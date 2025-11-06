using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strict_INN_Validation_with_a_Prefix
{
    internal class IdentityData
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string TaxID { get; set; }
        public IdentityData(string firstName, string lastName, string taxID)
        {
            this.FirstName = firstName ?? string.Empty;
            this.LastName = lastName ?? string.Empty;
            this.TaxID = taxID ?? string.Empty;
        }

        public override string ToString()
        {
            return $"Имя: {FirstName}, Фамилия: {LastName}, ИНН: {TaxID}";
        }
    }
}
