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
            FormManager.ChangeForm(new LibraryForm());
        }

        private void tsmi3_Treiness_Click(object sender, EventArgs e)
        {
            FormManager.ChangeForm(new TrainessesForm());
        }

        private void tsmi4_LiteratureTurnover_Click(object sender, EventArgs e)
        {
            FormManager.ChangeForm(new LitTurnoverForm());
        }

        private void tsmi5_Accounting_book_Click(object sender, EventArgs e)
        {
            FormManager.ChangeForm(new PurchaseForm());
        }

        private void tsmi6_Exit_Click(object sender, EventArgs e)
        {
            FormManager.ChangeForm(new AuthorizationForm());
            Close();        
        }
    }
}
