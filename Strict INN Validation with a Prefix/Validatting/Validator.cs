using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Strict_INN_Validation_with_a_Prefix.Validatting.Interfaces;

namespace Strict_INN_Validation_with_a_Prefix.Validatting
{
    internal class Validator : IValidator<IdentityData>
    {
        readonly private IValidator<string> _taxIDValidator;

        public Validator(IValidator<string> taxIDValidator)
        {
            this._taxIDValidator = taxIDValidator;
        }
        public void Validate(ref IdentityData data)
        {
            this._taxIDValidator.Validate(ref data.TaxID);
        }
    }
}
