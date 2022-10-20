using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spg.KunstShop.Domain.Model
{
    public class ShoppingCart
    {
        public int Id { get; set; }
        public int ItemCount { get; }
        public Customer CustomerNavigation { get; set; } = default!;
        public List<ShoppingCartItem> ShoppingCartItems { get; set; } = new();
    }
}
