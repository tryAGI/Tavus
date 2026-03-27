
#nullable enable

namespace Tavus
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PersonaLayers
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("perception")]
        public global::Tavus.PerceptionLayer? Perception { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stt")]
        public global::Tavus.SttLayer? Stt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversational_flow")]
        public global::Tavus.ConversationalFlowLayer? ConversationalFlow { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("llm")]
        public global::Tavus.LlmLayer? Llm { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tts")]
        public global::Tavus.TtsLayer? Tts { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PersonaLayers" /> class.
        /// </summary>
        /// <param name="perception"></param>
        /// <param name="stt"></param>
        /// <param name="conversationalFlow"></param>
        /// <param name="llm"></param>
        /// <param name="tts"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PersonaLayers(
            global::Tavus.PerceptionLayer? perception,
            global::Tavus.SttLayer? stt,
            global::Tavus.ConversationalFlowLayer? conversationalFlow,
            global::Tavus.LlmLayer? llm,
            global::Tavus.TtsLayer? tts)
        {
            this.Perception = perception;
            this.Stt = stt;
            this.ConversationalFlow = conversationalFlow;
            this.Llm = llm;
            this.Tts = tts;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PersonaLayers" /> class.
        /// </summary>
        public PersonaLayers()
        {
        }
    }
}