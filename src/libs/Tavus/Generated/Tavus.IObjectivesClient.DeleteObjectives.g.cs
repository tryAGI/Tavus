#nullable enable

namespace Tavus
{
    public partial interface IObjectivesClient
    {
        /// <summary>
        /// Delete Objective<br/>
        /// Deletes a single objective.
        /// </summary>
        /// <param name="objectivesId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Tavus.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteObjectivesAsync(
            string objectivesId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}