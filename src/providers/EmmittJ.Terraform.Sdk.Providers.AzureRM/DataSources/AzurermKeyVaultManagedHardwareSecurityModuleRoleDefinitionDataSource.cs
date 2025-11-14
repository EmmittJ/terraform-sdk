using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

// Resources, Data Sources, Ephemeral Resources, Blocks: Getter ALWAYS returns a reference
// This is the key to natural Terraform syntax
// When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
// The value that was SET is only used during serialization

// Providers: Getter returns stored value
// Providers are not referenced in HCL
// Use required getter if property is required or non-nullable

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
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}

/// <summary>
/// Retrieves information about a azurerm_key_vault_managed_hardware_security_module_role_definition.
/// </summary>
public class AzurermKeyVaultManagedHardwareSecurityModuleRoleDefinitionDataSource : TerraformDataSource
{
    public AzurermKeyVaultManagedHardwareSecurityModuleRoleDefinitionDataSource(string name) : base("azurerm_key_vault_managed_hardware_security_module_role_definition", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The managed_hsm_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ManagedHsmId is required")]
    [TerraformArgument("managed_hsm_id")]
    public required TerraformValue<string> ManagedHsmId
    {
        get => new TerraformReference<string>(this, "managed_hsm_id");
        set => SetArgument("managed_hsm_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermKeyVaultManagedHardwareSecurityModuleRoleDefinitionDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The assignable_scopes attribute.
    /// </summary>
    [TerraformArgument("assignable_scopes")]
    public TerraformList<string> AssignableScopes
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "assignable_scopes").ResolveNodes(ctx));
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformArgument("description")]
    public TerraformValue<string> Description
    {
        get => new TerraformReference<string>(this, "description");
    }

    /// <summary>
    /// The permission attribute.
    /// </summary>
    [TerraformArgument("permission")]
    public TerraformList<object> Permission
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "permission").ResolveNodes(ctx));
    }

    /// <summary>
    /// The resource_manager_id attribute.
    /// </summary>
    [TerraformArgument("resource_manager_id")]
    public TerraformValue<string> ResourceManagerId
    {
        get => new TerraformReference<string>(this, "resource_manager_id");
    }

    /// <summary>
    /// The role_name attribute.
    /// </summary>
    [TerraformArgument("role_name")]
    public TerraformValue<string> RoleName
    {
        get => new TerraformReference<string>(this, "role_name");
    }

    /// <summary>
    /// The role_type attribute.
    /// </summary>
    [TerraformArgument("role_type")]
    public TerraformValue<string> RoleType
    {
        get => new TerraformReference<string>(this, "role_type");
    }

}
