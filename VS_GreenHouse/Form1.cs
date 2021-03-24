using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.OleDb;

namespace VS_GreenHouse
{
    public partial class Form1 : Form
    {
        public static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Workers.mdb;";
        //public static string connectString = "Provider=Microsoft.ACE.OLEDB.12;Data Source=Workers.mdb;"; // если 1-я строка не работает

        private OleDbConnection myConnection;


        
        public Form1()
        {
            InitializeComponent();

            label1.Text = "Логин";
            label2.Text = "Пароль";
            label3.Text = "АРМ \"Оранжерея\"\n\nДля авторизации введите логин и пароль";
            button1.Text = "Ввойти";
            button2.Text = "Отмена";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
