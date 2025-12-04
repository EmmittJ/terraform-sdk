using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermKeyVaultManagedHardwareSecurityModuleRoleDefinitionDataSource.
/// Nesting mode: single
/// </summary>
public class AzurermKeyVaultManagedHardwareSecurityModuleRoleDefinitionDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

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
/// Represents a azurerm_key_vault_managed_hardware_security_module_role_definition Terraform data source.
/// Retrieves information about a azurerm_key_vault_managed_hardware_security_module_role_definition.
/// </summary>
public partial class AzurermKeyVaultManagedHardwareSecurityModuleRoleDefinitionDataSource(string name) : TerraformDataSource("azurerm_key_vault_managed_hardware_security_module_role_definition", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The managed_hsm_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ManagedHsmId is required")]
    public required TerraformValue<string> ManagedHsmId
    {
        get => GetArgument<TerraformValue<string>>("managed_hsm_id");
        set => SetArgument("managed_hsm_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The assignable_scopes attribute.
    /// </summary>
    public TerraformList<string> AssignableScopes
        => AsReference("assignable_scopes");

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string> Description
        => AsReference("description");

    /// <summary>
    /// The permission attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Permission
        => AsReference("permission");

    /// <summary>
    /// The resource_manager_id attribute.
    /// </summary>
    public TerraformValue<string> ResourceManagerId
        => AsReference("resource_manager_id");

    /// <summary>
    /// The role_name attribute.
    /// </summary>
    public TerraformValue<string> RoleName
        => AsReference("role_name");

    /// <summary>
    /// The role_type attribute.
    /// </summary>
    public TerraformValue<string> RoleType
        => AsReference("role_type");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermKeyVaultManagedHardwareSecurityModuleRoleDefinitionDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermKeyVaultManagedHardwareSecurityModuleRoleDefinitionDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
