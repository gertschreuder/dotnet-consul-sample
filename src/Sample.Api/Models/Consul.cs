namespace Sample.Api.Models
{
    public class Consul
    {
        public string Address { get; set; }
        public string ServiceName { get; set; }
        public string ServiceId { get; set; }
        public string ServiceAddress { get; set; }
        public string[] ServiceTags { get; set; }
    }
}