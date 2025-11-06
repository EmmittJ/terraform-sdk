using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_vmware_cluster resource.
/// </summary>
public class AzurermVmwareCluster : TerraformResource
{
    public AzurermVmwareCluster(string name) : base("azurerm_vmware_cluster", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("cluster_number");
        this.DeclareOutput("hosts");
    }

    /// <summary>
    /// The cluster_node_count attribute.
    /// </summary>
    public double? ClusterNodeCount
    {
        get => GetProperty<TerraformLiteralProperty<double>>("cluster_node_count")?.Value;
        set => this.WithProperty("cluster_node_count", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
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
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    public string? SkuName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("sku_name")?.Value;
        set => this.WithProperty("sku_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The vmware_cloud_id attribute.
    /// </summary>
    public string? VmwareCloudId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("vmware_cloud_id")?.Value;
        set => this.WithProperty("vmware_cloud_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The cluster_number attribute.
    /// </summary>
    public TerraformExpression ClusterNumber => this["cluster_number"];

    /// <summary>
    /// The hosts attribute.
    /// </summary>
    public TerraformExpression Hosts => this["hosts"];

}
