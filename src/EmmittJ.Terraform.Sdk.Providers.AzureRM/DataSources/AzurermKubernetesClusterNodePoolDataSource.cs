using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Retrieves information about a azurerm_kubernetes_cluster_node_pool.
/// </summary>
public class AzurermKubernetesClusterNodePoolDataSource : TerraformDataSource
{
    public AzurermKubernetesClusterNodePoolDataSource(string name) : base("azurerm_kubernetes_cluster_node_pool", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("auto_scaling_enabled");
        this.DeclareOutput("eviction_policy");
        this.DeclareOutput("gpu_driver");
        this.DeclareOutput("max_count");
        this.DeclareOutput("max_pods");
        this.DeclareOutput("min_count");
        this.DeclareOutput("mode");
        this.DeclareOutput("node_count");
        this.DeclareOutput("node_labels");
        this.DeclareOutput("node_public_ip_enabled");
        this.DeclareOutput("node_public_ip_prefix_id");
        this.DeclareOutput("node_taints");
        this.DeclareOutput("orchestrator_version");
        this.DeclareOutput("os_disk_size_gb");
        this.DeclareOutput("os_disk_type");
        this.DeclareOutput("os_type");
        this.DeclareOutput("priority");
        this.DeclareOutput("proximity_placement_group_id");
        this.DeclareOutput("spot_max_price");
        this.DeclareOutput("tags");
        this.DeclareOutput("upgrade_settings");
        this.DeclareOutput("vm_size");
        this.DeclareOutput("vnet_subnet_id");
        this.DeclareOutput("zones");
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
    /// The kubernetes_cluster_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? KubernetesClusterName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("kubernetes_cluster_name");
        set => this.WithProperty("kubernetes_cluster_name", value);
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
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The auto_scaling_enabled attribute.
    /// </summary>
    public TerraformExpression AutoScalingEnabled => this["auto_scaling_enabled"];

    /// <summary>
    /// The eviction_policy attribute.
    /// </summary>
    public TerraformExpression EvictionPolicy => this["eviction_policy"];

    /// <summary>
    /// The gpu_driver attribute.
    /// </summary>
    public TerraformExpression GpuDriver => this["gpu_driver"];

    /// <summary>
    /// The max_count attribute.
    /// </summary>
    public TerraformExpression MaxCount => this["max_count"];

    /// <summary>
    /// The max_pods attribute.
    /// </summary>
    public TerraformExpression MaxPods => this["max_pods"];

    /// <summary>
    /// The min_count attribute.
    /// </summary>
    public TerraformExpression MinCount => this["min_count"];

    /// <summary>
    /// The mode attribute.
    /// </summary>
    public TerraformExpression Mode => this["mode"];

    /// <summary>
    /// The node_count attribute.
    /// </summary>
    public TerraformExpression NodeCount => this["node_count"];

    /// <summary>
    /// The node_labels attribute.
    /// </summary>
    public TerraformExpression NodeLabels => this["node_labels"];

    /// <summary>
    /// The node_public_ip_enabled attribute.
    /// </summary>
    public TerraformExpression NodePublicIpEnabled => this["node_public_ip_enabled"];

    /// <summary>
    /// The node_public_ip_prefix_id attribute.
    /// </summary>
    public TerraformExpression NodePublicIpPrefixId => this["node_public_ip_prefix_id"];

    /// <summary>
    /// The node_taints attribute.
    /// </summary>
    public TerraformExpression NodeTaints => this["node_taints"];

    /// <summary>
    /// The orchestrator_version attribute.
    /// </summary>
    public TerraformExpression OrchestratorVersion => this["orchestrator_version"];

    /// <summary>
    /// The os_disk_size_gb attribute.
    /// </summary>
    public TerraformExpression OsDiskSizeGb => this["os_disk_size_gb"];

    /// <summary>
    /// The os_disk_type attribute.
    /// </summary>
    public TerraformExpression OsDiskType => this["os_disk_type"];

    /// <summary>
    /// The os_type attribute.
    /// </summary>
    public TerraformExpression OsType => this["os_type"];

    /// <summary>
    /// The priority attribute.
    /// </summary>
    public TerraformExpression Priority => this["priority"];

    /// <summary>
    /// The proximity_placement_group_id attribute.
    /// </summary>
    public TerraformExpression ProximityPlacementGroupId => this["proximity_placement_group_id"];

    /// <summary>
    /// The spot_max_price attribute.
    /// </summary>
    public TerraformExpression SpotMaxPrice => this["spot_max_price"];

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformExpression Tags => this["tags"];

    /// <summary>
    /// The upgrade_settings attribute.
    /// </summary>
    public TerraformExpression UpgradeSettings => this["upgrade_settings"];

    /// <summary>
    /// The vm_size attribute.
    /// </summary>
    public TerraformExpression VmSize => this["vm_size"];

    /// <summary>
    /// The vnet_subnet_id attribute.
    /// </summary>
    public TerraformExpression VnetSubnetId => this["vnet_subnet_id"];

    /// <summary>
    /// The zones attribute.
    /// </summary>
    public TerraformExpression Zones => this["zones"];

}
