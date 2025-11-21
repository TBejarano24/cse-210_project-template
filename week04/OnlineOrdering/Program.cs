using System;

class Program
{
    static void Main(string[] args)
    {
        Product product1 = new("Laptop", 8295, 5000, 5);
        Product product2 = new("Smart TV", 8302, 3500, 8);
        Product product3 = new("Phone", 8297, 3000, 10);

        List<Product> productList1 = [product1, product2, product3];

        Address rodrigoAddress = new("197 Wattson st.", "Lorem", "West Virginia", "United States");

        Customer customer1 = new("Rodrigo Fuentes", rodrigoAddress);

        Order order1 = new(productList1, customer1);

        Console.WriteLine(order1.DisplayPackingLabel());
        Console.WriteLine(order1.DisplayShippingLabel());
        Console.WriteLine("");
        Console.WriteLine($"Total: ${order1.OrderTotalCost()}");

        Console.WriteLine("--------------------------");
        Console.WriteLine("");

        Product product4 = new("Mac N'Cheese", 3810, 100, 40);
        Product product5 = new("Twinkies", 3108, 500, 45);
        Product product6 = new("Hershey's", 3019, 700, 30);

        List<Product> productList2 = [product4, product5, product6];

        Address eugenioAddress = new("Salvio 2912", "Juárez", "Buenos Aires", "Argentina");

        Customer customer2 = new("Eugenio Fernandez", eugenioAddress);

        Order order2 = new(productList2, customer2);

        Console.WriteLine(order2.DisplayPackingLabel());
        Console.WriteLine(order2.DisplayShippingLabel());
        Console.WriteLine("");
        Console.WriteLine($"Total: ${order2.OrderTotalCost()}");
    }
}