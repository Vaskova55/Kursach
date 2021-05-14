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
    public partial class IssuanceForm : Form
    {
        public IssuanceForm()
        {
            InitializeComponent();
        }

        private void Export_Issuance_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Файлы excel|*.xlsx";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                List<IssuanceClass> listIssuance = DbModel.init().Issuances.ToList();
                List<TrainessClass> listTrainesses = DbModel.init().Trainesses.ToList();
                List<BookClass> listBooks = DbModel.init().Books.ToList();
                string[,] values = new string[listIssuance.Count + 1, 5];

                values[0, 0] = "Класс";
                values[0, 1] = "Фамилия";
                values[0, 2] = "Имя";
                values[0, 3] = "Издание";
                values[0, 4] = "Дата выдачи";

                foreach (IssuanceClass issuance in DbModel.init().Issuances.Include(b => b.trainess).Include(b => b.book).Include(b => b.user))
                {
                    for (int i = 0; i < listIssuance.Count; i++)
                    {
                        values[i + 1, 0] = listTrainesses[i].issuance..ToString();
                        values[i + 1, 1] = listTrainesses[i].family_name;
                        values[i + 1, 2] = listTrainesses[i].first_name;
                    }
                    for (int i = 0; i < listIssuance.Count; i++)
                    {
                        values[i + 1, 3] = listBooks[i].name_book;
                    }
                    for (int i = 0; i < listIssuance.Count; i++)
                    {
                        values[i + 1, 3] = listIssuance[i].date_of_issue.ToString();
                    }
                }
                ExcelClass.saveExcel(dialog.FileName, "Выдача", values);
            }
        }
    }
}