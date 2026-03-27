# Authentication

The Tavus SDK uses API key authentication via the `x-api-key` header. You can obtain an API key from your [Tavus dashboard](https://platform.tavus.io/).

## Basic Usage

```csharp
using Tavus;

var client = new TavusClient(apiKey: Environment.GetEnvironmentVariable("TAVUS_API_KEY")!);
```

## Environment Variable

| Variable | Description |
|----------|-------------|
| `TAVUS_API_KEY` | Your Tavus API key |
