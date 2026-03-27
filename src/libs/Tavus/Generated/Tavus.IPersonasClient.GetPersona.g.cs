#nullable enable

namespace Tavus
{
    public partial interface IPersonasClient
    {
        /// <summary>
        /// Get Persona<br/>
        /// Returns a single persona.
        /// </summary>
        /// <param name="personaId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Tavus.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Tavus.Persona> GetPersonaAsync(
            string personaId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}