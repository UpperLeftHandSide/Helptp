using helptp.Extensions;

namespace Helptp.Tests.Extensions;

public class IntExtensionsTests
{
    [Test]
    [TestCase(1, "The entered status code was out of range.")]
    [TestCase(200, "OK")]
    [TestCase(500, "The entered status code was out of range.")]
    public void GetHttpStatusName(int statusCode, string expectedName)
    {
        Assert.That(200.GetHttpStatusName(), Is.EqualTo("OK"));
    }
}