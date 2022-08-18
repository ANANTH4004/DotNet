using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace from9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            conversion();
            Console.WriteLine("===========CHECK NEGATIVE=======================");
            CheckNegative();
            Console.WriteLine("============NULL CHECK====================");
            StringExample();
            Console.WriteLine("============ METER TO KILOMETER ====================");
            MeterToKilometer();
            Console.WriteLine("============  KILOMETER TO METER ====================");
            KilometerToMeter();
            Console.WriteLine("============  USD TO INR ====================");
            UsdToInr();

        }

        private static void UsdToInr()
        {
            Console.WriteLine("Enter the Amount in USD : ");
            double usd = double.Parse(Console.ReadLine());
            Console.WriteLine("{0} USD is equal to {1} INR. ",usd , (usd * 79.65));
        }

        private static void KilometerToMeter()
        {
            Console.WriteLine("Enter No of KiloMeters :");
            double k  = double.Parse(Console.ReadLine());
            Console.WriteLine("{0} METER is equal to {1} KILOMETER", k, (k * 1000));
        }

        private static void MeterToKilometer()
        {
            Console.WriteLine("Enter No of Meters :");
            double m = double.Parse(Console.ReadLine());
            Console.WriteLine("{0} METER is equal to {1} KILOMETER", m, (m / 1000));
        }

        private static void CheckNegative()
        {
            Console.WriteLine("Input first Integer :");
            int i1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Input second Integer :");
            int i2 = Int32.Parse(Console.ReadLine());
            if (i1 < 0 || i2 < 0)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
        }

        private static void conversion()
        {
            Console.WriteLine("Enter the Amount of Celcious :");
            int c = Int32.Parse(Console.ReadLine());
            Console.WriteLine("kelvin = {0}", c + 273);
            Console.WriteLine("Fahrenheit = {0}", (c * 1.8) + 32);
        }

        private static void StringExample()
        {
            string name = String.Empty;
            Console.WriteLine("Enter Your Name : ");
            name = Console.ReadLine();
            Console.WriteLine(String.IsNullOrEmpty(name));
        }
    }
}
