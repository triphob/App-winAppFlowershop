using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SQLite;
using System.Threading.Tasks;



namespace Appflowershop.views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registed : ContentPage
    {

        public Registed()
        {
            InitializeComponent();
            Init();
        }
        public void Init()
        {
            BackgroundColor = modelclass.constain.BackgroudPage;
            LNameFL.TextColor = modelclass.constain.Maintext;
            Name.TextColor = modelclass.constain.Maintext;
            Name2.TextColor = modelclass.constain.Maintext;
            laPassword.TextColor = modelclass.constain.Maintext;
            laPassword2.TextColor = modelclass.constain.Maintext;

        }
        public void Submit(object sender, EventArgs e)
        {
            if (Password.Text!=Password2.Text)
            {
                DisplayAlert("เเจ้งเตือน", "รหัสไม่ครงกัน", "ตกลง");
            }
            else
            {
                var dbpath = Path.Combine(Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "UserStore.db");
                var db = new SQLite.SQLiteConnection(dbpath);
                db.CreateTable<modelclass.User>();
                var userRe = new modelclass.User()
                {
                    name = ENameFL.Text,
                    username = EUsername.Text,
                    password = Password.Text,
                };
                db.Insert(userRe);
                DisplayAlert("เเจ้งเตือน", "สมัครสมาชิกเรียบร้อย", "ตกลง");
                Sincsub();
            }
        }
        public void Cancel(object sender, EventArgs e)
        {
            Opennewpage();
        }
        public void Opennewpage()
        {
            Application.Current.MainPage = new LoginSystem();
        }
        public void Sincsub()
        {
            Application.Current.MainPage = new LoginSystem();
        }
    }
    
}