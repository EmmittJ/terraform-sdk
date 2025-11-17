using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for azure_to_azure_settings in AzurermSiteRecoveryReplicationRecoveryPlan.
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
/// Block type for boot_recovery_group in AzurermSiteRecoveryReplicationRecoveryPlan.
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

    /// <summary>
    /// PostAction block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermSiteRecoveryReplicationRecoveryPlanBootRecoveryGroupBlockPostActionBlock>? PostAction
    {
        get => GetArgument<TerraformList<AzurermSiteRecoveryReplicationRecoveryPlanBootRecoveryGroupBlockPostActionBlock>>("post_action");
        set => SetArgument("post_action", value);
    }

    /// <summary>
    /// PreAction block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermSiteRecoveryReplicationRecoveryPlanBootRecoveryGroupBlockPreActionBlock>? PreAction
    {
        get => GetArgument<TerraformList<AzurermSiteRecoveryReplicationRecoveryPlanBootRecoveryGroupBlockPreActionBlock>>("pre_action");
        set => SetArgument("pre_action", value);
    }

}

/// <summary>
/// Block type for post_action in AzurermSiteRecoveryReplicationRecoveryPlanBootRecoveryGroupBlock.
/// Nesting mode: list
/// </summary>
public class AzurermSiteRecoveryReplicationRecoveryPlanBootRecoveryGroupBlockPostActionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "post_action";

    /// <summary>
    /// The fabric_location attribute.
    /// </summary>
    public TerraformValue<string>? FabricLocation
    {
        get => new TerraformReference<string>(this, "fabric_location");
        set => SetArgument("fabric_location", value);
    }

    /// <summary>
    /// The fail_over_directions attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FailOverDirections is required")]
    public required TerraformSet<string> FailOverDirections
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "fail_over_directions").ResolveNodes(ctx));
        set => SetArgument("fail_over_directions", value);
    }

    /// <summary>
    /// The fail_over_types attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FailOverTypes is required")]
    public required TerraformSet<string> FailOverTypes
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "fail_over_types").ResolveNodes(ctx));
        set => SetArgument("fail_over_types", value);
    }

    /// <summary>
    /// The manual_action_instruction attribute.
    /// </summary>
    public TerraformValue<string>? ManualActionInstruction
    {
        get => new TerraformReference<string>(this, "manual_action_instruction");
        set => SetArgument("manual_action_instruction", value);
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
    /// The runbook_id attribute.
    /// </summary>
    public TerraformValue<string>? RunbookId
    {
        get => new TerraformReference<string>(this, "runbook_id");
        set => SetArgument("runbook_id", value);
    }

    /// <summary>
    /// The script_path attribute.
    /// </summary>
    public TerraformValue<string>? ScriptPath
    {
        get => new TerraformReference<string>(this, "script_path");
        set => SetArgument("script_path", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

}

/// <summary>
/// Block type for pre_action in AzurermSiteRecoveryReplicationRecoveryPlanBootRecoveryGroupBlock.
/// Nesting mode: list
/// </summary>
public class AzurermSiteRecoveryReplicationRecoveryPlanBootRecoveryGroupBlockPreActionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "pre_action";

    /// <summary>
    /// The fabric_location attribute.
    /// </summary>
    public TerraformValue<string>? FabricLocation
    {
        get => new TerraformReference<string>(this, "fabric_location");
        set => SetArgument("fabric_location", value);
    }

    /// <summary>
    /// The fail_over_directions attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FailOverDirections is required")]
    public required TerraformSet<string> FailOverDirections
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "fail_over_directions").ResolveNodes(ctx));
        set => SetArgument("fail_over_directions", value);
    }

    /// <summary>
    /// The fail_over_types attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FailOverTypes is required")]
    public required TerraformSet<string> FailOverTypes
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "fail_over_types").ResolveNodes(ctx));
        set => SetArgument("fail_over_types", value);
    }

    /// <summary>
    /// The manual_action_instruction attribute.
    /// </summary>
    public TerraformValue<string>? ManualActionInstruction
    {
        get => new TerraformReference<string>(this, "manual_action_instruction");
        set => SetArgument("manual_action_instruction", value);
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
    /// The runbook_id attribute.
    /// </summary>
    public TerraformValue<string>? RunbookId
    {
        get => new TerraformReference<string>(this, "runbook_id");
        set => SetArgument("runbook_id", value);
    }

    /// <summary>
    /// The script_path attribute.
    /// </summary>
    public TerraformValue<string>? ScriptPath
    {
        get => new TerraformReference<string>(this, "script_path");
        set => SetArgument("script_path", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Block type for failover_recovery_group in AzurermSiteRecoveryReplicationRecoveryPlan.
/// Nesting mode: list
/// </summary>
public class AzurermSiteRecoveryReplicationRecoveryPlanFailoverRecoveryGroupBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "failover_recovery_group";

    /// <summary>
    /// PostAction block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermSiteRecoveryReplicationRecoveryPlanFailoverRecoveryGroupBlockPostActionBlock>? PostAction
    {
        get => GetArgument<TerraformList<AzurermSiteRecoveryReplicationRecoveryPlanFailoverRecoveryGroupBlockPostActionBlock>>("post_action");
        set => SetArgument("post_action", value);
    }

    /// <summary>
    /// PreAction block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermSiteRecoveryReplicationRecoveryPlanFailoverRecoveryGroupBlockPreActionBlock>? PreAction
    {
        get => GetArgument<TerraformList<AzurermSiteRecoveryReplicationRecoveryPlanFailoverRecoveryGroupBlockPreActionBlock>>("pre_action");
        set => SetArgument("pre_action", value);
    }

}

/// <summary>
/// Block type for post_action in AzurermSiteRecoveryReplicationRecoveryPlanFailoverRecoveryGroupBlock.
/// Nesting mode: list
/// </summary>
public class AzurermSiteRecoveryReplicationRecoveryPlanFailoverRecoveryGroupBlockPostActionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "post_action";

    /// <summary>
    /// The fabric_location attribute.
    /// </summary>
    public TerraformValue<string>? FabricLocation
    {
        get => new TerraformReference<string>(this, "fabric_location");
        set => SetArgument("fabric_location", value);
    }

    /// <summary>
    /// The fail_over_directions attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FailOverDirections is required")]
    public required TerraformSet<string> FailOverDirections
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "fail_over_directions").ResolveNodes(ctx));
        set => SetArgument("fail_over_directions", value);
    }

    /// <summary>
    /// The fail_over_types attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FailOverTypes is required")]
    public required TerraformSet<string> FailOverTypes
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "fail_over_types").ResolveNodes(ctx));
        set => SetArgument("fail_over_types", value);
    }

    /// <summary>
    /// The manual_action_instruction attribute.
    /// </summary>
    public TerraformValue<string>? ManualActionInstruction
    {
        get => new TerraformReference<string>(this, "manual_action_instruction");
        set => SetArgument("manual_action_instruction", value);
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
    /// The runbook_id attribute.
    /// </summary>
    public TerraformValue<string>? RunbookId
    {
        get => new TerraformReference<string>(this, "runbook_id");
        set => SetArgument("runbook_id", value);
    }

    /// <summary>
    /// The script_path attribute.
    /// </summary>
    public TerraformValue<string>? ScriptPath
    {
        get => new TerraformReference<string>(this, "script_path");
        set => SetArgument("script_path", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

}

/// <summary>
/// Block type for pre_action in AzurermSiteRecoveryReplicationRecoveryPlanFailoverRecoveryGroupBlock.
/// Nesting mode: list
/// </summary>
public class AzurermSiteRecoveryReplicationRecoveryPlanFailoverRecoveryGroupBlockPreActionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "pre_action";

    /// <summary>
    /// The fabric_location attribute.
    /// </summary>
    public TerraformValue<string>? FabricLocation
    {
        get => new TerraformReference<string>(this, "fabric_location");
        set => SetArgument("fabric_location", value);
    }

    /// <summary>
    /// The fail_over_directions attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FailOverDirections is required")]
    public required TerraformSet<string> FailOverDirections
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "fail_over_directions").ResolveNodes(ctx));
        set => SetArgument("fail_over_directions", value);
    }

    /// <summary>
    /// The fail_over_types attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FailOverTypes is required")]
    public required TerraformSet<string> FailOverTypes
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "fail_over_types").ResolveNodes(ctx));
        set => SetArgument("fail_over_types", value);
    }

    /// <summary>
    /// The manual_action_instruction attribute.
    /// </summary>
    public TerraformValue<string>? ManualActionInstruction
    {
        get => new TerraformReference<string>(this, "manual_action_instruction");
        set => SetArgument("manual_action_instruction", value);
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
    /// The runbook_id attribute.
    /// </summary>
    public TerraformValue<string>? RunbookId
    {
        get => new TerraformReference<string>(this, "runbook_id");
        set => SetArgument("runbook_id", value);
    }

    /// <summary>
    /// The script_path attribute.
    /// </summary>
    public TerraformValue<string>? ScriptPath
    {
        get => new TerraformReference<string>(this, "script_path");
        set => SetArgument("script_path", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Block type for shutdown_recovery_group in AzurermSiteRecoveryReplicationRecoveryPlan.
/// Nesting mode: list
/// </summary>
public class AzurermSiteRecoveryReplicationRecoveryPlanShutdownRecoveryGroupBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "shutdown_recovery_group";

    /// <summary>
    /// PostAction block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermSiteRecoveryReplicationRecoveryPlanShutdownRecoveryGroupBlockPostActionBlock>? PostAction
    {
        get => GetArgument<TerraformList<AzurermSiteRecoveryReplicationRecoveryPlanShutdownRecoveryGroupBlockPostActionBlock>>("post_action");
        set => SetArgument("post_action", value);
    }

    /// <summary>
    /// PreAction block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermSiteRecoveryReplicationRecoveryPlanShutdownRecoveryGroupBlockPreActionBlock>? PreAction
    {
        get => GetArgument<TerraformList<AzurermSiteRecoveryReplicationRecoveryPlanShutdownRecoveryGroupBlockPreActionBlock>>("pre_action");
        set => SetArgument("pre_action", value);
    }

}

/// <summary>
/// Block type for post_action in AzurermSiteRecoveryReplicationRecoveryPlanShutdownRecoveryGroupBlock.
/// Nesting mode: list
/// </summary>
public class AzurermSiteRecoveryReplicationRecoveryPlanShutdownRecoveryGroupBlockPostActionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "post_action";

    /// <summary>
    /// The fabric_location attribute.
    /// </summary>
    public TerraformValue<string>? FabricLocation
    {
        get => new TerraformReference<string>(this, "fabric_location");
        set => SetArgument("fabric_location", value);
    }

    /// <summary>
    /// The fail_over_directions attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FailOverDirections is required")]
    public required TerraformSet<string> FailOverDirections
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "fail_over_directions").ResolveNodes(ctx));
        set => SetArgument("fail_over_directions", value);
    }

    /// <summary>
    /// The fail_over_types attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FailOverTypes is required")]
    public required TerraformSet<string> FailOverTypes
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "fail_over_types").ResolveNodes(ctx));
        set => SetArgument("fail_over_types", value);
    }

    /// <summary>
    /// The manual_action_instruction attribute.
    /// </summary>
    public TerraformValue<string>? ManualActionInstruction
    {
        get => new TerraformReference<string>(this, "manual_action_instruction");
        set => SetArgument("manual_action_instruction", value);
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
    /// The runbook_id attribute.
    /// </summary>
    public TerraformValue<string>? RunbookId
    {
        get => new TerraformReference<string>(this, "runbook_id");
        set => SetArgument("runbook_id", value);
    }

    /// <summary>
    /// The script_path attribute.
    /// </summary>
    public TerraformValue<string>? ScriptPath
    {
        get => new TerraformReference<string>(this, "script_path");
        set => SetArgument("script_path", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

}

/// <summary>
/// Block type for pre_action in AzurermSiteRecoveryReplicationRecoveryPlanShutdownRecoveryGroupBlock.
/// Nesting mode: list
/// </summary>
public class AzurermSiteRecoveryReplicationRecoveryPlanShutdownRecoveryGroupBlockPreActionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "pre_action";

    /// <summary>
    /// The fabric_location attribute.
    /// </summary>
    public TerraformValue<string>? FabricLocation
    {
        get => new TerraformReference<string>(this, "fabric_location");
        set => SetArgument("fabric_location", value);
    }

    /// <summary>
    /// The fail_over_directions attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FailOverDirections is required")]
    public required TerraformSet<string> FailOverDirections
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "fail_over_directions").ResolveNodes(ctx));
        set => SetArgument("fail_over_directions", value);
    }

    /// <summary>
    /// The fail_over_types attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FailOverTypes is required")]
    public required TerraformSet<string> FailOverTypes
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "fail_over_types").ResolveNodes(ctx));
        set => SetArgument("fail_over_types", value);
    }

    /// <summary>
    /// The manual_action_instruction attribute.
    /// </summary>
    public TerraformValue<string>? ManualActionInstruction
    {
        get => new TerraformReference<string>(this, "manual_action_instruction");
        set => SetArgument("manual_action_instruction", value);
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
    /// The runbook_id attribute.
    /// </summary>
    public TerraformValue<string>? RunbookId
    {
        get => new TerraformReference<string>(this, "runbook_id");
        set => SetArgument("runbook_id", value);
    }

    /// <summary>
    /// The script_path attribute.
    /// </summary>
    public TerraformValue<string>? ScriptPath
    {
        get => new TerraformReference<string>(this, "script_path");
        set => SetArgument("script_path", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermSiteRecoveryReplicationRecoveryPlan.
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
    public TerraformList<AzurermSiteRecoveryReplicationRecoveryPlanAzureToAzureSettingsBlock>? AzureToAzureSettings
    {
        get => GetArgument<TerraformList<AzurermSiteRecoveryReplicationRecoveryPlanAzureToAzureSettingsBlock>>("azure_to_azure_settings");
        set => SetArgument("azure_to_azure_settings", value);
    }

    /// <summary>
    /// BootRecoveryGroup block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BootRecoveryGroup is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 BootRecoveryGroup block(s) required")]
    public required TerraformList<AzurermSiteRecoveryReplicationRecoveryPlanBootRecoveryGroupBlock> BootRecoveryGroup
    {
        get => GetRequiredArgument<TerraformList<AzurermSiteRecoveryReplicationRecoveryPlanBootRecoveryGroupBlock>>("boot_recovery_group");
        set => SetArgument("boot_recovery_group", value);
    }

    /// <summary>
    /// FailoverRecoveryGroup block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FailoverRecoveryGroup is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 FailoverRecoveryGroup block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FailoverRecoveryGroup block(s) allowed")]
    public required TerraformList<AzurermSiteRecoveryReplicationRecoveryPlanFailoverRecoveryGroupBlock> FailoverRecoveryGroup
    {
        get => GetRequiredArgument<TerraformList<AzurermSiteRecoveryReplicationRecoveryPlanFailoverRecoveryGroupBlock>>("failover_recovery_group");
        set => SetArgument("failover_recovery_group", value);
    }

    /// <summary>
    /// ShutdownRecoveryGroup block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ShutdownRecoveryGroup is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ShutdownRecoveryGroup block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ShutdownRecoveryGroup block(s) allowed")]
    public required TerraformList<AzurermSiteRecoveryReplicationRecoveryPlanShutdownRecoveryGroupBlock> ShutdownRecoveryGroup
    {
        get => GetRequiredArgument<TerraformList<AzurermSiteRecoveryReplicationRecoveryPlanShutdownRecoveryGroupBlock>>("shutdown_recovery_group");
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
