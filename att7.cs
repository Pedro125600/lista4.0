using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace att7
{
    class Program
    {
        static void simplifica(ref int nun ,ref int den)
        {
            int j = 0;
           
          for(int i = 1; i < nun || i < den; i++)
            {
                if(nun % i == 0 && den % i == 0)
                {
                    j = i;
                }
            }

          nun /= j;
          den /= j;



        }



        static void Main(string[] args)
        {
            Console.WriteLine("De o numerador da fração :");
            int nun = int.Parse(Console.ReadLine());

            Console.WriteLine("De o denominador da fração :");
            int den = int.Parse(Console.ReadLine());


            simplifica(ref nun, ref den);

            Console.WriteLine($"O numerador simplificado e : {nun}");
            Console.WriteLine($"O denominador simplificado e : {den}");


            Console.ReadLine();
        }
    }
}
