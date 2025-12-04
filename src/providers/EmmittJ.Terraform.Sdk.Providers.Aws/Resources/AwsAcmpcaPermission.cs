using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_acmpca_permission Terraform resource.
/// Manages a aws_acmpca_permission resource.
/// </summary>
public partial class AwsAcmpcaPermission(string name) : TerraformResource("aws_acmpca_permission", name)
{
    /// <summary>
    /// The actions attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Actions is required")]
    public required TerraformSet<string> Actions
    {
        get => GetArgument<TerraformSet<string>>("actions");
        set => SetArgument("actions", value);
    }

    /// <summary>
    /// The certificate_authority_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CertificateAuthorityArn is required")]
    public required TerraformValue<string> CertificateAuthorityArn
    {
        get => GetArgument<TerraformValue<string>>("certificate_authority_arn");
        set => SetArgument("certificate_authority_arn", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The principal attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Principal is required")]
    public required TerraformValue<string> Principal
    {
        get => GetArgument<TerraformValue<string>>("principal");
        set => SetArgument("principal", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The source_account attribute.
    /// </summary>
    public TerraformValue<string>? SourceAccount
    {
        get => GetArgument<TerraformValue<string>>("source_account");
        set => SetArgument("source_account", value);
    }

    /// <summary>
    /// The policy attribute.
    /// </summary>
    public TerraformValue<string> Policy
        => AsReference("policy");

}
