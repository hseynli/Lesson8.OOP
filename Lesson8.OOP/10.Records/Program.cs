Person tom = new Person("Tom", 37);
Person sam = tom with { Name = "Sam" };
Console.WriteLine($"{sam.Name} - {sam.Age}"); // Sam - 37


var person1 = new Person("Tom", 37);
// Bütün property-ləri kopyalamaq
var person2 = person1 with { }; 

public record Person
{
    public string Name { get; init; }
    public int Age { get; init; }
    public Person(string name, int age)
    {
        Name = name; Age = age;
    }
}