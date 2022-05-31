using Core.DataAcceess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IProductDal : IEntityRepository<Product> //product ın özel kodları burada tanımlanıyor
    {
        List<ProductDetailDto> GetProductDetails();
    }
}
