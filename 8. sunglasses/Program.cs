using System;

namespace _8._sunglasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int numnum = (num + 1) / 2 -1;

            //first line
            for (int i = 0; i < num * 5; i++)
            {
                if (i < num * 2) Console.Write("*");
                if (i >= num * 2 && i < num * 3) Console.Write(" ");
                if (i >= num * 3) Console.Write("*");
            }
            Console.Write("\n");

            // 2->mid-1 lines
            for (int j=0; j<numnum-1; j++)
            { 
                for (int i = 0; i < num * 5; i++)
                    {
                         if (i == 0) Console.Write("*");
                         if (i > 0 && i < num * 2-1) Console.Write("/");
                         if (i == num*2-1) Console.Write("*");  
                         if (i > num * 2-1 && i <num*3) Console.Write(" ");
                         if (i == num*3) Console.Write("*");
                         if (i>num*3 && i<num*5-1) Console.Write("/");
                         if (i == num*5-1) Console.Write("*");
                    }
                Console.Write("\n");
            }
            
            //mid line
            for (int i = 0; i < num * 5; i++)
            {
                if (i == 0) Console.Write("*");
                if (i > 0 && i < num * 2 - 1) Console.Write("/");
                if (i == num * 2 - 1) Console.Write("*");
                if (i > num * 2 - 1 && i < num * 3) Console.Write("|");
                if (i == num * 3) Console.Write("*");
                if (i > num * 3 && i < num * 5 - 1) Console.Write("/");
                if (i == num * 5 - 1) Console.Write("*");
            }
            Console.Write("\n");

            // mid+1 -> n-1 lines
            for (int j = numnum; j < num-2; j++)
            {
                for (int i = 0; i < num * 5; i++)
                {
                    if (i == 0) Console.Write("*");
                    if (i > 0 && i < num * 2 - 1) Console.Write("/");
                    if (i == num * 2 - 1) Console.Write("*");
                    if (i > num * 2 - 1 && i < num * 3) Console.Write(" ");
                    if (i == num * 3) Console.Write("*");
                    if (i > num * 3 && i < num * 5 - 1) Console.Write("/");
                    if (i == num * 5 - 1) Console.Write("*");
                }
                Console.Write("\n");
            }

            //last line
            for (int i = 0; i < num * 5; i++)
            {
                if (i < num * 2) Console.Write("*");
                if (i >= num * 2 && i < num * 3) Console.Write(" ");
                if (i >= num * 3) Console.Write("*");
            }
            

        }
    }
}
