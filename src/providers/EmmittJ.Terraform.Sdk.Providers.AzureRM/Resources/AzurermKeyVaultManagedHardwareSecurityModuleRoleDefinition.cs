using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for permission in .
/// Nesting mode: list
/// </summary>
public class AzurermKeyVaultManagedHardwareSecurityModuleRoleDefinitionPermissionBlock : ITerraformBlock
{
    /// <summary>
    /// The actions attribute.
    /// </summary>
    [TerraformPropertyName("actions")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? Actions { get; set; }

    /// <summary>
    /// The data_actions attribute.
    /// </summary>
    [TerraformPropertyName("data_actions")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? DataActions { get; set; }

    /// <summary>
    /// The not_actions attribute.
    /// </summary>
    [TerraformPropertyName("not_actions")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? NotActions { get; set; }

    /// <summary>
    /// The not_data_actions attribute.
    /// </summary>
    [TerraformPropertyName("not_data_actions")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? NotDataActions { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermKeyVaultManagedHardwareSecurityModuleRoleDefinitionTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

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
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The managed_hsm_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ManagedHsmId is required")]
    [TerraformPropertyName("managed_hsm_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ManagedHsmId { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The role_name attribute.
    /// </summary>
    [TerraformPropertyName("role_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? RoleName { get; set; }

    /// <summary>
    /// Block for permission.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("permission")]
    public TerraformList<TerraformBlock<AzurermKeyVaultManagedHardwareSecurityModuleRoleDefinitionPermissionBlock>>? Permission { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermKeyVaultManagedHardwareSecurityModuleRoleDefinitionTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The resource_manager_id attribute.
    /// </summary>
    [TerraformPropertyName("resource_manager_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ResourceManagerId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "resource_manager_id");

    /// <summary>
    /// The role_type attribute.
    /// </summary>
    [TerraformPropertyName("role_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> RoleType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "role_type");

}
