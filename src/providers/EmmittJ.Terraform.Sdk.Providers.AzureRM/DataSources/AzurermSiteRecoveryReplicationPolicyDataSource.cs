using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermSiteRecoveryReplicationPolicyDataSourceTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_site_recovery_replication_policy.
/// </summary>
public partial class AzurermSiteRecoveryReplicationPolicyDataSource : TerraformDataSource
{
    public AzurermSiteRecoveryReplicationPolicyDataSource(string name) : base("azurerm_site_recovery_replication_policy", name)
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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermSiteRecoveryReplicationPolicyDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The application_consistent_snapshot_frequency_in_minutes attribute.
    /// </summary>
    [TerraformProperty("application_consistent_snapshot_frequency_in_minutes")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> ApplicationConsistentSnapshotFrequencyInMinutes { get; }

    /// <summary>
    /// The recovery_point_retention_in_minutes attribute.
    /// </summary>
    [TerraformProperty("recovery_point_retention_in_minutes")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> RecoveryPointRetentionInMinutes { get; }

}
