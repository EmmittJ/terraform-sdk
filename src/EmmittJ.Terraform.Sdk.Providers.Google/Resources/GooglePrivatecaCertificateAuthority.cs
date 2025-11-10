using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for config in .
/// Nesting mode: list
/// </summary>
public class GooglePrivatecaCertificateAuthorityConfigBlock : TerraformBlock
{
}

/// <summary>
/// Block type for key_spec in .
/// Nesting mode: list
/// </summary>
public class GooglePrivatecaCertificateAuthorityKeySpecBlock : TerraformBlock
{
    /// <summary>
    /// The algorithm to use for creating a managed Cloud KMS key for a for a simplified
    /// experience. All managed keys will be have their ProtectionLevel as HSM. Possible values: [&amp;quot;SIGN_HASH_ALGORITHM_UNSPECIFIED&amp;quot;, &amp;quot;RSA_PSS_2048_SHA256&amp;quot;, &amp;quot;RSA_PSS_3072_SHA256&amp;quot;, &amp;quot;RSA_PSS_4096_SHA256&amp;quot;, &amp;quot;RSA_PKCS1_2048_SHA256&amp;quot;, &amp;quot;RSA_PKCS1_3072_SHA256&amp;quot;, &amp;quot;RSA_PKCS1_4096_SHA256&amp;quot;, &amp;quot;EC_P256_SHA256&amp;quot;, &amp;quot;EC_P384_SHA384&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? Algorithm
    {
        get => GetProperty<TerraformProperty<string>>("algorithm");
        set => WithProperty("algorithm", value);
    }

    /// <summary>
    /// The resource name for an existing Cloud KMS CryptoKeyVersion in the format
    /// &#39;projects/*/locations/*/keyRings/*/cryptoKeys/*/cryptoKeyVersions/*&#39;.
    /// </summary>
    public TerraformProperty<string>? CloudKmsKeyVersion
    {
        get => GetProperty<TerraformProperty<string>>("cloud_kms_key_version");
        set => WithProperty("cloud_kms_key_version", value);
    }

}

/// <summary>
/// Block type for subordinate_config in .
/// Nesting mode: list
/// </summary>
public class GooglePrivatecaCertificateAuthoritySubordinateConfigBlock : TerraformBlock
{
    /// <summary>
    /// This can refer to a CertificateAuthority that was used to create a
    /// subordinate CertificateAuthority. This field is used for information
    /// and usability purposes only. The resource name is in the format
    /// &#39;projects/*/locations/*/caPools/*/certificateAuthorities/*&#39;.
    /// </summary>
    public TerraformProperty<string>? CertificateAuthority
    {
        get => GetProperty<TerraformProperty<string>>("certificate_authority");
        set => WithProperty("certificate_authority", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GooglePrivatecaCertificateAuthorityTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Block type for user_defined_access_urls in .
/// Nesting mode: list
/// </summary>
public class GooglePrivatecaCertificateAuthorityUserDefinedAccessUrlsBlock : TerraformBlock
{
    /// <summary>
    /// A list of URLs where this CertificateAuthority&#39;s CA certificate is published that is specified by users.
    /// </summary>
    public List<TerraformProperty<string>>? AiaIssuingCertificateUrls
    {
        get => GetProperty<List<TerraformProperty<string>>>("aia_issuing_certificate_urls");
        set => WithProperty("aia_issuing_certificate_urls", value);
    }

    /// <summary>
    /// A list of URLs where this CertificateAuthority&#39;s CRLs are published that is specified by users.
    /// </summary>
    public List<TerraformProperty<string>>? CrlAccessUrls
    {
        get => GetProperty<List<TerraformProperty<string>>>("crl_access_urls");
        set => WithProperty("crl_access_urls", value);
    }

}

/// <summary>
/// Manages a google_privateca_certificate_authority resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GooglePrivatecaCertificateAuthority : TerraformResource
{
    public GooglePrivatecaCertificateAuthority(string name) : base("google_privateca_certificate_authority", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("access_urls");
        this.DeclareOutput("create_time");
        this.DeclareOutput("effective_labels");
        this.DeclareOutput("name");
        this.DeclareOutput("pem_ca_certificates");
        this.DeclareOutput("state");
        this.DeclareOutput("terraform_labels");
        this.DeclareOutput("update_time");
    }

    /// <summary>
    /// The user provided Resource ID for this Certificate Authority.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CertificateAuthorityId is required")]
    public required TerraformProperty<string> CertificateAuthorityId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("certificate_authority_id");
        set => this.WithProperty("certificate_authority_id", value);
    }

    /// <summary>
    /// Whether Terraform will be prevented from destroying the CertificateAuthority.
    /// When the field is set to true or unset in Terraform state, a &#39;terraform apply&#39;
    /// or &#39;terraform destroy&#39; that would delete the CertificateAuthority will fail.
    /// When the field is set to false, deleting the CertificateAuthority is allowed.
    /// </summary>
    public TerraformProperty<bool>? DeletionProtection
    {
        get => GetProperty<TerraformProperty<bool>>("deletion_protection");
        set => this.WithProperty("deletion_protection", value);
    }

    /// <summary>
    /// Desired state of the CertificateAuthority. Set this field to &#39;STAGED&#39; to create a &#39;STAGED&#39; root CA.
    /// Possible values: ENABLED, DISABLED, STAGED.
    /// </summary>
    public TerraformProperty<string>? DesiredState
    {
        get => GetProperty<TerraformProperty<string>>("desired_state");
        set => this.WithProperty("desired_state", value);
    }

    /// <summary>
    /// The name of a Cloud Storage bucket where this CertificateAuthority will publish content,
    /// such as the CA certificate and CRLs. This must be a bucket name, without any prefixes
    /// (such as &#39;gs://&#39;) or suffixes (such as &#39;.googleapis.com&#39;). For example, to use a bucket named
    /// my-bucket, you would simply specify &#39;my-bucket&#39;. If not specified, a managed bucket will be
    /// created.
    /// </summary>
    public TerraformProperty<string>? GcsBucket
    {
        get => GetProperty<TerraformProperty<string>>("gcs_bucket");
        set => this.WithProperty("gcs_bucket", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// This field allows the CA to be deleted even if the CA has active certs. Active certs include both unrevoked and unexpired certs.
    /// Use with care. Defaults to &#39;false&#39;.
    /// </summary>
    public TerraformProperty<bool>? IgnoreActiveCertificatesOnDeletion
    {
        get => GetProperty<TerraformProperty<bool>>("ignore_active_certificates_on_deletion");
        set => this.WithProperty("ignore_active_certificates_on_deletion", value);
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
    public Dictionary<string, TerraformProperty<string>>? Labels
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("labels");
        set => this.WithProperty("labels", value);
    }

    /// <summary>
    /// The desired lifetime of the CA certificate. Used to create the &amp;quot;notBeforeTime&amp;quot; and
    /// &amp;quot;notAfterTime&amp;quot; fields inside an X.509 certificate. A duration in seconds with up to nine
    /// fractional digits, terminated by &#39;s&#39;. Example: &amp;quot;3.5s&amp;quot;.
    /// </summary>
    public TerraformProperty<string>? Lifetime
    {
        get => GetProperty<TerraformProperty<string>>("lifetime");
        set => this.WithProperty("lifetime", value);
    }

    /// <summary>
    /// Location of the CertificateAuthority. A full list of valid locations can be found by
    /// running &#39;gcloud privateca locations list&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The signed CA certificate issued from the subordinated CA&#39;s CSR. This is needed when activating the subordiante CA with a third party issuer.
    /// </summary>
    public TerraformProperty<string>? PemCaCertificate
    {
        get => GetProperty<TerraformProperty<string>>("pem_ca_certificate");
        set => this.WithProperty("pem_ca_certificate", value);
    }

    /// <summary>
    /// The name of the CaPool this Certificate Authority belongs to.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Pool is required")]
    public required TerraformProperty<string> Pool
    {
        get => GetRequiredProperty<TerraformProperty<string>>("pool");
        set => this.WithProperty("pool", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// If this flag is set, the Certificate Authority will be deleted as soon as
    /// possible without a 30-day grace period where undeletion would have been
    /// allowed. If you proceed, there will be no way to recover this CA.
    /// Use with care. Defaults to &#39;false&#39;.
    /// </summary>
    public TerraformProperty<bool>? SkipGracePeriod
    {
        get => GetProperty<TerraformProperty<bool>>("skip_grace_period");
        set => this.WithProperty("skip_grace_period", value);
    }

    /// <summary>
    /// The Type of this CertificateAuthority.
    /// 
    /// ~&amp;gt; **Note:** For &#39;SUBORDINATE&#39; Certificate Authorities, they need to
    /// be activated before they can issue certificates. Default value: &amp;quot;SELF_SIGNED&amp;quot; Possible values: [&amp;quot;SELF_SIGNED&amp;quot;, &amp;quot;SUBORDINATE&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => this.WithProperty("type", value);
    }

    /// <summary>
    /// Block for config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Config block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Config block(s) allowed")]
    public List<GooglePrivatecaCertificateAuthorityConfigBlock>? Config
    {
        get => GetProperty<List<GooglePrivatecaCertificateAuthorityConfigBlock>>("config");
        set => this.WithProperty("config", value);
    }

    /// <summary>
    /// Block for key_spec.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 KeySpec block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KeySpec block(s) allowed")]
    public List<GooglePrivatecaCertificateAuthorityKeySpecBlock>? KeySpec
    {
        get => GetProperty<List<GooglePrivatecaCertificateAuthorityKeySpecBlock>>("key_spec");
        set => this.WithProperty("key_spec", value);
    }

    /// <summary>
    /// Block for subordinate_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SubordinateConfig block(s) allowed")]
    public List<GooglePrivatecaCertificateAuthoritySubordinateConfigBlock>? SubordinateConfig
    {
        get => GetProperty<List<GooglePrivatecaCertificateAuthoritySubordinateConfigBlock>>("subordinate_config");
        set => this.WithProperty("subordinate_config", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GooglePrivatecaCertificateAuthorityTimeoutsBlock? Timeouts
    {
        get => GetProperty<GooglePrivatecaCertificateAuthorityTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Block for user_defined_access_urls.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 UserDefinedAccessUrls block(s) allowed")]
    public List<GooglePrivatecaCertificateAuthorityUserDefinedAccessUrlsBlock>? UserDefinedAccessUrls
    {
        get => GetProperty<List<GooglePrivatecaCertificateAuthorityUserDefinedAccessUrlsBlock>>("user_defined_access_urls");
        set => this.WithProperty("user_defined_access_urls", value);
    }

    /// <summary>
    /// URLs for accessing content published by this CA, such as the CA certificate and CRLs.
    /// </summary>
    public TerraformExpression AccessUrls => this["access_urls"];

    /// <summary>
    /// The time at which this CertificateAuthority was created.
    /// 
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine
    /// fractional digits. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// The resource name for this CertificateAuthority in the format
    /// projects/*/locations/*/certificateAuthorities/*.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// This CertificateAuthority&#39;s certificate chain, including the current
    /// CertificateAuthority&#39;s certificate. Ordered such that the root issuer is the final
    /// element (consistent with RFC 5246). For a self-signed CA, this will only list the current
    /// CertificateAuthority&#39;s certificate.
    /// </summary>
    public TerraformExpression PemCaCertificates => this["pem_ca_certificates"];

    /// <summary>
    /// The State for this CertificateAuthority.
    /// </summary>
    public TerraformExpression State => this["state"];

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

    /// <summary>
    /// The time at which this CertificateAuthority was updated.
    /// 
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine
    /// fractional digits. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
