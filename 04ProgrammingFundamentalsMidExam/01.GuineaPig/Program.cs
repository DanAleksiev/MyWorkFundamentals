﻿using System;

namespace _01.GuineaPig
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            decimal food = decimal.Parse(Console.ReadLine());
            decimal hay = decimal.Parse(Console.ReadLine());
            decimal cover = decimal.Parse(Console.ReadLine());
            decimal puppysWaight = decimal.Parse(Console.ReadLine());

            for (int i = 1; i <= 30; i++)
                {
                food -= 0.3m;
                if (i % 2 == 0)
                    {
                    decimal haygiven = food * 0.05m;
                    hay -= haygiven;
                    }
                if (i % 3 == 0)
                    {
                    decimal coverGiven = puppysWaight / 3;
                    cover -= coverGiven;
                    }
                if (food == 0 && hay == 0 && cover == 0)
                    {
                    break;
                    }

                if (food <= 0 || hay <= 0 || cover <= 0)
                    {
                    Console.WriteLine("Merry must go to the pet store!");
                    break;
                    }
                }

            if (food > 0 && hay > 0 && cover > 0)
                {
                Console.WriteLine($"Everything is fine! Puppy is happy! Food: {food:f2}, Hay: {hay:f2}, Cover: {cover:f2}.");
                }
            }
        }
    }
