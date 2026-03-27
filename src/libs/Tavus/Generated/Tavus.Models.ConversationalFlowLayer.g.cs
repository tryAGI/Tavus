
#nullable enable

namespace Tavus
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConversationalFlowLayer
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("turn_detection_model")]
        public string? TurnDetectionModel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("turn_taking_patience")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Tavus.JsonConverters.ConversationalFlowLayerTurnTakingPatienceJsonConverter))]
        public global::Tavus.ConversationalFlowLayerTurnTakingPatience? TurnTakingPatience { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("replica_interruptibility")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Tavus.JsonConverters.ConversationalFlowLayerReplicaInterruptibilityJsonConverter))]
        public global::Tavus.ConversationalFlowLayerReplicaInterruptibility? ReplicaInterruptibility { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationalFlowLayer" /> class.
        /// </summary>
        /// <param name="turnDetectionModel"></param>
        /// <param name="turnTakingPatience"></param>
        /// <param name="replicaInterruptibility"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConversationalFlowLayer(
            string? turnDetectionModel,
            global::Tavus.ConversationalFlowLayerTurnTakingPatience? turnTakingPatience,
            global::Tavus.ConversationalFlowLayerReplicaInterruptibility? replicaInterruptibility)
        {
            this.TurnDetectionModel = turnDetectionModel;
            this.TurnTakingPatience = turnTakingPatience;
            this.ReplicaInterruptibility = replicaInterruptibility;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationalFlowLayer" /> class.
        /// </summary>
        public ConversationalFlowLayer()
        {
        }
    }
}