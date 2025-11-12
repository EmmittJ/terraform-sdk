using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleComputeTargetSslProxyTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Manages a google_compute_target_ssl_proxy resource.
/// </summary>
public partial class GoogleComputeTargetSslProxy : TerraformResource
{
    public GoogleComputeTargetSslProxy(string name) : base("google_compute_target_ssl_proxy", name)
    {
    }

    /// <summary>
    /// A reference to the BackendService resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackendService is required")]
    [TerraformProperty("backend_service")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> BackendService { get; set; }

    /// <summary>
    /// A reference to the CertificateMap resource uri that identifies a certificate map
    /// associated with the given target proxy. This field can only be set for global target proxies.
    /// Accepted format is &#39;//certificatemanager.googleapis.com/projects/{project}/locations/{location}/certificateMaps/{resourceName}&#39;.
    /// </summary>
    [TerraformProperty("certificate_map")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? CertificateMap { get; set; }

    /// <summary>
    /// An optional description of this resource.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

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
    /// Specifies the type of proxy header to append before sending data to
    /// the backend. Default value: &amp;quot;NONE&amp;quot; Possible values: [&amp;quot;NONE&amp;quot;, &amp;quot;PROXY_V1&amp;quot;]
    /// </summary>
    [TerraformProperty("proxy_header")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ProxyHeader { get; set; }

    /// <summary>
    /// A list of SslCertificate resources that are used to authenticate
    /// connections between users and the load balancer. At least one
    /// SSL certificate must be specified.
    /// </summary>
    [TerraformProperty("ssl_certificates")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? SslCertificates { get; set; }

    /// <summary>
    /// A reference to the SslPolicy resource that will be associated with
    /// the TargetSslProxy resource. If not set, the TargetSslProxy
    /// resource will not have any SSL policy configured.
    /// </summary>
    [TerraformProperty("ssl_policy")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SslPolicy { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public GoogleComputeTargetSslProxyTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    [TerraformProperty("creation_timestamp")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreationTimestamp { get; }

    /// <summary>
    /// The unique identifier for the resource.
    /// </summary>
    [TerraformProperty("proxy_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> ProxyId { get; }

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    [TerraformProperty("self_link")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SelfLink { get; }

}
