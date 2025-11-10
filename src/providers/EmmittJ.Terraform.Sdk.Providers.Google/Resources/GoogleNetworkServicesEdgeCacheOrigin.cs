using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for aws_v4_authentication in .
/// Nesting mode: list
/// </summary>
public class GoogleNetworkServicesEdgeCacheOriginAwsV4AuthenticationBlock : TerraformBlock
{
    /// <summary>
    /// The access key ID your origin uses to identify the key.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccessKeyId is required")]
    public required TerraformProperty<string> AccessKeyId
    {
        set => SetProperty("access_key_id", value);
    }

    /// <summary>
    /// The name of the AWS region that your origin is in.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OriginRegion is required")]
    public required TerraformProperty<string> OriginRegion
    {
        set => SetProperty("origin_region", value);
    }

    /// <summary>
    /// The Secret Manager secret version of the secret access key used by your origin.
    /// 
    /// This is the resource name of the secret version in the format &#39;projects/*/secrets/*/versions/*&#39; where the &#39;*&#39; values are replaced by the project, secret, and version you require.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecretAccessKeyVersion is required")]
    public required TerraformProperty<string> SecretAccessKeyVersion
    {
        set => SetProperty("secret_access_key_version", value);
    }

}

/// <summary>
/// Block type for flex_shielding in .
/// Nesting mode: list
/// </summary>
public class GoogleNetworkServicesEdgeCacheOriginFlexShieldingBlock : TerraformBlock
{
    /// <summary>
    /// Whenever possible, content will be fetched from origin and cached in or
    /// near the specified origin. Best effort.
    /// 
    /// You must specify exactly one FlexShieldingRegion. Possible values: [&amp;quot;AFRICA_SOUTH1&amp;quot;, &amp;quot;ME_CENTRAL1&amp;quot;]
    /// </summary>
    public List<TerraformProperty<string>>? FlexShieldingRegions
    {
        set => SetProperty("flex_shielding_regions", value);
    }

}

/// <summary>
/// Block type for origin_override_action in .
/// Nesting mode: list
/// </summary>
public class GoogleNetworkServicesEdgeCacheOriginOriginOverrideActionBlock : TerraformBlock
{
}

/// <summary>
/// Block type for origin_redirect in .
/// Nesting mode: list
/// </summary>
public class GoogleNetworkServicesEdgeCacheOriginOriginRedirectBlock : TerraformBlock
{
    /// <summary>
    /// The set of redirect response codes that the CDN
    /// follows. Values of
    /// [RedirectConditions](https://cloud.google.com/media-cdn/docs/reference/rest/v1/projects.locations.edgeCacheOrigins#redirectconditions)
    /// are accepted.
    /// </summary>
    public List<TerraformProperty<string>>? RedirectConditions
    {
        set => SetProperty("redirect_conditions", value);
    }

}

/// <summary>
/// Block type for timeout in .
/// Nesting mode: list
/// </summary>
public class GoogleNetworkServicesEdgeCacheOriginTimeoutBlock : TerraformBlock
{
    /// <summary>
    /// The maximum duration to wait for a single origin connection to be established, including DNS lookup, TLS handshake and TCP/QUIC connection establishment.
    /// 
    /// Defaults to 5 seconds. The timeout must be a value between 1s and 15s.
    /// 
    /// The connectTimeout capped by the deadline set by the request&#39;s maxAttemptsTimeout.  The last connection attempt may have a smaller connectTimeout in order to adhere to the overall maxAttemptsTimeout.
    /// </summary>
    public TerraformProperty<string>? ConnectTimeout
    {
        set => SetProperty("connect_timeout", value);
    }

    /// <summary>
    /// The maximum time across all connection attempts to the origin, including failover origins, before returning an error to the client. A HTTP 504 will be returned if the timeout is reached before a response is returned.
    /// 
    /// Defaults to 15 seconds. The timeout must be a value between 1s and 30s.
    /// 
    /// If a failoverOrigin is specified, the maxAttemptsTimeout of the first configured origin sets the deadline for all connection attempts across all failoverOrigins.
    /// </summary>
    public TerraformProperty<string>? MaxAttemptsTimeout
    {
        set => SetProperty("max_attempts_timeout", value);
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
    public TerraformProperty<string>? ReadTimeout
    {
        set => SetProperty("read_timeout", value);
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
    public TerraformProperty<string>? ResponseTimeout
    {
        set => SetProperty("response_timeout", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleNetworkServicesEdgeCacheOriginTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a google_network_services_edge_cache_origin resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleNetworkServicesEdgeCacheOrigin : TerraformResource
{
    public GoogleNetworkServicesEdgeCacheOrigin(string name) : base("google_network_services_edge_cache_origin", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("effective_labels");
        SetOutput("terraform_labels");
        SetOutput("description");
        SetOutput("failover_origin");
        SetOutput("id");
        SetOutput("labels");
        SetOutput("max_attempts");
        SetOutput("name");
        SetOutput("origin_address");
        SetOutput("port");
        SetOutput("project");
        SetOutput("protocol");
        SetOutput("retry_conditions");
    }

    /// <summary>
    /// A human-readable description of the resource.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// The Origin resource to try when the current origin cannot be reached.
    /// After maxAttempts is reached, the configured failoverOrigin will be used to fulfil the request.
    /// 
    /// The value of timeout.maxAttemptsTimeout dictates the timeout across all origins.
    /// A reference to a Topic resource.
    /// </summary>
    public TerraformProperty<string> FailoverOrigin
    {
        get => GetRequiredOutput<TerraformProperty<string>>("failover_origin");
        set => SetProperty("failover_origin", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// Set of label tags associated with the EdgeCache resource.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Labels
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("labels");
        set => SetProperty("labels", value);
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
    public TerraformProperty<double> MaxAttempts
    {
        get => GetRequiredOutput<TerraformProperty<double>>("max_attempts");
        set => SetProperty("max_attempts", value);
    }

    /// <summary>
    /// Name of the resource; provided by the client when the resource is created.
    /// The name must be 1-64 characters long, and match the regular expression [a-zA-Z][a-zA-Z0-9_-]* which means the first character must be a letter,
    /// and all following characters must be a dash, underscore, letter or digit.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
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
    public required TerraformProperty<string> OriginAddress
    {
        get => GetRequiredOutput<TerraformProperty<string>>("origin_address");
        set => SetProperty("origin_address", value);
    }

    /// <summary>
    /// The port to connect to the origin on.
    /// Defaults to port 443 for HTTP2 and HTTPS protocols, and port 80 for HTTP.
    /// </summary>
    public TerraformProperty<double> Port
    {
        get => GetRequiredOutput<TerraformProperty<double>>("port");
        set => SetProperty("port", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
    }

    /// <summary>
    /// The protocol to use to connect to the configured origin. Defaults to HTTP2, and it is strongly recommended that users use HTTP2 for both security &amp;amp; performance.
    /// 
    /// When using HTTP2 or HTTPS as the protocol, a valid, publicly-signed, unexpired TLS (SSL) certificate must be presented by the origin server. Possible values: [&amp;quot;HTTP2&amp;quot;, &amp;quot;HTTPS&amp;quot;, &amp;quot;HTTP&amp;quot;]
    /// </summary>
    public TerraformProperty<string> Protocol
    {
        get => GetRequiredOutput<TerraformProperty<string>>("protocol");
        set => SetProperty("protocol", value);
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
    public List<TerraformProperty<string>> RetryConditions
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("retry_conditions");
        set => SetProperty("retry_conditions", value);
    }

    /// <summary>
    /// Block for aws_v4_authentication.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AwsV4Authentication block(s) allowed")]
    public List<GoogleNetworkServicesEdgeCacheOriginAwsV4AuthenticationBlock>? AwsV4Authentication
    {
        set => SetProperty("aws_v4_authentication", value);
    }

    /// <summary>
    /// Block for flex_shielding.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FlexShielding block(s) allowed")]
    public List<GoogleNetworkServicesEdgeCacheOriginFlexShieldingBlock>? FlexShielding
    {
        set => SetProperty("flex_shielding", value);
    }

    /// <summary>
    /// Block for origin_override_action.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OriginOverrideAction block(s) allowed")]
    public List<GoogleNetworkServicesEdgeCacheOriginOriginOverrideActionBlock>? OriginOverrideAction
    {
        set => SetProperty("origin_override_action", value);
    }

    /// <summary>
    /// Block for origin_redirect.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OriginRedirect block(s) allowed")]
    public List<GoogleNetworkServicesEdgeCacheOriginOriginRedirectBlock>? OriginRedirect
    {
        set => SetProperty("origin_redirect", value);
    }

    /// <summary>
    /// Block for timeout.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Timeout block(s) allowed")]
    public List<GoogleNetworkServicesEdgeCacheOriginTimeoutBlock>? Timeout
    {
        set => SetProperty("timeout", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleNetworkServicesEdgeCacheOriginTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

}
