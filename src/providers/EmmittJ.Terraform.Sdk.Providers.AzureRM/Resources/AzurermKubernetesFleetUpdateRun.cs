using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for managed_cluster_update in .
/// Nesting mode: list
/// </summary>
public class AzurermKubernetesFleetUpdateRunManagedClusterUpdateBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "managed_cluster_update";

}

/// <summary>
/// Block type for stage in .
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
        get => new TerraformReference<double>(this, "after_stage_wait_in_seconds");
        set => SetArgument("after_stage_wait_in_seconds", value);
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

}

/// <summary>
/// Block type for timeouts in .
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
        get => new TerraformReference<string>(this, "fleet_update_strategy_id");
        set => SetArgument("fleet_update_strategy_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The kubernetes_fleet_manager_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KubernetesFleetManagerId is required")]
    public required TerraformValue<string> KubernetesFleetManagerId
    {
        get => new TerraformReference<string>(this, "kubernetes_fleet_manager_id");
        set => SetArgument("kubernetes_fleet_manager_id", value);
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
