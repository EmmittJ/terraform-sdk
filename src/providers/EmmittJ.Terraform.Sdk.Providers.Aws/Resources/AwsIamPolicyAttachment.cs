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
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "groups").ResolveNodes(ctx));
        set => SetArgument("groups", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The policy_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicyArn is required")]
    public required TerraformValue<string> PolicyArn
    {
        get => new TerraformReference<string>(this, "policy_arn");
        set => SetArgument("policy_arn", value);
    }

    /// <summary>
    /// The roles attribute.
    /// </summary>
    public TerraformSet<string>? Roles
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "roles").ResolveNodes(ctx));
        set => SetArgument("roles", value);
    }

    /// <summary>
    /// The users attribute.
    /// </summary>
    public TerraformSet<string>? Users
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "users").ResolveNodes(ctx));
        set => SetArgument("users", value);
    }

}
