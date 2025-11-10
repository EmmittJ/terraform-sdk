using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleComputeTargetHttpsProxyTimeoutsBlock : ITerraformBlock
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
/// Manages a google_compute_target_https_proxy resource.
/// </summary>
public class GoogleComputeTargetHttpsProxy : TerraformResource
{
    public GoogleComputeTargetHttpsProxy(string name) : base("google_compute_target_https_proxy", name)
    {
    }

    /// <summary>
    /// URLs to certificate manager certificate resources that are used to authenticate connections between users and the load balancer.
    /// Certificate manager certificates only apply when the load balancing scheme is set to INTERNAL_MANAGED.
    /// For EXTERNAL and EXTERNAL_MANAGED, use certificate_map instead.
    /// sslCertificates and certificateManagerCertificates fields can not be defined together.
    /// Accepted format is &#39;//certificatemanager.googleapis.com/projects/{project}/locations/{location}/certificates/{resourceName}&#39; or just the self_link &#39;projects/{project}/locations/{location}/certificates/{resourceName}&#39;
    /// </summary>
    [TerraformPropertyName("certificate_manager_certificates")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? CertificateManagerCertificates { get; set; }

    /// <summary>
    /// A reference to the CertificateMap resource uri that identifies a certificate map
    /// associated with the given target proxy. This field is only supported for EXTERNAL and EXTERNAL_MANAGED load balancing schemes.
    /// For INTERNAL_MANAGED, use certificate_manager_certificates instead.
    /// Accepted format is &#39;//certificatemanager.googleapis.com/projects/{project}/locations/{location}/certificateMaps/{resourceName}&#39;.
    /// </summary>
    [TerraformPropertyName("certificate_map")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? CertificateMap { get; set; }

    /// <summary>
    /// An optional description of this resource.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// Specifies how long to keep a connection open, after completing a response,
    /// while there is no matching traffic (in seconds). If an HTTP keepalive is
    /// not specified, a default value will be used. For Global
    /// external HTTP(S) load balancer, the default value is 610 seconds, the
    /// minimum allowed value is 5 seconds and the maximum allowed value is 1200
    /// seconds. For cross-region internal HTTP(S) load balancer, the default
    /// value is 600 seconds, the minimum allowed value is 5 seconds, and the
    /// maximum allowed value is 600 seconds. For Global external HTTP(S) load
    /// balancer (classic), this option is not available publicly.
    /// </summary>
    [TerraformPropertyName("http_keep_alive_timeout_sec")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? HttpKeepAliveTimeoutSec { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Name of the resource. Provided by the client when the resource is
    /// created. The name must be 1-63 characters long, and comply with
    /// RFC1035. Specifically, the name must be 1-63 characters long and match
    /// the regular expression &#39;[a-z]([-a-z0-9]*[a-z0-9])?&#39; which means the
    /// first character must be a lowercase letter, and all following
    /// characters must be a dash, lowercase letter, or digit, except the last
    /// character, which cannot be a dash.
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
    /// This field only applies when the forwarding rule that references
    /// this target proxy has a loadBalancingScheme set to INTERNAL_SELF_MANAGED.
    /// </summary>
    [TerraformPropertyName("proxy_bind")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> ProxyBind { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "proxy_bind");

    /// <summary>
    /// Specifies the QUIC override policy for this resource. This determines
    /// whether the load balancer will attempt to negotiate QUIC with clients
    /// or not. Can specify one of NONE, ENABLE, or DISABLE. If NONE is
    /// specified, Google manages whether QUIC is used. Default value: &amp;quot;NONE&amp;quot; Possible values: [&amp;quot;NONE&amp;quot;, &amp;quot;ENABLE&amp;quot;, &amp;quot;DISABLE&amp;quot;]
    /// </summary>
    [TerraformPropertyName("quic_override")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? QuicOverride { get; set; }

    /// <summary>
    /// A URL referring to a networksecurity.ServerTlsPolicy
    /// resource that describes how the proxy should authenticate inbound
    /// traffic. serverTlsPolicy only applies to a global TargetHttpsProxy
    /// attached to globalForwardingRules with the loadBalancingScheme
    /// set to INTERNAL_SELF_MANAGED or EXTERNAL or EXTERNAL_MANAGED.
    /// For details which ServerTlsPolicy resources are accepted with
    /// INTERNAL_SELF_MANAGED and which with EXTERNAL, EXTERNAL_MANAGED
    /// loadBalancingScheme consult ServerTlsPolicy documentation.
    /// If left blank, communications are not encrypted.
    /// 
    /// If you remove this field from your configuration at the same time as
    /// deleting or recreating a referenced ServerTlsPolicy resource, you will
    /// receive a resourceInUseByAnotherResource error. Use lifecycle.create_before_destroy
    /// within the ServerTlsPolicy resource to avoid this.
    /// </summary>
    [TerraformPropertyName("server_tls_policy")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ServerTlsPolicy { get; set; }

    /// <summary>
    /// URLs to SslCertificate resources that are used to authenticate connections between users and the load balancer.
    /// Currently, you may specify up to 15 SSL certificates. sslCertificates do not apply when the load balancing scheme is set to INTERNAL_SELF_MANAGED.
    /// sslCertificates and certificateManagerCertificates can not be defined together.
    /// </summary>
    [TerraformPropertyName("ssl_certificates")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? SslCertificates { get; set; }

    /// <summary>
    /// A reference to the SslPolicy resource that will be associated with
    /// the TargetHttpsProxy resource. If not set, the TargetHttpsProxy
    /// resource will not have any SSL policy configured.
    /// </summary>
    [TerraformPropertyName("ssl_policy")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SslPolicy { get; set; }

    /// <summary>
    /// Specifies whether TLS 1.3 0-RTT Data (“Early Data”) should be accepted for this service.
    /// Early Data allows a TLS resumption handshake to include the initial application payload
    /// (a HTTP request) alongside the handshake, reducing the effective round trips to “zero”.
    /// This applies to TLS 1.3 connections over TCP (HTTP/2) as well as over UDP (QUIC/h3). Possible values: [&amp;quot;STRICT&amp;quot;, &amp;quot;PERMISSIVE&amp;quot;, &amp;quot;UNRESTRICTED&amp;quot;, &amp;quot;DISABLED&amp;quot;]
    /// </summary>
    [TerraformPropertyName("tls_early_data")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> TlsEarlyData { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "tls_early_data");

    /// <summary>
    /// A reference to the UrlMap resource that defines the mapping from URL
    /// to the BackendService.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UrlMap is required")]
    [TerraformPropertyName("url_map")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> UrlMap { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleComputeTargetHttpsProxyTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    [TerraformPropertyName("creation_timestamp")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreationTimestamp => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "creation_timestamp");

    /// <summary>
    /// Fingerprint of this resource. A hash of the contents stored in this object. This field is used in optimistic locking.
    /// This field will be ignored when inserting a TargetHttpsProxy. An up-to-date fingerprint must be provided in order to
    /// patch the TargetHttpsProxy; otherwise, the request will fail with error 412 conditionNotMet.
    /// To see the latest fingerprint, make a get() request to retrieve the TargetHttpsProxy.
    /// A base64-encoded string.
    /// </summary>
    [TerraformPropertyName("fingerprint")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Fingerprint => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "fingerprint");

    /// <summary>
    /// The unique identifier for the resource.
    /// </summary>
    [TerraformPropertyName("proxy_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> ProxyId => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "proxy_id");

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    [TerraformPropertyName("self_link")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SelfLink => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "self_link");

}
