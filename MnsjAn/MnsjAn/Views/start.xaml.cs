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
  
    public partial class start : ContentPage
    {

        public ICommand TapCommand => new Command<string>(async (url) => await Launcher.OpenAsync(url));

        public start()
        {
            InitializeComponent();
            BindingContext = this;
        }
        private async void btnComenzar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Usuario());
        }
        //public Command Usuario
        //{
        //    get
        //    {
        //        return new Command(() =>
        //        {
        //            Navigation.PushAsync(new Usuario(null));
        //        });
        //    }
        //}
    }
}