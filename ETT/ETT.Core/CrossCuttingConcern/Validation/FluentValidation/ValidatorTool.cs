using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETT.Core.CrossCuttingConcern.Validation.FluentValidation
{
    public class ValidatorTool
    {
        public static void  FluentValidate(IValidator validator, object entitiy)
        {
            var result = validator.Validate(entitiy);
            if (result.Errors.Count > 0)
            {
                throw new ValidationException(result.Errors);
            }
        }
    }
}
