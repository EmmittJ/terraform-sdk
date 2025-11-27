using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azuread;

/// <summary>
/// Block type for timeouts in AzureadAppRoleAssignment.
/// Nesting mode: single
/// </summary>
public class AzureadAppRoleAssignmentTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}


/// <summary>
/// Represents a azuread_app_role_assignment Terraform resource.
/// Manages a azuread_app_role_assignment resource.
/// </summary>
public partial class AzureadAppRoleAssignment(string name) : TerraformResource("azuread_app_role_assignment", name)
{
    /// <summary>
    /// The ID of the app role to be assigned
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AppRoleId is required")]
    public required TerraformValue<string> AppRoleId
    {
        get => new TerraformReference<string>(this, "app_role_id");
        set => SetArgument("app_role_id", value);
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
    /// The object ID of the user, group or service principal to be assigned this app role
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrincipalObjectId is required")]
    public required TerraformValue<string> PrincipalObjectId
    {
        get => new TerraformReference<string>(this, "principal_object_id");
        set => SetArgument("principal_object_id", value);
    }

    /// <summary>
    /// The object ID of the service principal representing the resource
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceObjectId is required")]
    public required TerraformValue<string> ResourceObjectId
    {
        get => new TerraformReference<string>(this, "resource_object_id");
        set => SetArgument("resource_object_id", value);
    }

    /// <summary>
    /// The display name of the principal to which the app role is assigned
    /// </summary>
    public TerraformValue<string> PrincipalDisplayName
    {
        get => new TerraformReference<string>(this, "principal_display_name");
    }

    /// <summary>
    /// The object type of the principal to which the app role is assigned
    /// </summary>
    public TerraformValue<string> PrincipalType
    {
        get => new TerraformReference<string>(this, "principal_type");
    }

    /// <summary>
    /// The display name of the application representing the resource
    /// </summary>
    public TerraformValue<string> ResourceDisplayName
    {
        get => new TerraformReference<string>(this, "resource_display_name");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzureadAppRoleAssignmentTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzureadAppRoleAssignmentTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
