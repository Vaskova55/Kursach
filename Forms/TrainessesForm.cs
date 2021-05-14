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
    public partial class TrainessesForm : Form
    {
        public TrainessesForm()
        {
            InitializeComponent();
        }

        private void Add_Trainess_Click(object sender, EventArgs e)
        {
            AddTrainessForm f_atf = new AddTrainessForm();
        }

        private void bt_import_Click(object sender, EventArgs e)
        {
            if (ofd_load.ShowDialog() == DialogResult.OK)//Вызываем диалог выбора файла и проверяем, что полльзователь выбрал файл
            {
                DataTable table;
                if (ExcelClass.loadExcel(ofd_load.FileName, out table))//Если загрузка данных(ИмяФайла,ТаблицаСРезультатом) прошел успешно
                {
                    foreach (DataRow row in table.Rows)//перебираем полученные строки
                    {
                        /*TrainessClass.add(Convert.ToInt32(row["класс"]),              //
                            Convert.ToString(row["фамилия"]),                           //для разработки методом структурирования данных
                            Convert.ToString(row["имя"]),                               //
                            Convert.ToString(row["отчество"]));*/                       //
                        DbModel.init().Trainesses.Add( //Заполняем строки таблицы Trainesses значениями
                        new TrainessClass
                        {
                            classTrainess = Convert.ToInt32(row["класс"]),
                            family_name = Convert.ToString(row["фамилия"]),
                            first_name = Convert.ToString(row["имя"]),
                            middle_name = Convert.ToString(row["отчество"])
                        }
                    );
                    }
                    DbModel.init().SaveChanges();//сохраняем
                }
            }
        }

        private void Export_Trainess_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Файлы excel|*.xlsx";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                List<TrainessClass> listTrainesses = DbModel.init().Trainesses.ToList(); /////?
                string[,] values = new string[listTrainesses.Count + 1, 5];

                values[0, 0] = "Класс";
                values[0, 1] = "Фамилия";
                values[0, 2] = "Имя";
                values[0, 3] = "Отчество";

                for (int i = 0; i < listTrainesses.Count; i++)
                {
                    values[i + 1, 0] = listTrainesses[i].classTrainess.ToString();
                    values[i + 1, 1] = listTrainesses[i].family_name;
                    values[i + 1, 2] = listTrainesses[i].first_name;
                    values[i + 1, 3] = listTrainesses[i].middle_name;
                }
                ExcelClass.saveExcel(dialog.FileName, "Обучающиеся", values);
            }
        }
    }
}
