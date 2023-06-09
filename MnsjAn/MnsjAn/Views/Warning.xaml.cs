﻿using MnsjAn.ViewModels;
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
    public partial class Warning : Rg.Plugins.Popup.Pages.PopupPage
    {
        public Warning()
        {
            InitializeComponent();
            
        }

        private async void btnInt_Clicked(object sender, EventArgs e)
        {
            await PopupNavigation.Instance.PushAsync(new DetailWarning());
        }
    }
}