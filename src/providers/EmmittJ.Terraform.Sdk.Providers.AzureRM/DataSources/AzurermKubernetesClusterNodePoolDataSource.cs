using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermKubernetesClusterNodePoolDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The kubernetes_cluster_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KubernetesClusterName is required")]
    [TerraformPropertyName("kubernetes_cluster_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> KubernetesClusterName { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ResourceGroupName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermKubernetesClusterNodePoolDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The auto_scaling_enabled attribute.
    /// </summary>
    [TerraformPropertyName("auto_scaling_enabled")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> AutoScalingEnabled => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "auto_scaling_enabled");

    /// <summary>
    /// The eviction_policy attribute.
    /// </summary>
    [TerraformPropertyName("eviction_policy")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> EvictionPolicy => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "eviction_policy");

    /// <summary>
    /// The gpu_driver attribute.
    /// </summary>
    [TerraformPropertyName("gpu_driver")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> GpuDriver => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "gpu_driver");

    /// <summary>
    /// The max_count attribute.
    /// </summary>
    [TerraformPropertyName("max_count")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> MaxCount => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "max_count");

    /// <summary>
    /// The max_pods attribute.
    /// </summary>
    [TerraformPropertyName("max_pods")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> MaxPods => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "max_pods");

    /// <summary>
    /// The min_count attribute.
    /// </summary>
    [TerraformPropertyName("min_count")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> MinCount => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "min_count");

    /// <summary>
    /// The mode attribute.
    /// </summary>
    [TerraformPropertyName("mode")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Mode => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "mode");

    /// <summary>
    /// The node_count attribute.
    /// </summary>
    [TerraformPropertyName("node_count")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> NodeCount => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "node_count");

    /// <summary>
    /// The node_labels attribute.
    /// </summary>
    [TerraformPropertyName("node_labels")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> NodeLabels => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "node_labels");

    /// <summary>
    /// The node_public_ip_enabled attribute.
    /// </summary>
    [TerraformPropertyName("node_public_ip_enabled")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> NodePublicIpEnabled => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "node_public_ip_enabled");

    /// <summary>
    /// The node_public_ip_prefix_id attribute.
    /// </summary>
    [TerraformPropertyName("node_public_ip_prefix_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> NodePublicIpPrefixId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "node_public_ip_prefix_id");

    /// <summary>
    /// The node_taints attribute.
    /// </summary>
    [TerraformPropertyName("node_taints")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> NodeTaints => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "node_taints");

    /// <summary>
    /// The orchestrator_version attribute.
    /// </summary>
    [TerraformPropertyName("orchestrator_version")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> OrchestratorVersion => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "orchestrator_version");

    /// <summary>
    /// The os_disk_size_gb attribute.
    /// </summary>
    [TerraformPropertyName("os_disk_size_gb")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> OsDiskSizeGb => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "os_disk_size_gb");

    /// <summary>
    /// The os_disk_type attribute.
    /// </summary>
    [TerraformPropertyName("os_disk_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> OsDiskType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "os_disk_type");

    /// <summary>
    /// The os_type attribute.
    /// </summary>
    [TerraformPropertyName("os_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> OsType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "os_type");

    /// <summary>
    /// The priority attribute.
    /// </summary>
    [TerraformPropertyName("priority")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Priority => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "priority");

    /// <summary>
    /// The proximity_placement_group_id attribute.
    /// </summary>
    [TerraformPropertyName("proximity_placement_group_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ProximityPlacementGroupId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "proximity_placement_group_id");

    /// <summary>
    /// The spot_max_price attribute.
    /// </summary>
    [TerraformPropertyName("spot_max_price")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> SpotMaxPrice => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "spot_max_price");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags");

    /// <summary>
    /// The upgrade_settings attribute.
    /// </summary>
    [TerraformPropertyName("upgrade_settings")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> UpgradeSettings => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "upgrade_settings");

    /// <summary>
    /// The vm_size attribute.
    /// </summary>
    [TerraformPropertyName("vm_size")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> VmSize => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "vm_size");

    /// <summary>
    /// The vnet_subnet_id attribute.
    /// </summary>
    [TerraformPropertyName("vnet_subnet_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> VnetSubnetId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "vnet_subnet_id");

    /// <summary>
    /// The zones attribute.
    /// </summary>
    [TerraformPropertyName("zones")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> Zones => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "zones");

}
