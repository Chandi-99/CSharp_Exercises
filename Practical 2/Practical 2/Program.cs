﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1;
            int number2;

            Console.Write("Enter first integer-");
            number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second integer-");
            number2 = Convert.ToInt32(Console.ReadLine());

            if (number1 == number2)
            Console.WriteLine("{0}=={1}", number1, number2);

            if (number1 != number2) 
            Console.WriteLine("{0}!={1}",number1, number2);

            if (number1 < number2) 
            Console.WriteLine("{0}<{1}", number1, number2);

            if (number1 > number2) 
            Console.WriteLine("{0}>{1}", number1, number2);

            if (number1 <= number2) 
            Console.WriteLine("{0}<={1}", number1, number2);

            if (number1 >= number2)
            Console.WriteLine("{0}>={1}", number1, number2);

            Console.ReadLine();

        }
    }
}
