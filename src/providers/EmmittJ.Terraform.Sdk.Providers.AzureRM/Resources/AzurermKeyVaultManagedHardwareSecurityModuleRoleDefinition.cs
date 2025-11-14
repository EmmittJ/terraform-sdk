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
/// Block type for permission in .
/// Nesting mode: list
/// </summary>
public class AzurermKeyVaultManagedHardwareSecurityModuleRoleDefinitionPermissionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "permission";

    /// <summary>
    /// The actions attribute.
    /// </summary>
    [TerraformArgument("actions")]
    public TerraformList<string>? Actions
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "actions").ResolveNodes(ctx));
        set => SetArgument("actions", value);
    }

    /// <summary>
    /// The data_actions attribute.
    /// </summary>
    [TerraformArgument("data_actions")]
    public TerraformSet<string>? DataActions
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "data_actions").ResolveNodes(ctx));
        set => SetArgument("data_actions", value);
    }

    /// <summary>
    /// The not_actions attribute.
    /// </summary>
    [TerraformArgument("not_actions")]
    public TerraformList<string>? NotActions
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "not_actions").ResolveNodes(ctx));
        set => SetArgument("not_actions", value);
    }

    /// <summary>
    /// The not_data_actions attribute.
    /// </summary>
    [TerraformArgument("not_data_actions")]
    public TerraformSet<string>? NotDataActions
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "not_data_actions").ResolveNodes(ctx));
        set => SetArgument("not_data_actions", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermKeyVaultManagedHardwareSecurityModuleRoleDefinitionTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformArgument("create")]
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformArgument("delete")]
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformArgument("update")]
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}

/// <summary>
/// Manages a azurerm_key_vault_managed_hardware_security_module_role_definition resource.
/// </summary>
public class AzurermKeyVaultManagedHardwareSecurityModuleRoleDefinition : TerraformResource
{
    public AzurermKeyVaultManagedHardwareSecurityModuleRoleDefinition(string name) : base("azurerm_key_vault_managed_hardware_security_module_role_definition", name)
    {
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformArgument("description")]
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
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
    /// The role_name attribute.
    /// </summary>
    [TerraformArgument("role_name")]
    public TerraformValue<string>? RoleName
    {
        get => new TerraformReference<string>(this, "role_name");
        set => SetArgument("role_name", value);
    }

    /// <summary>
    /// Block for permission.
    /// Nesting mode: list
    /// </summary>
    [TerraformArgument("permission")]
    public TerraformList<AzurermKeyVaultManagedHardwareSecurityModuleRoleDefinitionPermissionBlock> Permission { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermKeyVaultManagedHardwareSecurityModuleRoleDefinitionTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The resource_manager_id attribute.
    /// </summary>
    [TerraformArgument("resource_manager_id")]
    public TerraformValue<string> ResourceManagerId
    {
        get => new TerraformReference<string>(this, "resource_manager_id");
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
