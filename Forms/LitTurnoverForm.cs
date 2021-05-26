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
    public partial class LitTurnoverForm : Form
    {
        public LitTurnoverForm()
        {
            InitializeComponent();
            updatData();
        }

        private void updatData()
        {
            dgv_LitTurnover.Rows.Clear();
            foreach (LiteratureTurnoverClass litTurnover in DbModel.init().LiteratureTurnover.Include(l => l.book).Include(l=>l.book.type).Include(l=>l.book.Authors).Include(l => l.purchaseAccounting)
                .Where(
                l => l.book.type.type.Contains(tb_SearchLitTurnover.Text) ||
                l.book.classnum.ToString().Contains(tb_SearchLitTurnover.Text) ||
                l.book.name_book.Contains(tb_SearchLitTurnover.Text) ||
                l.book.Authors.Any(a => a.family_name.StartsWith(tb_SearchLitTurnover.Text) || a.first_name.StartsWith(tb_SearchLitTurnover.Text) || a.middle_name.StartsWith(tb_SearchLitTurnover.Text)) ||
                l.book.publisher.name.StartsWith(tb_SearchLitTurnover.Text) ||
                l.book.publishing_year.ToString().Contains(tb_SearchLitTurnover.Text) ||
                l.purchaseAccounting.count.ToString().Contains(tb_SearchLitTurnover.Text) ||
                l.dateActivity.ToString().Contains(tb_SearchLitTurnover.Text) )
                )
            {
                int r = dgv_LitTurnover.Rows.Add(
                    litTurnover.book.type.type.ToString(),
                    litTurnover.book.classnum.ToString(),
                    litTurnover.book.name_book.ToString(),
                    litTurnover.book.Authors.ToString(),
                    litTurnover.book.publishing_year.ToString(),
                    litTurnover.purchaseAccounting.count.ToString()
                    );
                dgv_LitTurnover.Rows[0].Tag = litTurnover;
            }
        }

        private void Update_LitTurnover_Click(object sender, EventArgs e)
        {
            updatData();
        }

        private void Delete_LitTurnover_Click(object sender, EventArgs e)
        {
            if (dgv_LitTurnover.Rows.Count > 0)
            {
                LiteratureTurnoverClass litTurnover = dgv_LitTurnover.Rows[0].Tag as LiteratureTurnoverClass;
                DbModel.init().LiteratureTurnover.Remove(litTurnover);
                DbModel.init().SaveChanges();
                updatData();
            }
        }

        private void tb_SearchLitTurnover_TextChanged(object sender, EventArgs e)
        {
            updatData();
        }

        private void Add_LitTurnover_Click(object sender, EventArgs e)
        {
            AddLitTurnoverForm addLitTurnover = new AddLitTurnoverForm();
            addLitTurnover.ShowDialog();
        }
    }
}
