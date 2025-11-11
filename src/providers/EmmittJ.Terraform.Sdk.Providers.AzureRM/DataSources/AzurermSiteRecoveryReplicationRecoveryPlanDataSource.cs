using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermSiteRecoveryReplicationRecoveryPlanDataSourceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_site_recovery_replication_recovery_plan.
/// </summary>
public partial class AzurermSiteRecoveryReplicationRecoveryPlanDataSource : TerraformDataSource
{
    public AzurermSiteRecoveryReplicationRecoveryPlanDataSource(string name) : base("azurerm_site_recovery_replication_recovery_plan", name)
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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AzurermSiteRecoveryReplicationRecoveryPlanDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The azure_to_azure_settings attribute.
    /// </summary>
    [TerraformProperty("azure_to_azure_settings")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> AzureToAzureSettings { get; }

    /// <summary>
    /// The failover_deployment_model attribute.
    /// </summary>
    [TerraformProperty("failover_deployment_model")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> FailoverDeploymentModel { get; }

    /// <summary>
    /// The recovery_group attribute.
    /// </summary>
    [TerraformProperty("recovery_group")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformSet<object> RecoveryGroup { get; }

    /// <summary>
    /// The source_recovery_fabric_id attribute.
    /// </summary>
    [TerraformProperty("source_recovery_fabric_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SourceRecoveryFabricId { get; }

    /// <summary>
    /// The target_recovery_fabric_id attribute.
    /// </summary>
    [TerraformProperty("target_recovery_fabric_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> TargetRecoveryFabricId { get; }

}
