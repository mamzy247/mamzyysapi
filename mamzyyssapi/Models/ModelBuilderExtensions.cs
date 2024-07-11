namespace mamzyyssapi.Models;
using Microsoft.EntityFrameworkCore;



public static class ModelBuilderExtensions
    {

        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Clothing>().HasData(
                new Clothing { Id = 1, Name = "Dresses" },
                new Clothing { Id = 2, Name = "trousers" },
                new Clothing { Id = 3, Name = "shirts" },
                new Clothing { Id = 4, Name = "shoes" },
                new Clothing { Id = 5, Name = "Accesorries" });

            modelBuilder.Entity<Items>().HasData(
                new Items { Id = 1, ClothingId = 1, Name = "Mid Dresses",Size = "S , M , L", Sku = "MAMZMD", Price = 6000 , IsAvailable = true },
                new Items { Id = 2, ClothingId = 1, Name = "Floor Length", Size = "S , M , L", Sku = "MAMZFL", Price = 8000, IsAvailable = true },
                new Items { Id = 3, ClothingId = 1, Name = "Bubu", Size = "S , M , L", Sku = "MAMZBB", Price = 10000, IsAvailable = true },
                new Items { Id = 4, ClothingId = 1, Name = "BodyCon", Size = "S , M , L", Sku = "MAMZBC", Price = 10000, IsAvailable = true },
                new Items { Id = 5, ClothingId = 1, Name = "Wrap Dress", Size = "S , M , L", Sku = "MAMZWD", Price = 8000, IsAvailable = true },
                new Items { Id = 6, ClothingId = 1, Name = "Dinner Dress", Size = "S , M , L", Sku = "MAMZDD", Price = 25000, IsAvailable = true },
                new Items { Id = 7, ClothingId = 1, Name = "Short Dresses", Size = "S , M , L", Sku = "MAMZSD", Price = 9500, IsAvailable = true },
                new Items { Id = 8, ClothingId = 1, Name = "Slip Dresses", Size = "S , M , L", Sku = "MAMZSLD", Price = 6500, IsAvailable = true },
                new Items { Id = 9, ClothingId = 1, Name = "Corprate Dresses", Size = "S , M , L", Sku = "MAMZCD", Price = 8000 - 10000, IsAvailable = true },
                new Items { Id = 10, ClothingId = 2, Name = "Straight Cut", Size = "S , M , L", Sku = "MAMZSC", Price = 5000, IsAvailable = true },
                new Items { Id = 11, ClothingId = 2, Name = "Flare Cut", Size = "S , M , L", Sku = "MAMZFC", Price = 8000, IsAvailable = false },
                new Items { Id = 12, ClothingId = 2, Name = "Boot Cut", Size = "S , M , L", Sku = "MAMZBTC", Price = 6800, IsAvailable = true },
                new Items { Id = 13, ClothingId = 2, Name = "Wide Cut", Size = "S , M , L", Sku = "MAMZWC", Price = 5000, IsAvailable = true },
                new Items { Id = 14, ClothingId = 2, Name = "Sweat Pants", Size = "S , M , L", Sku = "MAMZSP", Price = 12000, IsAvailable = true },
                new Items { Id = 15, ClothingId = 2, Name = "Cargo Pants", Size = "S , M , L", Sku = "MAMZCP", Price = 15000, IsAvailable = true },
                new Items { Id = 16, ClothingId = 2, Name = "Palazzo", Size = "S , M , L", Sku = "MAMZPL", Price = 9500, IsAvailable = true },
                new Items { Id = 17, ClothingId = 2, Name = "Shorts pants", Size = "S , M , L", Sku = "MAMZSTP", Price = 7000, IsAvailable = true },
                new Items { Id = 18, ClothingId = 3, Name = "Polo Shirt", Size = "S , M , L", Sku = "STPS", Price = 4500, IsAvailable = true },
                new Items { Id = 19, ClothingId = 3, Name = "Tube Top", Size = "S , M , L", Sku = "STTT", Price = 5000, IsAvailable = true },
                new Items { Id = 20, ClothingId = 3, Name = "Tuxedo", Size = "S , M , L", Sku = "STTX", Price = 6000, IsAvailable = true },
                new Items { Id = 21, ClothingId = 3, Name = "Tank Top", Size = "S , M , L", Sku = "STTKT", Price = 3500, IsAvailable = true },
                new Items { Id = 22, ClothingId = 3, Name = "Sweatshirt", Size = "S , M , L", Sku = "STCT", Price = 6000, IsAvailable = true },
                new Items { Id = 23, ClothingId = 3, Name = "Crop Top", Size = "S , M , L", Sku = "STCT", Price = 3000, IsAvailable = true },
                new Items { Id = 24, ClothingId = 4, Name = "Heels", Size = "All Sizes available", Sku = "SH00", Price = 13000, IsAvailable = true },
                new Items { Id = 25, ClothingId = 4, Name = "Flats", Size = "All Sizes available", Sku = "SH01", Price = 5000, IsAvailable = true },
                new Items { Id = 26, ClothingId = 4, Name = "Slides", Size = "All Sizes available", Sku = "SH02", Price = 5000, IsAvailable = true },
                new Items { Id = 27, ClothingId = 4, Name = "Boots", Size = "All Sizes available", Price = 8000, IsAvailable = true },
                new Items { Id = 28, ClothingId = 4, Name = "Pumps", Size = "All Sizes available", Sku = "SH04", Price = 6000, IsAvailable = true },
                new Items { Id = 29, ClothingId = 4, Name = "Sneakers", Size = "All Sizes available", Sku = "SH05", Price = 8000, IsAvailable = true },
                new Items { Id = 30, ClothingId = 4, Name = "Bluchers", Size = "All Sizes available", Sku = "SH06", Price = 10000, IsAvailable = true },
                new Items { Id = 31, ClothingId = 4, Name = "Wedges", Size = "All Sizes available", Sku = "SH07", Price = 7000, IsAvailable = true },
                new Items { Id = 32, ClothingId = 4, Name = "Sport shoes", Size = "All Sizes available", Sku = "SH08", Price = 6000, IsAvailable = true },
                new Items { Id = 33, ClothingId = 5, Name = "Rings", Sku = "ASS002", Price = 5000, IsAvailable = true },
                new Items { Id = 34, ClothingId = 5, Name = "Bracelets", Sku = "ASS008", Price = 5000, IsAvailable = true },
                new Items { Id = 35, ClothingId = 5, Name = "Watches", Sku = "ASS230", Price = 10000, IsAvailable = true },
                new Items { Id = 36, ClothingId = 5, Name = "Anklets", Sku = "ASS231", Price = 3000, IsAvailable = true },
                new Items { Id = 37, ClothingId = 5, Name = "Earrrings", Sku = "ASS456", Price = 5000, IsAvailable = true },
                new Items { Id = 38, ClothingId = 5, Name = "Nose Rings", Sku = "ASS008", Price = 2500, IsAvailable = true });
    }

           
    }

