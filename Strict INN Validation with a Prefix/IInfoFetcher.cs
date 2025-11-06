using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strict_INN_Validation_with_a_Prefix
{
    internal interface IInfoFetcher<T>
    {
        T GetData();
    }
}
