namespace DO;

/// <summary>
/// Represents a customer registered in the store.
/// </summary>
/// <param name="Id">The customer's ID number.</param>
/// <param name="Name">The customer's name.</param>
/// <param name="Address">The customer's address.</param>
/// <param name="Phone">The customer's phone number.</param>
public record Customer(
    int Id,
    string Name,
    string Address,
    string Phone)
{
    /// <summary>
    /// Initializes an empty customer.
    /// </summary>
    public Customer() : this(0, string.Empty, string.Empty, string.Empty)
    {
    }
}
