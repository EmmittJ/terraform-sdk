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
        set => SetProperty("actions", value);
    }

    /// <summary>
    /// The data_actions attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? DataActions
    {
        set => SetProperty("data_actions", value);
    }

    /// <summary>
    /// The not_actions attribute.
    /// </summary>
    public List<TerraformProperty<string>>? NotActions
    {
        set => SetProperty("not_actions", value);
    }

    /// <summary>
    /// The not_data_actions attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? NotDataActions
    {
        set => SetProperty("not_data_actions", value);
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

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
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
        SetOutput("resource_manager_id");
        SetOutput("role_type");
        SetOutput("description");
        SetOutput("id");
        SetOutput("managed_hsm_id");
        SetOutput("name");
        SetOutput("role_name");
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
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
    /// The managed_hsm_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ManagedHsmId is required")]
    public required TerraformProperty<string> ManagedHsmId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("managed_hsm_id");
        set => SetProperty("managed_hsm_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The role_name attribute.
    /// </summary>
    public TerraformProperty<string> RoleName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("role_name");
        set => SetProperty("role_name", value);
    }

    /// <summary>
    /// Block for permission.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermKeyVaultManagedHardwareSecurityModuleRoleDefinitionPermissionBlock>? Permission
    {
        set => SetProperty("permission", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermKeyVaultManagedHardwareSecurityModuleRoleDefinitionTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
