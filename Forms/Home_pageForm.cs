using Biblioteka2.Classes;
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
    public partial class Home_pageForm : Form
    {
        public Home_pageForm()
        {
            InitializeComponent();
        }

        private void tsmi1_Issuance_Click(object sender, EventArgs e)
        {
            FormManager.ChangeForm(new IssuanceForm());
        }

        private void tsmi2_Library_Click(object sender, EventArgs e)
        {

        }
    }
}
