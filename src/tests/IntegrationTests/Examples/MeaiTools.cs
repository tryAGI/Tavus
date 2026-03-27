/*
order: 20
title: MEAI Tools
slug: meai-tools

Shows how to use Tavus as AIFunction tools with any IChatClient.
*/

using Microsoft.Extensions.AI;

namespace Tavus.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public void ToolsAreCreatedSuccessfully()
    {
        //// Create AIFunction tool wrappers from the Tavus client for use with any IChatClient.
        using var client = new TavusClient(apiKey: "test-key");

        var tools = new AIFunction[]
        {
            client.AsCreateConversationTool(),
            client.AsListConversationsTool(),
            client.AsGetConversationTool(),
            client.AsEndConversationTool(),
            client.AsListPersonasTool(),
            client.AsListReplicasTool(),
        };

        foreach (var tool in tools)
        {
            tool.Should().NotBeNull();
            tool.Name.Should().NotBeNullOrEmpty();
            tool.Description.Should().NotBeNullOrEmpty();
        }
    }

    [TestMethod]
    public void AsCreateConversationTool_CreatesValidTool()
    {
        using var client = new TavusClient(apiKey: "test-key");

        //// The CreateConversation tool lets an AI model start a video conversation.
        var tool = client.AsCreateConversationTool();
        tool.Name.Should().Be("CreateConversation");
        tool.Description.Should().Contain("conversation");
    }

    [TestMethod]
    public void AsListConversationsTool_CreatesValidTool()
    {
        using var client = new TavusClient(apiKey: "test-key");

        //// The ListConversations tool lets an AI model list all conversations.
        var tool = client.AsListConversationsTool();
        tool.Name.Should().Be("ListConversations");
        tool.Description.Should().Contain("conversation");
    }

    [TestMethod]
    public void AsGetConversationTool_CreatesValidTool()
    {
        using var client = new TavusClient(apiKey: "test-key");

        //// The GetConversation tool retrieves details of a specific conversation.
        var tool = client.AsGetConversationTool();
        tool.Name.Should().Be("GetConversation");
        tool.Description.Should().Contain("conversation");
    }

    [TestMethod]
    public void AsEndConversationTool_CreatesValidTool()
    {
        using var client = new TavusClient(apiKey: "test-key");

        //// The EndConversation tool ends an active video conversation.
        var tool = client.AsEndConversationTool();
        tool.Name.Should().Be("EndConversation");
        tool.Description.Should().Contain("conversation");
    }

    [TestMethod]
    public void AsListPersonasTool_CreatesValidTool()
    {
        using var client = new TavusClient(apiKey: "test-key");

        //// The ListPersonas tool lists all available personas.
        var tool = client.AsListPersonasTool();
        tool.Name.Should().Be("ListPersonas");
        tool.Description.Should().Contain("persona");
    }

    [TestMethod]
    public void AsListReplicasTool_CreatesValidTool()
    {
        using var client = new TavusClient(apiKey: "test-key");

        //// The ListReplicas tool lists all available replicas (AI video avatars).
        var tool = client.AsListReplicasTool();
        tool.Name.Should().Be("ListReplicas");
        tool.Description.Should().Contain("replica");
    }
}
