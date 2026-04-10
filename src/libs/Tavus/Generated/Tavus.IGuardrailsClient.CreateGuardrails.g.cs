#nullable enable

namespace Tavus
{
    public partial interface IGuardrailsClient
    {
        /// <summary>
        /// Create Guardrails<br/>
        /// Creates a new set of guardrails for a persona.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Tavus.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Tavus.Guardrails> CreateGuardrailsAsync(

            global::Tavus.CreateGuardrailsRequest request,
            global::Tavus.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Guardrails<br/>
        /// Creates a new set of guardrails for a persona.
        /// </summary>
        /// <param name="guardrailsName"></param>
        /// <param name="guardrailsPrompt"></param>
        /// <param name="modality"></param>
        /// <param name="callbackUrl"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Tavus.Guardrails> CreateGuardrailsAsync(
            string? guardrailsName = default,
            string? guardrailsPrompt = default,
            string? modality = default,
            string? callbackUrl = default,
            global::Tavus.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}