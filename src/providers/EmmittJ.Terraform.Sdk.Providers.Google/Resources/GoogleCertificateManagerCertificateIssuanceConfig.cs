using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for certificate_authority_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleCertificateManagerCertificateIssuanceConfigCertificateAuthorityConfigBlock : TerraformBlockBase
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleCertificateManagerCertificateIssuanceConfigTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_certificate_manager_certificate_issuance_config resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleCertificateManagerCertificateIssuanceConfig : TerraformResource
{
    public GoogleCertificateManagerCertificateIssuanceConfig(string name) : base("google_certificate_manager_certificate_issuance_config", name)
    {
    }

    /// <summary>
    /// One or more paragraphs of text description of a CertificateIssuanceConfig.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Key algorithm to use when generating the private key. Possible values: [&amp;quot;RSA_2048&amp;quot;, &amp;quot;ECDSA_P256&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyAlgorithm is required")]
    [TerraformProperty("key_algorithm")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> KeyAlgorithm { get; set; }

    /// <summary>
    /// &#39;Set of label tags associated with the CertificateIssuanceConfig resource.
    ///  An object containing a list of &amp;quot;key&amp;quot;: value pairs. Example: { &amp;quot;name&amp;quot;: &amp;quot;wrench&amp;quot;, &amp;quot;count&amp;quot;: &amp;quot;3&amp;quot; }.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformProperty("labels")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Labels { get; set; }

    /// <summary>
    /// Lifetime of issued certificates. A duration in seconds with up to nine fractional digits, ending with &#39;s&#39;.
    /// Example: &amp;quot;1814400s&amp;quot;. Valid values are from 21 days (1814400s) to 30 days (2592000s)
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Lifetime is required")]
    [TerraformProperty("lifetime")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Lifetime { get; set; }

    /// <summary>
    /// The Certificate Manager location. If not specified, &amp;quot;global&amp;quot; is used.
    /// </summary>
    [TerraformProperty("location")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Location { get; set; }

    /// <summary>
    /// A user-defined name of the certificate issuance config.
    /// CertificateIssuanceConfig names must be unique globally.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Project { get; set; }

    /// <summary>
    /// It specifies the percentage of elapsed time of the certificate lifetime to wait before renewing the certificate.
    /// Must be a number between 1-99, inclusive.
    /// You must set the rotation window percentage in relation to the certificate lifetime so that certificate renewal occurs at least 7 days after
    /// the certificate has been issued and at least 7 days before it expires.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RotationWindowPercentage is required")]
    [TerraformProperty("rotation_window_percentage")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<double> RotationWindowPercentage { get; set; }

    /// <summary>
    /// Block for certificate_authority_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CertificateAuthorityConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 CertificateAuthorityConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CertificateAuthorityConfig block(s) allowed")]
    [TerraformProperty("certificate_authority_config")]
    public TerraformList<TerraformBlock<GoogleCertificateManagerCertificateIssuanceConfigCertificateAuthorityConfigBlock>>? CertificateAuthorityConfig { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<GoogleCertificateManagerCertificateIssuanceConfigTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The creation timestamp of a CertificateIssuanceConfig. Timestamp is in RFC3339 UTC &amp;quot;Zulu&amp;quot; format,
    /// accurate to nanoseconds with up to nine fractional digits.
    /// Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    [TerraformProperty("create_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CreateTime { get; }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformProperty("effective_labels")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> EffectiveLabels { get; }

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformProperty("terraform_labels")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> TerraformLabels { get; }

    /// <summary>
    /// The last update timestamp of a CertificateIssuanceConfig. Timestamp is in RFC3339 UTC &amp;quot;Zulu&amp;quot; format,
    /// accurate to nanoseconds with up to nine fractional digits.
    /// Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    [TerraformProperty("update_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> UpdateTime { get; }

}
