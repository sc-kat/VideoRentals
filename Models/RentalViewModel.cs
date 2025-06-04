namespace CassetteRentals.Models
{
    internal class RentalViewModel
    {
        public int RentalId { get; set; }
        public string ClientName { get; set; }
        public string MovieTitle { get; set; }
        public string RentalDate { get; set; }
        public string ReturnDate { get; set; }
    }
}
