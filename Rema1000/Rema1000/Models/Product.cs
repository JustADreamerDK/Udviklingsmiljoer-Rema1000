namespace Rema1000.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Unit { get; set; }
        public int Amount { get; set; }
        public int Price { get; set; }
        public Category Category { get; set; }
    }
}
