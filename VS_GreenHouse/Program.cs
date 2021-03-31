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
        1. Окно авторизации
	        Данные логина и пароля надо брять с БД
	        Программа будет 1 для всех.
		        Для продавца пункт сотрудники не будет доступен.
		        Для руководителя все пункты.
        2. Меню
	        Работа с кадрами
	        Работа с клиентами
	        Справочники (те данные которые необходимы для того чтобы работать, должности)
	        Справка 
        
        Информация о сотрудниках (Делает хозяин)
	        Принимать, увольнать
	        Трудовая книжка
        Продавец
	        Координаты , какие цветы, выписка счёта.
	        Кто будет отправлять? когда? Улица? города? цветы и т.д.
         */
    }
}
