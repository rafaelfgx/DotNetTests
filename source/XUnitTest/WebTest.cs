using Microsoft.AspNetCore.Mvc.Testing;

namespace XUnitTest;

public class WebTest
{
    [Fact]
    public async void HelloWorld()
    {
        using var application = new WebApplicationFactory<Program>();

        using var client = application.CreateClient();

        Assert.Equal("Hello World!", await client.GetStringAsync(string.Empty));
    }
}
