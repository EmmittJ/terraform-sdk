using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for client_certificate in .
/// Nesting mode: list
/// </summary>
public partial class GoogleNetworkSecurityClientTlsPolicyClientCertificateBlock() : TerraformBlock("client_certificate")
{
}

/// <summary>
/// Block type for server_validation_ca in .
/// Nesting mode: list
/// </summary>
public partial class GoogleNetworkSecurityClientTlsPolicyServerValidationCaBlock() : TerraformBlock("server_validation_ca")
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleNetworkSecurityClientTlsPolicyTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Manages a google_network_security_client_tls_policy resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleNetworkSecurityClientTlsPolicy : TerraformResource
{
    public GoogleNetworkSecurityClientTlsPolicy(string name) : base("google_network_security_client_tls_policy", name)
    {
    }

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
    /// Set of label tags associated with the ClientTlsPolicy resource.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformProperty("labels")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Labels { get; set; }

    /// <summary>
    /// The location of the client tls policy.
    /// The default value is &#39;global&#39;.
    /// </summary>
    [TerraformProperty("location")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Location { get; set; }

    /// <summary>
    /// Name of the ClientTlsPolicy resource.
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
    /// Server Name Indication string to present to the server during TLS handshake. E.g: &amp;quot;secure.example.com&amp;quot;.
    /// </summary>
    [TerraformProperty("sni")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Sni { get; set; }

    /// <summary>
    /// Block for client_certificate.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ClientCertificate block(s) allowed")]
    [TerraformProperty("client_certificate")]
    public TerraformList<GoogleNetworkSecurityClientTlsPolicyClientCertificateBlock> ClientCertificate { get; set; } = new();

    /// <summary>
    /// Block for server_validation_ca.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("server_validation_ca")]
    public TerraformList<GoogleNetworkSecurityClientTlsPolicyServerValidationCaBlock> ServerValidationCa { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public GoogleNetworkSecurityClientTlsPolicyTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// Time the ClientTlsPolicy was created in UTC.
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
    /// Time the ClientTlsPolicy was updated in UTC.
    /// </summary>
    [TerraformProperty("update_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> UpdateTime { get; }

}
