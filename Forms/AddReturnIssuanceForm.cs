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
    public partial class AddReturnIssuanceForm : Form
    {
        public AddReturnIssuanceForm()
        {
            InitializeComponent();
            updatCombo();
            updatList();
        }

        private void updatCombo()
        {
            cb_TrainessIssRet.Items.Clear();
            cb_TrainessIssRet.Items.AddRange(DbModel.init().Trainesses.Where(t => t.issuance.Any(i => i.date_of_realreturn == null)).ToArray());
        }

        private void updatList()
        {
            lb_RetLit.Items.Clear();
            lb_OkRetLit.Items.Clear();
            if (cb_TrainessIssRet.SelectedItem != null)
            {
                lb_RetLit.Items.Clear();
                int trainessId = (cb_TrainessIssRet.SelectedItem as TrainessClass).idTrainess;
                lb_RetLit.Items.AddRange(DbModel.init().Issuances.Include(i => i.literature)
                .Include(i => i.literature.book).Include(i => i.trainess)
                .Where(l => l.trainess.idTrainess == trainessId && l.date_of_realreturn == null).ToArray());
            }
        }

        private void bt_BooksReturn_Click(object sender, EventArgs e)
        {
            foreach (IssuanceClass issuance in lb_OkRetLit.Items)
            {
                issuance.date_of_realreturn = dtp_ReturnIssuance.Value;
                issuance.literature.status = LiteratureTurnoverClass.e_literature_state.storage;
            }
            DbModel.init().SaveChanges();
        }

        private void bt_PlusBookReturn_Click(object sender, EventArgs e)
        {
            lb_OkRetLit.Items.Add(lb_RetLit.SelectedItem);
            lb_RetLit.Items.Remove(lb_RetLit.SelectedItem);
        }

        private void bt_MinusBookReturn_Click(object sender, EventArgs e)
        {
            lb_RetLit.Items.Add(lb_OkRetLit.SelectedItem);
            lb_OkRetLit.Items.Remove(lb_OkRetLit.SelectedItem);
        }

        private void cb_TrainessIssRet_SelectedValueChanged(object sender, EventArgs e)
        {
            updatList();
        }
    }
}
