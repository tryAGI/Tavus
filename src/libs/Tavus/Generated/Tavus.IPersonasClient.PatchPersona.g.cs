#nullable enable

namespace Tavus
{
    public partial interface IPersonasClient
    {
        /// <summary>
        /// Patch Persona<br/>
        /// Updates a persona using JSON Patch (RFC 6902).
        /// </summary>
        /// <param name="personaId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Tavus.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Tavus.Persona> PatchPersonaAsync(
            string personaId,

            global::System.Collections.Generic.IList<global::Tavus.JsonPatchOperation> request,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}