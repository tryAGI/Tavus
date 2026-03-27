
#nullable enable

namespace Tavus
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RecrawlDocumentRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("crawl")]
        public global::Tavus.CrawlConfig? Crawl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RecrawlDocumentRequest" /> class.
        /// </summary>
        /// <param name="crawl"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RecrawlDocumentRequest(
            global::Tavus.CrawlConfig? crawl)
        {
            this.Crawl = crawl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RecrawlDocumentRequest" /> class.
        /// </summary>
        public RecrawlDocumentRequest()
        {
        }
    }
}