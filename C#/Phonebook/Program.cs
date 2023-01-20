using PersonNameSpace;
using System;
using System.Linq;
using System.Text.RegularExpressions;


class Program
{
    static PersonRepository repo = new PersonRepository();
    static void Main(string[] args)
    {
        repo.AddDefaultPeople();


        Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçin:");
        Console.WriteLine("*******************************************");
        Console.WriteLine("(1) Yeni Numara Kaydetmek");
        Console.WriteLine("(2) Varolan Numarayı Silmek");
        Console.WriteLine("(3) Varolan Numarayı Güncelleme");
        Console.WriteLine("(4) Rehberi Listelemek");
        Console.WriteLine("(5) Rehberde Arama Yapmak");

        //Kullanıcının seçtiği işlem
        int choice = int.Parse(Console.ReadLine());

        //Seçilen işlem
        switch (choice)
        {
            case 1:
                Console.WriteLine("Lütfen isim giriniz: ");
                string firstName = Console.ReadLine();
                while (!Regex.IsMatch(firstName, @"^[a-zA-Z ]+$"))
                {
                    Console.WriteLine("Isim sadece harflerden oluşmalıdır. Lütfen tekrar giriniz: ");
                    firstName = Console.ReadLine();
                }

                Console.WriteLine("Lütfen soyisim giriniz: ");
                string lastName = Console.ReadLine();
                while (!Regex.IsMatch(lastName, @"^[a-zA-Z ]+$"))
                {
                    Console.WriteLine("Soyisim sadece harflerden oluşmalıdır. Lütfen tekrar giriniz: ");
                    lastName = Console.ReadLine();
                }

                Console.WriteLine("Lütfen telefon numarası giriniz: ");
                string phoneNumber = Console.ReadLine();
                while (!Regex.IsMatch(phoneNumber, @"^\d{10}$"))
                {
                    Console.WriteLine("Telefon numarası sadece 10 haneden oluşmalıdır. Lütfen tekrar giriniz: ");
                    phoneNumber = Console.ReadLine();
                }
                repo.AddPerson(new Person(firstName, lastName, phoneNumber));



                Console.WriteLine("Kayıt başarıyla eklendi.");
                Console.WriteLine("Isim: {0} Soyisim: {1} Telefon Numarası: {2}", firstName, lastName, phoneNumber);
                Console.WriteLine("Ana menüye dönmek için herhangi bir tuşa basın...");
                Console.ReadKey();
                Main(args);
                break;


            case 2:
                // Varolan numarayı silme işlemi
                break;
            case 3:
                // Varolan numarayı güncelleme işlemi
                break;
            case 4:
                List<Person> people = repo.GetPeople();
                foreach (var person in people)
                {
                    Console.WriteLine(person.ToString());
                }
                Console.WriteLine("Ana menüye dönmek için herhangi bir tuşa basın...");
                Console.ReadKey();
                Main(args);


                break;
            case 5:
                //Rehberde arama yapmak
                break;

        }
    }
}