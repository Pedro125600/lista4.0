namespace att13
{
    internal class Program
    {
        static void IntercalarStrings(ref string str1, string str2)
        {
            int n1 = str1.Length;
            int n2 = str2.Length;
            int minLength;

            if (n1 < n2)
            {
                minLength = n1;
            }
            else
            {
                minLength = n2;
            }

            char[] intercalada = new char[n1 + n2];

            int k = 0;
            for (int i = 0; i < minLength; i++)
            {
                
                intercalada[k] = str1[i];
                k++;
                intercalada[k] = str2[i];
                k++;
            }

            for (int i = minLength; i < n1; i++)
            {
                intercalada[k] = str1[i];
                k++;
            }

            for (int i = minLength; i < n2; i++)
            {
                intercalada[k] = str2[i];
                k++;
            }

            str1 = new string(intercalada);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Escreva a primeira string");
            string A = Console.ReadLine();
            Console.WriteLine("Escreva a segunda string");
            string B = Console.ReadLine();

            IntercalarStrings(ref A , B );

            Console.WriteLine($"String intercalada:{A} ");
        }
    }
}
