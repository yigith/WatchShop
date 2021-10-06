namespace ApplicationCore.Entities
{
    public class OrderDetail : BaseEntity
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public string PictureUri { get; set; }
        public int Quantity { get; set; }

        public Product Product { get; set; }
    }
}
