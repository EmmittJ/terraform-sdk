using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_iam_role Terraform data source.
/// Retrieves information about a aws_iam_role.
/// </summary>
public partial class AwsIamRoleDataSource(string name) : TerraformDataSource("aws_iam_role", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
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
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The assume_role_policy attribute.
    /// </summary>
    public TerraformValue<string> AssumeRolePolicy
        => AsReference("assume_role_policy");

    /// <summary>
    /// The create_date attribute.
    /// </summary>
    public TerraformValue<string> CreateDate
        => AsReference("create_date");

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string> Description
        => AsReference("description");

    /// <summary>
    /// The max_session_duration attribute.
    /// </summary>
    public TerraformValue<double> MaxSessionDuration
        => AsReference("max_session_duration");

    /// <summary>
    /// The path attribute.
    /// </summary>
    public TerraformValue<string> Path
        => AsReference("path");

    /// <summary>
    /// The permissions_boundary attribute.
    /// </summary>
    public TerraformValue<string> PermissionsBoundary
        => AsReference("permissions_boundary");

    /// <summary>
    /// The role_last_used attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> RoleLastUsed
        => AsReference("role_last_used");

    /// <summary>
    /// The unique_id attribute.
    /// </summary>
    public TerraformValue<string> UniqueId
        => AsReference("unique_id");

}
