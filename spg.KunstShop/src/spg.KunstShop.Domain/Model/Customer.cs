using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spg.KunstShop.Domain.Model
{
    public enum Gender
    {
        Male = 0,
        Feamale = 1,
        Other = 2
    }

    public class Customer
    {
        public Gender Gender { get; set; }
        public string CustomerNumber { get; set; }= string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string EMail { get; set; } = string.Empty;
        public DateTime BirthDate { get; set; } = DateTime.MinValue;
        public string Address { get; set; } = string.Empty;
        public DateTime RegistrationDateTime { get; set; } 
        public List<ShoppingCart> ShoppingCart { get; set; } = new();



    }
}
