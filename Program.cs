using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Working_with_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {//you can just prin out numbers as below
            Console.WriteLine(5);
            //you can use operators right in the writeline method ie + - * /
            Console.WriteLine(6 + 5);
            //modulo operator, to get the remainder of division, use %
            Console.WriteLine(5%2);
            //BODMAS still applies, 4+2*3 gets 10, use brackets to change the order 
            Console.WriteLine(4+2*3);
            //whatever you do just with integers, you get an integer back
            Console.WriteLine(5/2.0);
            //can also give a number to variable
            int number = 6;
            //can incement or decrement by 1
            number++;
            Console.WriteLine(number);
            //calling methods eg the Math method, Abs means Absolute
            // you will always get the positive number
            Console.WriteLine(Math.Abs(-40));
                //to raise to powers
                Console.WriteLine(Math.Pow(2,2));  
        }
    }
}