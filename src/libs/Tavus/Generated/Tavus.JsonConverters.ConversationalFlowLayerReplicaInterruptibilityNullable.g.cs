#nullable enable

namespace Tavus.JsonConverters
{
    /// <inheritdoc />
    public sealed class ConversationalFlowLayerReplicaInterruptibilityNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Tavus.ConversationalFlowLayerReplicaInterruptibility?>
    {
        /// <inheritdoc />
        public override global::Tavus.ConversationalFlowLayerReplicaInterruptibility? Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::Tavus.ConversationalFlowLayerReplicaInterruptibilityExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Tavus.ConversationalFlowLayerReplicaInterruptibility)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Tavus.ConversationalFlowLayerReplicaInterruptibility?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Tavus.ConversationalFlowLayerReplicaInterruptibility? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Tavus.ConversationalFlowLayerReplicaInterruptibilityExtensions.ToValueString(value.Value));
            }
        }
    }
}
