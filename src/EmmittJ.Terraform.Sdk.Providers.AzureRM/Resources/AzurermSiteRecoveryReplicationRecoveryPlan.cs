using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for azure_to_azure_settings in .
/// Nesting mode: list
/// </summary>
public class AzurermSiteRecoveryReplicationRecoveryPlanAzureToAzureSettingsBlock : TerraformBlock
{
    /// <summary>
    /// The primary_edge_zone attribute.
    /// </summary>
    public TerraformProperty<string>? PrimaryEdgeZone
    {
        get => GetProperty<TerraformProperty<string>>("primary_edge_zone");
        set => WithProperty("primary_edge_zone", value);
    }

    /// <summary>
    /// The primary_zone attribute.
    /// </summary>
    public TerraformProperty<string>? PrimaryZone
    {
        get => GetProperty<TerraformProperty<string>>("primary_zone");
        set => WithProperty("primary_zone", value);
    }

    /// <summary>
    /// The recovery_edge_zone attribute.
    /// </summary>
    public TerraformProperty<string>? RecoveryEdgeZone
    {
        get => GetProperty<TerraformProperty<string>>("recovery_edge_zone");
        set => WithProperty("recovery_edge_zone", value);
    }

    /// <summary>
    /// The recovery_zone attribute.
    /// </summary>
    public TerraformProperty<string>? RecoveryZone
    {
        get => GetProperty<TerraformProperty<string>>("recovery_zone");
        set => WithProperty("recovery_zone", value);
    }

}

/// <summary>
/// Block type for boot_recovery_group in .
/// Nesting mode: list
/// </summary>
public class AzurermSiteRecoveryReplicationRecoveryPlanBootRecoveryGroupBlock : TerraformBlock
{
    /// <summary>
    /// The replicated_protected_items attribute.
    /// </summary>
    public List<TerraformProperty<string>>? ReplicatedProtectedItems
    {
        get => GetProperty<List<TerraformProperty<string>>>("replicated_protected_items");
        set => WithProperty("replicated_protected_items", value);
    }

}

/// <summary>
/// Block type for failover_recovery_group in .
/// Nesting mode: list
/// </summary>
public class AzurermSiteRecoveryReplicationRecoveryPlanFailoverRecoveryGroupBlock : TerraformBlock
{
}

/// <summary>
/// Block type for shutdown_recovery_group in .
/// Nesting mode: list
/// </summary>
public class AzurermSiteRecoveryReplicationRecoveryPlanShutdownRecoveryGroupBlock : TerraformBlock
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermSiteRecoveryReplicationRecoveryPlanTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a azurerm_site_recovery_replication_recovery_plan resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermSiteRecoveryReplicationRecoveryPlan : TerraformResource
{
    public AzurermSiteRecoveryReplicationRecoveryPlan(string name) : base("azurerm_site_recovery_replication_recovery_plan", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The recovery_vault_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RecoveryVaultId is required")]
    public required TerraformProperty<string> RecoveryVaultId
    {
        get => GetProperty<TerraformProperty<string>>("recovery_vault_id");
        set => this.WithProperty("recovery_vault_id", value);
    }

    /// <summary>
    /// The source_recovery_fabric_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceRecoveryFabricId is required")]
    public required TerraformProperty<string> SourceRecoveryFabricId
    {
        get => GetProperty<TerraformProperty<string>>("source_recovery_fabric_id");
        set => this.WithProperty("source_recovery_fabric_id", value);
    }

    /// <summary>
    /// The target_recovery_fabric_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetRecoveryFabricId is required")]
    public required TerraformProperty<string> TargetRecoveryFabricId
    {
        get => GetProperty<TerraformProperty<string>>("target_recovery_fabric_id");
        set => this.WithProperty("target_recovery_fabric_id", value);
    }

    /// <summary>
    /// Block for azure_to_azure_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AzureToAzureSettings block(s) allowed")]
    public List<AzurermSiteRecoveryReplicationRecoveryPlanAzureToAzureSettingsBlock>? AzureToAzureSettings
    {
        get => GetProperty<List<AzurermSiteRecoveryReplicationRecoveryPlanAzureToAzureSettingsBlock>>("azure_to_azure_settings");
        set => this.WithProperty("azure_to_azure_settings", value);
    }

    /// <summary>
    /// Block for boot_recovery_group.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 BootRecoveryGroup block(s) required")]
    public List<AzurermSiteRecoveryReplicationRecoveryPlanBootRecoveryGroupBlock>? BootRecoveryGroup
    {
        get => GetProperty<List<AzurermSiteRecoveryReplicationRecoveryPlanBootRecoveryGroupBlock>>("boot_recovery_group");
        set => this.WithProperty("boot_recovery_group", value);
    }

    /// <summary>
    /// Block for failover_recovery_group.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 FailoverRecoveryGroup block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FailoverRecoveryGroup block(s) allowed")]
    public List<AzurermSiteRecoveryReplicationRecoveryPlanFailoverRecoveryGroupBlock>? FailoverRecoveryGroup
    {
        get => GetProperty<List<AzurermSiteRecoveryReplicationRecoveryPlanFailoverRecoveryGroupBlock>>("failover_recovery_group");
        set => this.WithProperty("failover_recovery_group", value);
    }

    /// <summary>
    /// Block for shutdown_recovery_group.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ShutdownRecoveryGroup block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ShutdownRecoveryGroup block(s) allowed")]
    public List<AzurermSiteRecoveryReplicationRecoveryPlanShutdownRecoveryGroupBlock>? ShutdownRecoveryGroup
    {
        get => GetProperty<List<AzurermSiteRecoveryReplicationRecoveryPlanShutdownRecoveryGroupBlock>>("shutdown_recovery_group");
        set => this.WithProperty("shutdown_recovery_group", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermSiteRecoveryReplicationRecoveryPlanTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermSiteRecoveryReplicationRecoveryPlanTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
