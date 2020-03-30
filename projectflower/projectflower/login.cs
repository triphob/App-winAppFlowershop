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
    public partial class login : Form
    {
        public static string nameUser;
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = textBox1.Text.Trim();
            nameUser = user;
            string pass = textBox2.Text.Trim();
            order hme = new order();


            if (user == "" && pass == "")
            {
                MessageBox.Show("กรุณาเช็คชื่อผู้ใช้เเละรหัสผ่าน");
            }
            else
            {
                if (user == "admin" && pass == "0000")
                {
                    MessageBox.Show("เข้าสู่ระบบเรียบร้อย");
                    Admincheck had = new Admincheck();
                    this.Hide();
                    had.Show();
                }
                else
                {
                    SQLiteConnection conn = new SQLiteConnection(@"Data Source=C:/Users/NonGay/Desktop/Projectflower/Database/UserandAdmin.db;");
                    string query = "SELECT * from User Where Username = '" + user + "' and Password = '" + pass + "'";
                    conn.Open();
                    SQLiteCommand cmdd = new SQLiteCommand(query, conn);
                    DataTable dt = new DataTable();
                    SQLiteDataAdapter sda = new SQLiteDataAdapter(cmdd);
                    sda.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        Goods home = new Goods();
                        this.Hide();
                        home.Show();
                    }
                    else
                    {
                        MessageBox.Show("กรุณาเช็คชื่อผู้ใช้เเละรหัสผ่าน");
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Application.Run.(new registed());
            
        }
    }
}

