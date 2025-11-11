using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for automatic_update in .
/// Nesting mode: list
/// </summary>
public partial class AzurermSiteRecoveryProtectionContainerMappingAutomaticUpdateBlock : TerraformBlockBase
{
    /// <summary>
    /// The authentication_type attribute.
    /// </summary>
    [TerraformProperty("authentication_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AuthenticationType { get; set; }

    /// <summary>
    /// The automation_account_id attribute.
    /// </summary>
    [TerraformProperty("automation_account_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AutomationAccountId { get; set; }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformProperty("enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Enabled { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermSiteRecoveryProtectionContainerMappingTimeoutsBlock : TerraformBlockBase
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

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_site_recovery_protection_container_mapping resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermSiteRecoveryProtectionContainerMapping : TerraformResource
{
    public AzurermSiteRecoveryProtectionContainerMapping(string name) : base("azurerm_site_recovery_protection_container_mapping", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The recovery_fabric_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RecoveryFabricName is required")]
    [TerraformProperty("recovery_fabric_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> RecoveryFabricName { get; set; }

    /// <summary>
    /// The recovery_replication_policy_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RecoveryReplicationPolicyId is required")]
    [TerraformProperty("recovery_replication_policy_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> RecoveryReplicationPolicyId { get; set; }

    /// <summary>
    /// The recovery_source_protection_container_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RecoverySourceProtectionContainerName is required")]
    [TerraformProperty("recovery_source_protection_container_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> RecoverySourceProtectionContainerName { get; set; }

    /// <summary>
    /// The recovery_target_protection_container_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RecoveryTargetProtectionContainerId is required")]
    [TerraformProperty("recovery_target_protection_container_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> RecoveryTargetProtectionContainerId { get; set; }

    /// <summary>
    /// The recovery_vault_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RecoveryVaultName is required")]
    [TerraformProperty("recovery_vault_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> RecoveryVaultName { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// Block for automatic_update.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutomaticUpdate block(s) allowed")]
    [TerraformProperty("automatic_update")]
    public partial TerraformList<TerraformBlock<AzurermSiteRecoveryProtectionContainerMappingAutomaticUpdateBlock>>? AutomaticUpdate { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AzurermSiteRecoveryProtectionContainerMappingTimeoutsBlock>? Timeouts { get; set; }

}
