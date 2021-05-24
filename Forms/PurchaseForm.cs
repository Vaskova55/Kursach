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
    public partial class PurchaseForm : Form
    {
        public PurchaseForm()
        {
            InitializeComponent();
            updatData();
        }

       private void updatData()
        {
            dgv_Purchase.Rows.Clear();
            foreach (LiteratureTurnoverClass purchaseBook in DbModel.init().LiteratureTurnover.Include(p => p.purchaseAccounting).Include(p => p.book)
                .Include(p => p.book.publisher).Include(p => p.purchaseAccounting.purchaseList).Where(
                p => p.book.classnum.ToString().Contains(tb_SearchPurchase.Text) ||
                p.book.name_book.Contains(tb_SearchPurchase.Text)||
                p.book.publisher.city.Contains(tb_SearchPurchase.Text) || p.book.publisher.name.Contains(tb_SearchPurchase.Text)||
                p.purchaseAccounting.price.ToString().Contains(tb_SearchPurchase.Text)||
                p.purchaseAccounting.count.ToString().Contains(tb_SearchPurchase.Text)||
                p.purchaseAccounting.purchaseList.datePurchase.ToString().Contains(tb_SearchPurchase.Text)
                )
                )
            {
                int r = dgv_Purchase.Rows.Add(
                   purchaseBook.purchaseAccounting.purchaseList.datePurchase.ToString(),
                   purchaseBook.book.classnum,
                   purchaseBook.book.name_book,
                   purchaseBook.book.publisher.ToString(),
                   purchaseBook.purchaseAccounting.price,
                   purchaseBook.purchaseAccounting.count,
                   purchaseBook.purchaseAccounting.count * purchaseBook.purchaseAccounting.price
                    ) ;

                dgv_Purchase.Rows[r].Tag = purchaseBook;
            }
        }
        private void Update_Purchase_Click(object sender, EventArgs e)
        {
            updatData();
        }

        private void Add_Purchase_Click(object sender, EventArgs e)
        {
            AddPurchaseForm f_ap = new AddPurchaseForm();
            f_ap.ShowDialog();
            //прописать обновление данных
        }

        private void tb_SearchPurchase_TextChanged(object sender, EventArgs e)
        {
            updatData();
        }

        private void bt_import_Purchase_Click(object sender, EventArgs e)
        {
            if (ofd_load_Purchase.ShowDialog() == DialogResult.OK)//Вызываем диалог выбора файла и проверяем, что полльзователь выбрал файл
            {
                DataTable table;
                if (ExcelClass.loadExcel(ofd_load_Purchase.FileName, out table))//Если загрузка данных(ИмяФайла,ТаблицаСРезультатом) прошел успешно
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
