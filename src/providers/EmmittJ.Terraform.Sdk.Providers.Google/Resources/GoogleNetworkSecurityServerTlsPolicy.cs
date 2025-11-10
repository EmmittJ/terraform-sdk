using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for mtls_policy in .
/// Nesting mode: list
/// </summary>
public class GoogleNetworkSecurityServerTlsPolicyMtlsPolicyBlock : ITerraformBlock
{
    /// <summary>
    /// When the client presents an invalid certificate or no certificate to the load balancer, the clientValidationMode specifies how the client connection is handled.
    /// Required if the policy is to be used with the external HTTPS load balancing. For Traffic Director it must be empty. Possible values: [&amp;quot;CLIENT_VALIDATION_MODE_UNSPECIFIED&amp;quot;, &amp;quot;ALLOW_INVALID_OR_MISSING_CLIENT_CERT&amp;quot;, &amp;quot;REJECT_INVALID&amp;quot;]
    /// </summary>
    [TerraformPropertyName("client_validation_mode")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ClientValidationMode { get; set; }

    /// <summary>
    /// Reference to the TrustConfig from certificatemanager.googleapis.com namespace.
    /// If specified, the chain validation will be performed against certificates configured in the given TrustConfig.
    /// Allowed only if the policy is to be used with external HTTPS load balancers.
    /// </summary>
    [TerraformPropertyName("client_validation_trust_config")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ClientValidationTrustConfig { get; set; }

}

/// <summary>
/// Block type for server_certificate in .
/// Nesting mode: list
/// </summary>
public class GoogleNetworkSecurityServerTlsPolicyServerCertificateBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleNetworkSecurityServerTlsPolicyTimeoutsBlock : ITerraformBlock
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
/// Manages a google_network_security_server_tls_policy resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleNetworkSecurityServerTlsPolicy : TerraformResource
{
    public GoogleNetworkSecurityServerTlsPolicy(string name) : base("google_network_security_server_tls_policy", name)
    {
    }

    /// <summary>
    /// This field applies only for Traffic Director policies. It is must be set to false for external HTTPS load balancer policies.
    /// Determines if server allows plaintext connections. If set to true, server allows plain text connections. By default, it is set to false. This setting is not exclusive of other encryption modes. For example, if allowOpen and mtlsPolicy are set, server allows both plain text and mTLS connections. See documentation of other encryption modes to confirm compatibility.
    /// Consider using it if you wish to upgrade in place your deployment to TLS while having mixed TLS and non-TLS traffic reaching port :80.
    /// </summary>
    [TerraformPropertyName("allow_open")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? AllowOpen { get; set; }

    /// <summary>
    /// A free-text description of the resource. Max length 1024 characters.
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
    /// Set of label tags associated with the ServerTlsPolicy resource.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformPropertyName("labels")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Labels { get; set; }

    /// <summary>
    /// The location of the server tls policy.
    /// The default value is &#39;global&#39;.
    /// </summary>
    [TerraformPropertyName("location")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Location { get; set; }

    /// <summary>
    /// Name of the ServerTlsPolicy resource.
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
    /// Block for mtls_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MtlsPolicy block(s) allowed")]
    [TerraformPropertyName("mtls_policy")]
    public TerraformList<TerraformBlock<GoogleNetworkSecurityServerTlsPolicyMtlsPolicyBlock>>? MtlsPolicy { get; set; } = new();

    /// <summary>
    /// Block for server_certificate.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServerCertificate block(s) allowed")]
    [TerraformPropertyName("server_certificate")]
    public TerraformList<TerraformBlock<GoogleNetworkSecurityServerTlsPolicyServerCertificateBlock>>? ServerCertificate { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleNetworkSecurityServerTlsPolicyTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// Time the ServerTlsPolicy was created in UTC.
    /// </summary>
    [TerraformPropertyName("create_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "create_time");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformPropertyName("effective_labels")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> EffectiveLabels => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "effective_labels");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformPropertyName("terraform_labels")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TerraformLabels => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "terraform_labels");

    /// <summary>
    /// Time the ServerTlsPolicy was updated in UTC.
    /// </summary>
    [TerraformPropertyName("update_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> UpdateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "update_time");

}
