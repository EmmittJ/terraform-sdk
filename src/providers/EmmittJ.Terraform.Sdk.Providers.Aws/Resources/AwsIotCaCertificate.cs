using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for registration_config in AwsIotCaCertificate.
/// Nesting mode: list
/// </summary>
public class AwsIotCaCertificateRegistrationConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "registration_config";

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    public TerraformValue<string>? RoleArn
    {
        get => new TerraformReference<string>(this, "role_arn");
        set => SetArgument("role_arn", value);
    }

    /// <summary>
    /// The template_body attribute.
    /// </summary>
    public TerraformValue<string>? TemplateBody
    {
        get => new TerraformReference<string>(this, "template_body");
        set => SetArgument("template_body", value);
    }

    /// <summary>
    /// The template_name attribute.
    /// </summary>
    public TerraformValue<string>? TemplateName
    {
        get => new TerraformReference<string>(this, "template_name");
        set => SetArgument("template_name", value);
    }

}


/// <summary>
/// Represents a aws_iot_ca_certificate Terraform resource.
/// Manages a aws_iot_ca_certificate resource.
/// </summary>
public partial class AwsIotCaCertificate(string name) : TerraformResource("aws_iot_ca_certificate", name)
{
    /// <summary>
    /// The active attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Active is required")]
    public required TerraformValue<bool> Active
    {
        get => new TerraformReference<bool>(this, "active");
        set => SetArgument("active", value);
    }

    /// <summary>
    /// The allow_auto_registration attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllowAutoRegistration is required")]
    public required TerraformValue<bool> AllowAutoRegistration
    {
        get => new TerraformReference<bool>(this, "allow_auto_registration");
        set => SetArgument("allow_auto_registration", value);
    }

    /// <summary>
    /// The ca_certificate_pem attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CaCertificatePem is required")]
    public required TerraformValue<string> CaCertificatePem
    {
        get => new TerraformReference<string>(this, "ca_certificate_pem");
        set => SetArgument("ca_certificate_pem", value);
    }

    /// <summary>
    /// The certificate_mode attribute.
    /// </summary>
    public TerraformValue<string>? CertificateMode
    {
        get => new TerraformReference<string>(this, "certificate_mode");
        set => SetArgument("certificate_mode", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The verification_certificate_pem attribute.
    /// </summary>
    public TerraformValue<string>? VerificationCertificatePem
    {
        get => new TerraformReference<string>(this, "verification_certificate_pem");
        set => SetArgument("verification_certificate_pem", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The customer_version attribute.
    /// </summary>
    public TerraformValue<double> CustomerVersion
    {
        get => new TerraformReference<double>(this, "customer_version");
    }

    /// <summary>
    /// The generation_id attribute.
    /// </summary>
    public TerraformValue<string> GenerationId
    {
        get => new TerraformReference<string>(this, "generation_id");
    }

    /// <summary>
    /// The validity attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Validity
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "validity").ResolveNodes(ctx));
    }

    /// <summary>
    /// RegistrationConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RegistrationConfig block(s) allowed")]
    public TerraformList<AwsIotCaCertificateRegistrationConfigBlock>? RegistrationConfig
    {
        get => GetArgument<TerraformList<AwsIotCaCertificateRegistrationConfigBlock>>("registration_config");
        set => SetArgument("registration_config", value);
    }

}
