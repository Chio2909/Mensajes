using MnsjAn.Models;
using MnsjAn.ViewModels;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MnsjAn.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MensajeDetail : ContentPage
    {
       
        public MensajeDetail(string descripcion, int tipo_id, int id)
        {
            InitializeComponent();
            BindingContext = new TipoVM();
            BindingContext = new MensajesVM();

            Mydescripcion.Text = descripcion;
            Mytipo.Text = tipo_id.ToString();
        }

        private void btnVer_Clicked(object sender, EventArgs e)
        {

        }

        private void btnResponder_Clicked(object sender, EventArgs e)
        {
            Browser.OpenAsync("https://www.instagram.com/", BrowserLaunchMode.SystemPreferred);
        }

        private async void warning_Clicked(object sender, EventArgs e)
        {
            
            await PopupNavigation.Instance.PushAsync(new Warning());
        }

        private async void cerrar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Inbox());
        }
    }
}