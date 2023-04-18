using System;

namespace _9._house
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numnum = int.Parse(Console.ReadLine());
            int num = 0;

            if (numnum%2 ==0) { num = numnum / 2; }
            else { num = (numnum+1) / 2; }

            // first half

            for (int i = num - 1; i >= 0; i--)
            {
                for (int j = 0; j < i; j++)
                { Console.Write("-"); }

                for (int j = 0; j < numnum - 2*i; j++)
                { Console.Write('*'); }

                for (int j = i-1; j >= 0; j-- )
                { Console.Write("-"); }


                Console.Write("\n");
            }

            for (int i = 0; i < numnum - num; i++) 
            {
                Console.Write("|");
                for (int j = 0;j < numnum-2; j++) {Console.Write("*"); }
                Console.Write("|");
                Console.Write("\n");

            }
        }
    }
}
