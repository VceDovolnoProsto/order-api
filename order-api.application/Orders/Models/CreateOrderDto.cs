namespace order_api.application.Orders.Models
{
    public class CreateOrderDto
    {
        public string Name { get; init; }
        public string SourceNote { get; set; }
        public decimal? Cost { get; init; }
    }
}