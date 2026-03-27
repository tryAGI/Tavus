#nullable enable

namespace Tavus
{
    public partial interface IReplicasClient
    {
        /// <summary>
        /// List Replicas<br/>
        /// Returns a list of all replicas.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Tavus.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Tavus.ListReplicasResponse> ListReplicasAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}