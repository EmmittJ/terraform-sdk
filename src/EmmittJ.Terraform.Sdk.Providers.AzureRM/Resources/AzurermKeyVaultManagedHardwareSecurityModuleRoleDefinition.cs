using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for permission in .
/// Nesting mode: list
/// </summary>
public class AzurermKeyVaultManagedHardwareSecurityModuleRoleDefinitionPermissionBlock : TerraformBlock
{
    /// <summary>
    /// The actions attribute.
    /// </summary>
    public List<TerraformProperty<string>>? Actions
    {
        get => GetProperty<List<TerraformProperty<string>>>("actions");
        set => WithProperty("actions", value);
    }

    /// <summary>
    /// The data_actions attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? DataActions
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("data_actions");
        set => WithProperty("data_actions", value);
    }

    /// <summary>
    /// The not_actions attribute.
    /// </summary>
    public List<TerraformProperty<string>>? NotActions
    {
        get => GetProperty<List<TerraformProperty<string>>>("not_actions");
        set => WithProperty("not_actions", value);
    }

    /// <summary>
    /// The not_data_actions attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? NotDataActions
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("not_data_actions");
        set => WithProperty("not_data_actions", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermKeyVaultManagedHardwareSecurityModuleRoleDefinitionTimeoutsBlock : TerraformBlock
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

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

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
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
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
    /// The managed_hsm_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ManagedHsmId is required")]
    public required TerraformProperty<string> ManagedHsmId
    {
        get => GetProperty<TerraformProperty<string>>("managed_hsm_id");
        set => this.WithProperty("managed_hsm_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The role_name attribute.
    /// </summary>
    public TerraformProperty<string>? RoleName
    {
        get => GetProperty<TerraformProperty<string>>("role_name");
        set => this.WithProperty("role_name", value);
    }

    /// <summary>
    /// Block for permission.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermKeyVaultManagedHardwareSecurityModuleRoleDefinitionPermissionBlock>? Permission
    {
        get => GetProperty<List<AzurermKeyVaultManagedHardwareSecurityModuleRoleDefinitionPermissionBlock>>("permission");
        set => this.WithProperty("permission", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermKeyVaultManagedHardwareSecurityModuleRoleDefinitionTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermKeyVaultManagedHardwareSecurityModuleRoleDefinitionTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
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
