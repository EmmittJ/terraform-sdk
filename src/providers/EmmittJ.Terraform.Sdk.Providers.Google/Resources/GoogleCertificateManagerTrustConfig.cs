using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for allowlisted_certificates in .
/// Nesting mode: list
/// </summary>
public class GoogleCertificateManagerTrustConfigAllowlistedCertificatesBlock : ITerraformBlock
{
    /// <summary>
    /// PEM certificate that is allowlisted. The certificate can be up to 5k bytes, and must be a parseable X.509 certificate.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PemCertificate is required")]
    [TerraformPropertyName("pem_certificate")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> PemCertificate { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleCertificateManagerTrustConfigTimeoutsBlock : ITerraformBlock
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
/// Block type for trust_stores in .
/// Nesting mode: list
/// </summary>
public class GoogleCertificateManagerTrustConfigTrustStoresBlock : ITerraformBlock
{
}

/// <summary>
/// Manages a google_certificate_manager_trust_config resource.
/// </summary>
public class GoogleCertificateManagerTrustConfig : TerraformResource
{
    public GoogleCertificateManagerTrustConfig(string name) : base("google_certificate_manager_trust_config", name)
    {
    }

    /// <summary>
    /// One or more paragraphs of text description of a trust config.
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
    /// Set of label tags associated with the trust config.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformPropertyName("labels")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Labels { get; set; }

    /// <summary>
    /// The trust config location.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Location { get; set; }

    /// <summary>
    /// A user-defined name of the trust config. Trust config names must be unique globally.
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
    /// Block for allowlisted_certificates.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("allowlisted_certificates")]
    public TerraformList<TerraformBlock<GoogleCertificateManagerTrustConfigAllowlistedCertificatesBlock>>? AllowlistedCertificates { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleCertificateManagerTrustConfigTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// Block for trust_stores.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("trust_stores")]
    public TerraformList<TerraformBlock<GoogleCertificateManagerTrustConfigTrustStoresBlock>>? TrustStores { get; set; } = new();

    /// <summary>
    /// The creation timestamp of a TrustConfig.
    /// 
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional digits.
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
    /// The last update timestamp of a TrustConfig.
    /// 
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional digits.
    /// Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    [TerraformPropertyName("update_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> UpdateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "update_time");

}
