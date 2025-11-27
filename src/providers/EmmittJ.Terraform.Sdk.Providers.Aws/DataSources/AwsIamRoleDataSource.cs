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
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The assume_role_policy attribute.
    /// </summary>
    public TerraformValue<string> AssumeRolePolicy
    {
        get => new TerraformReference<string>(this, "assume_role_policy");
    }

    /// <summary>
    /// The create_date attribute.
    /// </summary>
    public TerraformValue<string> CreateDate
    {
        get => new TerraformReference<string>(this, "create_date");
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string> Description
    {
        get => new TerraformReference<string>(this, "description");
    }

    /// <summary>
    /// The max_session_duration attribute.
    /// </summary>
    public TerraformValue<double> MaxSessionDuration
    {
        get => new TerraformReference<double>(this, "max_session_duration");
    }

    /// <summary>
    /// The path attribute.
    /// </summary>
    public TerraformValue<string> Path
    {
        get => new TerraformReference<string>(this, "path");
    }

    /// <summary>
    /// The permissions_boundary attribute.
    /// </summary>
    public TerraformValue<string> PermissionsBoundary
    {
        get => new TerraformReference<string>(this, "permissions_boundary");
    }

    /// <summary>
    /// The role_last_used attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> RoleLastUsed
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "role_last_used").ResolveNodes(ctx));
    }

    /// <summary>
    /// The unique_id attribute.
    /// </summary>
    public TerraformValue<string> UniqueId
    {
        get => new TerraformReference<string>(this, "unique_id");
    }

}
