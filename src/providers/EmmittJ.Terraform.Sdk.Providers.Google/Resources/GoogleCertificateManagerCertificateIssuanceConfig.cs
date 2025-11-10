using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for certificate_authority_config in .
/// Nesting mode: list
/// </summary>
public class GoogleCertificateManagerCertificateIssuanceConfigCertificateAuthorityConfigBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleCertificateManagerCertificateIssuanceConfigTimeoutsBlock : ITerraformBlock
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
/// Manages a google_certificate_manager_certificate_issuance_config resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleCertificateManagerCertificateIssuanceConfig : TerraformResource
{
    public GoogleCertificateManagerCertificateIssuanceConfig(string name) : base("google_certificate_manager_certificate_issuance_config", name)
    {
    }

    /// <summary>
    /// One or more paragraphs of text description of a CertificateIssuanceConfig.
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
    /// Key algorithm to use when generating the private key. Possible values: [&amp;quot;RSA_2048&amp;quot;, &amp;quot;ECDSA_P256&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyAlgorithm is required")]
    [TerraformPropertyName("key_algorithm")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> KeyAlgorithm { get; set; }

    /// <summary>
    /// &#39;Set of label tags associated with the CertificateIssuanceConfig resource.
    ///  An object containing a list of &amp;quot;key&amp;quot;: value pairs. Example: { &amp;quot;name&amp;quot;: &amp;quot;wrench&amp;quot;, &amp;quot;count&amp;quot;: &amp;quot;3&amp;quot; }.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformPropertyName("labels")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Labels { get; set; }

    /// <summary>
    /// Lifetime of issued certificates. A duration in seconds with up to nine fractional digits, ending with &#39;s&#39;.
    /// Example: &amp;quot;1814400s&amp;quot;. Valid values are from 21 days (1814400s) to 30 days (2592000s)
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Lifetime is required")]
    [TerraformPropertyName("lifetime")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Lifetime { get; set; }

    /// <summary>
    /// The Certificate Manager location. If not specified, &amp;quot;global&amp;quot; is used.
    /// </summary>
    [TerraformPropertyName("location")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Location { get; set; }

    /// <summary>
    /// A user-defined name of the certificate issuance config.
    /// CertificateIssuanceConfig names must be unique globally.
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
    /// It specifies the percentage of elapsed time of the certificate lifetime to wait before renewing the certificate.
    /// Must be a number between 1-99, inclusive.
    /// You must set the rotation window percentage in relation to the certificate lifetime so that certificate renewal occurs at least 7 days after
    /// the certificate has been issued and at least 7 days before it expires.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RotationWindowPercentage is required")]
    [TerraformPropertyName("rotation_window_percentage")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> RotationWindowPercentage { get; set; }

    /// <summary>
    /// Block for certificate_authority_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CertificateAuthorityConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 CertificateAuthorityConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CertificateAuthorityConfig block(s) allowed")]
    [TerraformPropertyName("certificate_authority_config")]
    public TerraformList<TerraformBlock<GoogleCertificateManagerCertificateIssuanceConfigCertificateAuthorityConfigBlock>>? CertificateAuthorityConfig { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleCertificateManagerCertificateIssuanceConfigTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The creation timestamp of a CertificateIssuanceConfig. Timestamp is in RFC3339 UTC &amp;quot;Zulu&amp;quot; format,
    /// accurate to nanoseconds with up to nine fractional digits.
    /// Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
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
    /// The last update timestamp of a CertificateIssuanceConfig. Timestamp is in RFC3339 UTC &amp;quot;Zulu&amp;quot; format,
    /// accurate to nanoseconds with up to nine fractional digits.
    /// Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    [TerraformPropertyName("update_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> UpdateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "update_time");

}
