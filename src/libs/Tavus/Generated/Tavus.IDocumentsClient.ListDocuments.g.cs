#nullable enable

namespace Tavus
{
    public partial interface IDocumentsClient
    {
        /// <summary>
        /// List Documents<br/>
        /// Retrieve a list of documents with optional filtering and pagination.
        /// </summary>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <param name="tags"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Tavus.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Tavus.ListDocumentsResponse> ListDocumentsAsync(
            int? page = default,
            int? pageSize = default,
            string? tags = default,
            global::Tavus.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}