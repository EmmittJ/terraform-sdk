using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermSiteRecoveryNetworkMappingTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Manages a azurerm_site_recovery_network_mapping resource.
/// </summary>
public partial class AzurermSiteRecoveryNetworkMapping : TerraformResource
{
    public AzurermSiteRecoveryNetworkMapping(string name) : base("azurerm_site_recovery_network_mapping", name)
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
    /// The source_network_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceNetworkId is required")]
    [TerraformProperty("source_network_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> SourceNetworkId { get; set; }

    /// <summary>
    /// The source_recovery_fabric_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceRecoveryFabricName is required")]
    [TerraformProperty("source_recovery_fabric_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> SourceRecoveryFabricName { get; set; }

    /// <summary>
    /// The target_network_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetNetworkId is required")]
    [TerraformProperty("target_network_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> TargetNetworkId { get; set; }

    /// <summary>
    /// The target_recovery_fabric_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetRecoveryFabricName is required")]
    [TerraformProperty("target_recovery_fabric_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> TargetRecoveryFabricName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermSiteRecoveryNetworkMappingTimeoutsBlock Timeouts { get; set; } = new();

}
