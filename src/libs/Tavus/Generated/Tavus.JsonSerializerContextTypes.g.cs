
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace Tavus
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class JsonSerializerContextTypes
    {
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? StringStringDictionary { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, object>? StringObjectDictionary { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public global::System.Text.Json.JsonElement? JsonElement { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public global::Tavus.CreateConversationRequest? Type0 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string? Type1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool? Type2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int? Type3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<string>? Type4 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavus.ConversationProperties? Type5 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavus.CreateConversationResponse? Type6 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.DateTime? Type7 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavus.Conversation? Type8 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Tavus.TranscriptMessage>? Type9 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavus.TranscriptMessage? Type10 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavus.ListConversationsResponse? Type11 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Tavus.Conversation>? Type12 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavus.CreateReplicaRequest? Type13 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavus.CreateReplicaRequestModelName? Type14 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavus.CreateReplicaRequestReplicaType? Type15 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavus.Replica? Type16 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavus.RenameReplicaRequest? Type17 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavus.ListReplicasResponse? Type18 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Tavus.Replica>? Type19 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavus.CreatePersonaRequest? Type20 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavus.CreatePersonaRequestPipelineMode? Type21 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavus.PersonaLayers? Type22 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavus.PerceptionLayer? Type23 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavus.SttLayer? Type24 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavus.ConversationalFlowLayer? Type25 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavus.LlmLayer? Type26 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavus.TtsLayer? Type27 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Tavus.ToolDefinition>? Type28 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavus.ToolDefinition? Type29 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavus.ConversationalFlowLayerTurnTakingPatience? Type30 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavus.ConversationalFlowLayerReplicaInterruptibility? Type31 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? Type32 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public object? Type33 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavus.VoiceSettings? Type34 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavus.VoiceSettingsSpeed? Type35 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavus.ToolDefinitionType? Type36 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavus.ToolFunction? Type37 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavus.Persona? Type38 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavus.ListPersonasResponse? Type39 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Tavus.Persona>? Type40 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavus.GenerateVideoRequest? Type41 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavus.VideoProperties? Type42 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavus.VideoPropertiesBackgroundScrollType? Type43 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavus.VideoPropertiesBackgroundScrollDepth? Type44 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavus.VideoPropertiesBackgroundScrollReturn? Type45 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavus.Video? Type46 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavus.RenameVideoRequest? Type47 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavus.ListVideosResponse? Type48 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Tavus.Video>? Type49 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavus.CreateDocumentRequest? Type50 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public byte[]? Type51 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavus.CrawlConfig? Type52 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavus.Document? Type53 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavus.UpdateDocumentRequest? Type54 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavus.RecrawlDocumentRequest? Type55 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavus.ListDocumentsResponse? Type56 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Tavus.Document>? Type57 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavus.CreateGuardrailsRequest? Type58 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavus.Guardrails? Type59 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavus.ListGuardrailsResponse? Type60 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Tavus.Guardrails>? Type61 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavus.CreateObjectivesRequest? Type62 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavus.CreateObjectivesRequestConfirmationMode? Type63 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Tavus.ConditionalObjective>? Type64 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavus.ConditionalObjective? Type65 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavus.Objectives? Type66 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavus.ListObjectivesResponse? Type67 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Tavus.Objectives>? Type68 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavus.JsonPatchOperation? Type69 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavus.JsonPatchOperationOp? Type70 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Tavus.JsonPatchOperation>? Type71 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<string>? ListType0 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Tavus.TranscriptMessage>? ListType1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Tavus.Conversation>? ListType2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Tavus.Replica>? ListType3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Tavus.ToolDefinition>? ListType4 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Tavus.Persona>? ListType5 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Tavus.Video>? ListType6 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Tavus.Document>? ListType7 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Tavus.Guardrails>? ListType8 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Tavus.ConditionalObjective>? ListType9 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Tavus.Objectives>? ListType10 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Tavus.JsonPatchOperation>? ListType11 { get; set; }
    }
}