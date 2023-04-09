using System;
using System.Globalization;
using System.Runtime.ExceptionServices;

namespace _7._chTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            // first half

            for (int i = 0; i < num; i++)
            { Console.Write(" "); }
            Console.WriteLine(" | ");

            for (int i = num - 1; i >= 0; i--)
            {
                for (int j = 0; j < i; j++)
                { Console.Write(" "); }

                for (int j = 0; j < num - i; j++)
                { Console.Write('*'); }
                Console.Write(" | ");

                //right half

                for (int j = 0; j < num - i; j++)
                { Console.Write("*"); }

                for (int j = 0; j < i; j++)
                { Console.Write(" "); }

                Console.Write("\n");


            }

        }
    }
}
