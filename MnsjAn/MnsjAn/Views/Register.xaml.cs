using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MnsjAn.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Register : ContentPage
         
    {
        public ICommand TapCommand => new Command<string>(async (url) => await Launcher.OpenAsync(url));
        public Register()
        {
            InitializeComponent();
            BindingContext = this;
        }

        private async void btnRegistrar_Clicked(object sender, EventArgs e)
        {
            if (txtPass.Text == txtPassConf.Text)
            {
                await btnRegistrar.ScaleTo(0.8, 1000, Easing.SinInOut);
                await btnRegistrar.ScaleTo(1, 1000, Easing.SinInOut);
                await Navigation.PushAsync(new Usuario());
            }
            else
            {
                
                DisplayAlert("Error", "Las contraseñas no coinciden", "OK");
            }
           
        }
    

    }
}