namespace Mc.NetCore.Angular.Model
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class User
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [StringLength(10)]
        public string Email { get; set; }

        public IList<TradeProduct> Products { get; set; }
    }
}
