using Acr.UserDialogs;
using MnsjAn.Models;
using MnsjAn.ViewModels;
using Newtonsoft.Json;
using System;
using System.Net;
using System.Net.Http;
using System.Text;

using Xamarin.Forms;

namespace MnsjAn.Views
{

    public partial class Usuario : ContentPage
    {
    


        public Usuario()
        {
            InitializeComponent();


        }
        private void OnTextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(e.NewTextValue))
            {
                btnListo.IsVisible = true;
            }
            else
            {
                btnListo.IsVisible = false;
            }
        }

        private async void btnListo_Clicked(object sender, EventArgs e)
        {
            
            try
            {
                WebClient client = new WebClient();
                var parametros = new System.Collections.Specialized.NameValueCollection();
                parametros.Add("nombre", txtUser.Text);
                var response = client.UploadValues("https://nglapi.000webhostapp.com/user.php", "POST", parametros);

                Application.Current.Properties["keyUser"] = txtUser.Text.Trim();
                Application.Current.Properties["IsLoggedIn"] = true;
                Menu menu = new Menu();
                await Navigation.PushAsync(menu);
            }
          
                catch(Exception ex)
                {
                    await DisplayAlert("Error", ex.Message, "Ok");
                }

       
        }
    }
}


            //  HttpClient client = new HttpClient();

//string url ="https://nglapi.000webhostapp.com/user.php/";
// string jsonUser = JsonConvert.SerializeObject(user);
//  var resultado = await client.PostAsync(url, new StringContent(jsonUser));
//  var json = resultado.Content.ReadAsStringAsync().Result;

//await DisplayAlert("Resultado", json, "Ok");
//        }
//    }
//}

//try
//{
//    if (String.IsNullOrWhiteSpace(txtUser.Text))
//    {
//        await DisplayAlert("Advertencia", "El campo Usuario es obligatorio", "OK");
//    }

//    else
//    {
//       


//        var request = new HttpRequestMessage();
//        request.RequestUri = new Uri("https://nglapi.000webhostapp.com/user.php/");
//        request.Method = HttpMethod.Post;
//        request.Headers.Add("Accpet", "application/json");
//        var payload = JsonConvert.SerializeObject(user);
//        HttpContent c = new StringContent(payload, Encoding.UTF8, "application/json");
//        request.Content = c;
//        var client = new HttpClient();
//        HttpResponseMessage response = await client.SendAsync(request);
//        if (response.StatusCode == HttpStatusCode.OK)
//        {
//            await DisplayAlert("Notificación", "El usuario se a creado con éxito :" + txtUser.Text, "OK");

//        }
//        else
//        {
//            await DisplayAlert("Notificación", "Error al conectar", "OK");
//            await Navigation.PopToRootAsync();
//        }
//    }
//}
//catch (Exception)
//{
//    await DisplayAlert("Notificación", "Error al conectar", "OK");
//    await Navigation.PopToRootAsync();
//}
//if (txtUser != null)
//{
//    WebClient client = new WebClient();
//    var parametros = new System.Collections.Specialized.NameValueCollection();
//    parametros.Add("nombre", txtUser.Text);

// var response = client.UploadValues("https://nglapi.000webhostapp.com/user.php", "POST", parametros);


//}
//else
//{
//    await DisplayAlert("Registro", "Completa todos los campos", "Ok");
//}



