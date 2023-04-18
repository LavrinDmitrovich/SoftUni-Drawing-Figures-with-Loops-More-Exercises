using System;
using System.Reflection.Emit;

namespace _10._Diamond
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numnum2 = int.Parse(Console.ReadLine());
            int numnum = numnum2 - 2;
            int num = 0;
            int num2 = 0;

            if (numnum % 2 == 0) { num = numnum / 2; }
            else { num = (numnum + 1) / 2; }
            if (numnum2 % 2 == 0) { num2 = numnum2 / 2; }
            else { num2 = (numnum2 + 1) / 2; }

            if (numnum2<=2) { goto label; }

            // first line
            for (int i = num2 - 1; i > num2 - 2; i--)
            {
                for (int j = 0; j < i; j++) { Console.Write("-"); }
                for (int j = 0; j < numnum2 - 2 * i; j++) { Console.Write("*"); }
                for (int j = i - 1; j >= 0; j--) { Console.Write("-"); }
                Console.Write("\n");
            }

            // first half
            for (int i = num -1 ; i >= 0; i--)
            {
                for (int j = 0; j < i; j++) { Console.Write("-"); }
                Console.Write("*");
                for (int j = 0; j < numnum - 2 * i; j++) { Console.Write("-"); }
                Console.Write("*");
                for (int j = i ; j > 0; j--) { Console.Write("-"); }
                Console.Write("\n");
            }

            // second half
            for (int i =  1; i < num; i++)
            {
                for (int j = 0; j < i; j++) { Console.Write("-"); }
                Console.Write("*");
                for (int j = 0; j < numnum - 2 * i; j++) { Console.Write("-"); }
                Console.Write("*");
                for (int j = i; j > 0; j--) { Console.Write("-"); }
                Console.Write("\n");
            }
            // last line

            label:
            for (int i = num2 - 1; i > num2 - 2; i--)
            {
                for (int j = 0; j < i; j++) { Console.Write("-"); }
                for (int j = 0; j < numnum2 - 2 * i; j++) { Console.Write("*"); }
                for (int j = i - 1; j >= 0; j--) { Console.Write("-"); }
                Console.Write("\n");
            }

            

        }
    }
}
