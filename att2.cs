using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace att2
{
    class Program
    {
        static double TempF(double c)
        {
            return c * (9.0 / 5.0) + 32.0;
        }


        static void Main(string[] args)
        {
            Console.WriteLine("De uma temperatura em Celcius");
            double celcius = double.Parse(Console.ReadLine());


            Console.WriteLine($"A temperatira :{celcius} em Fahrenheit e : {TempF(celcius)}");

            Console.ReadLine();


        }
    }
}
