using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1;//declare first number to add
            int number2;//declare second number to add
            int number3;//declare third number to add
            int sum; //declare sum of number 1 , number2 and number 3

            Console.Write("Enter first integer: "); //prompt user
            // read first number from user
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second integer: ");//prompt user
           //read second number from user
            number2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter third integer ");//prompt user
            // read third number from user
            number3 = Convert.ToInt32(Console.ReadLine());
            sum = number1 + number2 + number3; //add numbers
            Console.WriteLine("Sum is {0}", sum); //display sum
            Console.Read();
        }
    }
}
