using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleNetworkSecurityBackendAuthenticationConfigTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Manages a google_network_security_backend_authentication_config resource.
/// </summary>
public partial class GoogleNetworkSecurityBackendAuthenticationConfig : TerraformResource
{
    public GoogleNetworkSecurityBackendAuthenticationConfig(string name) : base("google_network_security_backend_authentication_config", name)
    {
    }

    /// <summary>
    /// Reference to a Certificate resource from the certificatemanager.googleapis.com namespace.
    /// Used by a BackendService to negotiate mTLS when the backend connection uses TLS and the backend requests a client certificate. Must have a CLIENT_AUTH scope.
    /// </summary>
    [TerraformProperty("client_certificate")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ClientCertificate { get; set; }

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
    /// Set of label tags associated with the BackendAuthenticationConfig resource.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformProperty("labels")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Labels { get; set; }

    /// <summary>
    /// The location of the backend authentication config.
    /// The default value is &#39;global&#39;.
    /// </summary>
    [TerraformProperty("location")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Location { get; set; }

    /// <summary>
    /// Name of the BackendAuthenticationConfig resource.
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
    /// Reference to a TrustConfig resource from the certificatemanager.googleapis.com namespace.
    /// A BackendService uses the chain of trust represented by this TrustConfig, if specified, to validate the server certificates presented by the backend. Required unless wellKnownRoots is set to PUBLIC_ROOTS.
    /// </summary>
    [TerraformProperty("trust_config")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? TrustConfig { get; set; }

    /// <summary>
    /// Well known roots to use for server certificate validation. If set to NONE, the BackendService will only validate server certificates against roots specified in TrustConfig.
    /// If set to PUBLIC_ROOTS, the BackendService uses a set of well-known public roots, in addition to any roots specified in the trustConfig field, when validating the server certificates presented by the backend.
    /// Validation with these roots is only considered when the TlsSettings.sni field in the BackendService is set. The well-known roots are a set of root CAs managed by Google. CAs in this set can be added or removed without notice. Possible values: [&amp;quot;NONE&amp;quot;, &amp;quot;PUBLIC_ROOTS&amp;quot;]
    /// </summary>
    [TerraformProperty("well_known_roots")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? WellKnownRoots { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public GoogleNetworkSecurityBackendAuthenticationConfigTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// Time the BackendAuthenticationConfig was created in UTC.
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
    /// Time the BackendAuthenticationConfig was updated in UTC.
    /// </summary>
    [TerraformProperty("update_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> UpdateTime { get; }

}
