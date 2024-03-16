using ConsoleApp1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Buy
    {
        public List<Order> _orders { get; set; } = new List<Order>();
        private List<User> _users;
        private List<Product> _product;
        public Buy(List<User> users, List<Product> product)
        {
            _users = users;
            _product = product;
        }
        public void Buys()
        {
        Console.WriteLine("Wright product you want to buy");
                    var product = Console.ReadLine();
        var buyProd = _product.FirstOrDefault(x => x.Name == product);
        Console.WriteLine("Wrtight Your Name");
                    var name = Console.ReadLine();
        var buyName = _users.FirstOrDefault(c => c.Name == name);
        Order ord = new Order(buyName.Name, buyProd.Name);
            _orders.Add(ord);
                    Console.WriteLine($"Order '{product}' for user '{name}' has been succesfully create");
        }
    }
}
