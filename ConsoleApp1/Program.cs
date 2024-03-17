using ConsoleApp1;
using ConsoleApp1.Model;

public class Program
{
    private static AppDbContext.ApplicationDbContext _db;

    public Program(AppDbContext.ApplicationDbContext db)
    {
        _db = db;
    }

    public static void Main(string[] args)
    {
        var swit = new Switch(_db);
        var register = new Registers(_db); 
        var login = new LogIns(_db); 

        Console.WriteLine("1. Register");
        Console.WriteLine("2. Login");

        string choice = Console.ReadLine();
        switch (choice)
        {
            case "1":
                register.Register();
                break;
            case "2":
                login.Login();
                break;
            default:
                Console.WriteLine("Invalid choice. Please try again.");
                break;
        }
    }
}