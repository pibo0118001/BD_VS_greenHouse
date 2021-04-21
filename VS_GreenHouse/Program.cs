using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VS_GreenHouse
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            using (Form1 form1 = new Form1())
            {
                if (form1.ShowDialog() == DialogResult.OK)
                {
                    Application.Run(new Form2());
                }
            }
            
        }

        /*
        Задачи
            1. Окно авторизации
	            Логин и пароль надо сравнивають с БД...
	        
            2. Меню
	            Работа с кадрами
	            Работа с клиентами
	            Справочники (те данные которые необходимы для того чтобы работать, должности)   ?
	            Справка
                
                Дополнительно
                    Надо добавить кнопку выхода из профиля. (Вернутся к Form1)




        Условия
            Информация о сотрудниках (Делает хозяин)
	            Принимать, увольнать
	            Трудовая книжка
            Продавец
	            Координаты , какие цветы, выписка счёта.
	            Кто будет отправлять? когда? Улица? города? цветы и т.д.


         */
    }
}
