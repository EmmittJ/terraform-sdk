using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermKubernetesClusterNodePoolDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

}

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
        SetOutput("auto_scaling_enabled");
        SetOutput("eviction_policy");
        SetOutput("gpu_driver");
        SetOutput("max_count");
        SetOutput("max_pods");
        SetOutput("min_count");
        SetOutput("mode");
        SetOutput("node_count");
        SetOutput("node_labels");
        SetOutput("node_public_ip_enabled");
        SetOutput("node_public_ip_prefix_id");
        SetOutput("node_taints");
        SetOutput("orchestrator_version");
        SetOutput("os_disk_size_gb");
        SetOutput("os_disk_type");
        SetOutput("os_type");
        SetOutput("priority");
        SetOutput("proximity_placement_group_id");
        SetOutput("spot_max_price");
        SetOutput("tags");
        SetOutput("upgrade_settings");
        SetOutput("vm_size");
        SetOutput("vnet_subnet_id");
        SetOutput("zones");
        SetOutput("id");
        SetOutput("kubernetes_cluster_name");
        SetOutput("name");
        SetOutput("resource_group_name");
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
    /// The kubernetes_cluster_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KubernetesClusterName is required")]
    public required TerraformProperty<string> KubernetesClusterName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("kubernetes_cluster_name");
        set => SetProperty("kubernetes_cluster_name", value);
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
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_group_name");
        set => SetProperty("resource_group_name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermKubernetesClusterNodePoolDataSourceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
