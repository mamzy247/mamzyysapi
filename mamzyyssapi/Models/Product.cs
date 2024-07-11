using System.Text.Json.Serialization;

namespace mamzyyssapi.Models
{
    public class Items
    {
        public int Id { get; set; }
        public string Sku { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Size {  get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public bool IsAvailable { get; set; }

        public int ClothingId { get; set; }
        [JsonIgnore]
        public virtual Clothing Clothing { get; set; }
    }
}
