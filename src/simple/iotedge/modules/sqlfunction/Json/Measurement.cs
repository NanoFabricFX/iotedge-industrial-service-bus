using Newtonsoft.Json;

namespace Industrial.Service.Bus
{
    internal sealed class Measurement
    {
        [JsonProperty("Displayname")]
        public string Displayname { get; set; }

        [JsonProperty("Address")]
        public string Address { get; set; }

        [JsonProperty("Value")]
        public string Value { get; set; }
    }
}