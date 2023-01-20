using PersonNameSpace;

class PersonRepository
{
    private List<Person> _people;

    public PersonRepository()
    {
        _people = new List<Person>();
        AddDefaultPeople();
    }
    public void AddPersonIfNotExist(Person person)
    {
        if (!_people.Any(p => p.FirstName == person.FirstName && p.LastName == person.LastName))
        {
            _people.Add(person);
        }
    }

    public void AddDefaultPeople()
    {
        //Varsayılan olarak 5 kişi ekleme
        AddPersonIfNotExist(new Person("John", "Doe", "555-555-5555"));
        AddPersonIfNotExist(new Person("Jane", "Smith", "555-555-5556"));
        AddPersonIfNotExist(new Person("Bob", "Johnson", "555-555-5557"));
        AddPersonIfNotExist(new Person("Michael", "Jones", "555-555-5559"));
        AddPersonIfNotExist(new Person("Samantha", "Williams", "555-555-5558"));

    }
    public void AddPerson(Person person)
    {
        if (!_people.Any(p => p.FirstName == person.FirstName && p.LastName == person.LastName))
        {
            _people.Add(person);
            Console.WriteLine("Record added successfully.");
        }
        else
        {
            Console.WriteLine("A person with the same name and surname already exists in the phone book.");
        }
    }


    public void RemovePerson(Person person)
    {
        _people.Remove(person);
    }
    public List<Person> GetPeople()
    {
        return _people;
    }

}
