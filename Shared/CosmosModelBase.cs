using Newtonsoft.Json;

namespace BlazorTodoApp.Shared
{
    public abstract class CosmosModelBase
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("pk")]
        public string Pk { get; set; }
        public abstract string ClassType { get; }
    }
}
 