using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in .
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
        get => new TerraformReference<string>(this, "read");
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
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The managed_hsm_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ManagedHsmId is required")]
    public required TerraformValue<string> ManagedHsmId
    {
        get => new TerraformReference<string>(this, "managed_hsm_id");
        set => SetArgument("managed_hsm_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The assignable_scopes attribute.
    /// </summary>
    public TerraformList<string> AssignableScopes
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "assignable_scopes").ResolveNodes(ctx));
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string> Description
    {
        get => new TerraformReference<string>(this, "description");
    }

    /// <summary>
    /// The permission attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Permission
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "permission").ResolveNodes(ctx));
    }

    /// <summary>
    /// The resource_manager_id attribute.
    /// </summary>
    public TerraformValue<string> ResourceManagerId
    {
        get => new TerraformReference<string>(this, "resource_manager_id");
    }

    /// <summary>
    /// The role_name attribute.
    /// </summary>
    public TerraformValue<string> RoleName
    {
        get => new TerraformReference<string>(this, "role_name");
    }

    /// <summary>
    /// The role_type attribute.
    /// </summary>
    public TerraformValue<string> RoleType
    {
        get => new TerraformReference<string>(this, "role_type");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermKeyVaultManagedHardwareSecurityModuleRoleDefinitionDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermKeyVaultManagedHardwareSecurityModuleRoleDefinitionDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
