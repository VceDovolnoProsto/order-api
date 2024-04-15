using Newtonsoft.Json;

namespace order_api.application.Common.Exceptions
{
    public class ErrorDetails
    {
        public int StatusCode { get; set; }
        public string Message { get; set; }
        public Guid ExceptionId { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this);
    }
}