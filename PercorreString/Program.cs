using System;

namespace PercorreString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Escreva uma string");
            string s = Console.ReadLine();
            Console.WriteLine("Escreva um caractér");
            char c = Console.ReadKey().KeyChar;
            s = s.Replace($"{c}","");
            Console.WriteLine();
            Console.WriteLine($"{s}");
        }
    }
}
