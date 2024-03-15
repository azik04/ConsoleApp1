namespace ConsoleApp1.Model
{
    public class Order
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string UserName { get; set; }

        public Order(string productName, string userName)
        {
            ProductName = productName;
            UserName = productName;
        }
    }

}
