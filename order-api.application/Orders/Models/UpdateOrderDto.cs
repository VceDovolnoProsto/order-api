namespace order_api.application.Orders.Models
{
    public class UpdateOrderDto
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string SourceNote { get; set; }
        public decimal? Cost { get; set; }
    }
}