using Microsoft.Extensions.AI;

namespace Tavus;

/// <summary>
/// Extensions for using TavusClient as MEAI tools with any IChatClient.
/// </summary>
public static class TavusToolExtensions
{
    /// <summary>
    /// Creates an <see cref="AIFunction"/> that creates a new real-time video conversation
    /// with an AI replica and persona, suitable for use as a tool with any IChatClient.
    /// </summary>
    /// <param name="client">The Tavus client to use.</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    public static AIFunction AsCreateConversationTool(this TavusClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (
                string personaId,
                string? replicaId,
                string? conversationalContext,
                string? customGreeting,
                string? language,
                CancellationToken cancellationToken) =>
            {
                var response = await client.Conversations.CreateConversationAsync(
                    personaId: personaId,
                    replicaId: replicaId,
                    conversationalContext: conversationalContext,
                    customGreeting: customGreeting,
                    language: language,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return FormatCreateConversationResponse(response);
            },
            name: "CreateConversation",
            description: "Creates a new real-time video conversation with a Tavus AI replica. Returns a conversation URL to join the call. Requires a persona ID and optionally a replica ID, context, greeting, and language.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that lists all conversations,
    /// suitable for use as a tool with any IChatClient.
    /// </summary>
    /// <param name="client">The Tavus client to use.</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    public static AIFunction AsListConversationsTool(this TavusClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (CancellationToken cancellationToken) =>
            {
                var response = await client.Conversations.ListConversationsAsync(
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return FormatListConversationsResponse(response);
            },
            name: "ListConversations",
            description: "Lists all Tavus video conversations with their status, IDs, and URLs.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that retrieves a specific conversation with details,
    /// suitable for use as a tool with any IChatClient.
    /// </summary>
    /// <param name="client">The Tavus client to use.</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    public static AIFunction AsGetConversationTool(this TavusClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (string conversationId, CancellationToken cancellationToken) =>
            {
                var response = await client.Conversations.GetConversationAsync(
                    conversationId: conversationId,
                    verbose: true,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return FormatConversation(response);
            },
            name: "GetConversation",
            description: "Gets details of a specific Tavus conversation by ID, including status, transcript, and timing information.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that ends an active conversation,
    /// suitable for use as a tool with any IChatClient.
    /// </summary>
    /// <param name="client">The Tavus client to use.</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    public static AIFunction AsEndConversationTool(this TavusClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (string conversationId, CancellationToken cancellationToken) =>
            {
                await client.Conversations.EndConversationAsync(
                    conversationId: conversationId,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return $"Conversation {conversationId} has been ended successfully.";
            },
            name: "EndConversation",
            description: "Ends an active Tavus video conversation by its conversation ID.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that lists all personas,
    /// suitable for use as a tool with any IChatClient.
    /// </summary>
    /// <param name="client">The Tavus client to use.</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    public static AIFunction AsListPersonasTool(this TavusClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (CancellationToken cancellationToken) =>
            {
                var response = await client.Personas.ListPersonasAsync(
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return FormatListPersonasResponse(response);
            },
            name: "ListPersonas",
            description: "Lists all Tavus personas with their IDs, names, and configuration details.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that lists all replicas,
    /// suitable for use as a tool with any IChatClient.
    /// </summary>
    /// <param name="client">The Tavus client to use.</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    public static AIFunction AsListReplicasTool(this TavusClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (CancellationToken cancellationToken) =>
            {
                var response = await client.Replicas.ListReplicasAsync(
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return FormatListReplicasResponse(response);
            },
            name: "ListReplicas",
            description: "Lists all Tavus replicas (AI video avatars) with their IDs, names, status, and training progress.");
    }

    private static string FormatCreateConversationResponse(CreateConversationResponse response)
    {
        var parts = new List<string>();

        if (response.ConversationId is { Length: > 0 })
        {
            parts.Add($"Conversation ID: {response.ConversationId}");
        }

        if (response.ConversationUrl is { Length: > 0 })
        {
            parts.Add($"Join URL: {response.ConversationUrl}");
        }

        if (response.ConversationName is { Length: > 0 })
        {
            parts.Add($"Name: {response.ConversationName}");
        }

        if (response.Status is { Length: > 0 })
        {
            parts.Add($"Status: {response.Status}");
        }

        return parts.Count > 0
            ? string.Join("\n", parts)
            : "Conversation created successfully.";
    }

    private static string FormatListConversationsResponse(ListConversationsResponse response)
    {
        if (response.Data is not { Count: > 0 })
        {
            return "No conversations found.";
        }

        var parts = new List<string> { $"Found {response.Data.Count} conversation(s):" };

        foreach (var conversation in response.Data)
        {
            var entry = $"- [{conversation.ConversationId}] {conversation.ConversationName ?? "(unnamed)"}";
            if (conversation.Status is { Length: > 0 })
            {
                entry += $" (Status: {conversation.Status})";
            }

            parts.Add(entry);
        }

        return string.Join("\n", parts);
    }

    private static string FormatConversation(Conversation conversation)
    {
        var parts = new List<string>();

        if (conversation.ConversationId is { Length: > 0 })
        {
            parts.Add($"ID: {conversation.ConversationId}");
        }

        if (conversation.ConversationName is { Length: > 0 })
        {
            parts.Add($"Name: {conversation.ConversationName}");
        }

        if (conversation.Status is { Length: > 0 })
        {
            parts.Add($"Status: {conversation.Status}");
        }

        if (conversation.ConversationUrl is { Length: > 0 })
        {
            parts.Add($"URL: {conversation.ConversationUrl}");
        }

        if (conversation.PersonaId is { Length: > 0 })
        {
            parts.Add($"Persona: {conversation.PersonaId}");
        }

        if (conversation.ReplicaId is { Length: > 0 })
        {
            parts.Add($"Replica: {conversation.ReplicaId}");
        }

        if (conversation.CreatedAt is { } createdAt)
        {
            parts.Add($"Created: {createdAt:u}");
        }

        if (conversation.EndedAt is { } endedAt)
        {
            parts.Add($"Ended: {endedAt:u}");
        }

        if (conversation.ShutdownReason is { Length: > 0 })
        {
            parts.Add($"Shutdown reason: {conversation.ShutdownReason}");
        }

        if (conversation.Transcript is { Count: > 0 })
        {
            parts.Add($"Transcript ({conversation.Transcript.Count} messages):");
            foreach (var msg in conversation.Transcript)
            {
                parts.Add($"  > {msg.ToJson()}");
            }
        }

        return parts.Count > 0
            ? string.Join("\n", parts)
            : "No conversation details available.";
    }

    private static string FormatListPersonasResponse(ListPersonasResponse response)
    {
        if (response.Data is not { Count: > 0 })
        {
            return "No personas found.";
        }

        var parts = new List<string> { $"Found {response.Data.Count} persona(s):" };

        foreach (var persona in response.Data)
        {
            var entry = $"- [{persona.PersonaId}] {persona.PersonaName ?? "(unnamed)"}";
            if (persona.PipelineMode is { Length: > 0 })
            {
                entry += $" (Mode: {persona.PipelineMode})";
            }

            parts.Add(entry);
        }

        return string.Join("\n", parts);
    }

    private static string FormatListReplicasResponse(ListReplicasResponse response)
    {
        if (response.Data is not { Count: > 0 })
        {
            return "No replicas found.";
        }

        var parts = new List<string> { $"Found {response.Data.Count} replica(s):" };

        foreach (var replica in response.Data)
        {
            var entry = $"- [{replica.ReplicaId}] {replica.ReplicaName ?? "(unnamed)"}";
            if (replica.Status is { Length: > 0 })
            {
                entry += $" (Status: {replica.Status})";
            }
            if (replica.TrainingProgress is { Length: > 0 })
            {
                entry += $" [Training: {replica.TrainingProgress}]";
            }

            parts.Add(entry);
        }

        return string.Join("\n", parts);
    }
}
