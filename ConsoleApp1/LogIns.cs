using ConsoleApp1.Model;

namespace ConsoleApp1
{
    public class LogIns
    {

        private List<User> _users;

        public LogIns(List<User> users)
        {
            _users = users;
        }
        public void Login()
        {
            var reg = new Registers();
            var create = new Creates();
            var view = new Views(create.Products) ;
            var remove = new Removes(create.Products);
            Console.Write("Enter username: ");
            string username = Console.ReadLine();
            Console.Write("Enter password: ");
            string password = Console.ReadLine();

            var data = _users.FirstOrDefault(x => x.Name == username && x.Password == password);
            if (data != null)
            {
                Console.WriteLine("Login successful!");
            }
            else
            {
                Console.WriteLine("Invalid username or password. Please try again.");
            }
            if (_users.Where(x => x.Role == "2").Any())
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
}
