namespace WebApplication1.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty; // Przypisanie wartości domyślnej
        public decimal Price { get; set; }
    }
}
