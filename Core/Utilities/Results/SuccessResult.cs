using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class SuccessResult:Result
    {
        //base: kalıtım aldıgı kişi yanı Result
        //doğru olan yanı (success) kısmını burada tanımladık
        public SuccessResult(string message) : base(true, message) 
        {

        }
        public SuccessResult() : base(true)
        {

        }
    }
}
