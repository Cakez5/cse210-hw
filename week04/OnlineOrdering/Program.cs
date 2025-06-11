using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Order> orders = new List<Order>();

        // Create sample orders
        Address addr1 = new Address("123 Maple St", "Springfield", "IL", "USA");
        Customer cust1 = new Customer("Alex Johnson", addr1);
        Order order1 = new Order(cust1);
        order1.AddProduct(new Product("Notebook", "P001", 3.50m, 2));
        order1.AddProduct(new Product("Pen Set", "P002", 5.00m, 1));
        orders.Add(order1);

        Address addr2 = new Address("456 King Rd", "Toronto", "ON", "Canada");
        Customer cust2 = new Customer("Samantha Lee", addr2);
        Order order2 = new Order(cust2);
        order2.AddProduct(new Product("Journal", "P003", 6.00m, 3));
        order2.AddProduct(new Product("Eraser Pack", "P004", 2.25m, 2));
        orders.Add(order2);

        string input = "";
        while (input != "5")
        {
            Console.Clear();
            Console.WriteLine("=== Online Ordering System: Video Stats Admin ===");
            Console.WriteLine("1. View Packing Labels");
            Console.WriteLine("2. View Shipping Labels");
            Console.WriteLine("3. View Order Totals");
            Console.WriteLine("4. View Full Order Report");
            Console.WriteLine("5. Exit");
            Console.Write("\nChoose an option: ");
            input = Console.ReadLine();

            Console.Clear();
            switch (input)
            {
                case "1":
                    foreach (var order in orders)
                    {
                        Console.WriteLine(order.GetPackingLabel());
                        Console.WriteLine("------------------------");
                    }
                    break;
                case "2":
                    foreach (var order in orders)
                    {
                        Console.WriteLine(order.GetShippingLabel());
                        Console.WriteLine("------------------------");
                    }
                    break;
                case "3":
                    foreach (var order in orders)
                    {
                        Console.WriteLine($"Customer: {order.GetShippingLabel().Split('\n')[1]}");
                        Console.WriteLine($"Total Price: ${order.GetTotalPrice()}\n");
                    }
                    break;
                case "4":
                    Console.WriteLine("=== Full Order Report ===\n");
                    foreach (var order in orders)
                    {
                        Console.WriteLine(order.GetPackingLabel());
                        Console.WriteLine(order.GetShippingLabel());
                        Console.WriteLine($"Total Price: ${order.GetTotalPrice()}");
                        Console.WriteLine("------------------------\n");
                    }
                    break;
                case "5":
                    Console.WriteLine("Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid selection. Please choose again.");
                    break;
            }

            if (input != "5")
            {
                Console.WriteLine("\nPress Enter to return to the menu...");
                Console.ReadLine();
            }
        }
    }
}