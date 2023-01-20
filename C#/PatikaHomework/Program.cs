namespace ConsoleApp
{
    internal class PatikaHomework1
    {
        static void Main(string[] args)
        {
            PositiveNumbers();
            DivisibleNumbers();
            ReverseWords();
            SentenceInfo();
        }
        static void PositiveNumbers()
        {
            Console.WriteLine("Pozitif bir sayi giriniz:");
            int n = Convert.ToInt32(Console.ReadLine());
            List<int> numbers = new List<int>();


            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}. sayıyı girin", i + 1);
                int number = Convert.ToInt32(Console.ReadLine());

                numbers.Add(number);
            }
            Console.WriteLine("Çift sayılar:");
            for (int i = 0; i < n; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    Console.WriteLine(numbers[i] + " ");
                }
            }
            Console.WriteLine();
            Console.ReadLine();
        }
        static void DivisibleNumbers()
        {
            Console.WriteLine("Pozitif bir sayi giriniz (n):");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Pozitif bir sayi giriniz (m):");
            int m = Convert.ToInt32(Console.ReadLine());

            List<int> numbers = new List<int>();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}. sayiyi giriniz:", i + 1);
                int number = Convert.ToInt32(Console.ReadLine());
                numbers.Add(number);
            }

            Console.WriteLine("m'ye eşit veya tam bölünen sayılar:");
            for (int i = 0; i < n; i++)
            {
                if (numbers[i] % m == 0)
                {
                    Console.WriteLine(numbers[i]);
                }
            }
            Console.ReadLine();
        }
        static void ReverseWords()
        {
            Console.WriteLine("Kac kelime gireceksiniz:");
            int n = Convert.ToInt32(Console.ReadLine());

            List<string> words = new List<string>();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}. kelimeyi giriniz:", i + 1);
                string word = Console.ReadLine();
                if (word != null)
                {
                    words.Add(word);
                }
                else
                {
                    Console.WriteLine("Girdi yok");
                }
            }

            Console.WriteLine("Kelimelerin tersi:");
            for (int i = n - 1; i >= 0; i--)
            {
                Console.WriteLine(words[i]);
            }

            Console.ReadLine();
        }
        static void SentenceInfo()
        {
            Console.WriteLine("Bir cümle giriniz:");
            string sentence = Console.ReadLine();

            if (sentence != null)
            {
                int wordCount = sentence.Split(new char[] { ' ', '.', ',' }, StringSplitOptions.RemoveEmptyEntries).Length;
                int letterCount = sentence.Length - sentence.Count(char.IsWhiteSpace);

                Console.WriteLine("Cümledeki toplam kelime sayısı: {0}", wordCount);
                Console.WriteLine("Cümledeki toplam harf sayısı: {0}", letterCount);
            }
            else
            {
                Console.WriteLine("Girdi yok");
            }
            Console.ReadLine();

        }
    }
}
