using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for permission in .
/// Nesting mode: list
/// </summary>
public partial class AzurermKeyVaultManagedHardwareSecurityModuleRoleDefinitionPermissionBlock : TerraformBlockBase
{
    /// <summary>
    /// The actions attribute.
    /// </summary>
    [TerraformProperty("actions")]
    // Optional argument - source generator will implement get/set
    public TerraformList<string>? Actions { get; set; }

    /// <summary>
    /// The data_actions attribute.
    /// </summary>
    [TerraformProperty("data_actions")]
    // Optional argument - source generator will implement get/set
    public TerraformSet<string>? DataActions { get; set; }

    /// <summary>
    /// The not_actions attribute.
    /// </summary>
    [TerraformProperty("not_actions")]
    // Optional argument - source generator will implement get/set
    public TerraformList<string>? NotActions { get; set; }

    /// <summary>
    /// The not_data_actions attribute.
    /// </summary>
    [TerraformProperty("not_data_actions")]
    // Optional argument - source generator will implement get/set
    public TerraformSet<string>? NotDataActions { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermKeyVaultManagedHardwareSecurityModuleRoleDefinitionTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_key_vault_managed_hardware_security_module_role_definition resource.
/// </summary>
public partial class AzurermKeyVaultManagedHardwareSecurityModuleRoleDefinition : TerraformResource
{
    public AzurermKeyVaultManagedHardwareSecurityModuleRoleDefinition(string name) : base("azurerm_key_vault_managed_hardware_security_module_role_definition", name)
    {
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The managed_hsm_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ManagedHsmId is required")]
    [TerraformProperty("managed_hsm_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ManagedHsmId { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The role_name attribute.
    /// </summary>
    [TerraformProperty("role_name")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? RoleName { get; set; }

    /// <summary>
    /// Block for permission.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("permission")]
    public TerraformList<TerraformBlock<AzurermKeyVaultManagedHardwareSecurityModuleRoleDefinitionPermissionBlock>>? Permission { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermKeyVaultManagedHardwareSecurityModuleRoleDefinitionTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The resource_manager_id attribute.
    /// </summary>
    [TerraformProperty("resource_manager_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ResourceManagerId { get; }

    /// <summary>
    /// The role_type attribute.
    /// </summary>
    [TerraformProperty("role_type")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> RoleType { get; }

}
