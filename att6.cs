using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace att6
{
    class Program
    {
        static double CalcS(int N)
        {
            double s = 0;

            for(int i = 1; i <= N; i++)
            {
                s += (( i * i ) + 1) / (double)(i + 3);
            }

            return s;

        }


        static void Main(string[] args)
        {
            Console.WriteLine("De o valor de N");
            int N = int.Parse(Console.ReadLine());

            Console.WriteLine($"o valor de s e : {CalcS(N)}");


            Console.ReadLine();
        }
    }
}
