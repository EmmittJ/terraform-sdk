using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for config in .
/// Nesting mode: list
/// </summary>
public class GooglePrivatecaCertificateAuthorityConfigBlock
{
}

/// <summary>
/// Block type for key_spec in .
/// Nesting mode: list
/// </summary>
public class GooglePrivatecaCertificateAuthorityKeySpecBlock
{
    /// <summary>
    /// The algorithm to use for creating a managed Cloud KMS key for a for a simplified
    /// experience. All managed keys will be have their ProtectionLevel as HSM. Possible values: [&amp;quot;SIGN_HASH_ALGORITHM_UNSPECIFIED&amp;quot;, &amp;quot;RSA_PSS_2048_SHA256&amp;quot;, &amp;quot;RSA_PSS_3072_SHA256&amp;quot;, &amp;quot;RSA_PSS_4096_SHA256&amp;quot;, &amp;quot;RSA_PKCS1_2048_SHA256&amp;quot;, &amp;quot;RSA_PKCS1_3072_SHA256&amp;quot;, &amp;quot;RSA_PKCS1_4096_SHA256&amp;quot;, &amp;quot;EC_P256_SHA256&amp;quot;, &amp;quot;EC_P384_SHA384&amp;quot;]
    /// </summary>
    [TerraformPropertyName("algorithm")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Algorithm { get; set; }

    /// <summary>
    /// The resource name for an existing Cloud KMS CryptoKeyVersion in the format
    /// &#39;projects/*/locations/*/keyRings/*/cryptoKeys/*/cryptoKeyVersions/*&#39;.
    /// </summary>
    [TerraformPropertyName("cloud_kms_key_version")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? CloudKmsKeyVersion { get; set; }

}

/// <summary>
/// Block type for subordinate_config in .
/// Nesting mode: list
/// </summary>
public class GooglePrivatecaCertificateAuthoritySubordinateConfigBlock
{
    /// <summary>
    /// This can refer to a CertificateAuthority that was used to create a
    /// subordinate CertificateAuthority. This field is used for information
    /// and usability purposes only. The resource name is in the format
    /// &#39;projects/*/locations/*/caPools/*/certificateAuthorities/*&#39;.
    /// </summary>
    [TerraformPropertyName("certificate_authority")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? CertificateAuthority { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GooglePrivatecaCertificateAuthorityTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Block type for user_defined_access_urls in .
/// Nesting mode: list
/// </summary>
public class GooglePrivatecaCertificateAuthorityUserDefinedAccessUrlsBlock
{
    /// <summary>
    /// A list of URLs where this CertificateAuthority&#39;s CA certificate is published that is specified by users.
    /// </summary>
    [TerraformPropertyName("aia_issuing_certificate_urls")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? AiaIssuingCertificateUrls { get; set; }

    /// <summary>
    /// A list of URLs where this CertificateAuthority&#39;s CRLs are published that is specified by users.
    /// </summary>
    [TerraformPropertyName("crl_access_urls")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? CrlAccessUrls { get; set; }

}

/// <summary>
/// Manages a google_privateca_certificate_authority resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GooglePrivatecaCertificateAuthority : TerraformResource
{
    public GooglePrivatecaCertificateAuthority(string name) : base("google_privateca_certificate_authority", name)
    {
    }

    /// <summary>
    /// The user provided Resource ID for this Certificate Authority.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CertificateAuthorityId is required")]
    [TerraformPropertyName("certificate_authority_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> CertificateAuthorityId { get; set; }

    /// <summary>
    /// Whether Terraform will be prevented from destroying the CertificateAuthority.
    /// When the field is set to true or unset in Terraform state, a &#39;terraform apply&#39;
    /// or &#39;terraform destroy&#39; that would delete the CertificateAuthority will fail.
    /// When the field is set to false, deleting the CertificateAuthority is allowed.
    /// </summary>
    [TerraformPropertyName("deletion_protection")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? DeletionProtection { get; set; }

    /// <summary>
    /// Desired state of the CertificateAuthority. Set this field to &#39;STAGED&#39; to create a &#39;STAGED&#39; root CA.
    /// Possible values: ENABLED, DISABLED, STAGED.
    /// </summary>
    [TerraformPropertyName("desired_state")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DesiredState { get; set; }

    /// <summary>
    /// The name of a Cloud Storage bucket where this CertificateAuthority will publish content,
    /// such as the CA certificate and CRLs. This must be a bucket name, without any prefixes
    /// (such as &#39;gs://&#39;) or suffixes (such as &#39;.googleapis.com&#39;). For example, to use a bucket named
    /// my-bucket, you would simply specify &#39;my-bucket&#39;. If not specified, a managed bucket will be
    /// created.
    /// </summary>
    [TerraformPropertyName("gcs_bucket")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? GcsBucket { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// This field allows the CA to be deleted even if the CA has active certs. Active certs include both unrevoked and unexpired certs.
    /// Use with care. Defaults to &#39;false&#39;.
    /// </summary>
    [TerraformPropertyName("ignore_active_certificates_on_deletion")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? IgnoreActiveCertificatesOnDeletion { get; set; }

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
    [TerraformPropertyName("labels")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Labels { get; set; }

    /// <summary>
    /// The desired lifetime of the CA certificate. Used to create the &amp;quot;notBeforeTime&amp;quot; and
    /// &amp;quot;notAfterTime&amp;quot; fields inside an X.509 certificate. A duration in seconds with up to nine
    /// fractional digits, terminated by &#39;s&#39;. Example: &amp;quot;3.5s&amp;quot;.
    /// </summary>
    [TerraformPropertyName("lifetime")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Lifetime { get; set; }

    /// <summary>
    /// Location of the CertificateAuthority. A full list of valid locations can be found by
    /// running &#39;gcloud privateca locations list&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The signed CA certificate issued from the subordinated CA&#39;s CSR. This is needed when activating the subordiante CA with a third party issuer.
    /// </summary>
    [TerraformPropertyName("pem_ca_certificate")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? PemCaCertificate { get; set; }

    /// <summary>
    /// The name of the CaPool this Certificate Authority belongs to.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Pool is required")]
    [TerraformPropertyName("pool")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Pool { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Project { get; set; } = default!;

    /// <summary>
    /// If this flag is set, the Certificate Authority will be deleted as soon as
    /// possible without a 30-day grace period where undeletion would have been
    /// allowed. If you proceed, there will be no way to recover this CA.
    /// Use with care. Defaults to &#39;false&#39;.
    /// </summary>
    [TerraformPropertyName("skip_grace_period")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? SkipGracePeriod { get; set; }

    /// <summary>
    /// The Type of this CertificateAuthority.
    /// 
    /// ~&amp;gt; **Note:** For &#39;SUBORDINATE&#39; Certificate Authorities, they need to
    /// be activated before they can issue certificates. Default value: &amp;quot;SELF_SIGNED&amp;quot; Possible values: [&amp;quot;SELF_SIGNED&amp;quot;, &amp;quot;SUBORDINATE&amp;quot;]
    /// </summary>
    [TerraformPropertyName("type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Type { get; set; }

    /// <summary>
    /// Block for config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Config is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Config block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Config block(s) allowed")]
    [TerraformPropertyName("config")]
    public TerraformList<TerraformBlock<GooglePrivatecaCertificateAuthorityConfigBlock>>? Config { get; set; }

    /// <summary>
    /// Block for key_spec.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeySpec is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 KeySpec block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KeySpec block(s) allowed")]
    [TerraformPropertyName("key_spec")]
    public TerraformList<TerraformBlock<GooglePrivatecaCertificateAuthorityKeySpecBlock>>? KeySpec { get; set; }

    /// <summary>
    /// Block for subordinate_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SubordinateConfig block(s) allowed")]
    [TerraformPropertyName("subordinate_config")]
    public TerraformList<TerraformBlock<GooglePrivatecaCertificateAuthoritySubordinateConfigBlock>>? SubordinateConfig { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GooglePrivatecaCertificateAuthorityTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Block for user_defined_access_urls.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 UserDefinedAccessUrls block(s) allowed")]
    [TerraformPropertyName("user_defined_access_urls")]
    public TerraformList<TerraformBlock<GooglePrivatecaCertificateAuthorityUserDefinedAccessUrlsBlock>>? UserDefinedAccessUrls { get; set; }

    /// <summary>
    /// URLs for accessing content published by this CA, such as the CA certificate and CRLs.
    /// </summary>
    [TerraformPropertyName("access_urls")]
    // Output-only attribute - read-only reference
    public TerraformList<object> AccessUrls => new TerraformReference(this, "access_urls");

    /// <summary>
    /// The time at which this CertificateAuthority was created.
    /// 
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine
    /// fractional digits. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    [TerraformPropertyName("create_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CreateTime => new TerraformReference(this, "create_time");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformPropertyName("effective_labels")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> EffectiveLabels => new TerraformReference(this, "effective_labels");

    /// <summary>
    /// The resource name for this CertificateAuthority in the format
    /// projects/*/locations/*/certificateAuthorities/*.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Name => new TerraformReference(this, "name");

    /// <summary>
    /// This CertificateAuthority&#39;s certificate chain, including the current
    /// CertificateAuthority&#39;s certificate. Ordered such that the root issuer is the final
    /// element (consistent with RFC 5246). For a self-signed CA, this will only list the current
    /// CertificateAuthority&#39;s certificate.
    /// </summary>
    [TerraformPropertyName("pem_ca_certificates")]
    // Output-only attribute - read-only reference
    public TerraformList<string> PemCaCertificates => new TerraformReference(this, "pem_ca_certificates");

    /// <summary>
    /// The State for this CertificateAuthority.
    /// </summary>
    [TerraformPropertyName("state")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> State => new TerraformReference(this, "state");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformPropertyName("terraform_labels")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> TerraformLabels => new TerraformReference(this, "terraform_labels");

    /// <summary>
    /// The time at which this CertificateAuthority was updated.
    /// 
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine
    /// fractional digits. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    [TerraformPropertyName("update_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> UpdateTime => new TerraformReference(this, "update_time");

}
