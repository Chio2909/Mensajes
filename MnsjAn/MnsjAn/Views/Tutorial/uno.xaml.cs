using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.CommunityToolkit.Extensions;
using Xamarin.CommunityToolkit.UI.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MnsjAn.Views.Tutorial
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class uno : Rg.Plugins.Popup.Pages.PopupPage
    {
        public uno()
        {
            InitializeComponent();
        }

        private async void btnSiguiente_Clicked(object sender, EventArgs e)
        {
          await PopupNavigation.Instance.PushAsync(new dos());
            
            
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
    }
}