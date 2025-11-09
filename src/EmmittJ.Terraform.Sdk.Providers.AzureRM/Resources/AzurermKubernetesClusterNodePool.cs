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
    public TerraformProperty<bool>? AutoScalingEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("auto_scaling_enabled");
        set => this.WithProperty("auto_scaling_enabled", value);
    }

    /// <summary>
    /// The capacity_reservation_group_id attribute.
    /// </summary>
    public TerraformProperty<string>? CapacityReservationGroupId
    {
        get => GetProperty<TerraformProperty<string>>("capacity_reservation_group_id");
        set => this.WithProperty("capacity_reservation_group_id", value);
    }

    /// <summary>
    /// The eviction_policy attribute.
    /// </summary>
    public TerraformProperty<string>? EvictionPolicy
    {
        get => GetProperty<TerraformProperty<string>>("eviction_policy");
        set => this.WithProperty("eviction_policy", value);
    }

    /// <summary>
    /// The fips_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? FipsEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("fips_enabled");
        set => this.WithProperty("fips_enabled", value);
    }

    /// <summary>
    /// The gpu_driver attribute.
    /// </summary>
    public TerraformProperty<string>? GpuDriver
    {
        get => GetProperty<TerraformProperty<string>>("gpu_driver");
        set => this.WithProperty("gpu_driver", value);
    }

    /// <summary>
    /// The gpu_instance attribute.
    /// </summary>
    public TerraformProperty<string>? GpuInstance
    {
        get => GetProperty<TerraformProperty<string>>("gpu_instance");
        set => this.WithProperty("gpu_instance", value);
    }

    /// <summary>
    /// The host_encryption_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? HostEncryptionEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("host_encryption_enabled");
        set => this.WithProperty("host_encryption_enabled", value);
    }

    /// <summary>
    /// The host_group_id attribute.
    /// </summary>
    public TerraformProperty<string>? HostGroupId
    {
        get => GetProperty<TerraformProperty<string>>("host_group_id");
        set => this.WithProperty("host_group_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The kubelet_disk_type attribute.
    /// </summary>
    public TerraformProperty<string>? KubeletDiskType
    {
        get => GetProperty<TerraformProperty<string>>("kubelet_disk_type");
        set => this.WithProperty("kubelet_disk_type", value);
    }

    /// <summary>
    /// The kubernetes_cluster_id attribute.
    /// </summary>
    public TerraformProperty<string>? KubernetesClusterId
    {
        get => GetProperty<TerraformProperty<string>>("kubernetes_cluster_id");
        set => this.WithProperty("kubernetes_cluster_id", value);
    }

    /// <summary>
    /// The max_count attribute.
    /// </summary>
    public TerraformProperty<double>? MaxCount
    {
        get => GetProperty<TerraformProperty<double>>("max_count");
        set => this.WithProperty("max_count", value);
    }

    /// <summary>
    /// The max_pods attribute.
    /// </summary>
    public TerraformProperty<double>? MaxPods
    {
        get => GetProperty<TerraformProperty<double>>("max_pods");
        set => this.WithProperty("max_pods", value);
    }

    /// <summary>
    /// The min_count attribute.
    /// </summary>
    public TerraformProperty<double>? MinCount
    {
        get => GetProperty<TerraformProperty<double>>("min_count");
        set => this.WithProperty("min_count", value);
    }

    /// <summary>
    /// The mode attribute.
    /// </summary>
    public TerraformProperty<string>? Mode
    {
        get => GetProperty<TerraformProperty<string>>("mode");
        set => this.WithProperty("mode", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The node_count attribute.
    /// </summary>
    public TerraformProperty<double>? NodeCount
    {
        get => GetProperty<TerraformProperty<double>>("node_count");
        set => this.WithProperty("node_count", value);
    }

    /// <summary>
    /// The node_labels attribute.
    /// </summary>
    public TerraformMapProperty<string>? NodeLabels
    {
        get => GetProperty<TerraformMapProperty<string>>("node_labels");
        set => this.WithProperty("node_labels", value);
    }

    /// <summary>
    /// The node_public_ip_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? NodePublicIpEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("node_public_ip_enabled");
        set => this.WithProperty("node_public_ip_enabled", value);
    }

    /// <summary>
    /// The node_public_ip_prefix_id attribute.
    /// </summary>
    public TerraformProperty<string>? NodePublicIpPrefixId
    {
        get => GetProperty<TerraformProperty<string>>("node_public_ip_prefix_id");
        set => this.WithProperty("node_public_ip_prefix_id", value);
    }

    /// <summary>
    /// The node_taints attribute.
    /// </summary>
    public TerraformProperty<List<string>>? NodeTaints
    {
        get => GetProperty<TerraformProperty<List<string>>>("node_taints");
        set => this.WithProperty("node_taints", value);
    }

    /// <summary>
    /// The orchestrator_version attribute.
    /// </summary>
    public TerraformProperty<string>? OrchestratorVersion
    {
        get => GetProperty<TerraformProperty<string>>("orchestrator_version");
        set => this.WithProperty("orchestrator_version", value);
    }

    /// <summary>
    /// The os_disk_size_gb attribute.
    /// </summary>
    public TerraformProperty<double>? OsDiskSizeGb
    {
        get => GetProperty<TerraformProperty<double>>("os_disk_size_gb");
        set => this.WithProperty("os_disk_size_gb", value);
    }

    /// <summary>
    /// The os_disk_type attribute.
    /// </summary>
    public TerraformProperty<string>? OsDiskType
    {
        get => GetProperty<TerraformProperty<string>>("os_disk_type");
        set => this.WithProperty("os_disk_type", value);
    }

    /// <summary>
    /// The os_sku attribute.
    /// </summary>
    public TerraformProperty<string>? OsSku
    {
        get => GetProperty<TerraformProperty<string>>("os_sku");
        set => this.WithProperty("os_sku", value);
    }

    /// <summary>
    /// The os_type attribute.
    /// </summary>
    public TerraformProperty<string>? OsType
    {
        get => GetProperty<TerraformProperty<string>>("os_type");
        set => this.WithProperty("os_type", value);
    }

    /// <summary>
    /// The pod_subnet_id attribute.
    /// </summary>
    public TerraformProperty<string>? PodSubnetId
    {
        get => GetProperty<TerraformProperty<string>>("pod_subnet_id");
        set => this.WithProperty("pod_subnet_id", value);
    }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    public TerraformProperty<string>? Priority
    {
        get => GetProperty<TerraformProperty<string>>("priority");
        set => this.WithProperty("priority", value);
    }

    /// <summary>
    /// The proximity_placement_group_id attribute.
    /// </summary>
    public TerraformProperty<string>? ProximityPlacementGroupId
    {
        get => GetProperty<TerraformProperty<string>>("proximity_placement_group_id");
        set => this.WithProperty("proximity_placement_group_id", value);
    }

    /// <summary>
    /// The scale_down_mode attribute.
    /// </summary>
    public TerraformProperty<string>? ScaleDownMode
    {
        get => GetProperty<TerraformProperty<string>>("scale_down_mode");
        set => this.WithProperty("scale_down_mode", value);
    }

    /// <summary>
    /// The snapshot_id attribute.
    /// </summary>
    public TerraformProperty<string>? SnapshotId
    {
        get => GetProperty<TerraformProperty<string>>("snapshot_id");
        set => this.WithProperty("snapshot_id", value);
    }

    /// <summary>
    /// The spot_max_price attribute.
    /// </summary>
    public TerraformProperty<double>? SpotMaxPrice
    {
        get => GetProperty<TerraformProperty<double>>("spot_max_price");
        set => this.WithProperty("spot_max_price", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMapProperty<string>? Tags
    {
        get => GetProperty<TerraformMapProperty<string>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The temporary_name_for_rotation attribute.
    /// </summary>
    public TerraformProperty<string>? TemporaryNameForRotation
    {
        get => GetProperty<TerraformProperty<string>>("temporary_name_for_rotation");
        set => this.WithProperty("temporary_name_for_rotation", value);
    }

    /// <summary>
    /// The ultra_ssd_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? UltraSsdEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("ultra_ssd_enabled");
        set => this.WithProperty("ultra_ssd_enabled", value);
    }

    /// <summary>
    /// The vm_size attribute.
    /// </summary>
    public TerraformProperty<string>? VmSize
    {
        get => GetProperty<TerraformProperty<string>>("vm_size");
        set => this.WithProperty("vm_size", value);
    }

    /// <summary>
    /// The vnet_subnet_id attribute.
    /// </summary>
    public TerraformProperty<string>? VnetSubnetId
    {
        get => GetProperty<TerraformProperty<string>>("vnet_subnet_id");
        set => this.WithProperty("vnet_subnet_id", value);
    }

    /// <summary>
    /// The workload_runtime attribute.
    /// </summary>
    public TerraformProperty<string>? WorkloadRuntime
    {
        get => GetProperty<TerraformProperty<string>>("workload_runtime");
        set => this.WithProperty("workload_runtime", value);
    }

    /// <summary>
    /// The zones attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? Zones
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("zones");
        set => this.WithProperty("zones", value);
    }

}
