using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("===ORDER PROCESSING SYSTEM===\n");

        // First customer order from USA
        Address address1 = new Address("123 Main St", "Anytown", "NY", "USA");
        // CREATE CUSTOMER
        Customer customer1 = new Customer("John Philip", address1);
        // CREATE ORDER
        Order order1 = new Order(customer1);
        //ADD PRODUCTS
        order1.AddProduct(new Product("Laptop", "LP-1001", 29.99, 2));
        order1.AddProduct(new Product("Mouse", "MS-2002", 79.99, 1));
        order1.AddProduct(new Product("Keyboard", "KB-3003", 50.00, 1));
        // DISPLAY ORDER
        Console.WriteLine($"ORDER #1");
        Console.WriteLine($"Customer Location: {(customer1.LivesInUSA() ? "USA" : "International")}");
        


        Console.WriteLine();
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine();
        Console.WriteLine($"Total Price: ${order1.GetTotalPrice():F2}");
        Console.WriteLine("\n" + new string('-', 50)+ "\n");

        // second order for international customer
        Address address2 = new Address("456 Queen St", "Toronto", "Onatario", "Canada");
        Customer customer2 = new Customer("Emily Johnson", address2);
        // create order
        Order order2 = new Order(customer2);
        // add products
        order2.AddProduct(new Product("Smartphone", "SP-4004", 500.00, 1));
        order2.AddProduct(new Product("Headphones", "HP-5005", 150.00, 2));
        //Display order
        Console.WriteLine($"ORDER #2");
        Console.WriteLine($"Customer Location: {(customer2.LivesInUSA() ? "USA" : "International")}");

        Console.WriteLine();
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine();
        Console.WriteLine($"Total Price: ${order2.GetTotalPrice():F2}");
        Console.WriteLine("\n" + new string('-', 50)+ "\n");


        // order 3 for customer in USA
        Address address3 = new Address("789 Oak Ave", "Seattle", "WA", "United States");
        Customer customer3 = new Customer("Michael Smith", address3);
        Order order3 = new Order(customer3);
        // add products
        order3.AddProduct(new Product("Tablet", "TB-6006", 300.00, 1));
        order3.AddProduct(new Product("Webcam HD", "WC-7007", 80.00, 1));
        order3.AddProduct(new Product("External Hard Drive", "HD-8008", 120.00, 1));

        // display order 3
        Console.WriteLine($"ORDER #3");
        Console.WriteLine($"Customer Location: {(customer3.LivesInUSA() ? "USA" : "International")}");
        Console.WriteLine();
        Console.WriteLine(order3.GetPackingLabel());
        Console.WriteLine(order3.GetShippingLabel());
        Console.WriteLine();
        Console.WriteLine($"Total Price: ${order3.GetTotalPrice():F2}");
        



    } 
    
}