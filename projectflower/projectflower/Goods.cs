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
    public partial class Goods : Form
    {
        private const string setsize="StretchImage";
        private int countpage = 1;
        private int numpage=1;
        private string localfile = "C:/Users/NonGay/Desktop/Projectflower/photo/";
        public Goods()
        {
            InitializeComponent();
            Init();
            
        }
        public void Init()
        {
            showpage.Text = countpage.ToString();
            if (countpage == 1)
            {
                numpage = 1;
                int numpage1 = numpage;
                picture1.Image = Image.FromFile(localfile + "dc_0" + numpage1.ToString() + ".jpg");
                nameg.Text = "ต้นคล้า";
                price.Text = "45.00";
                numpage1 = numpage1 + 1;
                picture2.Image = Image.FromFile(localfile + "dc_0" + numpage1.ToString() + ".jpg");
                nameg1.Text = "เศรษฐีเรือนนอก";
                price1.Text = "45.00";
                numpage1 = numpage1 + 1;
                picture3.Image = Image.FromFile(localfile + "dc_0" + numpage1.ToString() + ".jpg");
                nameg2.Text = "ต้นฟิโลใบหัวใจ";
                price2.Text = "45.00";
                numpage1 = numpage1 + 1;
                picture4.Image = Image.FromFile(localfile + "dc_0" + numpage1.ToString() + ".jpg");
                nameg3.Text = " สับปะรดสี";
                price3.Text = "45.00";
                numpage = 4;
                Back.Visible = false;
                Next.Visible = true;

            }
            else if (countpage == 2)
            {
                int numpage1 = 5;
                picture1.Image = Image.FromFile(localfile + "dc_0" + numpage1.ToString() + ".jpg");
                nameg.Text = "เดหลี";
                price.Text = "45.00";
                numpage1 = numpage1 + 1;
                picture2.Image = Image.FromFile(localfile + "dc_0" + numpage1.ToString() + ".jpg");
                nameg1.Text = "แก้วกาญจนา";
                price1.Text = "45.00";
                numpage1 = numpage1 + 1;
                picture3.Image = Image.FromFile(localfile + "dc_0" + numpage1.ToString() + ".jpg");
                nameg2.Text = "ลิ้นมังกร";
                price2.Text = "45.00";
                numpage1 = numpage1 + 1;
                picture4.Image = Image.FromFile(localfile + "dc_0" + numpage1.ToString() + ".jpg");
                nameg3.Text = "บัวดอย";
                price3.Text = "45.00";
                numpage = numpage1;
                Back.Visible = true;
                Next.Visible = true;
            }
            else
            {
                int numpage1 = 9;
                picture1.Image = Image.FromFile(localfile + "dc_0" + numpage1.ToString() + ".jpg");
                nameg.Text = "ปาล์มไผ่";
                price.Text = "45.00";
                numpage1 = numpage1 + 1;
                picture2.Image = Image.FromFile(localfile + "dc_0" + numpage1.ToString() + ".jpg");
                nameg1.Text = "ไทรย้อยใบแหลม";
                price1.Text = "45.00";
                numpage1 = numpage1 + 1;
                picture3.Image = Image.FromFile(localfile + "dc_0" + numpage1.ToString() + ".jpg");
                nameg2.Text = "พลูด่าง";
                price2.Text = "45.00";
                numpage1 = numpage1 + 1;
                picture4.Image = Image.FromFile(localfile + "dc_0" + numpage1.ToString() + ".jpg");
                nameg3.Text = "เข็มสามสีหรือเข็มริมแดง";
                price3.Text = "45.00";
                Back.Visible = true;
                Next.Visible = false;
            }
        }

        private void Next_Click(object sender, EventArgs e)
        {
            countpage = countpage + 1;
            Init();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            countpage = countpage - 1;
            Init();
        }

        private void order_Click(object sender, EventArgs e)
        {
            order home = new order();
            this.Hide();
            home.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection("Data Source=C:/Users/NonGay/Desktop/Projectflower/Database/UserandAdmin.db;");
            con.Open();
            var cmds = new SQLiteCommand();
            cmds.Connection = con;
            cmds.CommandText = "INSERT INTO Ordersub(Naneorder,namemember) VALUES('" + nameg.Text + "','" + login.nameUser.ToString() + "') ";
            cmds.ExecuteNonQuery();
            //cmd.ExecuteNonQuery();
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection("Data Source=C:/Users/NonGay/Desktop/Projectflower/Database/UserandAdmin.db;");
            con.Open();
            var cmds = new SQLiteCommand();
            cmds.Connection = con;
            cmds.CommandText = "INSERT INTO Ordersub(Naneorder,namemember) VALUES('" + nameg1.Text + "','" + login.nameUser.ToString() + "') ";
            cmds.ExecuteNonQuery();
            //cmd.ExecuteNonQuery();
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection("Data Source=C:/Users/NonGay/Desktop/Projectflower/Database/UserandAdmin.db;");
            con.Open();
            var cmds = new SQLiteCommand();
            cmds.Connection = con;
            cmds.CommandText = "INSERT INTO Ordersub(Naneorder,namemember) VALUES('" + nameg2.Text + "','" + login.nameUser.ToString() + "') ";
            cmds.ExecuteNonQuery();
            //cmd.ExecuteNonQuery();
            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection("Data Source=C:/Users/NonGay/Desktop/Projectflower/Database/UserandAdmin.db;");
            con.Open();
            var cmds = new SQLiteCommand();
            cmds.Connection = con;
            cmds.CommandText = "INSERT INTO Ordersub(Naneorder,namemember) VALUES('" + nameg3.Text + "','" + login.nameUser.ToString() + "') ";
            cmds.ExecuteNonQuery();
            //cmd.ExecuteNonQuery();
            con.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            login had = new login();
            this.Hide();
            had.Show();
        }
    }
}
