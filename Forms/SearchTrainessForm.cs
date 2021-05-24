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

            foreach (IssuanceClass issuance in DbModel.init().Issuances.Include(i => i.trainess).Include(i => i.literature).Include(i => i.literature.book).Include(i => i.literature.book.Authors)
                .Where(
                i => i.trainess.family_name.StartsWith(tb_FamillySearchTrainess.Text) &&
                i.trainess.first_name.StartsWith(tb_NameSearchTrainess.Text)
                ))
            {
                int r = dgv_SearchTrainess.Rows.Add(
                    issuance.trainess.classTrainess,
                    issuance.trainess.family_name,
                    issuance.trainess.first_name,
                    issuance.literature.book.name_book,
                    String.Join(", ", issuance.literature.book.Authors),
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
    }
}
