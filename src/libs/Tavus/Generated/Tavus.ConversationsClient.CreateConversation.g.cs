
#nullable enable

namespace Tavus
{
    public partial class ConversationsClient
    {


        private static readonly global::Tavus.EndPointSecurityRequirement s_CreateConversationSecurityRequirement0 =
            new global::Tavus.EndPointSecurityRequirement
            {
                Authorizations = new global::Tavus.EndPointAuthorizationRequirement[]
                {                    new global::Tavus.EndPointAuthorizationRequirement
                    {
                        Type = "ApiKey",
                        SchemeId = "ApiKeyAuth",
                        Location = "Header",
                        Name = "x-api-key",
                        FriendlyName = "ApiKeyInHeader",
                    },
                },
            };
        private static readonly global::Tavus.EndPointSecurityRequirement[] s_CreateConversationSecurityRequirements =
            new global::Tavus.EndPointSecurityRequirement[]
            {                s_CreateConversationSecurityRequirement0,
            };
        partial void PrepareCreateConversationArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::Tavus.CreateConversationRequest request);
        partial void PrepareCreateConversationRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::Tavus.CreateConversationRequest request);
        partial void ProcessCreateConversationResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateConversationResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create Conversation<br/>
        /// Start a real-time video conversation with your AI replica and persona. The response includes a conversation_url to join the call or embed it.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Tavus.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Tavus.CreateConversationResponse> CreateConversationAsync(

            global::Tavus.CreateConversationRequest request,
            global::Tavus.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreateConversationArguments(
                httpClient: HttpClient,
                request: request);


            var __authorizations = global::Tavus.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_CreateConversationSecurityRequirements,
                operationName: "CreateConversationAsync");

            using var __timeoutCancellationTokenSource = global::Tavus.AutoSDKRequestOptionsSupport.CreateTimeoutCancellationTokenSource(
                clientOptions: Options,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken);
            var __effectiveCancellationToken = __timeoutCancellationTokenSource?.Token ?? cancellationToken;
            var __effectiveReadResponseAsString = global::Tavus.AutoSDKRequestOptionsSupport.GetReadResponseAsString(
                clientOptions: Options,
                requestOptions: requestOptions,
                fallbackValue: ReadResponseAsString);
            var __maxAttempts = global::Tavus.AutoSDKRequestOptionsSupport.GetMaxAttempts(
                clientOptions: Options,
                requestOptions: requestOptions,
                supportsRetry: true);

            global::System.Net.Http.HttpRequestMessage __CreateHttpRequest()
            {
                            var __pathBuilder = new global::Tavus.PathBuilder(
                                path: "/v2/conversations",
                                baseUri: HttpClient.BaseAddress);
                            var __path = __pathBuilder.ToString();
                __path = global::Tavus.AutoSDKRequestOptionsSupport.AppendQueryParameters(
                    path: __path,
                    clientParameters: Options.QueryParameters,
                    requestParameters: requestOptions?.QueryParameters);
                var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                    method: global::System.Net.Http.HttpMethod.Post,
                    requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
                __httpRequest.Version = global::System.Net.HttpVersion.Version11;
                __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in __authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2" ||
                    __authorization.Type == "OpenIdConnect")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                } 
            }
                            var __httpRequestContentBody = request.ToJson(JsonSerializerContext);
                            var __httpRequestContent = new global::System.Net.Http.StringContent(
                                content: __httpRequestContentBody,
                                encoding: global::System.Text.Encoding.UTF8,
                                mediaType: "application/json");
                            __httpRequest.Content = __httpRequestContent;
                global::Tavus.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareCreateConversationRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    request: request);

                return __httpRequest;
            }

            global::System.Net.Http.HttpRequestMessage? __httpRequest = null;
            global::System.Net.Http.HttpResponseMessage? __response = null;
            var __attemptNumber = 0;
            try
            {
                for (var __attempt = 1; __attempt <= __maxAttempts; __attempt++)
                {
                    __attemptNumber = __attempt;
                    __httpRequest = __CreateHttpRequest();
                    await global::Tavus.AutoSDKRequestOptionsSupport.OnBeforeRequestAsync(
                            clientOptions: Options,
                            context: global::Tavus.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "CreateConversation",
                                methodName: "CreateConversationAsync",
                                pathTemplate: "\"/v2/conversations\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                    try
                    {
                        __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                    }
                    catch (global::System.Net.Http.HttpRequestException __exception)
                    {
                        var __willRetry = __attempt < __maxAttempts && !__effectiveCancellationToken.IsCancellationRequested;
                        await global::Tavus.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Tavus.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "CreateConversation",
                                methodName: "CreateConversationAsync",
                                pathTemplate: "\"/v2/conversations\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: __exception,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: __willRetry,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        if (!__willRetry)
                        {
                            throw;
                        }

                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::Tavus.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    if (__response != null &&
                        __attempt < __maxAttempts &&
                        global::Tavus.AutoSDKRequestOptionsSupport.ShouldRetryStatusCode(__response.StatusCode))
                    {
                        await global::Tavus.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Tavus.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "CreateConversation",
                                methodName: "CreateConversationAsync",
                                pathTemplate: "\"/v2/conversations\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: true,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        __response.Dispose();
                        __response = null;
                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::Tavus.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    break;
                }

                if (__response == null)
                {
                    throw new global::System.InvalidOperationException("No response received.");
                }

                using (__response)
                {

                ProcessResponse(
                    client: HttpClient,
                    response: __response);
                ProcessCreateConversationResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::Tavus.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::Tavus.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "CreateConversation",
                                methodName: "CreateConversationAsync",
                                pathTemplate: "\"/v2/conversations\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                else
                {
                    await global::Tavus.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Tavus.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "CreateConversation",
                                methodName: "CreateConversationAsync",
                                pathTemplate: "\"/v2/conversations\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }

                            if (__effectiveReadResponseAsString)
                            {
                                var __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                    __effectiveCancellationToken
                #endif
                                ).ConfigureAwait(false);

                                ProcessResponseContent(
                                    client: HttpClient,
                                    response: __response,
                                    content: ref __content);
                                ProcessCreateConversationResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    return
                                        global::Tavus.CreateConversationResponse.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                }
                                catch (global::System.Exception __ex)
                                {
                                    throw new global::Tavus.ApiException(
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        statusCode: __response.StatusCode)
                                    {
                                        ResponseBody = __content,
                                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value),
                                    };
                                }
                            }
                            else
                            {
                                try
                                {
                                    __response.EnsureSuccessStatusCode();
                                    using var __content = await __response.Content.ReadAsStreamAsync(
                #if NET5_0_OR_GREATER
                                        __effectiveCancellationToken
                #endif
                                    ).ConfigureAwait(false);

                                    return
                                        await global::Tavus.CreateConversationResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                }
                                catch (global::System.Exception __ex)
                                {
                                    string? __content = null;
                                    try
                                    {
                                        __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                            __effectiveCancellationToken
                #endif
                                        ).ConfigureAwait(false);
                                    }
                                    catch (global::System.Exception)
                                    {
                                    }

                                    throw new global::Tavus.ApiException(
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        statusCode: __response.StatusCode)
                                    {
                                        ResponseBody = __content,
                                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value),
                                    };
                                }
                            }

                }
            }
            finally
            {
                __httpRequest?.Dispose();
            }
        }
        /// <summary>
        /// Create Conversation<br/>
        /// Start a real-time video conversation with your AI replica and persona. The response includes a conversation_url to join the call or embed it.
        /// </summary>
        /// <param name="personaId">
        /// The identifier of the persona to use.
        /// </param>
        /// <param name="replicaId">
        /// The identifier of the replica. Required if persona has no default replica.
        /// </param>
        /// <param name="callbackUrl">
        /// URL to receive webhook callbacks.
        /// </param>
        /// <param name="conversationalContext">
        /// Additional context for the LLM.
        /// </param>
        /// <param name="customGreeting">
        /// Custom greeting message.
        /// </param>
        /// <param name="language">
        /// Conversation language or "multilingual" for auto-detection.
        /// </param>
        /// <param name="audioOnly">
        /// Start in audio-only mode.
        /// </param>
        /// <param name="maxCallDuration">
        /// Maximum call length in seconds (max 3600).
        /// </param>
        /// <param name="idleTimeout">
        /// Timeout if no participant joins.
        /// </param>
        /// <param name="participantLeftTimeout">
        /// Timeout after last participant leaves.
        /// </param>
        /// <param name="enableClosedCaptions">
        /// Enable closed captions.
        /// </param>
        /// <param name="isPrivate">
        /// Create a private conversation requiring a meeting token.
        /// </param>
        /// <param name="maxParticipantCount">
        /// Maximum number of participants.
        /// </param>
        /// <param name="applyGreenscreen">
        /// Apply green screen effect.
        /// </param>
        /// <param name="backgroundUrl">
        /// Website URL for background.
        /// </param>
        /// <param name="backgroundImageUrl">
        /// Image URL for background.
        /// </param>
        /// <param name="memoryStores">
        /// Memory store identifiers for cross-conversation memory.
        /// </param>
        /// <param name="enableRecording">
        /// Enable conversation recording.
        /// </param>
        /// <param name="recordingS3BucketRegion">
        /// AWS S3 bucket region for recordings.
        /// </param>
        /// <param name="recordingS3BucketName">
        /// AWS S3 bucket name for recordings.
        /// </param>
        /// <param name="properties"></param>
        /// <param name="documentIds">
        /// Knowledge base document IDs to make available.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Tavus.CreateConversationResponse> CreateConversationAsync(
            string? personaId = default,
            string? replicaId = default,
            string? callbackUrl = default,
            string? conversationalContext = default,
            string? customGreeting = default,
            string? language = default,
            bool? audioOnly = default,
            int? maxCallDuration = default,
            int? idleTimeout = default,
            int? participantLeftTimeout = default,
            bool? enableClosedCaptions = default,
            bool? isPrivate = default,
            int? maxParticipantCount = default,
            bool? applyGreenscreen = default,
            string? backgroundUrl = default,
            string? backgroundImageUrl = default,
            global::System.Collections.Generic.IList<string>? memoryStores = default,
            bool? enableRecording = default,
            string? recordingS3BucketRegion = default,
            string? recordingS3BucketName = default,
            global::Tavus.ConversationProperties? properties = default,
            global::System.Collections.Generic.IList<string>? documentIds = default,
            global::Tavus.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Tavus.CreateConversationRequest
            {
                PersonaId = personaId,
                ReplicaId = replicaId,
                CallbackUrl = callbackUrl,
                ConversationalContext = conversationalContext,
                CustomGreeting = customGreeting,
                Language = language,
                AudioOnly = audioOnly,
                MaxCallDuration = maxCallDuration,
                IdleTimeout = idleTimeout,
                ParticipantLeftTimeout = participantLeftTimeout,
                EnableClosedCaptions = enableClosedCaptions,
                IsPrivate = isPrivate,
                MaxParticipantCount = maxParticipantCount,
                ApplyGreenscreen = applyGreenscreen,
                BackgroundUrl = backgroundUrl,
                BackgroundImageUrl = backgroundImageUrl,
                MemoryStores = memoryStores,
                EnableRecording = enableRecording,
                RecordingS3BucketRegion = recordingS3BucketRegion,
                RecordingS3BucketName = recordingS3BucketName,
                Properties = properties,
                DocumentIds = documentIds,
            };

            return await CreateConversationAsync(
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}