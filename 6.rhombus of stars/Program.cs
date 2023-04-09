using System;

namespace _6.rhombus_of_stars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            // first half

            for (int i = num-1; i >= 0; i--)
            {
                for (int j = 0; j < i; j++)
                { Console.Write(" "); }

                for (int j = 0; j < num - i; j++)
                { Console.Write('♦' + " "); }

                Console.Write("\n");
            }

            // second half

            for (int i = 1; i < num; i++)
            {
                for (int j = 0; j < i; j++)
                { Console.Write(" "); }

                for (int j = 0; j < num - i; j++)
                { Console.Write('♦' + " "); }

                Console.Write("\n");
            }

            
        }
    }
}
