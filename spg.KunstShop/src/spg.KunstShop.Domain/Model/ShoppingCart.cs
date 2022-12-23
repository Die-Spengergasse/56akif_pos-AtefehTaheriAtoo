using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spg.KunstShop.Domain.Model
{
    public enum  ShoppingCartStates { Active = 0, sent = 1, Unknown = 99 }

    public class ShoppingCart
    {
        public int Id { get; }
        public string Name { get; set; } = string.Empty;
        public ShoppingCartStates ShoppingCartStates { get; set; }
        public DateTime CreationDate { get; }
        public int ItemCount { get; }
        public decimal Summary{get;}

        public int CustomerNavigationId { get; set; }

        // WICHTIG!!!!! es mus null sein!
        // agar benevisim Customer? ham mishe ama eshtebahe chon too Datenbank b moshkel mikhore
        // alamat sola dar datenbank ehtemal NULL shodan dare
        public Customer CustomerNavigation { get; set; } = default!;

        public List<ShoppingCartItem> _shoppingCartItems  = new();
        public IReadOnlyList<ShoppingCartItem> ShoppingCartItems => _shoppingCartItems;


        protected ShoppingCart() { }

        public ShoppingCart(string name, ShoppingCartStates shoppingCartStates, DateTime creationDate)
        {
           
            Name = name;
            ShoppingCartStates = shoppingCartStates;
            CreationDate = creationDate;           
        }
    }
}
