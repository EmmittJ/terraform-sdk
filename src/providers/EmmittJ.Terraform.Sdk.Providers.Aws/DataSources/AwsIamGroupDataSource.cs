using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_iam_group Terraform data source.
/// Retrieves information about a aws_iam_group.
/// </summary>
public partial class AwsIamGroupDataSource(string name) : TerraformDataSource("aws_iam_group", name)
{
    /// <summary>
    /// The group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GroupName is required")]
    public required TerraformValue<string> GroupName
    {
        get => new TerraformReference<string>(this, "group_name");
        set => SetArgument("group_name", value);
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
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The group_id attribute.
    /// </summary>
    public TerraformValue<string> GroupId
    {
        get => new TerraformReference<string>(this, "group_id");
    }

    /// <summary>
    /// The path attribute.
    /// </summary>
    public TerraformValue<string> Path
    {
        get => new TerraformReference<string>(this, "path");
    }

    /// <summary>
    /// The users attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Users
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "users").ResolveNodes(ctx));
    }

}
