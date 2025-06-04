namespace CassetteRentals.Models
{
    internal class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public int Year { get; set; }
        public bool IsAvailable { get; set; }

        public override string ToString() => $"{Title} ({Year})";
    }
}
