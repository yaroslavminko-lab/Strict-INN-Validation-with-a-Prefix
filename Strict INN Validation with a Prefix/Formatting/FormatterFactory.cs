using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Strict_INN_Validation_with_a_Prefix.Formatting.Interfaces;

namespace Strict_INN_Validation_with_a_Prefix.Formatting
{
    static class FormatterFactory
    {
        public static IFormatter<IdentityData> CreateFormatter()
        {
            var firstNameFormatter = new FirstNameFormatter();
            var lastNameFormatter = new LastNameFormatter();
            return new Formatter(firstNameFormatter, lastNameFormatter);
        }
    }
}
