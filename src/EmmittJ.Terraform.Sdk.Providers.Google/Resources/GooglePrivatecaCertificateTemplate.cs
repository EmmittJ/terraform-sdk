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
        get => GetProperty<TerraformProperty<bool>>("allow_subject_alt_names_passthrough");
        set => WithProperty("allow_subject_alt_names_passthrough", value);
    }

    /// <summary>
    /// Required. If this is true, the Subject field may be copied from a certificate request into the signed certificate. Otherwise, the requested Subject will be discarded.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllowSubjectPassthrough is required")]
    public required TerraformProperty<bool> AllowSubjectPassthrough
    {
        get => GetProperty<TerraformProperty<bool>>("allow_subject_passthrough");
        set => WithProperty("allow_subject_passthrough", value);
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
        get => GetProperty<List<TerraformProperty<string>>>("known_extensions");
        set => WithProperty("known_extensions", value);
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
        get => GetProperty<List<TerraformProperty<string>>>("aia_ocsp_servers");
        set => WithProperty("aia_ocsp_servers", value);
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
/// Manages a google_privateca_certificate_template resource.
/// </summary>
public class GooglePrivatecaCertificateTemplate : TerraformResource
{
    public GooglePrivatecaCertificateTemplate(string name) : base("google_privateca_certificate_template", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("create_time");
        this.DeclareOutput("effective_labels");
        this.DeclareOutput("terraform_labels");
        this.DeclareOutput("update_time");
    }

    /// <summary>
    /// Optional. A human-readable description of scenarios this template is intended for.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
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
    /// Optional. Labels with user-defined metadata.
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
    /// The location for the resource
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// Optional. The maximum lifetime allowed for all issued certificates that use this template. If the issuing CaPool&#39;s IssuancePolicy specifies a maximum lifetime the minimum of the two durations will be the maximum lifetime for issued. Note that if the issuing CertificateAuthority expires before a Certificate&#39;s requested maximum_lifetime, the effective lifetime will be explicitly truncated to match it.
    /// </summary>
    public TerraformProperty<string>? MaximumLifetime
    {
        get => GetProperty<TerraformProperty<string>>("maximum_lifetime");
        set => this.WithProperty("maximum_lifetime", value);
    }

    /// <summary>
    /// The resource name for this CertificateTemplate in the format &#39;projects/*/locations/*/certificateTemplates/*&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
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
    /// Block for identity_constraints.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IdentityConstraints block(s) allowed")]
    public List<GooglePrivatecaCertificateTemplateIdentityConstraintsBlock>? IdentityConstraints
    {
        get => GetProperty<List<GooglePrivatecaCertificateTemplateIdentityConstraintsBlock>>("identity_constraints");
        set => this.WithProperty("identity_constraints", value);
    }

    /// <summary>
    /// Block for passthrough_extensions.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PassthroughExtensions block(s) allowed")]
    public List<GooglePrivatecaCertificateTemplatePassthroughExtensionsBlock>? PassthroughExtensions
    {
        get => GetProperty<List<GooglePrivatecaCertificateTemplatePassthroughExtensionsBlock>>("passthrough_extensions");
        set => this.WithProperty("passthrough_extensions", value);
    }

    /// <summary>
    /// Block for predefined_values.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PredefinedValues block(s) allowed")]
    public List<GooglePrivatecaCertificateTemplatePredefinedValuesBlock>? PredefinedValues
    {
        get => GetProperty<List<GooglePrivatecaCertificateTemplatePredefinedValuesBlock>>("predefined_values");
        set => this.WithProperty("predefined_values", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GooglePrivatecaCertificateTemplateTimeoutsBlock? Timeouts
    {
        get => GetProperty<GooglePrivatecaCertificateTemplateTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
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
