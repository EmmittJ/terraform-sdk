using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for config in .
/// Nesting mode: list
/// </summary>
public partial class GooglePrivatecaCertificateAuthorityConfigBlock : TerraformBlockBase
{
}

/// <summary>
/// Block type for key_spec in .
/// Nesting mode: list
/// </summary>
public partial class GooglePrivatecaCertificateAuthorityKeySpecBlock : TerraformBlockBase
{
    /// <summary>
    /// The algorithm to use for creating a managed Cloud KMS key for a for a simplified
    /// experience. All managed keys will be have their ProtectionLevel as HSM. Possible values: [&amp;quot;SIGN_HASH_ALGORITHM_UNSPECIFIED&amp;quot;, &amp;quot;RSA_PSS_2048_SHA256&amp;quot;, &amp;quot;RSA_PSS_3072_SHA256&amp;quot;, &amp;quot;RSA_PSS_4096_SHA256&amp;quot;, &amp;quot;RSA_PKCS1_2048_SHA256&amp;quot;, &amp;quot;RSA_PKCS1_3072_SHA256&amp;quot;, &amp;quot;RSA_PKCS1_4096_SHA256&amp;quot;, &amp;quot;EC_P256_SHA256&amp;quot;, &amp;quot;EC_P384_SHA384&amp;quot;]
    /// </summary>
    [TerraformProperty("algorithm")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Algorithm { get; set; }

    /// <summary>
    /// The resource name for an existing Cloud KMS CryptoKeyVersion in the format
    /// &#39;projects/*/locations/*/keyRings/*/cryptoKeys/*/cryptoKeyVersions/*&#39;.
    /// </summary>
    [TerraformProperty("cloud_kms_key_version")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? CloudKmsKeyVersion { get; set; }

}

/// <summary>
/// Block type for subordinate_config in .
/// Nesting mode: list
/// </summary>
public partial class GooglePrivatecaCertificateAuthoritySubordinateConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// This can refer to a CertificateAuthority that was used to create a
    /// subordinate CertificateAuthority. This field is used for information
    /// and usability purposes only. The resource name is in the format
    /// &#39;projects/*/locations/*/caPools/*/certificateAuthorities/*&#39;.
    /// </summary>
    [TerraformProperty("certificate_authority")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? CertificateAuthority { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GooglePrivatecaCertificateAuthorityTimeoutsBlock : TerraformBlockBase
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
/// Block type for user_defined_access_urls in .
/// Nesting mode: list
/// </summary>
public partial class GooglePrivatecaCertificateAuthorityUserDefinedAccessUrlsBlock : TerraformBlockBase
{
    /// <summary>
    /// A list of URLs where this CertificateAuthority&#39;s CA certificate is published that is specified by users.
    /// </summary>
    [TerraformProperty("aia_issuing_certificate_urls")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? AiaIssuingCertificateUrls { get; set; }

    /// <summary>
    /// A list of URLs where this CertificateAuthority&#39;s CRLs are published that is specified by users.
    /// </summary>
    [TerraformProperty("crl_access_urls")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? CrlAccessUrls { get; set; }

}

/// <summary>
/// Manages a google_privateca_certificate_authority resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GooglePrivatecaCertificateAuthority : TerraformResource
{
    public GooglePrivatecaCertificateAuthority(string name) : base("google_privateca_certificate_authority", name)
    {
    }

    /// <summary>
    /// The user provided Resource ID for this Certificate Authority.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CertificateAuthorityId is required")]
    [TerraformProperty("certificate_authority_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> CertificateAuthorityId { get; set; }

    /// <summary>
    /// Whether Terraform will be prevented from destroying the CertificateAuthority.
    /// When the field is set to true or unset in Terraform state, a &#39;terraform apply&#39;
    /// or &#39;terraform destroy&#39; that would delete the CertificateAuthority will fail.
    /// When the field is set to false, deleting the CertificateAuthority is allowed.
    /// </summary>
    [TerraformProperty("deletion_protection")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? DeletionProtection { get; set; }

    /// <summary>
    /// Desired state of the CertificateAuthority. Set this field to &#39;STAGED&#39; to create a &#39;STAGED&#39; root CA.
    /// Possible values: ENABLED, DISABLED, STAGED.
    /// </summary>
    [TerraformProperty("desired_state")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DesiredState { get; set; }

    /// <summary>
    /// The name of a Cloud Storage bucket where this CertificateAuthority will publish content,
    /// such as the CA certificate and CRLs. This must be a bucket name, without any prefixes
    /// (such as &#39;gs://&#39;) or suffixes (such as &#39;.googleapis.com&#39;). For example, to use a bucket named
    /// my-bucket, you would simply specify &#39;my-bucket&#39;. If not specified, a managed bucket will be
    /// created.
    /// </summary>
    [TerraformProperty("gcs_bucket")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? GcsBucket { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// This field allows the CA to be deleted even if the CA has active certs. Active certs include both unrevoked and unexpired certs.
    /// Use with care. Defaults to &#39;false&#39;.
    /// </summary>
    [TerraformProperty("ignore_active_certificates_on_deletion")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? IgnoreActiveCertificatesOnDeletion { get; set; }

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
    /// The desired lifetime of the CA certificate. Used to create the &amp;quot;notBeforeTime&amp;quot; and
    /// &amp;quot;notAfterTime&amp;quot; fields inside an X.509 certificate. A duration in seconds with up to nine
    /// fractional digits, terminated by &#39;s&#39;. Example: &amp;quot;3.5s&amp;quot;.
    /// </summary>
    [TerraformProperty("lifetime")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Lifetime { get; set; }

    /// <summary>
    /// Location of the CertificateAuthority. A full list of valid locations can be found by
    /// running &#39;gcloud privateca locations list&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The signed CA certificate issued from the subordinated CA&#39;s CSR. This is needed when activating the subordiante CA with a third party issuer.
    /// </summary>
    [TerraformProperty("pem_ca_certificate")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? PemCaCertificate { get; set; }

    /// <summary>
    /// The name of the CaPool this Certificate Authority belongs to.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Pool is required")]
    [TerraformProperty("pool")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Pool { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// If this flag is set, the Certificate Authority will be deleted as soon as
    /// possible without a 30-day grace period where undeletion would have been
    /// allowed. If you proceed, there will be no way to recover this CA.
    /// Use with care. Defaults to &#39;false&#39;.
    /// </summary>
    [TerraformProperty("skip_grace_period")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? SkipGracePeriod { get; set; }

    /// <summary>
    /// The Type of this CertificateAuthority.
    /// 
    /// ~&amp;gt; **Note:** For &#39;SUBORDINATE&#39; Certificate Authorities, they need to
    /// be activated before they can issue certificates. Default value: &amp;quot;SELF_SIGNED&amp;quot; Possible values: [&amp;quot;SELF_SIGNED&amp;quot;, &amp;quot;SUBORDINATE&amp;quot;]
    /// </summary>
    [TerraformProperty("type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Type { get; set; }

    /// <summary>
    /// Block for config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Config is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Config block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Config block(s) allowed")]
    [TerraformProperty("config")]
    public partial TerraformList<TerraformBlock<GooglePrivatecaCertificateAuthorityConfigBlock>>? Config { get; set; }

    /// <summary>
    /// Block for key_spec.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeySpec is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 KeySpec block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KeySpec block(s) allowed")]
    [TerraformProperty("key_spec")]
    public partial TerraformList<TerraformBlock<GooglePrivatecaCertificateAuthorityKeySpecBlock>>? KeySpec { get; set; }

    /// <summary>
    /// Block for subordinate_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SubordinateConfig block(s) allowed")]
    [TerraformProperty("subordinate_config")]
    public partial TerraformList<TerraformBlock<GooglePrivatecaCertificateAuthoritySubordinateConfigBlock>>? SubordinateConfig { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<GooglePrivatecaCertificateAuthorityTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Block for user_defined_access_urls.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 UserDefinedAccessUrls block(s) allowed")]
    [TerraformProperty("user_defined_access_urls")]
    public partial TerraformList<TerraformBlock<GooglePrivatecaCertificateAuthorityUserDefinedAccessUrlsBlock>>? UserDefinedAccessUrls { get; set; }

    /// <summary>
    /// URLs for accessing content published by this CA, such as the CA certificate and CRLs.
    /// </summary>
    [TerraformProperty("access_urls")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> AccessUrls { get; }

    /// <summary>
    /// The time at which this CertificateAuthority was created.
    /// 
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine
    /// fractional digits. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
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
    /// The resource name for this CertificateAuthority in the format
    /// projects/*/locations/*/certificateAuthorities/*.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Name { get; }

    /// <summary>
    /// This CertificateAuthority&#39;s certificate chain, including the current
    /// CertificateAuthority&#39;s certificate. Ordered such that the root issuer is the final
    /// element (consistent with RFC 5246). For a self-signed CA, this will only list the current
    /// CertificateAuthority&#39;s certificate.
    /// </summary>
    [TerraformProperty("pem_ca_certificates")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> PemCaCertificates { get; }

    /// <summary>
    /// The State for this CertificateAuthority.
    /// </summary>
    [TerraformProperty("state")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> State { get; }

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformProperty("terraform_labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> TerraformLabels { get; }

    /// <summary>
    /// The time at which this CertificateAuthority was updated.
    /// 
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine
    /// fractional digits. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    [TerraformProperty("update_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> UpdateTime { get; }

}
