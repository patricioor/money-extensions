namespace MoneyExtension;

public static class MoneyExtensions
{
  public static int ToCents(this decimal amount)
  {
    if (amount <= 0)
      return 0;

    var cents = amount.ToString("N2").Replace(",", "").Replace(".", "");

    if (string.IsNullOrEmpty(cents))
      return 0;

    int.TryParse(cents, out var result);
    return result;
  }
}
