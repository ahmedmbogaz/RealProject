using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.CrossCuttingConcerns.Validation
{
    public class ValidationTool
    {
        public static void Validate(IValidator validator,object entity)
        {
            var context = new ValidationContext<object>(entity); // generic olarak tanımladığı için product nesnesi verdik
            var result = validator.Validate(context);
            if (!result.IsValid) // isvalid: geçerli değilse
            {
                throw new ValidationException(result.Errors);
            }
        }
    }
}
