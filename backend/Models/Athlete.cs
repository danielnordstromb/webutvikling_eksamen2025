namespace backend.Models
{
    public class Athlete
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Gender { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public string Image { get; set; } = string.Empty;
        public bool PurchaseStatus { get; set; }  // true = purchased, false = not purchased
        public string Position { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
        public string Height { get; set; } = string.Empty;
        public int Age { get; set; }
        public int Weight { get; set; }
    }
}
