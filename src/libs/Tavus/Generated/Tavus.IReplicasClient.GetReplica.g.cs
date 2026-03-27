#nullable enable

namespace Tavus
{
    public partial interface IReplicasClient
    {
        /// <summary>
        /// Get Replica<br/>
        /// Returns a single replica with training progress.
        /// </summary>
        /// <param name="replicaId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Tavus.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Tavus.Replica> GetReplicaAsync(
            string replicaId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}