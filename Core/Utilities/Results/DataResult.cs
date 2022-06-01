using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    //dataresult: T:bana işteyeceğimi sor, aynı zamanda Result sun ve Aynı zamanda IDataResult sun 
    public class DataResult<T> : Result, IDataResult<T>
    {
        //constracter bu (result tan gelen constracter leri tanımlama)
        public DataResult(T data,bool success,string message):base(success,message)  
        {
            Data = data; // set etmek
        }
        public DataResult(T data, bool success):base (success)
        {
            Data = data;

        }
        public T Data { get; }
    }
}
