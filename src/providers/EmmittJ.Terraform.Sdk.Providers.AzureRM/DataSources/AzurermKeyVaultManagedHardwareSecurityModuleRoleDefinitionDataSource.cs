using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermKeyVaultManagedHardwareSecurityModuleRoleDefinitionDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermKeyVaultManagedHardwareSecurityModuleRoleDefinitionDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The assignable_scopes attribute.
    /// </summary>
    [TerraformPropertyName("assignable_scopes")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> AssignableScopes => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "assignable_scopes");

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Description => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "description");

    /// <summary>
    /// The permission attribute.
    /// </summary>
    [TerraformPropertyName("permission")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Permission => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "permission");

    /// <summary>
    /// The resource_manager_id attribute.
    /// </summary>
    [TerraformPropertyName("resource_manager_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ResourceManagerId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "resource_manager_id");

    /// <summary>
    /// The role_name attribute.
    /// </summary>
    [TerraformPropertyName("role_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> RoleName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "role_name");

    /// <summary>
    /// The role_type attribute.
    /// </summary>
    [TerraformPropertyName("role_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> RoleType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "role_type");

}
