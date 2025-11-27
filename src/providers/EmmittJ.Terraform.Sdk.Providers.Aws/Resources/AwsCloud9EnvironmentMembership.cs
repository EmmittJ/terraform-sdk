using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_cloud9_environment_membership Terraform resource.
/// Manages a aws_cloud9_environment_membership resource.
/// </summary>
public partial class AwsCloud9EnvironmentMembership(string name) : TerraformResource("aws_cloud9_environment_membership", name)
{
    /// <summary>
    /// The environment_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EnvironmentId is required")]
    public required TerraformValue<string> EnvironmentId
    {
        get => new TerraformReference<string>(this, "environment_id");
        set => SetArgument("environment_id", value);
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
    /// The permissions attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Permissions is required")]
    public required TerraformValue<string> Permissions
    {
        get => new TerraformReference<string>(this, "permissions");
        set => SetArgument("permissions", value);
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
    /// The user_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserArn is required")]
    public required TerraformValue<string> UserArn
    {
        get => new TerraformReference<string>(this, "user_arn");
        set => SetArgument("user_arn", value);
    }

    /// <summary>
    /// The user_id attribute.
    /// </summary>
    public TerraformValue<string> UserId
    {
        get => new TerraformReference<string>(this, "user_id");
    }

}
