using Biblioteka2.Classes;
using Biblioteka2.Classes.Entityes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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

        private void Add_Library_Click(object sender, EventArgs e)
        {
            AddBookForm f_ab = new AddBookForm();
            f_ab.ShowDialog();
            DbModel.init().SaveChanges();
            updatData();
        }
        private void updatData()
        {
            dgv_Library.Rows.Clear();
            foreach (BookClass book in DbModel.init().Books.Include(b => b.publisher).Include(b => b.type).Include(b => b.Authors)
                .Where(
                    b=>b.name_book.Contains(tb_SearchLibrary.Text) ||
                    b.publisher.name.Contains(tb_SearchLibrary.Text) || 
                    b.classnum.ToString().Contains(tb_SearchLibrary.Text) || 
                    b.publishing_year.ToString().Contains(tb_SearchLibrary.Text) ||
                    b.type.type.Contains(tb_SearchLibrary.Text)
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

        }
    }
}
