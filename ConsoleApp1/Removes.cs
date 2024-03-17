using ConsoleApp1.Model;
namespace ConsoleApp1
{
    public class Removes
    {
        private readonly AppDbContext.ApplicationDbContext _db;
        public Removes(AppDbContext.ApplicationDbContext db)
        {
            _db = db;
        }
        public void Remove()
        {
            var swit = new Switch(_db);
            Console.WriteLine("Enter the name of the product you want to remove:");
            string productName = Console.ReadLine();
            var productToRemove = _db.Product.FirstOrDefault(p => p.Name == productName);
            _db.Product.Remove(productToRemove);
            Console.WriteLine($"Product '{productName}' has been removed.");
            swit.Switc();
        }
    }
}
