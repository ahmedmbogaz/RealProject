﻿using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IProductService
    {
        // bunlara ek olarak bir işlem sonucu mesaj koymak için IdataR. yaptık
        IDataResult<List<Product>> GetAll();  // hem işlem sonucunu hem mesajı hemde döndüreceği (listof product) şeyi içerek yapı gorevi görür
        IDataResult<List<Product>> GetAllByCategoryId(int id);
        IDataResult<List<Product>> GetByUnitPrice(decimal min, decimal max);
        IDataResult<List<ProductDetailDto>> GetProductDetails();
        IDataResult<Product> GetById(int productId); 
        IResult Add(Product product);
        IResult AddTransactionalTest(Product product);
    }
}
