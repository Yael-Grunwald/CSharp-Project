namespace DO;

/// <summary>
/// Represents a product sold in the store.
/// </summary>
/// <param name="Id">The unique product identifier.</param>
/// <param name="Name">The product name.</param>
/// <param name="Category">The product category.</param>
/// <param name="Price">The product price.</param>
/// <param name="StockQuantity">The quantity available in stock.</param>
public record Product(
    int Id,
    string Name,
    Category Category,
    double Price,
    int StockQuantity)
{
    /// <summary>
    /// Initializes an empty product.
    /// </summary>
    public Product() : this(0, string.Empty, default, 0, 0)
    {
    }
}