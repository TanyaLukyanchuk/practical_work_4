using System;

class Program
{
    static void Main(string[] args)
    {
        ShippingService shippingService = new ShippingService(10); 
        Package package1 = new Package("Книги", 0.5);
        Package package2 = new Package("Рецепты тортиков", 10.9);
        Package package3 = new Package("Лелё", 0.1);

        shippingService.SendPackage(package1); 
        shippingService.SendPackage(package2);
        shippingService.SendPackage(package3); 
    }
}