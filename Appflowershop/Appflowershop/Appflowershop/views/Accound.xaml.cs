using Appflowershop.modelclass;
using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Appflowershop.views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Accound : ContentPage
    {
        public Accound()
        {
            InitializeComponent();
            Init();
        }

        public void Init()
        {
            BackgroundColor = modelclass.constain.BackgroudPage;
            nameFL.TextColor = constain.Maintext;
            textnormal1.TextColor = modelclass.constain.Maintext;
            textnormal6.TextColor = modelclass.constain.Maintext;
            textnormal4.TextColor = modelclass.constain.Maintext;
            textnormal2.TextColor = modelclass.constain.Maintext;
            textnormal3.TextColor = modelclass.constain.Maintext;
            var dbPath = Path.Combine(Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "UserStore.db");
            var db = new SQLite.SQLiteConnection(dbPath);
            var table = db.Table<User>();
            foreach (var s in table)
            {
                if (LoginSystem.usernamee == s.username)
                {
                    nameFL.Text = s.name;
                    textnormal2.Text = s.username;
                    textnormal4.Text = s.password;
                }
            }
        }
        public void homepage(object sender, EventArgs e)
        {
            Application.Current.MainPage = new menu.menuOrder();
        }
    }
}