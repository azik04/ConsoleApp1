namespace ConsoleApp1.Model
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }

        public Product(string name, string price)
        {
            Name = name;
            Price = price;
        }
    }
}
