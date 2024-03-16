using ConsoleApp1;
using Microsoft.Data.SqlClient;
using System.Data;

public class Program
{
    private static void Main(string[] args)
    {
        
    var register = new Registers();
        var login = new LogIns(register.Users);
        bool running = true;
        while (running)
        {
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
}