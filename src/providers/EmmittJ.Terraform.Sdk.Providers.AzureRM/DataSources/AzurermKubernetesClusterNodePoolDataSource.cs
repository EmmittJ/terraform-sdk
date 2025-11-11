using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermKubernetesClusterNodePoolDataSourceTimeoutsBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

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
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The kubernetes_cluster_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KubernetesClusterName is required")]
    [TerraformPropertyName("kubernetes_cluster_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> KubernetesClusterName { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermKubernetesClusterNodePoolDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The auto_scaling_enabled attribute.
    /// </summary>
    [TerraformPropertyName("auto_scaling_enabled")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> AutoScalingEnabled => new TerraformReference(this, "auto_scaling_enabled");

    /// <summary>
    /// The eviction_policy attribute.
    /// </summary>
    [TerraformPropertyName("eviction_policy")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> EvictionPolicy => new TerraformReference(this, "eviction_policy");

    /// <summary>
    /// The gpu_driver attribute.
    /// </summary>
    [TerraformPropertyName("gpu_driver")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> GpuDriver => new TerraformReference(this, "gpu_driver");

    /// <summary>
    /// The max_count attribute.
    /// </summary>
    [TerraformPropertyName("max_count")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> MaxCount => new TerraformReference(this, "max_count");

    /// <summary>
    /// The max_pods attribute.
    /// </summary>
    [TerraformPropertyName("max_pods")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> MaxPods => new TerraformReference(this, "max_pods");

    /// <summary>
    /// The min_count attribute.
    /// </summary>
    [TerraformPropertyName("min_count")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> MinCount => new TerraformReference(this, "min_count");

    /// <summary>
    /// The mode attribute.
    /// </summary>
    [TerraformPropertyName("mode")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Mode => new TerraformReference(this, "mode");

    /// <summary>
    /// The node_count attribute.
    /// </summary>
    [TerraformPropertyName("node_count")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> NodeCount => new TerraformReference(this, "node_count");

    /// <summary>
    /// The node_labels attribute.
    /// </summary>
    [TerraformPropertyName("node_labels")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> NodeLabels => new TerraformReference(this, "node_labels");

    /// <summary>
    /// The node_public_ip_enabled attribute.
    /// </summary>
    [TerraformPropertyName("node_public_ip_enabled")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> NodePublicIpEnabled => new TerraformReference(this, "node_public_ip_enabled");

    /// <summary>
    /// The node_public_ip_prefix_id attribute.
    /// </summary>
    [TerraformPropertyName("node_public_ip_prefix_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> NodePublicIpPrefixId => new TerraformReference(this, "node_public_ip_prefix_id");

    /// <summary>
    /// The node_taints attribute.
    /// </summary>
    [TerraformPropertyName("node_taints")]
    // Output-only attribute - read-only reference
    public TerraformList<string> NodeTaints => new TerraformReference(this, "node_taints");

    /// <summary>
    /// The orchestrator_version attribute.
    /// </summary>
    [TerraformPropertyName("orchestrator_version")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> OrchestratorVersion => new TerraformReference(this, "orchestrator_version");

    /// <summary>
    /// The os_disk_size_gb attribute.
    /// </summary>
    [TerraformPropertyName("os_disk_size_gb")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> OsDiskSizeGb => new TerraformReference(this, "os_disk_size_gb");

    /// <summary>
    /// The os_disk_type attribute.
    /// </summary>
    [TerraformPropertyName("os_disk_type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> OsDiskType => new TerraformReference(this, "os_disk_type");

    /// <summary>
    /// The os_type attribute.
    /// </summary>
    [TerraformPropertyName("os_type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> OsType => new TerraformReference(this, "os_type");

    /// <summary>
    /// The priority attribute.
    /// </summary>
    [TerraformPropertyName("priority")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Priority => new TerraformReference(this, "priority");

    /// <summary>
    /// The proximity_placement_group_id attribute.
    /// </summary>
    [TerraformPropertyName("proximity_placement_group_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ProximityPlacementGroupId => new TerraformReference(this, "proximity_placement_group_id");

    /// <summary>
    /// The spot_max_price attribute.
    /// </summary>
    [TerraformPropertyName("spot_max_price")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> SpotMaxPrice => new TerraformReference(this, "spot_max_price");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> Tags => new TerraformReference(this, "tags");

    /// <summary>
    /// The upgrade_settings attribute.
    /// </summary>
    [TerraformPropertyName("upgrade_settings")]
    // Output-only attribute - read-only reference
    public TerraformList<object> UpgradeSettings => new TerraformReference(this, "upgrade_settings");

    /// <summary>
    /// The vm_size attribute.
    /// </summary>
    [TerraformPropertyName("vm_size")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> VmSize => new TerraformReference(this, "vm_size");

    /// <summary>
    /// The vnet_subnet_id attribute.
    /// </summary>
    [TerraformPropertyName("vnet_subnet_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> VnetSubnetId => new TerraformReference(this, "vnet_subnet_id");

    /// <summary>
    /// The zones attribute.
    /// </summary>
    [TerraformPropertyName("zones")]
    // Output-only attribute - read-only reference
    public TerraformList<string> Zones => new TerraformReference(this, "zones");

}
