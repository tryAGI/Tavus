#nullable enable

namespace Tavus
{
    public partial interface IObjectivesClient
    {
        /// <summary>
        /// Get Objective<br/>
        /// Returns a single objective.
        /// </summary>
        /// <param name="objectivesId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Tavus.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Tavus.Objectives> GetObjectivesAsync(
            string objectivesId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}