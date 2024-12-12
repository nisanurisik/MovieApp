namespace MovieApp.Entity.Models
{
    public class TvShow
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Genre { get; set; }
        public string Description { get; set; }
        public decimal Rating { get; set; }
        public bool State { get; set; }
        public string? Url { get; set; }
        public int CatId { get; set; }
        public Category Category { get; set; }
    }
}
