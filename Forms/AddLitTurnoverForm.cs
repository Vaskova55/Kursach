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
    public partial class AddLitTurnoverForm : Form
    {
        public AddLitTurnoverForm()
        {
            InitializeComponent();
            updatCombo();
        }
        private void updatCombo()
        {
            cb_LiteratureSpisanie.Items.Clear();
            cb_LiteratureSpisanie.Items.AddRange(DbModel.init().Books.Include(l => l.literatureTurnovers).ToArray());
        }

        private void updatList()
        {
            lb_ListSpisanie.Items.Clear();
          //  lb_ListSpisanie.Items.AddRange(DbModel.init().Books.Include(b => b.literatureTurnovers).Where(b => b.publishing_year == DateTime.Now.AddMonths(-5)).ToArray());
        }

        private void bt_BooksReturn_Click(object sender, EventArgs e)
        {

        }
    }
}
