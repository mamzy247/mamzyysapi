namespace mamzyyssapi.Models
{
    public class Clothing
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public virtual List<Items> Products { get; set; }
    }
}

