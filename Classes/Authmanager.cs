using Biblioteka2.Classes.Entityes;
using Biblioteka2.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteka2.Classes
{
    static class Authmanager
    {
        //Установка параметров с внешним доступом на чтение
        public static UserClass user { get; private set; }
        
        //Метод авторизации
        public static bool Auth(string login, string pass) {
            user = DbModel.init().Users.Where(u => u.login == login && u.password == pass).FirstOrDefault();
            if (user != null) {
                return true;
            }
            MessageBox.Show("Неверный логин или пароль!");
            return false;
        }

        //Проверка пользователя на уровень доступа (роль) и открытие соответствующей ему формы
        public static void MenuMenu()
        {
            if (user.access_level == 1)
            {
                FormManager.ChangeForm(new Home_pageForm());
            }
            else if (user.access_level == 0)
            {
                FormManager.ChangeForm(new SearchTrainessForm());
            }
        }

        //Выход пользователя из системы и переход на форму авторизации
        public static void DeAuth()
        {
            user = null;
            FormManager.ChangeForm(new AuthorizationForm());
        }
    }
}
