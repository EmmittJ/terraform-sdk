using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for identity_constraints in .
/// Nesting mode: list
/// </summary>
public class GooglePrivatecaCertificateTemplateIdentityConstraintsBlock : TerraformBlock
{
    /// <summary>
    /// Required. If this is true, the SubjectAltNames extension may be copied from a certificate request into the signed certificate. Otherwise, the requested SubjectAltNames will be discarded.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllowSubjectAltNamesPassthrough is required")]
    public required TerraformProperty<bool> AllowSubjectAltNamesPassthrough
    {
        set => SetProperty("allow_subject_alt_names_passthrough", value);
    }

    /// <summary>
    /// Required. If this is true, the Subject field may be copied from a certificate request into the signed certificate. Otherwise, the requested Subject will be discarded.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllowSubjectPassthrough is required")]
    public required TerraformProperty<bool> AllowSubjectPassthrough
    {
        set => SetProperty("allow_subject_passthrough", value);
    }

}

/// <summary>
/// Block type for passthrough_extensions in .
/// Nesting mode: list
/// </summary>
public class GooglePrivatecaCertificateTemplatePassthroughExtensionsBlock : TerraformBlock
{
    /// <summary>
    /// Optional. A set of named X.509 extensions. Will be combined with additional_extensions to determine the full set of X.509 extensions.
    /// </summary>
    public List<TerraformProperty<string>>? KnownExtensions
    {
        set => SetProperty("known_extensions", value);
    }

}

/// <summary>
/// Block type for predefined_values in .
/// Nesting mode: list
/// </summary>
public class GooglePrivatecaCertificateTemplatePredefinedValuesBlock : TerraformBlock
{
    /// <summary>
    /// Optional. Describes Online Certificate Status Protocol (OCSP) endpoint addresses that appear in the &amp;quot;Authority Information Access&amp;quot; extension in the certificate.
    /// </summary>
    public List<TerraformProperty<string>>? AiaOcspServers
    {
        set => SetProperty("aia_ocsp_servers", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GooglePrivatecaCertificateTemplateTimeoutsBlock : TerraformBlock
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
/// Manages a google_privateca_certificate_template resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GooglePrivatecaCertificateTemplate : TerraformResource
{
    public GooglePrivatecaCertificateTemplate(string name) : base("google_privateca_certificate_template", name)
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
        SetOutput("labels");
        SetOutput("location");
        SetOutput("maximum_lifetime");
        SetOutput("name");
        SetOutput("project");
    }

    /// <summary>
    /// Optional. A human-readable description of scenarios this template is intended for.
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
    /// Optional. Labels with user-defined metadata.
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
    /// The location for the resource
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// Optional. The maximum lifetime allowed for all issued certificates that use this template. If the issuing CaPool&#39;s IssuancePolicy specifies a maximum lifetime the minimum of the two durations will be the maximum lifetime for issued. Note that if the issuing CertificateAuthority expires before a Certificate&#39;s requested maximum_lifetime, the effective lifetime will be explicitly truncated to match it.
    /// </summary>
    public TerraformProperty<string> MaximumLifetime
    {
        get => GetRequiredOutput<TerraformProperty<string>>("maximum_lifetime");
        set => SetProperty("maximum_lifetime", value);
    }

    /// <summary>
    /// The resource name for this CertificateTemplate in the format &#39;projects/*/locations/*/certificateTemplates/*&#39;.
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
    /// Block for identity_constraints.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IdentityConstraints block(s) allowed")]
    public List<GooglePrivatecaCertificateTemplateIdentityConstraintsBlock>? IdentityConstraints
    {
        set => SetProperty("identity_constraints", value);
    }

    /// <summary>
    /// Block for passthrough_extensions.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PassthroughExtensions block(s) allowed")]
    public List<GooglePrivatecaCertificateTemplatePassthroughExtensionsBlock>? PassthroughExtensions
    {
        set => SetProperty("passthrough_extensions", value);
    }

    /// <summary>
    /// Block for predefined_values.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PredefinedValues block(s) allowed")]
    public List<GooglePrivatecaCertificateTemplatePredefinedValuesBlock>? PredefinedValues
    {
        set => SetProperty("predefined_values", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GooglePrivatecaCertificateTemplateTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// Output only. The time at which this CertificateTemplate was created.
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
    /// Output only. The time at which this CertificateTemplate was updated.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
