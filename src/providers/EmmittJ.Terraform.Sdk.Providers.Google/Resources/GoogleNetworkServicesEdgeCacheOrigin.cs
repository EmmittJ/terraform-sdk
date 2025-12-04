using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for aws_v4_authentication in GoogleNetworkServicesEdgeCacheOrigin.
/// Nesting mode: list
/// </summary>
public class GoogleNetworkServicesEdgeCacheOriginAwsV4AuthenticationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "aws_v4_authentication";

    /// <summary>
    /// The access key ID your origin uses to identify the key.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccessKeyId is required")]
    public required TerraformValue<string> AccessKeyId
    {
        get => GetRequiredArgument<TerraformValue<string>>("access_key_id");
        set => SetArgument("access_key_id", value);
    }

    /// <summary>
    /// The name of the AWS region that your origin is in.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OriginRegion is required")]
    public required TerraformValue<string> OriginRegion
    {
        get => GetRequiredArgument<TerraformValue<string>>("origin_region");
        set => SetArgument("origin_region", value);
    }

    /// <summary>
    /// The Secret Manager secret version of the secret access key used by your origin.
    /// 
    /// This is the resource name of the secret version in the format &#39;projects/*/secrets/*/versions/*&#39; where the &#39;*&#39; values are replaced by the project, secret, and version you require.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecretAccessKeyVersion is required")]
    public required TerraformValue<string> SecretAccessKeyVersion
    {
        get => GetRequiredArgument<TerraformValue<string>>("secret_access_key_version");
        set => SetArgument("secret_access_key_version", value);
    }

}


/// <summary>
/// Block type for flex_shielding in GoogleNetworkServicesEdgeCacheOrigin.
/// Nesting mode: list
/// </summary>
public class GoogleNetworkServicesEdgeCacheOriginFlexShieldingBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "flex_shielding";

    /// <summary>
    /// Whenever possible, content will be fetched from origin and cached in or
    /// near the specified origin. Best effort.
    /// 
    /// You must specify exactly one FlexShieldingRegion. Possible values: [&amp;quot;AFRICA_SOUTH1&amp;quot;, &amp;quot;ME_CENTRAL1&amp;quot;]
    /// </summary>
    public TerraformList<string>? FlexShieldingRegions
    {
        get => GetArgument<TerraformList<string>>("flex_shielding_regions");
        set => SetArgument("flex_shielding_regions", value);
    }

}


/// <summary>
/// Block type for origin_override_action in GoogleNetworkServicesEdgeCacheOrigin.
/// Nesting mode: list
/// </summary>
public class GoogleNetworkServicesEdgeCacheOriginOriginOverrideActionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "origin_override_action";

    /// <summary>
    /// HeaderAction block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HeaderAction block(s) allowed")]
    public TerraformList<GoogleNetworkServicesEdgeCacheOriginOriginOverrideActionBlockHeaderActionBlock>? HeaderAction
    {
        get => GetArgument<TerraformList<GoogleNetworkServicesEdgeCacheOriginOriginOverrideActionBlockHeaderActionBlock>>("header_action");
        set => SetArgument("header_action", value);
    }

    /// <summary>
    /// UrlRewrite block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 UrlRewrite block(s) allowed")]
    public TerraformList<GoogleNetworkServicesEdgeCacheOriginOriginOverrideActionBlockUrlRewriteBlock>? UrlRewrite
    {
        get => GetArgument<TerraformList<GoogleNetworkServicesEdgeCacheOriginOriginOverrideActionBlockUrlRewriteBlock>>("url_rewrite");
        set => SetArgument("url_rewrite", value);
    }

}

/// <summary>
/// Block type for header_action in GoogleNetworkServicesEdgeCacheOriginOriginOverrideActionBlock.
/// Nesting mode: list
/// </summary>
public class GoogleNetworkServicesEdgeCacheOriginOriginOverrideActionBlockHeaderActionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "header_action";

    /// <summary>
    /// RequestHeadersToAdd block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(25, ErrorMessage = "Maximum 25 RequestHeadersToAdd block(s) allowed")]
    public TerraformList<GoogleNetworkServicesEdgeCacheOriginOriginOverrideActionBlockHeaderActionBlockRequestHeadersToAddBlock>? RequestHeadersToAdd
    {
        get => GetArgument<TerraformList<GoogleNetworkServicesEdgeCacheOriginOriginOverrideActionBlockHeaderActionBlockRequestHeadersToAddBlock>>("request_headers_to_add");
        set => SetArgument("request_headers_to_add", value);
    }

}

/// <summary>
/// Block type for request_headers_to_add in GoogleNetworkServicesEdgeCacheOriginOriginOverrideActionBlockHeaderActionBlock.
/// Nesting mode: list
/// </summary>
public class GoogleNetworkServicesEdgeCacheOriginOriginOverrideActionBlockHeaderActionBlockRequestHeadersToAddBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "request_headers_to_add";

    /// <summary>
    /// The name of the header to add.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HeaderName is required")]
    public required TerraformValue<string> HeaderName
    {
        get => GetRequiredArgument<TerraformValue<string>>("header_name");
        set => SetArgument("header_name", value);
    }

    /// <summary>
    /// The value of the header to add.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HeaderValue is required")]
    public required TerraformValue<string> HeaderValue
    {
        get => GetRequiredArgument<TerraformValue<string>>("header_value");
        set => SetArgument("header_value", value);
    }

    /// <summary>
    /// Whether to replace all existing headers with the same name.
    /// 
    /// By default, added header values are appended
    /// to the response or request headers with the
    /// same field names. The added values are
    /// separated by commas.
    /// 
    /// To overwrite existing values, set &#39;replace&#39; to &#39;true&#39;.
    /// </summary>
    public TerraformValue<bool>? Replace
    {
        get => GetArgument<TerraformValue<bool>>("replace");
        set => SetArgument("replace", value);
    }

}

/// <summary>
/// Block type for url_rewrite in GoogleNetworkServicesEdgeCacheOriginOriginOverrideActionBlock.
/// Nesting mode: list
/// </summary>
public class GoogleNetworkServicesEdgeCacheOriginOriginOverrideActionBlockUrlRewriteBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "url_rewrite";

    /// <summary>
    /// Prior to forwarding the request to the selected
    /// origin, the request&#39;s host header is replaced with
    /// contents of the hostRewrite.
    /// 
    /// This value must be between 1 and 255 characters.
    /// </summary>
    public TerraformValue<string>? HostRewrite
    {
        get => GetArgument<TerraformValue<string>>("host_rewrite");
        set => SetArgument("host_rewrite", value);
    }

}


/// <summary>
/// Block type for origin_redirect in GoogleNetworkServicesEdgeCacheOrigin.
/// Nesting mode: list
/// </summary>
public class GoogleNetworkServicesEdgeCacheOriginOriginRedirectBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "origin_redirect";

    /// <summary>
    /// The set of redirect response codes that the CDN
    /// follows. Values of
    /// [RedirectConditions](https://cloud.google.com/media-cdn/docs/reference/rest/v1/projects.locations.edgeCacheOrigins#redirectconditions)
    /// are accepted.
    /// </summary>
    public TerraformList<string>? RedirectConditions
    {
        get => GetArgument<TerraformList<string>>("redirect_conditions");
        set => SetArgument("redirect_conditions", value);
    }

}


/// <summary>
/// Block type for timeout in GoogleNetworkServicesEdgeCacheOrigin.
/// Nesting mode: list
/// </summary>
public class GoogleNetworkServicesEdgeCacheOriginTimeoutBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeout";

    /// <summary>
    /// The maximum duration to wait for a single origin connection to be established, including DNS lookup, TLS handshake and TCP/QUIC connection establishment.
    /// 
    /// Defaults to 5 seconds. The timeout must be a value between 1s and 15s.
    /// 
    /// The connectTimeout capped by the deadline set by the request&#39;s maxAttemptsTimeout.  The last connection attempt may have a smaller connectTimeout in order to adhere to the overall maxAttemptsTimeout.
    /// </summary>
    public TerraformValue<string>? ConnectTimeout
    {
        get => GetArgument<TerraformValue<string>>("connect_timeout");
        set => SetArgument("connect_timeout", value);
    }

    /// <summary>
    /// The maximum time across all connection attempts to the origin, including failover origins, before returning an error to the client. A HTTP 504 will be returned if the timeout is reached before a response is returned.
    /// 
    /// Defaults to 15 seconds. The timeout must be a value between 1s and 30s.
    /// 
    /// If a failoverOrigin is specified, the maxAttemptsTimeout of the first configured origin sets the deadline for all connection attempts across all failoverOrigins.
    /// </summary>
    public TerraformValue<string>? MaxAttemptsTimeout
    {
        get => GetArgument<TerraformValue<string>>("max_attempts_timeout");
        set => SetArgument("max_attempts_timeout", value);
    }

    /// <summary>
    /// The maximum duration to wait between reads of a single HTTP connection/stream.
    /// 
    /// Defaults to 15 seconds.  The timeout must be a value between 1s and 30s.
    /// 
    /// The readTimeout is capped by the responseTimeout.  All reads of the HTTP connection/stream must be completed by the deadline set by the responseTimeout.
    /// 
    /// If the response headers have already been written to the connection, the response will be truncated and logged.
    /// </summary>
    public TerraformValue<string>? ReadTimeout
    {
        get => GetArgument<TerraformValue<string>>("read_timeout");
        set => SetArgument("read_timeout", value);
    }

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
    public TerraformValue<string>? ResponseTimeout
    {
        get => GetArgument<TerraformValue<string>>("response_timeout");
        set => SetArgument("response_timeout", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleNetworkServicesEdgeCacheOrigin.
/// Nesting mode: single
/// </summary>
public class GoogleNetworkServicesEdgeCacheOriginTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_network_services_edge_cache_origin Terraform resource.
/// Manages a google_network_services_edge_cache_origin resource.
/// </summary>
public partial class GoogleNetworkServicesEdgeCacheOrigin(string name) : TerraformResource("google_network_services_edge_cache_origin", name)
{
    /// <summary>
    /// A human-readable description of the resource.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The Origin resource to try when the current origin cannot be reached.
    /// After maxAttempts is reached, the configured failoverOrigin will be used to fulfil the request.
    /// 
    /// The value of timeout.maxAttemptsTimeout dictates the timeout across all origins.
    /// A reference to a Topic resource.
    /// </summary>
    public TerraformValue<string>? FailoverOrigin
    {
        get => GetArgument<TerraformValue<string>>("failover_origin");
        set => SetArgument("failover_origin", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Set of label tags associated with the EdgeCache resource.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformMap<string>? Labels
    {
        get => GetArgument<TerraformMap<string>>("labels");
        set => SetArgument("labels", value);
    }

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
    public TerraformValue<double>? MaxAttempts
    {
        get => GetArgument<TerraformValue<double>>("max_attempts");
        set => SetArgument("max_attempts", value);
    }

    /// <summary>
    /// Name of the resource; provided by the client when the resource is created.
    /// The name must be 1-64 characters long, and match the regular expression [a-zA-Z][a-zA-Z0-9_-]* which means the first character must be a letter,
    /// and all following characters must be a dash, underscore, letter or digit.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// A fully qualified domain name (FQDN) or IP address reachable over the public Internet, or the address of a Google Cloud Storage bucket.
    /// 
    /// This address will be used as the origin for cache requests - e.g. FQDN: media-backend.example.com, IPv4: 35.218.1.1, IPv6: 2607:f8b0:4012:809::200e, Cloud Storage: gs://bucketname
    /// 
    /// When providing an FQDN (hostname), it must be publicly resolvable (e.g. via Google public DNS) and IP addresses must be publicly routable.  It must not contain a protocol (e.g., https://) and it must not contain any slashes.
    /// If a Cloud Storage bucket is provided, it must be in the canonical &amp;quot;gs://bucketname&amp;quot; format. Other forms, such as &amp;quot;storage.googleapis.com&amp;quot;, will be rejected.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OriginAddress is required")]
    public required TerraformValue<string> OriginAddress
    {
        get => GetRequiredArgument<TerraformValue<string>>("origin_address");
        set => SetArgument("origin_address", value);
    }

    /// <summary>
    /// The port to connect to the origin on.
    /// Defaults to port 443 for HTTP2 and HTTPS protocols, and port 80 for HTTP.
    /// </summary>
    public TerraformValue<double> Port
    {
        get => GetArgument<TerraformValue<double>>("port") ?? AsReference("port");
        set => SetArgument("port", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => GetArgument<TerraformValue<string>>("project") ?? AsReference("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The protocol to use to connect to the configured origin. Defaults to HTTP2, and it is strongly recommended that users use HTTP2 for both security &amp;amp; performance.
    /// 
    /// When using HTTP2 or HTTPS as the protocol, a valid, publicly-signed, unexpired TLS (SSL) certificate must be presented by the origin server. Possible values: [&amp;quot;HTTP2&amp;quot;, &amp;quot;HTTPS&amp;quot;, &amp;quot;HTTP&amp;quot;]
    /// </summary>
    public TerraformValue<string> Protocol
    {
        get => GetArgument<TerraformValue<string>>("protocol") ?? AsReference("protocol");
        set => SetArgument("protocol", value);
    }

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
    public TerraformList<string> RetryConditions
    {
        get => GetArgument<TerraformList<string>>("retry_conditions") ?? AsReference("retry_conditions");
        set => SetArgument("retry_conditions", value);
    }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
        => AsReference("effective_labels");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
        => AsReference("terraform_labels");

    /// <summary>
    /// AwsV4Authentication block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AwsV4Authentication block(s) allowed")]
    public TerraformList<GoogleNetworkServicesEdgeCacheOriginAwsV4AuthenticationBlock>? AwsV4Authentication
    {
        get => GetArgument<TerraformList<GoogleNetworkServicesEdgeCacheOriginAwsV4AuthenticationBlock>>("aws_v4_authentication");
        set => SetArgument("aws_v4_authentication", value);
    }

    /// <summary>
    /// FlexShielding block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FlexShielding block(s) allowed")]
    public TerraformList<GoogleNetworkServicesEdgeCacheOriginFlexShieldingBlock>? FlexShielding
    {
        get => GetArgument<TerraformList<GoogleNetworkServicesEdgeCacheOriginFlexShieldingBlock>>("flex_shielding");
        set => SetArgument("flex_shielding", value);
    }

    /// <summary>
    /// OriginOverrideAction block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OriginOverrideAction block(s) allowed")]
    public TerraformList<GoogleNetworkServicesEdgeCacheOriginOriginOverrideActionBlock>? OriginOverrideAction
    {
        get => GetArgument<TerraformList<GoogleNetworkServicesEdgeCacheOriginOriginOverrideActionBlock>>("origin_override_action");
        set => SetArgument("origin_override_action", value);
    }

    /// <summary>
    /// OriginRedirect block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OriginRedirect block(s) allowed")]
    public TerraformList<GoogleNetworkServicesEdgeCacheOriginOriginRedirectBlock>? OriginRedirect
    {
        get => GetArgument<TerraformList<GoogleNetworkServicesEdgeCacheOriginOriginRedirectBlock>>("origin_redirect");
        set => SetArgument("origin_redirect", value);
    }

    /// <summary>
    /// Timeout block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Timeout block(s) allowed")]
    public TerraformList<GoogleNetworkServicesEdgeCacheOriginTimeoutBlock>? Timeout
    {
        get => GetArgument<TerraformList<GoogleNetworkServicesEdgeCacheOriginTimeoutBlock>>("timeout");
        set => SetArgument("timeout", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleNetworkServicesEdgeCacheOriginTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleNetworkServicesEdgeCacheOriginTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
