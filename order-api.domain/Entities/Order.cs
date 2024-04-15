namespace order_api.domain.Entities
{
    public class Order
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string SourceNote { get; set; }
        public decimal? Cost { get; set; }
    }
}