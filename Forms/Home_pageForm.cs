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
    public partial class Home_pageForm : Form
    {
        public Home_pageForm()
        {
            InitializeComponent();
            
        }

        private void LoaadTraines() {
            dgv_Home_page.Columns.Clear();
            dgv_Home_page.Rows.Clear();
            dgv_Home_page.Columns.Add("dg_tb_fio", "FIO");
            dgv_Home_page.Columns.Add("dg_tb_fio", "Book taked count");

            FillMode();

            foreach (TrainessClass tirain in DbModel.init().Trainesses.Include(t=>t.issuance).Where(t=>t.issuance.Any(i=>i.date_of_realreturn==null))){
                dgv_Home_page.Rows.Add(tirain.ToString(), tirain.issuance.Count(i => i.date_of_realreturn == null));
            }
        }

        public void FillMode() {
            for (int i=0; i<dgv_Home_page.Columns.Count; i++) {
                dgv_Home_page.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void LoaadDoljnik()
        {
            dgv_Home_page.Columns.Clear();
            dgv_Home_page.Rows.Clear();
            int c0 = dgv_Home_page.Columns.Add("dg_tb_fio", "FIO");
            int c1 = dgv_Home_page.Columns.Add("dg_tb_fio", "Book doljen count");

            FillMode();

            foreach (TrainessClass tirain in DbModel.init().Trainesses.Include(t => t.issuance)
                .Where(t => t.issuance.Any(i => i.date_of_realreturn == null && i.date_of_plan_return<DateTime.Now)))
            {
                dgv_Home_page.Rows.Add(
                    tirain.ToString(),
                    tirain.issuance.Count(i => i.date_of_realreturn == null && i.date_of_plan_return < DateTime.Now));
            }
        }

        public void LoaadLiterathure() {
            dgv_Home_page.Columns.Clear();
            dgv_Home_page.Rows.Clear();
            dgv_Home_page.Columns.Add("dg_tb_bookname", "Book name");
            dgv_Home_page.Columns.Add("dg_tb_count", "Book count");

            FillMode();

            foreach (BookClass book in DbModel.init().Books.Include(b => b.literatureTurnovers)
                .Where(b => b.literatureTurnovers.Any(l=>l.status == LiteratureTurnoverClass.e_literature_state.issuance)))
            {
                dgv_Home_page.Rows.Add(book.ToString(), book.literatureTurnovers.Count(l=>l.status == LiteratureTurnoverClass.e_literature_state.issuance));
            }
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

        private void Home_pageForm_Load(object sender, EventArgs e)
        {
            
        }

        private void ChangeSelected(object sender, EventArgs e)
        {
            if (rb_Dolg.Checked)
            {
                LoaadDoljnik();
            }
            else if (rb_Chitatel.Checked)
            {
                LoaadTraines();
            }
            else if (rb_IssLit.Checked)
            {
                LoaadLiterathure();
            }
        }
    }
}
