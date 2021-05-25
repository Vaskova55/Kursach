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

        private void LoaadTraines()
        {
            dgv_Home_page.Columns.Clear();
            dgv_Home_page.Rows.Clear();
            dgv_Home_page.Columns.Add("dg_tb_fio", "FIO");
            dgv_Home_page.Columns.Add("dg_tb_fio", "Book taked count");

            FillMode();

            foreach (TrainessClass tirain in DbModel.init().Trainesses.Include(t=>t.issuance).Where(t=>t.issuance.Any(i=>i.date_of_realreturn==null)))
            {
                dgv_Home_page.Rows.Add(tirain.ToString(), tirain.issuance.Count(i => i.date_of_realreturn == null));
            }
        }

        public void FillMode()
        {
            for (int i=0; i<dgv_Home_page.Columns.Count; i++)
            {
                dgv_Home_page.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void LoaadDoljnik()
        {
            dgv_Home_page.Columns.Clear();
            dgv_Home_page.Rows.Clear();
            int c0 = dgv_Home_page.Columns.Add("dg_tb_fio", "Фамилия/Имя");
            int c1 = dgv_Home_page.Columns.Add("dg_tb_fio", "Количество задолженных книг");

            FillMode();

            foreach (TrainessClass tirain in DbModel.init().Trainesses.Include(t => t.issuance)
                .Where(t => t.issuance.Any(i => i.date_of_realreturn == null && i.date_of_plan_return<DateTime.Now)))
            {
                dgv_Home_page.Rows.Add(
                    tirain.ToString(),
                    tirain.issuance.Count(i => i.date_of_realreturn == null && i.date_of_plan_return < DateTime.Now));
            }
        }

        public void LoaadLiterathure()
        {
            dgv_Home_page.Columns.Clear();
            dgv_Home_page.Rows.Clear();
            dgv_Home_page.Columns.Add("dg_tb_bookname", "Название книги");
            dgv_Home_page.Columns.Add("dg_tb_count", "Количество");

            FillMode();

            foreach (BookClass book in DbModel.init().Books.Include(b => b.literatureTurnovers)
                .Where(b => b.literatureTurnovers.Any(l=>l.status == LiteratureTurnoverClass.e_literature_state.issuance)))
            {
                dgv_Home_page.Rows.Add(book.ToString(), book.literatureTurnovers.Count(l=>l.status == LiteratureTurnoverClass.e_literature_state.issuance));
            }
        }

        public void PoiskIstoriiLit()
        {
            dgv_Home_page.Columns.Clear();
            dgv_Home_page.Rows.Clear();
            dgv_Home_page.Columns.Add("dg_tb_bookname", "Название книги");
            dgv_Home_page.Columns.Add("dg_tb_dateIssuance", "Дата выдачи");
            dgv_Home_page.Columns.Add("dg_tb_dateReturn", "Дата возврата");
            dgv_Home_page.Columns.Add("dg_tb_TrainessIssuance", "Обучающийся");

            FillMode();

            foreach (IssuanceClass issuance in DbModel.init().Issuances.Include(i => i.literature).Include(i => i.literature.book).Include(i => i.literature.book.Authors).Include(i => i.trainess) 
                .Where(i => i.literature.book.name_book.StartsWith(tb_NameBook.Text)
                || i.literature.book.Authors.Any(a => a.family_name.StartsWith(tb_Avtor.Text) || a.first_name.StartsWith(tb_Avtor.Text) || a.middle_name.StartsWith(tb_Avtor.Text))))
            {
                dgv_Home_page.Rows.Clear();
                dgv_Home_page.Rows.Add(issuance.literature.book.ToString(), issuance.date_of_issue, issuance.date_of_realreturn, issuance.trainess);
            }
        }

        private void tsmi1_Issuance_Click(object sender, EventArgs e)
        {
            IssuanceForm f_i = new IssuanceForm();
            f_i.ShowDialog();
        }

        private void tsmi2_Library_Click(object sender, EventArgs e)
        {
            LibraryForm f_lf = new LibraryForm();
            f_lf.ShowDialog();
        }

        private void tsmi3_Treiness_Click(object sender, EventArgs e)
        {
            TrainessesForm f_t = new TrainessesForm();
            f_t.ShowDialog();
        }

        private void tsmi4_LiteratureTurnover_Click(object sender, EventArgs e)
        {

            LitTurnoverForm f_lt = new LitTurnoverForm();
            f_lt.ShowDialog();
        }

        private void tsmi5_Accounting_book_Click(object sender, EventArgs e)
        {
            PurchaseForm f_p = new PurchaseForm();
            f_p.ShowDialog();
        }

        private void tsmi6_Exit_Click(object sender, EventArgs e)
        {
            FormManager.ChangeForm(new AuthorizationForm());
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

        private void tb_Avtor_TextChanged(object sender, EventArgs e)
        {
            PoiskIstoriiLit();
        }

        private void tb_NameBook_TextChanged(object sender, EventArgs e)
        {
            PoiskIstoriiLit();
        }
    }
}
