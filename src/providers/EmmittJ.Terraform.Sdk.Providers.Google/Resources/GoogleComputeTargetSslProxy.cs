using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleComputeTargetSslProxyTimeoutsBlock : ITerraformBlock
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
/// Manages a google_compute_target_ssl_proxy resource.
/// </summary>
public class GoogleComputeTargetSslProxy : TerraformResource
{
    public GoogleComputeTargetSslProxy(string name) : base("google_compute_target_ssl_proxy", name)
    {
    }

    /// <summary>
    /// A reference to the BackendService resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackendService is required")]
    [TerraformPropertyName("backend_service")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> BackendService { get; set; }

    /// <summary>
    /// A reference to the CertificateMap resource uri that identifies a certificate map
    /// associated with the given target proxy. This field can only be set for global target proxies.
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
    /// Specifies the type of proxy header to append before sending data to
    /// the backend. Default value: &amp;quot;NONE&amp;quot; Possible values: [&amp;quot;NONE&amp;quot;, &amp;quot;PROXY_V1&amp;quot;]
    /// </summary>
    [TerraformPropertyName("proxy_header")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ProxyHeader { get; set; }

    /// <summary>
    /// A list of SslCertificate resources that are used to authenticate
    /// connections between users and the load balancer. At least one
    /// SSL certificate must be specified.
    /// </summary>
    [TerraformPropertyName("ssl_certificates")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? SslCertificates { get; set; }

    /// <summary>
    /// A reference to the SslPolicy resource that will be associated with
    /// the TargetSslProxy resource. If not set, the TargetSslProxy
    /// resource will not have any SSL policy configured.
    /// </summary>
    [TerraformPropertyName("ssl_policy")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SslPolicy { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleComputeTargetSslProxyTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    [TerraformPropertyName("creation_timestamp")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreationTimestamp => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "creation_timestamp");

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
