using ConsoleApp1.Model;
namespace ConsoleApp1
{
    public class Removes
    {
        private List<Product> _products;
        public Removes(List<Product> products) 
        {
            _products = products;
        }
        public void Remove()
        {
            Console.WriteLine("Enter the name of the product you want to remove:");
            string productName = Console.ReadLine();
            var productToRemove = _products.FirstOrDefault(p => p.Name == productName);
            _products.Remove(productToRemove);
            Console.WriteLine($"Product '{productName}' has been removed.");
        }
    }
}
