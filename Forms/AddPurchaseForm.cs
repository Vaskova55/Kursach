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
    public partial class AddPurchaseForm : Form
    {
        public AddPurchaseForm()
        {
            InitializeComponent();
            updateCombo();
        }

        public AddPurchaseForm(PurchaseListClass purchaseList)
        {
            InitializeComponent();
            updateCombo();
            foreach (PurchaseAccountingClass purchaseAccounting in purchaseList.purchaseAccountings) {
                int r = dgv_PurchaseList.Rows.Add(purchaseAccounting.literatureTurnover.First().book.ToString(), purchaseAccounting.count, purchaseAccounting.price, purchaseAccounting.count*purchaseAccounting.price);
                dgv_PurchaseList.Rows[r].Tag = purchaseAccounting;
            }
            dtp_datePurchase.Value = purchaseList.datePurchase;
            updateResult();
        }

        private void updateCombo()
        {
            cb_BookPurchase.Items.Clear();
            cb_BookPurchase.Items.AddRange(DbModel.init().Books.Include(b=>b.literatureTurnovers).ToArray());
        }
        private void Ok_AddPurchase_Click(object sender, EventArgs e)
        {
            if ( dgv_PurchaseList.Rows.Count>0)
            {
                List<PurchaseAccountingClass> purchaseAccountings = new List<PurchaseAccountingClass>();
                foreach (DataGridViewRow row in dgv_PurchaseList.Rows)
                {
                    purchaseAccountings.Add(row.Tag as PurchaseAccountingClass);
                }
                PurchaseListClass purchaseList = new PurchaseListClass
                {
                    datePurchase = dtp_datePurchase.Value,
                    purchaseAccountings = purchaseAccountings
                };
                DbModel.init().PurchaseLists.Add(purchaseList);
                DbModel.init().SaveChanges();
                Close();
            }
            else
            {
                MessageBox.Show("Пожалуйста, проверьте на заполненность всех полей");
            }
        }

        private void cb_NotBook_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_NotBook.Checked)
            {
                AddBookForm f_ab = new AddBookForm();
                f_ab.ShowDialog();
                cb_NotBook.Checked = false;
                updateCombo();
            }
        }

        private void updateResult() {
            int countBook = 0;
            decimal pricebooks = 0; 
            foreach (DataGridViewRow row in dgv_PurchaseList.Rows)
            {
                PurchaseAccountingClass purchase = row.Tag as PurchaseAccountingClass;
                countBook += purchase.count;
                pricebooks += purchase.price * purchase.count;                
            }

            dgv_ResultPurchaseList.Rows.Clear();
            dgv_ResultPurchaseList.Rows.Add(countBook, pricebooks);
        }

        private void bt_PlusBookListPurchase_Click(object sender, EventArgs e)
        {
            //Заполнение таблицы про закупку одной книги
            PurchaseAccountingClass purchaseAccounting = new PurchaseAccountingClass
            {
                price = Convert.ToDecimal(tb_PricePurchase.Text),
                count = Convert.ToInt32(tb_CountPurchase.Text),

            };
            //
            purchaseAccounting.literatureTurnover = LiteratureTurnoverClass.addNewLitherature(cb_BookPurchase.SelectedItem as BookClass, purchaseAccounting.count);
            //выадим в dgv информацию о закупаемой книге: количество, цену, стоимость
            int r = dgv_PurchaseList.Rows.Add((cb_BookPurchase.SelectedItem as BookClass).ToString(), purchaseAccounting.count, purchaseAccounting.price, (purchaseAccounting.count * purchaseAccounting.price));
            //получаем тег строки (её номер)
            dgv_PurchaseList.Rows[r].Tag = purchaseAccounting;

            updateResult();
        }

        private void bt_MinusBookListPurchase_Click(object sender, EventArgs e)
        {
            //удаление строки из dgv
            if (dgv_PurchaseList.SelectedRows.Count > 0)
            {
                dgv_PurchaseList.Rows.Remove(dgv_PurchaseList.SelectedRows[0]);
            }
        }



        /*PurchaseAccountingClass purchase = new PurchaseAccountingClass
            {
                count = (int)nud_AddPurchase.Value,
                price = Convert.ToDecimal (tb_PricePurchase.Text),
            };
            DbModel.init().Purchase.Add(purchase);
            */
    }
}
