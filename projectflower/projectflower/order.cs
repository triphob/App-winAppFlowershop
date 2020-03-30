using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectflower
{
    public partial class order : Form
    {
        public order()
        {
            InitializeComponent();
            SQLiteConnection conn = new SQLiteConnection(@"Data Source=C:/Users/NonGay/Desktop/Projectflower/Database/UserandAdmin.db;");
            string query = "SELECT * from Ordersub";
            conn.Open();
            var selectCmd = new SQLiteCommand(query, conn);
            selectCmd.CommandText = "SELECT * FROM Ordersub WHERE namemember='"+login.nameUser+"'";

            var reader = selectCmd.ExecuteReader();
            int j=0;
            while (reader.Read())
            {
                var message = reader.GetString(1);
                string item = message.Trim();
                listBox1.Items.Add( "สินค้า " + item);
                listBox2.Items.Add("สินค้า " + item);
                j++;
            }
            label2.Text = j.ToString();
            label1.Text = j.ToString();
            conn.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPage3);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Goods had = new Goods();
            this.Hide();
            had.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPage2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPage1);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Goods had = new Goods();
            this.Hide();
            had.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text = " ";
            label2.Text = " ";
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            MessageBox.Show("กรุณารอสินค้า");
        }
    }
}
