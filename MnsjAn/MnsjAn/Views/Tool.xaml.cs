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
using Xamarin.CommunityToolkit.UI.Views;

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

        private async void btnClose_Clicked(object sender, EventArgs e)
        {
            // await Navigation.PopAsync();
            //await Navigation.PushAsync(new Menu());
            await PopupNavigation.Instance.PopAsync();
        }

        private async void btnQuestion_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Preguntas());
            await PopupNavigation.Instance.PopAsync();
        }

        private async void btnProblem_ClickedAsync(object sender, EventArgs e)
        {
            var mensaje = new EmailMessage("Reporte de Problema", "", "ayudamsq@gmail.com");
            mensaje.BodyFormat = EmailBodyFormat.PlainText;
            await Email.ComposeAsync(mensaje);

        }

        private async void btnIdioma_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Idioma());
            await PopupNavigation.Instance.PopAsync();
        }

        private async void btnCuenta_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MiCuenta());
            await PopupNavigation.Instance.PopAsync();
        }

        private void btnFace_Clicked(object sender, EventArgs e)
        {
            Browser.OpenAsync("https://es-la.facebook.com/", BrowserLaunchMode.SystemPreferred);
        }

        private void btnIns_Clicked(object sender, EventArgs e)
        {
            Browser.OpenAsync("https://www.instagram.com/", BrowserLaunchMode.SystemPreferred);
        }

        private void btnYou_Clicked(object sender, EventArgs e)
        {
            Browser.OpenAsync("https://www.youtube.com/", BrowserLaunchMode.SystemPreferred);
        }

        private void btnTik_Clicked(object sender, EventArgs e)
        {
            Browser.OpenAsync("https://www.tiktok.com/es/", BrowserLaunchMode.SystemPreferred);
        }
    }
}