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
        get => GetArgument<TerraformValue<string>>("role_arn");
        set => SetArgument("role_arn", value);
    }

    /// <summary>
    /// The template_body attribute.
    /// </summary>
    public TerraformValue<string>? TemplateBody
    {
        get => GetArgument<TerraformValue<string>>("template_body");
        set => SetArgument("template_body", value);
    }

    /// <summary>
    /// The template_name attribute.
    /// </summary>
    public TerraformValue<string>? TemplateName
    {
        get => GetArgument<TerraformValue<string>>("template_name");
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
        get => GetRequiredArgument<TerraformValue<bool>>("active");
        set => SetArgument("active", value);
    }

    /// <summary>
    /// The allow_auto_registration attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllowAutoRegistration is required")]
    public required TerraformValue<bool> AllowAutoRegistration
    {
        get => GetRequiredArgument<TerraformValue<bool>>("allow_auto_registration");
        set => SetArgument("allow_auto_registration", value);
    }

    /// <summary>
    /// The ca_certificate_pem attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CaCertificatePem is required")]
    public required TerraformValue<string> CaCertificatePem
    {
        get => GetRequiredArgument<TerraformValue<string>>("ca_certificate_pem");
        set => SetArgument("ca_certificate_pem", value);
    }

    /// <summary>
    /// The certificate_mode attribute.
    /// </summary>
    public TerraformValue<string>? CertificateMode
    {
        get => GetArgument<TerraformValue<string>>("certificate_mode");
        set => SetArgument("certificate_mode", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all") ?? CreateReference("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The verification_certificate_pem attribute.
    /// </summary>
    public TerraformValue<string>? VerificationCertificatePem
    {
        get => GetArgument<TerraformValue<string>>("verification_certificate_pem");
        set => SetArgument("verification_certificate_pem", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => CreateReference("arn");

    /// <summary>
    /// The customer_version attribute.
    /// </summary>
    public TerraformValue<double> CustomerVersion
        => CreateReference("customer_version");

    /// <summary>
    /// The generation_id attribute.
    /// </summary>
    public TerraformValue<string> GenerationId
        => CreateReference("generation_id");

    /// <summary>
    /// The validity attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Validity
        => CreateReference("validity");

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
