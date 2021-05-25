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
    public partial class AddLitTurnoverForm : Form
    {
        public AddLitTurnoverForm()
        {
            InitializeComponent();
            updatCombo();
            updatList();
        }
        private void updatCombo()
        {
            cb_LiteratureSpisanie.Items.Clear();

            const int mountcount = 5;
            DateTime datePublisher = dtp_Spisanie.Value.AddYears(-mountcount);
            cb_LiteratureSpisanie.Items.AddRange(DbModel.init().LiteratureTurnover.Include(l => l.book).
                Where(l => l.book.publishing_year > datePublisher.Year && l.status != LiteratureTurnoverClass.e_literature_state.remove).ToArray());
        }

        private void updatList()
        {
            lb_ListSpisanie.Items.Clear();
            //Подсчет года публикации книгиотносительно нынешнего
            const int mountcount = 5;
            DateTime datePublisher = dtp_Spisanie.Value.AddYears(-mountcount);
            //Заполнение ListBox "lb_ListSpisanie" литературой, удовлетворяющей выборке по статусу и году публикации
            lb_ListSpisanie.Items.AddRange(DbModel.init().LiteratureTurnover.Include(l => l.book).
                Where(
                l => l.book.publishing_year <= datePublisher.Year &&
                l.status != LiteratureTurnoverClass.e_literature_state.remove).ToArray());
        }

        private void bt_BooksReturn_Click(object sender, EventArgs e)
        {
            foreach (LiteratureTurnoverClass literatureTurnover in lb_ListSpisanie.Items)
            {

                literatureTurnover.dateActivity = dtp_Spisanie.Value;
                literatureTurnover.status = LiteratureTurnoverClass.e_literature_state.remove;
            }
            DbModel.init().SaveChanges();
        }

        private void bt_PlusBookListSpisanie_Click(object sender, EventArgs e)
        {
            lb_ListSpisanie.Items.Add(cb_LiteratureSpisanie.SelectedItem);
            cb_LiteratureSpisanie.Items.Remove(cb_LiteratureSpisanie.SelectedItem);
        }

        private void bt_MinusBookListSpisanie_Click(object sender, EventArgs e)
        {
            cb_LiteratureSpisanie.Items.Add(lb_ListSpisanie.SelectedItem);
            lb_ListSpisanie.Items.Remove(lb_ListSpisanie.SelectedItem);
        }
    }
}
