namespace ApplicationCore.Entities
{
    public class BasketItem : BaseEntity
    {
        public int Quantity { get; set; }

        public int ProductId { get; set; }

        public int BasketId { get; set; }


        public Product Product { get; set; }
    }
}
