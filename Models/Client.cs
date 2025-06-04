namespace CassetteRentals.Models
{
    internal class Client
    {
        public int ClientId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public override string ToString() => $"{FirstName} {LastName}";
    }
}
