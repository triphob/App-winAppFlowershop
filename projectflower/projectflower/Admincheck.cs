using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectflower
{
    public partial class Admincheck : Form
    {
        public Admincheck()
        {
            InitializeComponent();
            checklist();
           
        }
        public void checklist()
        {
            var num = 1;
            SQLiteConnection conn = new SQLiteConnection(@"Data Source=C:/Users/NonGay/Desktop/Projectflower/Database/UserandAdmin.db;");
            string query = "SELECT * from User";
            conn.Open();
            var selectCmd = new SQLiteCommand(query, conn);
            selectCmd.CommandText = "SELECT * FROM Ordersub";

            var reader = selectCmd.ExecuteReader();

            while (reader.Read())
            {
                var nameUser = reader.GetString(2);
                var message = reader.GetString(1);
                string item = message.Trim();
                string item2 = nameUser.Trim();
                listBox2.Items.Add(num.ToString() + "  :  " + item + "    ชื่อผู้ใช้ :" + item2);
                num++;
            }
            conn.Close();
        }

        private void Showmember_Click(object sender, EventArgs e)
        {
            var aa = 1;
            SQLiteConnection conn = new SQLiteConnection(@"Data Source=C:/Users/NonGay/Desktop/Projectflower/Database/UserandAdmin.db;");
            string query = "SELECT * from User";
            conn.Open();
            var selectCmd = new SQLiteCommand(query, conn);
            selectCmd.CommandText = "SELECT * FROM User";

            var reader = selectCmd.ExecuteReader();
            
                while (reader.Read())
                {
                var nameUser = reader.GetString(1);
                var message = reader.GetString(2);
                string item = message.Trim();
                string item2 = nameUser.Trim();
                    listBox1.Items.Add(aa.ToString()+"  Username:  "+item+"  ชื่อ: "+item2);
                aa++;
                }
            conn.Close();
        }

        private void comfirm_Click(object sender, EventArgs e)
        {
            var num = 1;
            SQLiteConnection conn = new SQLiteConnection(@"Data Source=C:/Users/NonGay/Desktop/Projectflower/Database/UserandAdmin.db;");
            string query = "SELECT * from User";
            SQLiteConnection con = new SQLiteConnection("Data Source=C:/Users/NonGay/Desktop/Projectflower/Database/UserandAdmin.db;");
            con.Open();
            var cmds = new SQLiteCommand();
            cmds.Connection = con;
            cmds.CommandText = "DELETE FROM Ordersub WHERE namemember='" + textBoxcheck.Text + "'";
            cmds.ExecuteNonQuery();
            //cmd.ExecuteNonQuery();
            conn.Close();
            listBox2.Items.Clear();
            checklist();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            login had = new login();
            this.Hide();
            had.Show();
        }
    }
}
