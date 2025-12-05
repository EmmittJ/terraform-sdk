using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for managed_cluster_update in AzurermKubernetesFleetUpdateRun.
/// Nesting mode: list
/// </summary>
public class AzurermKubernetesFleetUpdateRunManagedClusterUpdateBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "managed_cluster_update";

    /// <summary>
    /// NodeImageSelection block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NodeImageSelection block(s) allowed")]
    public TerraformList<AzurermKubernetesFleetUpdateRunManagedClusterUpdateBlockNodeImageSelectionBlock>? NodeImageSelection
    {
        get => GetArgument<TerraformList<AzurermKubernetesFleetUpdateRunManagedClusterUpdateBlockNodeImageSelectionBlock>>("node_image_selection");
        set => SetArgument("node_image_selection", value);
    }

    /// <summary>
    /// Upgrade block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Upgrade is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Upgrade block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Upgrade block(s) allowed")]
    public required TerraformList<AzurermKubernetesFleetUpdateRunManagedClusterUpdateBlockUpgradeBlock> Upgrade
    {
        get => GetRequiredArgument<TerraformList<AzurermKubernetesFleetUpdateRunManagedClusterUpdateBlockUpgradeBlock>>("upgrade");
        set => SetArgument("upgrade", value);
    }

}

/// <summary>
/// Block type for node_image_selection in AzurermKubernetesFleetUpdateRunManagedClusterUpdateBlock.
/// Nesting mode: list
/// </summary>
public class AzurermKubernetesFleetUpdateRunManagedClusterUpdateBlockNodeImageSelectionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "node_image_selection";

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetRequiredArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

}

/// <summary>
/// Block type for upgrade in AzurermKubernetesFleetUpdateRunManagedClusterUpdateBlock.
/// Nesting mode: list
/// </summary>
public class AzurermKubernetesFleetUpdateRunManagedClusterUpdateBlockUpgradeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "upgrade";

    /// <summary>
    /// The kubernetes_version attribute.
    /// </summary>
    public TerraformValue<string>? KubernetesVersion
    {
        get => GetArgument<TerraformValue<string>>("kubernetes_version");
        set => SetArgument("kubernetes_version", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetRequiredArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Block type for stage in AzurermKubernetesFleetUpdateRun.
/// Nesting mode: list
/// </summary>
public class AzurermKubernetesFleetUpdateRunStageBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "stage";

    /// <summary>
    /// The after_stage_wait_in_seconds attribute.
    /// </summary>
    public TerraformValue<double>? AfterStageWaitInSeconds
    {
        get => GetArgument<TerraformValue<double>>("after_stage_wait_in_seconds");
        set => SetArgument("after_stage_wait_in_seconds", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Group block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Group is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Group block(s) required")]
    public required TerraformList<AzurermKubernetesFleetUpdateRunStageBlockGroupBlock> Group
    {
        get => GetRequiredArgument<TerraformList<AzurermKubernetesFleetUpdateRunStageBlockGroupBlock>>("group");
        set => SetArgument("group", value);
    }

}

/// <summary>
/// Block type for group in AzurermKubernetesFleetUpdateRunStageBlock.
/// Nesting mode: list
/// </summary>
public class AzurermKubernetesFleetUpdateRunStageBlockGroupBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "group";

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermKubernetesFleetUpdateRun.
/// Nesting mode: single
/// </summary>
public class AzurermKubernetesFleetUpdateRunTimeoutsBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a azurerm_kubernetes_fleet_update_run Terraform resource.
/// Manages a azurerm_kubernetes_fleet_update_run resource.
/// </summary>
public partial class AzurermKubernetesFleetUpdateRun(string name) : TerraformResource("azurerm_kubernetes_fleet_update_run", name)
{
    /// <summary>
    /// The fleet_update_strategy_id attribute.
    /// </summary>
    public TerraformValue<string>? FleetUpdateStrategyId
    {
        get => GetArgument<TerraformValue<string>>("fleet_update_strategy_id");
        set => SetArgument("fleet_update_strategy_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The kubernetes_fleet_manager_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KubernetesFleetManagerId is required")]
    public required TerraformValue<string> KubernetesFleetManagerId
    {
        get => GetRequiredArgument<TerraformValue<string>>("kubernetes_fleet_manager_id");
        set => SetArgument("kubernetes_fleet_manager_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// ManagedClusterUpdate block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ManagedClusterUpdate is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ManagedClusterUpdate block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ManagedClusterUpdate block(s) allowed")]
    public required TerraformList<AzurermKubernetesFleetUpdateRunManagedClusterUpdateBlock> ManagedClusterUpdate
    {
        get => GetRequiredArgument<TerraformList<AzurermKubernetesFleetUpdateRunManagedClusterUpdateBlock>>("managed_cluster_update");
        set => SetArgument("managed_cluster_update", value);
    }

    /// <summary>
    /// Stage block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermKubernetesFleetUpdateRunStageBlock>? Stage
    {
        get => GetArgument<TerraformList<AzurermKubernetesFleetUpdateRunStageBlock>>("stage");
        set => SetArgument("stage", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermKubernetesFleetUpdateRunTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermKubernetesFleetUpdateRunTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
