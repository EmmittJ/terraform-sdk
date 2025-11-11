using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for aws_v4_authentication in .
/// Nesting mode: list
/// </summary>
public partial class GoogleNetworkServicesEdgeCacheOriginAwsV4AuthenticationBlock : TerraformBlockBase
{
    /// <summary>
    /// The access key ID your origin uses to identify the key.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccessKeyId is required")]
    [TerraformProperty("access_key_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> AccessKeyId { get; set; }

    /// <summary>
    /// The name of the AWS region that your origin is in.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OriginRegion is required")]
    [TerraformProperty("origin_region")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> OriginRegion { get; set; }

    /// <summary>
    /// The Secret Manager secret version of the secret access key used by your origin.
    /// 
    /// This is the resource name of the secret version in the format &#39;projects/*/secrets/*/versions/*&#39; where the &#39;*&#39; values are replaced by the project, secret, and version you require.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecretAccessKeyVersion is required")]
    [TerraformProperty("secret_access_key_version")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> SecretAccessKeyVersion { get; set; }

}

/// <summary>
/// Block type for flex_shielding in .
/// Nesting mode: list
/// </summary>
public partial class GoogleNetworkServicesEdgeCacheOriginFlexShieldingBlock : TerraformBlockBase
{
    /// <summary>
    /// Whenever possible, content will be fetched from origin and cached in or
    /// near the specified origin. Best effort.
    /// 
    /// You must specify exactly one FlexShieldingRegion. Possible values: [&amp;quot;AFRICA_SOUTH1&amp;quot;, &amp;quot;ME_CENTRAL1&amp;quot;]
    /// </summary>
    [TerraformProperty("flex_shielding_regions")]
    // Optional argument - source generator will implement get/set
    public TerraformList<string>? FlexShieldingRegions { get; set; }

}

/// <summary>
/// Block type for origin_override_action in .
/// Nesting mode: list
/// </summary>
public partial class GoogleNetworkServicesEdgeCacheOriginOriginOverrideActionBlock : TerraformBlockBase
{
}

/// <summary>
/// Block type for origin_redirect in .
/// Nesting mode: list
/// </summary>
public partial class GoogleNetworkServicesEdgeCacheOriginOriginRedirectBlock : TerraformBlockBase
{
    /// <summary>
    /// The set of redirect response codes that the CDN
    /// follows. Values of
    /// [RedirectConditions](https://cloud.google.com/media-cdn/docs/reference/rest/v1/projects.locations.edgeCacheOrigins#redirectconditions)
    /// are accepted.
    /// </summary>
    [TerraformProperty("redirect_conditions")]
    // Optional argument - source generator will implement get/set
    public TerraformList<string>? RedirectConditions { get; set; }

}

/// <summary>
/// Block type for timeout in .
/// Nesting mode: list
/// </summary>
public partial class GoogleNetworkServicesEdgeCacheOriginTimeoutBlock : TerraformBlockBase
{
    /// <summary>
    /// The maximum duration to wait for a single origin connection to be established, including DNS lookup, TLS handshake and TCP/QUIC connection establishment.
    /// 
    /// Defaults to 5 seconds. The timeout must be a value between 1s and 15s.
    /// 
    /// The connectTimeout capped by the deadline set by the request&#39;s maxAttemptsTimeout.  The last connection attempt may have a smaller connectTimeout in order to adhere to the overall maxAttemptsTimeout.
    /// </summary>
    [TerraformProperty("connect_timeout")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ConnectTimeout { get; set; }

    /// <summary>
    /// The maximum time across all connection attempts to the origin, including failover origins, before returning an error to the client. A HTTP 504 will be returned if the timeout is reached before a response is returned.
    /// 
    /// Defaults to 15 seconds. The timeout must be a value between 1s and 30s.
    /// 
    /// If a failoverOrigin is specified, the maxAttemptsTimeout of the first configured origin sets the deadline for all connection attempts across all failoverOrigins.
    /// </summary>
    [TerraformProperty("max_attempts_timeout")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? MaxAttemptsTimeout { get; set; }

    /// <summary>
    /// The maximum duration to wait between reads of a single HTTP connection/stream.
    /// 
    /// Defaults to 15 seconds.  The timeout must be a value between 1s and 30s.
    /// 
    /// The readTimeout is capped by the responseTimeout.  All reads of the HTTP connection/stream must be completed by the deadline set by the responseTimeout.
    /// 
    /// If the response headers have already been written to the connection, the response will be truncated and logged.
    /// </summary>
    [TerraformProperty("read_timeout")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ReadTimeout { get; set; }

    /// <summary>
    /// The maximum duration to wait for the last byte of a response to arrive when reading from the HTTP connection/stream.
    /// 
    /// Defaults to 30 seconds. The timeout must be a value between 1s and 120s.
    /// 
    /// The responseTimeout starts after the connection has been established.
    /// 
    /// This also applies to HTTP Chunked Transfer Encoding responses, and/or when an open-ended Range request is made to the origin. Origins that take longer to write additional bytes to the response than the configured responseTimeout will result in an error being returned to the client.
    /// 
    /// If the response headers have already been written to the connection, the response will be truncated and logged.
    /// </summary>
    [TerraformProperty("response_timeout")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ResponseTimeout { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleNetworkServicesEdgeCacheOriginTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_network_services_edge_cache_origin resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleNetworkServicesEdgeCacheOrigin : TerraformResource
{
    public GoogleNetworkServicesEdgeCacheOrigin(string name) : base("google_network_services_edge_cache_origin", name)
    {
    }

    /// <summary>
    /// A human-readable description of the resource.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The Origin resource to try when the current origin cannot be reached.
    /// After maxAttempts is reached, the configured failoverOrigin will be used to fulfil the request.
    /// 
    /// The value of timeout.maxAttemptsTimeout dictates the timeout across all origins.
    /// A reference to a Topic resource.
    /// </summary>
    [TerraformProperty("failover_origin")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? FailoverOrigin { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Set of label tags associated with the EdgeCache resource.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformProperty("labels")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Labels { get; set; }

    /// <summary>
    /// The maximum number of attempts to cache fill from this origin. Another attempt is made when a cache fill fails with one of the retryConditions.
    /// 
    /// Once maxAttempts to this origin have failed the failoverOrigin will be used, if one is specified. That failoverOrigin may specify its own maxAttempts,
    /// retryConditions and failoverOrigin to control its own cache fill failures.
    /// 
    /// The total number of allowed attempts to cache fill across this and failover origins is limited to four.
    /// The total time allowed for cache fill attempts across this and failover origins can be controlled with maxAttemptsTimeout.
    /// 
    /// The last valid, non-retried response from all origins will be returned to the client.
    /// If no origin returns a valid response, an HTTP 502 will be returned to the client.
    /// 
    /// Defaults to 1. Must be a value greater than 0 and less than 4.
    /// </summary>
    [TerraformProperty("max_attempts")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? MaxAttempts { get; set; }

    /// <summary>
    /// Name of the resource; provided by the client when the resource is created.
    /// The name must be 1-64 characters long, and match the regular expression [a-zA-Z][a-zA-Z0-9_-]* which means the first character must be a letter,
    /// and all following characters must be a dash, underscore, letter or digit.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// A fully qualified domain name (FQDN) or IP address reachable over the public Internet, or the address of a Google Cloud Storage bucket.
    /// 
    /// This address will be used as the origin for cache requests - e.g. FQDN: media-backend.example.com, IPv4: 35.218.1.1, IPv6: 2607:f8b0:4012:809::200e, Cloud Storage: gs://bucketname
    /// 
    /// When providing an FQDN (hostname), it must be publicly resolvable (e.g. via Google public DNS) and IP addresses must be publicly routable.  It must not contain a protocol (e.g., https://) and it must not contain any slashes.
    /// If a Cloud Storage bucket is provided, it must be in the canonical &amp;quot;gs://bucketname&amp;quot; format. Other forms, such as &amp;quot;storage.googleapis.com&amp;quot;, will be rejected.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OriginAddress is required")]
    [TerraformProperty("origin_address")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> OriginAddress { get; set; }

    /// <summary>
    /// The port to connect to the origin on.
    /// Defaults to port 443 for HTTP2 and HTTPS protocols, and port 80 for HTTP.
    /// </summary>
    [TerraformProperty("port")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<double> Port { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Project { get; set; }

    /// <summary>
    /// The protocol to use to connect to the configured origin. Defaults to HTTP2, and it is strongly recommended that users use HTTP2 for both security &amp;amp; performance.
    /// 
    /// When using HTTP2 or HTTPS as the protocol, a valid, publicly-signed, unexpired TLS (SSL) certificate must be presented by the origin server. Possible values: [&amp;quot;HTTP2&amp;quot;, &amp;quot;HTTPS&amp;quot;, &amp;quot;HTTP&amp;quot;]
    /// </summary>
    [TerraformProperty("protocol")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Protocol { get; set; }

    /// <summary>
    /// Specifies one or more retry conditions for the configured origin.
    /// 
    /// If the failure mode during a connection attempt to the origin matches the configured retryCondition(s),
    /// the origin request will be retried up to maxAttempts times. The failoverOrigin, if configured, will then be used to satisfy the request.
    /// 
    /// The default retryCondition is &amp;quot;CONNECT_FAILURE&amp;quot;.
    /// 
    /// retryConditions apply to this origin, and not subsequent failoverOrigin(s),
    /// which may specify their own retryConditions and maxAttempts.
    /// 
    /// Valid values are:
    /// 
    /// - CONNECT_FAILURE: Retry on failures connecting to origins, for example due to connection timeouts.
    /// - HTTP_5XX: Retry if the origin responds with any 5xx response code, or if the origin does not respond at all, example: disconnects, reset, read timeout, connection failure, and refused streams.
    /// - GATEWAY_ERROR: Similar to 5xx, but only applies to response codes 502, 503 or 504.
    /// - RETRIABLE_4XX: Retry for retriable 4xx response codes, which include HTTP 409 (Conflict) and HTTP 429 (Too Many Requests)
    /// - NOT_FOUND: Retry if the origin returns a HTTP 404 (Not Found). This can be useful when generating video content, and the segment is not available yet.
    /// - FORBIDDEN: Retry if the origin returns a HTTP 403 (Forbidden). Possible values: [&amp;quot;CONNECT_FAILURE&amp;quot;, &amp;quot;HTTP_5XX&amp;quot;, &amp;quot;GATEWAY_ERROR&amp;quot;, &amp;quot;RETRIABLE_4XX&amp;quot;, &amp;quot;NOT_FOUND&amp;quot;, &amp;quot;FORBIDDEN&amp;quot;]
    /// </summary>
    [TerraformProperty("retry_conditions")]
    // Optional+Computed - source generator will implement get/set
    public TerraformList<string> RetryConditions { get; set; }

    /// <summary>
    /// Block for aws_v4_authentication.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AwsV4Authentication block(s) allowed")]
    [TerraformProperty("aws_v4_authentication")]
    public TerraformList<TerraformBlock<GoogleNetworkServicesEdgeCacheOriginAwsV4AuthenticationBlock>>? AwsV4Authentication { get; set; }

    /// <summary>
    /// Block for flex_shielding.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FlexShielding block(s) allowed")]
    [TerraformProperty("flex_shielding")]
    public TerraformList<TerraformBlock<GoogleNetworkServicesEdgeCacheOriginFlexShieldingBlock>>? FlexShielding { get; set; }

    /// <summary>
    /// Block for origin_override_action.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OriginOverrideAction block(s) allowed")]
    [TerraformProperty("origin_override_action")]
    public TerraformList<TerraformBlock<GoogleNetworkServicesEdgeCacheOriginOriginOverrideActionBlock>>? OriginOverrideAction { get; set; }

    /// <summary>
    /// Block for origin_redirect.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OriginRedirect block(s) allowed")]
    [TerraformProperty("origin_redirect")]
    public TerraformList<TerraformBlock<GoogleNetworkServicesEdgeCacheOriginOriginRedirectBlock>>? OriginRedirect { get; set; }

    /// <summary>
    /// Block for timeout.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Timeout block(s) allowed")]
    [TerraformProperty("timeout")]
    public TerraformList<TerraformBlock<GoogleNetworkServicesEdgeCacheOriginTimeoutBlock>>? Timeout { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<GoogleNetworkServicesEdgeCacheOriginTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformProperty("effective_labels")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> EffectiveLabels { get; }

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformProperty("terraform_labels")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> TerraformLabels { get; }

}
