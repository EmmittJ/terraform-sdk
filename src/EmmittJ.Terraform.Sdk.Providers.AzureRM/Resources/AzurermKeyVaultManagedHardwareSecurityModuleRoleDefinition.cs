using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_key_vault_managed_hardware_security_module_role_definition resource.
/// </summary>
public class AzurermKeyVaultManagedHardwareSecurityModuleRoleDefinition : TerraformResource
{
    public AzurermKeyVaultManagedHardwareSecurityModuleRoleDefinition(string name) : base("azurerm_key_vault_managed_hardware_security_module_role_definition", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("resource_manager_id");
        this.DeclareOutput("role_type");
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The role_name attribute.
    /// </summary>
    public string? RoleName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("role_name")?.Value;
        set => this.WithProperty("role_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The resource_manager_id attribute.
    /// </summary>
    public TerraformExpression ResourceManagerId => this["resource_manager_id"];

    /// <summary>
    /// The role_type attribute.
    /// </summary>
    public TerraformExpression RoleType => this["role_type"];

}
