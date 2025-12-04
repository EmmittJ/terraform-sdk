using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_iam_policy_attachment Terraform resource.
/// Manages a aws_iam_policy_attachment resource.
/// </summary>
public partial class AwsIamPolicyAttachment(string name) : TerraformResource("aws_iam_policy_attachment", name)
{
    /// <summary>
    /// The groups attribute.
    /// </summary>
    public TerraformSet<string>? Groups
    {
        get => GetArgument<TerraformSet<string>>("groups");
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The policy_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicyArn is required")]
    public required TerraformValue<string> PolicyArn
    {
        get => GetRequiredArgument<TerraformValue<string>>("policy_arn");
        set => SetArgument("policy_arn", value);
    }

    /// <summary>
    /// The roles attribute.
    /// </summary>
    public TerraformSet<string>? Roles
    {
        get => GetArgument<TerraformSet<string>>("roles");
        set => SetArgument("roles", value);
    }

    /// <summary>
    /// The users attribute.
    /// </summary>
    public TerraformSet<string>? Users
    {
        get => GetArgument<TerraformSet<string>>("users");
        set => SetArgument("users", value);
    }

}
