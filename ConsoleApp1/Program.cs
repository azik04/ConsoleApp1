
List<User> user = new List<User>();
List<Product> products = new List<Product>();
List<Order> order = new List<Order>();

bool running = true;
while (running)
{
    Console.WriteLine("1. Register");
    Console.WriteLine("2. Login");

    string choice = Console.ReadLine();
    switch (choice)
    {
        case "1":
            Register();
            break;
        case "2":
            Login();
            string data = Console.ReadLine();

            break;
        default:
            Console.WriteLine("Invalid choice. Please try again.");
            break;
    }
}
void Login()
{
    Console.Write("Enter username: ");
    string username = Console.ReadLine();
    Console.Write("Enter password: ");
    string password = Console.ReadLine();

    var data = user.FirstOrDefault(x => x.Name == username && x.Password == password);
    if (data != null)
    {
        Console.WriteLine("Login successful!");
        if (user.Where(x => x.Role == "2").Any())
        {
        Console.WriteLine("1. View Products");
        Console.WriteLine("2. Create Product");
        Console.WriteLine("3. Remove Product");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    View();
                    break;
                case "2":
                    Create();
                    break;
                case "3":
                    Remove();
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
                    Create();
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }

        
    }
    else
    {
        Console.WriteLine("Invalid username or password. Please try again.");

    }
}
void Register()
{
    Console.Write("Register username: ");
    string username = Console.ReadLine();
    Console.Write("Register password: ");
    string password = Console.ReadLine();
    Console.Write("Register Role: ");
    string role = Console.ReadLine();
    User users = new User(username, password, role);
    user.Add(users);
    Console.WriteLine($"User {users.Name} has been successfully create");
}

void Create()
{
    Console.WriteLine("Enter product name:");
    string name = Console.ReadLine();
    Console.WriteLine("Enter product price:");
    string price = Console.ReadLine();
    Product newProduct = new Product(name, price);
    products.Add(newProduct);
    Console.WriteLine("Product has been successfully added.");
    Console.WriteLine("Login successful!");
    Console.WriteLine("1. Create Product");
    Console.WriteLine("2. View Products");
    Console.WriteLine("3. Remove Product");

    string choice = Console.ReadLine();
    switch (choice)
    {
        case "1":
            Create();
            break;
        case "2":
            View();
            break;
        case "3":
            Remove();
            break;
        default:
            Console.WriteLine("Invalid choice. Please try again.");
            break;
    }
}

void Remove()
{
    Console.WriteLine("Enter the name of the product you want to remove:");
    string productName = Console.ReadLine();
    var productToRemove = products.FirstOrDefault(p => p.Name == productName);
    products.Remove(productToRemove);
    Console.WriteLine($"Product '{productName}' has been removed.");
}

void View()
{
    Console.WriteLine("List of Products:");
    foreach (var product in products)
    {
        Console.WriteLine($"Name: {product.Name}, Price: {product.Price}");
    }
    Console.WriteLine("buy smn???");
    Console.WriteLine("Wright yes if you wonna buy smn");
    Console.WriteLine("Wright no if you wonna to exit");
    var data = Console.ReadLine();
    switch (data)
    {
        case "yes":
            Console.WriteLine("Wright product you want to buy");
            var product = Console.ReadLine();
            var buyProd = products.FirstOrDefault(x => x.Name == product);
            Console.WriteLine("Wrtight Your Name");
            var name = Console.ReadLine();
            var buyName = user.FirstOrDefault(c => c.Name == name);
            Order ord = new Order(buyName.Name , buyProd.Name);
            order.Add(ord);
            Console.WriteLine($"Order '{product}' for user '{name}' has been succesfully create");
            break;
        case "no":
            View();
            break;
        default:
            Console.WriteLine("Invalid number. Please try again");
            break;

    }
}

class Product
{
    public string Name { get; set; }
    public string Price { get; set; }

    public Product(string name, string price)
    {
        Name = name;
        Price = price;
    }
}
class User
{
    public string Name { get; set; }
    public string Password { get; set; }
    public string Role { get; set; }

    public User(string name, string password, string role)
    {
        Name = name;
        Password = password;
        Role = role;
    }
}
class Order
{
    public string ProductName { get; set; }
    public string UserName { get; set; }

    public Order(string productName, string userName)
    {
        ProductName = productName;
        UserName = productName;
    }
}
