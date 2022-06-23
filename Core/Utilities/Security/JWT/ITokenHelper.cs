using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Security.JWT
{
    public interface ITokenHelper
    {
        //oluşturulacak token
        //kullanıcı adı sifre doğrııuysa createtoken çalışacak
        //ilgili kullanıcı için claim oluşturacak ve token üretip kullanıcıya verecek.
        AccessToken CreateToken(User user, List<OperationClaim> operationClaims);
    }
}
