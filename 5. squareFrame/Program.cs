using System;

namespace _5._squareFrame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            Console.Write("+ ");
            for (int i=0;  i < num-2; i++) { Console.Write("- "); }
            Console.Write("+");
            Console.Write("\n");

            for (int i = 0; i < num-2; i++)
            {
                Console.Write("| ");
                for (int j=0; j < num - 2; j++) { Console.Write("- "); }
                Console.Write("|");
                Console.Write("\n");

            }
            Console.Write("+ ");
            for (int i = 0; i < num - 2; i++) { Console.Write("- "); }
            Console.Write("+");
            Console.Write("\n");

        }
    }
}
