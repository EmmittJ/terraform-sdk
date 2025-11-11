using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for allowlisted_certificates in .
/// Nesting mode: list
/// </summary>
public partial class GoogleCertificateManagerTrustConfigAllowlistedCertificatesBlock : TerraformBlockBase
{
    /// <summary>
    /// PEM certificate that is allowlisted. The certificate can be up to 5k bytes, and must be a parseable X.509 certificate.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PemCertificate is required")]
    [TerraformProperty("pem_certificate")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> PemCertificate { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleCertificateManagerTrustConfigTimeoutsBlock : TerraformBlockBase
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
/// Block type for trust_stores in .
/// Nesting mode: list
/// </summary>
public partial class GoogleCertificateManagerTrustConfigTrustStoresBlock : TerraformBlockBase
{
}

/// <summary>
/// Manages a google_certificate_manager_trust_config resource.
/// </summary>
public partial class GoogleCertificateManagerTrustConfig : TerraformResource
{
    public GoogleCertificateManagerTrustConfig(string name) : base("google_certificate_manager_trust_config", name)
    {
    }

    /// <summary>
    /// One or more paragraphs of text description of a trust config.
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
    /// Set of label tags associated with the trust config.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformProperty("labels")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Labels { get; set; }

    /// <summary>
    /// The trust config location.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// A user-defined name of the trust config. Trust config names must be unique globally.
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
    /// Block for allowlisted_certificates.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("allowlisted_certificates")]
    public TerraformList<TerraformBlock<GoogleCertificateManagerTrustConfigAllowlistedCertificatesBlock>>? AllowlistedCertificates { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<GoogleCertificateManagerTrustConfigTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Block for trust_stores.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("trust_stores")]
    public TerraformList<TerraformBlock<GoogleCertificateManagerTrustConfigTrustStoresBlock>>? TrustStores { get; set; }

    /// <summary>
    /// The creation timestamp of a TrustConfig.
    /// 
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional digits.
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
    /// The last update timestamp of a TrustConfig.
    /// 
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional digits.
    /// Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    [TerraformProperty("update_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> UpdateTime { get; }

}
