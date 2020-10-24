using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ACA
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new ACA.Anjana.Authentication.views.Loginpage();
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
