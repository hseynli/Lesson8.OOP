class MyClass1
{
    public MyClass1()
    {
        Console.WriteLine("MyClass1 klasinin instance-i yaradilib");
    }
}

class MyClass2
{
    private MyClass1 myObj = null;

    // Aşağıdakı metod fakriv metod deyil.
    public void Method()
    {
        myObj = new MyClass1();
    }
}

class Program
{
    static void Main()
    {
        MyClass2 my = new MyClass2();

        my.Method();

        // Delay.
        Console.ReadKey();
    }
}