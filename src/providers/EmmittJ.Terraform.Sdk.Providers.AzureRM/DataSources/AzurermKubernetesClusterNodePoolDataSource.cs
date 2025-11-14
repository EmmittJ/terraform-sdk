using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

// Resources, Data Sources, Ephemeral Resources, Blocks: Getter ALWAYS returns a reference
// This is the key to natural Terraform syntax
// When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
// The value that was SET is only used during serialization

// Providers: Getter returns stored value
// Providers are not referenced in HCL
// Use required getter if property is required or non-nullable

/// <summary>
/// Block type for timeouts in .
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
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}

/// <summary>
/// Retrieves information about a azurerm_kubernetes_cluster_node_pool.
/// </summary>
public class AzurermKubernetesClusterNodePoolDataSource : TerraformDataSource
{
    public AzurermKubernetesClusterNodePoolDataSource(string name) : base("azurerm_kubernetes_cluster_node_pool", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The kubernetes_cluster_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KubernetesClusterName is required")]
    [TerraformArgument("kubernetes_cluster_name")]
    public required TerraformValue<string> KubernetesClusterName
    {
        get => new TerraformReference<string>(this, "kubernetes_cluster_name");
        set => SetArgument("kubernetes_cluster_name", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformArgument("resource_group_name")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermKubernetesClusterNodePoolDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The auto_scaling_enabled attribute.
    /// </summary>
    [TerraformArgument("auto_scaling_enabled")]
    public TerraformValue<bool> AutoScalingEnabled
    {
        get => new TerraformReference<bool>(this, "auto_scaling_enabled");
    }

    /// <summary>
    /// The eviction_policy attribute.
    /// </summary>
    [TerraformArgument("eviction_policy")]
    public TerraformValue<string> EvictionPolicy
    {
        get => new TerraformReference<string>(this, "eviction_policy");
    }

    /// <summary>
    /// The gpu_driver attribute.
    /// </summary>
    [TerraformArgument("gpu_driver")]
    public TerraformValue<string> GpuDriver
    {
        get => new TerraformReference<string>(this, "gpu_driver");
    }

    /// <summary>
    /// The max_count attribute.
    /// </summary>
    [TerraformArgument("max_count")]
    public TerraformValue<double> MaxCount
    {
        get => new TerraformReference<double>(this, "max_count");
    }

    /// <summary>
    /// The max_pods attribute.
    /// </summary>
    [TerraformArgument("max_pods")]
    public TerraformValue<double> MaxPods
    {
        get => new TerraformReference<double>(this, "max_pods");
    }

    /// <summary>
    /// The min_count attribute.
    /// </summary>
    [TerraformArgument("min_count")]
    public TerraformValue<double> MinCount
    {
        get => new TerraformReference<double>(this, "min_count");
    }

    /// <summary>
    /// The mode attribute.
    /// </summary>
    [TerraformArgument("mode")]
    public TerraformValue<string> Mode
    {
        get => new TerraformReference<string>(this, "mode");
    }

    /// <summary>
    /// The node_count attribute.
    /// </summary>
    [TerraformArgument("node_count")]
    public TerraformValue<double> NodeCount
    {
        get => new TerraformReference<double>(this, "node_count");
    }

    /// <summary>
    /// The node_labels attribute.
    /// </summary>
    [TerraformArgument("node_labels")]
    public TerraformMap<string> NodeLabels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "node_labels").ResolveNodes(ctx));
    }

    /// <summary>
    /// The node_public_ip_enabled attribute.
    /// </summary>
    [TerraformArgument("node_public_ip_enabled")]
    public TerraformValue<bool> NodePublicIpEnabled
    {
        get => new TerraformReference<bool>(this, "node_public_ip_enabled");
    }

    /// <summary>
    /// The node_public_ip_prefix_id attribute.
    /// </summary>
    [TerraformArgument("node_public_ip_prefix_id")]
    public TerraformValue<string> NodePublicIpPrefixId
    {
        get => new TerraformReference<string>(this, "node_public_ip_prefix_id");
    }

    /// <summary>
    /// The node_taints attribute.
    /// </summary>
    [TerraformArgument("node_taints")]
    public TerraformList<string> NodeTaints
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "node_taints").ResolveNodes(ctx));
    }

    /// <summary>
    /// The orchestrator_version attribute.
    /// </summary>
    [TerraformArgument("orchestrator_version")]
    public TerraformValue<string> OrchestratorVersion
    {
        get => new TerraformReference<string>(this, "orchestrator_version");
    }

    /// <summary>
    /// The os_disk_size_gb attribute.
    /// </summary>
    [TerraformArgument("os_disk_size_gb")]
    public TerraformValue<double> OsDiskSizeGb
    {
        get => new TerraformReference<double>(this, "os_disk_size_gb");
    }

    /// <summary>
    /// The os_disk_type attribute.
    /// </summary>
    [TerraformArgument("os_disk_type")]
    public TerraformValue<string> OsDiskType
    {
        get => new TerraformReference<string>(this, "os_disk_type");
    }

    /// <summary>
    /// The os_type attribute.
    /// </summary>
    [TerraformArgument("os_type")]
    public TerraformValue<string> OsType
    {
        get => new TerraformReference<string>(this, "os_type");
    }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    [TerraformArgument("priority")]
    public TerraformValue<string> Priority
    {
        get => new TerraformReference<string>(this, "priority");
    }

    /// <summary>
    /// The proximity_placement_group_id attribute.
    /// </summary>
    [TerraformArgument("proximity_placement_group_id")]
    public TerraformValue<string> ProximityPlacementGroupId
    {
        get => new TerraformReference<string>(this, "proximity_placement_group_id");
    }

    /// <summary>
    /// The spot_max_price attribute.
    /// </summary>
    [TerraformArgument("spot_max_price")]
    public TerraformValue<double> SpotMaxPrice
    {
        get => new TerraformReference<double>(this, "spot_max_price");
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformArgument("tags")]
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
    }

    /// <summary>
    /// The upgrade_settings attribute.
    /// </summary>
    [TerraformArgument("upgrade_settings")]
    public TerraformList<object> UpgradeSettings
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "upgrade_settings").ResolveNodes(ctx));
    }

    /// <summary>
    /// The vm_size attribute.
    /// </summary>
    [TerraformArgument("vm_size")]
    public TerraformValue<string> VmSize
    {
        get => new TerraformReference<string>(this, "vm_size");
    }

    /// <summary>
    /// The vnet_subnet_id attribute.
    /// </summary>
    [TerraformArgument("vnet_subnet_id")]
    public TerraformValue<string> VnetSubnetId
    {
        get => new TerraformReference<string>(this, "vnet_subnet_id");
    }

    /// <summary>
    /// The zones attribute.
    /// </summary>
    [TerraformArgument("zones")]
    public TerraformList<string> Zones
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "zones").ResolveNodes(ctx));
    }

}
