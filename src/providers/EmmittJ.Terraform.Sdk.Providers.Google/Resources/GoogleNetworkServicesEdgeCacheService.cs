using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for log_config in .
/// Nesting mode: list
/// </summary>
public class GoogleNetworkServicesEdgeCacheServiceLogConfigBlock : ITerraformBlock
{
    /// <summary>
    /// Specifies whether to enable logging for traffic served by this service.
    /// </summary>
    [TerraformPropertyName("enable")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> Enable { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>("", "enable");

    /// <summary>
    /// Configures the sampling rate of requests, where 1.0 means all logged requests are reported and 0.0 means no logged requests are reported. The default value is 1.0, and the value of the field must be in [0, 1].
    /// 
    /// This field can only be specified if logging is enabled for this service.
    /// </summary>
    [TerraformPropertyName("sample_rate")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? SampleRate { get; set; }

}

/// <summary>
/// Block type for routing in .
/// Nesting mode: list
/// </summary>
public class GoogleNetworkServicesEdgeCacheServiceRoutingBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleNetworkServicesEdgeCacheServiceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a google_network_services_edge_cache_service resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleNetworkServicesEdgeCacheService : TerraformResource
{
    public GoogleNetworkServicesEdgeCacheService(string name) : base("google_network_services_edge_cache_service", name)
    {
    }

    /// <summary>
    /// A human-readable description of the resource.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// Disables HTTP/2.
    /// 
    /// HTTP/2 (h2) is enabled by default and recommended for performance. HTTP/2 improves connection re-use and reduces connection setup overhead by sending multiple streams over the same connection.
    /// 
    /// Some legacy HTTP clients may have issues with HTTP/2 connections due to broken HTTP/2 implementations. Setting this to true will prevent HTTP/2 from being advertised and negotiated.
    /// </summary>
    [TerraformPropertyName("disable_http2")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? DisableHttp2 { get; set; }

    /// <summary>
    /// HTTP/3 (IETF QUIC) and Google QUIC are enabled by default.
    /// </summary>
    [TerraformPropertyName("disable_quic")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> DisableQuic { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "disable_quic");

    /// <summary>
    /// Resource URL that points at the Cloud Armor edge security policy that is applied on each request against the EdgeCacheService.
    /// </summary>
    [TerraformPropertyName("edge_security_policy")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? EdgeSecurityPolicy { get; set; }

    /// <summary>
    /// URLs to sslCertificate resources that are used to authenticate connections between users and the EdgeCacheService.
    /// 
    /// Note that only &amp;quot;global&amp;quot; certificates with a &amp;quot;scope&amp;quot; of &amp;quot;EDGE_CACHE&amp;quot; can be attached to an EdgeCacheService.
    /// </summary>
    [TerraformPropertyName("edge_ssl_certificates")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? EdgeSslCertificates { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Set of label tags associated with the EdgeCache resource.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformPropertyName("labels")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Labels { get; set; }

    /// <summary>
    /// Name of the resource; provided by the client when the resource is created.
    /// The name must be 1-64 characters long, and match the regular expression [a-zA-Z][a-zA-Z0-9_-]* which means the first character must be a letter,
    /// and all following characters must be a dash, underscore, letter or digit.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Project { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "project");

    /// <summary>
    /// Require TLS (HTTPS) for all clients connecting to this service.
    /// 
    /// Clients who connect over HTTP (port 80) will receive a HTTP 301 to the same URL over HTTPS (port 443).
    /// You must have at least one (1) edgeSslCertificate specified to enable this.
    /// </summary>
    [TerraformPropertyName("require_tls")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> RequireTls { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "require_tls");

    /// <summary>
    /// URL of the SslPolicy resource that will be associated with the EdgeCacheService.
    /// 
    /// If not set, the EdgeCacheService has no SSL policy configured, and will default to the &amp;quot;COMPATIBLE&amp;quot; policy.
    /// </summary>
    [TerraformPropertyName("ssl_policy")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SslPolicy { get; set; }

    /// <summary>
    /// Block for log_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LogConfig block(s) allowed")]
    [TerraformPropertyName("log_config")]
    public TerraformList<TerraformBlock<GoogleNetworkServicesEdgeCacheServiceLogConfigBlock>>? LogConfig { get; set; } = new();

    /// <summary>
    /// Block for routing.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Routing is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Routing block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Routing block(s) allowed")]
    [TerraformPropertyName("routing")]
    public TerraformList<TerraformBlock<GoogleNetworkServicesEdgeCacheServiceRoutingBlock>>? Routing { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleNetworkServicesEdgeCacheServiceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformPropertyName("effective_labels")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> EffectiveLabels => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "effective_labels");

    /// <summary>
    /// The IPv4 addresses associated with this service. Addresses are static for the lifetime of the service.
    /// </summary>
    [TerraformPropertyName("ipv4_addresses")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> Ipv4Addresses => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "ipv4_addresses");

    /// <summary>
    /// The IPv6 addresses associated with this service. Addresses are static for the lifetime of the service.
    /// </summary>
    [TerraformPropertyName("ipv6_addresses")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> Ipv6Addresses => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "ipv6_addresses");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformPropertyName("terraform_labels")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TerraformLabels => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "terraform_labels");

}
