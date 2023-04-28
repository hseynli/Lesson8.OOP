// Obyekt özündə heç bir üzvü eyni klasın digər obyektindən gizlədə (inkapsulyasiya) bilməz.

class MyClass
{
    MyClass my = null;

    private void Method()
    {
        Console.WriteLine("Hello");
    }

    public void CallMethod()
    {
        my = new MyClass();

        // private metod instance səviyyəsində çağrılır!
        my.Method();
    }
}

class Program
{
    static void Main()
    {
        MyClass my = new MyClass();
        my.CallMethod();
        //my.Method(); // Görsənmir.

        // Delay.
        Console.ReadKey();
    }
}