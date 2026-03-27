#nullable enable

namespace Tavus
{
    public partial interface IDocumentsClient
    {
        /// <summary>
        /// Get Document<br/>
        /// Retrieve a specific document.
        /// </summary>
        /// <param name="documentId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Tavus.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Tavus.Document> GetDocumentAsync(
            string documentId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}