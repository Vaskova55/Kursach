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
    }
}
