namespace order_api.application.Orders.Models
{
    public class OrderDto
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string SourceNote { get; set; }
        public decimal? Cost { get; set; }
    }
}