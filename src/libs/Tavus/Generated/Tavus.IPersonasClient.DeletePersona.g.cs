#nullable enable

namespace Tavus
{
    public partial interface IPersonasClient
    {
        /// <summary>
        /// Delete Persona<br/>
        /// Deletes a single persona.
        /// </summary>
        /// <param name="personaId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Tavus.ApiException"></exception>
        global::System.Threading.Tasks.Task DeletePersonaAsync(
            string personaId,
            global::Tavus.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}