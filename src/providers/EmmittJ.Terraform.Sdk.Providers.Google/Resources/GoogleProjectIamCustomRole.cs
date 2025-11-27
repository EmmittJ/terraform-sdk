using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_project_iam_custom_role Terraform resource.
/// Manages a google_project_iam_custom_role resource.
/// </summary>
public partial class GoogleProjectIamCustomRole(string name) : TerraformResource("google_project_iam_custom_role", name)
{
    /// <summary>
    /// A human-readable description for the role.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
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
    /// The names of the permissions this role grants when bound in an IAM policy. At least one permission must be specified.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Permissions is required")]
    public required TerraformSet<string> Permissions
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "permissions").ResolveNodes(ctx));
        set => SetArgument("permissions", value);
    }

    /// <summary>
    /// The project that the service account will be created in. Defaults to the provider project configuration.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => new TerraformReference<string>(this, "project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The camel case role id to use for this role. Cannot contain - characters.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleId is required")]
    public required TerraformValue<string> RoleId
    {
        get => new TerraformReference<string>(this, "role_id");
        set => SetArgument("role_id", value);
    }

    /// <summary>
    /// The current launch stage of the role. Defaults to GA.
    /// </summary>
    public TerraformValue<string>? Stage
    {
        get => new TerraformReference<string>(this, "stage");
        set => SetArgument("stage", value);
    }

    /// <summary>
    /// A human-readable title for the role.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Title is required")]
    public required TerraformValue<string> Title
    {
        get => new TerraformReference<string>(this, "title");
        set => SetArgument("title", value);
    }

    /// <summary>
    /// The current deleted state of the role.
    /// </summary>
    public TerraformValue<bool> Deleted
    {
        get => new TerraformReference<bool>(this, "deleted");
    }

    /// <summary>
    /// The name of the role in the format projects/{{project}}/roles/{{role_id}}. Like id, this field can be used as a reference in other resources such as IAM role bindings.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
    }

}
