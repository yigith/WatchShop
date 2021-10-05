using System.Collections.Generic;

namespace ApplicationCore.Entities
{
    public class Basket : BaseEntity
    {
        public string BuyerId { get; set; }


        public List<BasketItem> Items { get; set; }
    }
}
