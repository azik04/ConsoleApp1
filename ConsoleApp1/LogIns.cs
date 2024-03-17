using ConsoleApp1.Model;

namespace ConsoleApp1
{
    public class LogIns
    {

        private readonly AppDbContext.ApplicationDbContext _db;
        public LogIns(AppDbContext.ApplicationDbContext db)
        {
            _db = db;
        }
        public void Login()
        {
            var swit = new Switch(_db);
            var reg = new Registers(_db);
            var create = new Creates(_db);
            var view = new Views(_db) ;
            var remove = new Removes(_db);
            Console.Write("Enter username: ");
            string username = Console.ReadLine();
            Console.Write("Enter password: ");
            string password = Console.ReadLine();

            var data = _db.Users.FirstOrDefault(x => x.Name == username && x.Password == password);
            if (data != null)
            {
                Console.WriteLine("Login successful!");
            }
            else
            {
                Console.WriteLine("Invalid username or password. Please try again.");
            }
            swit.Switc();

        }
    }
}
