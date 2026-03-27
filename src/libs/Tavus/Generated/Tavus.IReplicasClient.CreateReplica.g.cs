#nullable enable

namespace Tavus
{
    public partial interface IReplicasClient
    {
        /// <summary>
        /// Create Replica<br/>
        /// Create a new replica using the latest phoenix-4 model.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Tavus.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Tavus.Replica> CreateReplicaAsync(

            global::Tavus.CreateReplicaRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Replica<br/>
        /// Create a new replica using the latest phoenix-4 model.
        /// </summary>
        /// <param name="trainVideoUrl">
        /// Publicly accessible download link to the training video.
        /// </param>
        /// <param name="consentVideoUrl">
        /// Publicly accessible download link to the consent video. Required for personal replicas.
        /// </param>
        /// <param name="replicaName">
        /// Name for the replica.
        /// </param>
        /// <param name="callbackUrl">
        /// URL to receive training status callbacks.
        /// </param>
        /// <param name="modelName">
        /// Model to use (defaults to phoenix-4).
        /// </param>
        /// <param name="replicaType">
        /// The type of replica.
        /// </param>
        /// <param name="trainAudioUrl"></param>
        /// <param name="thumbnailVideoUrl"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Tavus.Replica> CreateReplicaAsync(
            string trainVideoUrl,
            string? consentVideoUrl = default,
            string? replicaName = default,
            string? callbackUrl = default,
            global::Tavus.CreateReplicaRequestModelName? modelName = default,
            global::Tavus.CreateReplicaRequestReplicaType? replicaType = default,
            string? trainAudioUrl = default,
            string? thumbnailVideoUrl = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}