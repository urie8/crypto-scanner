namespace crypto_scanner.App
{
    using crypto_scanner.Data.Database;

    public class CryptoManager
    {
        public CryptoManager()
        {
            CryptoRepo cryptoRepo = new();
        }
    }
}
