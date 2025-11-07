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
    public TerraformLiteralProperty<double>? ClusterNodeCount
    {
        get => GetProperty<TerraformLiteralProperty<double>>("cluster_node_count");
        set => this.WithProperty("cluster_node_count", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SkuName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("sku_name");
        set => this.WithProperty("sku_name", value);
    }

    /// <summary>
    /// The vmware_cloud_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? VmwareCloudId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("vmware_cloud_id");
        set => this.WithProperty("vmware_cloud_id", value);
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
