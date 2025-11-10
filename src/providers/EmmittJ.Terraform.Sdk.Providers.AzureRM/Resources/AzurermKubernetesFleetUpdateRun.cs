using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for managed_cluster_update in .
/// Nesting mode: list
/// </summary>
public class AzurermKubernetesFleetUpdateRunManagedClusterUpdateBlock : TerraformBlock
{
}

/// <summary>
/// Block type for stage in .
/// Nesting mode: list
/// </summary>
public class AzurermKubernetesFleetUpdateRunStageBlock : TerraformBlock
{
    /// <summary>
    /// The after_stage_wait_in_seconds attribute.
    /// </summary>
    public TerraformProperty<double>? AfterStageWaitInSeconds
    {
        set => SetProperty("after_stage_wait_in_seconds", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        set => SetProperty("name", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermKubernetesFleetUpdateRunTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_kubernetes_fleet_update_run resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermKubernetesFleetUpdateRun : TerraformResource
{
    public AzurermKubernetesFleetUpdateRun(string name) : base("azurerm_kubernetes_fleet_update_run", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("fleet_update_strategy_id");
        SetOutput("id");
        SetOutput("kubernetes_fleet_manager_id");
        SetOutput("name");
    }

    /// <summary>
    /// The fleet_update_strategy_id attribute.
    /// </summary>
    public TerraformProperty<string> FleetUpdateStrategyId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("fleet_update_strategy_id");
        set => SetProperty("fleet_update_strategy_id", value);
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
    /// The kubernetes_fleet_manager_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KubernetesFleetManagerId is required")]
    public required TerraformProperty<string> KubernetesFleetManagerId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("kubernetes_fleet_manager_id");
        set => SetProperty("kubernetes_fleet_manager_id", value);
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
    /// Block for managed_cluster_update.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ManagedClusterUpdate is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ManagedClusterUpdate block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ManagedClusterUpdate block(s) allowed")]
    public List<AzurermKubernetesFleetUpdateRunManagedClusterUpdateBlock>? ManagedClusterUpdate
    {
        set => SetProperty("managed_cluster_update", value);
    }

    /// <summary>
    /// Block for stage.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermKubernetesFleetUpdateRunStageBlock>? Stage
    {
        set => SetProperty("stage", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermKubernetesFleetUpdateRunTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
