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
    public partial class PurchaseForm : Form
    {
        public PurchaseForm()
        {
            InitializeComponent();
            updatData();
        }

       private void updatData()
        {
            dgv_Purchase.Rows.Clear();
            foreach (LiteratureTurnoverClass purchaseBook in DbModel.init().LiteratureTurnover.Include(p => p.purchaseAccounting).Include(p => p.book)
                .Include(p => p.book.publisher).Include(p => p.purchaseAccounting.purchaseList).Where(
                p => p.book.classnum.ToString().Contains(tb_SearchPurchase.Text) ||
                p.book.name_book.Contains(tb_SearchPurchase.Text)||
                p.book.publisher.city.Contains(tb_SearchPurchase.Text) || p.book.publisher.name.Contains(tb_SearchPurchase.Text)||
                p.purchaseAccounting.price.ToString().Contains(tb_SearchPurchase.Text)||
                p.purchaseAccounting.count.ToString().Contains(tb_SearchPurchase.Text)||
                p.purchaseAccounting.purchaseList.datePurchase.ToString().Contains(tb_SearchPurchase.Text)
                )
                )
            {
                int r = dgv_Purchase.Rows.Add(
                   purchaseBook.purchaseAccounting.purchaseList.datePurchase.ToString(),
                   purchaseBook.book.classnum,
                   purchaseBook.book.name_book,
                   purchaseBook.book.publisher.ToString(),
                   purchaseBook.purchaseAccounting.price,
                   purchaseBook.purchaseAccounting.count,
                   purchaseBook.purchaseAccounting.count * purchaseBook.purchaseAccounting.price
                    ) ;

                dgv_Purchase.Rows[r].Tag = purchaseBook;
            }
        }
        private void Update_Purchase_Click(object sender, EventArgs e)
        {
            updatData();
        }

        private void Add_Purchase_Click(object sender, EventArgs e)
        {
            AddPurchaseForm f_ap = new AddPurchaseForm();
            f_ap.ShowDialog();
            //прописать обновление данных
        }

        private void tb_SearchPurchase_TextChanged(object sender, EventArgs e)
        {
            updatData();
        }
    }
}
