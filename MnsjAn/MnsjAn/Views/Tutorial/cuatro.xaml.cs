using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.CommunityToolkit.Extensions;
using Xamarin.CommunityToolkit.UI.Views;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MnsjAn.Views.Tutorial
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class cuatro : Rg.Plugins.Popup.Pages.PopupPage
    {
        public cuatro()
        {
            InitializeComponent();

        }
        private async void uno_Clicked(object sender, EventArgs e)
        {
            await PopupNavigation.Instance.PushAsync(new uno());
            // await Navigation.PushAsync(new uno());
        }

        private async void dos_Clicked(object sender, EventArgs e)
        {
            await PopupNavigation.Instance.PushAsync(new dos());
        }

        private async void tres_Clicked(object sender, EventArgs e)
        {
            await PopupNavigation.Instance.PushAsync(new tres());
        }

        private async void cuatro_Clicked(object sender, EventArgs e)
        {
            await PopupNavigation.Instance.PushAsync(new cuatro());
        }

        private void btnCompartir_Clicked(object sender, EventArgs e)
        {
            Browser.OpenAsync("https://www.instagram.com/", BrowserLaunchMode.SystemPreferred);

        }
    }
}