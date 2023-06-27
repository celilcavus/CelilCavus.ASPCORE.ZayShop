namespace celilcavus.models
{
    public class Product
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string Image1 { get; set; }
        public string Image2 { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public short Point { get; set; }
        public int BrandId { get; set; }
        public string Description { get; set; }
        public int ColorId { get; set; }

    }
}