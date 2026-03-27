#nullable enable

namespace Tavus
{
    public partial interface IVideosClient
    {
        /// <summary>
        /// Delete Video<br/>
        /// Deletes a single video.
        /// </summary>
        /// <param name="videoId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Tavus.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteVideoAsync(
            string videoId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}