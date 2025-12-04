using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azuread;

/// <summary>
/// Block type for timeouts in AzureadDirectoryRoleAssignment.
/// Nesting mode: single
/// </summary>
public class AzureadDirectoryRoleAssignmentTimeoutsBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

}


/// <summary>
/// Represents a azuread_directory_role_assignment Terraform resource.
/// Manages a azuread_directory_role_assignment resource.
/// </summary>
public partial class AzureadDirectoryRoleAssignment(string name) : TerraformResource("azuread_directory_role_assignment", name)
{
    /// <summary>
    /// Identifier of the app-specific scope when the assignment scope is app-specific
    /// </summary>
    public TerraformValue<string>? AppScopeId
    {
        get => GetArgument<TerraformValue<string>>("app_scope_id");
        set => SetArgument("app_scope_id", value);
    }

    /// <summary>
    /// Identifier of the directory object representing the scope of the assignment
    /// </summary>
    public TerraformValue<string>? DirectoryScopeId
    {
        get => GetArgument<TerraformValue<string>>("directory_scope_id");
        set => SetArgument("directory_scope_id", value);
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
    /// The object ID of the member principal
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrincipalObjectId is required")]
    public required TerraformValue<string> PrincipalObjectId
    {
        get => GetArgument<TerraformValue<string>>("principal_object_id");
        set => SetArgument("principal_object_id", value);
    }

    /// <summary>
    /// The object ID of the directory role for this assignment
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleId is required")]
    public required TerraformValue<string> RoleId
    {
        get => GetArgument<TerraformValue<string>>("role_id");
        set => SetArgument("role_id", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzureadDirectoryRoleAssignmentTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzureadDirectoryRoleAssignmentTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
