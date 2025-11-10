using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for azure_to_azure_settings in .
/// Nesting mode: list
/// </summary>
public class AzurermSiteRecoveryReplicationRecoveryPlanAzureToAzureSettingsBlock : ITerraformBlock
{
    /// <summary>
    /// The primary_edge_zone attribute.
    /// </summary>
    [TerraformPropertyName("primary_edge_zone")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? PrimaryEdgeZone { get; set; }

    /// <summary>
    /// The primary_zone attribute.
    /// </summary>
    [TerraformPropertyName("primary_zone")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? PrimaryZone { get; set; }

    /// <summary>
    /// The recovery_edge_zone attribute.
    /// </summary>
    [TerraformPropertyName("recovery_edge_zone")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? RecoveryEdgeZone { get; set; }

    /// <summary>
    /// The recovery_zone attribute.
    /// </summary>
    [TerraformPropertyName("recovery_zone")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? RecoveryZone { get; set; }

}

/// <summary>
/// Block type for boot_recovery_group in .
/// Nesting mode: list
/// </summary>
public class AzurermSiteRecoveryReplicationRecoveryPlanBootRecoveryGroupBlock : ITerraformBlock
{
    /// <summary>
    /// The replicated_protected_items attribute.
    /// </summary>
    [TerraformPropertyName("replicated_protected_items")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? ReplicatedProtectedItems { get; set; }

}

/// <summary>
/// Block type for failover_recovery_group in .
/// Nesting mode: list
/// </summary>
public class AzurermSiteRecoveryReplicationRecoveryPlanFailoverRecoveryGroupBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for shutdown_recovery_group in .
/// Nesting mode: list
/// </summary>
public class AzurermSiteRecoveryReplicationRecoveryPlanShutdownRecoveryGroupBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermSiteRecoveryReplicationRecoveryPlanTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_site_recovery_replication_recovery_plan resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermSiteRecoveryReplicationRecoveryPlan : TerraformResource
{
    public AzurermSiteRecoveryReplicationRecoveryPlan(string name) : base("azurerm_site_recovery_replication_recovery_plan", name)
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
    /// The source_recovery_fabric_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceRecoveryFabricId is required")]
    [TerraformPropertyName("source_recovery_fabric_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> SourceRecoveryFabricId { get; set; }

    /// <summary>
    /// The target_recovery_fabric_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetRecoveryFabricId is required")]
    [TerraformPropertyName("target_recovery_fabric_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> TargetRecoveryFabricId { get; set; }

    /// <summary>
    /// Block for azure_to_azure_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AzureToAzureSettings block(s) allowed")]
    [TerraformPropertyName("azure_to_azure_settings")]
    public TerraformList<TerraformBlock<AzurermSiteRecoveryReplicationRecoveryPlanAzureToAzureSettingsBlock>>? AzureToAzureSettings { get; set; } = new();

    /// <summary>
    /// Block for boot_recovery_group.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BootRecoveryGroup is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 BootRecoveryGroup block(s) required")]
    [TerraformPropertyName("boot_recovery_group")]
    public TerraformList<TerraformBlock<AzurermSiteRecoveryReplicationRecoveryPlanBootRecoveryGroupBlock>>? BootRecoveryGroup { get; set; } = new();

    /// <summary>
    /// Block for failover_recovery_group.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FailoverRecoveryGroup is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 FailoverRecoveryGroup block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FailoverRecoveryGroup block(s) allowed")]
    [TerraformPropertyName("failover_recovery_group")]
    public TerraformList<TerraformBlock<AzurermSiteRecoveryReplicationRecoveryPlanFailoverRecoveryGroupBlock>>? FailoverRecoveryGroup { get; set; } = new();

    /// <summary>
    /// Block for shutdown_recovery_group.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ShutdownRecoveryGroup is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ShutdownRecoveryGroup block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ShutdownRecoveryGroup block(s) allowed")]
    [TerraformPropertyName("shutdown_recovery_group")]
    public TerraformList<TerraformBlock<AzurermSiteRecoveryReplicationRecoveryPlanShutdownRecoveryGroupBlock>>? ShutdownRecoveryGroup { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermSiteRecoveryReplicationRecoveryPlanTimeoutsBlock>? Timeouts { get; set; } = new();

}
