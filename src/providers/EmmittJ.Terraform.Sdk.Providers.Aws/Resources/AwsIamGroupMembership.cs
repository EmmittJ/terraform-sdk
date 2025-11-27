using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_iam_group_membership Terraform resource.
/// Manages a aws_iam_group_membership resource.
/// </summary>
public partial class AwsIamGroupMembership(string name) : TerraformResource("aws_iam_group_membership", name)
{
    /// <summary>
    /// The group attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Group is required")]
    public required TerraformValue<string> Group
    {
        get => new TerraformReference<string>(this, "group");
        set => SetArgument("group", value);
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
    /// The users attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Users is required")]
    public required TerraformSet<string> Users
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "users").ResolveNodes(ctx));
        set => SetArgument("users", value);
    }

}
