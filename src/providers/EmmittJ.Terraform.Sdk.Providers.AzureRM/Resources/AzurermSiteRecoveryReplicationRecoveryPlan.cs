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
        set => SetProperty("primary_edge_zone", value);
    }

    /// <summary>
    /// The primary_zone attribute.
    /// </summary>
    public TerraformProperty<string>? PrimaryZone
    {
        set => SetProperty("primary_zone", value);
    }

    /// <summary>
    /// The recovery_edge_zone attribute.
    /// </summary>
    public TerraformProperty<string>? RecoveryEdgeZone
    {
        set => SetProperty("recovery_edge_zone", value);
    }

    /// <summary>
    /// The recovery_zone attribute.
    /// </summary>
    public TerraformProperty<string>? RecoveryZone
    {
        set => SetProperty("recovery_zone", value);
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
        set => SetProperty("replicated_protected_items", value);
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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
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
        SetOutput("id");
        SetOutput("name");
        SetOutput("recovery_vault_id");
        SetOutput("source_recovery_fabric_id");
        SetOutput("target_recovery_fabric_id");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The recovery_vault_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RecoveryVaultId is required")]
    public required TerraformProperty<string> RecoveryVaultId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("recovery_vault_id");
        set => SetProperty("recovery_vault_id", value);
    }

    /// <summary>
    /// The source_recovery_fabric_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceRecoveryFabricId is required")]
    public required TerraformProperty<string> SourceRecoveryFabricId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("source_recovery_fabric_id");
        set => SetProperty("source_recovery_fabric_id", value);
    }

    /// <summary>
    /// The target_recovery_fabric_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetRecoveryFabricId is required")]
    public required TerraformProperty<string> TargetRecoveryFabricId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("target_recovery_fabric_id");
        set => SetProperty("target_recovery_fabric_id", value);
    }

    /// <summary>
    /// Block for azure_to_azure_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AzureToAzureSettings block(s) allowed")]
    public List<AzurermSiteRecoveryReplicationRecoveryPlanAzureToAzureSettingsBlock>? AzureToAzureSettings
    {
        set => SetProperty("azure_to_azure_settings", value);
    }

    /// <summary>
    /// Block for boot_recovery_group.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BootRecoveryGroup is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 BootRecoveryGroup block(s) required")]
    public List<AzurermSiteRecoveryReplicationRecoveryPlanBootRecoveryGroupBlock>? BootRecoveryGroup
    {
        set => SetProperty("boot_recovery_group", value);
    }

    /// <summary>
    /// Block for failover_recovery_group.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FailoverRecoveryGroup is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 FailoverRecoveryGroup block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FailoverRecoveryGroup block(s) allowed")]
    public List<AzurermSiteRecoveryReplicationRecoveryPlanFailoverRecoveryGroupBlock>? FailoverRecoveryGroup
    {
        set => SetProperty("failover_recovery_group", value);
    }

    /// <summary>
    /// Block for shutdown_recovery_group.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ShutdownRecoveryGroup is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ShutdownRecoveryGroup block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ShutdownRecoveryGroup block(s) allowed")]
    public List<AzurermSiteRecoveryReplicationRecoveryPlanShutdownRecoveryGroupBlock>? ShutdownRecoveryGroup
    {
        set => SetProperty("shutdown_recovery_group", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermSiteRecoveryReplicationRecoveryPlanTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
