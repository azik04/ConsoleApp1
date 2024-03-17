using ConsoleApp1.Model;

public class Registers
{
    private readonly AppDbContext.ApplicationDbContext _db;
    public Registers(AppDbContext.ApplicationDbContext db)
    {
        _db = db;
    }
    public void Register()
    {
        var swit = new Switch(_db);
        Console.Write("Register username: ");
        string username = Console.ReadLine();
        Console.Write("Register password: ");
        string password = Console.ReadLine();
        Console.Write("Register Role: ");
        string role = Console.ReadLine();
        User newUser = new User(username, password, role);
        _db.Users.Add(newUser);
        Console.WriteLine($"User {newUser.Name} has been successfully created");
        swit.Switc();
    }
}