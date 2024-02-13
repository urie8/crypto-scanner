using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace crypto_scanner.Data.Models
{
    public class RootCoin
    {
        public class Root
        {
            [Key]
            [JsonProperty("id")]
            public int Id { get; set; }
            [JsonProperty("symbol")]
            public string? Symbol { get; set; }
            [JsonProperty("name")]

            public string? Name { get; set; }
        }
    }
}
