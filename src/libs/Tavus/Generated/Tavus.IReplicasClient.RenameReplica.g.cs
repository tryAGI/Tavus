#nullable enable

namespace Tavus
{
    public partial interface IReplicasClient
    {
        /// <summary>
        /// Rename Replica<br/>
        /// Renames a single replica.
        /// </summary>
        /// <param name="replicaId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Tavus.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Tavus.Replica> RenameReplicaAsync(
            string replicaId,

            global::Tavus.RenameReplicaRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Rename Replica<br/>
        /// Renames a single replica.
        /// </summary>
        /// <param name="replicaId"></param>
        /// <param name="replicaName"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Tavus.Replica> RenameReplicaAsync(
            string replicaId,
            string replicaName,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}