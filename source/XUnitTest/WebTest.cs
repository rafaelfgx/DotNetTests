namespace XUnitTest;

public class WebTest
{
    [Fact]
    public async Task HelloWorld()
    {
        await using var application = new WebApplicationFactory<Program>();

        using var client = application.CreateClient();

        Assert.Equal("Hello World!", await client.GetStringAsync(string.Empty));
    }
}
