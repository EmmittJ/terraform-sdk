using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermSiteRecoveryReplicationPolicyDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_site_recovery_replication_policy.
/// </summary>
public class AzurermSiteRecoveryReplicationPolicyDataSource : TerraformDataSource
{
    public AzurermSiteRecoveryReplicationPolicyDataSource(string name) : base("azurerm_site_recovery_replication_policy", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The recovery_vault_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RecoveryVaultName is required")]
    [TerraformPropertyName("recovery_vault_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> RecoveryVaultName { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ResourceGroupName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermSiteRecoveryReplicationPolicyDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The application_consistent_snapshot_frequency_in_minutes attribute.
    /// </summary>
    [TerraformPropertyName("application_consistent_snapshot_frequency_in_minutes")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> ApplicationConsistentSnapshotFrequencyInMinutes => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "application_consistent_snapshot_frequency_in_minutes");

    /// <summary>
    /// The recovery_point_retention_in_minutes attribute.
    /// </summary>
    [TerraformPropertyName("recovery_point_retention_in_minutes")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> RecoveryPointRetentionInMinutes => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "recovery_point_retention_in_minutes");

}
