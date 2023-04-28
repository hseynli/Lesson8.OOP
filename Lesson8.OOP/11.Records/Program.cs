Person tom = new Person("Tom", 37);
Person sam = tom with { Name = "Sam" };
Console.WriteLine($"{sam.Name} - {sam.Age}"); // Sam - 37

Console.WriteLine(new string('-', 80));

Person2 person = new Person2("Tom", 37) { Company = "Google" };
Console.WriteLine(person.Company); // Google
person.Company = "Microsoft";
Console.WriteLine(person.Company); // Microsoft
//person.Name = "Bob";    // ! default olaraq init götürülür, yeni dəyərə mənimsətmək OLMAZ!

public record Person(string Name, int Age);


public record Person2(string Name, int Age)
{
    public string Company { get; set; } = "";
}