using ConsoleApp1.Model;
namespace ConsoleApp1
{
    public class Views
    {
        private readonly AppDbContext.ApplicationDbContext _db;
        public Views(AppDbContext.ApplicationDbContext db)
        {
            _db = db;
        }

        public void View()
        {
            var swit = new Switch(_db);
            var buy = new Buy(_db);
            Console.WriteLine("List of Products:");
            foreach (var item in _db.Product)
            {
                Console.WriteLine($"Name: {item.Name}, Price: {item.Price}");
            }
 
            Console.WriteLine("buy smn???");
            Console.WriteLine("Wright yes if you wonna buy smn");
            Console.WriteLine("Wright no if you wonna to exit");
            var data = Console.ReadLine();
            switch (data)
            {
                case "yes":
                    buy.Buys();
                    break;
                case "no":
                    View();
                    break;
                default:
                    Console.WriteLine("Invalid number. Please try again");
                    break;

            }
            swit.Switc();
        }
    }
}
