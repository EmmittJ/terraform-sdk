using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Retrieves information about a azurerm_key_vault_managed_hardware_security_module_role_definition.
/// </summary>
public class AzurermKeyVaultManagedHardwareSecurityModuleRoleDefinitionDataSource : TerraformDataSource
{
    public AzurermKeyVaultManagedHardwareSecurityModuleRoleDefinitionDataSource(string name) : base("azurerm_key_vault_managed_hardware_security_module_role_definition", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("assignable_scopes");
        this.DeclareOutput("description");
        this.DeclareOutput("permission");
        this.DeclareOutput("resource_manager_id");
        this.DeclareOutput("role_name");
        this.DeclareOutput("role_type");
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
    /// The managed_hsm_id attribute.
    /// </summary>
    public string? ManagedHsmId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("managed_hsm_id")?.Value;
        set => this.WithProperty("managed_hsm_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The assignable_scopes attribute.
    /// </summary>
    public TerraformExpression AssignableScopes => this["assignable_scopes"];

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformExpression Description => this["description"];

    /// <summary>
    /// The permission attribute.
    /// </summary>
    public TerraformExpression Permission => this["permission"];

    /// <summary>
    /// The resource_manager_id attribute.
    /// </summary>
    public TerraformExpression ResourceManagerId => this["resource_manager_id"];

    /// <summary>
    /// The role_name attribute.
    /// </summary>
    public TerraformExpression RoleName => this["role_name"];

    /// <summary>
    /// The role_type attribute.
    /// </summary>
    public TerraformExpression RoleType => this["role_type"];

}
