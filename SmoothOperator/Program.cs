using System;

namespace SmoothOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            //ask user for input
            Console.Write("Insere um número inteiro não negativo: ");
            string response = Console.ReadLine();
            //convert string to byte
            byte n = byte.Parse(response);
            //print results
            Console.WriteLine(--n);
            Console.WriteLine(++n);
            Console.WriteLine(n/2);
            Console.WriteLine(n<<3);
            Console.WriteLine(n^5);
            Console.WriteLine(n>10);
        }
    }
}
