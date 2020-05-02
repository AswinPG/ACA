using ACA.Anjana.Authentication.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ACA.Anjana.Authentication.Interfaces
{
    public interface IFireBaseAuthenticator
    {
        Task<AppUser> LoginWithGoogle(string idTok, string accesTok);
    }
}
