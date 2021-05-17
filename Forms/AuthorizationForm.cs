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
            //вызов метода авторизации и открытие формы
            if (Authmanager.Auth(tb_login.Text, tb_password.Text))
            {
                Authmanager.MenuMenu();
            }
        }
    }
}
