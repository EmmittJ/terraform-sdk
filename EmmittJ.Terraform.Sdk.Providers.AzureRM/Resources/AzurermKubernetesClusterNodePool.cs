using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_kubernetes_cluster_node_pool resource.
/// </summary>
public class AzurermKubernetesClusterNodePool : TerraformResource
{
    public AzurermKubernetesClusterNodePool(string name) : base("azurerm_kubernetes_cluster_node_pool", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The auto_scaling_enabled attribute.
    /// </summary>
    public bool? AutoScalingEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("auto_scaling_enabled")?.Value;
        set => this.WithProperty("auto_scaling_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The capacity_reservation_group_id attribute.
    /// </summary>
    public string? CapacityReservationGroupId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("capacity_reservation_group_id")?.Value;
        set => this.WithProperty("capacity_reservation_group_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The eviction_policy attribute.
    /// </summary>
    public string? EvictionPolicy
    {
        get => GetProperty<TerraformLiteralProperty<string>>("eviction_policy")?.Value;
        set => this.WithProperty("eviction_policy", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The fips_enabled attribute.
    /// </summary>
    public bool? FipsEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("fips_enabled")?.Value;
        set => this.WithProperty("fips_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The gpu_driver attribute.
    /// </summary>
    public string? GpuDriver
    {
        get => GetProperty<TerraformLiteralProperty<string>>("gpu_driver")?.Value;
        set => this.WithProperty("gpu_driver", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The gpu_instance attribute.
    /// </summary>
    public string? GpuInstance
    {
        get => GetProperty<TerraformLiteralProperty<string>>("gpu_instance")?.Value;
        set => this.WithProperty("gpu_instance", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The host_encryption_enabled attribute.
    /// </summary>
    public bool? HostEncryptionEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("host_encryption_enabled")?.Value;
        set => this.WithProperty("host_encryption_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The host_group_id attribute.
    /// </summary>
    public string? HostGroupId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("host_group_id")?.Value;
        set => this.WithProperty("host_group_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The kubelet_disk_type attribute.
    /// </summary>
    public string? KubeletDiskType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("kubelet_disk_type")?.Value;
        set => this.WithProperty("kubelet_disk_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The kubernetes_cluster_id attribute.
    /// </summary>
    public string? KubernetesClusterId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("kubernetes_cluster_id")?.Value;
        set => this.WithProperty("kubernetes_cluster_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The max_count attribute.
    /// </summary>
    public double? MaxCount
    {
        get => GetProperty<TerraformLiteralProperty<double>>("max_count")?.Value;
        set => this.WithProperty("max_count", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The max_pods attribute.
    /// </summary>
    public double? MaxPods
    {
        get => GetProperty<TerraformLiteralProperty<double>>("max_pods")?.Value;
        set => this.WithProperty("max_pods", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The min_count attribute.
    /// </summary>
    public double? MinCount
    {
        get => GetProperty<TerraformLiteralProperty<double>>("min_count")?.Value;
        set => this.WithProperty("min_count", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The mode attribute.
    /// </summary>
    public string? Mode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("mode")?.Value;
        set => this.WithProperty("mode", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The node_count attribute.
    /// </summary>
    public double? NodeCount
    {
        get => GetProperty<TerraformLiteralProperty<double>>("node_count")?.Value;
        set => this.WithProperty("node_count", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The node_labels attribute.
    /// </summary>
    public Dictionary<string, string>? NodeLabels
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("node_labels")?.Value;
        set => this.WithProperty("node_labels", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The node_public_ip_enabled attribute.
    /// </summary>
    public bool? NodePublicIpEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("node_public_ip_enabled")?.Value;
        set => this.WithProperty("node_public_ip_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The node_public_ip_prefix_id attribute.
    /// </summary>
    public string? NodePublicIpPrefixId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("node_public_ip_prefix_id")?.Value;
        set => this.WithProperty("node_public_ip_prefix_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The node_taints attribute.
    /// </summary>
    public List<string>? NodeTaints
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("node_taints")?.Value;
        set => this.WithProperty("node_taints", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// The orchestrator_version attribute.
    /// </summary>
    public string? OrchestratorVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("orchestrator_version")?.Value;
        set => this.WithProperty("orchestrator_version", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The os_disk_size_gb attribute.
    /// </summary>
    public double? OsDiskSizeGb
    {
        get => GetProperty<TerraformLiteralProperty<double>>("os_disk_size_gb")?.Value;
        set => this.WithProperty("os_disk_size_gb", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The os_disk_type attribute.
    /// </summary>
    public string? OsDiskType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("os_disk_type")?.Value;
        set => this.WithProperty("os_disk_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The os_sku attribute.
    /// </summary>
    public string? OsSku
    {
        get => GetProperty<TerraformLiteralProperty<string>>("os_sku")?.Value;
        set => this.WithProperty("os_sku", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The os_type attribute.
    /// </summary>
    public string? OsType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("os_type")?.Value;
        set => this.WithProperty("os_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The pod_subnet_id attribute.
    /// </summary>
    public string? PodSubnetId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("pod_subnet_id")?.Value;
        set => this.WithProperty("pod_subnet_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    public string? Priority
    {
        get => GetProperty<TerraformLiteralProperty<string>>("priority")?.Value;
        set => this.WithProperty("priority", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The proximity_placement_group_id attribute.
    /// </summary>
    public string? ProximityPlacementGroupId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("proximity_placement_group_id")?.Value;
        set => this.WithProperty("proximity_placement_group_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The scale_down_mode attribute.
    /// </summary>
    public string? ScaleDownMode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("scale_down_mode")?.Value;
        set => this.WithProperty("scale_down_mode", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The snapshot_id attribute.
    /// </summary>
    public string? SnapshotId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("snapshot_id")?.Value;
        set => this.WithProperty("snapshot_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The spot_max_price attribute.
    /// </summary>
    public double? SpotMaxPrice
    {
        get => GetProperty<TerraformLiteralProperty<double>>("spot_max_price")?.Value;
        set => this.WithProperty("spot_max_price", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The temporary_name_for_rotation attribute.
    /// </summary>
    public string? TemporaryNameForRotation
    {
        get => GetProperty<TerraformLiteralProperty<string>>("temporary_name_for_rotation")?.Value;
        set => this.WithProperty("temporary_name_for_rotation", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The ultra_ssd_enabled attribute.
    /// </summary>
    public bool? UltraSsdEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("ultra_ssd_enabled")?.Value;
        set => this.WithProperty("ultra_ssd_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The vm_size attribute.
    /// </summary>
    public string? VmSize
    {
        get => GetProperty<TerraformLiteralProperty<string>>("vm_size")?.Value;
        set => this.WithProperty("vm_size", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The vnet_subnet_id attribute.
    /// </summary>
    public string? VnetSubnetId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("vnet_subnet_id")?.Value;
        set => this.WithProperty("vnet_subnet_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The workload_runtime attribute.
    /// </summary>
    public string? WorkloadRuntime
    {
        get => GetProperty<TerraformLiteralProperty<string>>("workload_runtime")?.Value;
        set => this.WithProperty("workload_runtime", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The zones attribute.
    /// </summary>
    public HashSet<string>? Zones
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("zones")?.Value;
        set => this.WithProperty("zones", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

}
