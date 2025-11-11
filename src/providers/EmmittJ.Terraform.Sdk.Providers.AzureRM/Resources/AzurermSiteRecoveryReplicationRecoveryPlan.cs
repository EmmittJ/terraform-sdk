using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for azure_to_azure_settings in .
/// Nesting mode: list
/// </summary>
public partial class AzurermSiteRecoveryReplicationRecoveryPlanAzureToAzureSettingsBlock : TerraformBlockBase
{
    /// <summary>
    /// The primary_edge_zone attribute.
    /// </summary>
    [TerraformProperty("primary_edge_zone")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? PrimaryEdgeZone { get; set; }

    /// <summary>
    /// The primary_zone attribute.
    /// </summary>
    [TerraformProperty("primary_zone")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? PrimaryZone { get; set; }

    /// <summary>
    /// The recovery_edge_zone attribute.
    /// </summary>
    [TerraformProperty("recovery_edge_zone")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? RecoveryEdgeZone { get; set; }

    /// <summary>
    /// The recovery_zone attribute.
    /// </summary>
    [TerraformProperty("recovery_zone")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? RecoveryZone { get; set; }

}

/// <summary>
/// Block type for boot_recovery_group in .
/// Nesting mode: list
/// </summary>
public partial class AzurermSiteRecoveryReplicationRecoveryPlanBootRecoveryGroupBlock : TerraformBlockBase
{
    /// <summary>
    /// The replicated_protected_items attribute.
    /// </summary>
    [TerraformProperty("replicated_protected_items")]
    // Optional argument - source generator will implement get/set
    public TerraformList<string>? ReplicatedProtectedItems { get; set; }

}

/// <summary>
/// Block type for failover_recovery_group in .
/// Nesting mode: list
/// </summary>
public partial class AzurermSiteRecoveryReplicationRecoveryPlanFailoverRecoveryGroupBlock : TerraformBlockBase
{
}

/// <summary>
/// Block type for shutdown_recovery_group in .
/// Nesting mode: list
/// </summary>
public partial class AzurermSiteRecoveryReplicationRecoveryPlanShutdownRecoveryGroupBlock : TerraformBlockBase
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermSiteRecoveryReplicationRecoveryPlanTimeoutsBlock : TerraformBlockBase
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
/// Manages a azurerm_site_recovery_replication_recovery_plan resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermSiteRecoveryReplicationRecoveryPlan : TerraformResource
{
    public AzurermSiteRecoveryReplicationRecoveryPlan(string name) : base("azurerm_site_recovery_replication_recovery_plan", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The recovery_vault_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RecoveryVaultId is required")]
    [TerraformProperty("recovery_vault_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> RecoveryVaultId { get; set; }

    /// <summary>
    /// The source_recovery_fabric_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceRecoveryFabricId is required")]
    [TerraformProperty("source_recovery_fabric_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> SourceRecoveryFabricId { get; set; }

    /// <summary>
    /// The target_recovery_fabric_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetRecoveryFabricId is required")]
    [TerraformProperty("target_recovery_fabric_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> TargetRecoveryFabricId { get; set; }

    /// <summary>
    /// Block for azure_to_azure_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AzureToAzureSettings block(s) allowed")]
    [TerraformProperty("azure_to_azure_settings")]
    public TerraformList<TerraformBlock<AzurermSiteRecoveryReplicationRecoveryPlanAzureToAzureSettingsBlock>>? AzureToAzureSettings { get; set; }

    /// <summary>
    /// Block for boot_recovery_group.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BootRecoveryGroup is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 BootRecoveryGroup block(s) required")]
    [TerraformProperty("boot_recovery_group")]
    public TerraformList<TerraformBlock<AzurermSiteRecoveryReplicationRecoveryPlanBootRecoveryGroupBlock>>? BootRecoveryGroup { get; set; }

    /// <summary>
    /// Block for failover_recovery_group.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FailoverRecoveryGroup is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 FailoverRecoveryGroup block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FailoverRecoveryGroup block(s) allowed")]
    [TerraformProperty("failover_recovery_group")]
    public TerraformList<TerraformBlock<AzurermSiteRecoveryReplicationRecoveryPlanFailoverRecoveryGroupBlock>>? FailoverRecoveryGroup { get; set; }

    /// <summary>
    /// Block for shutdown_recovery_group.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ShutdownRecoveryGroup is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ShutdownRecoveryGroup block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ShutdownRecoveryGroup block(s) allowed")]
    [TerraformProperty("shutdown_recovery_group")]
    public TerraformList<TerraformBlock<AzurermSiteRecoveryReplicationRecoveryPlanShutdownRecoveryGroupBlock>>? ShutdownRecoveryGroup { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermSiteRecoveryReplicationRecoveryPlanTimeoutsBlock>? Timeouts { get; set; }

}
