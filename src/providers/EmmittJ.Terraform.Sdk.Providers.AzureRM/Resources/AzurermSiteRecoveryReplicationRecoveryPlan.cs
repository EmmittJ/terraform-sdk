using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

// Resources, Data Sources, Ephemeral Resources, Blocks: Getter ALWAYS returns a reference
// This is the key to natural Terraform syntax
// When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
// The value that was SET is only used during serialization

// Providers: Getter returns stored value
// Providers are not referenced in HCL
// Use required getter if property is required or non-nullable

/// <summary>
/// Block type for azure_to_azure_settings in .
/// Nesting mode: list
/// </summary>
public class AzurermSiteRecoveryReplicationRecoveryPlanAzureToAzureSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "azure_to_azure_settings";

    /// <summary>
    /// The primary_edge_zone attribute.
    /// </summary>
    [TerraformArgument("primary_edge_zone")]
    public TerraformValue<string>? PrimaryEdgeZone
    {
        get => new TerraformReference<string>(this, "primary_edge_zone");
        set => SetArgument("primary_edge_zone", value);
    }

    /// <summary>
    /// The primary_zone attribute.
    /// </summary>
    [TerraformArgument("primary_zone")]
    public TerraformValue<string>? PrimaryZone
    {
        get => new TerraformReference<string>(this, "primary_zone");
        set => SetArgument("primary_zone", value);
    }

    /// <summary>
    /// The recovery_edge_zone attribute.
    /// </summary>
    [TerraformArgument("recovery_edge_zone")]
    public TerraformValue<string>? RecoveryEdgeZone
    {
        get => new TerraformReference<string>(this, "recovery_edge_zone");
        set => SetArgument("recovery_edge_zone", value);
    }

    /// <summary>
    /// The recovery_zone attribute.
    /// </summary>
    [TerraformArgument("recovery_zone")]
    public TerraformValue<string>? RecoveryZone
    {
        get => new TerraformReference<string>(this, "recovery_zone");
        set => SetArgument("recovery_zone", value);
    }

}

/// <summary>
/// Block type for boot_recovery_group in .
/// Nesting mode: list
/// </summary>
public class AzurermSiteRecoveryReplicationRecoveryPlanBootRecoveryGroupBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "boot_recovery_group";

    /// <summary>
    /// The replicated_protected_items attribute.
    /// </summary>
    [TerraformArgument("replicated_protected_items")]
    public TerraformList<string>? ReplicatedProtectedItems
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "replicated_protected_items").ResolveNodes(ctx));
        set => SetArgument("replicated_protected_items", value);
    }

}

/// <summary>
/// Block type for failover_recovery_group in .
/// Nesting mode: list
/// </summary>
public class AzurermSiteRecoveryReplicationRecoveryPlanFailoverRecoveryGroupBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "failover_recovery_group";

}

/// <summary>
/// Block type for shutdown_recovery_group in .
/// Nesting mode: list
/// </summary>
public class AzurermSiteRecoveryReplicationRecoveryPlanShutdownRecoveryGroupBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "shutdown_recovery_group";

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermSiteRecoveryReplicationRecoveryPlanTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformArgument("create")]
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformArgument("delete")]
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformArgument("update")]
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
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
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The recovery_vault_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RecoveryVaultId is required")]
    [TerraformArgument("recovery_vault_id")]
    public required TerraformValue<string> RecoveryVaultId
    {
        get => new TerraformReference<string>(this, "recovery_vault_id");
        set => SetArgument("recovery_vault_id", value);
    }

    /// <summary>
    /// The source_recovery_fabric_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceRecoveryFabricId is required")]
    [TerraformArgument("source_recovery_fabric_id")]
    public required TerraformValue<string> SourceRecoveryFabricId
    {
        get => new TerraformReference<string>(this, "source_recovery_fabric_id");
        set => SetArgument("source_recovery_fabric_id", value);
    }

    /// <summary>
    /// The target_recovery_fabric_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetRecoveryFabricId is required")]
    [TerraformArgument("target_recovery_fabric_id")]
    public required TerraformValue<string> TargetRecoveryFabricId
    {
        get => new TerraformReference<string>(this, "target_recovery_fabric_id");
        set => SetArgument("target_recovery_fabric_id", value);
    }

    /// <summary>
    /// Block for azure_to_azure_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AzureToAzureSettings block(s) allowed")]
    [TerraformArgument("azure_to_azure_settings")]
    public TerraformList<AzurermSiteRecoveryReplicationRecoveryPlanAzureToAzureSettingsBlock> AzureToAzureSettings { get; set; } = new();

    /// <summary>
    /// Block for boot_recovery_group.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BootRecoveryGroup is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 BootRecoveryGroup block(s) required")]
    [TerraformArgument("boot_recovery_group")]
    public required TerraformList<AzurermSiteRecoveryReplicationRecoveryPlanBootRecoveryGroupBlock> BootRecoveryGroup { get; set; } = new();

    /// <summary>
    /// Block for failover_recovery_group.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FailoverRecoveryGroup is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 FailoverRecoveryGroup block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FailoverRecoveryGroup block(s) allowed")]
    [TerraformArgument("failover_recovery_group")]
    public required TerraformList<AzurermSiteRecoveryReplicationRecoveryPlanFailoverRecoveryGroupBlock> FailoverRecoveryGroup { get; set; } = new();

    /// <summary>
    /// Block for shutdown_recovery_group.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ShutdownRecoveryGroup is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ShutdownRecoveryGroup block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ShutdownRecoveryGroup block(s) allowed")]
    [TerraformArgument("shutdown_recovery_group")]
    public required TerraformList<AzurermSiteRecoveryReplicationRecoveryPlanShutdownRecoveryGroupBlock> ShutdownRecoveryGroup { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermSiteRecoveryReplicationRecoveryPlanTimeoutsBlock Timeouts { get; set; } = new();

}
