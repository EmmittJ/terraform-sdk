using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for managed_cluster_update in .
/// Nesting mode: list
/// </summary>
public class AzurermKubernetesFleetUpdateRunManagedClusterUpdateBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for stage in .
/// Nesting mode: list
/// </summary>
public class AzurermKubernetesFleetUpdateRunStageBlock : ITerraformBlock
{
    /// <summary>
    /// The after_stage_wait_in_seconds attribute.
    /// </summary>
    [TerraformPropertyName("after_stage_wait_in_seconds")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? AfterStageWaitInSeconds { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermKubernetesFleetUpdateRunTimeoutsBlock : ITerraformBlock
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
    [TerraformPropertyName("fleet_update_strategy_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? FleetUpdateStrategyId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The kubernetes_fleet_manager_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KubernetesFleetManagerId is required")]
    [TerraformPropertyName("kubernetes_fleet_manager_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> KubernetesFleetManagerId { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// Block for managed_cluster_update.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ManagedClusterUpdate is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ManagedClusterUpdate block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ManagedClusterUpdate block(s) allowed")]
    [TerraformPropertyName("managed_cluster_update")]
    public TerraformList<TerraformBlock<AzurermKubernetesFleetUpdateRunManagedClusterUpdateBlock>>? ManagedClusterUpdate { get; set; } = new();

    /// <summary>
    /// Block for stage.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("stage")]
    public TerraformList<TerraformBlock<AzurermKubernetesFleetUpdateRunStageBlock>>? Stage { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermKubernetesFleetUpdateRunTimeoutsBlock>? Timeouts { get; set; } = new();

}
