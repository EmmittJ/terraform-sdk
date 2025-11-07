using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_kubernetes_fleet_update_strategy resource.
/// </summary>
public class AzurermKubernetesFleetUpdateStrategy : TerraformResource
{
    public AzurermKubernetesFleetUpdateStrategy(string name) : base("azurerm_kubernetes_fleet_update_strategy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The kubernetes_fleet_manager_id attribute.
    /// </summary>
    public TerraformProperty<string>? KubernetesFleetManagerId
    {
        get => GetProperty<TerraformProperty<string>>("kubernetes_fleet_manager_id");
        set => this.WithProperty("kubernetes_fleet_manager_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

}
