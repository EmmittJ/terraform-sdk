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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
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
        SetOutput("app_scope_id");
        SetOutput("directory_scope_id");
        SetOutput("id");
        SetOutput("principal_object_id");
        SetOutput("role_id");
    }

    /// <summary>
    /// Identifier of the app-specific scope when the assignment scope is app-specific
    /// </summary>
    public TerraformProperty<string> AppScopeId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("app_scope_id");
        set => SetProperty("app_scope_id", value);
    }

    /// <summary>
    /// Identifier of the directory object representing the scope of the assignment
    /// </summary>
    public TerraformProperty<string> DirectoryScopeId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("directory_scope_id");
        set => SetProperty("directory_scope_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The object ID of the member principal
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrincipalObjectId is required")]
    public required TerraformProperty<string> PrincipalObjectId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("principal_object_id");
        set => SetProperty("principal_object_id", value);
    }

    /// <summary>
    /// The object ID of the directory role for this assignment
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleId is required")]
    public required TerraformProperty<string> RoleId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("role_id");
        set => SetProperty("role_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzureadDirectoryRoleAssignmentTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
