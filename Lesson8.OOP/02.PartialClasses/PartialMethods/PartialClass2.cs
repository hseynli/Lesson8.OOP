// Klasın ikinci hissəsi.
partial class PartialClass
{
    // partial metodun realizasiya. 
    partial void PartialMethod()
    {
        Console.WriteLine("partial metod cagirilir - PartialMethod()");
    }

    // bütün partial metodların bir partial metod olmayan metoddan çağırılması
    public void CallPartialMethod()
    {
        PartialMethod();

        // Realizasiya olunmayan partial metodu çağıranda kompilyator onu iqnor edəcək və heç bir xəta yaranmayacaqdır.
        MyMethod();
    }

    #region Partial metodları klasın digər hissələrində realizasiya etmək məcburi deyil!

    //partial void MyMethod()
    //{
    //    Console.WriteLine("Partial metodları klasın digər hissələrində realizasiya etmək məcburi deyil!"); ;
    //}

    #endregion
}