using ConsoleApp1.Model;
namespace ConsoleApp1
{
    public class Buy
    {
        private readonly AppDbContext.ApplicationDbContext _db;
        public Buy (AppDbContext.ApplicationDbContext db)
        {
            _db = db;
        }
        public void Buys()
        {
            var swit = new Switch(_db);
            Console.WriteLine("Wright product you want to buy");
        var product = Console.ReadLine();
        var buyProd = _db.Product.FirstOrDefault(x => x.Name == product);
        Console.WriteLine("Wrtight Your Name");
        var name = Console.ReadLine();
        var buyName = _db.Users.FirstOrDefault(c => c.Name == name);
        Order ord = new Order( buyProd.Name, buyName.Name);
        _db.Order.Add(ord);
        Console.WriteLine($"Order '{product}' for user '{name}' has been succesfully create");
        swit.Switc();
        }
    }
}
