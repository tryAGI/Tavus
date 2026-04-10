#nullable enable

namespace Tavus
{
    public partial interface IGuardrailsClient
    {
        /// <summary>
        /// List Guardrails<br/>
        /// Returns a list of all guardrails.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Tavus.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Tavus.ListGuardrailsResponse> ListGuardrailsAsync(
            global::Tavus.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}