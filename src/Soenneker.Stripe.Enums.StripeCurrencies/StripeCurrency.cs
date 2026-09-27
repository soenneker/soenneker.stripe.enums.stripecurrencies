using Soenneker.Gen.EnumValues;

namespace Soenneker.Stripe.Enums.StripeCurrencies;

/// <summary>
/// Stripe currency values.
/// </summary>
[EnumValue<string>]
public sealed partial class StripeCurrency
{
    public static readonly StripeCurrency Usd = new("usd");
}
