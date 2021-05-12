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
    public partial class FormAuthorization : Form
    {
        
        public FormAuthorization(string connectionString)
        {
            InitializeComponent();

            this.Text = "Авторизация";
            label1.Text = "Логин";
            label2.Text = "Пароль";
            label3.Text = "АРМ \"Оранжерея\"\n\nДля авторизации введите логин и пароль";
            button1.Text = "Ввойти";
            button2.Text = "Отмена";
            
        }













        private void button1_Click(object sender, EventArgs e) // не готово 
        {
            if (true)
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

    }
}
