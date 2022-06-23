using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Security.Encryption
{
    //yonetilecek jwt sisteminin güvenlik anahtarın(securitykey) budur, şifreleme algoritmanda budur(algoritma)
    class SigningCredentialsHelper//sistemi kullanabilmek için buna ihtiyaç var
    {
        public static SigningCredentials CreateSigningCredentials(SecurityKey securityKey)
        {
            return new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha512Signature);
        }
    }
}
