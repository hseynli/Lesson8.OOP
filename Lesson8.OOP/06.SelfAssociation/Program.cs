class MyClass
{
    MyClass instance;

    public MyClass()  // StackOverflowException
    {
        Console.WriteLine("Constructor MyClass");

        // Konstruktor sonsuz şəkildə yenidən instance yaratmağa çalışacaq.

        instance = new MyClass();
    }
}

class Program
{
    static void Main()
    {
        MyClass instance = new MyClass();

        // Delay.
        Console.ReadKey();
    }
}