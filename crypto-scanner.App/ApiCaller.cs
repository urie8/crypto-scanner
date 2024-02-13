using crypto_scanner.Data.Models;
using Newtonsoft.Json;

namespace crypto_scanner.App
{
    public class ApiCaller
    {
        public HttpClient Client { get; set; }

        public ApiCaller()
        {
            Client = new();

            Client.BaseAddress = new Uri("https://api.coingecko.com/api/v3/");
        }

        public async Task<RootCoin> GetCoin(string url, string name)
        {
            HttpResponseMessage response = await Client.GetAsync($"{url}/{name.ToLower()}");

            if (response.IsSuccessStatusCode)
            {
                string json = await response.Content.ReadAsStringAsync();

                RootCoin coin = JsonConvert.DeserializeObject<RootCoin>(json);

                if (coin != null)
                {
                    return coin;
                }
            }

            throw new HttpRequestException();

        }

        public async Task<List<RootCoin>> GetExchanges(int quantity, string pageNr)
        {
            HttpResponseMessage response = await Client.GetAsync($"exchanges/?per_page={quantity}&page={pageNr}");

            if (response.IsSuccessStatusCode)
            {
                string json = await response.Content.ReadAsStringAsync();

                List<RootCoin> coins = JsonConvert.DeserializeObject<List<RootCoin>>(json);

                if (coins != null)
                {
                    return coins;
                }
            }
            throw new HttpRequestException();

        }
    }
}
