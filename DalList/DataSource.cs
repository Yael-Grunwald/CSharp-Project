

namespace Dal;

internal static class DataSource
{
    internal static List<DO.Product?> Products = new();
    internal static List<DO.Customer?> Customers = new();
    internal static List<DO.Sale?> Sales = new();

    internal static class Config
    {
        internal const int StartSaleId = 100;
        private static int nextSaleId = StartSaleId;
        internal static int NextSaleId => nextSaleId++;
    }
}
