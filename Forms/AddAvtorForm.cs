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
    public partial class AddAvtorForm : Form
    {
        public AddAvtorForm()
        {
            InitializeComponent();
        }

        public AddAvtorForm(string family_name, string first_name, string middle_name)
        {
            InitializeComponent();

            tb_lastname.Text = family_name;
            tb_firstname.Text = first_name;
            tb_middlename.Text = middle_name;

            MessageBox.Show(String.Format("Автор с инициалами {0}. {1}. {2}. не найден.", family_name, first_name, middle_name));
        }

        private void Ok_AddBook_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            if (cb_noMiddle.Checked)
            {
                DbModel.init().Authors.Add(new AuthorClass { family_name = tb_lastname.Text, first_name = tb_firstname.Text});
                DbModel.init().SaveChanges();
                Close();
            }
            else
            {
                DbModel.init().Authors.Add(new AuthorClass { family_name = tb_lastname.Text, first_name = tb_firstname.Text, middle_name = tb_middlename.Text });
                DbModel.init().SaveChanges();
                Close();
            }
        }
    }
}
