#nullable enable

namespace Tavus
{
    public partial interface IDocumentsClient
    {
        /// <summary>
        /// Recrawl Document<br/>
        /// Trigger a recrawl of a website document to fetch fresh content.
        /// </summary>
        /// <param name="documentId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Tavus.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Tavus.Document> RecrawlDocumentAsync(
            string documentId,

            global::Tavus.RecrawlDocumentRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Recrawl Document<br/>
        /// Trigger a recrawl of a website document to fetch fresh content.
        /// </summary>
        /// <param name="documentId"></param>
        /// <param name="crawl"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Tavus.Document> RecrawlDocumentAsync(
            string documentId,
            global::Tavus.CrawlConfig? crawl = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}