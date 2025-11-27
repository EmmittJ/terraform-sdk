using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for certificate_authority_config in GoogleCertificateManagerCertificateIssuanceConfig.
/// Nesting mode: list
/// </summary>
public class GoogleCertificateManagerCertificateIssuanceConfigCertificateAuthorityConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "certificate_authority_config";

    /// <summary>
    /// CertificateAuthorityServiceConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CertificateAuthorityServiceConfig block(s) allowed")]
    public TerraformList<GoogleCertificateManagerCertificateIssuanceConfigCertificateAuthorityConfigBlockCertificateAuthorityServiceConfigBlock>? CertificateAuthorityServiceConfig
    {
        get => GetArgument<TerraformList<GoogleCertificateManagerCertificateIssuanceConfigCertificateAuthorityConfigBlockCertificateAuthorityServiceConfigBlock>>("certificate_authority_service_config");
        set => SetArgument("certificate_authority_service_config", value);
    }

}

/// <summary>
/// Block type for certificate_authority_service_config in GoogleCertificateManagerCertificateIssuanceConfigCertificateAuthorityConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleCertificateManagerCertificateIssuanceConfigCertificateAuthorityConfigBlockCertificateAuthorityServiceConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "certificate_authority_service_config";

    /// <summary>
    /// A CA pool resource used to issue a certificate.
    /// The CA pool string has a relative resource path following the form
    /// &amp;quot;projects/{project}/locations/{location}/caPools/{caPool}&amp;quot;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CaPool is required")]
    public required TerraformValue<string> CaPool
    {
        get => new TerraformReference<string>(this, "ca_pool");
        set => SetArgument("ca_pool", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleCertificateManagerCertificateIssuanceConfig.
/// Nesting mode: single
/// </summary>
public class GoogleCertificateManagerCertificateIssuanceConfigTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_certificate_manager_certificate_issuance_config Terraform resource.
/// Manages a google_certificate_manager_certificate_issuance_config resource.
/// </summary>
public partial class GoogleCertificateManagerCertificateIssuanceConfig(string name) : TerraformResource("google_certificate_manager_certificate_issuance_config", name)
{
    /// <summary>
    /// One or more paragraphs of text description of a CertificateIssuanceConfig.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
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
    /// Key algorithm to use when generating the private key. Possible values: [&amp;quot;RSA_2048&amp;quot;, &amp;quot;ECDSA_P256&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyAlgorithm is required")]
    public required TerraformValue<string> KeyAlgorithm
    {
        get => new TerraformReference<string>(this, "key_algorithm");
        set => SetArgument("key_algorithm", value);
    }

    /// <summary>
    /// &#39;Set of label tags associated with the CertificateIssuanceConfig resource.
    ///  An object containing a list of &amp;quot;key&amp;quot;: value pairs. Example: { &amp;quot;name&amp;quot;: &amp;quot;wrench&amp;quot;, &amp;quot;count&amp;quot;: &amp;quot;3&amp;quot; }.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformMap<string>? Labels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "labels").ResolveNodes(ctx));
        set => SetArgument("labels", value);
    }

    /// <summary>
    /// Lifetime of issued certificates. A duration in seconds with up to nine fractional digits, ending with &#39;s&#39;.
    /// Example: &amp;quot;1814400s&amp;quot;. Valid values are from 21 days (1814400s) to 30 days (2592000s)
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Lifetime is required")]
    public required TerraformValue<string> Lifetime
    {
        get => new TerraformReference<string>(this, "lifetime");
        set => SetArgument("lifetime", value);
    }

    /// <summary>
    /// The Certificate Manager location. If not specified, &amp;quot;global&amp;quot; is used.
    /// </summary>
    public TerraformValue<string>? Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// A user-defined name of the certificate issuance config.
    /// CertificateIssuanceConfig names must be unique globally.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => new TerraformReference<string>(this, "project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// It specifies the percentage of elapsed time of the certificate lifetime to wait before renewing the certificate.
    /// Must be a number between 1-99, inclusive.
    /// You must set the rotation window percentage in relation to the certificate lifetime so that certificate renewal occurs at least 7 days after
    /// the certificate has been issued and at least 7 days before it expires.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RotationWindowPercentage is required")]
    public required TerraformValue<double> RotationWindowPercentage
    {
        get => new TerraformReference<double>(this, "rotation_window_percentage");
        set => SetArgument("rotation_window_percentage", value);
    }

    /// <summary>
    /// The creation timestamp of a CertificateIssuanceConfig. Timestamp is in RFC3339 UTC &amp;quot;Zulu&amp;quot; format,
    /// accurate to nanoseconds with up to nine fractional digits.
    /// Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    public TerraformValue<string> CreateTime
    {
        get => new TerraformReference<string>(this, "create_time");
    }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "effective_labels").ResolveNodes(ctx));
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
    /// The last update timestamp of a CertificateIssuanceConfig. Timestamp is in RFC3339 UTC &amp;quot;Zulu&amp;quot; format,
    /// accurate to nanoseconds with up to nine fractional digits.
    /// Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    public TerraformValue<string> UpdateTime
    {
        get => new TerraformReference<string>(this, "update_time");
    }

    /// <summary>
    /// CertificateAuthorityConfig block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CertificateAuthorityConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 CertificateAuthorityConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CertificateAuthorityConfig block(s) allowed")]
    public required TerraformList<GoogleCertificateManagerCertificateIssuanceConfigCertificateAuthorityConfigBlock> CertificateAuthorityConfig
    {
        get => GetRequiredArgument<TerraformList<GoogleCertificateManagerCertificateIssuanceConfigCertificateAuthorityConfigBlock>>("certificate_authority_config");
        set => SetArgument("certificate_authority_config", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleCertificateManagerCertificateIssuanceConfigTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleCertificateManagerCertificateIssuanceConfigTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
