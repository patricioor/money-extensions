namespace MoneyExtension.Tests;

[TestClass]
public class MoneyExtensionTests
{
    [TestMethod]
    public void ShouldConvertDecimalToInt()
    {
        decimal value = 279.98m;
        var cents = value.ToCents();

        Assert.AreEqual(27998, cents);
    }
}