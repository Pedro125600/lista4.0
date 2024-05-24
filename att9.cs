using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace att9
{
    class Program
    {
        static void impresaoInversa(int[] v)
        {
            for (int i = v.Length-1; i >= 0; i--)
            {

                Console.Write(v[i] + " ");

            }
        }

        static void impresaoVetor(int[] v)
        {
            for (int i = 0; i < v.Length; i++)
            {
             
                Console.Write(v[i] + " ");

            }

        }

        static void MaiorMenor(out int menor, out int maior,int[] v)
        {
            maior = v[0];
            menor = v[0];

            for (int i = 1; i < v.Length; i++)
            {
                if(maior < v[i])
                {
                    maior = v[i];
                }

                if(menor > v[i])
                {
                    menor = v[i];
                }
            }

        }
        static void Main(string[] args)
        {

            Console.WriteLine("De o tamamho do vetor :");
            int v = int.Parse(Console.ReadLine());
            int[] vetor = new int[v];

            Random r = new Random();
            for (int i = 0; i < vetor.Length; i++)
            {
                vetor[i] = r.Next(100);
            }

            Console.WriteLine("Vetor:");
            impresaoVetor(vetor);
            Console.WriteLine("\nVetor inverso");
            impresaoInversa(vetor);

            int maior= 0, menor = 0;

            MaiorMenor(out menor, out maior, vetor);

            Console.WriteLine($"\nO menor valor e : {menor}");
            Console.WriteLine($"O maior valor e : {maior}");

            Console.ReadLine();
        }
    }
}
