using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical3
{
    class Program
    {
        static void Main(string[] args)
        {
            Double number1;//declare number 1
            Double number2;//declare number 2
            Double average;//declare average of number 1 and number 2

            Console.Write("Enter first integer-");//prompt user
            //read first number from user
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second integer- ");//prompt user
            //read second number from user
            number2 = Convert.ToInt32(Console.ReadLine());
            average = (number1 + number2) / 2;//average numbers
            Console.WriteLine("average is {0}",average);//display average
            Console.Read();
        }
    }
}
