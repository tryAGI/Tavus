#nullable enable

namespace Tavus
{
    public partial interface IDocumentsClient
    {
        /// <summary>
        /// Update Document<br/>
        /// Update document metadata.
        /// </summary>
        /// <param name="documentId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Tavus.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Tavus.Document> UpdateDocumentAsync(
            string documentId,

            global::Tavus.UpdateDocumentRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Document<br/>
        /// Update document metadata.
        /// </summary>
        /// <param name="documentId"></param>
        /// <param name="documentName"></param>
        /// <param name="tags"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Tavus.Document> UpdateDocumentAsync(
            string documentId,
            string? documentName = default,
            global::System.Collections.Generic.IList<string>? tags = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}