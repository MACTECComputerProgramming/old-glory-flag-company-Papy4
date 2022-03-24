namespace FlagCompany.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int DeliveryData { get; set; }
        public int OrderNumber { get; set; }
        public Customer? Costomer { get; set; }
        public Product? Product { get; set; }
    }
}
