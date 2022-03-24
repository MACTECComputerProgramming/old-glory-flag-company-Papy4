namespace FlagCompany.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Address { get; set; }
        public int City { get; set; }
        public int zipcode { get; set; }
        public DateTime Created { get; set; }
        public int costumNumber { get; set; }
        public string FullName
        {
            get
            {
                return LastName + ", " + FirstName;
            }
        }
        public ICollection<Order>? Order { get; set; }
    }
}

