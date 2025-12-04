using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_iam_role Terraform data source.
/// Retrieves information about a google_iam_role.
/// </summary>
public partial class GoogleIamRoleDataSource(string name) : TerraformDataSource("google_iam_role", name)
{
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
    /// The included_permissions attribute.
    /// </summary>
    public TerraformList<string> IncludedPermissions
        => AsReference("included_permissions");

    /// <summary>
    /// The stage attribute.
    /// </summary>
    public TerraformValue<string> Stage
        => AsReference("stage");

    /// <summary>
    /// The title attribute.
    /// </summary>
    public TerraformValue<string> Title
        => AsReference("title");

}
