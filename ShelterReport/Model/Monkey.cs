using System.Text.Json.Serialization;

namespace ShelterReport1.Model
{
    public class Monkey
    {
        [JsonPropertyName("_id")]
        public string Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
        
        [JsonPropertyName("age")]
        public int Age { get; set; }
        
        [JsonPropertyName("weight")]
        public int Weight { get; set; }
        
        [JsonPropertyName("eyeColor")]
        public string EyeColor { get; set; }
        
        [JsonPropertyName("species")]
        public string Species { get; set; }
        
        [JsonPropertyName("registered")]
        public string Registered { get; set; }
        
        [JsonPropertyName("favoriteFruit")]
        public string FavoriteFruit { get; set; }
    }
}
