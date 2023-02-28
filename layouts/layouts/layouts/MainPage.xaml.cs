using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace layouts
{
    public partial class MainPage : FlyoutPage
    {
        public MainPage()
        {
            InitializeComponent();

            this.Flyout = new maestro();
            this.Detail = new NavigationPage(new detalle());

            App.flyoutPage = this;
        }
    }
}
