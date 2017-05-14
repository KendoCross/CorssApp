using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace CrossApp
{
    public partial class DetailPage : ContentPage
    {
        public DetailPage(object vm)
        {
            InitializeComponent();
            BindingContext = vm;
        }


        void OnButtonClicked(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }
    }
}
