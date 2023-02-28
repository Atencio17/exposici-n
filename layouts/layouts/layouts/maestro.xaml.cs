using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace layouts
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class maestro : ContentPage
    {
        public maestro()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            App.flyoutPage.IsPresented = false;
            App.flyoutPage.Detail.Navigation.PushAsync(new StackLayout());
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            App.flyoutPage.IsPresented = false;
            App.flyoutPage.Detail.Navigation.PushAsync(new GridLayout());
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            App.flyoutPage.IsPresented = false;
            App.flyoutPage.Detail.Navigation.PushAsync(new FlexLayout());
        }

        private void Button_Clicked_3(object sender, EventArgs e)
        {
            App.flyoutPage.IsPresented = false;
            App.flyoutPage.Detail.Navigation.PushAsync(new AbsoluteLayout());
        }

        private void Button_Clicked_4(object sender, EventArgs e)
        {
            App.flyoutPage.IsPresented = false;
            App.flyoutPage.Detail.Navigation.PushAsync(new RelativeLayout());
        }
    }
}