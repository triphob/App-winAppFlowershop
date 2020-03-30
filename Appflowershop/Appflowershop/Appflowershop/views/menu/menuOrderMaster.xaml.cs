using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Appflowershop.views.menu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class menuOrderMaster : ContentPage
    {
        public ListView ListView;

        public menuOrderMaster()
        {
            InitializeComponent();

            BindingContext = new menuOrderMasterViewModel();
            ListView = MenuItemsListView;
            Init();
        }
        public void Init()
        {
            gridname.BackgroundColor = modelclass.constain.tabpage;
        }
        class menuOrderMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<menuOrderMasterMenuItem> MenuItems { get; set; }

            public menuOrderMasterViewModel()
            {
                MenuItems = new ObservableCollection<menuOrderMasterMenuItem>(new[]
                {
                    new menuOrderMasterMenuItem { Id = 0, Title = "สินค้า" ,TargetType=typeof(menuOrderDetail)},
                    new menuOrderMasterMenuItem { Id = 1, Title = "ตระกล้า" ,TargetType=typeof(views.order)},
                    new menuOrderMasterMenuItem { Id = 2, Title = "บัญชี" ,TargetType=typeof(views.Accound)},
                    new menuOrderMasterMenuItem { Id = 3, Title = "ออกจากระบบ" ,TargetType=typeof(views.Exit)},
                    //new menuOrderMasterMenuItem { Id = 4, Title = "Page 5" },
                });
            }

            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}