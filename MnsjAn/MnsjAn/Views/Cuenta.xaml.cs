using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MnsjAn.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Cuenta : Rg.Plugins.Popup.Pages.PopupPage
    {
        public Cuenta()
        {
            InitializeComponent();
        }

        private async void cancelar_Clicked(object sender, EventArgs e)
        {
           
            await PopupNavigation.Instance.PopAsync();
        }

        private async void eliminar_Clicked(object sender, EventArgs e)
        {
            await PopupNavigation.Instance.PopAsync();
            await Navigation.PushAsync(new start());
        }
    }
}