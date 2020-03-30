using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Appflowershop.views.menu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class menuOrder : MasterDetailPage
    {
        public menuOrder()
        {
            InitializeComponent();
            MasterPage.ListView.ItemSelected += ListView_ItemSelected;
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as menuOrderMasterMenuItem;
            if (item == null)
                return;

            Detail = new NavigationPage((Page)Activator.CreateInstance(item.TargetType));
            IsPresented = false;

            MasterPage.ListView.SelectedItem = null;
        }
    }
}