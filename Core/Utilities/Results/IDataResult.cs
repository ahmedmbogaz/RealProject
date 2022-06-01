using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    //mesajla işlem sonucumu IResult içeriyor bir daha yazmaaya gerek yok, Sen aynı zaman da Iresultsun bunun dısında içine yazdık
    //IDataResult Sende Iresult var birde T data var diyor
    public interface IDataResult<T>:IResult
    {
        T Data { get; }
    }
}
