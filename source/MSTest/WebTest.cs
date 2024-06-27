namespace MSTest;

[TestClass]
public class WebTest
{
    [TestMethod]
    public async void HelloWorld()
    {
        using var application = new WebApplicationFactory<Program>();

        using var client = application.CreateClient();

        Assert.AreEqual("Hello World!", await client.GetStringAsync(string.Empty));
    }
}
