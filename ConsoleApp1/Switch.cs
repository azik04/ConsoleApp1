using ConsoleApp1;
using ConsoleApp1.Model;
public class Switch
{
    private readonly AppDbContext.ApplicationDbContext _db;
    public Switch(AppDbContext.ApplicationDbContext db)
    {
        _db = db;
    }
    public void Switc(){
        var create = new Creates(_db);
        var view = new Views(_db);
        var remove = new Removes(_db);
        Console.WriteLine("Product has been successfully added.");
        Console.WriteLine("Login successful!");
        Console.WriteLine("1. Create Product");
        Console.WriteLine("2. View Products");
        Console.WriteLine("3. Remove Product");
        if (_db.Users.Where(x => x.Role == "2").Any())
        {
            Console.WriteLine("1. View Products");
            Console.WriteLine("2. Create Product");
            Console.WriteLine("3. Remove Product");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    view.View();
                    break;
                case "2":
                    create.Create();
                    break;
                case "3":
                    remove.Remove();
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
        else
        {
            Console.WriteLine("1. View Products");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    create.Create();
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}