namespace API.Models
{
    public class Membership
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime PaymentDate { get; set; }
        public User User { get; set; }

    }
}
