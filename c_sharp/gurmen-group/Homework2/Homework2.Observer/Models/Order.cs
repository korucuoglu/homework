namespace Homework2.Observer.Models
{
    public class Order
    {
        public Order()
        {
            Products = new List<Product>();
        }

        public int Id { get; set; }
        public List<Product> Products { get; set; }
    }
}
