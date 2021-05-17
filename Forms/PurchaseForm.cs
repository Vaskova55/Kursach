using Biblioteka2.Classes;
using Biblioteka2.Classes.Entityes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteka2.Forms
{
    public partial class PurchaseForm : Form
    {
        public PurchaseForm()
        {
            InitializeComponent();
        }

       /* private void updatData()
        {
            dgv_Purchase.Rows.Clear();
            foreach (PurchaseAccountingClass purchase in DbModel.init().Purchase.Include(p => p.literatureTurnover.book).Where()
            {
                int p = dgv_Purchase.Rows.Add(
                    purchase.literatureTurnover.book.ToString()
                    )
            }
        }*/
        private void Update_Purchase_Click(object sender, EventArgs e)
        {

        }
    }
}
