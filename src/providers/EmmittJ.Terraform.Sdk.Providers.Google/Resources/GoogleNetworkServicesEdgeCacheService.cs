using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for log_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleNetworkServicesEdgeCacheServiceLogConfigBlock() : TerraformBlock("log_config")
{
    /// <summary>
    /// Specifies whether to enable logging for traffic served by this service.
    /// </summary>
    [TerraformProperty("enable")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> Enable { get; set; }

    /// <summary>
    /// Configures the sampling rate of requests, where 1.0 means all logged requests are reported and 0.0 means no logged requests are reported. The default value is 1.0, and the value of the field must be in [0, 1].
    /// 
    /// This field can only be specified if logging is enabled for this service.
    /// </summary>
    [TerraformProperty("sample_rate")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? SampleRate { get; set; }

}

/// <summary>
/// Block type for routing in .
/// Nesting mode: list
/// </summary>
public partial class GoogleNetworkServicesEdgeCacheServiceRoutingBlock() : TerraformBlock("routing")
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleNetworkServicesEdgeCacheServiceTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_network_services_edge_cache_service resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleNetworkServicesEdgeCacheService : TerraformResource
{
    public GoogleNetworkServicesEdgeCacheService(string name) : base("google_network_services_edge_cache_service", name)
    {
    }

    /// <summary>
    /// A human-readable description of the resource.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// Disables HTTP/2.
    /// 
    /// HTTP/2 (h2) is enabled by default and recommended for performance. HTTP/2 improves connection re-use and reduces connection setup overhead by sending multiple streams over the same connection.
    /// 
    /// Some legacy HTTP clients may have issues with HTTP/2 connections due to broken HTTP/2 implementations. Setting this to true will prevent HTTP/2 from being advertised and negotiated.
    /// </summary>
    [TerraformProperty("disable_http2")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? DisableHttp2 { get; set; }

    /// <summary>
    /// HTTP/3 (IETF QUIC) and Google QUIC are enabled by default.
    /// </summary>
    [TerraformProperty("disable_quic")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> DisableQuic { get; set; }

    /// <summary>
    /// Resource URL that points at the Cloud Armor edge security policy that is applied on each request against the EdgeCacheService.
    /// </summary>
    [TerraformProperty("edge_security_policy")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? EdgeSecurityPolicy { get; set; }

    /// <summary>
    /// URLs to sslCertificate resources that are used to authenticate connections between users and the EdgeCacheService.
    /// 
    /// Note that only &amp;quot;global&amp;quot; certificates with a &amp;quot;scope&amp;quot; of &amp;quot;EDGE_CACHE&amp;quot; can be attached to an EdgeCacheService.
    /// </summary>
    [TerraformProperty("edge_ssl_certificates")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? EdgeSslCertificates { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Set of label tags associated with the EdgeCache resource.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformProperty("labels")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Labels { get; set; }

    /// <summary>
    /// Name of the resource; provided by the client when the resource is created.
    /// The name must be 1-64 characters long, and match the regular expression [a-zA-Z][a-zA-Z0-9_-]* which means the first character must be a letter,
    /// and all following characters must be a dash, underscore, letter or digit.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// Require TLS (HTTPS) for all clients connecting to this service.
    /// 
    /// Clients who connect over HTTP (port 80) will receive a HTTP 301 to the same URL over HTTPS (port 443).
    /// You must have at least one (1) edgeSslCertificate specified to enable this.
    /// </summary>
    [TerraformProperty("require_tls")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> RequireTls { get; set; }

    /// <summary>
    /// URL of the SslPolicy resource that will be associated with the EdgeCacheService.
    /// 
    /// If not set, the EdgeCacheService has no SSL policy configured, and will default to the &amp;quot;COMPATIBLE&amp;quot; policy.
    /// </summary>
    [TerraformProperty("ssl_policy")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SslPolicy { get; set; }

    /// <summary>
    /// Block for log_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LogConfig block(s) allowed")]
    [TerraformProperty("log_config")]
    public TerraformList<GoogleNetworkServicesEdgeCacheServiceLogConfigBlock> LogConfig { get; set; } = new();

    /// <summary>
    /// Block for routing.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Routing is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Routing block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Routing block(s) allowed")]
    [TerraformProperty("routing")]
    public required TerraformList<GoogleNetworkServicesEdgeCacheServiceRoutingBlock> Routing { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public GoogleNetworkServicesEdgeCacheServiceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformProperty("effective_labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> EffectiveLabels { get; }

    /// <summary>
    /// The IPv4 addresses associated with this service. Addresses are static for the lifetime of the service.
    /// </summary>
    [TerraformProperty("ipv4_addresses")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> Ipv4Addresses { get; }

    /// <summary>
    /// The IPv6 addresses associated with this service. Addresses are static for the lifetime of the service.
    /// </summary>
    [TerraformProperty("ipv6_addresses")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> Ipv6Addresses { get; }

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformProperty("terraform_labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> TerraformLabels { get; }

}
