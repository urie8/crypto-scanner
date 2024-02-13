using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace crypto_scanner.Data.Models
{
    public class RootCoin
    {
            [Key]
            [JsonProperty("id")]
            public string Id { get; set; }
            [JsonProperty("symbol")]
            public string? Symbol { get; set; }
            [JsonProperty("name")]
            public string? Name { get; set; }
            [JsonProperty("Description")]
            public string? Description { get; set; }
           
    }
}
