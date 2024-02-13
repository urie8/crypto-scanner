using crypto_scanner.App;
using crypto_scanner.Data.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace crypto_scanner.UI.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public RootCoin Coin { get; set; }

        public List<RootCoin> Coins { get; set; }

        public string? ErrorMessage { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public async void OnGet(string id)
        {
            try
            {
                List<RootCoin> coins = await new ApiCaller().GetExchanges(10, 1);

                if (coins != null)
                {
                    Coins = coins;

                    // TODO: Check if coin already exists in the database
                }
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
            }
        }
    }
}
