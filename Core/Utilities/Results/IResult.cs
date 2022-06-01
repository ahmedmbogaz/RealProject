using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public interface IResult //void denen yerde  Iresul yaz

    {
        bool Success { get; } //bunu ctor da geri dönecek bekle
        string Message { get; }

    }
}
