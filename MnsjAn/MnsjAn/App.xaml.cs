using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MnsjAn.Views;

namespace MnsjAn
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            Properties["IsLoggedIn"] = false;
            MainPage = new NavigationPage(new start());
        
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
