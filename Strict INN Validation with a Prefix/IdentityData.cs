using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strict_INN_Validation_with_a_Prefix
{
    internal class IdentityData
    {
        public string FirstName;
        public string LastName;
        public string TaxID;
        public IdentityData(string firstName, string lastName, string taxID)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.TaxID = taxID;
        }

        public override string ToString()
        {
            return $"Имя: {FirstName}, Фамилия: {LastName}, ИНН: {TaxID}";
        }
    }
}
