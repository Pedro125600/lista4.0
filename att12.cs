namespace att12
{
    internal class Program
    {
        static bool SaoAnagramas(string A, string B)
        {
            if (A.Length != B.Length)
            {
                return false;
            }

            char[] A1 = A.ToCharArray();
            char[] B1 = B.ToCharArray();
            int cont = 0;
            for(int i  = 0; i < A1.Length; i++)
            {
                for(int j = 0; j < B1.Length; j++)
                {
                    if (A1[i] == B1[j])
                    {
                        cont++;
                    }
                }
            }

            if( cont >= B.Length )
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }


            static void Main(string[] args)
        {
            Console.WriteLine("Escreva a primeira string");
            string A = Console.ReadLine();
            Console.WriteLine("Escreva a segunda string");
            string B = Console.ReadLine();

            Console.WriteLine($"As strings {A} e {B} são anagramas? {SaoAnagramas(A,B)}");

        }
    }
}
