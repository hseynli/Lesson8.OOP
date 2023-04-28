public class PersonClass
{
    public string Name { get; set; }
    public PersonClass(string name) => Name = name;
}

public record PersonRecord
{
    public string Name { get; set; }
    public PersonRecord(string name) => Name = name;
}

public record class PersonRecordClass
{
    public string Name { get; set; }
    public PersonRecordClass(string name) => Name = name;
}

class Program
{
    public static void Main()
    {
        PersonRecord person1 = new PersonRecord("Tom");
        PersonRecord person2 = new PersonRecord("Tom");
        Console.WriteLine(person1.Equals(person2)); // true
        Console.WriteLine(person1 == person2);      // true

        Console.WriteLine(new string('-', 80));

        PersonClass personClass = new PersonClass("Tom");
        PersonClass personClass2 = new PersonClass("Tom");
        Console.WriteLine(personClass.Equals(personClass2)); // false
        Console.WriteLine(personClass == personClass2);      // false
    }
}