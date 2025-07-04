using System.Text.Json.Serialization;

namespace GurpreetRaju.Models
{
    /// <summary>
    /// Represents a project model containing details about a project.
    /// </summary>
    public class ProjectModel
    {
        /// <summary>
        /// Represents the name of the project.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// The image of the project.
        /// </summary>
        [JsonPropertyName("image")]
        public string Image { get; set; }

        /// <summary>
        /// The skills used in the project.
        /// </summary>
        [JsonPropertyName("skills")]
        public string[] Skills { get; set; }

        /// <summary>
        /// The key features of the project.
        /// </summary>
        [JsonPropertyName("key-features")]
        public string[] KeyFeatures { get; set; }

        /// <summary>
        /// The demo URL for the project.
        /// </summary>
        [JsonPropertyName("demoUrl")]
        public string DemoUrl { get; set; }

        /// <summary>
        /// The GitHub URL for the project.
        /// </summary>
        [JsonPropertyName("gitHubUrl")]
        public string GitHubUrl { get; set; }

        /// <summary>
        /// Hue color value for project card.
        /// </summary>
        [JsonPropertyName("hue")]
        public int Hue { get; set; }
    }
}
