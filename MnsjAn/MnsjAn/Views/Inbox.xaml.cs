using MnsjAn.Models;
using MnsjAn.ViewModels;
using Newtonsoft.Json;
using Plugin.LocalNotification;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MnsjAn.Views
{
    
    public partial class Inbox : ContentPage
    {
        

        public Inbox()
        {
            InitializeComponent();
            BindingContext = new MensajesVM();
           

        }
       

        

        private async void btnRecibe_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Menu());
        }
        private async void tool_Clicked(object sender, EventArgs e)
        {
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

        private async void mycollection_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var itemSelected = e.CurrentSelection[0] as Mensajes;
            if (itemSelected != null)
            {
                await Navigation.PushAsync(new MensajeDetail(itemSelected.descripcion, itemSelected.tipo_id, itemSelected.id));
            }
        }
    }
}