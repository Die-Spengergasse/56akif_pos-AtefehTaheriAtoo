using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace spg.KunstShop.Domain.Model
{
    public class ShoppingCartItem
    {      
        public int Id { get; set; }
        public int ShoppingCartNavigationId { get; set; }
        public ShoppingCart ShoppingCartNavigation { get; set; } = default;
        public int ProductNavigationId { get; set; }
        public Product ProducktNavigation { get; set; } = default;

        protected ShoppingCartItem()
        {

        }
    }
}
