using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace att10
{
    class Program
    {
        static int Maior10(int[,] matriz)
        {
            int c = 0;
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                  if(matriz[i,j] > 10)
                    {
                        c++;
                    }
                }
              
            }

            return c;
        }

        static void Main(string[] args)
        {
            int[,] matriz = new int[4, 4];
            Console.WriteLine("matriz 4x4");
            Random r = new Random();
            for(int i = 0; i < matriz.GetLength(0); i++)
            {
                for(int j = 0; i < matriz.GetLength(1);i++)
                {
                    matriz[i, j] = r.Next(100);
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine($"A matriz possui {} numeros maiore que 10");

            Console.ReadLine();


        }
    }
}
