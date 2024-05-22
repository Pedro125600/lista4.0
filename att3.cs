using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace att3
{
    class Program
    {
        static double CalcularP(double n1, double n2, double n3)
        {


           return  (n1 * 5 + n2 * 3 + n3 * 2) / 10;
      


        }
        static double CalcularA(double n1, double n2, double n3)
        {

            return (n1 + n2 + n3) / 3.0;
        


        }
        public static void Main(string[] args)
        {
            Console.Write("Escreva o Primeiro valor :");
            double n1 = double.Parse(Console.ReadLine());
            Console.Write("Escreva o Segundo valor :");
            double n2 = double.Parse(Console.ReadLine());
            Console.Write("Escreva o terceiro valor :");
            double n3 = double.Parse(Console.ReadLine());

            Console.WriteLine("Escolha uma opção \n A:calcular e escrever a média aritmética dos valores \n P: imprimir a média ponderada, usando os seguintes pesos: 5, 3 e 2");
            char op = char.Parse(Console.ReadLine());

            if (op == 'A')
            {
                Console.WriteLine($"A media aritimetica e : {CalcularA(n1 , n2 , n3)}");
            }

            else if (op == 'P')
            {
                Console.WriteLine($"A media ponderada e : {CalcularP(n1, n2, n3)}");
            }
            else
            {
                Console.WriteLine("opção invalida");
            }


            Console.ReadLine();
        }
    }
}
