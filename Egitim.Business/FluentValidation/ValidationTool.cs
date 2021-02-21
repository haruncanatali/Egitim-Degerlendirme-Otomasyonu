using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Egitim.Business.FluentValidation
{
    public static class ValidationTool
    {
        public static void Validate(IValidator validator,Object instance)
        {
            var result = validator.Validate(instance);
            if (result.Errors.Count > 0)
            {
                throw new ValidationException(result.Errors);
            }
        }
    }
}
