using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        //getler constracterde set edilebilir.Programcı kısıtlaması için böyle olur
        //this: resultun tek parametreli constacterına baglan (this: bu classın constacterı demek)
        public Result(bool success, string message) :this(success)
        {
            Message = message;
        }

        public Result(bool success) // constracter kullanımı, imza farkı 
        {
            Success = success;
        }

        public bool Success { get; }

        public string Message { get; }
    }
}
