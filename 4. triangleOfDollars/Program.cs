﻿using System;

namespace _4._triangleOfDollars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                for (int j = 0; j <= i; j++)
                { Console.Write("$ "); }
                Console.Write("\n");
            }
        }
    }
}
