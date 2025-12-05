using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for cluster_config in GoogleDataprocCluster.
/// Nesting mode: list
/// </summary>
public class GoogleDataprocClusterClusterConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cluster_config";

    /// <summary>
    ///  The name of the cloud storage bucket ultimately used to house the staging data for the cluster. If staging_bucket is specified, it will contain this value, otherwise it will be the auto generated name.
    /// </summary>
    public TerraformValue<string> Bucket
        => CreateReference("bucket");

    /// <summary>
    /// Specifies the tier of the cluster created.
    /// </summary>
    public TerraformValue<string> ClusterTier
    {
        get => GetArgument<TerraformValue<string>>("cluster_tier") ?? CreateReference("cluster_tier");
        set => SetArgument("cluster_tier", value);
    }

    /// <summary>
    /// The Cloud Storage staging bucket used to stage files, such as Hadoop jars, between client machines and the cluster. Note: If you don&#39;t explicitly specify a staging_bucket then GCP will auto create / assign one for you. However, you are not guaranteed an auto generated bucket which is solely dedicated to your cluster; it may be shared with other clusters in the same region/zone also choosing to use the auto generation option.
    /// </summary>
    public TerraformValue<string>? StagingBucket
    {
        get => GetArgument<TerraformValue<string>>("staging_bucket");
        set => SetArgument("staging_bucket", value);
    }

    /// <summary>
    /// The Cloud Storage temp bucket used to store ephemeral cluster and jobs data, such as Spark and MapReduce history files. Note: If you don&#39;t explicitly specify a temp_bucket then GCP will auto create / assign one for you.
    /// </summary>
    public TerraformValue<string> TempBucket
    {
        get => GetArgument<TerraformValue<string>>("temp_bucket") ?? CreateReference("temp_bucket");
        set => SetArgument("temp_bucket", value);
    }

    /// <summary>
    /// AutoscalingConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutoscalingConfig block(s) allowed")]
    public TerraformList<GoogleDataprocClusterClusterConfigBlockAutoscalingConfigBlock>? AutoscalingConfig
    {
        get => GetArgument<TerraformList<GoogleDataprocClusterClusterConfigBlockAutoscalingConfigBlock>>("autoscaling_config");
        set => SetArgument("autoscaling_config", value);
    }

    /// <summary>
    /// AuxiliaryNodeGroups block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleDataprocClusterClusterConfigBlockAuxiliaryNodeGroupsBlock>? AuxiliaryNodeGroups
    {
        get => GetArgument<TerraformList<GoogleDataprocClusterClusterConfigBlockAuxiliaryNodeGroupsBlock>>("auxiliary_node_groups");
        set => SetArgument("auxiliary_node_groups", value);
    }

    /// <summary>
    /// DataprocMetricConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DataprocMetricConfig block(s) allowed")]
    public TerraformList<GoogleDataprocClusterClusterConfigBlockDataprocMetricConfigBlock>? DataprocMetricConfig
    {
        get => GetArgument<TerraformList<GoogleDataprocClusterClusterConfigBlockDataprocMetricConfigBlock>>("dataproc_metric_config");
        set => SetArgument("dataproc_metric_config", value);
    }

    /// <summary>
    /// EncryptionConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EncryptionConfig block(s) allowed")]
    public TerraformList<GoogleDataprocClusterClusterConfigBlockEncryptionConfigBlock>? EncryptionConfig
    {
        get => GetArgument<TerraformList<GoogleDataprocClusterClusterConfigBlockEncryptionConfigBlock>>("encryption_config");
        set => SetArgument("encryption_config", value);
    }

    /// <summary>
    /// EndpointConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EndpointConfig block(s) allowed")]
    public TerraformList<GoogleDataprocClusterClusterConfigBlockEndpointConfigBlock>? EndpointConfig
    {
        get => GetArgument<TerraformList<GoogleDataprocClusterClusterConfigBlockEndpointConfigBlock>>("endpoint_config");
        set => SetArgument("endpoint_config", value);
    }

    /// <summary>
    /// GceClusterConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GceClusterConfig block(s) allowed")]
    public TerraformList<GoogleDataprocClusterClusterConfigBlockGceClusterConfigBlock>? GceClusterConfig
    {
        get => GetArgument<TerraformList<GoogleDataprocClusterClusterConfigBlockGceClusterConfigBlock>>("gce_cluster_config");
        set => SetArgument("gce_cluster_config", value);
    }

    /// <summary>
    /// InitializationAction block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleDataprocClusterClusterConfigBlockInitializationActionBlock>? InitializationAction
    {
        get => GetArgument<TerraformList<GoogleDataprocClusterClusterConfigBlockInitializationActionBlock>>("initialization_action");
        set => SetArgument("initialization_action", value);
    }

    /// <summary>
    /// LifecycleConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LifecycleConfig block(s) allowed")]
    public TerraformList<GoogleDataprocClusterClusterConfigBlockLifecycleConfigBlock>? LifecycleConfig
    {
        get => GetArgument<TerraformList<GoogleDataprocClusterClusterConfigBlockLifecycleConfigBlock>>("lifecycle_config");
        set => SetArgument("lifecycle_config", value);
    }

    /// <summary>
    /// MasterConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MasterConfig block(s) allowed")]
    public TerraformList<GoogleDataprocClusterClusterConfigBlockMasterConfigBlock>? MasterConfig
    {
        get => GetArgument<TerraformList<GoogleDataprocClusterClusterConfigBlockMasterConfigBlock>>("master_config");
        set => SetArgument("master_config", value);
    }

    /// <summary>
    /// MetastoreConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MetastoreConfig block(s) allowed")]
    public TerraformList<GoogleDataprocClusterClusterConfigBlockMetastoreConfigBlock>? MetastoreConfig
    {
        get => GetArgument<TerraformList<GoogleDataprocClusterClusterConfigBlockMetastoreConfigBlock>>("metastore_config");
        set => SetArgument("metastore_config", value);
    }

    /// <summary>
    /// PreemptibleWorkerConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PreemptibleWorkerConfig block(s) allowed")]
    public TerraformList<GoogleDataprocClusterClusterConfigBlockPreemptibleWorkerConfigBlock>? PreemptibleWorkerConfig
    {
        get => GetArgument<TerraformList<GoogleDataprocClusterClusterConfigBlockPreemptibleWorkerConfigBlock>>("preemptible_worker_config");
        set => SetArgument("preemptible_worker_config", value);
    }

    /// <summary>
    /// SecurityConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SecurityConfig block(s) allowed")]
    public TerraformList<GoogleDataprocClusterClusterConfigBlockSecurityConfigBlock>? SecurityConfig
    {
        get => GetArgument<TerraformList<GoogleDataprocClusterClusterConfigBlockSecurityConfigBlock>>("security_config");
        set => SetArgument("security_config", value);
    }

    /// <summary>
    /// SoftwareConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SoftwareConfig block(s) allowed")]
    public TerraformList<GoogleDataprocClusterClusterConfigBlockSoftwareConfigBlock>? SoftwareConfig
    {
        get => GetArgument<TerraformList<GoogleDataprocClusterClusterConfigBlockSoftwareConfigBlock>>("software_config");
        set => SetArgument("software_config", value);
    }

    /// <summary>
    /// WorkerConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WorkerConfig block(s) allowed")]
    public TerraformList<GoogleDataprocClusterClusterConfigBlockWorkerConfigBlock>? WorkerConfig
    {
        get => GetArgument<TerraformList<GoogleDataprocClusterClusterConfigBlockWorkerConfigBlock>>("worker_config");
        set => SetArgument("worker_config", value);
    }

}

/// <summary>
/// Block type for autoscaling_config in GoogleDataprocClusterClusterConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataprocClusterClusterConfigBlockAutoscalingConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "autoscaling_config";

    /// <summary>
    /// The autoscaling policy used by the cluster.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicyUri is required")]
    public required TerraformValue<string> PolicyUri
    {
        get => GetRequiredArgument<TerraformValue<string>>("policy_uri");
        set => SetArgument("policy_uri", value);
    }

}

/// <summary>
/// Block type for auxiliary_node_groups in GoogleDataprocClusterClusterConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataprocClusterClusterConfigBlockAuxiliaryNodeGroupsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "auxiliary_node_groups";

    /// <summary>
    /// A node group ID. Generated if not specified. The ID must contain only letters (a-z, A-Z), numbers (0-9), underscores (_), and hyphens (-). Cannot begin or end with underscore or hyphen. Must consist of from 3 to 33 characters.
    /// </summary>
    public TerraformValue<string> NodeGroupId
    {
        get => GetArgument<TerraformValue<string>>("node_group_id") ?? CreateReference("node_group_id");
        set => SetArgument("node_group_id", value);
    }

    /// <summary>
    /// NodeGroup block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NodeGroup is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 NodeGroup block(s) required")]
    public required TerraformList<GoogleDataprocClusterClusterConfigBlockAuxiliaryNodeGroupsBlockNodeGroupBlock> NodeGroup
    {
        get => GetRequiredArgument<TerraformList<GoogleDataprocClusterClusterConfigBlockAuxiliaryNodeGroupsBlockNodeGroupBlock>>("node_group");
        set => SetArgument("node_group", value);
    }

}

/// <summary>
/// Block type for node_group in GoogleDataprocClusterClusterConfigBlockAuxiliaryNodeGroupsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataprocClusterClusterConfigBlockAuxiliaryNodeGroupsBlockNodeGroupBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "node_group";

    /// <summary>
    /// The Node group resource name.
    /// </summary>
    public TerraformValue<string> Name
        => CreateReference("name");

    /// <summary>
    /// Node group roles.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Roles is required")]
    public TerraformList<string>? Roles
    {
        get => GetArgument<TerraformList<string>>("roles");
        set => SetArgument("roles", value);
    }

    /// <summary>
    /// NodeGroupConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NodeGroupConfig block(s) allowed")]
    public TerraformList<GoogleDataprocClusterClusterConfigBlockAuxiliaryNodeGroupsBlockNodeGroupBlockNodeGroupConfigBlock>? NodeGroupConfig
    {
        get => GetArgument<TerraformList<GoogleDataprocClusterClusterConfigBlockAuxiliaryNodeGroupsBlockNodeGroupBlockNodeGroupConfigBlock>>("node_group_config");
        set => SetArgument("node_group_config", value);
    }

}

/// <summary>
/// Block type for node_group_config in GoogleDataprocClusterClusterConfigBlockAuxiliaryNodeGroupsBlockNodeGroupBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataprocClusterClusterConfigBlockAuxiliaryNodeGroupsBlockNodeGroupBlockNodeGroupConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "node_group_config";

    /// <summary>
    /// List of auxiliary node group instance names which have been assigned to the cluster.
    /// </summary>
    public TerraformList<string> InstanceNames
        => CreateReference("instance_names");

    /// <summary>
    /// The name of a Google Compute Engine machine type to create for the master
    /// </summary>
    public TerraformValue<string> MachineType
    {
        get => GetArgument<TerraformValue<string>>("machine_type") ?? CreateReference("machine_type");
        set => SetArgument("machine_type", value);
    }

    /// <summary>
    /// The name of a minimum generation of CPU family for the auxiliary node group. If not specified, GCP will default to a predetermined computed value for each zone.
    /// </summary>
    public TerraformValue<string> MinCpuPlatform
    {
        get => GetArgument<TerraformValue<string>>("min_cpu_platform") ?? CreateReference("min_cpu_platform");
        set => SetArgument("min_cpu_platform", value);
    }

    /// <summary>
    /// Specifies the number of auxiliary nodes to create. If not specified, GCP will default to a predetermined computed value.
    /// </summary>
    public TerraformValue<double> NumInstances
    {
        get => GetArgument<TerraformValue<double>>("num_instances") ?? CreateReference("num_instances");
        set => SetArgument("num_instances", value);
    }

    /// <summary>
    /// Accelerators block (nesting mode: set).
    /// </summary>
    public TerraformSet<GoogleDataprocClusterClusterConfigBlockAuxiliaryNodeGroupsBlockNodeGroupBlockNodeGroupConfigBlockAcceleratorsBlock>? Accelerators
    {
        get => GetArgument<TerraformSet<GoogleDataprocClusterClusterConfigBlockAuxiliaryNodeGroupsBlockNodeGroupBlockNodeGroupConfigBlockAcceleratorsBlock>>("accelerators");
        set => SetArgument("accelerators", value);
    }

    /// <summary>
    /// DiskConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DiskConfig block(s) allowed")]
    public TerraformList<GoogleDataprocClusterClusterConfigBlockAuxiliaryNodeGroupsBlockNodeGroupBlockNodeGroupConfigBlockDiskConfigBlock>? DiskConfig
    {
        get => GetArgument<TerraformList<GoogleDataprocClusterClusterConfigBlockAuxiliaryNodeGroupsBlockNodeGroupBlockNodeGroupConfigBlockDiskConfigBlock>>("disk_config");
        set => SetArgument("disk_config", value);
    }

}

/// <summary>
/// Block type for accelerators in GoogleDataprocClusterClusterConfigBlockAuxiliaryNodeGroupsBlockNodeGroupBlockNodeGroupConfigBlock.
/// Nesting mode: set
/// </summary>
public class GoogleDataprocClusterClusterConfigBlockAuxiliaryNodeGroupsBlockNodeGroupBlockNodeGroupConfigBlockAcceleratorsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "accelerators";

    /// <summary>
    /// The number of the accelerator cards of this type exposed to this instance. Often restricted to one of 1, 2, 4, or 8.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AcceleratorCount is required")]
    public required TerraformValue<double> AcceleratorCount
    {
        get => GetRequiredArgument<TerraformValue<double>>("accelerator_count");
        set => SetArgument("accelerator_count", value);
    }

    /// <summary>
    /// The short name of the accelerator type to expose to this instance. For example, nvidia-tesla-k80.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AcceleratorType is required")]
    public required TerraformValue<string> AcceleratorType
    {
        get => GetRequiredArgument<TerraformValue<string>>("accelerator_type");
        set => SetArgument("accelerator_type", value);
    }

}

/// <summary>
/// Block type for disk_config in GoogleDataprocClusterClusterConfigBlockAuxiliaryNodeGroupsBlockNodeGroupBlockNodeGroupConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataprocClusterClusterConfigBlockAuxiliaryNodeGroupsBlockNodeGroupBlockNodeGroupConfigBlockDiskConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "disk_config";

    /// <summary>
    /// Size of the primary disk attached to each node, specified in GB. The primary disk contains the boot volume and system libraries, and the smallest allowed disk size is 10GB. GCP will default to a predetermined computed value if not set (currently 500GB). Note: If SSDs are not attached, it also contains the HDFS data blocks and Hadoop working directories.
    /// </summary>
    public TerraformValue<double> BootDiskSizeGb
    {
        get => GetArgument<TerraformValue<double>>("boot_disk_size_gb") ?? CreateReference("boot_disk_size_gb");
        set => SetArgument("boot_disk_size_gb", value);
    }

    /// <summary>
    /// The disk type of the primary disk attached to each node. Such as &amp;quot;pd-ssd&amp;quot; or &amp;quot;pd-standard&amp;quot;. Defaults to &amp;quot;pd-standard&amp;quot;.
    /// </summary>
    public TerraformValue<string>? BootDiskType
    {
        get => GetArgument<TerraformValue<string>>("boot_disk_type");
        set => SetArgument("boot_disk_type", value);
    }

    /// <summary>
    /// Interface type of local SSDs (default is &amp;quot;scsi&amp;quot;). Valid values: &amp;quot;scsi&amp;quot; (Small Computer System Interface), &amp;quot;nvme&amp;quot; (Non-Volatile Memory Express).
    /// </summary>
    public TerraformValue<string>? LocalSsdInterface
    {
        get => GetArgument<TerraformValue<string>>("local_ssd_interface");
        set => SetArgument("local_ssd_interface", value);
    }

    /// <summary>
    /// The amount of local SSD disks that will be attached to each master cluster node. Defaults to 0.
    /// </summary>
    public TerraformValue<double> NumLocalSsds
    {
        get => GetArgument<TerraformValue<double>>("num_local_ssds") ?? CreateReference("num_local_ssds");
        set => SetArgument("num_local_ssds", value);
    }

}

/// <summary>
/// Block type for dataproc_metric_config in GoogleDataprocClusterClusterConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataprocClusterClusterConfigBlockDataprocMetricConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "dataproc_metric_config";

    /// <summary>
    /// Metrics block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Metrics is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Metrics block(s) required")]
    public required TerraformList<GoogleDataprocClusterClusterConfigBlockDataprocMetricConfigBlockMetricsBlock> Metrics
    {
        get => GetRequiredArgument<TerraformList<GoogleDataprocClusterClusterConfigBlockDataprocMetricConfigBlockMetricsBlock>>("metrics");
        set => SetArgument("metrics", value);
    }

}

/// <summary>
/// Block type for metrics in GoogleDataprocClusterClusterConfigBlockDataprocMetricConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataprocClusterClusterConfigBlockDataprocMetricConfigBlockMetricsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "metrics";

    /// <summary>
    /// Specify one or more [available OSS metrics] (https://cloud.google.com/dataproc/docs/guides/monitoring#available_oss_metrics) to collect.
    /// </summary>
    public TerraformSet<string>? MetricOverrides
    {
        get => GetArgument<TerraformSet<string>>("metric_overrides");
        set => SetArgument("metric_overrides", value);
    }

    /// <summary>
    /// A source for the collection of Dataproc OSS metrics (see [available OSS metrics] (https://cloud.google.com//dataproc/docs/guides/monitoring#available_oss_metrics)).
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MetricSource is required")]
    public required TerraformValue<string> MetricSource
    {
        get => GetRequiredArgument<TerraformValue<string>>("metric_source");
        set => SetArgument("metric_source", value);
    }

}

/// <summary>
/// Block type for encryption_config in GoogleDataprocClusterClusterConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataprocClusterClusterConfigBlockEncryptionConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "encryption_config";

    /// <summary>
    /// The Cloud KMS key name to use for PD disk encryption for all instances in the cluster.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KmsKeyName is required")]
    public required TerraformValue<string> KmsKeyName
    {
        get => GetRequiredArgument<TerraformValue<string>>("kms_key_name");
        set => SetArgument("kms_key_name", value);
    }

}

/// <summary>
/// Block type for endpoint_config in GoogleDataprocClusterClusterConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataprocClusterClusterConfigBlockEndpointConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "endpoint_config";

    /// <summary>
    /// The flag to enable http access to specific ports on the cluster from external sources (aka Component Gateway). Defaults to false.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EnableHttpPortAccess is required")]
    public required TerraformValue<bool> EnableHttpPortAccess
    {
        get => GetRequiredArgument<TerraformValue<bool>>("enable_http_port_access");
        set => SetArgument("enable_http_port_access", value);
    }

    /// <summary>
    /// The map of port descriptions to URLs. Will only be populated if enable_http_port_access is true.
    /// </summary>
    public TerraformMap<string> HttpPorts
        => CreateReference("http_ports");

}

/// <summary>
/// Block type for gce_cluster_config in GoogleDataprocClusterClusterConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataprocClusterClusterConfigBlockGceClusterConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "gce_cluster_config";

    /// <summary>
    /// By default, clusters are not restricted to internal IP addresses, and will have ephemeral external IP addresses assigned to each instance. If set to true, all instances in the cluster will only have internal IP addresses. Note: Private Google Access (also known as privateIpGoogleAccess) must be enabled on the subnetwork that the cluster will be launched in.
    /// </summary>
    public TerraformValue<bool>? InternalIpOnly
    {
        get => GetArgument<TerraformValue<bool>>("internal_ip_only");
        set => SetArgument("internal_ip_only", value);
    }

    /// <summary>
    /// A map of the Compute Engine metadata entries to add to all instances
    /// </summary>
    public TerraformMap<string> Metadata
    {
        get => GetArgument<TerraformMap<string>>("metadata") ?? CreateReference("metadata");
        set => SetArgument("metadata", value);
    }

    /// <summary>
    /// The name or self_link of the Google Compute Engine network to the cluster will be part of. Conflicts with subnetwork. If neither is specified, this defaults to the &amp;quot;default&amp;quot; network.
    /// </summary>
    public TerraformValue<string> Network
    {
        get => GetArgument<TerraformValue<string>>("network") ?? CreateReference("network");
        set => SetArgument("network", value);
    }

    /// <summary>
    /// The service account to be used by the Node VMs. If not specified, the &amp;quot;default&amp;quot; service account is used.
    /// </summary>
    public TerraformValue<string>? ServiceAccount
    {
        get => GetArgument<TerraformValue<string>>("service_account");
        set => SetArgument("service_account", value);
    }

    /// <summary>
    /// The set of Google API scopes to be made available on all of the node VMs under the service_account specified. These can be either FQDNs, or scope aliases.
    /// </summary>
    public TerraformSet<string> ServiceAccountScopes
    {
        get => GetArgument<TerraformSet<string>>("service_account_scopes") ?? CreateReference("service_account_scopes");
        set => SetArgument("service_account_scopes", value);
    }

    /// <summary>
    /// The name or self_link of the Google Compute Engine subnetwork the cluster will be part of. Conflicts with network.
    /// </summary>
    public TerraformValue<string>? Subnetwork
    {
        get => GetArgument<TerraformValue<string>>("subnetwork");
        set => SetArgument("subnetwork", value);
    }

    /// <summary>
    /// The list of instance tags applied to instances in the cluster. Tags are used to identify valid sources or targets for network firewalls.
    /// </summary>
    public TerraformSet<string>? Tags
    {
        get => GetArgument<TerraformSet<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The GCP zone where your data is stored and used (i.e. where the master and the worker nodes will be created in). If region is set to &#39;global&#39; (default) then zone is mandatory, otherwise GCP is able to make use of Auto Zone Placement to determine this automatically for you. Note: This setting additionally determines and restricts which computing resources are available for use with other configs such as cluster_config.master_config.machine_type and cluster_config.worker_config.machine_type.
    /// </summary>
    public TerraformValue<string> Zone
    {
        get => GetArgument<TerraformValue<string>>("zone") ?? CreateReference("zone");
        set => SetArgument("zone", value);
    }

    /// <summary>
    /// ConfidentialInstanceConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ConfidentialInstanceConfig block(s) allowed")]
    public TerraformList<GoogleDataprocClusterClusterConfigBlockGceClusterConfigBlockConfidentialInstanceConfigBlock>? ConfidentialInstanceConfig
    {
        get => GetArgument<TerraformList<GoogleDataprocClusterClusterConfigBlockGceClusterConfigBlockConfidentialInstanceConfigBlock>>("confidential_instance_config");
        set => SetArgument("confidential_instance_config", value);
    }

    /// <summary>
    /// NodeGroupAffinity block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NodeGroupAffinity block(s) allowed")]
    public TerraformList<GoogleDataprocClusterClusterConfigBlockGceClusterConfigBlockNodeGroupAffinityBlock>? NodeGroupAffinity
    {
        get => GetArgument<TerraformList<GoogleDataprocClusterClusterConfigBlockGceClusterConfigBlockNodeGroupAffinityBlock>>("node_group_affinity");
        set => SetArgument("node_group_affinity", value);
    }

    /// <summary>
    /// ReservationAffinity block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ReservationAffinity block(s) allowed")]
    public TerraformList<GoogleDataprocClusterClusterConfigBlockGceClusterConfigBlockReservationAffinityBlock>? ReservationAffinity
    {
        get => GetArgument<TerraformList<GoogleDataprocClusterClusterConfigBlockGceClusterConfigBlockReservationAffinityBlock>>("reservation_affinity");
        set => SetArgument("reservation_affinity", value);
    }

    /// <summary>
    /// ShieldedInstanceConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ShieldedInstanceConfig block(s) allowed")]
    public TerraformList<GoogleDataprocClusterClusterConfigBlockGceClusterConfigBlockShieldedInstanceConfigBlock>? ShieldedInstanceConfig
    {
        get => GetArgument<TerraformList<GoogleDataprocClusterClusterConfigBlockGceClusterConfigBlockShieldedInstanceConfigBlock>>("shielded_instance_config");
        set => SetArgument("shielded_instance_config", value);
    }

}

/// <summary>
/// Block type for confidential_instance_config in GoogleDataprocClusterClusterConfigBlockGceClusterConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataprocClusterClusterConfigBlockGceClusterConfigBlockConfidentialInstanceConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "confidential_instance_config";

    /// <summary>
    /// Defines whether the instance should have confidential compute enabled.
    /// </summary>
    public TerraformValue<bool>? EnableConfidentialCompute
    {
        get => GetArgument<TerraformValue<bool>>("enable_confidential_compute");
        set => SetArgument("enable_confidential_compute", value);
    }

}

/// <summary>
/// Block type for node_group_affinity in GoogleDataprocClusterClusterConfigBlockGceClusterConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataprocClusterClusterConfigBlockGceClusterConfigBlockNodeGroupAffinityBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "node_group_affinity";

    /// <summary>
    /// The URI of a sole-tenant that the cluster will be created on.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NodeGroupUri is required")]
    public required TerraformValue<string> NodeGroupUri
    {
        get => GetRequiredArgument<TerraformValue<string>>("node_group_uri");
        set => SetArgument("node_group_uri", value);
    }

}

/// <summary>
/// Block type for reservation_affinity in GoogleDataprocClusterClusterConfigBlockGceClusterConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataprocClusterClusterConfigBlockGceClusterConfigBlockReservationAffinityBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "reservation_affinity";

    /// <summary>
    /// Type of reservation to consume.
    /// </summary>
    public TerraformValue<string>? ConsumeReservationType
    {
        get => GetArgument<TerraformValue<string>>("consume_reservation_type");
        set => SetArgument("consume_reservation_type", value);
    }

    /// <summary>
    /// Corresponds to the label key of reservation resource.
    /// </summary>
    public TerraformValue<string>? Key
    {
        get => GetArgument<TerraformValue<string>>("key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// Corresponds to the label values of reservation resource.
    /// </summary>
    public TerraformSet<string>? ValuesAttribute
    {
        get => GetArgument<TerraformSet<string>>("values");
        set => SetArgument("values", value);
    }

}

/// <summary>
/// Block type for shielded_instance_config in GoogleDataprocClusterClusterConfigBlockGceClusterConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataprocClusterClusterConfigBlockGceClusterConfigBlockShieldedInstanceConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "shielded_instance_config";

    /// <summary>
    /// Defines whether instances have integrity monitoring enabled.
    /// </summary>
    public TerraformValue<bool>? EnableIntegrityMonitoring
    {
        get => GetArgument<TerraformValue<bool>>("enable_integrity_monitoring");
        set => SetArgument("enable_integrity_monitoring", value);
    }

    /// <summary>
    /// Defines whether instances have Secure Boot enabled.
    /// </summary>
    public TerraformValue<bool>? EnableSecureBoot
    {
        get => GetArgument<TerraformValue<bool>>("enable_secure_boot");
        set => SetArgument("enable_secure_boot", value);
    }

    /// <summary>
    /// Defines whether instances have the vTPM enabled.
    /// </summary>
    public TerraformValue<bool>? EnableVtpm
    {
        get => GetArgument<TerraformValue<bool>>("enable_vtpm");
        set => SetArgument("enable_vtpm", value);
    }

}

/// <summary>
/// Block type for initialization_action in GoogleDataprocClusterClusterConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataprocClusterClusterConfigBlockInitializationActionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "initialization_action";

    /// <summary>
    /// The script to be executed during initialization of the cluster. The script must be a GCS file with a gs:// prefix.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Script is required")]
    public required TerraformValue<string> Script
    {
        get => GetRequiredArgument<TerraformValue<string>>("script");
        set => SetArgument("script", value);
    }

    /// <summary>
    /// The maximum duration (in seconds) which script is allowed to take to execute its action. GCP will default to a predetermined computed value if not set (currently 300).
    /// </summary>
    public TerraformValue<double>? TimeoutSec
    {
        get => GetArgument<TerraformValue<double>>("timeout_sec");
        set => SetArgument("timeout_sec", value);
    }

}

/// <summary>
/// Block type for lifecycle_config in GoogleDataprocClusterClusterConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataprocClusterClusterConfigBlockLifecycleConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "lifecycle_config";

    /// <summary>
    /// The time when cluster will be auto-deleted. A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, accurate to nanoseconds. Example: &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    public TerraformValue<string>? AutoDeleteTime
    {
        get => GetArgument<TerraformValue<string>>("auto_delete_time");
        set => SetArgument("auto_delete_time", value);
    }

    /// <summary>
    /// The duration to keep the cluster alive while idling (no jobs running). After this TTL, the cluster will be deleted. Valid range: [10m, 14d].
    /// </summary>
    public TerraformValue<string>? IdleDeleteTtl
    {
        get => GetArgument<TerraformValue<string>>("idle_delete_ttl");
        set => SetArgument("idle_delete_ttl", value);
    }

    /// <summary>
    /// Time when the cluster became idle (most recent job finished) and became eligible for deletion due to idleness.
    /// </summary>
    public TerraformValue<string> IdleStartTime
        => CreateReference("idle_start_time");

}

/// <summary>
/// Block type for master_config in GoogleDataprocClusterClusterConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataprocClusterClusterConfigBlockMasterConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "master_config";

    /// <summary>
    /// The URI for the image to use for this master
    /// </summary>
    public TerraformValue<string> ImageUri
    {
        get => GetArgument<TerraformValue<string>>("image_uri") ?? CreateReference("image_uri");
        set => SetArgument("image_uri", value);
    }

    /// <summary>
    /// List of master instance names which have been assigned to the cluster.
    /// </summary>
    public TerraformList<string> InstanceNames
        => CreateReference("instance_names");

    /// <summary>
    /// The name of a Google Compute Engine machine type to create for the master
    /// </summary>
    public TerraformValue<string> MachineType
    {
        get => GetArgument<TerraformValue<string>>("machine_type") ?? CreateReference("machine_type");
        set => SetArgument("machine_type", value);
    }

    /// <summary>
    /// The name of a minimum generation of CPU family for the master. If not specified, GCP will default to a predetermined computed value for each zone.
    /// </summary>
    public TerraformValue<string> MinCpuPlatform
    {
        get => GetArgument<TerraformValue<string>>("min_cpu_platform") ?? CreateReference("min_cpu_platform");
        set => SetArgument("min_cpu_platform", value);
    }

    /// <summary>
    /// Specifies the number of master nodes to create. If not specified, GCP will default to a predetermined computed value.
    /// </summary>
    public TerraformValue<double> NumInstances
    {
        get => GetArgument<TerraformValue<double>>("num_instances") ?? CreateReference("num_instances");
        set => SetArgument("num_instances", value);
    }

    /// <summary>
    /// Accelerators block (nesting mode: set).
    /// </summary>
    public TerraformSet<GoogleDataprocClusterClusterConfigBlockMasterConfigBlockAcceleratorsBlock>? Accelerators
    {
        get => GetArgument<TerraformSet<GoogleDataprocClusterClusterConfigBlockMasterConfigBlockAcceleratorsBlock>>("accelerators");
        set => SetArgument("accelerators", value);
    }

    /// <summary>
    /// DiskConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DiskConfig block(s) allowed")]
    public TerraformList<GoogleDataprocClusterClusterConfigBlockMasterConfigBlockDiskConfigBlock>? DiskConfig
    {
        get => GetArgument<TerraformList<GoogleDataprocClusterClusterConfigBlockMasterConfigBlockDiskConfigBlock>>("disk_config");
        set => SetArgument("disk_config", value);
    }

}

/// <summary>
/// Block type for accelerators in GoogleDataprocClusterClusterConfigBlockMasterConfigBlock.
/// Nesting mode: set
/// </summary>
public class GoogleDataprocClusterClusterConfigBlockMasterConfigBlockAcceleratorsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "accelerators";

    /// <summary>
    /// The number of the accelerator cards of this type exposed to this instance. Often restricted to one of 1, 2, 4, or 8.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AcceleratorCount is required")]
    public required TerraformValue<double> AcceleratorCount
    {
        get => GetRequiredArgument<TerraformValue<double>>("accelerator_count");
        set => SetArgument("accelerator_count", value);
    }

    /// <summary>
    /// The short name of the accelerator type to expose to this instance. For example, nvidia-tesla-k80.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AcceleratorType is required")]
    public required TerraformValue<string> AcceleratorType
    {
        get => GetRequiredArgument<TerraformValue<string>>("accelerator_type");
        set => SetArgument("accelerator_type", value);
    }

}

/// <summary>
/// Block type for disk_config in GoogleDataprocClusterClusterConfigBlockMasterConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataprocClusterClusterConfigBlockMasterConfigBlockDiskConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "disk_config";

    /// <summary>
    /// Size of the primary disk attached to each node, specified in GB. The primary disk contains the boot volume and system libraries, and the smallest allowed disk size is 10GB. GCP will default to a predetermined computed value if not set (currently 500GB). Note: If SSDs are not attached, it also contains the HDFS data blocks and Hadoop working directories.
    /// </summary>
    public TerraformValue<double> BootDiskSizeGb
    {
        get => GetArgument<TerraformValue<double>>("boot_disk_size_gb") ?? CreateReference("boot_disk_size_gb");
        set => SetArgument("boot_disk_size_gb", value);
    }

    /// <summary>
    /// The disk type of the primary disk attached to each node. Such as &amp;quot;pd-ssd&amp;quot; or &amp;quot;pd-standard&amp;quot;. Defaults to &amp;quot;pd-standard&amp;quot;.
    /// </summary>
    public TerraformValue<string>? BootDiskType
    {
        get => GetArgument<TerraformValue<string>>("boot_disk_type");
        set => SetArgument("boot_disk_type", value);
    }

    /// <summary>
    /// Interface type of local SSDs (default is &amp;quot;scsi&amp;quot;). Valid values: &amp;quot;scsi&amp;quot; (Small Computer System Interface), &amp;quot;nvme&amp;quot; (Non-Volatile Memory Express).
    /// </summary>
    public TerraformValue<string>? LocalSsdInterface
    {
        get => GetArgument<TerraformValue<string>>("local_ssd_interface");
        set => SetArgument("local_ssd_interface", value);
    }

    /// <summary>
    /// The amount of local SSD disks that will be attached to each master cluster node. Defaults to 0.
    /// </summary>
    public TerraformValue<double> NumLocalSsds
    {
        get => GetArgument<TerraformValue<double>>("num_local_ssds") ?? CreateReference("num_local_ssds");
        set => SetArgument("num_local_ssds", value);
    }

}

/// <summary>
/// Block type for metastore_config in GoogleDataprocClusterClusterConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataprocClusterClusterConfigBlockMetastoreConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "metastore_config";

    /// <summary>
    /// Resource name of an existing Dataproc Metastore service.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataprocMetastoreService is required")]
    public required TerraformValue<string> DataprocMetastoreService
    {
        get => GetRequiredArgument<TerraformValue<string>>("dataproc_metastore_service");
        set => SetArgument("dataproc_metastore_service", value);
    }

}

/// <summary>
/// Block type for preemptible_worker_config in GoogleDataprocClusterClusterConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataprocClusterClusterConfigBlockPreemptibleWorkerConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "preemptible_worker_config";

    /// <summary>
    /// List of preemptible instance names which have been assigned to the cluster.
    /// </summary>
    public TerraformList<string> InstanceNames
        => CreateReference("instance_names");

    /// <summary>
    /// Specifies the number of preemptible nodes to create. Defaults to 0.
    /// </summary>
    public TerraformValue<double> NumInstances
    {
        get => GetArgument<TerraformValue<double>>("num_instances") ?? CreateReference("num_instances");
        set => SetArgument("num_instances", value);
    }

    /// <summary>
    /// Specifies the preemptibility of the secondary nodes. Defaults to PREEMPTIBLE.
    /// </summary>
    public TerraformValue<string>? Preemptibility
    {
        get => GetArgument<TerraformValue<string>>("preemptibility");
        set => SetArgument("preemptibility", value);
    }

    /// <summary>
    /// DiskConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DiskConfig block(s) allowed")]
    public TerraformList<GoogleDataprocClusterClusterConfigBlockPreemptibleWorkerConfigBlockDiskConfigBlock>? DiskConfig
    {
        get => GetArgument<TerraformList<GoogleDataprocClusterClusterConfigBlockPreemptibleWorkerConfigBlockDiskConfigBlock>>("disk_config");
        set => SetArgument("disk_config", value);
    }

    /// <summary>
    /// InstanceFlexibilityPolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InstanceFlexibilityPolicy block(s) allowed")]
    public TerraformList<GoogleDataprocClusterClusterConfigBlockPreemptibleWorkerConfigBlockInstanceFlexibilityPolicyBlock>? InstanceFlexibilityPolicy
    {
        get => GetArgument<TerraformList<GoogleDataprocClusterClusterConfigBlockPreemptibleWorkerConfigBlockInstanceFlexibilityPolicyBlock>>("instance_flexibility_policy");
        set => SetArgument("instance_flexibility_policy", value);
    }

}

/// <summary>
/// Block type for disk_config in GoogleDataprocClusterClusterConfigBlockPreemptibleWorkerConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataprocClusterClusterConfigBlockPreemptibleWorkerConfigBlockDiskConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "disk_config";

    /// <summary>
    /// Size of the primary disk attached to each preemptible worker node, specified in GB. The smallest allowed disk size is 10GB. GCP will default to a predetermined computed value if not set (currently 500GB). Note: If SSDs are not attached, it also contains the HDFS data blocks and Hadoop working directories.
    /// </summary>
    public TerraformValue<double> BootDiskSizeGb
    {
        get => GetArgument<TerraformValue<double>>("boot_disk_size_gb") ?? CreateReference("boot_disk_size_gb");
        set => SetArgument("boot_disk_size_gb", value);
    }

    /// <summary>
    /// The disk type of the primary disk attached to each preemptible worker node. Such as &amp;quot;pd-ssd&amp;quot; or &amp;quot;pd-standard&amp;quot;. Defaults to &amp;quot;pd-standard&amp;quot;.
    /// </summary>
    public TerraformValue<string>? BootDiskType
    {
        get => GetArgument<TerraformValue<string>>("boot_disk_type");
        set => SetArgument("boot_disk_type", value);
    }

    /// <summary>
    /// Interface type of local SSDs (default is &amp;quot;scsi&amp;quot;). Valid values: &amp;quot;scsi&amp;quot; (Small Computer System Interface), &amp;quot;nvme&amp;quot; (Non-Volatile Memory Express).
    /// </summary>
    public TerraformValue<string>? LocalSsdInterface
    {
        get => GetArgument<TerraformValue<string>>("local_ssd_interface");
        set => SetArgument("local_ssd_interface", value);
    }

    /// <summary>
    /// The amount of local SSD disks that will be attached to each preemptible worker node. Defaults to 0.
    /// </summary>
    public TerraformValue<double> NumLocalSsds
    {
        get => GetArgument<TerraformValue<double>>("num_local_ssds") ?? CreateReference("num_local_ssds");
        set => SetArgument("num_local_ssds", value);
    }

}

/// <summary>
/// Block type for instance_flexibility_policy in GoogleDataprocClusterClusterConfigBlockPreemptibleWorkerConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataprocClusterClusterConfigBlockPreemptibleWorkerConfigBlockInstanceFlexibilityPolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "instance_flexibility_policy";

    /// <summary>
    /// A list of instance selection results in the group.
    /// </summary>
    public TerraformList<TerraformMap<object>> InstanceSelectionResults
        => CreateReference("instance_selection_results");

    /// <summary>
    /// InstanceSelectionList block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleDataprocClusterClusterConfigBlockPreemptibleWorkerConfigBlockInstanceFlexibilityPolicyBlockInstanceSelectionListBlock>? InstanceSelectionList
    {
        get => GetArgument<TerraformList<GoogleDataprocClusterClusterConfigBlockPreemptibleWorkerConfigBlockInstanceFlexibilityPolicyBlockInstanceSelectionListBlock>>("instance_selection_list");
        set => SetArgument("instance_selection_list", value);
    }

    /// <summary>
    /// ProvisioningModelMix block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ProvisioningModelMix block(s) allowed")]
    public TerraformList<GoogleDataprocClusterClusterConfigBlockPreemptibleWorkerConfigBlockInstanceFlexibilityPolicyBlockProvisioningModelMixBlock>? ProvisioningModelMix
    {
        get => GetArgument<TerraformList<GoogleDataprocClusterClusterConfigBlockPreemptibleWorkerConfigBlockInstanceFlexibilityPolicyBlockProvisioningModelMixBlock>>("provisioning_model_mix");
        set => SetArgument("provisioning_model_mix", value);
    }

}

/// <summary>
/// Block type for instance_selection_list in GoogleDataprocClusterClusterConfigBlockPreemptibleWorkerConfigBlockInstanceFlexibilityPolicyBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataprocClusterClusterConfigBlockPreemptibleWorkerConfigBlockInstanceFlexibilityPolicyBlockInstanceSelectionListBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "instance_selection_list";

    /// <summary>
    /// Full machine-type names, e.g. &amp;quot;n1-standard-16&amp;quot;.
    /// </summary>
    public TerraformList<string> MachineTypes
    {
        get => GetArgument<TerraformList<string>>("machine_types") ?? CreateReference("machine_types");
        set => SetArgument("machine_types", value);
    }

    /// <summary>
    /// Preference of this instance selection. Lower number means higher preference. Dataproc will first try to create a VM based on the machine-type with priority rank and fallback to next rank based on availability. Machine types and instance selections with the same priority have the same preference.
    /// </summary>
    public TerraformValue<double> Rank
    {
        get => GetArgument<TerraformValue<double>>("rank") ?? CreateReference("rank");
        set => SetArgument("rank", value);
    }

}

/// <summary>
/// Block type for provisioning_model_mix in GoogleDataprocClusterClusterConfigBlockPreemptibleWorkerConfigBlockInstanceFlexibilityPolicyBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataprocClusterClusterConfigBlockPreemptibleWorkerConfigBlockInstanceFlexibilityPolicyBlockProvisioningModelMixBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "provisioning_model_mix";

    /// <summary>
    /// The base capacity that will always use Standard VMs to avoid risk of more preemption than the minimum capacity you need.
    /// </summary>
    public TerraformValue<double>? StandardCapacityBase
    {
        get => GetArgument<TerraformValue<double>>("standard_capacity_base");
        set => SetArgument("standard_capacity_base", value);
    }

    /// <summary>
    /// The percentage of target capacity that should use Standard VM. The remaining percentage will use Spot VMs.
    /// </summary>
    public TerraformValue<double>? StandardCapacityPercentAboveBase
    {
        get => GetArgument<TerraformValue<double>>("standard_capacity_percent_above_base");
        set => SetArgument("standard_capacity_percent_above_base", value);
    }

}

/// <summary>
/// Block type for security_config in GoogleDataprocClusterClusterConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataprocClusterClusterConfigBlockSecurityConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "security_config";

    /// <summary>
    /// IdentityConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IdentityConfig block(s) allowed")]
    public TerraformList<GoogleDataprocClusterClusterConfigBlockSecurityConfigBlockIdentityConfigBlock>? IdentityConfig
    {
        get => GetArgument<TerraformList<GoogleDataprocClusterClusterConfigBlockSecurityConfigBlockIdentityConfigBlock>>("identity_config");
        set => SetArgument("identity_config", value);
    }

    /// <summary>
    /// KerberosConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KerberosConfig block(s) allowed")]
    public TerraformList<GoogleDataprocClusterClusterConfigBlockSecurityConfigBlockKerberosConfigBlock>? KerberosConfig
    {
        get => GetArgument<TerraformList<GoogleDataprocClusterClusterConfigBlockSecurityConfigBlockKerberosConfigBlock>>("kerberos_config");
        set => SetArgument("kerberos_config", value);
    }

}

/// <summary>
/// Block type for identity_config in GoogleDataprocClusterClusterConfigBlockSecurityConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataprocClusterClusterConfigBlockSecurityConfigBlockIdentityConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "identity_config";

    /// <summary>
    /// User to service account mappings for multi-tenancy.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserServiceAccountMapping is required")]
    public required TerraformMap<string> UserServiceAccountMapping
    {
        get => GetRequiredArgument<TerraformMap<string>>("user_service_account_mapping");
        set => SetArgument("user_service_account_mapping", value);
    }

}

/// <summary>
/// Block type for kerberos_config in GoogleDataprocClusterClusterConfigBlockSecurityConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataprocClusterClusterConfigBlockSecurityConfigBlockKerberosConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "kerberos_config";

    /// <summary>
    /// The admin server (IP or hostname) for the remote trusted realm in a cross realm trust relationship.
    /// </summary>
    public TerraformValue<string>? CrossRealmTrustAdminServer
    {
        get => GetArgument<TerraformValue<string>>("cross_realm_trust_admin_server");
        set => SetArgument("cross_realm_trust_admin_server", value);
    }

    /// <summary>
    /// The KDC (IP or hostname) for the remote trusted realm in a cross realm trust relationship.
    /// </summary>
    public TerraformValue<string>? CrossRealmTrustKdc
    {
        get => GetArgument<TerraformValue<string>>("cross_realm_trust_kdc");
        set => SetArgument("cross_realm_trust_kdc", value);
    }

    /// <summary>
    /// The remote realm the Dataproc on-cluster KDC will trust, should the user enable cross realm trust.
    /// </summary>
    public TerraformValue<string>? CrossRealmTrustRealm
    {
        get => GetArgument<TerraformValue<string>>("cross_realm_trust_realm");
        set => SetArgument("cross_realm_trust_realm", value);
    }

    /// <summary>
    /// The Cloud Storage URI of a KMS encrypted file containing the shared password between the on-cluster
    /// Kerberos realm and the remote trusted realm, in a cross realm trust relationship.
    /// </summary>
    public TerraformValue<string>? CrossRealmTrustSharedPasswordUri
    {
        get => GetArgument<TerraformValue<string>>("cross_realm_trust_shared_password_uri");
        set => SetArgument("cross_realm_trust_shared_password_uri", value);
    }

    /// <summary>
    /// Flag to indicate whether to Kerberize the cluster.
    /// </summary>
    public TerraformValue<bool>? EnableKerberos
    {
        get => GetArgument<TerraformValue<bool>>("enable_kerberos");
        set => SetArgument("enable_kerberos", value);
    }

    /// <summary>
    /// The Cloud Storage URI of a KMS encrypted file containing the master key of the KDC database.
    /// </summary>
    public TerraformValue<string>? KdcDbKeyUri
    {
        get => GetArgument<TerraformValue<string>>("kdc_db_key_uri");
        set => SetArgument("kdc_db_key_uri", value);
    }

    /// <summary>
    /// The Cloud Storage URI of a KMS encrypted file containing the password to the user provided key. For the self-signed certificate, this password is generated by Dataproc.
    /// </summary>
    public TerraformValue<string>? KeyPasswordUri
    {
        get => GetArgument<TerraformValue<string>>("key_password_uri");
        set => SetArgument("key_password_uri", value);
    }

    /// <summary>
    /// The Cloud Storage URI of a KMS encrypted file containing
    /// the password to the user provided keystore. For the self-signed certificate, this password is generated
    /// by Dataproc
    /// </summary>
    public TerraformValue<string>? KeystorePasswordUri
    {
        get => GetArgument<TerraformValue<string>>("keystore_password_uri");
        set => SetArgument("keystore_password_uri", value);
    }

    /// <summary>
    /// The Cloud Storage URI of the keystore file used for SSL encryption. If not provided, Dataproc will provide a self-signed certificate.
    /// </summary>
    public TerraformValue<string>? KeystoreUri
    {
        get => GetArgument<TerraformValue<string>>("keystore_uri");
        set => SetArgument("keystore_uri", value);
    }

    /// <summary>
    /// The uri of the KMS key used to encrypt various sensitive files.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KmsKeyUri is required")]
    public required TerraformValue<string> KmsKeyUri
    {
        get => GetRequiredArgument<TerraformValue<string>>("kms_key_uri");
        set => SetArgument("kms_key_uri", value);
    }

    /// <summary>
    /// The name of the on-cluster Kerberos realm. If not specified, the uppercased domain of hostnames will be the realm.
    /// </summary>
    public TerraformValue<string>? Realm
    {
        get => GetArgument<TerraformValue<string>>("realm");
        set => SetArgument("realm", value);
    }

    /// <summary>
    /// The cloud Storage URI of a KMS encrypted file containing the root principal password.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RootPrincipalPasswordUri is required")]
    public required TerraformValue<string> RootPrincipalPasswordUri
    {
        get => GetRequiredArgument<TerraformValue<string>>("root_principal_password_uri");
        set => SetArgument("root_principal_password_uri", value);
    }

    /// <summary>
    /// The lifetime of the ticket granting ticket, in hours.
    /// </summary>
    public TerraformValue<double>? TgtLifetimeHours
    {
        get => GetArgument<TerraformValue<double>>("tgt_lifetime_hours");
        set => SetArgument("tgt_lifetime_hours", value);
    }

    /// <summary>
    /// The Cloud Storage URI of a KMS encrypted file containing the password to the user provided truststore. For the self-signed certificate, this password is generated by Dataproc.
    /// </summary>
    public TerraformValue<string>? TruststorePasswordUri
    {
        get => GetArgument<TerraformValue<string>>("truststore_password_uri");
        set => SetArgument("truststore_password_uri", value);
    }

    /// <summary>
    /// The Cloud Storage URI of the truststore file used for SSL encryption. If not provided, Dataproc will provide a self-signed certificate.
    /// </summary>
    public TerraformValue<string>? TruststoreUri
    {
        get => GetArgument<TerraformValue<string>>("truststore_uri");
        set => SetArgument("truststore_uri", value);
    }

}

/// <summary>
/// Block type for software_config in GoogleDataprocClusterClusterConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataprocClusterClusterConfigBlockSoftwareConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "software_config";

    /// <summary>
    /// The Cloud Dataproc image version to use for the cluster - this controls the sets of software versions installed onto the nodes when you create clusters. If not specified, defaults to the latest version.
    /// </summary>
    public TerraformValue<string> ImageVersion
    {
        get => GetArgument<TerraformValue<string>>("image_version") ?? CreateReference("image_version");
        set => SetArgument("image_version", value);
    }

    /// <summary>
    /// The set of optional components to activate on the cluster.
    /// </summary>
    public TerraformSet<string>? OptionalComponents
    {
        get => GetArgument<TerraformSet<string>>("optional_components");
        set => SetArgument("optional_components", value);
    }

    /// <summary>
    /// A list of override and additional properties (key/value pairs) used to modify various aspects of the common configuration files used when creating a cluster.
    /// </summary>
    public TerraformMap<string>? OverrideProperties
    {
        get => GetArgument<TerraformMap<string>>("override_properties");
        set => SetArgument("override_properties", value);
    }

    /// <summary>
    /// A list of the properties used to set the daemon config files. This will include any values supplied by the user via cluster_config.software_config.override_properties
    /// </summary>
    public TerraformMap<string> Properties
        => CreateReference("properties");

}

/// <summary>
/// Block type for worker_config in GoogleDataprocClusterClusterConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataprocClusterClusterConfigBlockWorkerConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "worker_config";

    /// <summary>
    /// The URI for the image to use for this master/worker
    /// </summary>
    public TerraformValue<string> ImageUri
    {
        get => GetArgument<TerraformValue<string>>("image_uri") ?? CreateReference("image_uri");
        set => SetArgument("image_uri", value);
    }

    /// <summary>
    /// List of master/worker instance names which have been assigned to the cluster.
    /// </summary>
    public TerraformList<string> InstanceNames
        => CreateReference("instance_names");

    /// <summary>
    /// The name of a Google Compute Engine machine type to create for the master/worker
    /// </summary>
    public TerraformValue<string> MachineType
    {
        get => GetArgument<TerraformValue<string>>("machine_type") ?? CreateReference("machine_type");
        set => SetArgument("machine_type", value);
    }

    /// <summary>
    /// The name of a minimum generation of CPU family for the master/worker. If not specified, GCP will default to a predetermined computed value for each zone.
    /// </summary>
    public TerraformValue<string> MinCpuPlatform
    {
        get => GetArgument<TerraformValue<string>>("min_cpu_platform") ?? CreateReference("min_cpu_platform");
        set => SetArgument("min_cpu_platform", value);
    }

    /// <summary>
    /// The minimum number of primary worker instances to create.
    /// </summary>
    public TerraformValue<double> MinNumInstances
    {
        get => GetArgument<TerraformValue<double>>("min_num_instances") ?? CreateReference("min_num_instances");
        set => SetArgument("min_num_instances", value);
    }

    /// <summary>
    /// Specifies the number of worker nodes to create. If not specified, GCP will default to a predetermined computed value.
    /// </summary>
    public TerraformValue<double> NumInstances
    {
        get => GetArgument<TerraformValue<double>>("num_instances") ?? CreateReference("num_instances");
        set => SetArgument("num_instances", value);
    }

    /// <summary>
    /// Accelerators block (nesting mode: set).
    /// </summary>
    public TerraformSet<GoogleDataprocClusterClusterConfigBlockWorkerConfigBlockAcceleratorsBlock>? Accelerators
    {
        get => GetArgument<TerraformSet<GoogleDataprocClusterClusterConfigBlockWorkerConfigBlockAcceleratorsBlock>>("accelerators");
        set => SetArgument("accelerators", value);
    }

    /// <summary>
    /// DiskConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DiskConfig block(s) allowed")]
    public TerraformList<GoogleDataprocClusterClusterConfigBlockWorkerConfigBlockDiskConfigBlock>? DiskConfig
    {
        get => GetArgument<TerraformList<GoogleDataprocClusterClusterConfigBlockWorkerConfigBlockDiskConfigBlock>>("disk_config");
        set => SetArgument("disk_config", value);
    }

}

/// <summary>
/// Block type for accelerators in GoogleDataprocClusterClusterConfigBlockWorkerConfigBlock.
/// Nesting mode: set
/// </summary>
public class GoogleDataprocClusterClusterConfigBlockWorkerConfigBlockAcceleratorsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "accelerators";

    /// <summary>
    /// The number of the accelerator cards of this type exposed to this instance. Often restricted to one of 1, 2, 4, or 8.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AcceleratorCount is required")]
    public required TerraformValue<double> AcceleratorCount
    {
        get => GetRequiredArgument<TerraformValue<double>>("accelerator_count");
        set => SetArgument("accelerator_count", value);
    }

    /// <summary>
    /// The short name of the accelerator type to expose to this instance. For example, nvidia-tesla-k80.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AcceleratorType is required")]
    public required TerraformValue<string> AcceleratorType
    {
        get => GetRequiredArgument<TerraformValue<string>>("accelerator_type");
        set => SetArgument("accelerator_type", value);
    }

}

/// <summary>
/// Block type for disk_config in GoogleDataprocClusterClusterConfigBlockWorkerConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataprocClusterClusterConfigBlockWorkerConfigBlockDiskConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "disk_config";

    /// <summary>
    /// Size of the primary disk attached to each node, specified in GB. The primary disk contains the boot volume and system libraries, and the smallest allowed disk size is 10GB. GCP will default to a predetermined computed value if not set (currently 500GB). Note: If SSDs are not attached, it also contains the HDFS data blocks and Hadoop working directories.
    /// </summary>
    public TerraformValue<double> BootDiskSizeGb
    {
        get => GetArgument<TerraformValue<double>>("boot_disk_size_gb") ?? CreateReference("boot_disk_size_gb");
        set => SetArgument("boot_disk_size_gb", value);
    }

    /// <summary>
    /// The disk type of the primary disk attached to each node. Such as &amp;quot;pd-ssd&amp;quot; or &amp;quot;pd-standard&amp;quot;. Defaults to &amp;quot;pd-standard&amp;quot;.
    /// </summary>
    public TerraformValue<string>? BootDiskType
    {
        get => GetArgument<TerraformValue<string>>("boot_disk_type");
        set => SetArgument("boot_disk_type", value);
    }

    /// <summary>
    /// Interface type of local SSDs (default is &amp;quot;scsi&amp;quot;). Valid values: &amp;quot;scsi&amp;quot; (Small Computer System Interface), &amp;quot;nvme&amp;quot; (Non-Volatile Memory Express).
    /// </summary>
    public TerraformValue<string>? LocalSsdInterface
    {
        get => GetArgument<TerraformValue<string>>("local_ssd_interface");
        set => SetArgument("local_ssd_interface", value);
    }

    /// <summary>
    /// The amount of local SSD disks that will be attached to each master cluster node. Defaults to 0.
    /// </summary>
    public TerraformValue<double> NumLocalSsds
    {
        get => GetArgument<TerraformValue<double>>("num_local_ssds") ?? CreateReference("num_local_ssds");
        set => SetArgument("num_local_ssds", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleDataprocCluster.
/// Nesting mode: single
/// </summary>
public class GoogleDataprocClusterTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Block type for virtual_cluster_config in GoogleDataprocCluster.
/// Nesting mode: list
/// </summary>
public class GoogleDataprocClusterVirtualClusterConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "virtual_cluster_config";

    /// <summary>
    /// A Cloud Storage bucket used to stage job dependencies, config files, and job driver console output. If you do not specify a staging bucket, Cloud Dataproc will determine a Cloud Storage location (US, ASIA, or EU) for your cluster&#39;s staging bucket according to the Compute Engine zone where your cluster is deployed, and then create and manage this project-level, per-location bucket.
    /// </summary>
    public TerraformValue<string>? StagingBucket
    {
        get => GetArgument<TerraformValue<string>>("staging_bucket");
        set => SetArgument("staging_bucket", value);
    }

    /// <summary>
    /// AuxiliaryServicesConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AuxiliaryServicesConfig block(s) allowed")]
    public TerraformList<GoogleDataprocClusterVirtualClusterConfigBlockAuxiliaryServicesConfigBlock>? AuxiliaryServicesConfig
    {
        get => GetArgument<TerraformList<GoogleDataprocClusterVirtualClusterConfigBlockAuxiliaryServicesConfigBlock>>("auxiliary_services_config");
        set => SetArgument("auxiliary_services_config", value);
    }

    /// <summary>
    /// KubernetesClusterConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KubernetesClusterConfig block(s) allowed")]
    public TerraformList<GoogleDataprocClusterVirtualClusterConfigBlockKubernetesClusterConfigBlock>? KubernetesClusterConfig
    {
        get => GetArgument<TerraformList<GoogleDataprocClusterVirtualClusterConfigBlockKubernetesClusterConfigBlock>>("kubernetes_cluster_config");
        set => SetArgument("kubernetes_cluster_config", value);
    }

}

/// <summary>
/// Block type for auxiliary_services_config in GoogleDataprocClusterVirtualClusterConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataprocClusterVirtualClusterConfigBlockAuxiliaryServicesConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "auxiliary_services_config";

    /// <summary>
    /// MetastoreConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MetastoreConfig block(s) allowed")]
    public TerraformList<GoogleDataprocClusterVirtualClusterConfigBlockAuxiliaryServicesConfigBlockMetastoreConfigBlock>? MetastoreConfig
    {
        get => GetArgument<TerraformList<GoogleDataprocClusterVirtualClusterConfigBlockAuxiliaryServicesConfigBlockMetastoreConfigBlock>>("metastore_config");
        set => SetArgument("metastore_config", value);
    }

    /// <summary>
    /// SparkHistoryServerConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SparkHistoryServerConfig block(s) allowed")]
    public TerraformList<GoogleDataprocClusterVirtualClusterConfigBlockAuxiliaryServicesConfigBlockSparkHistoryServerConfigBlock>? SparkHistoryServerConfig
    {
        get => GetArgument<TerraformList<GoogleDataprocClusterVirtualClusterConfigBlockAuxiliaryServicesConfigBlockSparkHistoryServerConfigBlock>>("spark_history_server_config");
        set => SetArgument("spark_history_server_config", value);
    }

}

/// <summary>
/// Block type for metastore_config in GoogleDataprocClusterVirtualClusterConfigBlockAuxiliaryServicesConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataprocClusterVirtualClusterConfigBlockAuxiliaryServicesConfigBlockMetastoreConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "metastore_config";

    /// <summary>
    /// The Hive Metastore configuration for this workload.
    /// </summary>
    public TerraformValue<string>? DataprocMetastoreService
    {
        get => GetArgument<TerraformValue<string>>("dataproc_metastore_service");
        set => SetArgument("dataproc_metastore_service", value);
    }

}

/// <summary>
/// Block type for spark_history_server_config in GoogleDataprocClusterVirtualClusterConfigBlockAuxiliaryServicesConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataprocClusterVirtualClusterConfigBlockAuxiliaryServicesConfigBlockSparkHistoryServerConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "spark_history_server_config";

    /// <summary>
    /// Resource name of an existing Dataproc Cluster to act as a Spark History Server for the workload.
    /// </summary>
    public TerraformValue<string>? DataprocCluster
    {
        get => GetArgument<TerraformValue<string>>("dataproc_cluster");
        set => SetArgument("dataproc_cluster", value);
    }

}

/// <summary>
/// Block type for kubernetes_cluster_config in GoogleDataprocClusterVirtualClusterConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataprocClusterVirtualClusterConfigBlockKubernetesClusterConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "kubernetes_cluster_config";

    /// <summary>
    /// A namespace within the Kubernetes cluster to deploy into. If this namespace does not exist, it is created. If it exists, Dataproc verifies that another Dataproc VirtualCluster is not installed into it. If not specified, the name of the Dataproc Cluster is used.
    /// </summary>
    public TerraformValue<string>? KubernetesNamespace
    {
        get => GetArgument<TerraformValue<string>>("kubernetes_namespace");
        set => SetArgument("kubernetes_namespace", value);
    }

    /// <summary>
    /// GkeClusterConfig block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GkeClusterConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 GkeClusterConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GkeClusterConfig block(s) allowed")]
    public required TerraformList<GoogleDataprocClusterVirtualClusterConfigBlockKubernetesClusterConfigBlockGkeClusterConfigBlock> GkeClusterConfig
    {
        get => GetRequiredArgument<TerraformList<GoogleDataprocClusterVirtualClusterConfigBlockKubernetesClusterConfigBlockGkeClusterConfigBlock>>("gke_cluster_config");
        set => SetArgument("gke_cluster_config", value);
    }

    /// <summary>
    /// KubernetesSoftwareConfig block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KubernetesSoftwareConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 KubernetesSoftwareConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KubernetesSoftwareConfig block(s) allowed")]
    public required TerraformList<GoogleDataprocClusterVirtualClusterConfigBlockKubernetesClusterConfigBlockKubernetesSoftwareConfigBlock> KubernetesSoftwareConfig
    {
        get => GetRequiredArgument<TerraformList<GoogleDataprocClusterVirtualClusterConfigBlockKubernetesClusterConfigBlockKubernetesSoftwareConfigBlock>>("kubernetes_software_config");
        set => SetArgument("kubernetes_software_config", value);
    }

}

/// <summary>
/// Block type for gke_cluster_config in GoogleDataprocClusterVirtualClusterConfigBlockKubernetesClusterConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataprocClusterVirtualClusterConfigBlockKubernetesClusterConfigBlockGkeClusterConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "gke_cluster_config";

    /// <summary>
    /// A target GKE cluster to deploy to. It must be in the same project and region as the Dataproc cluster (the GKE cluster can be zonal or regional). Format: &#39;projects/{project}/locations/{location}/clusters/{cluster_id}&#39;
    /// </summary>
    public TerraformValue<string>? GkeClusterTarget
    {
        get => GetArgument<TerraformValue<string>>("gke_cluster_target");
        set => SetArgument("gke_cluster_target", value);
    }

    /// <summary>
    /// NodePoolTarget block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleDataprocClusterVirtualClusterConfigBlockKubernetesClusterConfigBlockGkeClusterConfigBlockNodePoolTargetBlock>? NodePoolTarget
    {
        get => GetArgument<TerraformList<GoogleDataprocClusterVirtualClusterConfigBlockKubernetesClusterConfigBlockGkeClusterConfigBlockNodePoolTargetBlock>>("node_pool_target");
        set => SetArgument("node_pool_target", value);
    }

}

/// <summary>
/// Block type for node_pool_target in GoogleDataprocClusterVirtualClusterConfigBlockKubernetesClusterConfigBlockGkeClusterConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataprocClusterVirtualClusterConfigBlockKubernetesClusterConfigBlockGkeClusterConfigBlockNodePoolTargetBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "node_pool_target";

    /// <summary>
    /// The target GKE node pool. Format: &#39;projects/{project}/locations/{location}/clusters/{cluster}/nodePools/{nodePool}&#39;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NodePool is required")]
    public required TerraformValue<string> NodePool
    {
        get => GetRequiredArgument<TerraformValue<string>>("node_pool");
        set => SetArgument("node_pool", value);
    }

    /// <summary>
    /// The roles associated with the GKE node pool.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Roles is required")]
    public required TerraformSet<string> Roles
    {
        get => GetRequiredArgument<TerraformSet<string>>("roles");
        set => SetArgument("roles", value);
    }

    /// <summary>
    /// NodePoolConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NodePoolConfig block(s) allowed")]
    public TerraformList<GoogleDataprocClusterVirtualClusterConfigBlockKubernetesClusterConfigBlockGkeClusterConfigBlockNodePoolTargetBlockNodePoolConfigBlock>? NodePoolConfig
    {
        get => GetArgument<TerraformList<GoogleDataprocClusterVirtualClusterConfigBlockKubernetesClusterConfigBlockGkeClusterConfigBlockNodePoolTargetBlockNodePoolConfigBlock>>("node_pool_config");
        set => SetArgument("node_pool_config", value);
    }

}

/// <summary>
/// Block type for node_pool_config in GoogleDataprocClusterVirtualClusterConfigBlockKubernetesClusterConfigBlockGkeClusterConfigBlockNodePoolTargetBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataprocClusterVirtualClusterConfigBlockKubernetesClusterConfigBlockGkeClusterConfigBlockNodePoolTargetBlockNodePoolConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "node_pool_config";

    /// <summary>
    /// The list of Compute Engine zones where node pool nodes associated with a Dataproc on GKE virtual cluster will be located.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Locations is required")]
    public required TerraformSet<string> Locations
    {
        get => GetRequiredArgument<TerraformSet<string>>("locations");
        set => SetArgument("locations", value);
    }

    /// <summary>
    /// Autoscaling block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Autoscaling block(s) allowed")]
    public TerraformList<GoogleDataprocClusterVirtualClusterConfigBlockKubernetesClusterConfigBlockGkeClusterConfigBlockNodePoolTargetBlockNodePoolConfigBlockAutoscalingBlock>? Autoscaling
    {
        get => GetArgument<TerraformList<GoogleDataprocClusterVirtualClusterConfigBlockKubernetesClusterConfigBlockGkeClusterConfigBlockNodePoolTargetBlockNodePoolConfigBlockAutoscalingBlock>>("autoscaling");
        set => SetArgument("autoscaling", value);
    }

    /// <summary>
    /// Config block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Config block(s) allowed")]
    public TerraformList<GoogleDataprocClusterVirtualClusterConfigBlockKubernetesClusterConfigBlockGkeClusterConfigBlockNodePoolTargetBlockNodePoolConfigBlockConfigBlock>? Config
    {
        get => GetArgument<TerraformList<GoogleDataprocClusterVirtualClusterConfigBlockKubernetesClusterConfigBlockGkeClusterConfigBlockNodePoolTargetBlockNodePoolConfigBlockConfigBlock>>("config");
        set => SetArgument("config", value);
    }

}

/// <summary>
/// Block type for autoscaling in GoogleDataprocClusterVirtualClusterConfigBlockKubernetesClusterConfigBlockGkeClusterConfigBlockNodePoolTargetBlockNodePoolConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataprocClusterVirtualClusterConfigBlockKubernetesClusterConfigBlockGkeClusterConfigBlockNodePoolTargetBlockNodePoolConfigBlockAutoscalingBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "autoscaling";

    /// <summary>
    /// The maximum number of nodes in the node pool. Must be &amp;gt;= minNodeCount, and must be &amp;gt; 0.
    /// </summary>
    public TerraformValue<double>? MaxNodeCount
    {
        get => GetArgument<TerraformValue<double>>("max_node_count");
        set => SetArgument("max_node_count", value);
    }

    /// <summary>
    /// The minimum number of nodes in the node pool. Must be &amp;gt;= 0 and &amp;lt;= maxNodeCount.
    /// </summary>
    public TerraformValue<double>? MinNodeCount
    {
        get => GetArgument<TerraformValue<double>>("min_node_count");
        set => SetArgument("min_node_count", value);
    }

}

/// <summary>
/// Block type for config in GoogleDataprocClusterVirtualClusterConfigBlockKubernetesClusterConfigBlockGkeClusterConfigBlockNodePoolTargetBlockNodePoolConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataprocClusterVirtualClusterConfigBlockKubernetesClusterConfigBlockGkeClusterConfigBlockNodePoolTargetBlockNodePoolConfigBlockConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "config";

    /// <summary>
    /// The minimum number of nodes in the node pool. Must be &amp;gt;= 0 and &amp;lt;= maxNodeCount.
    /// </summary>
    public TerraformValue<double>? LocalSsdCount
    {
        get => GetArgument<TerraformValue<double>>("local_ssd_count");
        set => SetArgument("local_ssd_count", value);
    }

    /// <summary>
    /// The name of a Compute Engine machine type.
    /// </summary>
    public TerraformValue<string>? MachineType
    {
        get => GetArgument<TerraformValue<string>>("machine_type");
        set => SetArgument("machine_type", value);
    }

    /// <summary>
    /// Minimum CPU platform to be used by this instance. The instance may be scheduled on the specified or a newer CPU platform. Specify the friendly names of CPU platforms, such as &amp;quot;Intel Haswell&amp;quot; or &amp;quot;Intel Sandy Bridge&amp;quot;.
    /// </summary>
    public TerraformValue<string>? MinCpuPlatform
    {
        get => GetArgument<TerraformValue<string>>("min_cpu_platform");
        set => SetArgument("min_cpu_platform", value);
    }

    /// <summary>
    /// Whether the nodes are created as preemptible VM instances. Preemptible nodes cannot be used in a node pool with the CONTROLLER role or in the DEFAULT node pool if the CONTROLLER role is not assigned (the DEFAULT node pool will assume the CONTROLLER role).
    /// </summary>
    public TerraformValue<bool>? Preemptible
    {
        get => GetArgument<TerraformValue<bool>>("preemptible");
        set => SetArgument("preemptible", value);
    }

    /// <summary>
    /// Spot flag for enabling Spot VM, which is a rebrand of the existing preemptible flag.
    /// </summary>
    public TerraformValue<bool>? Spot
    {
        get => GetArgument<TerraformValue<bool>>("spot");
        set => SetArgument("spot", value);
    }

}

/// <summary>
/// Block type for kubernetes_software_config in GoogleDataprocClusterVirtualClusterConfigBlockKubernetesClusterConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataprocClusterVirtualClusterConfigBlockKubernetesClusterConfigBlockKubernetesSoftwareConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "kubernetes_software_config";

    /// <summary>
    /// The components that should be installed in this Dataproc cluster. The key must be a string from the KubernetesComponent enumeration. The value is the version of the software to be installed.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ComponentVersion is required")]
    public required TerraformMap<string> ComponentVersion
    {
        get => GetRequiredArgument<TerraformMap<string>>("component_version");
        set => SetArgument("component_version", value);
    }

    /// <summary>
    /// The properties to set on daemon config files. Property keys are specified in prefix:property format, for example spark:spark.kubernetes.container.image.
    /// </summary>
    public TerraformMap<string> Properties
    {
        get => GetArgument<TerraformMap<string>>("properties") ?? CreateReference("properties");
        set => SetArgument("properties", value);
    }

}


/// <summary>
/// Represents a google_dataproc_cluster Terraform resource.
/// Manages a google_dataproc_cluster resource.
/// </summary>
public partial class GoogleDataprocCluster(string name) : TerraformResource("google_dataproc_cluster", name)
{
    /// <summary>
    /// The timeout duration which allows graceful decomissioning when you change the number of worker nodes directly through a terraform apply
    /// </summary>
    public TerraformValue<string>? GracefulDecommissionTimeout
    {
        get => GetArgument<TerraformValue<string>>("graceful_decommission_timeout");
        set => SetArgument("graceful_decommission_timeout", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The list of the labels (key/value pairs) configured on the resource and to be applied to instances in the cluster.
    /// 
    /// 				**Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// 				Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformMap<string>? Labels
    {
        get => GetArgument<TerraformMap<string>>("labels");
        set => SetArgument("labels", value);
    }

    /// <summary>
    /// The name of the cluster, unique within the project and zone.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The ID of the project in which the cluster will exist. If it is not provided, the provider project is used.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => GetArgument<TerraformValue<string>>("project") ?? CreateReference("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The region in which the cluster and associated nodes will be created in. Defaults to global.
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
        => CreateReference("effective_labels");

    /// <summary>
    /// The combination of labels configured directly on the resource and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
        => CreateReference("terraform_labels");

    /// <summary>
    /// ClusterConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ClusterConfig block(s) allowed")]
    public TerraformList<GoogleDataprocClusterClusterConfigBlock>? ClusterConfig
    {
        get => GetArgument<TerraformList<GoogleDataprocClusterClusterConfigBlock>>("cluster_config");
        set => SetArgument("cluster_config", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleDataprocClusterTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleDataprocClusterTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

    /// <summary>
    /// VirtualClusterConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VirtualClusterConfig block(s) allowed")]
    public TerraformList<GoogleDataprocClusterVirtualClusterConfigBlock>? VirtualClusterConfig
    {
        get => GetArgument<TerraformList<GoogleDataprocClusterVirtualClusterConfigBlock>>("virtual_cluster_config");
        set => SetArgument("virtual_cluster_config", value);
    }

}
