
#nullable enable

namespace Tavus
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreatePersonaRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("persona_name")]
        public string? PersonaName { get; set; }

        /// <summary>
        /// System prompt defining persona behavior. Required for full pipeline mode.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("system_prompt")]
        public string? SystemPrompt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context")]
        public string? Context { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_replica_id")]
        public string? DefaultReplicaId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pipeline_mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Tavus.JsonConverters.CreatePersonaRequestPipelineModeJsonConverter))]
        public global::Tavus.CreatePersonaRequestPipelineMode? PipelineMode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("layers")]
        public global::Tavus.PersonaLayers? Layers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("guardrails_id")]
        public string? GuardrailsId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("objectives_id")]
        public string? ObjectivesId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("document_ids")]
        public global::System.Collections.Generic.IList<string>? DocumentIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePersonaRequest" /> class.
        /// </summary>
        /// <param name="personaName"></param>
        /// <param name="systemPrompt">
        /// System prompt defining persona behavior. Required for full pipeline mode.
        /// </param>
        /// <param name="context"></param>
        /// <param name="defaultReplicaId"></param>
        /// <param name="pipelineMode"></param>
        /// <param name="layers"></param>
        /// <param name="guardrailsId"></param>
        /// <param name="objectivesId"></param>
        /// <param name="documentIds"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreatePersonaRequest(
            string? personaName,
            string? systemPrompt,
            string? context,
            string? defaultReplicaId,
            global::Tavus.CreatePersonaRequestPipelineMode? pipelineMode,
            global::Tavus.PersonaLayers? layers,
            string? guardrailsId,
            string? objectivesId,
            global::System.Collections.Generic.IList<string>? documentIds)
        {
            this.PersonaName = personaName;
            this.SystemPrompt = systemPrompt;
            this.Context = context;
            this.DefaultReplicaId = defaultReplicaId;
            this.PipelineMode = pipelineMode;
            this.Layers = layers;
            this.GuardrailsId = guardrailsId;
            this.ObjectivesId = objectivesId;
            this.DocumentIds = documentIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePersonaRequest" /> class.
        /// </summary>
        public CreatePersonaRequest()
        {
        }
    }
}