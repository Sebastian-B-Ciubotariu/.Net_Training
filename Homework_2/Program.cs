﻿namespace Homework_2
{
    public class Program
    {
        private static void Main(string[] args)
        {
            // Console.WriteLine("Problem 1");
            // Problem1();

            // Console.WriteLine("Problem 2");
            // Problem2();

            // Console.WriteLine("Problem 3");
            //Problem3();

            // Console.WriteLine("Problem 4");
            //Problem4();

            // Console.WriteLine("Problem 5");
            // Problem5();
        }

        //Write a program that reads a number from the keyboard. Check whether that number is divisible by 7 and 11 or not
        public static void Problem1()
        {
            int number = Convert.ToInt32(Console.ReadLine()); ;

            if (number % 7 == 0 & number % 11 == 0)
            {
                Console.WriteLine("The number you have entered is divisible by 7 and 11");
            }
            else
            {
                Console.WriteLine("The number you have entered is not divisible by 7 and 11");
            }
        }

        // Check whether a given year is leap year or not.
        public static void Problem2()
        {
            int year = Convert.ToInt32(Console.ReadLine());
            if (year % 400 == 0)
            {
                Console.WriteLine("This is a leap year");
            }
            else if (year % 100 == 0)
            {
                Console.WriteLine("This is not a leap year");
            }
            else if (year % 4 == 0)
            {
                Console.WriteLine("This is a leap year");
            }
            else
                Console.WriteLine("This is not a leap year");
        }

        //By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13. What is the 47th prime number?
        public static void Problem3()
        {
            int n = 47;  // the nth prime we want to find
            int count = 1;  // initialize count to 1 (we already know the first prime is 2)
            int num = 3;  // start checking for primes at 3

            while (count < n)
            {
                if (IsPrime(num))
                {
                    count++;
                }
                num += 2;  // only check odd numbers
            }

            Console.WriteLine("The " + n + "th prime number is " + (num - 2));
        }

        // returns true if n is prime, false otherwise
        static bool IsPrime(int n)
        {
            if (n < 2)
            {
                return false;
            }
            for (int i = 2; i * i <= n; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        //Each new term in the Fibonacci sequence is generated by adding the previous two terms. By starting with 1 and 2, the first 10 terms will be:
        // 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, ...
        //By considering the terms in the Fibonacci sequence whose values do not exceed 1000, find the sum of the even-valued terms.
        public static void Problem4()
        {
            int prev = 1;
            int curr = 2;
            int sum = 2;  // initialize sum to include the second number

            while (curr <= 1000)
            {
                int next = prev + curr;
                if (next > 1000)
                {
                    break;
                }
                prev = curr;
                curr = next;
                sum += curr;
            }

            Console.WriteLine("Sum of Fibonacci numbers <= 1000: " + sum);
        }


        //Find the sum of digits of a number read from the keyboard.
        public static void Problem5()
        {
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());

            int sum = 0;
            while (num > 0)
            {
                sum += num % 10;
                num /= 10;
            }

            Console.WriteLine("Sum of digits: " + sum);
        }


    }

}