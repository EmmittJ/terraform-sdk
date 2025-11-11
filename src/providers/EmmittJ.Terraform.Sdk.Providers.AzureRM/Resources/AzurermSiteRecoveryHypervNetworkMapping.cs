using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermSiteRecoveryHypervNetworkMappingTimeoutsBlock : TerraformBlockBase
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
/// Manages a azurerm_site_recovery_hyperv_network_mapping resource.
/// </summary>
public partial class AzurermSiteRecoveryHypervNetworkMapping : TerraformResource
{
    public AzurermSiteRecoveryHypervNetworkMapping(string name) : base("azurerm_site_recovery_hyperv_network_mapping", name)
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
    /// The recovery_vault_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RecoveryVaultId is required")]
    [TerraformProperty("recovery_vault_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> RecoveryVaultId { get; set; }

    /// <summary>
    /// The source_network_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceNetworkName is required")]
    [TerraformProperty("source_network_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> SourceNetworkName { get; set; }

    /// <summary>
    /// The source_system_center_virtual_machine_manager_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceSystemCenterVirtualMachineManagerName is required")]
    [TerraformProperty("source_system_center_virtual_machine_manager_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> SourceSystemCenterVirtualMachineManagerName { get; set; }

    /// <summary>
    /// The target_network_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetNetworkId is required")]
    [TerraformProperty("target_network_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> TargetNetworkId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AzurermSiteRecoveryHypervNetworkMappingTimeoutsBlock>? Timeouts { get; set; }

}
