namespace ShopKursovaWPF
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class ShopKurs : DbContext
    {
        public ShopKurs()
            : base("name=ShopKurs")
        {
        }

    }

}