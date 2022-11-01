using System;

namespace Day5Assign
{
    class Program
    {
        static void Main(string[] args)
        {
            // declare variable
            int n;

            //take input 
            Console.Write("Enter the number = ");
            n = Convert.ToInt32(Console.ReadLine());

            //check if n is even or odd 
            if (n % 2 == 0)
                Console.WriteLine(n + " is even");
            else
                Console.WriteLine(n + " is odd");

            // wait for user to press any key
            Console.ReadKey();
        }
    }
}

