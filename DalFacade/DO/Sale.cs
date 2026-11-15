namespace DO;

/// <summary>
/// Represents a promotion offered for a product.
/// </summary>
/// <param name="Id">The unique promotion identifier.</param>
/// <param name="ProductId">The identifier of the product.</param>
/// <param name="RequiredQuantity">The quantity required for the promotion.</param>
/// <param name="PromotionPrice">The total price in the promotion.</param>
/// <param name="ClubMembersOnly">Indicates whether the promotion is for club members only.</param>
/// <param name="StartDate">The promotion start date.</param>
/// <param name="EndDate">The promotion end date.</param>
public record Sale(
    int Id,
    int ProductId,
    int RequiredQuantity,
    double PromotionPrice,
    bool ClubMembersOnly,
    DateTime StartDate,
    DateTime EndDate)
{
    /// <summary>
    /// Initializes an empty promotion.
    /// </summary>
    public Sale() : this(0, 0, 0, 0, false, default, default)
    {
    }
}