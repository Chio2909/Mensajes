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

        //private void ins_Clicked(object sender, EventArgs e)
        //{
        //    Browser.OpenAsync("https://www.instagram.com/ngl.app/?hl=es", BrowserLaunchMode.SystemPreferred);
        //}




        private async void btnClose_Clicked(object sender, EventArgs e)
        {
            // await Navigation.PopAsync();
            //await Navigation.PushAsync(new Menu());
            await PopupNavigation.Instance.PopAsync();
        }

        private void btnQuestion_Clicked(object sender, EventArgs e)
        {

        }

        private async void btnProblem_ClickedAsync(object sender, EventArgs e)
        {
            var mensaje = new EmailMessage("Reportar un problema" + " App version: 2.0.0", "ayuda@myquestions.com");
            mensaje.BodyFormat = EmailBodyFormat.PlainText;
            await Email.ComposeAsync(mensaje);
        }

        private void btnIdioma_Clicked(object sender, EventArgs e)
        {

        }

        private async void btnCuenta_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Cuenta());
        }
    }
}