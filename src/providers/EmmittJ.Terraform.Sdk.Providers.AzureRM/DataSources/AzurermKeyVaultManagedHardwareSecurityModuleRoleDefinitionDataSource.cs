using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermKeyVaultManagedHardwareSecurityModuleRoleDefinitionDataSourceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_key_vault_managed_hardware_security_module_role_definition.
/// </summary>
public partial class AzurermKeyVaultManagedHardwareSecurityModuleRoleDefinitionDataSource : TerraformDataSource
{
    public AzurermKeyVaultManagedHardwareSecurityModuleRoleDefinitionDataSource(string name) : base("azurerm_key_vault_managed_hardware_security_module_role_definition", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The managed_hsm_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ManagedHsmId is required")]
    [TerraformProperty("managed_hsm_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ManagedHsmId { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AzurermKeyVaultManagedHardwareSecurityModuleRoleDefinitionDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The assignable_scopes attribute.
    /// </summary>
    [TerraformProperty("assignable_scopes")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> AssignableScopes { get; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Description { get; }

    /// <summary>
    /// The permission attribute.
    /// </summary>
    [TerraformProperty("permission")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> Permission { get; }

    /// <summary>
    /// The resource_manager_id attribute.
    /// </summary>
    [TerraformProperty("resource_manager_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ResourceManagerId { get; }

    /// <summary>
    /// The role_name attribute.
    /// </summary>
    [TerraformProperty("role_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> RoleName { get; }

    /// <summary>
    /// The role_type attribute.
    /// </summary>
    [TerraformProperty("role_type")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> RoleType { get; }

}
