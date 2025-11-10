using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzureadDirectoryRoleAssignmentTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

}

/// <summary>
/// Manages a azuread_directory_role_assignment resource.
/// </summary>
public class AzureadDirectoryRoleAssignment : TerraformResource
{
    public AzureadDirectoryRoleAssignment(string name) : base("azuread_directory_role_assignment", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// Identifier of the app-specific scope when the assignment scope is app-specific
    /// </summary>
    public TerraformProperty<string>? AppScopeId
    {
        get => GetProperty<TerraformProperty<string>>("app_scope_id");
        set => this.WithProperty("app_scope_id", value);
    }

    /// <summary>
    /// Identifier of the directory object representing the scope of the assignment
    /// </summary>
    public TerraformProperty<string>? DirectoryScopeId
    {
        get => GetProperty<TerraformProperty<string>>("directory_scope_id");
        set => this.WithProperty("directory_scope_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The object ID of the member principal
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrincipalObjectId is required")]
    public required TerraformProperty<string> PrincipalObjectId
    {
        get => GetProperty<TerraformProperty<string>>("principal_object_id");
        set => this.WithProperty("principal_object_id", value);
    }

    /// <summary>
    /// The object ID of the directory role for this assignment
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleId is required")]
    public required TerraformProperty<string> RoleId
    {
        get => GetProperty<TerraformProperty<string>>("role_id");
        set => this.WithProperty("role_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzureadDirectoryRoleAssignmentTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzureadDirectoryRoleAssignmentTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
