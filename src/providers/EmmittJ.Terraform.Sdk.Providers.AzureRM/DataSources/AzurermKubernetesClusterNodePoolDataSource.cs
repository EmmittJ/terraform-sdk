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
        get => new TerraformReference<string>(this, "read");
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
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The kubernetes_cluster_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KubernetesClusterName is required")]
    public required TerraformValue<string> KubernetesClusterName
    {
        get => new TerraformReference<string>(this, "kubernetes_cluster_name");
        set => SetArgument("kubernetes_cluster_name", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The auto_scaling_enabled attribute.
    /// </summary>
    public TerraformValue<bool> AutoScalingEnabled
    {
        get => new TerraformReference<bool>(this, "auto_scaling_enabled");
    }

    /// <summary>
    /// The eviction_policy attribute.
    /// </summary>
    public TerraformValue<string> EvictionPolicy
    {
        get => new TerraformReference<string>(this, "eviction_policy");
    }

    /// <summary>
    /// The gpu_driver attribute.
    /// </summary>
    public TerraformValue<string> GpuDriver
    {
        get => new TerraformReference<string>(this, "gpu_driver");
    }

    /// <summary>
    /// The max_count attribute.
    /// </summary>
    public TerraformValue<double> MaxCount
    {
        get => new TerraformReference<double>(this, "max_count");
    }

    /// <summary>
    /// The max_pods attribute.
    /// </summary>
    public TerraformValue<double> MaxPods
    {
        get => new TerraformReference<double>(this, "max_pods");
    }

    /// <summary>
    /// The min_count attribute.
    /// </summary>
    public TerraformValue<double> MinCount
    {
        get => new TerraformReference<double>(this, "min_count");
    }

    /// <summary>
    /// The mode attribute.
    /// </summary>
    public TerraformValue<string> Mode
    {
        get => new TerraformReference<string>(this, "mode");
    }

    /// <summary>
    /// The node_count attribute.
    /// </summary>
    public TerraformValue<double> NodeCount
    {
        get => new TerraformReference<double>(this, "node_count");
    }

    /// <summary>
    /// The node_labels attribute.
    /// </summary>
    public TerraformMap<string> NodeLabels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "node_labels").ResolveNodes(ctx));
    }

    /// <summary>
    /// The node_public_ip_enabled attribute.
    /// </summary>
    public TerraformValue<bool> NodePublicIpEnabled
    {
        get => new TerraformReference<bool>(this, "node_public_ip_enabled");
    }

    /// <summary>
    /// The node_public_ip_prefix_id attribute.
    /// </summary>
    public TerraformValue<string> NodePublicIpPrefixId
    {
        get => new TerraformReference<string>(this, "node_public_ip_prefix_id");
    }

    /// <summary>
    /// The node_taints attribute.
    /// </summary>
    public TerraformList<string> NodeTaints
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "node_taints").ResolveNodes(ctx));
    }

    /// <summary>
    /// The orchestrator_version attribute.
    /// </summary>
    public TerraformValue<string> OrchestratorVersion
    {
        get => new TerraformReference<string>(this, "orchestrator_version");
    }

    /// <summary>
    /// The os_disk_size_gb attribute.
    /// </summary>
    public TerraformValue<double> OsDiskSizeGb
    {
        get => new TerraformReference<double>(this, "os_disk_size_gb");
    }

    /// <summary>
    /// The os_disk_type attribute.
    /// </summary>
    public TerraformValue<string> OsDiskType
    {
        get => new TerraformReference<string>(this, "os_disk_type");
    }

    /// <summary>
    /// The os_type attribute.
    /// </summary>
    public TerraformValue<string> OsType
    {
        get => new TerraformReference<string>(this, "os_type");
    }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    public TerraformValue<string> Priority
    {
        get => new TerraformReference<string>(this, "priority");
    }

    /// <summary>
    /// The proximity_placement_group_id attribute.
    /// </summary>
    public TerraformValue<string> ProximityPlacementGroupId
    {
        get => new TerraformReference<string>(this, "proximity_placement_group_id");
    }

    /// <summary>
    /// The spot_max_price attribute.
    /// </summary>
    public TerraformValue<double> SpotMaxPrice
    {
        get => new TerraformReference<double>(this, "spot_max_price");
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
    }

    /// <summary>
    /// The upgrade_settings attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> UpgradeSettings
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "upgrade_settings").ResolveNodes(ctx));
    }

    /// <summary>
    /// The vm_size attribute.
    /// </summary>
    public TerraformValue<string> VmSize
    {
        get => new TerraformReference<string>(this, "vm_size");
    }

    /// <summary>
    /// The vnet_subnet_id attribute.
    /// </summary>
    public TerraformValue<string> VnetSubnetId
    {
        get => new TerraformReference<string>(this, "vnet_subnet_id");
    }

    /// <summary>
    /// The zones attribute.
    /// </summary>
    public TerraformList<string> Zones
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "zones").ResolveNodes(ctx));
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermKubernetesClusterNodePoolDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermKubernetesClusterNodePoolDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
