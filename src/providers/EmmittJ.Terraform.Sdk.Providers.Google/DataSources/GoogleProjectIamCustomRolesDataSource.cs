using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_project_iam_custom_roles Terraform data source.
/// Retrieves information about a google_project_iam_custom_roles.
/// </summary>
public partial class GoogleProjectIamCustomRolesDataSource(string name) : TerraformDataSource("google_project_iam_custom_roles", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string>? Project
    {
        get => GetArgument<TerraformValue<string>>("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The show_deleted attribute.
    /// </summary>
    public TerraformValue<bool>? ShowDeleted
    {
        get => GetArgument<TerraformValue<bool>>("show_deleted");
        set => SetArgument("show_deleted", value);
    }

    /// <summary>
    /// The view attribute.
    /// </summary>
    public TerraformValue<string>? View
    {
        get => GetArgument<TerraformValue<string>>("view");
        set => SetArgument("view", value);
    }

    /// <summary>
    /// The roles attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Roles
        => CreateReference("roles");

}
