using System;
using System.Collections.Generic;
using System.Data.SQLite;
using SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Appflowershop.modelclass;
using SQLiteConnection = SQLite.SQLiteConnection;

namespace Appflowershop.views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginSystem : ContentPage
    {
        public static string usernamee { get; set; }
        public List<string> ass { get; set; }
        public LoginSystem()
        {
            InitializeComponent();
            Init();
        }
        public void Init()
        {
            
            BackgroundColor = modelclass.constain.BackgroudPage;
            laUsername.TextColor = modelclass.constain.Maintext;
            laPassword.TextColor = modelclass.constain.Maintext;
            forgetPassword.BackgroundColor = constain.BackgroudPage;
            forgetPassword.TextColor = constain.Maintext;
            EUsername.Completed += (S, e) => EUsername.Focus();
            Activitye.IsVisible = false;
        }
        public void insertname(object sender, EventArgs e)
        {
            LoginSystem.usernamee = EUsername.Text;
            var dbPath = Path.Combine(Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "UserStore.db");
            var db = new SQLite.SQLiteConnection(dbPath);
            var table = db.Table<User>();
            var query = db.Table<User>().Where(u => u.username.Equals(EUsername.Text) && u.password.Equals(EPassword.Text)).FirstOrDefault();
            if (query != null)
            {
                Application.Current.MainPage = new views.menu.menuOrder();
                DisplayAlert("เข้าสู่ระบบ", "เข้าสู่ระบบเรียบร้อยเเล้ว", "Yes");
            }
            else
            {
                DisplayAlert("เข้าสู่ระบบล้มเหลว", "เกอข้อผิดพลาดของระบบ", "Yes");


            }
//Application.Current.MainPage = new views.menu.menuOrder();
            //Navigation.PushAsync(new views.menu.menuOrder());
        }
        public void newpage(object sender, EventArgs e)
        {
            Application.Current.MainPage = new Registed();
        }
    }
}