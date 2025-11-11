using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_privateca_certificate_authority.
/// </summary>
public partial class GooglePrivatecaCertificateAuthorityDataSource : TerraformDataSource
{
    public GooglePrivatecaCertificateAuthorityDataSource(string name) : base("google_privateca_certificate_authority", name)
    {
    }

    /// <summary>
    /// The user provided Resource ID for this Certificate Authority.
    /// </summary>
    [TerraformProperty("certificate_authority_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? CertificateAuthorityId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Location of the CertificateAuthority. A full list of valid locations can be found by
    /// running &#39;gcloud privateca locations list&#39;.
    /// </summary>
    [TerraformProperty("location")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Location { get; set; }

    /// <summary>
    /// The name of the CaPool this Certificate Authority belongs to.
    /// </summary>
    [TerraformProperty("pool")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Pool { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Project { get; set; }

    /// <summary>
    /// URLs for accessing content published by this CA, such as the CA certificate and CRLs.
    /// </summary>
    [TerraformProperty("access_urls")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> AccessUrls { get; }

    /// <summary>
    /// The config used to create a self-signed X.509 certificate or CSR.
    /// </summary>
    [TerraformProperty("config")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> Config { get; }

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
    /// Whether Terraform will be prevented from destroying the CertificateAuthority.
    /// When the field is set to true or unset in Terraform state, a &#39;terraform apply&#39;
    /// or &#39;terraform destroy&#39; that would delete the CertificateAuthority will fail.
    /// When the field is set to false, deleting the CertificateAuthority is allowed.
    /// </summary>
    [TerraformProperty("deletion_protection")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> DeletionProtection { get; }

    /// <summary>
    /// Desired state of the CertificateAuthority. Set this field to &#39;STAGED&#39; to create a &#39;STAGED&#39; root CA.
    /// Possible values: ENABLED, DISABLED, STAGED.
    /// </summary>
    [TerraformProperty("desired_state")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DesiredState { get; }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformProperty("effective_labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> EffectiveLabels { get; }

    /// <summary>
    /// The name of a Cloud Storage bucket where this CertificateAuthority will publish content,
    /// such as the CA certificate and CRLs. This must be a bucket name, without any prefixes
    /// (such as &#39;gs://&#39;) or suffixes (such as &#39;.googleapis.com&#39;). For example, to use a bucket named
    /// my-bucket, you would simply specify &#39;my-bucket&#39;. If not specified, a managed bucket will be
    /// created.
    /// </summary>
    [TerraformProperty("gcs_bucket")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> GcsBucket { get; }

    /// <summary>
    /// This field allows the CA to be deleted even if the CA has active certs. Active certs include both unrevoked and unexpired certs.
    /// Use with care. Defaults to &#39;false&#39;.
    /// </summary>
    [TerraformProperty("ignore_active_certificates_on_deletion")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> IgnoreActiveCertificatesOnDeletion { get; }

    /// <summary>
    /// Used when issuing certificates for this CertificateAuthority. If this CertificateAuthority
    /// is a self-signed CertificateAuthority, this key is also used to sign the self-signed CA
    /// certificate. Otherwise, it is used to sign a CSR.
    /// </summary>
    [TerraformProperty("key_spec")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> KeySpec { get; }

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
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> Labels { get; }

    /// <summary>
    /// The desired lifetime of the CA certificate. Used to create the &amp;quot;notBeforeTime&amp;quot; and
    /// &amp;quot;notAfterTime&amp;quot; fields inside an X.509 certificate. A duration in seconds with up to nine
    /// fractional digits, terminated by &#39;s&#39;. Example: &amp;quot;3.5s&amp;quot;.
    /// </summary>
    [TerraformProperty("lifetime")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Lifetime { get; }

    /// <summary>
    /// The resource name for this CertificateAuthority in the format
    /// projects/*/locations/*/certificateAuthorities/*.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Name { get; }

    /// <summary>
    /// The signed CA certificate issued from the subordinated CA&#39;s CSR. This is needed when activating the subordiante CA with a third party issuer.
    /// </summary>
    [TerraformProperty("pem_ca_certificate")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PemCaCertificate { get; }

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
    /// The pem_csr attribute.
    /// </summary>
    [TerraformProperty("pem_csr")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PemCsr { get; }

    /// <summary>
    /// If this flag is set, the Certificate Authority will be deleted as soon as
    /// possible without a 30-day grace period where undeletion would have been
    /// allowed. If you proceed, there will be no way to recover this CA.
    /// Use with care. Defaults to &#39;false&#39;.
    /// </summary>
    [TerraformProperty("skip_grace_period")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> SkipGracePeriod { get; }

    /// <summary>
    /// The State for this CertificateAuthority.
    /// </summary>
    [TerraformProperty("state")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> State { get; }

    /// <summary>
    /// If this is a subordinate CertificateAuthority, this field will be set
    /// with the subordinate configuration, which describes its issuers.
    /// </summary>
    [TerraformProperty("subordinate_config")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> SubordinateConfig { get; }

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformProperty("terraform_labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> TerraformLabels { get; }

    /// <summary>
    /// The Type of this CertificateAuthority.
    /// 
    /// ~&amp;gt; **Note:** For &#39;SUBORDINATE&#39; Certificate Authorities, they need to
    /// be activated before they can issue certificates. Default value: &amp;quot;SELF_SIGNED&amp;quot; Possible values: [&amp;quot;SELF_SIGNED&amp;quot;, &amp;quot;SUBORDINATE&amp;quot;]
    /// </summary>
    [TerraformProperty("type")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Type { get; }

    /// <summary>
    /// The time at which this CertificateAuthority was updated.
    /// 
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine
    /// fractional digits. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    [TerraformProperty("update_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> UpdateTime { get; }

    /// <summary>
    /// Custom URLs for accessing content published by this CA, such as the CA certificate and CRLs,
    /// that can be specified by users.
    /// </summary>
    [TerraformProperty("user_defined_access_urls")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> UserDefinedAccessUrls { get; }

}
