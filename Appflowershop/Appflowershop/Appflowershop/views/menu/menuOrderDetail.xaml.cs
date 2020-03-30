using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Appflowershop.views.menu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class menuOrderDetail : ContentPage
    {
        public List<string> Showe = new List<string>();
        public int countpage=1;
        public int numpage = 1;
        private string nameu;
        public static string numID ="";
        public menuOrderDetail()
        {
            InitializeComponent();
            var dbPath = Path.Combine(Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "UserStore.db");
            var db = new SQLite.SQLiteConnection(dbPath);
            var table = db.Table<modelclass.User>();
            foreach (var s in table)
            {
                if (LoginSystem.usernamee == s.username)
                {
                    nameu = s.username;
                }
            }
            CreateID();
            Init();
            
        }
        private void CreateID()
        {
            var dbpathA = Path.Combine(Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "IDOrderStore.db");
            var dbA = new SQLite.SQLiteConnection(dbpathA);
            dbA.CreateTable<modelclass.Money>();
                //var num = table.Count()+1;
                var userRe = new modelclass.Money()
                {
                    NameUser = nameu
                };
                dbA.Insert(userRe);
                //numID=num.ToString();
            var table = dbA.Table<modelclass.Money>();
            DisplayAlert("เตือนการสั่งซื้อ", table.Count().ToString(), "ok");
            //var num = table.Count() + 1;
            numID = table.Count().ToString();


        }
        public void Init()
        {
            if (countpage==1)
            {
                numpage = 1;
                int numpage1 = numpage;
                Photogoods.Source = "dc_0" + numpage1.ToString() + ".jpg";
                namegoods.Text = "ต้นคล้า";
                pricegoods.Text = "45.00";
                numpage1 = numpage1 + 1;
                Photogoods1.Source = "dc_0" + numpage1.ToString() + ".jpg";
                namegoods1.Text = "เศรษฐีเรือนนอก";
                pricegoods1.Text = "45.00";
                numpage1 = numpage1 + 1;
                Photogoods2.Source = "dc_0" + numpage1.ToString() + ".jpg";
                namegood2.Text = "ต้นฟิโลใบหัวใจ";
                pricegoods2.Text = "45.00";
                numpage1 = numpage1 + 1;
                Photogoods3.Source = "dc_0" + numpage1.ToString() + ".jpg";
                namegoods3.Text = " สับปะรดสี";
                pricegoods3.Text = "45.00";
                numpage = 4;
                buttonclick.IsVisible = false;
                buttonclick1.IsVisible = true;

            }
            else if (countpage==2)
            {
                int numpage1 = numpage + 1;
                Photogoods.Source = "dc_0" + numpage1.ToString() + ".jpg";
                namegoods.Text = "เดหลี";
                pricegoods.Text = "45.00";
                numpage1 = numpage1 + 1;
                Photogoods1.Source = "dc_0"+ numpage1.ToString() + ".jpg";
                namegoods1.Text = "แก้วกาญจนา";
                pricegoods1.Text = "45.00";
                numpage1 = numpage1 + 1;
                Photogoods2.Source = "dc_0" + numpage1.ToString() + ".jpg";
                namegood2.Text = "ลิ้นมังกร";
                pricegoods2.Text = "45.00";
                numpage1 = numpage1 + 1;
                Photogoods3.Source = "dc_0" + numpage1.ToString() + ".jpg";
                namegoods3.Text = "บัวดอย";
                pricegoods3.Text = "45.00";
                numpage = numpage1;
                buttonclick.IsVisible = true;
                buttonclick1.IsVisible = true;
            }
            else
            {
                int numpage1 = numpage + 1;
                Photogoods.Source = "dc_0" + numpage1.ToString() + ".jpg";
                namegoods.Text = "ปาล์มไผ่";
                pricegoods.Text = "45.00";
                numpage1 = numpage1 + 1;
                Photogoods1.Source = "dc_0" + numpage1.ToString() + ".jpg";
                namegoods1.Text = "ไทรย้อยใบแหลม";
                pricegoods1.Text = "45.00";
                numpage1 = numpage1 + 1;
                Photogoods2.Source = "dc_0" + numpage1.ToString() + ".jpg";
                namegood2.Text = "พลูด่าง";
                pricegoods2.Text = "45.00";
                numpage1 = numpage1 + 1;
                Photogoods3.Source = "dc_0" + numpage1.ToString() + ".jpg";
                namegoods3.Text = "เข็มสามสีหรือเข็มริมแดง";
                pricegoods3.Text = "45.00";
                buttonclick.IsVisible = true;
                buttonclick1.IsVisible = false;
            }
                
            
        }

        private void Next(object sender, EventArgs e)
        {
            countpage =countpage-1;
            Init();
            //DisplayAlert("444", countpage.ToString() + numpage.ToString(), "yes");
        }
        public void Nextt(object sender, EventArgs e)
        {
            countpage =countpage+1;
            Init();
            //DisplayAlert("444",countpage.ToString()+numpage.ToString(),"yes");
        }
        public void create()
        {

        }
        private void Add(object sender, EventArgs e)
        {
            var dbpathA = Path.Combine(Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "OrderStore.db");
            var dbA = new SQLite.SQLiteConnection(dbpathA);
            var table = dbA.Table<modelclass.totalorder>();
            if (table.Count().ToString() == "0")
            {
                dbA.CreateTable<modelclass.totalorder>();
            }
            var userRe = new modelclass.totalorder()
            {
                IDorder = numID,
                name = namegoods.Text,
                price = pricegoods.Text,
                Username = nameu
            };
            dbA.Insert(userRe);
        }
        private void Add1(object sender, EventArgs e)
        {

            var dbpathA = Path.Combine(Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "OrderStore.db");
            var dbA = new SQLite.SQLiteConnection(dbpathA);
            var table = dbA.Table<modelclass.totalorder>();
            if (table.Count().ToString() == "0")
            {
                dbA.CreateTable<modelclass.totalorder>();
            }
            var userRe = new modelclass.totalorder()
            {
                IDorder = numID,
                name = namegoods1.Text,
                price = pricegoods1.Text,
                Username = nameu
            };
            dbA.Insert(userRe);
        }
        private void Add2(object sender, EventArgs e)
        {
            var dbpathA = Path.Combine(Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "OrderStore.db");
            var dbA = new SQLite.SQLiteConnection(dbpathA);
            var table = dbA.Table<modelclass.totalorder>();
            if (table.Count().ToString() == "0")
            {
                dbA.CreateTable<modelclass.totalorder>();
            }
            var userRe = new modelclass.totalorder()
            {
                IDorder = numID,
                name = namegood2.Text,
                price = pricegoods2.Text,
                Username = nameu
            };
            dbA.Insert(userRe);
        }
        private void Add3(object sender, EventArgs e)
        {
            var dbpathA = Path.Combine(Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "OrderStore.db");
            var dbA = new SQLite.SQLiteConnection(dbpathA);
            var table = dbA.Table<modelclass.totalorder>();
            if (table.Count().ToString() == "0")
            {
                dbA.CreateTable<modelclass.totalorder>();
            }
            var userRe = new modelclass.totalorder()
            {
                IDorder=numID,
                name = namegoods3.Text,
                price = pricegoods3.Text,
                Username = nameu
            };
            dbA.Insert(userRe);
        }
    }
}