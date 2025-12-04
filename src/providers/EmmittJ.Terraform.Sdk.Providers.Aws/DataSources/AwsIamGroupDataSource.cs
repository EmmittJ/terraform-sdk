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
        get => GetArgument<TerraformValue<string>>("group_name");
        set => SetArgument("group_name", value);
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
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The group_id attribute.
    /// </summary>
    public TerraformValue<string> GroupId
        => AsReference("group_id");

    /// <summary>
    /// The path attribute.
    /// </summary>
    public TerraformValue<string> Path
        => AsReference("path");

    /// <summary>
    /// The users attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Users
        => AsReference("users");

}
