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

        public async Task<RootCoin> MakeCall(string url, string name)
    }
}
