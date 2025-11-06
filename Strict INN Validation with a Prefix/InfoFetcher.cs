using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strict_INN_Validation_with_a_Prefix
{
    internal class InfoFetcher : IInfoFetcher<IdentityData>
    {
        public IdentityData GetData()
        {
            try
            {
                Console.Write("Введите имя: ");
                var firstName = Console.ReadLine();
                Console.Write("Введите фамилию: ");
                var lastName = Console.ReadLine();
                Console.Write("Введите ИНН: ");
                var taxID = Console.ReadLine();

                return new IdentityData(firstName, lastName, taxID);
            } 
            catch(Exception e)
            {
                Console.WriteLine("Проблема с получением данных. ", e.Message);
                return null;
            }
        }
    }
}
