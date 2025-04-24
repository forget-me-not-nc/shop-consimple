namespace Domain.Models
{
    public class Client : BaseEntity
    {
        public string FullName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime RegistrationDate { get; set; }

        public virtual ICollection<Order>? Orders { get; set; }
    }
}
