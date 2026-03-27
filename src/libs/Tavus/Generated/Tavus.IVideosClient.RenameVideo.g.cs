#nullable enable

namespace Tavus
{
    public partial interface IVideosClient
    {
        /// <summary>
        /// Rename Video<br/>
        /// Renames a single video.
        /// </summary>
        /// <param name="videoId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Tavus.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Tavus.Video> RenameVideoAsync(
            string videoId,

            global::Tavus.RenameVideoRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Rename Video<br/>
        /// Renames a single video.
        /// </summary>
        /// <param name="videoId"></param>
        /// <param name="videoName"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Tavus.Video> RenameVideoAsync(
            string videoId,
            string videoName,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}