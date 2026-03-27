#nullable enable

namespace Tavus
{
    public partial interface IGuardrailsClient
    {
        /// <summary>
        /// List Guardrails<br/>
        /// Returns a list of all guardrails.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Tavus.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Tavus.ListGuardrailsResponse> ListGuardrailsAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}