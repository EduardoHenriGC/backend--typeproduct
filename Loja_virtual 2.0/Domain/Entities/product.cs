namespace LojaVirtual.Domain.Entities
{
    public class Product : BaseModel
    {
        public string? name { get; set; }
        public string? type { get; set; }
        public string? description { get; set; }
        public double price { get; set; }
        public string? urlImg { get; set; }
    }
}
