namespace CassetteRentals.Models
{
    internal class Rental
    {
        public int RentalId { get; set; }
        public int ClientId { get; set; }
        public int MovieId { get; set; }
        public DateTime RentalDate { get; set; }
        public DateTime? ReturnDate { get; set; }

        public Client Client { get; set; }
        public Movie Movie { get; set; }
    }
}
