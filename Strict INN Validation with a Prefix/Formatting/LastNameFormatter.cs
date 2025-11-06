using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Strict_INN_Validation_with_a_Prefix.Formatting.Interfaces;


namespace Strict_INN_Validation_with_a_Prefix.Formatting
{
    class LastNameFormatter : IFormatter<string>
    {
        public void Format(ref string lastName)
        {
            if (string.IsNullOrWhiteSpace(lastName))
            {
                lastName = string.Empty;
                return;
            }

            lastName = (char.ToUpper(lastName.Trim()[0]) + lastName.Trim().Substring(1).ToLower()).Trim();
        }
    }
}
