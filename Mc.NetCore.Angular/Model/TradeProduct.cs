using System;

namespace Mc.NetCore.Angular.Model
{
    public class TradeProduct
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public Category Category { get; set; }

        public double Price { get; set; }

        public int Product { get; set; }

        public DateTime PublicationDate { get; set; }
    }
}
