using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteka2.Classes;
using Biblioteka2.Classes.Entityes;

namespace Biblioteka2.Forms
{
    public partial class AddIssuanceForm : Form
    {
        public AddIssuanceForm()
        {
            InitializeComponent();
            UpdateCombo();
        }

        private void UpdateCombo()
        {
            cb_FIOTrIssuance.Items.Clear();
            cb_LiteratureIssuance.Items.Clear();
            cb_FIOTrIssuance.Items.AddRange(DbModel.init().Trainesses.ToArray());
            cb_LiteratureIssuance.Items.AddRange(DbModel.init().Books.ToArray());
        }
        private void Ok_AddIssuance_Click(object sender, EventArgs e)
        {
            IssuanceClass issuance = new IssuanceClass
            {
                trainess = cb_FIOTrIssuance.SelectedItem as TrainessClass,
                book = cb_LiteratureIssuance.SelectedItem as BookClass,
                user = DbModel.init().Users.Where(u => u.access_level==1).FirstOrDefault(),
                date_of_issue = (DateTime)dtp_Issuance.Value,
            };

            DbModel.init().Issuances.Add(issuance);
            DbModel.init().SaveChanges();
            Hide();
        }
    }
}
