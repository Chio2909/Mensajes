﻿using Rg.Plugins.Popup.Services;
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
    public partial class MiCuenta : ContentPage
    {
        public MiCuenta()
        {
            InitializeComponent();
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