
#nullable enable

namespace Tavus
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VideoProperties
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("background_scroll")]
        public bool? BackgroundScroll { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("background_scroll_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Tavus.JsonConverters.VideoPropertiesBackgroundScrollTypeJsonConverter))]
        public global::Tavus.VideoPropertiesBackgroundScrollType? BackgroundScrollType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("background_scroll_depth")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Tavus.JsonConverters.VideoPropertiesBackgroundScrollDepthJsonConverter))]
        public global::Tavus.VideoPropertiesBackgroundScrollDepth? BackgroundScrollDepth { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("background_scroll_return")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Tavus.JsonConverters.VideoPropertiesBackgroundScrollReturnJsonConverter))]
        public global::Tavus.VideoPropertiesBackgroundScrollReturn? BackgroundScrollReturn { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoProperties" /> class.
        /// </summary>
        /// <param name="backgroundScroll"></param>
        /// <param name="backgroundScrollType"></param>
        /// <param name="backgroundScrollDepth"></param>
        /// <param name="backgroundScrollReturn"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VideoProperties(
            bool? backgroundScroll,
            global::Tavus.VideoPropertiesBackgroundScrollType? backgroundScrollType,
            global::Tavus.VideoPropertiesBackgroundScrollDepth? backgroundScrollDepth,
            global::Tavus.VideoPropertiesBackgroundScrollReturn? backgroundScrollReturn)
        {
            this.BackgroundScroll = backgroundScroll;
            this.BackgroundScrollType = backgroundScrollType;
            this.BackgroundScrollDepth = backgroundScrollDepth;
            this.BackgroundScrollReturn = backgroundScrollReturn;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoProperties" /> class.
        /// </summary>
        public VideoProperties()
        {
        }
    }
}