using ACA.Anjana.Authentication.Model;
using System;
using System.Collections.Generic;
using System.Text;
namespace ACA.Anjana.Authentication.Interfaces
{
     public interface IGoogleAuthenticator
    {
            void Login(Action<GoogleUser, string> OnLoginComplete);
            void Logout();
        
    }
}
