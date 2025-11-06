using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_kubernetes_fleet_update_run resource.
/// </summary>
public class AzurermKubernetesFleetUpdateRun : TerraformResource
{
    public AzurermKubernetesFleetUpdateRun(string name) : base("azurerm_kubernetes_fleet_update_run", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The fleet_update_strategy_id attribute.
    /// </summary>
    public string? FleetUpdateStrategyId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("fleet_update_strategy_id")?.Value;
        set => this.WithProperty("fleet_update_strategy_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The kubernetes_fleet_manager_id attribute.
    /// </summary>
    public string? KubernetesFleetManagerId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("kubernetes_fleet_manager_id")?.Value;
        set => this.WithProperty("kubernetes_fleet_manager_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
