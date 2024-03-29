﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteka2.Classes;
using Biblioteka2.Classes.Entityes;

namespace Biblioteka2.Forms
{
    public partial class AddIssuanceForm : Form
    {
        public AddIssuanceForm()
        {
            InitializeComponent();
            UpdateCombo();
        }

        private void UpdateCombo()
        {
            cb_FIOTrIssuance.Items.Clear();
            cb_FIOTrIssuance.Items.AddRange(DbModel.init().Trainesses.Where(
                t => t.classTrainess == nud_classTrIssuance.Value).ToArray());
            cb_LiteratureIssuance.Items.Clear();
            //Выборка книг со статусом "На полке" и не со статусом "Списано",
            //соответствует классу обучающегося или не является учебной литературой
            cb_LiteratureIssuance.Items.AddRange(DbModel.init().LiteratureTurnover.Include(l=>l.book).
                Where(
                l => l.status == LiteratureTurnoverClass.e_literature_state.storage &&
                l.status != LiteratureTurnoverClass.e_literature_state.remove &&
                (l.book.classnum == nud_classTrIssuance.Value ||
                l.book.classnum == null ||
                l.book.classnum == 0)).GroupBy(l => l.book.idBook).Select(l => l.FirstOrDefault()).ToArray());
        }
        private void Ok_AddIssuance_Click(object sender, EventArgs e)
        {
            if (cb_LiteratureIssuance.SelectedItem != null)
            {
                //Добавление данных о выдаче
                IssuanceClass issuance = new IssuanceClass
                {
                    trainess = cb_FIOTrIssuance.SelectedItem as TrainessClass,
                    literature = cb_LiteratureIssuance.SelectedItem as LiteratureTurnoverClass,
                    user = DbModel.init().Users.Where(u => u.access_level == 1).FirstOrDefault(),
                    date_of_issue = (DateTime)dtp_Issuance.Value,
                    date_of_plan_return = (DateTime)dtp_return.Value
                };
                //Редактирование статуса книги с "На полке" на "Выдано"
                issuance.literature.status = LiteratureTurnoverClass.e_literature_state.issuance;

                DbModel.init().Issuances.Add(issuance); //Сохранение
                DbModel.init().SaveChanges();
                UpdateCombo();
            }
            else {
                MessageBox.Show("Ошибка!");
            }
        }

        private void date_info_update(object sender, EventArgs e)
        {
            //Метод подсчета примерной даты возврата литературы
            int mountcount = 0;
            const int mountdisove = 2;
            switch (cb_mountmax.SelectedIndex) {
                case 0:
                    mountcount = 12 - mountdisove;
                    break;
                case 1:
                    mountcount = (2 * 12) - mountdisove;
                    break;
                case 2:
                    mountcount = (3 * 12) - mountdisove;
                    break;
            }
            dtp_return.Value = dtp_Issuance.Value.AddMonths(mountcount);
        }

        private void nud_classTrIssuance_ValueChanged(object sender, EventArgs e)
        {
            //обновление данных в ComboBox при изменении выбора класса
            cb_FIOTrIssuance.Items.Clear();
            cb_FIOTrIssuance.Items.AddRange(DbModel.init().Trainesses.Where(t => t.classTrainess == nud_classTrIssuance.Value).ToArray());
            cb_LiteratureIssuance.Items.Clear();
            cb_LiteratureIssuance.Items.AddRange(DbModel.init().LiteratureTurnover.Include(l => l.book).
               Where(l => l.status == LiteratureTurnoverClass.e_literature_state.storage && l.status != LiteratureTurnoverClass.e_literature_state.remove && ( l.book.classnum == nud_classTrIssuance.Value || l.book.classnum == null || l.book.classnum == 0))
               .GroupBy(l => l.book.idBook).Select(l => l.FirstOrDefault()).ToArray());
        }

        private void cb_FIOTrIssuance_SelectedIndexChanged(object sender, EventArgs e)
        {
            //обновление данных в ComboBox при изменении выбора бучающегося
            cb_LiteratureIssuance.Items.Clear();
            cb_LiteratureIssuance.Items.AddRange(DbModel.init().LiteratureTurnover.Include(l => l.book).
               Where(l => l.status == LiteratureTurnoverClass.e_literature_state.storage && l.status != LiteratureTurnoverClass.e_literature_state.remove && (l.book.classnum == nud_classTrIssuance.Value || l.book.classnum == null || l.book.classnum == 0))
               .GroupBy(l => l.book.idBook).Select(l => l.FirstOrDefault()).ToArray());
        }
    }
}
