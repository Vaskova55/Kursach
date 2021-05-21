using Biblioteka2.Classes;
using Biblioteka2.Classes.Entityes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteka2.Forms
{
    public partial class LibraryForm : Form
    {
        public LibraryForm()
        {
            InitializeComponent();
            updatData();
        }

        private void updatData()
        {
            dgv_Library.Rows.Clear();
            foreach (BookClass book in DbModel.init().Books.Include(b => b.publisher).Include(b => b.type).Include(b => b.Authors).Include(b => b.literatureTurnovers)
                .Where(
                    b => b.name_book.StartsWith(tb_SearchLibrary.Text) ||
                    b.publisher.name.StartsWith(tb_SearchLibrary.Text) ||
                    b.classnum.ToString().StartsWith(tb_SearchLibrary.Text) ||
                    b.publishing_year.ToString().StartsWith(tb_SearchLibrary.Text) ||
                    b.type.type.StartsWith(tb_SearchLibrary.Text) ||
                    b.Authors.Any(a => a.family_name.StartsWith(tb_SearchLibrary.Text) || a.first_name.StartsWith(tb_SearchLibrary.Text) || a.middle_name.StartsWith(tb_SearchLibrary.Text))
                )
            )
            {
                int r = dgv_Library.Rows.Add(
                    book.type.ToString(),
                    book.classnum,
                    book.name_book,
                    String.Join(", ", book.Authors),
                    book.publisher.ToString(),
                    book.publishing_year
                );
                dgv_Library.Rows[r].Tag = book;
            }
        }

        private void Edit_Library_Click(object sender, EventArgs e)
        {
            if (dgv_Library.SelectedRows.Count > 0)
            {
                AddBookForm f_ab = new AddBookForm(dgv_Library.SelectedRows[0].Tag as BookClass);
                f_ab.ShowDialog();
                updatData();
            }
        }

        private void Delete_Library_Click(object sender, EventArgs e)
        {
            if (dgv_Library.Rows.Count > 0)
            {
                BookClass book = dgv_Library.Rows[0].Tag as BookClass;
                DbModel.init().Books.Remove(book);
                DbModel.init().SaveChanges();
                updatData();
            }
        }

        private void Update_Library_Click(object sender, EventArgs e)
        {
            updatData();
        }

        private void Export_Library_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Файлы excel|*.xlsx";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                List<BookClass> listBook = DbModel.init().Books.Include(b => b.publisher).Include(b => b.type).Include(b => b.Authors).ToList();
                string[,] values = new string[listBook.Count + 1, 6];

                values[0, 0] = "Тип";
                values[0, 1] = "Класс";
                values[0, 2] = "Название";
                values[0, 3] = "Автор";
                values[0, 4] = "Издательство";
                values[0, 5] = "Год публикации";

                {
                    for (int i = 0; i < listBook.Count; i++)
                    {
                        {
                            values[i + 1, 0] = listBook[i].type.type;
                            values[i + 1, 1] = listBook[i].classnum.ToString();
                            values[i + 1, 2] = listBook[i].name_book;
                            values[i + 1, 3] = listBook[i].Authors.ToString();
                            values[i + 1, 4] = listBook[i].publisher.ToString();
                            values[i + 1, 5] = listBook[i].publishing_year.ToString();

                        }
                    }

                }
                ExcelClass.saveExcel(dialog.FileName, "Книги", values);
            }
        }

        private void tb_SearchLibrary_TextChanged(object sender, EventArgs e)
        {
            updatData();
        }

        private void Add_Library_Click_1(object sender, EventArgs e)
        {
            AddBookForm f_ab = new AddBookForm();
            f_ab.ShowDialog();
            updatData();
        }

        private void bt_import_Library_Click(object sender, EventArgs e)
        {
            //
            if (ofd_load_Library.ShowDialog() == DialogResult.OK)//Вызываем диалог выбора файла и проверяем, что полльзователь выбрал файл
            {
                DataTable table;
                if (ExcelClass.loadExcel(ofd_load_Library.FileName, out table))//Если загрузка данных(ИмяФайла,ТаблицаСРезультатом) прошел успешно
                {
                    PurchaseListClass purchaseList = new PurchaseListClass { datePurchase = DateTime.Now };
                    foreach (DataRow row in table.Rows)//перебираем полученные строки
                    {
                        StringBuilder builder = new StringBuilder();
                        //Проверка на наличие такого типа литературы с такими данными
                        string typename = row["Тип"].ToString();
                        TypeClass type = DbModel.init().Types.Where(t =>
                            t.type == typename).FirstOrDefault();

                        //Если книга не существует, то выдается сообщение об ошибке 
                        if (type == null)
                        {
                            type = new TypeClass { type = Convert.ToString(typename) };
                        }

                        //проверка на наличие авторов в базе
                        List<AuthorClass> authors = new List<AuthorClass>();
                        //разделение авторов сначала на двух разных, а затем каждого на инициалы
                        string FIO_Authors = Convert.ToString(row["Автор"]);
                        string[] split_Author = FIO_Authors.Split(',');
                        //перебираем инициаллы
                        foreach (string strF_IO in split_Author)
                        {
                            string[] F_I_O = strF_IO.Split(' ', '.');
                            AuthorClass author = null;
                            string fam = F_I_O[0], name = F_I_O[1], otch = F_I_O[2];
                            //сравниваем инициалы на наличие соотношениий в базе. Инициалы И.О. сверяются с первыми бууквами значений. 
                            author = DbModel.init().Authors.Where(a => a.family_name.StartsWith(fam) && a.first_name.StartsWith(name) && a.middle_name.StartsWith(otch)).FirstOrDefault();
                            //если такой автор в базе найден, то.....

                            if (author != null)
                            {
                                //в класс (таблицу) автора добавляется новой значение
                                authors.Add(author);
                            }
                            else
                            {
                                //если данные не найдены, то открывается форма "AddAvtor" для того, чтобы пользователь расшифровал значение.
                                //От формы данные добавляются в базу
                                AddAvtorForm addAvtor = new AddAvtorForm(fam, name, otch);
                                if (addAvtor.ShowDialog() != DialogResult.OK)
                                {
                                    builder.AppendLine(String.Format("Fio author {0} not found!", strF_IO));
                                }
                                else
                                {
                                    author = addAvtor.GetAuthor();
                                    authors.Add(author);
                                }
                            }
                        }



                        //Проверка на наличие издательства с такими данными. !!!!!!!!!Действия схожи с данными об авторах!!!!!!!
                        List<PublisherClass> publishers = new List<PublisherClass>();
                        string publicher_str = Convert.ToString(row["Издательство"]);
                        string[] split_publisher = publicher_str.Split(':');
                        PublisherClass publisher = null;
                        string publisher_name = split_publisher[1], publisher_city = split_publisher[0];
                        publisher = DbModel.init().Publishers.Where(p =>
                            p.city.StartsWith(publisher_city) && p.name.StartsWith(publisher_name)).FirstOrDefault();
                        if (publisher != null)
                        {
                            publishers.Add(publisher);
                        }
                        else
                        {
                            AddPublisherForm addPublisher = new AddPublisherForm(publisher_city, publisher_name);
                            if (addPublisher.ShowDialog() != DialogResult.OK)
                            {
                                builder.AppendLine(String.Format("Издательство не найдено!", publicher_str));
                            }
                            else
                            {
                                publisher = addPublisher.GetPublisher();
                                publishers.Add(publisher);
                            }
                        }


                        //Проверка на наличие данной литературы
                        BookClass book = null;
                        string bookname = row["Название"].ToString();
                        int? bookclassnum = null;
                        try
                        {
                            bookclassnum = Convert.ToInt32(row["Класс"]);
                        }
                        catch { }
                        book = DbModel.init().Books.Include(b => b.publisher).Include(b => b.type).Include(b => b.Authors)
                            .Where(b =>
                               b.classnum == bookclassnum &&
                               b.name_book == bookname &&
                               b.publisher.idPublisher == publisher.idPublisher &&
                               b.type.idType == type.idType
                            ).FirstOrDefault();

                        if (book == null)
                        {
                            AddBookForm addBook = new AddBookForm(bookclassnum, bookname, publisher, type, authors);
                            if (addBook.ShowDialog() != DialogResult.OK)
                            {
                                builder.AppendLine(String.Format("Литература не найдена!", bookname));
                            }
                            book = addBook.GetBook();
                        }

                        int Litheraturecount = Convert.ToInt32(row["Количество"]);
                        purchaseList.purchaseAccountings.Add(
                            new PurchaseAccountingClass
                            {

                                count = Litheraturecount,
                                price = Convert.ToDecimal(row["Цена"]),
                                literatureTurnover = LiteratureTurnoverClass.addNewLitherature(book, Litheraturecount)
                            }
                        );
                    }
                    AddPurchaseForm addPurchase = new AddPurchaseForm(purchaseList);
                    addPurchase.ShowDialog();
                    MessageBox.Show("Boooozhe! ONO RABOTAET!");
                }
            }
        }
    }
}
