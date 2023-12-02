using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello! This is the ordering system.");
        Console.WriteLine();


        //Addresses
        Address address1 = new Address("Accra", "Greater Accra", "Ghana", "N576 hopeful street");
        Address address2 = new Address("Tamale", "Northern Region", "Ghana", "B345 Musa street");
        Address address3 = new Address("New York", "New York", "USA", "676 Sika street"); // usa address

        // customer
        Customer customer1 = new Customer("Mike Smith", address3); //usa customer
        Customer customer2 = new Customer("Ibrahim Musa", address2);
        Customer customer3 = new Customer("John Appiah", address1);

        // products
        Product product1 = new Product("P9 headphones", "P9707", 80.0m, 3);
        Product product2 = new Product("Iphone 7", "IP787", 800.0m, 1);
        Product product3 = new Product("Hp laptop", "HP345", 1000.0m, 3);
        Product product4 = new Product("P9 headphones", "P9707", 80.0m, 2);
        Product product5 = new Product("Iphone 8", "IP788", 850.0m, 3);
        Product product6 = new Product("Apple laptop", "P345", 1000.0m, 2);
        Product product7 = new Product("Boom headphones", "BM707", 90.0m, 3);
        Product product8 = new Product("Samsung A30", "SA787", 800.0m, 3);
        Product product9 = new Product("Hp laptop", "HPD345", 1200.0m, 1);

        // Order

        Order order1 = new Order(new List<Product> {product1, product3, product4}, customer1);
        Order order2 = new Order(new List<Product> {product6, product5, product9}, customer2);
        Order order3 = new Order(new List<Product> {product8, product7, product2}, customer3);


        // Display results
        Console.WriteLine("Order 1:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.CalculateTotalPrice():F2}\n");
        Console.WriteLine();

        Console.WriteLine("Order 2:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.CalculateTotalPrice():F2}\n");
        Console.WriteLine();

        Console.WriteLine("Order 3:");
        Console.WriteLine(order3.GetPackingLabel());
        Console.WriteLine(order3.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order3.CalculateTotalPrice():F2}\n");





    }
}