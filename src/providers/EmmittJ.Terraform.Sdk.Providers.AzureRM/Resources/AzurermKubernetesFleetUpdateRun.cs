using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for managed_cluster_update in .
/// Nesting mode: list
/// </summary>
public partial class AzurermKubernetesFleetUpdateRunManagedClusterUpdateBlock() : TerraformBlock("managed_cluster_update")
{
}

/// <summary>
/// Block type for stage in .
/// Nesting mode: list
/// </summary>
public partial class AzurermKubernetesFleetUpdateRunStageBlock() : TerraformBlock("stage")
{
    /// <summary>
    /// The after_stage_wait_in_seconds attribute.
    /// </summary>
    [TerraformProperty("after_stage_wait_in_seconds")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? AfterStageWaitInSeconds { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermKubernetesFleetUpdateRunTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_kubernetes_fleet_update_run resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermKubernetesFleetUpdateRun : TerraformResource
{
    public AzurermKubernetesFleetUpdateRun(string name) : base("azurerm_kubernetes_fleet_update_run", name)
    {
    }

    /// <summary>
    /// The fleet_update_strategy_id attribute.
    /// </summary>
    [TerraformProperty("fleet_update_strategy_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? FleetUpdateStrategyId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The kubernetes_fleet_manager_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KubernetesFleetManagerId is required")]
    [TerraformProperty("kubernetes_fleet_manager_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> KubernetesFleetManagerId { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Block for managed_cluster_update.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ManagedClusterUpdate is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ManagedClusterUpdate block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ManagedClusterUpdate block(s) allowed")]
    [TerraformProperty("managed_cluster_update")]
    public required TerraformList<AzurermKubernetesFleetUpdateRunManagedClusterUpdateBlock> ManagedClusterUpdate { get; set; } = new();

    /// <summary>
    /// Block for stage.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("stage")]
    public TerraformList<AzurermKubernetesFleetUpdateRunStageBlock> Stage { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermKubernetesFleetUpdateRunTimeoutsBlock Timeouts { get; set; } = new();

}
