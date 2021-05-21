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
    public partial class SearchTrainessForm : Form
    {
        public SearchTrainessForm()
        {
            InitializeComponent();
            updatData();
        }
        private void updatData()
        {
            dgv_SearchTrainess.Rows.Clear();
            foreach (IssuanceClass issuance in DbModel.init().Issuances.Include(i => i.trainess).Include(i => i.literature).Include(i => i.literature.book)
                .Where(
                i => i.trainess.family_name.StartsWith(tb_FamillySearchTrainess.Text) ||
                i.trainess.first_name.StartsWith(tb_NameSearchTrainess.Text)
                ))
            {
                int r = dgv_SearchTrainess.Rows.Add(
                    issuance.trainess.classTrainess.ToString(),
                    issuance.trainess.family_name.ToString(),
                    issuance.trainess.first_name.ToString(),
                    issuance.literature.book.name_book.ToString(),
                    issuance.literature.book.Authors.ToString(),
                    issuance.date_of_issue,
                    issuance.date_of_realreturn
                    );
            }
        }

        private void tb_NameSearchTrainess_TextChanged(object sender, EventArgs e)
        {
            updatData();
        }

        private void tb_FamillySearchTrainess_TextChanged(object sender, EventArgs e)
        {
            updatData();
        }

        private void SearchTrainessForm_Load(object sender, EventArgs e)
        {
            CheckBox cb_SearchTrainess = new CheckBox();
            cb_SearchTrainess.Size = new Size(200, 42);
            cb_SearchTrainess.Text = "Проверить наличие долга по сданной литературе";
            pn_SearchTrainess.Controls.Add(cb_SearchTrainess);

            if (cb_SearchTrainess.Checked)
            {
                dgv_SearchTrainess.Rows.Clear();
                foreach (IssuanceClass issuance in DbModel.init().Issuances.Include(i => i.trainess).Include(i => i.literature).Include(i => i.literature.book)
                    .Where(i => i.date_of_realreturn > i.date_of_plan_return).Where((i => i.literature.status == LiteratureTurnoverClass.e_literature_state.remove)))
                {
                    int r = dgv_SearchTrainess.Rows.Add(
                        issuance.trainess.classTrainess.ToString(),
                        issuance.trainess.family_name.ToString(),
                        issuance.trainess.first_name.ToString(),
                        issuance.literature.book.name_book.ToString(),
                        issuance.literature.book.Authors.ToString(),
                        issuance.date_of_issue.ToString(),
                        issuance.date_of_realreturn.ToString());
                }
                updatData();
            }
        }
    }
}
