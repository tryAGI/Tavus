
#nullable enable

namespace Tavus
{
    public sealed partial class TavusClient
    {

        /// <inheritdoc/>
        public void AuthorizeUsingApiKeyInHeader(
            string apiKey)
        {
            apiKey = apiKey ?? throw new global::System.ArgumentNullException(nameof(apiKey));

            for (var i = Authorizations.Count - 1; i >= 0; i--)
            {
                var __authorization = Authorizations[i];
                if (__authorization.Type == "ApiKey" &&
                    __authorization.Location == "Header" &&
                    __authorization.Name == "x-api-key")
                {
                    Authorizations.RemoveAt(i);
                }
            }

            Authorizations.Add(new global::Tavus.EndPointAuthorization
            {
                Type = "ApiKey",
                Location = "Header",
                Name = "x-api-key",
                Value = apiKey,
            });
        }
    }
}