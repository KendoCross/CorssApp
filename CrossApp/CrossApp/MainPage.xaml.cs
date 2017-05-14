using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CrossApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            AppViewModel vm = new AppViewModel();
            vm.Init();
            this.BindingContext = vm;
            
        }

        public void Test()
        {
            Button btn = new Button();
            btn.VerticalOptions = LayoutOptions.Center;
            btn.HorizontalOptions = LayoutOptions.Start;
            
        }

        async void btnCall_Click(object sender, EventArgs e)
        {
            var model = (sender as Button)?.BindingContext as AppModel;
            if (model != null)
            {
                if (await this.DisplayAlert(
                        "温馨提示",
                        "您将拨打：" + model.PhoneNo + "?",
                        "是",
                        "否"))
                {
                    var dialer = DependencyService.Get<IDialer>();
                    if (dialer != null)
                    {
                        dialer.Dial(model.PhoneNo);
                    }
                }
            }

            
        }

        async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (listView.SelectedItem == null)
            {
                return;
            }
            listView.SelectedItem = null;
            await Navigation.PushModalAsync(new DetailPage(BindingContext));
        }

        
    }
}
