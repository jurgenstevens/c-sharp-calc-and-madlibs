﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CalcAndMadLibs
{
    class CalcAndMadLibs
    {
        static void Main(string[] args)
        {
            // using the data type: double will allow you to use ints and decimals
            //Console.Write("Enter a number: ");
            //double num1 = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Enter another number: ");
            //double num2 = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine(num1 + num2);
            //Console.ReadLine();

            string color, pluralNoun, celebrity;

            Console.Write("Enter a color: ");
            color = Console.ReadLine();
            Console.Write("Enter a plural noun: ");
            pluralNoun = Console.ReadLine();
            Console.Write("Enter a celebrity: ");
            celebrity = Console.ReadLine();

            Console.WriteLine("Roses are " + color);
            Console.WriteLine(pluralNoun + " are blue");
            Console.WriteLine("I love " + celebrity);

            Console.ReadLine();
        }
    }
}

