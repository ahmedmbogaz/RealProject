using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class ProductValidator:AbstractValidator<Product>
    {
        public ProductValidator() //constaktır içine kurallar yazılır
        {
            //araştır bunları
            RuleFor(p=>p.ProductName).NotEmpty(); //boş gelemez
            RuleFor(p=>p.ProductName).MinimumLength(2);//min uzunluk 2 karater olabilir
            RuleFor(p=>p.UnitPrice).NotEmpty();//boş olamaz
            RuleFor(p=>p.UnitPrice).GreaterThan(0);//unitprice 0 dan büyük olmalı
            RuleFor(p=>p.UnitPrice).GreaterThanOrEqualTo(10).When(p=>p.CategoryId==1);
            //içecek kategorisinde ise içecek kategorisinin ürünlerinin fiyatı min 10 olmalı demek (when şarttır.)
            //RuleFor(p => p.ProductName).Must(StarWithA).WithMessage("Ürünler Aharfi ile başlamalı");// isimler artık A ile başlasın
        }

        //private bool StarWithA(string arg) // arg: gönderdiğin parametredir.
        //{
        //    return arg.StartsWith("A"); //A ile başlarsa true döner, başka harle başlarsa false döner
        //}
    }
}
