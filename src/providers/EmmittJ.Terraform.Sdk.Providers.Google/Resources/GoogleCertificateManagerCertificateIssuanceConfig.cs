using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for certificate_authority_config in .
/// Nesting mode: list
/// </summary>
public class GoogleCertificateManagerCertificateIssuanceConfigCertificateAuthorityConfigBlock : TerraformBlock
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleCertificateManagerCertificateIssuanceConfigTimeoutsBlock : TerraformBlock
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
/// Manages a google_certificate_manager_certificate_issuance_config resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleCertificateManagerCertificateIssuanceConfig : TerraformResource
{
    public GoogleCertificateManagerCertificateIssuanceConfig(string name) : base("google_certificate_manager_certificate_issuance_config", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("create_time");
        SetOutput("effective_labels");
        SetOutput("terraform_labels");
        SetOutput("update_time");
        SetOutput("description");
        SetOutput("id");
        SetOutput("key_algorithm");
        SetOutput("labels");
        SetOutput("lifetime");
        SetOutput("location");
        SetOutput("name");
        SetOutput("project");
        SetOutput("rotation_window_percentage");
    }

    /// <summary>
    /// One or more paragraphs of text description of a CertificateIssuanceConfig.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
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
    /// Key algorithm to use when generating the private key. Possible values: [&amp;quot;RSA_2048&amp;quot;, &amp;quot;ECDSA_P256&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyAlgorithm is required")]
    public required TerraformProperty<string> KeyAlgorithm
    {
        get => GetRequiredOutput<TerraformProperty<string>>("key_algorithm");
        set => SetProperty("key_algorithm", value);
    }

    /// <summary>
    /// &#39;Set of label tags associated with the CertificateIssuanceConfig resource.
    ///  An object containing a list of &amp;quot;key&amp;quot;: value pairs. Example: { &amp;quot;name&amp;quot;: &amp;quot;wrench&amp;quot;, &amp;quot;count&amp;quot;: &amp;quot;3&amp;quot; }.
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
    /// Lifetime of issued certificates. A duration in seconds with up to nine fractional digits, ending with &#39;s&#39;.
    /// Example: &amp;quot;1814400s&amp;quot;. Valid values are from 21 days (1814400s) to 30 days (2592000s)
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Lifetime is required")]
    public required TerraformProperty<string> Lifetime
    {
        get => GetRequiredOutput<TerraformProperty<string>>("lifetime");
        set => SetProperty("lifetime", value);
    }

    /// <summary>
    /// The Certificate Manager location. If not specified, &amp;quot;global&amp;quot; is used.
    /// </summary>
    public TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// A user-defined name of the certificate issuance config.
    /// CertificateIssuanceConfig names must be unique globally.
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
    /// It specifies the percentage of elapsed time of the certificate lifetime to wait before renewing the certificate.
    /// Must be a number between 1-99, inclusive.
    /// You must set the rotation window percentage in relation to the certificate lifetime so that certificate renewal occurs at least 7 days after
    /// the certificate has been issued and at least 7 days before it expires.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RotationWindowPercentage is required")]
    public required TerraformProperty<double> RotationWindowPercentage
    {
        get => GetRequiredOutput<TerraformProperty<double>>("rotation_window_percentage");
        set => SetProperty("rotation_window_percentage", value);
    }

    /// <summary>
    /// Block for certificate_authority_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CertificateAuthorityConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 CertificateAuthorityConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CertificateAuthorityConfig block(s) allowed")]
    public List<GoogleCertificateManagerCertificateIssuanceConfigCertificateAuthorityConfigBlock>? CertificateAuthorityConfig
    {
        set => SetProperty("certificate_authority_config", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleCertificateManagerCertificateIssuanceConfigTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The creation timestamp of a CertificateIssuanceConfig. Timestamp is in RFC3339 UTC &amp;quot;Zulu&amp;quot; format,
    /// accurate to nanoseconds with up to nine fractional digits.
    /// Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

    /// <summary>
    /// The last update timestamp of a CertificateIssuanceConfig. Timestamp is in RFC3339 UTC &amp;quot;Zulu&amp;quot; format,
    /// accurate to nanoseconds with up to nine fractional digits.
    /// Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
