using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_privateca_certificate_authority Terraform data source.
/// Retrieves information about a google_privateca_certificate_authority.
/// </summary>
public partial class GooglePrivatecaCertificateAuthorityDataSource(string name) : TerraformDataSource("google_privateca_certificate_authority", name)
{
    /// <summary>
    /// The user provided Resource ID for this Certificate Authority.
    /// </summary>
    public TerraformValue<string>? CertificateAuthorityId
    {
        get => new TerraformReference<string>(this, "certificate_authority_id");
        set => SetArgument("certificate_authority_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Location of the CertificateAuthority. A full list of valid locations can be found by
    /// running &#39;gcloud privateca locations list&#39;.
    /// </summary>
    public TerraformValue<string>? Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The name of the CaPool this Certificate Authority belongs to.
    /// </summary>
    public TerraformValue<string>? Pool
    {
        get => new TerraformReference<string>(this, "pool");
        set => SetArgument("pool", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string>? Project
    {
        get => new TerraformReference<string>(this, "project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// URLs for accessing content published by this CA, such as the CA certificate and CRLs.
    /// </summary>
    public TerraformList<TerraformMap<object>> AccessUrls
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "access_urls").ResolveNodes(ctx));
    }

    /// <summary>
    /// The config used to create a self-signed X.509 certificate or CSR.
    /// </summary>
    public TerraformList<TerraformMap<object>> Config
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "config").ResolveNodes(ctx));
    }

    /// <summary>
    /// The time at which this CertificateAuthority was created.
    /// 
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine
    /// fractional digits. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    public TerraformValue<string> CreateTime
    {
        get => new TerraformReference<string>(this, "create_time");
    }

    /// <summary>
    /// Whether Terraform will be prevented from destroying the CertificateAuthority.
    /// When the field is set to true or unset in Terraform state, a &#39;terraform apply&#39;
    /// or &#39;terraform destroy&#39; that would delete the CertificateAuthority will fail.
    /// When the field is set to false, deleting the CertificateAuthority is allowed.
    /// </summary>
    public TerraformValue<bool> DeletionProtection
    {
        get => new TerraformReference<bool>(this, "deletion_protection");
    }

    /// <summary>
    /// Desired state of the CertificateAuthority. Set this field to &#39;STAGED&#39; to create a &#39;STAGED&#39; root CA.
    /// Possible values: ENABLED, DISABLED, STAGED.
    /// </summary>
    public TerraformValue<string> DesiredState
    {
        get => new TerraformReference<string>(this, "desired_state");
    }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "effective_labels").ResolveNodes(ctx));
    }

    /// <summary>
    /// The name of a Cloud Storage bucket where this CertificateAuthority will publish content,
    /// such as the CA certificate and CRLs. This must be a bucket name, without any prefixes
    /// (such as &#39;gs://&#39;) or suffixes (such as &#39;.googleapis.com&#39;). For example, to use a bucket named
    /// my-bucket, you would simply specify &#39;my-bucket&#39;. If not specified, a managed bucket will be
    /// created.
    /// </summary>
    public TerraformValue<string> GcsBucket
    {
        get => new TerraformReference<string>(this, "gcs_bucket");
    }

    /// <summary>
    /// This field allows the CA to be deleted even if the CA has active certs. Active certs include both unrevoked and unexpired certs.
    /// Use with care. Defaults to &#39;false&#39;.
    /// </summary>
    public TerraformValue<bool> IgnoreActiveCertificatesOnDeletion
    {
        get => new TerraformReference<bool>(this, "ignore_active_certificates_on_deletion");
    }

    /// <summary>
    /// Used when issuing certificates for this CertificateAuthority. If this CertificateAuthority
    /// is a self-signed CertificateAuthority, this key is also used to sign the self-signed CA
    /// certificate. Otherwise, it is used to sign a CSR.
    /// </summary>
    public TerraformList<TerraformMap<object>> KeySpec
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "key_spec").ResolveNodes(ctx));
    }

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
    public TerraformMap<string> Labels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "labels").ResolveNodes(ctx));
    }

    /// <summary>
    /// The desired lifetime of the CA certificate. Used to create the &amp;quot;notBeforeTime&amp;quot; and
    /// &amp;quot;notAfterTime&amp;quot; fields inside an X.509 certificate. A duration in seconds with up to nine
    /// fractional digits, terminated by &#39;s&#39;. Example: &amp;quot;3.5s&amp;quot;.
    /// </summary>
    public TerraformValue<string> Lifetime
    {
        get => new TerraformReference<string>(this, "lifetime");
    }

    /// <summary>
    /// The resource name for this CertificateAuthority in the format
    /// projects/*/locations/*/certificateAuthorities/*.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
    }

    /// <summary>
    /// The signed CA certificate issued from the subordinated CA&#39;s CSR. This is needed when activating the subordiante CA with a third party issuer.
    /// </summary>
    public TerraformValue<string> PemCaCertificate
    {
        get => new TerraformReference<string>(this, "pem_ca_certificate");
    }

    /// <summary>
    /// This CertificateAuthority&#39;s certificate chain, including the current
    /// CertificateAuthority&#39;s certificate. Ordered such that the root issuer is the final
    /// element (consistent with RFC 5246). For a self-signed CA, this will only list the current
    /// CertificateAuthority&#39;s certificate.
    /// </summary>
    public TerraformList<string> PemCaCertificates
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "pem_ca_certificates").ResolveNodes(ctx));
    }

    /// <summary>
    /// The pem_csr attribute.
    /// </summary>
    public TerraformValue<string> PemCsr
    {
        get => new TerraformReference<string>(this, "pem_csr");
    }

    /// <summary>
    /// If this flag is set, the Certificate Authority will be deleted as soon as
    /// possible without a 30-day grace period where undeletion would have been
    /// allowed. If you proceed, there will be no way to recover this CA.
    /// Use with care. Defaults to &#39;false&#39;.
    /// </summary>
    public TerraformValue<bool> SkipGracePeriod
    {
        get => new TerraformReference<bool>(this, "skip_grace_period");
    }

    /// <summary>
    /// The State for this CertificateAuthority.
    /// </summary>
    public TerraformValue<string> State
    {
        get => new TerraformReference<string>(this, "state");
    }

    /// <summary>
    /// If this is a subordinate CertificateAuthority, this field will be set
    /// with the subordinate configuration, which describes its issuers.
    /// </summary>
    public TerraformList<TerraformMap<object>> SubordinateConfig
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "subordinate_config").ResolveNodes(ctx));
    }

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "terraform_labels").ResolveNodes(ctx));
    }

    /// <summary>
    /// The Type of this CertificateAuthority.
    /// 
    /// ~&amp;gt; **Note:** For &#39;SUBORDINATE&#39; Certificate Authorities, they need to
    /// be activated before they can issue certificates. Default value: &amp;quot;SELF_SIGNED&amp;quot; Possible values: [&amp;quot;SELF_SIGNED&amp;quot;, &amp;quot;SUBORDINATE&amp;quot;]
    /// </summary>
    public TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
    }

    /// <summary>
    /// The time at which this CertificateAuthority was updated.
    /// 
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine
    /// fractional digits. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    public TerraformValue<string> UpdateTime
    {
        get => new TerraformReference<string>(this, "update_time");
    }

    /// <summary>
    /// Custom URLs for accessing content published by this CA, such as the CA certificate and CRLs,
    /// that can be specified by users.
    /// </summary>
    public TerraformList<TerraformMap<object>> UserDefinedAccessUrls
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "user_defined_access_urls").ResolveNodes(ctx));
    }

}
