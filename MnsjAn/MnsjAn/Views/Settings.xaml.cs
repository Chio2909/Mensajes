using MnsjAn.ViewModels;
using Rg.Plugins.Popup.Extensions;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.CommunityToolkit.UI.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MnsjAn.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Settings : Rg.Plugins.Popup.Pages.PopupPage 
    {
        private string strAuthentifyUser;
        public static string sstrUser;
   

        LoginAcess OAuthLogin = new LoginAcess(sstrUser);
        public Settings()
        {
            InitializeComponent();
        }
       

        private async void btnClose_Clicked(object sender, EventArgs e)
        {
           await PopupNavigation.Instance.PopAsync();
        }

            private void ngl_Clicked(object sender, EventArgs e)
        {
           
        }

        private async void account_Clicked(object sender, EventArgs e)
        {
            //  await PopupNavigation.Instance.PushAsync(new Cuenta());
            var result = await DisplayAlert("Confirmar", "Estas seguro", "SI", "NO");
            if (result)
            {
                OAuthLogin.LogoutLogin();
                await Navigation.PushAsync(new start());
            }
            else
            {
                return;
            }
        }
    }

        }
    
