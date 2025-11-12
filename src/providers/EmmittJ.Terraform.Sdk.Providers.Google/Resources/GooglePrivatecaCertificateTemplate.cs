using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for identity_constraints in .
/// Nesting mode: list
/// </summary>
public partial class GooglePrivatecaCertificateTemplateIdentityConstraintsBlock() : TerraformBlock("identity_constraints")
{
    /// <summary>
    /// Required. If this is true, the SubjectAltNames extension may be copied from a certificate request into the signed certificate. Otherwise, the requested SubjectAltNames will be discarded.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllowSubjectAltNamesPassthrough is required")]
    [TerraformProperty("allow_subject_alt_names_passthrough")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<bool> AllowSubjectAltNamesPassthrough { get; set; }

    /// <summary>
    /// Required. If this is true, the Subject field may be copied from a certificate request into the signed certificate. Otherwise, the requested Subject will be discarded.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllowSubjectPassthrough is required")]
    [TerraformProperty("allow_subject_passthrough")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<bool> AllowSubjectPassthrough { get; set; }

}

/// <summary>
/// Block type for passthrough_extensions in .
/// Nesting mode: list
/// </summary>
public partial class GooglePrivatecaCertificateTemplatePassthroughExtensionsBlock() : TerraformBlock("passthrough_extensions")
{
    /// <summary>
    /// Optional. A set of named X.509 extensions. Will be combined with additional_extensions to determine the full set of X.509 extensions.
    /// </summary>
    [TerraformProperty("known_extensions")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? KnownExtensions { get; set; }

}

/// <summary>
/// Block type for predefined_values in .
/// Nesting mode: list
/// </summary>
public partial class GooglePrivatecaCertificateTemplatePredefinedValuesBlock() : TerraformBlock("predefined_values")
{
    /// <summary>
    /// Optional. Describes Online Certificate Status Protocol (OCSP) endpoint addresses that appear in the &amp;quot;Authority Information Access&amp;quot; extension in the certificate.
    /// </summary>
    [TerraformProperty("aia_ocsp_servers")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? AiaOcspServers { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GooglePrivatecaCertificateTemplateTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Manages a google_privateca_certificate_template resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GooglePrivatecaCertificateTemplate : TerraformResource
{
    public GooglePrivatecaCertificateTemplate(string name) : base("google_privateca_certificate_template", name)
    {
    }

    /// <summary>
    /// Optional. A human-readable description of scenarios this template is intended for.
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
    /// Optional. Labels with user-defined metadata.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformProperty("labels")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Labels { get; set; }

    /// <summary>
    /// The location for the resource
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// Optional. The maximum lifetime allowed for all issued certificates that use this template. If the issuing CaPool&#39;s IssuancePolicy specifies a maximum lifetime the minimum of the two durations will be the maximum lifetime for issued. Note that if the issuing CertificateAuthority expires before a Certificate&#39;s requested maximum_lifetime, the effective lifetime will be explicitly truncated to match it.
    /// </summary>
    [TerraformProperty("maximum_lifetime")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? MaximumLifetime { get; set; }

    /// <summary>
    /// The resource name for this CertificateTemplate in the format &#39;projects/*/locations/*/certificateTemplates/*&#39;.
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
    /// Block for identity_constraints.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IdentityConstraints block(s) allowed")]
    [TerraformProperty("identity_constraints")]
    public TerraformList<GooglePrivatecaCertificateTemplateIdentityConstraintsBlock> IdentityConstraints { get; set; } = new();

    /// <summary>
    /// Block for passthrough_extensions.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PassthroughExtensions block(s) allowed")]
    [TerraformProperty("passthrough_extensions")]
    public TerraformList<GooglePrivatecaCertificateTemplatePassthroughExtensionsBlock> PassthroughExtensions { get; set; } = new();

    /// <summary>
    /// Block for predefined_values.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PredefinedValues block(s) allowed")]
    [TerraformProperty("predefined_values")]
    public TerraformList<GooglePrivatecaCertificateTemplatePredefinedValuesBlock> PredefinedValues { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public GooglePrivatecaCertificateTemplateTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// Output only. The time at which this CertificateTemplate was created.
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
    /// Output only. The time at which this CertificateTemplate was updated.
    /// </summary>
    [TerraformProperty("update_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> UpdateTime { get; }

}
