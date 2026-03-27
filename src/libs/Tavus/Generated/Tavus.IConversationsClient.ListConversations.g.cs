#nullable enable

namespace Tavus
{
    public partial interface IConversationsClient
    {
        /// <summary>
        /// List Conversations<br/>
        /// Returns a list of all conversations.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Tavus.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Tavus.ListConversationsResponse> ListConversationsAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}