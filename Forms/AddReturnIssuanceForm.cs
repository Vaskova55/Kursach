using Biblioteka2.Classes;
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
            UpdatCombo();
        }
        private void UpdatCombo()
        {
          /*  cb_TrainessReturnIs.Items.Clear();
            cb_TrainessReturnIs.Items.AddRange(DbModel.init().Issuances.Include(i => i.trainess).Where(i => i.trainess==4)).FirstOrDefault();*/
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
