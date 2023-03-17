using MnsjAn.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MnsjAn.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailWarning : Rg.Plugins.Popup.Pages.PopupPage
    {
        public DetailWarning()
        {
          
            InitializeComponent();
        }

        private void delete_ClickedAsync(object sender, EventArgs e)
        {
            //Device.BeginInvokeOnMainThread(async () =>
            //{
            //    var result = await this.DisplayAlert("", "¿Estas seguro?", "Si", "Cancelar");
            //    if (result)
            //    {
            //        var request = new HttpRequestMessage();
            //        request.RequestUri = new Uri("https://nglapi.000webhostapp.com/mensajes.php" );
            //        request.Method = HttpMethod.Delete;
            //        request.Headers.Add("Accpet", "Application/json");
            //        var client = new HttpClient();
            //        HttpResponseMessage response = await client.SendAsync(request);
            //        if(response.StatusCode == HttpStatusCode.OK)
            //        {
            //            await Navigation.PushAsync(new Inbox());
            //        }
            //    }
            //});
           
        }
    }
}