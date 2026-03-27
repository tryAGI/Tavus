#nullable enable

namespace Tavus
{
    public partial interface IConversationsClient
    {
        /// <summary>
        /// Get Conversation<br/>
        /// Returns a single conversation. Append ?verbose=true for additional event data including transcript and perception analysis.
        /// </summary>
        /// <param name="conversationId"></param>
        /// <param name="verbose"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Tavus.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Tavus.Conversation> GetConversationAsync(
            string conversationId,
            bool? verbose = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}