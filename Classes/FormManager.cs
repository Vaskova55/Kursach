using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteka2.Classes
{
    static class FormManager
    {
        private static Form CurForm; //текущая форма
        public static void ChangeForm(Form form)//метод переключения формы
        {
            if (CurForm != null) //если форма не пустая, то =>
            {
                CurForm.FormClosing -= CurForm_FormClosing; //отвязываем событие попытки закрытия формы
                CurForm.FormClosed -= CurForm_FormClosed; //отвязываем событие закрытия формы
                CurForm.Close(); //закрытие формы
                CurForm.Dispose();//уничтожение формы (очищение памяти от нее)
            }

            CurForm = form; //инициализируем текущую форму
            CurForm.FormClosing += CurForm_FormClosing; //привязываем событие попытки закрытия формы
            CurForm.FormClosed += CurForm_FormClosed;//привязываем событие закрытия формы
            CurForm.Show(); //показываем текущую форму
        }

        public static void Restart() {
            CurForm.FormClosing -= CurForm_FormClosing; //отвязываем событие попытки закрытия формы
            CurForm.FormClosed -= CurForm_FormClosed; //отвязываем событие закрытия формы
            Application.Restart(); //перезапуск программы
        }

        private static void CurForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); //выход из программы
        }

        private static void CurForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Обращение к пользователю о его желании закрыть форму
            if (MessageBox.Show("Вы хотите закрыть данную форму?", "Подтверждение", MessageBoxButtons.YesNo) != DialogResult.Yes) {
                e.Cancel = true;
            }
        }
    }
}
