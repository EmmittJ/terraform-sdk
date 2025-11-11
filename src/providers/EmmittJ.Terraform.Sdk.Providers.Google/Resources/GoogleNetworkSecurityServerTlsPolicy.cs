using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for mtls_policy in .
/// Nesting mode: list
/// </summary>
public partial class GoogleNetworkSecurityServerTlsPolicyMtlsPolicyBlock : TerraformBlockBase
{
    /// <summary>
    /// When the client presents an invalid certificate or no certificate to the load balancer, the clientValidationMode specifies how the client connection is handled.
    /// Required if the policy is to be used with the external HTTPS load balancing. For Traffic Director it must be empty. Possible values: [&amp;quot;CLIENT_VALIDATION_MODE_UNSPECIFIED&amp;quot;, &amp;quot;ALLOW_INVALID_OR_MISSING_CLIENT_CERT&amp;quot;, &amp;quot;REJECT_INVALID&amp;quot;]
    /// </summary>
    [TerraformProperty("client_validation_mode")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ClientValidationMode { get; set; }

    /// <summary>
    /// Reference to the TrustConfig from certificatemanager.googleapis.com namespace.
    /// If specified, the chain validation will be performed against certificates configured in the given TrustConfig.
    /// Allowed only if the policy is to be used with external HTTPS load balancers.
    /// </summary>
    [TerraformProperty("client_validation_trust_config")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ClientValidationTrustConfig { get; set; }

}

/// <summary>
/// Block type for server_certificate in .
/// Nesting mode: list
/// </summary>
public partial class GoogleNetworkSecurityServerTlsPolicyServerCertificateBlock : TerraformBlockBase
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleNetworkSecurityServerTlsPolicyTimeoutsBlock : TerraformBlockBase
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
/// Manages a google_network_security_server_tls_policy resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleNetworkSecurityServerTlsPolicy : TerraformResource
{
    public GoogleNetworkSecurityServerTlsPolicy(string name) : base("google_network_security_server_tls_policy", name)
    {
    }

    /// <summary>
    /// This field applies only for Traffic Director policies. It is must be set to false for external HTTPS load balancer policies.
    /// Determines if server allows plaintext connections. If set to true, server allows plain text connections. By default, it is set to false. This setting is not exclusive of other encryption modes. For example, if allowOpen and mtlsPolicy are set, server allows both plain text and mTLS connections. See documentation of other encryption modes to confirm compatibility.
    /// Consider using it if you wish to upgrade in place your deployment to TLS while having mixed TLS and non-TLS traffic reaching port :80.
    /// </summary>
    [TerraformProperty("allow_open")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? AllowOpen { get; set; }

    /// <summary>
    /// A free-text description of the resource. Max length 1024 characters.
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
    /// Set of label tags associated with the ServerTlsPolicy resource.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformProperty("labels")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Labels { get; set; }

    /// <summary>
    /// The location of the server tls policy.
    /// The default value is &#39;global&#39;.
    /// </summary>
    [TerraformProperty("location")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Location { get; set; }

    /// <summary>
    /// Name of the ServerTlsPolicy resource.
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
    /// Block for mtls_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MtlsPolicy block(s) allowed")]
    [TerraformProperty("mtls_policy")]
    public partial TerraformList<TerraformBlock<GoogleNetworkSecurityServerTlsPolicyMtlsPolicyBlock>>? MtlsPolicy { get; set; }

    /// <summary>
    /// Block for server_certificate.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServerCertificate block(s) allowed")]
    [TerraformProperty("server_certificate")]
    public partial TerraformList<TerraformBlock<GoogleNetworkSecurityServerTlsPolicyServerCertificateBlock>>? ServerCertificate { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<GoogleNetworkSecurityServerTlsPolicyTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Time the ServerTlsPolicy was created in UTC.
    /// </summary>
    [TerraformProperty("create_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreateTime { get; }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformProperty("effective_labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> EffectiveLabels { get; }

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformProperty("terraform_labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> TerraformLabels { get; }

    /// <summary>
    /// Time the ServerTlsPolicy was updated in UTC.
    /// </summary>
    [TerraformProperty("update_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> UpdateTime { get; }

}
