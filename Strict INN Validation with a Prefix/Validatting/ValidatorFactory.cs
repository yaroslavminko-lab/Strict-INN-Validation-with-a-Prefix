using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Strict_INN_Validation_with_a_Prefix.Validatting.Interfaces;

namespace Strict_INN_Validation_with_a_Prefix.Validatting
{
    static class ValidatorFactory
    {
        public static IValidator<IdentityData> CreateValidator()
        {
            var taxIDValidator = new TaxIDValidator();

            return new Validator(taxIDValidator);
        }
    }
}
