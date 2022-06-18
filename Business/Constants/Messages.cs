using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages  // sürekli new yapmamak için static olarak imzaladık
    {
        public static string ProductAdded = "Product Added!"; //prop için paskal case kullanılır
        public static string ProductNameInvalid= "Product Added!"; // ürün işmi geçersiz
        public static string MaintenanceTime = "sistem bakımda";
        public static string ProductsListed = "ürün listelendi";
        public static string ProductCountOfCategoryError ="maksimum 15 ürün ekleyebilirsiniz.";
        public static string ProductNameAlreadyExists ="Bu isimde zaten başka bir ürün var";
        public static string CategoryLimitExceded = "Categori limiti aşildıgı için kategory eklenemiyor.";
    }
}
