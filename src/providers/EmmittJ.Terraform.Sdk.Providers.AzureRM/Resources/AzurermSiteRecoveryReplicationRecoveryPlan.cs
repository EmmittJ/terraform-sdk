using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

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
    public TerraformValue<string>? PrimaryEdgeZone
    {
        get => new TerraformReference<string>(this, "primary_edge_zone");
        set => SetArgument("primary_edge_zone", value);
    }

    /// <summary>
    /// The primary_zone attribute.
    /// </summary>
    public TerraformValue<string>? PrimaryZone
    {
        get => new TerraformReference<string>(this, "primary_zone");
        set => SetArgument("primary_zone", value);
    }

    /// <summary>
    /// The recovery_edge_zone attribute.
    /// </summary>
    public TerraformValue<string>? RecoveryEdgeZone
    {
        get => new TerraformReference<string>(this, "recovery_edge_zone");
        set => SetArgument("recovery_edge_zone", value);
    }

    /// <summary>
    /// The recovery_zone attribute.
    /// </summary>
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
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}

/// <summary>
/// Represents a azurerm_site_recovery_replication_recovery_plan Terraform resource.
/// Manages a azurerm_site_recovery_replication_recovery_plan resource.
/// </summary>
public partial class AzurermSiteRecoveryReplicationRecoveryPlan(string name) : TerraformResource("azurerm_site_recovery_replication_recovery_plan", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The recovery_vault_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RecoveryVaultId is required")]
    public required TerraformValue<string> RecoveryVaultId
    {
        get => new TerraformReference<string>(this, "recovery_vault_id");
        set => SetArgument("recovery_vault_id", value);
    }

    /// <summary>
    /// The source_recovery_fabric_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceRecoveryFabricId is required")]
    public required TerraformValue<string> SourceRecoveryFabricId
    {
        get => new TerraformReference<string>(this, "source_recovery_fabric_id");
        set => SetArgument("source_recovery_fabric_id", value);
    }

    /// <summary>
    /// The target_recovery_fabric_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetRecoveryFabricId is required")]
    public required TerraformValue<string> TargetRecoveryFabricId
    {
        get => new TerraformReference<string>(this, "target_recovery_fabric_id");
        set => SetArgument("target_recovery_fabric_id", value);
    }

    /// <summary>
    /// AzureToAzureSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AzureToAzureSettings block(s) allowed")]
    public AzurermSiteRecoveryReplicationRecoveryPlanAzureToAzureSettingsBlock? AzureToAzureSettings
    {
        get => GetArgument<AzurermSiteRecoveryReplicationRecoveryPlanAzureToAzureSettingsBlock>("azure_to_azure_settings");
        set => SetArgument("azure_to_azure_settings", value);
    }

    /// <summary>
    /// BootRecoveryGroup block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BootRecoveryGroup is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 BootRecoveryGroup block(s) required")]
    public required AzurermSiteRecoveryReplicationRecoveryPlanBootRecoveryGroupBlock BootRecoveryGroup
    {
        get => GetRequiredArgument<AzurermSiteRecoveryReplicationRecoveryPlanBootRecoveryGroupBlock>("boot_recovery_group");
        set => SetArgument("boot_recovery_group", value);
    }

    /// <summary>
    /// FailoverRecoveryGroup block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FailoverRecoveryGroup is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 FailoverRecoveryGroup block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FailoverRecoveryGroup block(s) allowed")]
    public required AzurermSiteRecoveryReplicationRecoveryPlanFailoverRecoveryGroupBlock FailoverRecoveryGroup
    {
        get => GetRequiredArgument<AzurermSiteRecoveryReplicationRecoveryPlanFailoverRecoveryGroupBlock>("failover_recovery_group");
        set => SetArgument("failover_recovery_group", value);
    }

    /// <summary>
    /// ShutdownRecoveryGroup block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ShutdownRecoveryGroup is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ShutdownRecoveryGroup block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ShutdownRecoveryGroup block(s) allowed")]
    public required AzurermSiteRecoveryReplicationRecoveryPlanShutdownRecoveryGroupBlock ShutdownRecoveryGroup
    {
        get => GetRequiredArgument<AzurermSiteRecoveryReplicationRecoveryPlanShutdownRecoveryGroupBlock>("shutdown_recovery_group");
        set => SetArgument("shutdown_recovery_group", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermSiteRecoveryReplicationRecoveryPlanTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermSiteRecoveryReplicationRecoveryPlanTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
