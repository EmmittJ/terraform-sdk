using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermKeyVaultManagedHardwareSecurityModuleRoleAssignmentTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Manages a azurerm_key_vault_managed_hardware_security_module_role_assignment resource.
/// </summary>
public partial class AzurermKeyVaultManagedHardwareSecurityModuleRoleAssignment : TerraformResource
{
    public AzurermKeyVaultManagedHardwareSecurityModuleRoleAssignment(string name) : base("azurerm_key_vault_managed_hardware_security_module_role_assignment", name)
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
    /// The principal_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrincipalId is required")]
    [TerraformProperty("principal_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> PrincipalId { get; set; }

    /// <summary>
    /// The role_definition_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleDefinitionId is required")]
    [TerraformProperty("role_definition_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> RoleDefinitionId { get; set; }

    /// <summary>
    /// The scope attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Scope is required")]
    [TerraformProperty("scope")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Scope { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermKeyVaultManagedHardwareSecurityModuleRoleAssignmentTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The resource_id attribute.
    /// </summary>
    [TerraformProperty("resource_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ResourceId { get; }

}
