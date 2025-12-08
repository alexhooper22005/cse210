using System;

class Program
{
    static void Main(string[] args)
    {
        
        Address a1 = new Address("2nd West", "Rexburg", "Idaho", "USA");
        Customer c1 = new Customer("James Cooper", a1);

        Order o1 = new Order(c1);
        o1.AddProduct(new Product("Jacket", 1, 50, 1));
        o1.AddProduct(new Product("Graphic Tee", 2, 30, 2));

        Console.WriteLine(o1.GetPackingLabel());
        Console.WriteLine(o1.GetShippingLabel());
        
        Console.WriteLine($"Total price: ${o1.GetTotalPrice()}\n");


        Address a2 = new Address("Queen street", "Cardiff", "", "wales");
        Customer c2 = new Customer("Bob Smith", a2);

        Order o2 = new Order(c2);
        o2.AddProduct(new Product("Sweatpants", 3, 40, 1));
        o2.AddProduct(new Product("Graphic Tee", 2, 30, 2));

        Console.WriteLine(o2.GetPackingLabel());
        Console.WriteLine(o2.GetShippingLabel());
        
        Console.WriteLine($"Total price: ${o2.GetTotalPrice()}");

    }
}