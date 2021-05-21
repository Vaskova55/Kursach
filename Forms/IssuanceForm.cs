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
            updatData();
        }

        private void updatData()
        {
            dgv_Issuance.Rows.Clear();
            foreach (IssuanceClass issuance in DbModel.init().Issuances.Include(i => i.trainess).Include(i => i.literature).Include(i => i.literature.book).Include(i => i.user)
                .Where(
                    i => i.trainess.classTrainess.ToString().Contains(tb_SearchIssuance.Text) ||
                    i.trainess.family_name.Contains(tb_SearchIssuance.Text) ||
                    i.trainess.family_name.Contains(tb_SearchIssuance.Text) ||
                    i.literature.book.name_book.Contains(tb_SearchIssuance.Text) ||
                    i.literature.book.name_book.Contains(tb_SearchIssuance.Text) ||
                    i.literature.book.name_book.Contains(tb_SearchIssuance.Text) ||
                    i.date_of_issue.ToString().Contains(tb_SearchIssuance.Text)
                )
            )
            {
                int r = dgv_Issuance.Rows.Add(
                    issuance.literature.book.type.type.ToString(),
                    issuance.date_of_issue.ToString(),
                issuance.trainess.first_name.ToString(),
                    issuance.literature.book.name_book.ToString(),
                    issuance.date_of_issue.ToString(),
                    issuance.literature.book.ToString()
                );
                dgv_Issuance.Rows[r].Tag = issuance;
            }
        }

        private void Export_Issuance_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Файлы excel|*.xlsx";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                List<IssuanceClass> listIssuance = DbModel.init().Issuances.Include(i => i.trainess).Include(i => i.literature).Include(i => i.literature.book).ToList();
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
                            values[i + 1, 3] = listIssuance[i].literature.book.name_book;
                            values[i + 1, 4] = listIssuance[i].date_of_issue.ToString("F");

                        }
                    }

                }
                ExcelClass.saveExcel(dialog.FileName, "Выдача", values);
            }
        }

        private void bt_Import_Issuance_Click(object sender, EventArgs e)
        {
            if (ofd_load_Issuance.ShowDialog() == DialogResult.OK)//Вызываем диалог выбора файла и проверяем, что полльзователь выбрал файл
            {
                DataTable table;
                if (ExcelClass.loadExcel(ofd_load_Issuance.FileName, out table))//Если загрузка данных(ИмяФайла,ТаблицаСРезультатом) прошел успешно
                {
                    StringBuilder stringBuilder = new StringBuilder(); //конструктор ошибок
                    foreach (DataRow row in table.Rows)//перебираем полученные строки
                    {
                        //Проверка на наличие обучающегося с такими данными
                        TrainessClass trainess = DbModel.init().Trainesses.Where(t =>
                            t.classTrainess == Convert.ToInt32(row["Класс"])
                            && t.family_name == Convert.ToString(row["фамилия"])
                            && t.first_name == Convert.ToString(row["Имя"])
                         ).FirstOrDefault();

                        //Проверка на наличие книги с такими данными
                        BookClass book = DbModel.init().Books.Where(b => b.name_book == Convert.ToString(row["Название книги"])).FirstOrDefault();

                        //Если книга не существует, то выдается сообщение об ошибке 
                        if (book == null)
                        {
                            stringBuilder.AppendLine(String.Format("Book with name {0} not found!", Convert.ToString(row["Название книги"])));
                            continue;
                        }
                        LiteratureTurnoverClass literature = (book.literatureTurnovers.Where(l => l.status == LiteratureTurnoverClass.e_literature_state.storage).FirstOrDefault());
                        if (literature == null)
                        {
                            stringBuilder.AppendLine("Book not found in storage!");
                            continue;
                        }

                        //Если такого обучающегося не существует, то он создаётся
                        if (trainess == null)
                        {
                            trainess = new TrainessClass
                            {
                                classTrainess = Convert.ToInt32(row["Класс"]),
                                family_name = Convert.ToString(row["Фамилия"]),
                                first_name = Convert.ToString(row["Имя"])
                            };
                        }

                        //Когда подбор данных осуществлен, происходит импорт (добавление данных)
                        DbModel.init().Issuances.Add(
                            new IssuanceClass
                            {
                                user = Authmanager.user,
                                date_of_issue = Convert.ToDateTime(row["Дата выдачи"]),
                                trainess = trainess,
                                literature = literature
                            }
                        );
                    }

                    //Если найдена ошибка, то выдается сообщение и обращение к ползователю, где спрашивается его согласие на сохранение данных с ошибкой
                    if (stringBuilder.Length > 0)
                    {
                        MessageBox.Show(stringBuilder.ToString());
                        if (MessageBox.Show("Save?", "save", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            DbModel.init().SaveChanges();
                            updatData();
                        }
                    }
                    else
                    {
                        DbModel.init().SaveChanges();
                        updatData();
                    }
                }
            }
        }

        private void Add_Issuance_Click(object sender, EventArgs e)
        {
            AddIssuanceForm f_aif = new AddIssuanceForm();
            f_aif.ShowDialog();
            updatData();
        }

        private void Delete_Issuance_Click(object sender, EventArgs e)
        {
            if (dgv_Issuance.Rows.Count > 0)
            {
                IssuanceClass issuance = dgv_Issuance.Rows[0].Tag as IssuanceClass;
                DbModel.init().Issuances.Remove(issuance);
            DbModel.init().SaveChanges();
            updatData();
            }
        }

        private void Update_Issuance_Click(object sender, EventArgs e)
        {
            updatData();
        }

        private void tb_SearchIssuance_TextChanged(object sender, EventArgs e)
        {
            updatData();
        }

        private void bt_Return_Issuance_Click(object sender, EventArgs e)
        {
            TrainessesForm f_ti = new TrainessesForm();
            f_ti.ShowDialog();
            updatData();
        }

        private void Edit_Issuance_Click(object sender, EventArgs e)
        {

        }
    }
    /*
        if (dgv_Issuance.SelectedRows.Count > 0)
        {
            AddIssuanceForm f_aif = new AddIssuanceForm(dgv_Issuance.SelectedRows[0].Tag as IssuanceClass);
            f_aif.ShowDialog();
            updateData();
        }*/

}