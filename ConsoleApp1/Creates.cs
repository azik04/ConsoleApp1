using ConsoleApp1.Model;

namespace ConsoleApp1
{
    public class Creates
    {
        public List<Product> Products { get; set; } = new List<Product>();
        public void Create()
        {
            var reg = new Registers();
            var view = new Views(Products);
            var remove = new Removes(Products);
            Console.WriteLine("Enter product name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter product price:");
            string price = Console.ReadLine();
            Product newProduct = new Product(name, price);
            Products.Add(newProduct);
            Console.WriteLine("Product has been successfully added.");
            Console.WriteLine("Login successful!");
            Console.WriteLine("1. Create Product");
            Console.WriteLine("2. View Products");
            Console.WriteLine("3. Remove Product");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Create();
                    break;
                case "2":
                    view.View();
                    break;
                case "3":
                    remove.Remove();
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}
