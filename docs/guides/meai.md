# Microsoft.Extensions.AI Integration

!!! tip "Cross-SDK comparison"
    See the [centralized MEAI documentation](https://tryagi.github.io/docs/meai/) for feature matrices and comparisons across all tryAGI SDKs.

The Tavus SDK provides `AIFunction` tool wrappers compatible with [Microsoft.Extensions.AI](https://learn.microsoft.com/en-us/dotnet/ai/microsoft-extensions-ai). These tools can be used with any `IChatClient` to give AI models the ability to create and manage real-time video conversations with AI replicas.

## Installation

```bash
dotnet add package Tavus
```

## Create Conversation Tool

Use `AsCreateConversationTool()` to create an `AIFunction` that starts a new real-time video conversation. Pass it to any `IChatClient` via `ChatOptions.Tools`.

```csharp
using Microsoft.Extensions.AI;
using Tavus;

var tavusClient = new TavusClient(
    apiKey: Environment.GetEnvironmentVariable("TAVUS_API_KEY")!);

AIFunction createConversationTool = tavusClient.AsCreateConversationTool();

// Use with any IChatClient (OpenAI, Anthropic, Ollama, etc.)
IChatClient chatClient = /* your chat client */;

var options = new ChatOptions
{
    Tools = [createConversationTool],
};

var response = await chatClient.GetResponseAsync(
    "Start a video conversation using persona p_abc123",
    options);

Console.WriteLine(response.Text);
```

## List Conversations Tool

Use `AsListConversationsTool()` to create an `AIFunction` that lists all conversations.

```csharp
using Microsoft.Extensions.AI;
using Tavus;

var tavusClient = new TavusClient(
    apiKey: Environment.GetEnvironmentVariable("TAVUS_API_KEY")!);

AIFunction listConversationsTool = tavusClient.AsListConversationsTool();

IChatClient chatClient = /* your chat client */;

var options = new ChatOptions
{
    Tools = [listConversationsTool],
};

var response = await chatClient.GetResponseAsync(
    "What conversations do I have?",
    options);

Console.WriteLine(response.Text);
```

## Get Conversation Tool

Use `AsGetConversationTool()` to create an `AIFunction` that retrieves details of a specific conversation including its transcript.

```csharp
using Microsoft.Extensions.AI;
using Tavus;

var tavusClient = new TavusClient(
    apiKey: Environment.GetEnvironmentVariable("TAVUS_API_KEY")!);

AIFunction getConversationTool = tavusClient.AsGetConversationTool();

IChatClient chatClient = /* your chat client */;

var options = new ChatOptions
{
    Tools = [getConversationTool],
};

var response = await chatClient.GetResponseAsync(
    "Get the details and transcript of conversation c_abc123",
    options);

Console.WriteLine(response.Text);
```

## End Conversation Tool

Use `AsEndConversationTool()` to create an `AIFunction` that ends an active conversation.

```csharp
using Microsoft.Extensions.AI;
using Tavus;

var tavusClient = new TavusClient(
    apiKey: Environment.GetEnvironmentVariable("TAVUS_API_KEY")!);

AIFunction endConversationTool = tavusClient.AsEndConversationTool();

IChatClient chatClient = /* your chat client */;

var options = new ChatOptions
{
    Tools = [endConversationTool],
};

var response = await chatClient.GetResponseAsync(
    "End conversation c_abc123",
    options);

Console.WriteLine(response.Text);
```

## List Personas Tool

Use `AsListPersonasTool()` to create an `AIFunction` that lists all available personas.

```csharp
using Microsoft.Extensions.AI;
using Tavus;

var tavusClient = new TavusClient(
    apiKey: Environment.GetEnvironmentVariable("TAVUS_API_KEY")!);

AIFunction listPersonasTool = tavusClient.AsListPersonasTool();

IChatClient chatClient = /* your chat client */;

var options = new ChatOptions
{
    Tools = [listPersonasTool],
};

var response = await chatClient.GetResponseAsync(
    "What personas are available?",
    options);

Console.WriteLine(response.Text);
```

## List Replicas Tool

Use `AsListReplicasTool()` to create an `AIFunction` that lists all available replicas (AI video avatars).

```csharp
using Microsoft.Extensions.AI;
using Tavus;

var tavusClient = new TavusClient(
    apiKey: Environment.GetEnvironmentVariable("TAVUS_API_KEY")!);

AIFunction listReplicasTool = tavusClient.AsListReplicasTool();

IChatClient chatClient = /* your chat client */;

var options = new ChatOptions
{
    Tools = [listReplicasTool],
};

var response = await chatClient.GetResponseAsync(
    "What replicas do I have and what is their training status?",
    options);

Console.WriteLine(response.Text);
```

## Combining All Tools

You can provide all tools simultaneously, letting the model decide which to use.

```csharp
using Microsoft.Extensions.AI;
using Tavus;

var tavusClient = new TavusClient(
    apiKey: Environment.GetEnvironmentVariable("TAVUS_API_KEY")!);

var options = new ChatOptions
{
    Tools =
    [
        tavusClient.AsCreateConversationTool(),
        tavusClient.AsListConversationsTool(),
        tavusClient.AsGetConversationTool(),
        tavusClient.AsEndConversationTool(),
        tavusClient.AsListPersonasTool(),
        tavusClient.AsListReplicasTool(),
    ],
};

IChatClient chatClient = /* your chat client */;

var messages = new List<ChatMessage>
{
    new(ChatRole.User,
        "List my available personas and replicas, then start a conversation " +
        "using the first persona."),
};

while (true)
{
    var response = await chatClient.GetResponseAsync(messages, options);
    messages.AddRange(response.ToChatMessages());

    if (response.FinishReason == ChatFinishReason.ToolCalls)
    {
        var results = await response.CallToolsAsync(options);
        messages.AddRange(results);
        continue;
    }

    Console.WriteLine(response.Text);
    break;
}
```

## Tool Details

| Method | Tool Name | Description |
|--------|-----------|-------------|
| `AsCreateConversationTool()` | `CreateConversation` | Creates a real-time video conversation with a Tavus AI replica |
| `AsListConversationsTool()` | `ListConversations` | Lists all video conversations with status |
| `AsGetConversationTool()` | `GetConversation` | Gets details and transcript of a specific conversation |
| `AsEndConversationTool()` | `EndConversation` | Ends an active video conversation |
| `AsListPersonasTool()` | `ListPersonas` | Lists all personas with configuration details |
| `AsListReplicasTool()` | `ListReplicas` | Lists all replicas with training status |
