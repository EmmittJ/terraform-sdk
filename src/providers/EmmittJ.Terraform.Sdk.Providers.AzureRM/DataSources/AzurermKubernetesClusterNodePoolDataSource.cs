using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermKubernetesClusterNodePoolDataSourceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_kubernetes_cluster_node_pool.
/// </summary>
public partial class AzurermKubernetesClusterNodePoolDataSource : TerraformDataSource
{
    public AzurermKubernetesClusterNodePoolDataSource(string name) : base("azurerm_kubernetes_cluster_node_pool", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The kubernetes_cluster_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KubernetesClusterName is required")]
    [TerraformProperty("kubernetes_cluster_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> KubernetesClusterName { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AzurermKubernetesClusterNodePoolDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The auto_scaling_enabled attribute.
    /// </summary>
    [TerraformProperty("auto_scaling_enabled")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> AutoScalingEnabled { get; }

    /// <summary>
    /// The eviction_policy attribute.
    /// </summary>
    [TerraformProperty("eviction_policy")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> EvictionPolicy { get; }

    /// <summary>
    /// The gpu_driver attribute.
    /// </summary>
    [TerraformProperty("gpu_driver")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> GpuDriver { get; }

    /// <summary>
    /// The max_count attribute.
    /// </summary>
    [TerraformProperty("max_count")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> MaxCount { get; }

    /// <summary>
    /// The max_pods attribute.
    /// </summary>
    [TerraformProperty("max_pods")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> MaxPods { get; }

    /// <summary>
    /// The min_count attribute.
    /// </summary>
    [TerraformProperty("min_count")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> MinCount { get; }

    /// <summary>
    /// The mode attribute.
    /// </summary>
    [TerraformProperty("mode")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Mode { get; }

    /// <summary>
    /// The node_count attribute.
    /// </summary>
    [TerraformProperty("node_count")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> NodeCount { get; }

    /// <summary>
    /// The node_labels attribute.
    /// </summary>
    [TerraformProperty("node_labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> NodeLabels { get; }

    /// <summary>
    /// The node_public_ip_enabled attribute.
    /// </summary>
    [TerraformProperty("node_public_ip_enabled")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> NodePublicIpEnabled { get; }

    /// <summary>
    /// The node_public_ip_prefix_id attribute.
    /// </summary>
    [TerraformProperty("node_public_ip_prefix_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> NodePublicIpPrefixId { get; }

    /// <summary>
    /// The node_taints attribute.
    /// </summary>
    [TerraformProperty("node_taints")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> NodeTaints { get; }

    /// <summary>
    /// The orchestrator_version attribute.
    /// </summary>
    [TerraformProperty("orchestrator_version")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> OrchestratorVersion { get; }

    /// <summary>
    /// The os_disk_size_gb attribute.
    /// </summary>
    [TerraformProperty("os_disk_size_gb")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> OsDiskSizeGb { get; }

    /// <summary>
    /// The os_disk_type attribute.
    /// </summary>
    [TerraformProperty("os_disk_type")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> OsDiskType { get; }

    /// <summary>
    /// The os_type attribute.
    /// </summary>
    [TerraformProperty("os_type")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> OsType { get; }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    [TerraformProperty("priority")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Priority { get; }

    /// <summary>
    /// The proximity_placement_group_id attribute.
    /// </summary>
    [TerraformProperty("proximity_placement_group_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ProximityPlacementGroupId { get; }

    /// <summary>
    /// The spot_max_price attribute.
    /// </summary>
    [TerraformProperty("spot_max_price")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> SpotMaxPrice { get; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> Tags { get; }

    /// <summary>
    /// The upgrade_settings attribute.
    /// </summary>
    [TerraformProperty("upgrade_settings")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> UpgradeSettings { get; }

    /// <summary>
    /// The vm_size attribute.
    /// </summary>
    [TerraformProperty("vm_size")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> VmSize { get; }

    /// <summary>
    /// The vnet_subnet_id attribute.
    /// </summary>
    [TerraformProperty("vnet_subnet_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> VnetSubnetId { get; }

    /// <summary>
    /// The zones attribute.
    /// </summary>
    [TerraformProperty("zones")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> Zones { get; }

}
