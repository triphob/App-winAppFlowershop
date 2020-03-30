using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Appflowershop.modelclass;
using System.IO;
using System;
using SQLite;

namespace Appflowershop.views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class order : ContentPage
    {
        private bool check = true;

        public order()
        {
            InitializeComponent();
            Init();
        }
        public void Init()
        {
            testlabel.Text=testlabel+"\n";
            var dbPath = Path.Combine(Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "OrderStore.db");
            var db = new SQLite.SQLiteConnection(dbPath);
            var table = db.Table<totalorder>();
            if (check)
            {
                foreach (var s in table)
                {
                    if (s.IDorder == menu.menuOrderDetail.numID)
                    {
                        testlabel.Text = testlabel.Text + s.name + s.price + "\n";
                    }

                }
                check = false;
            }
        }

        private void comfirm(object sender, EventArgs e)
        {
            DisplayAlert("เตือนการสั่งซื้อ","กรุณาติดต่อทางร้าน"+"\n"+"รหัสใบสั่งซื้อ"+menu.menuOrderDetail.numID,"ตกลง");
        }
    }
}