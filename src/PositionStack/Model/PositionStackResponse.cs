using Newtonsoft.Json;

namespace PositionStack.Model
{
    public partial class PositionStackResponse
    {
        [JsonProperty("data")]
        public Datum[]? Data { get; set; }
    }
}
