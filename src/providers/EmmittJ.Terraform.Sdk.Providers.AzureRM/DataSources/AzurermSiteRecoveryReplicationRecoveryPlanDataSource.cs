using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermSiteRecoveryReplicationRecoveryPlanDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_site_recovery_replication_recovery_plan.
/// </summary>
public class AzurermSiteRecoveryReplicationRecoveryPlanDataSource : TerraformDataSource
{
    public AzurermSiteRecoveryReplicationRecoveryPlanDataSource(string name) : base("azurerm_site_recovery_replication_recovery_plan", name)
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
    /// The recovery_vault_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RecoveryVaultId is required")]
    [TerraformPropertyName("recovery_vault_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> RecoveryVaultId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermSiteRecoveryReplicationRecoveryPlanDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The azure_to_azure_settings attribute.
    /// </summary>
    [TerraformPropertyName("azure_to_azure_settings")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> AzureToAzureSettings => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "azure_to_azure_settings");

    /// <summary>
    /// The failover_deployment_model attribute.
    /// </summary>
    [TerraformPropertyName("failover_deployment_model")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> FailoverDeploymentModel => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "failover_deployment_model");

    /// <summary>
    /// The recovery_group attribute.
    /// </summary>
    [TerraformPropertyName("recovery_group")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<object>>> RecoveryGroup => new TerraformReferenceProperty<HashSet<TerraformProperty<object>>>(ResourceAddress, "recovery_group");

    /// <summary>
    /// The source_recovery_fabric_id attribute.
    /// </summary>
    [TerraformPropertyName("source_recovery_fabric_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SourceRecoveryFabricId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "source_recovery_fabric_id");

    /// <summary>
    /// The target_recovery_fabric_id attribute.
    /// </summary>
    [TerraformPropertyName("target_recovery_fabric_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> TargetRecoveryFabricId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "target_recovery_fabric_id");

}
