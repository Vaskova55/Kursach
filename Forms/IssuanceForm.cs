using Biblioteka2.Classes;
using Biblioteka2.Classes.Entityes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
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

        private void bt_Import_Issuance_Click(object sender, EventArgs e)
        {
            /*if (ofd_load.ShowDialog() == DialogResult.OK)//Вызываем диалог выбора файла и проверяем, что полльзователь выбрал файл
            {
                DataTable table;
                if (ExcelClass.loadExcel(ofd_load.FileName, out table))//Если загрузка данных(ИмяФайла,ТаблицаСРезультатом) прошел успешно
                {
                    foreach (DataRow row in table.Rows)//перебираем полученные строки
                    {
                         DbModel.init().Issuances.Add( //Заполняем строки таблицы Trainesses значениями
                           DbModel.init().Issuances.Include(i => i.trainess).Include(i => i.book),
                        new IssuanceClass()
                        {
                            trainess = Convert.ToInt32(row["класс"], row["фамилия"], row["имя"]),
                            book = Convert.ToString(row["название книги"]),
                            user = Convert.ToString(row["1"]),
                            date_of_issue = Convert.ToDateTime(row["дата выдачи"])
                        }
                    ); ;
                    }
                    DbModel.init().SaveChanges();//сохраняем
                }
            }        */
        }

        private void Add_Issuance_Click(object sender, EventArgs e)
        {
            AddIssuanceForm f_aif = new AddIssuanceForm();
            f_aif.ShowDialog();
            /* updateDate();*/  //СДЕЛАТЬ!!!!!!
        }

        private void Delete_Issuance_Click(object sender, EventArgs e)
        {

        }
    }
    }