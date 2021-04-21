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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        // надо добавить кнопку выхода из профиля
        private void выходToolStripMenuItem_Click(object sender, EventArgs e) // готово 
        {
            Close();
        }
    }
}
