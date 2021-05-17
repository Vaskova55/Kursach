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
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
            UpdateCombo();
            updatData();
        }

        private void bt_addtype_Click(object sender, EventArgs e)
        {
            DbModel.init().Types.Add(new TypeClass { type = tb_type.Text });
            DbModel.init().SaveChanges();
        }

        private void bt_add_publisher_Click(object sender, EventArgs e)
        {
            DbModel.init().Publishers.Add(new PublisherClass { city = tb_publisher_city.Text, name = tb_publisher_name.Text });
            DbModel.init().SaveChanges();
        }

        private void UpdateCombo() {
            cb_publisher.Items.Clear();
            cb_type.Items.Clear();
            cb_Author.Items.Clear();
            cb_publisher.Items.AddRange(DbModel.init().Publishers.ToArray());
            cb_type.Items.AddRange(DbModel.init().Types.ToArray());
            cb_Author.Items.AddRange(DbModel.init().Authors.ToArray());
        }

        private void bt_refresh_Click(object sender, EventArgs e)
        {
            UpdateCombo();
            updatData();
        }

        private void updatData()
        {
            dgv_books.Rows.Clear();
            foreach (BookClass book in DbModel.init().Books.Include(b => b.publisher).Include(b => b.type).Include(b => b.Authors))
            {
                int r = dgv_books.Rows.Add(
                    book.name_book,
                    String.Join(", ", book.Authors),
                    book.publisher.ToString(),
                    book.type.ToString(),
                    book.publishing_year,
                    book.publishing_year);
                    dgv_books.Rows[r].Tag = book;
            }
        }

        private void bt_add_autor_Click(object sender, EventArgs e)
        {
            lb_author.Items.Add(cb_Author.SelectedItem);
            cb_Author.Items.Remove(cb_Author.SelectedItem);
        }

        private void Ok_AddBook_Click(object sender, EventArgs e)
        {

        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (dgv_books.Rows.Count > 0)
            {
                BookClass book = dgv_books.Rows[0].Tag as BookClass;
                DbModel.init().Books.Remove(book);
                DbModel.init().SaveChanges();
                updatData();
            }
        }
    }
}
