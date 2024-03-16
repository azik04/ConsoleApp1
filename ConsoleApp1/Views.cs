using ConsoleApp1.Model;
namespace ConsoleApp1
{
    public class Views
    {
        private List<Product> _product;
        public Views(List<Product> products)
        {
            _product = products;
        }
        public void View()
        {
            var reg = new Registers();
            var buy = new Buy(reg.Users, _product);
            Console.WriteLine("List of Products:");
            foreach (var item in _product)
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
        }
    }
}
