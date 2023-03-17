using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MnsjAn.Views.Tutorial;
using Xamarin.CommunityToolkit.Extensions;
using Rg.Plugins.Popup.Services;
using Syncfusion.XForms.Buttons;
using Rg.Plugins.Popup.Extensions;
using MnsjAn.ViewModels;

namespace MnsjAn.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Tool : Rg.Plugins.Popup.Pages.PopupPage
    {
        
        public Tool()
        {
            InitializeComponent();
            BindingContext = new UserVM();
        }

        private void ins_Clicked(object sender, EventArgs e)
        {
            Browser.OpenAsync("https://www.instagram.com/ngl.app/?hl=es", BrowserLaunchMode.SystemPreferred);
        }

        private async void link_Clicked(object sender, EventArgs e)
        {
            await PopupNavigation.Instance.PushAsync(new uno());
        }

        private async void help_Clicked(object sender, EventArgs e)
        {
            var mensaje = new EmailMessage("I need help", "Id: "  + " App version: 2.1.1", "safety@nglapp.com");
            mensaje.BodyFormat = EmailBodyFormat.PlainText;
            await Email.ComposeAsync(mensaje);
        }

        private async void sett_Clicked(object sender, EventArgs e)
        {
            await PopupNavigation.Instance.PushAsync(new Settings());
        }

        private async void btnClose_Clicked(object sender, EventArgs e)
        {
            // await Navigation.PopAsync();
            //await Navigation.PushAsync(new Menu());
            await PopupNavigation.Instance.PopAsync();
        }
    }
}