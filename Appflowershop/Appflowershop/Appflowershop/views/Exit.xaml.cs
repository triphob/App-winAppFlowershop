using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Appflowershop.views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Exit : ContentPage
    {
        public Exit()
        {
            InitializeComponent();
            Init();
        }

        public void Init()
        {
            BackgroundColor = modelclass.constain.BackgroudPage;
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new LoginSystem();
        }
    }
}