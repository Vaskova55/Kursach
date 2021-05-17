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
            HashSet<BookClass> UniqueBooks = new HashSet<BookClass>();
            cb_LiteratureIssuance.Items.AddRange(DbModel.init().LiteratureTurnover.Include(l=>l.book).
                Where(l => l.status == LiteratureTurnoverClass.e_literature_state.storage && UniqueBooks.Add(l.book)).ToArray());
        }
        private void Ok_AddIssuance_Click(object sender, EventArgs e)
        {
            // LiteratureTurnoverClass literature = DbModel.init().Books.Where()
            IssuanceClass issuance = new IssuanceClass
            {
                trainess = cb_FIOTrIssuance.SelectedItem as TrainessClass,
                literature = cb_LiteratureIssuance.SelectedItem as LiteratureTurnoverClass,
                user = DbModel.init().Users.Where(u => u.access_level==1).FirstOrDefault(),
                date_of_issue = (DateTime)dtp_Issuance.Value,
            };

            DbModel.init().Issuances.Add(issuance);
            DbModel.init().SaveChanges();
            Close();
        }
    }
}
