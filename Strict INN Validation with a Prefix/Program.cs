using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Strict_INN_Validation_with_a_Prefix
{
    class Program
    {
        private readonly static IInfoFetcher<IdentityData> infoFetcher = new InfoFetcher();

        static void Main(string[] args)
        {
            try
            {
                var data = infoFetcher.GetData();;

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
