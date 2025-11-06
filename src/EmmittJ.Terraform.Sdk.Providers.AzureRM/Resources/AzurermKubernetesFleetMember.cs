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
    public string? Group
    {
        get => GetProperty<TerraformLiteralProperty<string>>("group")?.Value;
        set => this.WithProperty("group", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The kubernetes_cluster_id attribute.
    /// </summary>
    public string? KubernetesClusterId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("kubernetes_cluster_id")?.Value;
        set => this.WithProperty("kubernetes_cluster_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The kubernetes_fleet_id attribute.
    /// </summary>
    public string? KubernetesFleetId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("kubernetes_fleet_id")?.Value;
        set => this.WithProperty("kubernetes_fleet_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
