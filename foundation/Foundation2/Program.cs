using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Order 1: Parker Morgan
        Address address1 = new Address("15613 NE 15th Circle", "Vancouver", "Washington", "USA");
        Customer customer1 = new Customer("Parker Morgan", address1);

        List<Product> products1 = new List<Product>
        {
            new Product("Graphing Calculator", "GC200", 65.99, 1),
            new Product("Notebook", "NB50", 3.50, 5),
            new Product("Mechanical Pencil", "MP05", 1.99, 10)
        };

        Order order1 = new Order(products1, customer1);

        Console.WriteLine("Order 1:");
        order1.Display();
        Console.WriteLine();

        // Order 2: Alice Johnson
        Address address2 = new Address("47 Maple Drive", "Denver", "Colorado", "USA");
        Customer customer2 = new Customer("Alice Johnson", address2);

        List<Product> products2 = new List<Product>
        {
            new Product("Desk Chair", "DC100", 120.00, 1),
            new Product("Table Lamp", "TL20", 25.50, 2),
            new Product("Whiteboard Markers", "WM10", 10.99, 4)
        };

        Order order2 = new Order(products2, customer2);

        Console.WriteLine("Order 2:");
        order2.Display();
        Console.WriteLine();

        // Order 3: John Smith (Outside the US)
        Address address3 = new Address("45 High Street", "London", "England", "UK");
        Customer customer3 = new Customer("John Smith", address3);

        List<Product> products3 = new List<Product>
        {
            new Product("Office Desk", "OD300", 250.00, 1),
            new Product("Filing Cabinet", "FC50", 80.99, 2),
            new Product("Printer Paper", "PP20", 15.99, 5)
        };

        Order order3 = new Order(products3, customer3);

        Console.WriteLine("Order 3:");
        order3.Display();
        Console.WriteLine();
    }
}