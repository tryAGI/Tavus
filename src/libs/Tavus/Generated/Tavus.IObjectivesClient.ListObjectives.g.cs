#nullable enable

namespace Tavus
{
    public partial interface IObjectivesClient
    {
        /// <summary>
        /// List Objectives<br/>
        /// Returns a list of all objectives.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Tavus.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Tavus.ListObjectivesResponse> ListObjectivesAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}