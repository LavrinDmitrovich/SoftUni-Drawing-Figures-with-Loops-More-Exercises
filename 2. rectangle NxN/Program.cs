﻿using System;

namespace _2._rectangle_NxN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                for (int j = 0; j < num; j++)
                { Console.Write("*"); }
                Console.Write("\n");
            }
        }
    }
}
