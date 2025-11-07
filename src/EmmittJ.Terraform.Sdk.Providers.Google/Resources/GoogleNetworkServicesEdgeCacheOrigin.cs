using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_network_services_edge_cache_origin resource.
/// </summary>
public class GoogleNetworkServicesEdgeCacheOrigin : TerraformResource
{
    public GoogleNetworkServicesEdgeCacheOrigin(string name) : base("google_network_services_edge_cache_origin", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("effective_labels");
        this.DeclareOutput("terraform_labels");
    }

    /// <summary>
    /// A human-readable description of the resource.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The Origin resource to try when the current origin cannot be reached.
    /// After maxAttempts is reached, the configured failoverOrigin will be used to fulfil the request.
    /// 
    /// The value of timeout.maxAttemptsTimeout dictates the timeout across all origins.
    /// A reference to a Topic resource.
    /// </summary>
    public TerraformProperty<string>? FailoverOrigin
    {
        get => GetProperty<TerraformProperty<string>>("failover_origin");
        set => this.WithProperty("failover_origin", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// Set of label tags associated with the EdgeCache resource.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? Labels
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("labels");
        set => this.WithProperty("labels", value);
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
    public TerraformProperty<double>? MaxAttempts
    {
        get => GetProperty<TerraformProperty<double>>("max_attempts");
        set => this.WithProperty("max_attempts", value);
    }

    /// <summary>
    /// Name of the resource; provided by the client when the resource is created.
    /// The name must be 1-64 characters long, and match the regular expression [a-zA-Z][a-zA-Z0-9_-]* which means the first character must be a letter,
    /// and all following characters must be a dash, underscore, letter or digit.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// A fully qualified domain name (FQDN) or IP address reachable over the public Internet, or the address of a Google Cloud Storage bucket.
    /// 
    /// This address will be used as the origin for cache requests - e.g. FQDN: media-backend.example.com, IPv4: 35.218.1.1, IPv6: 2607:f8b0:4012:809::200e, Cloud Storage: gs://bucketname
    /// 
    /// When providing an FQDN (hostname), it must be publicly resolvable (e.g. via Google public DNS) and IP addresses must be publicly routable.  It must not contain a protocol (e.g., https://) and it must not contain any slashes.
    /// If a Cloud Storage bucket is provided, it must be in the canonical &amp;quot;gs://bucketname&amp;quot; format. Other forms, such as &amp;quot;storage.googleapis.com&amp;quot;, will be rejected.
    /// </summary>
    public TerraformProperty<string>? OriginAddress
    {
        get => GetProperty<TerraformProperty<string>>("origin_address");
        set => this.WithProperty("origin_address", value);
    }

    /// <summary>
    /// The port to connect to the origin on.
    /// Defaults to port 443 for HTTP2 and HTTPS protocols, and port 80 for HTTP.
    /// </summary>
    public TerraformProperty<double>? Port
    {
        get => GetProperty<TerraformProperty<double>>("port");
        set => this.WithProperty("port", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// The protocol to use to connect to the configured origin. Defaults to HTTP2, and it is strongly recommended that users use HTTP2 for both security &amp;amp; performance.
    /// 
    /// When using HTTP2 or HTTPS as the protocol, a valid, publicly-signed, unexpired TLS (SSL) certificate must be presented by the origin server. Possible values: [&amp;quot;HTTP2&amp;quot;, &amp;quot;HTTPS&amp;quot;, &amp;quot;HTTP&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? Protocol
    {
        get => GetProperty<TerraformProperty<string>>("protocol");
        set => this.WithProperty("protocol", value);
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
    public TerraformProperty<List<string>>? RetryConditions
    {
        get => GetProperty<TerraformProperty<List<string>>>("retry_conditions");
        set => this.WithProperty("retry_conditions", value);
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
