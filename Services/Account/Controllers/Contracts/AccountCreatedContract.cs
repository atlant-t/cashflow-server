namespace Cashflow.Services.Account.Controllers.Contracts
{
  /// <summary>
  /// Account that creates by API.
  /// </summary>
  public class AccountCreatedContract
  {
    /// <summary>
    /// Represents Account Id.
    /// </summary>
    /// <value>Account Id.</value>
    public string Id { get; set; }

    /// <summary>
    /// Represents Account Name.
    /// </summary>
    /// <value>Account Name.</value>
    public string Name { get; set; }
  }
}
