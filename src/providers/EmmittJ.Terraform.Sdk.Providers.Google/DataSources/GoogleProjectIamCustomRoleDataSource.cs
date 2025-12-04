using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_project_iam_custom_role Terraform data source.
/// Retrieves information about a google_project_iam_custom_role.
/// </summary>
public partial class GoogleProjectIamCustomRoleDataSource(string name) : TerraformDataSource("google_project_iam_custom_role", name)
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
    /// The project that the service account will be created in. Defaults to the provider project configuration.
    /// </summary>
    public TerraformValue<string>? Project
    {
        get => GetArgument<TerraformValue<string>>("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The camel case role id to use for this role. Cannot contain - characters.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleId is required")]
    public required TerraformValue<string> RoleId
    {
        get => GetArgument<TerraformValue<string>>("role_id");
        set => SetArgument("role_id", value);
    }

    /// <summary>
    /// The current deleted state of the role.
    /// </summary>
    public TerraformValue<bool> Deleted
        => AsReference("deleted");

    /// <summary>
    /// A human-readable description for the role.
    /// </summary>
    public TerraformValue<string> Description
        => AsReference("description");

    /// <summary>
    /// The name of the role in the format projects/{{project}}/roles/{{role_id}}. Like id, this field can be used as a reference in other resources such as IAM role bindings.
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

    /// <summary>
    /// The names of the permissions this role grants when bound in an IAM policy. At least one permission must be specified.
    /// </summary>
    public TerraformSet<string> Permissions
        => AsReference("permissions");

    /// <summary>
    /// The current launch stage of the role. Defaults to GA.
    /// </summary>
    public TerraformValue<string> Stage
        => AsReference("stage");

    /// <summary>
    /// A human-readable title for the role.
    /// </summary>
    public TerraformValue<string> Title
        => AsReference("title");

}
