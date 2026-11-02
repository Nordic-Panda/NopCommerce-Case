namespace Nop.Core.Domain.Catalog;

/// <summary>
/// Defines the action that should be performed when the product availability end date is reached.
/// </summary>
public enum ProductAvailabilityAction
{
    /// <summary>
    /// The product ceases to be displayed on the storefront once the availability end date is reached.
    /// This is the default behaviour.
    /// </summary>
    HideProduct = 0,

    /// <summary>
    /// The product is unpublished once the availability end date is reached (it ceases to be displayed).
    /// </summary>
    Unpublish = 1,

    /// <summary>
    /// The product remains displayed once the availability end date is reached, but the buy button is removed
    /// (the product can not be purchased anymore).
    /// </summary>
    DisableBuyButton = 2
}
