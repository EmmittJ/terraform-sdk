using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for identity_constraints in .
/// Nesting mode: list
/// </summary>
public class GooglePrivatecaCertificateTemplateIdentityConstraintsBlock : ITerraformBlock
{
    /// <summary>
    /// Required. If this is true, the SubjectAltNames extension may be copied from a certificate request into the signed certificate. Otherwise, the requested SubjectAltNames will be discarded.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllowSubjectAltNamesPassthrough is required")]
    [TerraformPropertyName("allow_subject_alt_names_passthrough")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<bool>> AllowSubjectAltNamesPassthrough { get; set; }

    /// <summary>
    /// Required. If this is true, the Subject field may be copied from a certificate request into the signed certificate. Otherwise, the requested Subject will be discarded.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllowSubjectPassthrough is required")]
    [TerraformPropertyName("allow_subject_passthrough")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<bool>> AllowSubjectPassthrough { get; set; }

}

/// <summary>
/// Block type for passthrough_extensions in .
/// Nesting mode: list
/// </summary>
public class GooglePrivatecaCertificateTemplatePassthroughExtensionsBlock : ITerraformBlock
{
    /// <summary>
    /// Optional. A set of named X.509 extensions. Will be combined with additional_extensions to determine the full set of X.509 extensions.
    /// </summary>
    [TerraformPropertyName("known_extensions")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? KnownExtensions { get; set; }

}

/// <summary>
/// Block type for predefined_values in .
/// Nesting mode: list
/// </summary>
public class GooglePrivatecaCertificateTemplatePredefinedValuesBlock : ITerraformBlock
{
    /// <summary>
    /// Optional. Describes Online Certificate Status Protocol (OCSP) endpoint addresses that appear in the &amp;quot;Authority Information Access&amp;quot; extension in the certificate.
    /// </summary>
    [TerraformPropertyName("aia_ocsp_servers")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? AiaOcspServers { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GooglePrivatecaCertificateTemplateTimeoutsBlock : ITerraformBlock
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
/// Manages a google_privateca_certificate_template resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GooglePrivatecaCertificateTemplate : TerraformResource
{
    public GooglePrivatecaCertificateTemplate(string name) : base("google_privateca_certificate_template", name)
    {
    }

    /// <summary>
    /// Optional. A human-readable description of scenarios this template is intended for.
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
    /// Optional. Labels with user-defined metadata.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformPropertyName("labels")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Labels { get; set; }

    /// <summary>
    /// The location for the resource
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Location { get; set; }

    /// <summary>
    /// Optional. The maximum lifetime allowed for all issued certificates that use this template. If the issuing CaPool&#39;s IssuancePolicy specifies a maximum lifetime the minimum of the two durations will be the maximum lifetime for issued. Note that if the issuing CertificateAuthority expires before a Certificate&#39;s requested maximum_lifetime, the effective lifetime will be explicitly truncated to match it.
    /// </summary>
    [TerraformPropertyName("maximum_lifetime")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? MaximumLifetime { get; set; }

    /// <summary>
    /// The resource name for this CertificateTemplate in the format &#39;projects/*/locations/*/certificateTemplates/*&#39;.
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
    /// Block for identity_constraints.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IdentityConstraints block(s) allowed")]
    [TerraformPropertyName("identity_constraints")]
    public TerraformList<TerraformBlock<GooglePrivatecaCertificateTemplateIdentityConstraintsBlock>>? IdentityConstraints { get; set; } = new();

    /// <summary>
    /// Block for passthrough_extensions.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PassthroughExtensions block(s) allowed")]
    [TerraformPropertyName("passthrough_extensions")]
    public TerraformList<TerraformBlock<GooglePrivatecaCertificateTemplatePassthroughExtensionsBlock>>? PassthroughExtensions { get; set; } = new();

    /// <summary>
    /// Block for predefined_values.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PredefinedValues block(s) allowed")]
    [TerraformPropertyName("predefined_values")]
    public TerraformList<TerraformBlock<GooglePrivatecaCertificateTemplatePredefinedValuesBlock>>? PredefinedValues { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GooglePrivatecaCertificateTemplateTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// Output only. The time at which this CertificateTemplate was created.
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
    /// Output only. The time at which this CertificateTemplate was updated.
    /// </summary>
    [TerraformPropertyName("update_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> UpdateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "update_time");

}
