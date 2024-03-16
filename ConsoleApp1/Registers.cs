using ConsoleApp1.Model;

public class Registers
{
    public List<User> Users { get; set; } = new List<User>();

    public void Register()
    {
        Console.Write("Register username: ");
        string username = Console.ReadLine();
        Console.Write("Register password: ");
        string password = Console.ReadLine();
        Console.Write("Register Role: ");
        string role = Console.ReadLine();
        User newUser = new User(username, password, role);
        Users.Add(newUser);
        Console.WriteLine($"User {newUser.Name} has been successfully created");
    }
}