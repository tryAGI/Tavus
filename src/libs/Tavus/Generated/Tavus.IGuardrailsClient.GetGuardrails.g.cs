#nullable enable

namespace Tavus
{
    public partial interface IGuardrailsClient
    {
        /// <summary>
        /// Get Guardrails<br/>
        /// Returns a single set of guardrails.
        /// </summary>
        /// <param name="guardrailsId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Tavus.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Tavus.Guardrails> GetGuardrailsAsync(
            string guardrailsId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}