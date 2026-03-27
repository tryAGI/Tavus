# CLAUDE.md -- Tavus SDK

## Overview

Auto-generated C# SDK for [Tavus](https://www.tavus.io/) -- conversational video AI platform for real-time video conversations with AI replicas and personas, plus video generation, dubbing, guardrails, and memory management.
**No public OpenAPI spec exists** -- `openapi.yaml` is manually maintained from Tavus API documentation.

## Build & Test

```bash
dotnet build Tavus.slnx
dotnet test src/tests/IntegrationTests/
```

## Auth

Bearer token auth:

```csharp
var client = new TavusClient(apiKey); // TAVUS_API_KEY env var
```

## Key Files

- `src/libs/Tavus/openapi.yaml` -- **Manually maintained** OpenAPI spec (3.0.3, no public spec from Tavus)
- `src/libs/Tavus/generate.sh` -- Runs autosdk on local spec (no download step, no spec fixes)
- `src/libs/Tavus/Generated/` -- **Never edit** -- auto-generated code
- `src/libs/Tavus/Extensions/TavusClient.AsTool.cs` -- MEAI `AIFunction` tools (conversations, personas, replicas)
- `src/tests/IntegrationTests/Tests.cs` -- Test helper with bearer auth
- `src/tests/IntegrationTests/Examples/` -- Example tests (also generate docs)

## Spec Notes

- **No public OpenAPI spec exists** -- `openapi.yaml` was manually created from Tavus API docs
- No spec fixes needed -- local spec is maintained in correct format
- Uses `--exclude-deprecated-operations` flag

## Sub-client Pattern

Tavus API has tagged operations generating sub-clients:
- `client.Conversations.*` -- Create, list, get, end conversations; manage conversation context
- `client.Personas.*` -- Create, list, get, update, delete AI personas
- `client.Replicas.*` -- Create, list, get, update, delete video replicas (AI avatars)
- `client.Videos.*` -- Create, list, get, update, delete generated videos
- `client.Documents.*` -- Upload and manage documents
- `client.Guardrails.*` -- Manage conversation guardrails
- `client.Memories.*` -- Manage persona memories
- `client.Objectives.*` -- Manage conversation objectives

## MEAI Integration

AIFunction tools for use with any `IChatClient`:
- `AsCreateConversationTool()` -- Create a real-time video conversation with persona and replica
- `AsListConversationsTool()` -- List all conversations with status and URLs
- `AsGetConversationTool()` -- Get conversation details including transcript and timing
- `AsEndConversationTool()` -- End an active conversation
- `AsListPersonasTool()` -- List all personas with IDs and configuration
- `AsListReplicasTool()` -- List all replicas with status and training progress

No MEAI interface (`IChatClient`, `IEmbeddingGenerator`, `ISpeechToTextClient`) is implemented -- Tavus is a conversational video AI platform with no matching MEAI interface.
