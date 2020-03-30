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
    public partial class registed : Form
    {
        public registed()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (FLname.Text == "" || Password.Text == "" || UsernameE.Text == "")
            {
                MessageBox.Show("กรุณากรอกข้อมูล");
            }
            SQLiteConnection con = new SQLiteConnection("Data Source=C:/Users/NonGay/Desktop/Projectflower/Database/UserandAdmin.db;");
            string query = "INSERT INTO User(nameFL, Username, Password) VALUES('" + FLname.Text + "','" + UsernameE.Text + "', '" + Password.Text + "') ";

            SQLiteCommand cmd = new SQLiteCommand(query, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("สมัครสมาชิกเรียบร้อย");
            login loge = new login();
            loge.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
