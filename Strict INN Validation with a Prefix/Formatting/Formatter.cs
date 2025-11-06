using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Strict_INN_Validation_with_a_Prefix.Formatting.Interfaces;


namespace Strict_INN_Validation_with_a_Prefix.Formatting
{
    internal class Formatter : IFormatter<IdentityData>
    {
        readonly private IFormatter<string> _firstNameFormatter;
        readonly private IFormatter<string> _lastNameFormatter;
        public Formatter(IFormatter<string> firstNameFormatter, IFormatter<string> lastNameFormatter)
        {
            this._firstNameFormatter = firstNameFormatter;
            this._lastNameFormatter = lastNameFormatter;
        }
        public void Format(IdentityData data)
        {
            _firstNameFormatter.Format(data.FirstName);
            _lastNameFormatter.Format(data.LastName);
        }
    }
}
