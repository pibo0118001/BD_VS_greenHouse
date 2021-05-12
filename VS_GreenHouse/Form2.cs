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
    public partial class Form2 : Form
    {
        private OleDbDataAdapter adapter;
        private DataSet ds;
        OleDbConnection Connection = new OleDbConnection();
        public string connectstring;
        DataSet Ds;

        public Form2(string connectionString)
        {
            InitializeComponent();
            connectstring = connectionString;
            Connection.ConnectionString = connectstring;
            

        }

        // надо добавить кнопку выхода из профиля
        private void выходToolStripMenuItem_Click(object sender, EventArgs e) // готово 
        {
            Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string select = " SELECT * FROM Cорт";
            Connection.Open();
            adapter = new OleDbDataAdapter(select, Connection);
            adapter.Fill(Ds);
            dataGridView1.DataSource = Ds.Tables[0];

        }
    }
}
