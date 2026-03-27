#nullable enable

namespace Tavus
{
    public partial interface IPersonasClient
    {
        /// <summary>
        /// Create Persona<br/>
        /// Create and customize a persona's behavior and capabilities for CVI.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Tavus.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Tavus.Persona> CreatePersonaAsync(

            global::Tavus.CreatePersonaRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Persona<br/>
        /// Create and customize a persona's behavior and capabilities for CVI.
        /// </summary>
        /// <param name="personaName"></param>
        /// <param name="systemPrompt">
        /// System prompt defining persona behavior. Required for full pipeline mode.
        /// </param>
        /// <param name="context"></param>
        /// <param name="defaultReplicaId"></param>
        /// <param name="pipelineMode"></param>
        /// <param name="layers"></param>
        /// <param name="guardrailsId"></param>
        /// <param name="objectivesId"></param>
        /// <param name="documentIds"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Tavus.Persona> CreatePersonaAsync(
            string? personaName = default,
            string? systemPrompt = default,
            string? context = default,
            string? defaultReplicaId = default,
            global::Tavus.CreatePersonaRequestPipelineMode? pipelineMode = default,
            global::Tavus.PersonaLayers? layers = default,
            string? guardrailsId = default,
            string? objectivesId = default,
            global::System.Collections.Generic.IList<string>? documentIds = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}