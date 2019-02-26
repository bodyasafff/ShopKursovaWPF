using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopKursovaWPF.Models
{
    public class Supplier
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Product> products { get; set; }
    }
}
