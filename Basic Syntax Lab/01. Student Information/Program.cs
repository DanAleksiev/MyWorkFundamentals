﻿using System;

namespace _01._Student_Information
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            string name =Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            double grades= double.Parse(Console.ReadLine());
            Console.WriteLine($"Name: {name}, Age: {age}, Grade: {grades:f2}");
            }
        }
    }
