using ACA.Anjana.Authentication.Interfaces;
using ACA.Anjana.Authentication.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ACA.Anjana.Authentication.views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Loginpage : ContentPage
    {
        public static IGoogleAuthenticator _googleManager = DependencyService.Get<IGoogleAuthenticator>();
        private object googleUser;

        public GoogleUser GoogleUser { get; private set; }
        public bool IsLogedIn { get; private set; }
        public Loginpage()
        {
            InitializeComponent();
           
        }
        
        public async void Login(object sender, EventArgs e)
        {
            Firstlight.TranslationY = -20;
            Secondlight.TranslationY = -20;
            Clock.TranslationY = -20;
            View.TranslationY = -20;
            LoginButton.TranslationY = -20;
            Forget.TranslationY = -20;
            Firstlight.Opacity = 0;
            Secondlight.Opacity = 0;
            Clock.Opacity = 0;
            View.Opacity = 0;
            LoginButton.Opacity = 0;
            Forget.Opacity = 0;
            Firstlight.FadeTo(1, 100);
            
            await Firstlight.TranslateTo(0, 0, 300);
            Secondlight.FadeTo(1, 100);
            
            await Secondlight.TranslateTo(0, 0, 300);
            Clock.FadeTo(1, 100);
            
            await Clock.TranslateTo(0, 0, 300);
            View.FadeTo(1, 100);
            
            await View.TranslateTo(0, 0, 300);
            LoginButton.FadeTo(1, 100);
            
            await LoginButton.TranslateTo(0, 0, 300);
            Forget.FadeTo(1, 100);
            
            await Forget.TranslateTo(0, 0, 300);








            //try
            //{

            //    _googleManager.Logout();
            //    _googleManager.Login(OnLoginComplete);

            //}
            //catch (Exception x)
            //{

            //    await DisplayAlert("Authentication Failed", "Your Authentication Attempt Failed. Please try again..", "Ok");
            //}
        }

       

        //private async void OnLoginComplete(GoogleUser googleUser, string message)
        //{
        //    if (googleUser != null)
        //    {
        //        GoogleUser = googleUser;
        //        try
        //        {
        //            AppUser User = await DependencyService.Get<IFireBaseAuthenticator>().LoginWithGoogle(googleUser.Token, null);
        //            //Application.Current.Properties["User"] = User.Uid;
        //        }
        //        catch (Exception e)
        //        {
        //            await DisplayAlert("Oops", "Firebase Error", "Ok");
                    
        //        }

        //        IsLogedIn = true;
        //        await DisplayAlert("Success", message, "Ok");
                
        //    }
        //    else
        //    {
                
        //        await DisplayAlert("Error", message, "Ok");
        //    }
        //}

        
    }
}