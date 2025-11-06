using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Strict_INN_Validation_with_a_Prefix.Formatting.Interfaces;

namespace Strict_INN_Validation_with_a_Prefix.Formatting
{
    internal class FirstNameFormatter : IFormatter<string>
    {
        public void Format(string firstName)
        {
            firstName = (char.ToUpper(firstName.Trim()[0]) + firstName.Trim().Substring(1).ToLower()).Trim();
        }

    }
}
