using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

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
    public string? AppScopeId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("app_scope_id")?.Value;
        set => this.WithProperty("app_scope_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Identifier of the directory object representing the scope of the assignment
    /// </summary>
    public string? DirectoryScopeId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("directory_scope_id")?.Value;
        set => this.WithProperty("directory_scope_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The object ID of the member principal
    /// </summary>
    public string? PrincipalObjectId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("principal_object_id")?.Value;
        set => this.WithProperty("principal_object_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The object ID of the directory role for this assignment
    /// </summary>
    public string? RoleId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("role_id")?.Value;
        set => this.WithProperty("role_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
