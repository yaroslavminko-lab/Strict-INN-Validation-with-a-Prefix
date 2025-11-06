using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strict_INN_Validation_with_a_Prefix.Validatting.Interfaces
{
    internal interface IValidator<T>
    {
        void Validate(T data);
    }
}
