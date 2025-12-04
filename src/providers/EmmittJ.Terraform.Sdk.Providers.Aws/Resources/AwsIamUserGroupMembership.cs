using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_iam_user_group_membership Terraform resource.
/// Manages a aws_iam_user_group_membership resource.
/// </summary>
public partial class AwsIamUserGroupMembership(string name) : TerraformResource("aws_iam_user_group_membership", name)
{
    /// <summary>
    /// The groups attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Groups is required")]
    public required TerraformSet<string> Groups
    {
        get => GetRequiredArgument<TerraformSet<string>>("groups");
        set => SetArgument("groups", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The user attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "User is required")]
    public required TerraformValue<string> User
    {
        get => GetRequiredArgument<TerraformValue<string>>("user");
        set => SetArgument("user", value);
    }

}
