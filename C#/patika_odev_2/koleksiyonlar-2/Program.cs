using System;
using System.Linq;

class FindNumbers
{
    public static void Main()
    {
        int[] numbers = new int[20];

        for (int i = 0; i < 20; i++)
        {
            Console.WriteLine("Enter the {0}. number:", i);
            numbers[i] = int.Parse(Console.ReadLine());
        }
        int[] top3 = numbers.OrderByDescending(x => x).Take(3).ToArray();
        int[] bottom3 = numbers.OrderBy(x => x).Take(3).ToArray();

        Console.WriteLine("Top 3 numbers:");
        foreach (int num in top3)
        {
            Console.WriteLine(num + " ");
        }
        Console.WriteLine();

        Console.WriteLine("Bottom 3 numbers:");
        foreach (int num in bottom3)
        {
            Console.WriteLine(num + " ");
        }
        Console.WriteLine();

        double top3Avg = top3.Average();
        double bottom3Avg = bottom3.Average();
        Console.WriteLine("Top 3 numbers average: " + top3Avg);
        Console.WriteLine("Bottom 3 numbers average: " + bottom3Avg);
        Console.WriteLine("Total average: " + (top3Avg + bottom3Avg) / 2);
    }
}