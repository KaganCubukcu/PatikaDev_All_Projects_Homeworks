using System;
using System.Collections;

class PrimeNumbers
{
    public static bool isPrime(int num)
    {
        if (num <= 1) return false;
        if (num == 2) return true;
        if (num % 2 == 0) return false;

        int boundary = (int)Math.Floor(Math.Sqrt(num));
        for (int i = 3; i <= boundary; i += 2)
        {
            if (num % i == 0) return false;
        }
        return true;
    }
    public static void Main()
    {
        ArrayList primeList = new ArrayList();
        ArrayList nonPrimeList = new ArrayList();

        for (int i = 0; i <= 20; i++)
        {
            Console.WriteLine("Enter the {0}. positive number:", i);
            int num = int.Parse(Console.ReadLine());

            if (num < 0)
            {
                Console.WriteLine("Invalid input. Please enter a positive number.");
                i--;
                continue;
            }
            if (isPrime(num))
            {
                primeList.Add(num);
            }
            else
            {
                nonPrimeList.Add(num);
            }
        }
        primeList.Sort();
        primeList.Reverse();
        nonPrimeList.Sort();
        nonPrimeList.Reverse();

        Console.WriteLine("Prime numbers:");
        foreach (int num in primeList)
        {
            Console.WriteLine(num + " ");

        }
        Console.WriteLine();

        Console.WriteLine("Non-prime numbers:");
        foreach (int num in nonPrimeList)
        {
            Console.WriteLine(num + " ");
        }
        Console.WriteLine();

        Console.WriteLine("Number of prime numbers: " + primeList.Count);
        Console.WriteLine("Number of non-prime numbers: " + nonPrimeList.Count);

        int primeSum = 0;

        foreach (int num in primeList)
        {
            primeSum += num;
        }
        Console.WriteLine("Average of prime numbers: " + primeSum / primeList.Count);

        int nonPrimeSum = 0;
        foreach (int num in nonPrimeList)
        {
            nonPrimeSum += num;
        }
        Console.WriteLine("Average of non-prime numbers: " + nonPrimeSum / nonPrimeList.Count);
    }
}