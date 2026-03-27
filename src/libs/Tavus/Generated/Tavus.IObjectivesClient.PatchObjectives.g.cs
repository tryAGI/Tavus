#nullable enable

namespace Tavus
{
    public partial interface IObjectivesClient
    {
        /// <summary>
        /// Patch Objective<br/>
        /// Update an objective using JSON Patch operations.
        /// </summary>
        /// <param name="objectivesId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Tavus.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Tavus.Objectives> PatchObjectivesAsync(
            string objectivesId,

            global::System.Collections.Generic.IList<global::Tavus.JsonPatchOperation> request,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}