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
                List<IssuanceClass> listIssuance = DbModel.init().Issuances.Include(i=>i.trainess).Include(i=>i.book).ToList();
                string[,] values = new string[listIssuance.Count + 1, 5];

                values[0, 0] = "Класс";
                values[0, 1] = "Фамилия";
                values[0, 2] = "Имя";
                values[0, 3] = "Издание";
                values[0, 4] = "Дата выдачи";

                {
                    for (int i = 0; i < listIssuance.Count; i++)
                    {
                        {
                            values[i + 1, 0] = listIssuance[i].trainess.classTrainess.ToString();
                            values[i + 1, 1] = listIssuance[i].trainess.family_name;
                            values[i + 1, 2] = listIssuance[i].trainess.first_name;
                            values[i+1,3] = listIssuance[i].book.name_book;
                            values[i+1, 4] = listIssuance[i].date_of_issue.ToString("F");

                        }
                    }
                    
                }
                ExcelClass.saveExcel(dialog.FileName, "Выдача", values);
            }
        }
    }
}