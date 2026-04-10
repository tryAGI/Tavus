#nullable enable

namespace Tavus
{
    public partial interface IVideosClient
    {
        /// <summary>
        /// Get Video<br/>
        /// Returns a single video. If ready, includes download_url, stream_url, and hosted_url.
        /// </summary>
        /// <param name="videoId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Tavus.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Tavus.Video> GetVideoAsync(
            string videoId,
            global::Tavus.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}