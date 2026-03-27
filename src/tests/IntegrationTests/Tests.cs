namespace Tavus.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static TavusClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("TAVUS_API_KEY") is { Length: > 0 } apiKeyValue
                ? apiKeyValue
                : throw new AssertInconclusiveException("TAVUS_API_KEY environment variable is not found.");

        var client = new TavusClient(apiKey);
        
        return client;
    }
}
