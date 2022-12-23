using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spg.KunstShop.Domain.Model
{
    public class Product
    {
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public int Tax { get; set; }
        public string Ean { get; set; } = string.Empty;
        public string? Material { get; set; } = string.Empty;
        public DateTime? ExpiryDate { get; set; }

        public List<ShoppingCartItem> _shoppingCartItems = new();

        public IReadOnlyList<ShoppingCartItem> ShoppingCartItems => _shoppingCartItems;

        protected Product() { }

        public Product(String name, decimal price, int tax, string ean, string? material, DateTime? expriryDate)
        {
            Name = name;
            Price = price;
            Tax = tax;
            Ean = ean;
            Material = material;
            ExpiryDate = expriryDate;
        }

    }
}
