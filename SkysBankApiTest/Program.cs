using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SkysBankApiTest.Api;

namespace SkysBankApiTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var client = new SweaWebServicePortTypeClient();
            var days = client.getCalendarDays(new DateTime(2022, 1, 1), new DateTime(2022, 2, 2));
            // sdffsdsdfdfs
            foreach (var day in days)
            {
                Console.WriteLine(day.bankday);
            }
        }
    }
}
