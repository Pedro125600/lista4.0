using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace att1
{
    class Program
    {
        static int PositivoNegativo(int n)
        {
            if (n > 0)
            
                return 1;

            else if (n < 0)
           
                return -1;
            
            else
                return 0;
        }



        static void Main(string[] args)
        {
            Console.WriteLine("De um valar para saber se o numero e positivo ou negativo ");
            int n = int.Parse(Console.ReadLine());


            Console.WriteLine("1 se positivo, -1 se negativo e 0 se for igual a 0.");
            Console.WriteLine($"Seu numero e : {PositivoNegativo(n)}");

            Console.ReadLine();
        }
    }
}
