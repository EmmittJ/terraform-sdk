using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_kubernetes_fleet_member resource.
/// </summary>
public class AzurermKubernetesFleetMember : TerraformResource
{
    public AzurermKubernetesFleetMember(string name) : base("azurerm_kubernetes_fleet_member", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The group attribute.
    /// </summary>
    public TerraformProperty<string>? Group
    {
        get => GetProperty<TerraformProperty<string>>("group");
        set => this.WithProperty("group", value);
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
    /// The kubernetes_cluster_id attribute.
    /// </summary>
    public TerraformProperty<string>? KubernetesClusterId
    {
        get => GetProperty<TerraformProperty<string>>("kubernetes_cluster_id");
        set => this.WithProperty("kubernetes_cluster_id", value);
    }

    /// <summary>
    /// The kubernetes_fleet_id attribute.
    /// </summary>
    public TerraformProperty<string>? KubernetesFleetId
    {
        get => GetProperty<TerraformProperty<string>>("kubernetes_fleet_id");
        set => this.WithProperty("kubernetes_fleet_id", value);
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
