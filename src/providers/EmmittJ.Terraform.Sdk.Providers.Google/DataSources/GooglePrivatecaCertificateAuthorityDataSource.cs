using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_privateca_certificate_authority.
/// </summary>
public class GooglePrivatecaCertificateAuthorityDataSource : TerraformDataSource
{
    public GooglePrivatecaCertificateAuthorityDataSource(string name) : base("google_privateca_certificate_authority", name)
    {
    }

    /// <summary>
    /// The user provided Resource ID for this Certificate Authority.
    /// </summary>
    [TerraformPropertyName("certificate_authority_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? CertificateAuthorityId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Location of the CertificateAuthority. A full list of valid locations can be found by
    /// running &#39;gcloud privateca locations list&#39;.
    /// </summary>
    [TerraformPropertyName("location")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Location { get; set; }

    /// <summary>
    /// The name of the CaPool this Certificate Authority belongs to.
    /// </summary>
    [TerraformPropertyName("pool")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Pool { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Project { get; set; }

    /// <summary>
    /// URLs for accessing content published by this CA, such as the CA certificate and CRLs.
    /// </summary>
    [TerraformPropertyName("access_urls")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> AccessUrls => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "access_urls");

    /// <summary>
    /// The config used to create a self-signed X.509 certificate or CSR.
    /// </summary>
    [TerraformPropertyName("config")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Config => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "config");

    /// <summary>
    /// The time at which this CertificateAuthority was created.
    /// 
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine
    /// fractional digits. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    [TerraformPropertyName("create_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "create_time");

    /// <summary>
    /// Whether Terraform will be prevented from destroying the CertificateAuthority.
    /// When the field is set to true or unset in Terraform state, a &#39;terraform apply&#39;
    /// or &#39;terraform destroy&#39; that would delete the CertificateAuthority will fail.
    /// When the field is set to false, deleting the CertificateAuthority is allowed.
    /// </summary>
    [TerraformPropertyName("deletion_protection")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> DeletionProtection => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "deletion_protection");

    /// <summary>
    /// Desired state of the CertificateAuthority. Set this field to &#39;STAGED&#39; to create a &#39;STAGED&#39; root CA.
    /// Possible values: ENABLED, DISABLED, STAGED.
    /// </summary>
    [TerraformPropertyName("desired_state")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DesiredState => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "desired_state");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformPropertyName("effective_labels")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> EffectiveLabels => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "effective_labels");

    /// <summary>
    /// The name of a Cloud Storage bucket where this CertificateAuthority will publish content,
    /// such as the CA certificate and CRLs. This must be a bucket name, without any prefixes
    /// (such as &#39;gs://&#39;) or suffixes (such as &#39;.googleapis.com&#39;). For example, to use a bucket named
    /// my-bucket, you would simply specify &#39;my-bucket&#39;. If not specified, a managed bucket will be
    /// created.
    /// </summary>
    [TerraformPropertyName("gcs_bucket")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> GcsBucket => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "gcs_bucket");

    /// <summary>
    /// This field allows the CA to be deleted even if the CA has active certs. Active certs include both unrevoked and unexpired certs.
    /// Use with care. Defaults to &#39;false&#39;.
    /// </summary>
    [TerraformPropertyName("ignore_active_certificates_on_deletion")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> IgnoreActiveCertificatesOnDeletion => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "ignore_active_certificates_on_deletion");

    /// <summary>
    /// Used when issuing certificates for this CertificateAuthority. If this CertificateAuthority
    /// is a self-signed CertificateAuthority, this key is also used to sign the self-signed CA
    /// certificate. Otherwise, it is used to sign a CSR.
    /// </summary>
    [TerraformPropertyName("key_spec")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> KeySpec => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "key_spec");

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
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Labels => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "labels");

    /// <summary>
    /// The desired lifetime of the CA certificate. Used to create the &amp;quot;notBeforeTime&amp;quot; and
    /// &amp;quot;notAfterTime&amp;quot; fields inside an X.509 certificate. A duration in seconds with up to nine
    /// fractional digits, terminated by &#39;s&#39;. Example: &amp;quot;3.5s&amp;quot;.
    /// </summary>
    [TerraformPropertyName("lifetime")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Lifetime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "lifetime");

    /// <summary>
    /// The resource name for this CertificateAuthority in the format
    /// projects/*/locations/*/certificateAuthorities/*.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Name => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

    /// <summary>
    /// The signed CA certificate issued from the subordinated CA&#39;s CSR. This is needed when activating the subordiante CA with a third party issuer.
    /// </summary>
    [TerraformPropertyName("pem_ca_certificate")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PemCaCertificate => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "pem_ca_certificate");

    /// <summary>
    /// This CertificateAuthority&#39;s certificate chain, including the current
    /// CertificateAuthority&#39;s certificate. Ordered such that the root issuer is the final
    /// element (consistent with RFC 5246). For a self-signed CA, this will only list the current
    /// CertificateAuthority&#39;s certificate.
    /// </summary>
    [TerraformPropertyName("pem_ca_certificates")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> PemCaCertificates => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "pem_ca_certificates");

    /// <summary>
    /// The pem_csr attribute.
    /// </summary>
    [TerraformPropertyName("pem_csr")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PemCsr => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "pem_csr");

    /// <summary>
    /// If this flag is set, the Certificate Authority will be deleted as soon as
    /// possible without a 30-day grace period where undeletion would have been
    /// allowed. If you proceed, there will be no way to recover this CA.
    /// Use with care. Defaults to &#39;false&#39;.
    /// </summary>
    [TerraformPropertyName("skip_grace_period")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> SkipGracePeriod => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "skip_grace_period");

    /// <summary>
    /// The State for this CertificateAuthority.
    /// </summary>
    [TerraformPropertyName("state")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> State => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "state");

    /// <summary>
    /// If this is a subordinate CertificateAuthority, this field will be set
    /// with the subordinate configuration, which describes its issuers.
    /// </summary>
    [TerraformPropertyName("subordinate_config")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> SubordinateConfig => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "subordinate_config");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformPropertyName("terraform_labels")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TerraformLabels => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "terraform_labels");

    /// <summary>
    /// The Type of this CertificateAuthority.
    /// 
    /// ~&amp;gt; **Note:** For &#39;SUBORDINATE&#39; Certificate Authorities, they need to
    /// be activated before they can issue certificates. Default value: &amp;quot;SELF_SIGNED&amp;quot; Possible values: [&amp;quot;SELF_SIGNED&amp;quot;, &amp;quot;SUBORDINATE&amp;quot;]
    /// </summary>
    [TerraformPropertyName("type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Type => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "type");

    /// <summary>
    /// The time at which this CertificateAuthority was updated.
    /// 
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine
    /// fractional digits. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    [TerraformPropertyName("update_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> UpdateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "update_time");

    /// <summary>
    /// Custom URLs for accessing content published by this CA, such as the CA certificate and CRLs,
    /// that can be specified by users.
    /// </summary>
    [TerraformPropertyName("user_defined_access_urls")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> UserDefinedAccessUrls => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "user_defined_access_urls");

}
