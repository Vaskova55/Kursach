using Biblioteka2.Classes;
using Biblioteka2.Classes.Entityes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteka2.Forms
{
    public partial class AddBookForm : Form
    {
        public AddBookForm()
        {
            InitializeComponent();
            UpdateCombo();
        }
        private BookClass bookEdited;

        public AddBookForm(BookClass bookEdit)
        {
            this.bookEdited = bookEdit;
            InitializeComponent();
            UpdateCombo();

            if (bookEdit.classnum == null)
            {
                NUD_Class.Enabled = false;
                cb_NoUchLit.Checked = true;
            }
            else
            {
                cb_NoUchLit.Checked = true;
                NUD_Class.Value = (decimal)bookEdit.classnum;
            }
            
            tb_bookname.Text = bookEdit.name_book;
            NUD_Year.Value = bookEdit.publishing_year;
            cb_type.SelectedItem = bookEdit.type;
            cb_publisher.SelectedItem = bookEdit.publisher;
            lb_author.Items.AddRange(bookEdit.Authors.ToArray());
        }
        private void UpdateCombo()
        {
            cb_publisher.Items.Clear();
            cb_type.Items.Clear();
            cb_Author.Items.Clear();
            cb_publisher.Items.AddRange(DbModel.init().Publishers.ToArray());
            cb_type.Items.AddRange(DbModel.init().Types.ToArray());
            cb_Author.Items.AddRange(DbModel.init().Authors.ToArray());
        }

        private void Ok_AddBook_Click(object sender, EventArgs e) //добавление книги
        {
            if (NUD_Class.Value > 0 && tb_bookname.TextLength > 0 && NUD_Year.Value > 0 && cb_type.SelectedItem != null && cb_publisher.SelectedItem != null && lb_author.Items != null)
            {
                if (bookEdited == null)
                {
                    BookClass book = new BookClass
                    {
                        name_book = tb_bookname.Text,
                        classnum = (int)NUD_Class.Value,
                        publishing_year = (Int16)NUD_Year.Value,
                        type = cb_type.SelectedItem as TypeClass,
                        publisher = cb_publisher.SelectedItem as PublisherClass
                    };
                    foreach (AuthorClass author in lb_author.Items) //перебор авторов и заполнение CheckBox
                    {
                        book.Authors.Add(author);
                    }
                    DbModel.init().Books.Add(book); //добавление книги
                    DbModel.init().SaveChanges();
                    Close();
                }
                else
                { //редактирование книги
                    if (cb_NoUchLit.Checked)
                    {
                        NUD_Class.Enabled = false;
                    }
                    else
                    {
                        NUD_Class.Enabled = true;
                    }
                    bookEdited.name_book = tb_bookname.Text;
                    bookEdited.classnum = (int)NUD_Class.Value;
                    bookEdited.publishing_year = (Int16)NUD_Year.Value;
                    bookEdited.type = cb_type.SelectedItem as TypeClass;
                    bookEdited.publisher = cb_publisher.SelectedItem as PublisherClass;
                    bookEdited.Authors.Clear();
                    foreach (AuthorClass author in lb_author.Items) //перебор авторов и заполнение CheckBox
                    {
                        bookEdited.Authors.Add(author);
                    }
                    DbModel.init().SaveChanges();
                    Close();
                }
            }
        }

        private void cb_NoAvtor_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_NoAvtor.Checked)
            {
                AddAvtorForm f_a = new AddAvtorForm();
                f_a.ShowDialog();
                cb_NoAvtor.Checked = false;
                UpdateCombo();
            }
        }

        private void bt_add_autor_Click(object sender, EventArgs e)
        {
            lb_author.Items.Add(cb_Author.SelectedItem);
            cb_Author.Items.Remove(cb_Author.SelectedItem);
        }

        private void cb_uchLit_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_NoUchLit.Checked)
            {
                NUD_Class.Enabled = false;
            }
            else {
                NUD_Class.Enabled = true;
            }
        }

        private void AddBookForm_Load(object sender, EventArgs e)
        {
            AddPurchaseForm f_p = new AddPurchaseForm();
            f_p.ShowDialog();
        }
    }
}
