using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Strict_INN_Validation_with_a_Prefix.Formatting;
using Strict_INN_Validation_with_a_Prefix.Formatting.Interfaces;
using Strict_INN_Validation_with_a_Prefix.Validatting;
using Strict_INN_Validation_with_a_Prefix.Validatting.Interfaces;


namespace Strict_INN_Validation_with_a_Prefix
{
    class Program
    {
        private readonly static IInfoFetcher<IdentityData> infoFetcher = new InfoFetcher();

        private readonly static IFormatter<IdentityData> formatter = FormatterFactory.CreateFormatter();
        private readonly static IValidator<IdentityData> validator = ValidatorFactory.CreateValidator();
        static void Main(string[] args)
        {
            try
            {
                var data = infoFetcher.GetData();

                formatter.Format(ref data);
                validator.Validate(ref data);

                Console.WriteLine(data.ToString());
                Console.ReadKey();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
