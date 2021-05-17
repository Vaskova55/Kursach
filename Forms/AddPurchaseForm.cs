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
    public partial class AddPurchaseForm : Form
    {
        public AddPurchaseForm()
        {
            InitializeComponent();
        }

        private void Ok_AddPurchase_Click(object sender, EventArgs e)
        {
            PurchaseAccountingClass purchase = new PurchaseAccountingClass
            {
                count = (int)nud_AddPurchase.Value,
                price = Convert.ToDecimal (tb_AddPurchase.Text),
            };
            DbModel.init().Purchase.Add(purchase);
            DbModel.init().SaveChanges();
            Close();
        }
    }
}
