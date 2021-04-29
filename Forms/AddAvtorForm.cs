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

        private void Ok_AddBook_Click(object sender, EventArgs e)
        {
            if (cb_noMiddle.Checked)
            {
                DbModel.init().Authors.Add(new AuthorClass { family_name = tb_lastname.Text, first_name = tb_firstname.Text});
                DbModel.init().SaveChanges();
                Hide();
            }
            else
            {
                DbModel.init().Authors.Add(new AuthorClass { family_name = tb_lastname.Text, first_name = tb_firstname.Text, middle_name = tb_middlename.Text });
                DbModel.init().SaveChanges();
                Hide();
            }
        }
    }
}
