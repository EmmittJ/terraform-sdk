using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for log_config in .
/// Nesting mode: list
/// </summary>
public class GoogleNetworkServicesEdgeCacheServiceLogConfigBlock : TerraformBlock
{
    /// <summary>
    /// Specifies whether to enable logging for traffic served by this service.
    /// </summary>
    public TerraformProperty<bool>? Enable
    {
        get => GetProperty<TerraformProperty<bool>>("enable");
        set => WithProperty("enable", value);
    }

    /// <summary>
    /// Configures the sampling rate of requests, where 1.0 means all logged requests are reported and 0.0 means no logged requests are reported. The default value is 1.0, and the value of the field must be in [0, 1].
    /// 
    /// This field can only be specified if logging is enabled for this service.
    /// </summary>
    public TerraformProperty<double>? SampleRate
    {
        get => GetProperty<TerraformProperty<double>>("sample_rate");
        set => WithProperty("sample_rate", value);
    }

}

/// <summary>
/// Block type for routing in .
/// Nesting mode: list
/// </summary>
public class GoogleNetworkServicesEdgeCacheServiceRoutingBlock : TerraformBlock
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleNetworkServicesEdgeCacheServiceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a google_network_services_edge_cache_service resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleNetworkServicesEdgeCacheService : TerraformResource
{
    public GoogleNetworkServicesEdgeCacheService(string name) : base("google_network_services_edge_cache_service", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("effective_labels");
        this.DeclareOutput("ipv4_addresses");
        this.DeclareOutput("ipv6_addresses");
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
    /// Disables HTTP/2.
    /// 
    /// HTTP/2 (h2) is enabled by default and recommended for performance. HTTP/2 improves connection re-use and reduces connection setup overhead by sending multiple streams over the same connection.
    /// 
    /// Some legacy HTTP clients may have issues with HTTP/2 connections due to broken HTTP/2 implementations. Setting this to true will prevent HTTP/2 from being advertised and negotiated.
    /// </summary>
    public TerraformProperty<bool>? DisableHttp2
    {
        get => GetProperty<TerraformProperty<bool>>("disable_http2");
        set => this.WithProperty("disable_http2", value);
    }

    /// <summary>
    /// HTTP/3 (IETF QUIC) and Google QUIC are enabled by default.
    /// </summary>
    public TerraformProperty<bool>? DisableQuic
    {
        get => GetProperty<TerraformProperty<bool>>("disable_quic");
        set => this.WithProperty("disable_quic", value);
    }

    /// <summary>
    /// Resource URL that points at the Cloud Armor edge security policy that is applied on each request against the EdgeCacheService.
    /// </summary>
    public TerraformProperty<string>? EdgeSecurityPolicy
    {
        get => GetProperty<TerraformProperty<string>>("edge_security_policy");
        set => this.WithProperty("edge_security_policy", value);
    }

    /// <summary>
    /// URLs to sslCertificate resources that are used to authenticate connections between users and the EdgeCacheService.
    /// 
    /// Note that only &amp;quot;global&amp;quot; certificates with a &amp;quot;scope&amp;quot; of &amp;quot;EDGE_CACHE&amp;quot; can be attached to an EdgeCacheService.
    /// </summary>
    public List<TerraformProperty<string>>? EdgeSslCertificates
    {
        get => GetProperty<List<TerraformProperty<string>>>("edge_ssl_certificates");
        set => this.WithProperty("edge_ssl_certificates", value);
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
    public Dictionary<string, TerraformProperty<string>>? Labels
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("labels");
        set => this.WithProperty("labels", value);
    }

    /// <summary>
    /// Name of the resource; provided by the client when the resource is created.
    /// The name must be 1-64 characters long, and match the regular expression [a-zA-Z][a-zA-Z0-9_-]* which means the first character must be a letter,
    /// and all following characters must be a dash, underscore, letter or digit.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
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
    /// Require TLS (HTTPS) for all clients connecting to this service.
    /// 
    /// Clients who connect over HTTP (port 80) will receive a HTTP 301 to the same URL over HTTPS (port 443).
    /// You must have at least one (1) edgeSslCertificate specified to enable this.
    /// </summary>
    public TerraformProperty<bool>? RequireTls
    {
        get => GetProperty<TerraformProperty<bool>>("require_tls");
        set => this.WithProperty("require_tls", value);
    }

    /// <summary>
    /// URL of the SslPolicy resource that will be associated with the EdgeCacheService.
    /// 
    /// If not set, the EdgeCacheService has no SSL policy configured, and will default to the &amp;quot;COMPATIBLE&amp;quot; policy.
    /// </summary>
    public TerraformProperty<string>? SslPolicy
    {
        get => GetProperty<TerraformProperty<string>>("ssl_policy");
        set => this.WithProperty("ssl_policy", value);
    }

    /// <summary>
    /// Block for log_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LogConfig block(s) allowed")]
    public List<GoogleNetworkServicesEdgeCacheServiceLogConfigBlock>? LogConfig
    {
        get => GetProperty<List<GoogleNetworkServicesEdgeCacheServiceLogConfigBlock>>("log_config");
        set => this.WithProperty("log_config", value);
    }

    /// <summary>
    /// Block for routing.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Routing block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Routing block(s) allowed")]
    public List<GoogleNetworkServicesEdgeCacheServiceRoutingBlock>? Routing
    {
        get => GetProperty<List<GoogleNetworkServicesEdgeCacheServiceRoutingBlock>>("routing");
        set => this.WithProperty("routing", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleNetworkServicesEdgeCacheServiceTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleNetworkServicesEdgeCacheServiceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// The IPv4 addresses associated with this service. Addresses are static for the lifetime of the service.
    /// </summary>
    public TerraformExpression Ipv4Addresses => this["ipv4_addresses"];

    /// <summary>
    /// The IPv6 addresses associated with this service. Addresses are static for the lifetime of the service.
    /// </summary>
    public TerraformExpression Ipv6Addresses => this["ipv6_addresses"];

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

}
