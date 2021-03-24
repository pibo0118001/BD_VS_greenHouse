using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VS_GreenHouse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            label1.Text = "Логин";
            label2.Text = "Пароль";
            label3.Text = "АРМ \"Оранжерея\"\n\nДля авторизации введите логин и пароль";
            button1.Text = "Ввойти";

        }
    }
}
