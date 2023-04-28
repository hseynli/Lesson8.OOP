// partial metodlar ancaq partial klaslarda ola bilər.
// partial metodlar partial açar sözü ilə işarələnməlidir.
// partial metodlar həmişə private olur, digər access modifier-lərdən istifadə xətaya gətirib çıxaracaq
// partial metodların qaytardığı tip void olmalıdır.
// partial metodlar realizasiya OLUNMAYA bilər.

PartialClass instance = new PartialClass();

instance.CallPartialMethod();

Console.WriteLine("\nDone!");