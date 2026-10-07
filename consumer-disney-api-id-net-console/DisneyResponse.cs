using System.Text.Json.Serialization;

namespace ConsumerDisneyIdApi
{
    public class DisneyResponse
    {
        [JsonPropertyName("info")]
        public InfoData Info { get; set; }

        [JsonPropertyName("data")]
        public CharacterData Data { get; set; }
    }

    public class InfoData
    {
        [JsonPropertyName("count")]
        public int Count { get; set; }

        [JsonPropertyName("totalPages")]
        public int TotalPages { get; set; }

        [JsonPropertyName("previousPage")]
        public string PreviousPage { get; set; }

        [JsonPropertyName("nextPage")]
        public string NextPage { get; set; }
    }

    public class CharacterData
    {
        [JsonPropertyName("_id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("imageUrl")]
        public string ImageUrl { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }
    }
}