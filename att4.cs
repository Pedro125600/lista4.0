using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace att4
{
    class Program
    {
        static void Soma(double n1, double n2)
        {
            double result = n1 + n2;
            Console.WriteLine("A soma e  " + result);
        }

        static void Sub(double n1, double n2)
        {
            double result;

            if (n1 > n2)
            {
                result = n1 - n2;

            }
            else
            {
                result = n2 - n1;

            }
            Console.WriteLine("A diferença e" + result);
        }

        static void Mult(double n1, double n2)
        {
            double result;
            result = n1 * n2;
            Console.WriteLine("O produto e " + result);
        }

        static void div(double n1 , double n2)
        {
            double result;
            while (n2 == 0)
            {
                Console.WriteLine("O denominador não pode ser zero escolha outro");
                n2 = double.Parse(Console.ReadLine());
            }
            result = n1 / n2;
            Console.WriteLine("A divisão deu " + result);
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Escolha a opção");
            Console.WriteLine("+");
            Console.WriteLine("-");
            Console.WriteLine("*");
            Console.WriteLine("/");

            char opcao = char.Parse(Console.ReadLine());

            Console.WriteLine("Escolha um numero se for fazer divisao este e o numerador");
            double n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Escolha outro numero se for fazer divisao este e o denominador");
            double n2 = double.Parse(Console.ReadLine());
            double result;

            switch (opcao)
            {
                case '+':
                    Soma(n1, n2);

                    break;

                case '-':
                    Sub(n1, n2);
                    break;

                case '*':Mult(n1, n2);

                    break;

                case '/':
                    div(n1, n2);
                    break;
                default:Console.WriteLine("Valor Infalido");break;
            }


            Console.ReadLine();
        }
    }
}
