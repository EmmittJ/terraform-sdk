using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermKubernetesClusterNodePoolDataSource.
/// Nesting mode: single
/// </summary>
public class AzurermKubernetesClusterNodePoolDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

}


/// <summary>
/// Represents a azurerm_kubernetes_cluster_node_pool Terraform data source.
/// Retrieves information about a azurerm_kubernetes_cluster_node_pool.
/// </summary>
public partial class AzurermKubernetesClusterNodePoolDataSource(string name) : TerraformDataSource("azurerm_kubernetes_cluster_node_pool", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The kubernetes_cluster_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KubernetesClusterName is required")]
    public required TerraformValue<string> KubernetesClusterName
    {
        get => GetRequiredArgument<TerraformValue<string>>("kubernetes_cluster_name");
        set => SetArgument("kubernetes_cluster_name", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetRequiredArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The auto_scaling_enabled attribute.
    /// </summary>
    public TerraformValue<bool> AutoScalingEnabled
        => CreateReference("auto_scaling_enabled");

    /// <summary>
    /// The eviction_policy attribute.
    /// </summary>
    public TerraformValue<string> EvictionPolicy
        => CreateReference("eviction_policy");

    /// <summary>
    /// The gpu_driver attribute.
    /// </summary>
    public TerraformValue<string> GpuDriver
        => CreateReference("gpu_driver");

    /// <summary>
    /// The max_count attribute.
    /// </summary>
    public TerraformValue<double> MaxCount
        => CreateReference("max_count");

    /// <summary>
    /// The max_pods attribute.
    /// </summary>
    public TerraformValue<double> MaxPods
        => CreateReference("max_pods");

    /// <summary>
    /// The min_count attribute.
    /// </summary>
    public TerraformValue<double> MinCount
        => CreateReference("min_count");

    /// <summary>
    /// The mode attribute.
    /// </summary>
    public TerraformValue<string> Mode
        => CreateReference("mode");

    /// <summary>
    /// The node_count attribute.
    /// </summary>
    public TerraformValue<double> NodeCount
        => CreateReference("node_count");

    /// <summary>
    /// The node_labels attribute.
    /// </summary>
    public TerraformMap<string> NodeLabels
        => CreateReference("node_labels");

    /// <summary>
    /// The node_public_ip_enabled attribute.
    /// </summary>
    public TerraformValue<bool> NodePublicIpEnabled
        => CreateReference("node_public_ip_enabled");

    /// <summary>
    /// The node_public_ip_prefix_id attribute.
    /// </summary>
    public TerraformValue<string> NodePublicIpPrefixId
        => CreateReference("node_public_ip_prefix_id");

    /// <summary>
    /// The node_taints attribute.
    /// </summary>
    public TerraformList<string> NodeTaints
        => CreateReference("node_taints");

    /// <summary>
    /// The orchestrator_version attribute.
    /// </summary>
    public TerraformValue<string> OrchestratorVersion
        => CreateReference("orchestrator_version");

    /// <summary>
    /// The os_disk_size_gb attribute.
    /// </summary>
    public TerraformValue<double> OsDiskSizeGb
        => CreateReference("os_disk_size_gb");

    /// <summary>
    /// The os_disk_type attribute.
    /// </summary>
    public TerraformValue<string> OsDiskType
        => CreateReference("os_disk_type");

    /// <summary>
    /// The os_type attribute.
    /// </summary>
    public TerraformValue<string> OsType
        => CreateReference("os_type");

    /// <summary>
    /// The priority attribute.
    /// </summary>
    public TerraformValue<string> Priority
        => CreateReference("priority");

    /// <summary>
    /// The proximity_placement_group_id attribute.
    /// </summary>
    public TerraformValue<string> ProximityPlacementGroupId
        => CreateReference("proximity_placement_group_id");

    /// <summary>
    /// The spot_max_price attribute.
    /// </summary>
    public TerraformValue<double> SpotMaxPrice
        => CreateReference("spot_max_price");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
        => CreateReference("tags");

    /// <summary>
    /// The upgrade_settings attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> UpgradeSettings
        => CreateReference("upgrade_settings");

    /// <summary>
    /// The vm_size attribute.
    /// </summary>
    public TerraformValue<string> VmSize
        => CreateReference("vm_size");

    /// <summary>
    /// The vnet_subnet_id attribute.
    /// </summary>
    public TerraformValue<string> VnetSubnetId
        => CreateReference("vnet_subnet_id");

    /// <summary>
    /// The zones attribute.
    /// </summary>
    public TerraformList<string> Zones
        => CreateReference("zones");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermKubernetesClusterNodePoolDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermKubernetesClusterNodePoolDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
