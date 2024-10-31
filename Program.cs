using System;

namespace PrimeNumbers
{
    class Program
    {
        static void Main(string[] args)
        { //input
            Console.Write("Enter the starting number (n): ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Enter the ending number (m): ");
            int m = int.Parse(Console.ReadLine());

            Console.WriteLine($"Prime numbers between {n} and {m}:");
            for (int i = n; i <= m; i++)
            {
                if (IsPrime(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        // Method to check if a number is prime
        static bool IsPrime(int number)
        {
            if (number <= 1) return false; // Numbers less than 2 are not prime

            for (int i = 2; i * i <= number; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}

