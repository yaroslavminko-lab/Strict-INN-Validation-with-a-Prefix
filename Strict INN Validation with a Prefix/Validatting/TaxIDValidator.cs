using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Strict_INN_Validation_with_a_Prefix.Validatting.Interfaces;
using System.Text.RegularExpressions;

namespace Strict_INN_Validation_with_a_Prefix.Validatting
{
    class TaxIDValidator : IValidator<string>
    {
        const string pattern = @"^RU\d{10}$";
        public void Validate(ref string data)
        {
            if (Regex.IsMatch(data.ToUpper(), pattern) || data.Length != 12)
            {
                data = string.Empty;
            }
        }

    }
}
