using Core.Utilities.Interceptors;
using Core.Utilities.IoC;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.DynamicProxy;
using Microsoft.Extensions.DependencyInjection;
using Core.Extensions;
using Business.Constants;

namespace Business.BusinessAspects.Autofac
{
    //jwt üzerinden işlem yapar
    public class SecuredOperation : MethodInterception
    {
        private string[] _roles;
        private IHttpContextAccessor _httpContextAccessor;//her istek için http contex oluşturur

        public SecuredOperation(string roles)// rolleri ver demek
        {
            _roles = roles.Split(',');//iki elemanlı işlem yapar
            _httpContextAccessor = ServiceTool.ServiceProvider.GetService<IHttpContextAccessor>();
            //controller içindeki verileri aspact ile bağlar
            //IHttpCOntextAccessor: .net içerisinden gelen bir şey
        }

        //OnBefore: MethodInterceptiondan geliyor. ilk yapılacak iş
        //o anki kullanıcının claim rolerini bul diyor.
        protected override void OnBefore(IInvocation invocation)
        {
            var roleClaims = _httpContextAccessor.HttpContext.User.ClaimRoles();
            foreach (var role in _roles)
            {
                //cleaim rolleri içinde ilgili rol varsa return et demek
                if (roleClaims.Contains(role))
                {
                    return;
                }
            }
            throw new Exception(Messages.AuthorizationDenied);
        }
    }
}
