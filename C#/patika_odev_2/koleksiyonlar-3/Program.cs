using System;
using System.Linq;
using System.Collections.Generic;

class Vowels
{
    public static void Main()
    {
        Console.WriteLine("Enter a sentence:");
        string sentence = Console.ReadLine();

        List<char> vowels = new List<char>();
        string vowelsInTurkish = "aeıioöuüAEIİOÖUÜ";
        for (int i = 0; i < sentence.Length; i++)
        {
            if (vowelsInTurkish.Contains(sentence[i]))
            {
                vowels.Add(sentence[i]);
            }
        }

        vowels.Sort();

        Console.WriteLine("Vowels in the sentence:");
        foreach (char vowel in vowels)
        {
            Console.Write(vowel + " ");
        }
        Console.WriteLine();
    }
}
