using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for encryption_spec in .
/// Nesting mode: list
/// </summary>
public class GooglePrivatecaCaPoolEncryptionSpecBlock : TerraformBlock
{
    /// <summary>
    /// The resource name for an existing Cloud KMS key in the format
    /// &#39;projects/*/locations/*/keyRings/*/cryptoKeys/*&#39;.
    /// </summary>
    public TerraformProperty<string>? CloudKmsKey
    {
        set => SetProperty("cloud_kms_key", value);
    }

}

/// <summary>
/// Block type for issuance_policy in .
/// Nesting mode: list
/// </summary>
public class GooglePrivatecaCaPoolIssuancePolicyBlock : TerraformBlock
{
    /// <summary>
    /// The duration to backdate all certificates issued from this CaPool. If not set, the
    /// certificates will be issued with a not_before_time of the issuance time (i.e. the current
    /// time). If set, the certificates will be issued with a not_before_time of the issuance
    /// time minus the backdate_duration. The not_after_time will be adjusted to preserve the
    /// requested lifetime. The backdate_duration must be less than or equal to 48 hours.
    /// </summary>
    public TerraformProperty<string>? BackdateDuration
    {
        set => SetProperty("backdate_duration", value);
    }

    /// <summary>
    /// The maximum lifetime allowed for issued Certificates. Note that if the issuing CertificateAuthority
    /// expires before a Certificate&#39;s requested maximumLifetime, the effective lifetime will be explicitly truncated to match it.
    /// </summary>
    public TerraformProperty<string>? MaximumLifetime
    {
        set => SetProperty("maximum_lifetime", value);
    }

}

/// <summary>
/// Block type for publishing_options in .
/// Nesting mode: list
/// </summary>
public class GooglePrivatecaCaPoolPublishingOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Specifies the encoding format of each CertificateAuthority&#39;s CA
    /// certificate and CRLs. If this is omitted, CA certificates and CRLs
    /// will be published in PEM. Possible values: [&amp;quot;PEM&amp;quot;, &amp;quot;DER&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? EncodingFormat
    {
        set => SetProperty("encoding_format", value);
    }

    /// <summary>
    /// When true, publishes each CertificateAuthority&#39;s CA certificate and includes its URL in the &amp;quot;Authority Information Access&amp;quot;
    /// X.509 extension in all issued Certificates. If this is false, the CA certificate will not be published and the corresponding
    /// X.509 extension will not be written in issued certificates.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PublishCaCert is required")]
    public required TerraformProperty<bool> PublishCaCert
    {
        set => SetProperty("publish_ca_cert", value);
    }

    /// <summary>
    /// When true, publishes each CertificateAuthority&#39;s CRL and includes its URL in the &amp;quot;CRL Distribution Points&amp;quot; X.509 extension
    /// in all issued Certificates. If this is false, CRLs will not be published and the corresponding X.509 extension will not
    /// be written in issued certificates. CRLs will expire 7 days from their creation. However, we will rebuild daily. CRLs are
    /// also rebuilt shortly after a certificate is revoked.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PublishCrl is required")]
    public required TerraformProperty<bool> PublishCrl
    {
        set => SetProperty("publish_crl", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GooglePrivatecaCaPoolTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a google_privateca_ca_pool resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GooglePrivatecaCaPool : TerraformResource
{
    public GooglePrivatecaCaPool(string name) : base("google_privateca_ca_pool", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("effective_labels");
        SetOutput("terraform_labels");
        SetOutput("id");
        SetOutput("labels");
        SetOutput("location");
        SetOutput("name");
        SetOutput("project");
        SetOutput("tier");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
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
    public Dictionary<string, TerraformProperty<string>> Labels
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("labels");
        set => SetProperty("labels", value);
    }

    /// <summary>
    /// Location of the CaPool. A full list of valid locations can be found by
    /// running &#39;gcloud privateca locations list&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The name for this CaPool.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
    }

    /// <summary>
    /// The Tier of this CaPool. Possible values: [&amp;quot;ENTERPRISE&amp;quot;, &amp;quot;DEVOPS&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Tier is required")]
    public required TerraformProperty<string> Tier
    {
        get => GetRequiredOutput<TerraformProperty<string>>("tier");
        set => SetProperty("tier", value);
    }

    /// <summary>
    /// Block for encryption_spec.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EncryptionSpec block(s) allowed")]
    public List<GooglePrivatecaCaPoolEncryptionSpecBlock>? EncryptionSpec
    {
        set => SetProperty("encryption_spec", value);
    }

    /// <summary>
    /// Block for issuance_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IssuancePolicy block(s) allowed")]
    public List<GooglePrivatecaCaPoolIssuancePolicyBlock>? IssuancePolicy
    {
        set => SetProperty("issuance_policy", value);
    }

    /// <summary>
    /// Block for publishing_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PublishingOptions block(s) allowed")]
    public List<GooglePrivatecaCaPoolPublishingOptionsBlock>? PublishingOptions
    {
        set => SetProperty("publishing_options", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GooglePrivatecaCaPoolTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

}
