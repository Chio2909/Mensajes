using MnsjAn.ViewModels;
using MnsjAn.Views.Tutorial;
using Plugin.Clipboard;
using Rg.Plugins.Popup.Services;
using System;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MnsjAn.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Menu : ContentPage
    {
        private string strAuthentifyUser;
        public static string sstrUser;
        LoginAcess OAuthLogin = new LoginAcess(sstrUser);

        //private const string url = "https://nglapi.000webhostapp.com/tipo.php";
        //private HttpClient client = new HttpClient();
        //private ObservableCollection<Tipo> tipo;
        public Menu()
        {
            strAuthentifyUser = OAuthLogin.AuthentifyLogin();

            InitializeComponent();
            BindingContext = new TipoVM();
          //  usertxt.Text = strAuthentifyUser;

        }
        

        private async void btnEnlace_Clicked(object sender, EventArgs e)
        {
            await btnEnlace.ScaleTo(0.9, 1000, Easing.SinInOut);
            await btnEnlace.ScaleTo(1, 1000, Easing.SinInOut);
            await Share.RequestAsync(new ShareTextRequest() {
                Title="Compartir enlace",
                Text= enlace.Text
                });

            // Copy text
            //CrossClipboard.Current.SetText(enlace.Text);
            //await DisplayAlert("Link Copied!", enlace.Text, "OK");
         }

       
       private async void btnComparte_Clicked(object sender, EventArgs e) 
        {
            await btnComparte.ScaleTo(0.8, 1000, Easing.SinInOut);
            await btnComparte.ScaleTo(1, 1000, Easing.SinInOut);
            await PopupNavigation.Instance.PushAsync(new uno());
           // await Navigation.ShowPopupAsync(new uno());
           // await DisplayAlert("Popup closed", result.ToString(), "OK");
            // await Navigation.PushAsync(new uno());
        }

        private async void tool_Clicked(object sender, EventArgs e)
        {
           // await Navigation.PushAsync(new Ejemplo());
            await PopupNavigation.Instance.PushAsync(new Tool());
        }

        private async void inbox_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Inbox());
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Menu());
        }
    }
}