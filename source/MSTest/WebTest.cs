namespace MSTest;

[TestClass]
public class WebTest
{
    [TestMethod]
    public async Task HelloWorld()
    {
        await using var application = new WebApplicationFactory<Program>();

        using var client = application.CreateClient();

        Assert.AreEqual("Hello World!", await client.GetStringAsync(string.Empty));
    }
}
