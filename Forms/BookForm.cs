﻿using Biblioteka2.Classes;
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
    public partial class BookForm : Form
    {
        public BookForm()
        {
            InitializeComponent();
            UpdateCombo();
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
        }

        private void bt_update_Click(object sender, EventArgs e)
        {
            dgv_books.Rows.Clear();
            foreach (BookClass book in DbModel.init().Books.Include(b => b.publisher).Include(b => b.type).Include(b=>b.Authors)) {
                dgv_books.Rows.Add(book.name_book, String.Join(", ", book.Authors), book.publisher.ToString(), book.type.ToString(), book.publishing_year, book.publishing_year);
            }
        }

        private void bt_add_autor_Click(object sender, EventArgs e)
        {
            lb_author.Items.Add(cb_Author.SelectedItem);
            cb_Author.Items.Remove(cb_Author.SelectedItem);
        }
    }
}
