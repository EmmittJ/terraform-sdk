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
    public TerraformLiteralProperty<bool>? AutoScalingEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("auto_scaling_enabled");
        set => this.WithProperty("auto_scaling_enabled", value);
    }

    /// <summary>
    /// The capacity_reservation_group_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? CapacityReservationGroupId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("capacity_reservation_group_id");
        set => this.WithProperty("capacity_reservation_group_id", value);
    }

    /// <summary>
    /// The eviction_policy attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? EvictionPolicy
    {
        get => GetProperty<TerraformLiteralProperty<string>>("eviction_policy");
        set => this.WithProperty("eviction_policy", value);
    }

    /// <summary>
    /// The fips_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? FipsEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("fips_enabled");
        set => this.WithProperty("fips_enabled", value);
    }

    /// <summary>
    /// The gpu_driver attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? GpuDriver
    {
        get => GetProperty<TerraformLiteralProperty<string>>("gpu_driver");
        set => this.WithProperty("gpu_driver", value);
    }

    /// <summary>
    /// The gpu_instance attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? GpuInstance
    {
        get => GetProperty<TerraformLiteralProperty<string>>("gpu_instance");
        set => this.WithProperty("gpu_instance", value);
    }

    /// <summary>
    /// The host_encryption_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? HostEncryptionEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("host_encryption_enabled");
        set => this.WithProperty("host_encryption_enabled", value);
    }

    /// <summary>
    /// The host_group_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? HostGroupId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("host_group_id");
        set => this.WithProperty("host_group_id", value);
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
    /// The kubelet_disk_type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? KubeletDiskType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("kubelet_disk_type");
        set => this.WithProperty("kubelet_disk_type", value);
    }

    /// <summary>
    /// The kubernetes_cluster_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? KubernetesClusterId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("kubernetes_cluster_id");
        set => this.WithProperty("kubernetes_cluster_id", value);
    }

    /// <summary>
    /// The max_count attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? MaxCount
    {
        get => GetProperty<TerraformLiteralProperty<double>>("max_count");
        set => this.WithProperty("max_count", value);
    }

    /// <summary>
    /// The max_pods attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? MaxPods
    {
        get => GetProperty<TerraformLiteralProperty<double>>("max_pods");
        set => this.WithProperty("max_pods", value);
    }

    /// <summary>
    /// The min_count attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? MinCount
    {
        get => GetProperty<TerraformLiteralProperty<double>>("min_count");
        set => this.WithProperty("min_count", value);
    }

    /// <summary>
    /// The mode attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Mode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("mode");
        set => this.WithProperty("mode", value);
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
    /// The node_count attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? NodeCount
    {
        get => GetProperty<TerraformLiteralProperty<double>>("node_count");
        set => this.WithProperty("node_count", value);
    }

    /// <summary>
    /// The node_labels attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? NodeLabels
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("node_labels");
        set => this.WithProperty("node_labels", value);
    }

    /// <summary>
    /// The node_public_ip_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? NodePublicIpEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("node_public_ip_enabled");
        set => this.WithProperty("node_public_ip_enabled", value);
    }

    /// <summary>
    /// The node_public_ip_prefix_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? NodePublicIpPrefixId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("node_public_ip_prefix_id");
        set => this.WithProperty("node_public_ip_prefix_id", value);
    }

    /// <summary>
    /// The node_taints attribute.
    /// </summary>
    public TerraformLiteralProperty<List<string>>? NodeTaints
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("node_taints");
        set => this.WithProperty("node_taints", value);
    }

    /// <summary>
    /// The orchestrator_version attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? OrchestratorVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("orchestrator_version");
        set => this.WithProperty("orchestrator_version", value);
    }

    /// <summary>
    /// The os_disk_size_gb attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? OsDiskSizeGb
    {
        get => GetProperty<TerraformLiteralProperty<double>>("os_disk_size_gb");
        set => this.WithProperty("os_disk_size_gb", value);
    }

    /// <summary>
    /// The os_disk_type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? OsDiskType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("os_disk_type");
        set => this.WithProperty("os_disk_type", value);
    }

    /// <summary>
    /// The os_sku attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? OsSku
    {
        get => GetProperty<TerraformLiteralProperty<string>>("os_sku");
        set => this.WithProperty("os_sku", value);
    }

    /// <summary>
    /// The os_type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? OsType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("os_type");
        set => this.WithProperty("os_type", value);
    }

    /// <summary>
    /// The pod_subnet_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? PodSubnetId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("pod_subnet_id");
        set => this.WithProperty("pod_subnet_id", value);
    }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Priority
    {
        get => GetProperty<TerraformLiteralProperty<string>>("priority");
        set => this.WithProperty("priority", value);
    }

    /// <summary>
    /// The proximity_placement_group_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ProximityPlacementGroupId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("proximity_placement_group_id");
        set => this.WithProperty("proximity_placement_group_id", value);
    }

    /// <summary>
    /// The scale_down_mode attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ScaleDownMode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("scale_down_mode");
        set => this.WithProperty("scale_down_mode", value);
    }

    /// <summary>
    /// The snapshot_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SnapshotId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("snapshot_id");
        set => this.WithProperty("snapshot_id", value);
    }

    /// <summary>
    /// The spot_max_price attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? SpotMaxPrice
    {
        get => GetProperty<TerraformLiteralProperty<double>>("spot_max_price");
        set => this.WithProperty("spot_max_price", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The temporary_name_for_rotation attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? TemporaryNameForRotation
    {
        get => GetProperty<TerraformLiteralProperty<string>>("temporary_name_for_rotation");
        set => this.WithProperty("temporary_name_for_rotation", value);
    }

    /// <summary>
    /// The ultra_ssd_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? UltraSsdEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("ultra_ssd_enabled");
        set => this.WithProperty("ultra_ssd_enabled", value);
    }

    /// <summary>
    /// The vm_size attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? VmSize
    {
        get => GetProperty<TerraformLiteralProperty<string>>("vm_size");
        set => this.WithProperty("vm_size", value);
    }

    /// <summary>
    /// The vnet_subnet_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? VnetSubnetId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("vnet_subnet_id");
        set => this.WithProperty("vnet_subnet_id", value);
    }

    /// <summary>
    /// The workload_runtime attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? WorkloadRuntime
    {
        get => GetProperty<TerraformLiteralProperty<string>>("workload_runtime");
        set => this.WithProperty("workload_runtime", value);
    }

    /// <summary>
    /// The zones attribute.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? Zones
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("zones");
        set => this.WithProperty("zones", value);
    }

}
