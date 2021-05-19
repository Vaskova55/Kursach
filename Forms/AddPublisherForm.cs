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
    public partial class AddPublisherForm : Form
    {
        public AddPublisherForm()
        {
            InitializeComponent();
        }

        public AddPublisherForm(string city, string name)
        {
            InitializeComponent();

            tb_City.Text = city;
            tb_NamePublisher.Text = name;
            MessageBox.Show(String.Format("Автор с инициалами {0}. {1}. не найден.", city, name));
        }
        private void Ok_AddPublisher_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            DbModel.init().Publishers.Add(new PublisherClass
            {
                city = tb_City.Text,
                name = tb_NamePublisher.Text
            });
            DbModel.init().SaveChanges();
            Close();
        }
    }
}
