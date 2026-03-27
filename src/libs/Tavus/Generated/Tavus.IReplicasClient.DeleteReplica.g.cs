#nullable enable

namespace Tavus
{
    public partial interface IReplicasClient
    {
        /// <summary>
        /// Delete Replica<br/>
        /// Deletes a replica.
        /// </summary>
        /// <param name="replicaId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Tavus.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteReplicaAsync(
            string replicaId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}