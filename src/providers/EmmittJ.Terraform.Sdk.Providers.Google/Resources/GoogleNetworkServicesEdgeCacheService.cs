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
        set => SetProperty("enable", value);
    }

    /// <summary>
    /// Configures the sampling rate of requests, where 1.0 means all logged requests are reported and 0.0 means no logged requests are reported. The default value is 1.0, and the value of the field must be in [0, 1].
    /// 
    /// This field can only be specified if logging is enabled for this service.
    /// </summary>
    public TerraformProperty<double>? SampleRate
    {
        set => SetProperty("sample_rate", value);
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
        SetOutput("effective_labels");
        SetOutput("ipv4_addresses");
        SetOutput("ipv6_addresses");
        SetOutput("terraform_labels");
        SetOutput("description");
        SetOutput("disable_http2");
        SetOutput("disable_quic");
        SetOutput("edge_security_policy");
        SetOutput("edge_ssl_certificates");
        SetOutput("id");
        SetOutput("labels");
        SetOutput("name");
        SetOutput("project");
        SetOutput("require_tls");
        SetOutput("ssl_policy");
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
    /// Disables HTTP/2.
    /// 
    /// HTTP/2 (h2) is enabled by default and recommended for performance. HTTP/2 improves connection re-use and reduces connection setup overhead by sending multiple streams over the same connection.
    /// 
    /// Some legacy HTTP clients may have issues with HTTP/2 connections due to broken HTTP/2 implementations. Setting this to true will prevent HTTP/2 from being advertised and negotiated.
    /// </summary>
    public TerraformProperty<bool> DisableHttp2
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("disable_http2");
        set => SetProperty("disable_http2", value);
    }

    /// <summary>
    /// HTTP/3 (IETF QUIC) and Google QUIC are enabled by default.
    /// </summary>
    public TerraformProperty<bool> DisableQuic
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("disable_quic");
        set => SetProperty("disable_quic", value);
    }

    /// <summary>
    /// Resource URL that points at the Cloud Armor edge security policy that is applied on each request against the EdgeCacheService.
    /// </summary>
    public TerraformProperty<string> EdgeSecurityPolicy
    {
        get => GetRequiredOutput<TerraformProperty<string>>("edge_security_policy");
        set => SetProperty("edge_security_policy", value);
    }

    /// <summary>
    /// URLs to sslCertificate resources that are used to authenticate connections between users and the EdgeCacheService.
    /// 
    /// Note that only &amp;quot;global&amp;quot; certificates with a &amp;quot;scope&amp;quot; of &amp;quot;EDGE_CACHE&amp;quot; can be attached to an EdgeCacheService.
    /// </summary>
    public List<TerraformProperty<string>> EdgeSslCertificates
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("edge_ssl_certificates");
        set => SetProperty("edge_ssl_certificates", value);
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
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
    }

    /// <summary>
    /// Require TLS (HTTPS) for all clients connecting to this service.
    /// 
    /// Clients who connect over HTTP (port 80) will receive a HTTP 301 to the same URL over HTTPS (port 443).
    /// You must have at least one (1) edgeSslCertificate specified to enable this.
    /// </summary>
    public TerraformProperty<bool> RequireTls
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("require_tls");
        set => SetProperty("require_tls", value);
    }

    /// <summary>
    /// URL of the SslPolicy resource that will be associated with the EdgeCacheService.
    /// 
    /// If not set, the EdgeCacheService has no SSL policy configured, and will default to the &amp;quot;COMPATIBLE&amp;quot; policy.
    /// </summary>
    public TerraformProperty<string> SslPolicy
    {
        get => GetRequiredOutput<TerraformProperty<string>>("ssl_policy");
        set => SetProperty("ssl_policy", value);
    }

    /// <summary>
    /// Block for log_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LogConfig block(s) allowed")]
    public List<GoogleNetworkServicesEdgeCacheServiceLogConfigBlock>? LogConfig
    {
        set => SetProperty("log_config", value);
    }

    /// <summary>
    /// Block for routing.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Routing is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Routing block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Routing block(s) allowed")]
    public List<GoogleNetworkServicesEdgeCacheServiceRoutingBlock>? Routing
    {
        set => SetProperty("routing", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleNetworkServicesEdgeCacheServiceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
