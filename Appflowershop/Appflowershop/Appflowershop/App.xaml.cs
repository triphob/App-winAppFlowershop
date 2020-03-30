using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Appflowershop
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new views.LoginSystem();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
