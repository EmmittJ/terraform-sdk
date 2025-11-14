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
    [TerraformArgument("after_stage_wait_in_seconds")]
    public TerraformValue<double>? AfterStageWaitInSeconds
    {
        get => new TerraformReference<double>(this, "after_stage_wait_in_seconds");
        set => SetArgument("after_stage_wait_in_seconds", value);
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
/// Manages a azurerm_kubernetes_fleet_update_run resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermKubernetesFleetUpdateRun : TerraformResource
{
    public AzurermKubernetesFleetUpdateRun(string name) : base("azurerm_kubernetes_fleet_update_run", name)
    {
    }

    /// <summary>
    /// The fleet_update_strategy_id attribute.
    /// </summary>
    [TerraformArgument("fleet_update_strategy_id")]
    public TerraformValue<string>? FleetUpdateStrategyId
    {
        get => new TerraformReference<string>(this, "fleet_update_strategy_id");
        set => SetArgument("fleet_update_strategy_id", value);
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
    /// The kubernetes_fleet_manager_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KubernetesFleetManagerId is required")]
    [TerraformArgument("kubernetes_fleet_manager_id")]
    public required TerraformValue<string> KubernetesFleetManagerId
    {
        get => new TerraformReference<string>(this, "kubernetes_fleet_manager_id");
        set => SetArgument("kubernetes_fleet_manager_id", value);
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
    /// Block for managed_cluster_update.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ManagedClusterUpdate is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ManagedClusterUpdate block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ManagedClusterUpdate block(s) allowed")]
    [TerraformArgument("managed_cluster_update")]
    public required TerraformList<AzurermKubernetesFleetUpdateRunManagedClusterUpdateBlock> ManagedClusterUpdate { get; set; } = new();

    /// <summary>
    /// Block for stage.
    /// Nesting mode: list
    /// </summary>
    [TerraformArgument("stage")]
    public TerraformList<AzurermKubernetesFleetUpdateRunStageBlock> Stage { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermKubernetesFleetUpdateRunTimeoutsBlock Timeouts { get; set; } = new();

}
