using System.Text.Json.Serialization;

namespace GurpreetRaju.Models
{
    public class Experience
    {
        [JsonPropertyName("logo")]
        public string Logo { get; set; }

        [JsonPropertyName("roles")]
        public Role[] Roles { get; set; }

        [JsonPropertyName("company")]
        public string Company { get; set; }

        [JsonPropertyName("location")]
        public string Location { get; set; }

        [JsonPropertyName("responsibilities")]
        public string[] Responsibilities { get; set; }
    }

    public class Role
    {
        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("from")]
        public string From { get; set; }

        [JsonPropertyName("to")]
        public string To { get; set; }
    }
}
