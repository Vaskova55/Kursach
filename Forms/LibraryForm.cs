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
    }
}
