namespace list4
{
    internal class Program
    {
        static int SomaAbaixoDiagonal(int[,] matriz)
        {
            int soma = 0;

            for (int i = 1; i < 3; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    soma += matriz[i, j];
                }
            }

            return soma;
        }


        static void Main(string[] args)
        {
            int[,] matriz = new int[3, 3];
            Console.WriteLine("matriz 3x3");
            Random r = new Random();

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = r.Next(100);
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine("\n");
            }

        
            Console.WriteLine($"A soma dos elementos abaixo da diagonal principal é:{SomaAbaixoDiagonal(matriz)} " );
        }

     
    
    }
}
