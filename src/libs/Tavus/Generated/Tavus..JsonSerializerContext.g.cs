
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Tavus
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::Tavus.JsonConverters.CreateReplicaRequestModelNameJsonConverter),
            typeof(global::Tavus.JsonConverters.CreateReplicaRequestModelNameNullableJsonConverter),
            typeof(global::Tavus.JsonConverters.CreateReplicaRequestReplicaTypeJsonConverter),
            typeof(global::Tavus.JsonConverters.CreateReplicaRequestReplicaTypeNullableJsonConverter),
            typeof(global::Tavus.JsonConverters.CreatePersonaRequestPipelineModeJsonConverter),
            typeof(global::Tavus.JsonConverters.CreatePersonaRequestPipelineModeNullableJsonConverter),
            typeof(global::Tavus.JsonConverters.ConversationalFlowLayerTurnTakingPatienceJsonConverter),
            typeof(global::Tavus.JsonConverters.ConversationalFlowLayerTurnTakingPatienceNullableJsonConverter),
            typeof(global::Tavus.JsonConverters.ConversationalFlowLayerReplicaInterruptibilityJsonConverter),
            typeof(global::Tavus.JsonConverters.ConversationalFlowLayerReplicaInterruptibilityNullableJsonConverter),
            typeof(global::Tavus.JsonConverters.VoiceSettingsSpeedJsonConverter),
            typeof(global::Tavus.JsonConverters.VoiceSettingsSpeedNullableJsonConverter),
            typeof(global::Tavus.JsonConverters.ToolDefinitionTypeJsonConverter),
            typeof(global::Tavus.JsonConverters.ToolDefinitionTypeNullableJsonConverter),
            typeof(global::Tavus.JsonConverters.VideoPropertiesBackgroundScrollTypeJsonConverter),
            typeof(global::Tavus.JsonConverters.VideoPropertiesBackgroundScrollTypeNullableJsonConverter),
            typeof(global::Tavus.JsonConverters.VideoPropertiesBackgroundScrollDepthJsonConverter),
            typeof(global::Tavus.JsonConverters.VideoPropertiesBackgroundScrollDepthNullableJsonConverter),
            typeof(global::Tavus.JsonConverters.VideoPropertiesBackgroundScrollReturnJsonConverter),
            typeof(global::Tavus.JsonConverters.VideoPropertiesBackgroundScrollReturnNullableJsonConverter),
            typeof(global::Tavus.JsonConverters.CreateObjectivesRequestConfirmationModeJsonConverter),
            typeof(global::Tavus.JsonConverters.CreateObjectivesRequestConfirmationModeNullableJsonConverter),
            typeof(global::Tavus.JsonConverters.JsonPatchOperationOpJsonConverter),
            typeof(global::Tavus.JsonConverters.JsonPatchOperationOpNullableJsonConverter),
            typeof(global::Tavus.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavus.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavus.CreateConversationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavus.ConversationProperties))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavus.CreateConversationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavus.Conversation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Tavus.TranscriptMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavus.TranscriptMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavus.ListConversationsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Tavus.Conversation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavus.CreateReplicaRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavus.CreateReplicaRequestModelName))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavus.CreateReplicaRequestReplicaType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavus.Replica))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavus.RenameReplicaRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavus.ListReplicasResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Tavus.Replica>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavus.CreatePersonaRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavus.CreatePersonaRequestPipelineMode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavus.PersonaLayers))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavus.PerceptionLayer))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavus.SttLayer))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavus.ConversationalFlowLayer))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavus.LlmLayer))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavus.TtsLayer))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Tavus.ToolDefinition>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavus.ToolDefinition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavus.ConversationalFlowLayerTurnTakingPatience))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavus.ConversationalFlowLayerReplicaInterruptibility))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavus.VoiceSettings))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavus.VoiceSettingsSpeed))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavus.ToolDefinitionType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavus.ToolFunction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavus.Persona))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavus.ListPersonasResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Tavus.Persona>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavus.GenerateVideoRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavus.VideoProperties))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavus.VideoPropertiesBackgroundScrollType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavus.VideoPropertiesBackgroundScrollDepth))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavus.VideoPropertiesBackgroundScrollReturn))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavus.Video))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavus.RenameVideoRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavus.ListVideosResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Tavus.Video>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavus.CreateDocumentRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavus.CrawlConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavus.Document))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavus.UpdateDocumentRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavus.RecrawlDocumentRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavus.ListDocumentsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Tavus.Document>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavus.CreateGuardrailsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavus.Guardrails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavus.ListGuardrailsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Tavus.Guardrails>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavus.CreateObjectivesRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavus.CreateObjectivesRequestConfirmationMode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Tavus.ConditionalObjective>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavus.ConditionalObjective))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavus.Objectives))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavus.ListObjectivesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Tavus.Objectives>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavus.JsonPatchOperation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavus.JsonPatchOperationOp))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Tavus.JsonPatchOperation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Tavus.TranscriptMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Tavus.Conversation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Tavus.Replica>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Tavus.ToolDefinition>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Tavus.Persona>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Tavus.Video>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Tavus.Document>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Tavus.Guardrails>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Tavus.ConditionalObjective>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Tavus.Objectives>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Tavus.JsonPatchOperation>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}