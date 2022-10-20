using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spg.KunstShop.Domain.Model
{
    public enum Kategorien
    {
        Gemaelde = 0,
        Skulptur = 1,
        Sonstiges = 2
    }
    public class Kunstwerk
    {
        public int Id { get; set; }
        public double Size { get; set; }
    }
}
