using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace att8
{
    class Program
    {
        static double media(int[] v)
        {
            int media = 0;
            int i = 0;

            while(i < v.Length)
            {
                media += v[i];
                i++;
            }


            return media / i;
        }


        static void Main(string[] args)
        {
            Console.WriteLine("De o tamamho do vetor :");
            int v = int.Parse(Console.ReadLine());
            int[] vetor = new int[v];

            Random r = new Random();
            Console.WriteLine("Vetor:");

            for(int i = 0; i < vetor.Length; i++)
            {
                vetor[i] = r.Next(100);
                Console.Write(vetor[i] + " ");

            }

            Console.WriteLine($"a media dos numeros do vetor r : {media(vetor)}");
            Console.ReadLine();
        }
    }
}
