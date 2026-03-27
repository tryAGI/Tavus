#nullable enable

namespace Tavus
{
    public partial interface IConversationsClient
    {
        /// <summary>
        /// Delete Conversation<br/>
        /// Deletes a single conversation.
        /// </summary>
        /// <param name="conversationId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Tavus.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteConversationAsync(
            string conversationId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}