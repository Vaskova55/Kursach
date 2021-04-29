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
    public partial class AuthorizationForm : Form
    {
        public AuthorizationForm()
        {
            InitializeComponent();
        }

        private void Ok_Autorization_Click(object sender, EventArgs e)
        {
            UserClass user = DbModel.init().Users.Where(u => u.login == tb_login.Text && u.password == tb_password.Text).FirstOrDefault();
            if (user != null)
            {
                if (user.access_level == 1)
                {
                    Home_page f_hp = new Home_page();
                    f_hp.Show();
                    Hide();
                }
            }
        }
    }
}
