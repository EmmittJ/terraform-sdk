using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_organization_iam_custom_role Terraform resource.
/// Manages a google_organization_iam_custom_role resource.
/// </summary>
public partial class GoogleOrganizationIamCustomRole(string name) : TerraformResource("google_organization_iam_custom_role", name)
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
    /// The numeric ID of the organization in which you want to create a custom role.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OrgId is required")]
    public required TerraformValue<string> OrgId
    {
        get => new TerraformReference<string>(this, "org_id");
        set => SetArgument("org_id", value);
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
    /// The role id to use for this role.
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
    /// The name of the role in the format organizations/{{org_id}}/roles/{{role_id}}. Like id, this field can be used as a reference in other resources such as IAM role bindings.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
    }

}
