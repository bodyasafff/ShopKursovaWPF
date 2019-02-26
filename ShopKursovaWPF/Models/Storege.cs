using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopKursovaWPF.Models
{
    public class Storege
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
        public virtual ICollection<Product> products { get; set; }   
    }
}
