using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_codebuild_source_credential Terraform resource.
/// Manages a aws_codebuild_source_credential resource.
/// </summary>
public partial class AwsCodebuildSourceCredential(string name) : TerraformResource("aws_codebuild_source_credential", name)
{
    /// <summary>
    /// The auth_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthType is required")]
    public required TerraformValue<string> AuthType
    {
        get => new TerraformReference<string>(this, "auth_type");
        set => SetArgument("auth_type", value);
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
    /// The server_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServerType is required")]
    public required TerraformValue<string> ServerType
    {
        get => new TerraformReference<string>(this, "server_type");
        set => SetArgument("server_type", value);
    }

    /// <summary>
    /// The token attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Token is required")]
    public required TerraformValue<string> Token
    {
        get => new TerraformReference<string>(this, "token");
        set => SetArgument("token", value);
    }

    /// <summary>
    /// The user_name attribute.
    /// </summary>
    public TerraformValue<string>? UserName
    {
        get => new TerraformReference<string>(this, "user_name");
        set => SetArgument("user_name", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

}
