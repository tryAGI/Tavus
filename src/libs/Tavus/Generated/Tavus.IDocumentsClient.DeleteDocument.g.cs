#nullable enable

namespace Tavus
{
    public partial interface IDocumentsClient
    {
        /// <summary>
        /// Delete Document<br/>
        /// Delete a document.
        /// </summary>
        /// <param name="documentId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Tavus.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteDocumentAsync(
            string documentId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}