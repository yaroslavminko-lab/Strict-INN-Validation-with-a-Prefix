using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Strict_INN_Validation_with_a_Prefix
{
    internal class IdentityData
    {
        private string _firstName;
        private string _lastName;
        private string _taxID;

        const string pattern = @"^RU\d{10}$";

        public string FirstName {
            get => _firstName;
            set{
                if (string.IsNullOrEmpty(value))
                    _firstName = string.Empty;
                else
                    _firstName = (char.ToUpper(value.Trim()[0]) + value.Trim().Substring(1).ToLower()).Trim();
            }
        }
        public string LastName {
            get => _lastName;
            set => _lastName = string.IsNullOrEmpty(value)
                ? string.Empty;
                : (char.ToUpper(value.Trim()[0]) + value.Trim().Substring(1).ToLower()).Trim();

        }
        public string TaxID
        {
            get => _taxID;
            set => _taxID = string.IsNullOrEmpty(value) || !Regex.IsMatch(value.ToUpper(), pattern)
                ? string.Empty
                : value.ToUpper();
        }
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
