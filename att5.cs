using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace att5
{
    class Program
    {
        static void Etriangulo(double n1, double n2, double n3)
        {
            while(n1 < 0)
            {
                Console.WriteLine("O 1 valor tem que ser positivo");
                n1 = double.Parse(Console.ReadLine());
            }

            while (n2 < 0)
            {
                Console.WriteLine("O 2 valor tem que ser positivo");
                n2 = double.Parse(Console.ReadLine());
            }

            while (n3 < 0)
            {
                Console.WriteLine("O 3 valor tem que ser positivo");
                n3 = double.Parse(Console.ReadLine());
            }

            if (n1 < n2 + n3 && n2 < n1 + n3 && n3 < n1 + n2)
            {
                Console.WriteLine("Forman um triangulo");
            }
            else
            {
                Console.WriteLine("NÂO Forman um triangulo");

            }

        }

        static void TipoTriangulo(double n1, double n2, double n3)
        {
            if (n1 == n2 && n2 == n3)
            {
                Console.WriteLine("É um triângulo equilátero.");
            }
            else if (n1 == n2 || n1 == n3 || n2 == n3)
            {
                Console.WriteLine("É um triângulo isósceles.");
            }
            else
            {
                Console.WriteLine("É um triângulo escaleno.");
            }
        }

        static void Main(string[] args)
        {
            
            Console.Write("De o valor 1 :");
            double n1 = double.Parse(Console.ReadLine());
            Console.Write("De o valor 2 :");
            double n2 = double.Parse(Console.ReadLine());
            Console.Write("De o valor 3 :");
            double n3 = double.Parse(Console.ReadLine());

            Console.Write("Os tres valores:");
            Etriangulo(n1, n2, n3);
            TipoTriangulo(n1, n2, n3);
            Console.ReadLine();


        }


    }
}
