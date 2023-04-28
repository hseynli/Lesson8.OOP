// fabrik metodlar texnoloqiyasından istifadə
class Product
{
    public Product()
    {
        Console.WriteLine("Product klasinin instance-i yaradilib");
    }
}

class Factory
{
    public Product FactoryMethod()
    {
        return new Product();
    }
}

class Program
{
    static void Main()
    {
        Factory factory = new Factory();

        Product product = factory.FactoryMethod();

        // Delay.
        Console.ReadKey();
    }
}