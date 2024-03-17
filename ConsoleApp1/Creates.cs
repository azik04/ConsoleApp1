using ConsoleApp1.Model;

namespace ConsoleApp1
{
    public class Creates
    {
        private readonly AppDbContext.ApplicationDbContext _db;
        public Creates(AppDbContext.ApplicationDbContext db)
        {
            _db = db;
        }

        public void Create()
        {
            var swit = new Switch(_db);

            Console.WriteLine("Enter product name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter product price:");
            string price = Console.ReadLine();
            Product newProduct = new Product( name,price);
            _db.Product.Add(newProduct);
            swit.Switc();

        }
    }
}
