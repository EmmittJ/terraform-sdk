using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for encryption_spec in .
/// Nesting mode: list
/// </summary>
public partial class GooglePrivatecaCaPoolEncryptionSpecBlock : TerraformBlockBase
{
    /// <summary>
    /// The resource name for an existing Cloud KMS key in the format
    /// &#39;projects/*/locations/*/keyRings/*/cryptoKeys/*&#39;.
    /// </summary>
    [TerraformProperty("cloud_kms_key")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? CloudKmsKey { get; set; }

}

/// <summary>
/// Block type for issuance_policy in .
/// Nesting mode: list
/// </summary>
public partial class GooglePrivatecaCaPoolIssuancePolicyBlock : TerraformBlockBase
{
    /// <summary>
    /// The duration to backdate all certificates issued from this CaPool. If not set, the
    /// certificates will be issued with a not_before_time of the issuance time (i.e. the current
    /// time). If set, the certificates will be issued with a not_before_time of the issuance
    /// time minus the backdate_duration. The not_after_time will be adjusted to preserve the
    /// requested lifetime. The backdate_duration must be less than or equal to 48 hours.
    /// </summary>
    [TerraformProperty("backdate_duration")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? BackdateDuration { get; set; }

    /// <summary>
    /// The maximum lifetime allowed for issued Certificates. Note that if the issuing CertificateAuthority
    /// expires before a Certificate&#39;s requested maximumLifetime, the effective lifetime will be explicitly truncated to match it.
    /// </summary>
    [TerraformProperty("maximum_lifetime")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? MaximumLifetime { get; set; }

}

/// <summary>
/// Block type for publishing_options in .
/// Nesting mode: list
/// </summary>
public partial class GooglePrivatecaCaPoolPublishingOptionsBlock : TerraformBlockBase
{
    /// <summary>
    /// Specifies the encoding format of each CertificateAuthority&#39;s CA
    /// certificate and CRLs. If this is omitted, CA certificates and CRLs
    /// will be published in PEM. Possible values: [&amp;quot;PEM&amp;quot;, &amp;quot;DER&amp;quot;]
    /// </summary>
    [TerraformProperty("encoding_format")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? EncodingFormat { get; set; }

    /// <summary>
    /// When true, publishes each CertificateAuthority&#39;s CA certificate and includes its URL in the &amp;quot;Authority Information Access&amp;quot;
    /// X.509 extension in all issued Certificates. If this is false, the CA certificate will not be published and the corresponding
    /// X.509 extension will not be written in issued certificates.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PublishCaCert is required")]
    [TerraformProperty("publish_ca_cert")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<bool> PublishCaCert { get; set; }

    /// <summary>
    /// When true, publishes each CertificateAuthority&#39;s CRL and includes its URL in the &amp;quot;CRL Distribution Points&amp;quot; X.509 extension
    /// in all issued Certificates. If this is false, CRLs will not be published and the corresponding X.509 extension will not
    /// be written in issued certificates. CRLs will expire 7 days from their creation. However, we will rebuild daily. CRLs are
    /// also rebuilt shortly after a certificate is revoked.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PublishCrl is required")]
    [TerraformProperty("publish_crl")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<bool> PublishCrl { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GooglePrivatecaCaPoolTimeoutsBlock : TerraformBlockBase
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
/// Manages a google_privateca_ca_pool resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GooglePrivatecaCaPool : TerraformResource
{
    public GooglePrivatecaCaPool(string name) : base("google_privateca_ca_pool", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Labels with user-defined metadata.
    /// 
    /// An object containing a list of &amp;quot;key&amp;quot;: value pairs. Example: { &amp;quot;name&amp;quot;: &amp;quot;wrench&amp;quot;, &amp;quot;mass&amp;quot;:
    /// &amp;quot;1.3kg&amp;quot;, &amp;quot;count&amp;quot;: &amp;quot;3&amp;quot; }.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformProperty("labels")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Labels { get; set; }

    /// <summary>
    /// Location of the CaPool. A full list of valid locations can be found by
    /// running &#39;gcloud privateca locations list&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The name for this CaPool.
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
    /// The Tier of this CaPool. Possible values: [&amp;quot;ENTERPRISE&amp;quot;, &amp;quot;DEVOPS&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Tier is required")]
    [TerraformProperty("tier")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Tier { get; set; }

    /// <summary>
    /// Block for encryption_spec.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EncryptionSpec block(s) allowed")]
    [TerraformProperty("encryption_spec")]
    public partial TerraformList<TerraformBlock<GooglePrivatecaCaPoolEncryptionSpecBlock>>? EncryptionSpec { get; set; }

    /// <summary>
    /// Block for issuance_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IssuancePolicy block(s) allowed")]
    [TerraformProperty("issuance_policy")]
    public partial TerraformList<TerraformBlock<GooglePrivatecaCaPoolIssuancePolicyBlock>>? IssuancePolicy { get; set; }

    /// <summary>
    /// Block for publishing_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PublishingOptions block(s) allowed")]
    [TerraformProperty("publishing_options")]
    public partial TerraformList<TerraformBlock<GooglePrivatecaCaPoolPublishingOptionsBlock>>? PublishingOptions { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<GooglePrivatecaCaPoolTimeoutsBlock>? Timeouts { get; set; }

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

}
