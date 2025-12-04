using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for autoscaling in GoogleContainerAwsNodePool.
/// Nesting mode: list
/// </summary>
public class GoogleContainerAwsNodePoolAutoscalingBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "autoscaling";

    /// <summary>
    /// Maximum number of nodes in the NodePool. Must be &amp;gt;= min_node_count.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxNodeCount is required")]
    public required TerraformValue<double> MaxNodeCount
    {
        get => GetRequiredArgument<TerraformValue<double>>("max_node_count");
        set => SetArgument("max_node_count", value);
    }

    /// <summary>
    /// Minimum number of nodes in the NodePool. Must be &amp;gt;= 1 and &amp;lt;= max_node_count.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MinNodeCount is required")]
    public required TerraformValue<double> MinNodeCount
    {
        get => GetRequiredArgument<TerraformValue<double>>("min_node_count");
        set => SetArgument("min_node_count", value);
    }

}


/// <summary>
/// Block type for config in GoogleContainerAwsNodePool.
/// Nesting mode: list
/// </summary>
public class GoogleContainerAwsNodePoolConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "config";

    /// <summary>
    /// The name of the AWS IAM role assigned to nodes in the pool.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IamInstanceProfile is required")]
    public required TerraformValue<string> IamInstanceProfile
    {
        get => GetRequiredArgument<TerraformValue<string>>("iam_instance_profile");
        set => SetArgument("iam_instance_profile", value);
    }

    /// <summary>
    /// Optional. The AWS instance type. When unspecified, it defaults to `m5.large`.
    /// </summary>
    public TerraformValue<string> InstanceType
    {
        get => GetArgument<TerraformValue<string>>("instance_type") ?? AsReference("instance_type");
        set => SetArgument("instance_type", value);
    }

    /// <summary>
    /// Optional. The initial labels assigned to nodes of this node pool. An object containing a list of &amp;quot;key&amp;quot;: value pairs. Example: { &amp;quot;name&amp;quot;: &amp;quot;wrench&amp;quot;, &amp;quot;mass&amp;quot;: &amp;quot;1.3kg&amp;quot;, &amp;quot;count&amp;quot;: &amp;quot;3&amp;quot; }.
    /// </summary>
    public TerraformMap<string>? Labels
    {
        get => GetArgument<TerraformMap<string>>("labels");
        set => SetArgument("labels", value);
    }

    /// <summary>
    /// Optional. The IDs of additional security groups to add to nodes in this pool. The manager will automatically create security groups with minimum rules needed for a functioning cluster.
    /// </summary>
    public TerraformList<string>? SecurityGroupIds
    {
        get => GetArgument<TerraformList<string>>("security_group_ids");
        set => SetArgument("security_group_ids", value);
    }

    /// <summary>
    /// Optional. Key/value metadata to assign to each underlying AWS resource. Specify at most 50 pairs containing alphanumerics, spaces, and symbols (.+-=_:@/). Keys can be up to 127 Unicode characters. Values can be up to 255 Unicode characters.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// AutoscalingMetricsCollection block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutoscalingMetricsCollection block(s) allowed")]
    public TerraformList<GoogleContainerAwsNodePoolConfigBlockAutoscalingMetricsCollectionBlock>? AutoscalingMetricsCollection
    {
        get => GetArgument<TerraformList<GoogleContainerAwsNodePoolConfigBlockAutoscalingMetricsCollectionBlock>>("autoscaling_metrics_collection");
        set => SetArgument("autoscaling_metrics_collection", value);
    }

    /// <summary>
    /// ConfigEncryption block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConfigEncryption is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ConfigEncryption block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ConfigEncryption block(s) allowed")]
    public required TerraformList<GoogleContainerAwsNodePoolConfigBlockConfigEncryptionBlock> ConfigEncryption
    {
        get => GetRequiredArgument<TerraformList<GoogleContainerAwsNodePoolConfigBlockConfigEncryptionBlock>>("config_encryption");
        set => SetArgument("config_encryption", value);
    }

    /// <summary>
    /// ProxyConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ProxyConfig block(s) allowed")]
    public TerraformList<GoogleContainerAwsNodePoolConfigBlockProxyConfigBlock>? ProxyConfig
    {
        get => GetArgument<TerraformList<GoogleContainerAwsNodePoolConfigBlockProxyConfigBlock>>("proxy_config");
        set => SetArgument("proxy_config", value);
    }

    /// <summary>
    /// RootVolume block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RootVolume block(s) allowed")]
    public TerraformList<GoogleContainerAwsNodePoolConfigBlockRootVolumeBlock>? RootVolume
    {
        get => GetArgument<TerraformList<GoogleContainerAwsNodePoolConfigBlockRootVolumeBlock>>("root_volume");
        set => SetArgument("root_volume", value);
    }

    /// <summary>
    /// SshConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SshConfig block(s) allowed")]
    public TerraformList<GoogleContainerAwsNodePoolConfigBlockSshConfigBlock>? SshConfig
    {
        get => GetArgument<TerraformList<GoogleContainerAwsNodePoolConfigBlockSshConfigBlock>>("ssh_config");
        set => SetArgument("ssh_config", value);
    }

    /// <summary>
    /// Taints block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleContainerAwsNodePoolConfigBlockTaintsBlock>? Taints
    {
        get => GetArgument<TerraformList<GoogleContainerAwsNodePoolConfigBlockTaintsBlock>>("taints");
        set => SetArgument("taints", value);
    }

}

/// <summary>
/// Block type for autoscaling_metrics_collection in GoogleContainerAwsNodePoolConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerAwsNodePoolConfigBlockAutoscalingMetricsCollectionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "autoscaling_metrics_collection";

    /// <summary>
    /// The frequency at which EC2 Auto Scaling sends aggregated data to AWS CloudWatch. The only valid value is &amp;quot;1Minute&amp;quot;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Granularity is required")]
    public required TerraformValue<string> Granularity
    {
        get => GetRequiredArgument<TerraformValue<string>>("granularity");
        set => SetArgument("granularity", value);
    }

    /// <summary>
    /// The metrics to enable. For a list of valid metrics, see https://docs.aws.amazon.com/autoscaling/ec2/APIReference/API_EnableMetricsCollection.html. If you specify granularity and don&#39;t specify any metrics, all metrics are enabled.
    /// </summary>
    public TerraformList<string>? Metrics
    {
        get => GetArgument<TerraformList<string>>("metrics");
        set => SetArgument("metrics", value);
    }

}

/// <summary>
/// Block type for config_encryption in GoogleContainerAwsNodePoolConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerAwsNodePoolConfigBlockConfigEncryptionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "config_encryption";

    /// <summary>
    /// The ARN of the AWS KMS key used to encrypt node pool configuration.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KmsKeyArn is required")]
    public required TerraformValue<string> KmsKeyArn
    {
        get => GetRequiredArgument<TerraformValue<string>>("kms_key_arn");
        set => SetArgument("kms_key_arn", value);
    }

}

/// <summary>
/// Block type for proxy_config in GoogleContainerAwsNodePoolConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerAwsNodePoolConfigBlockProxyConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "proxy_config";

    /// <summary>
    /// The ARN of the AWS Secret Manager secret that contains the HTTP(S) proxy configuration.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecretArn is required")]
    public required TerraformValue<string> SecretArn
    {
        get => GetRequiredArgument<TerraformValue<string>>("secret_arn");
        set => SetArgument("secret_arn", value);
    }

    /// <summary>
    /// The version string of the AWS Secret Manager secret that contains the HTTP(S) proxy configuration.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecretVersion is required")]
    public required TerraformValue<string> SecretVersion
    {
        get => GetRequiredArgument<TerraformValue<string>>("secret_version");
        set => SetArgument("secret_version", value);
    }

}

/// <summary>
/// Block type for root_volume in GoogleContainerAwsNodePoolConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerAwsNodePoolConfigBlockRootVolumeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "root_volume";

    /// <summary>
    /// Optional. The number of I/O operations per second (IOPS) to provision for GP3 volume.
    /// </summary>
    public TerraformValue<double> Iops
    {
        get => GetArgument<TerraformValue<double>>("iops") ?? AsReference("iops");
        set => SetArgument("iops", value);
    }

    /// <summary>
    /// Optional. The Amazon Resource Name (ARN) of the Customer Managed Key (CMK) used to encrypt AWS EBS volumes. If not specified, the default Amazon managed key associated to the AWS region where this cluster runs will be used.
    /// </summary>
    public TerraformValue<string>? KmsKeyArn
    {
        get => GetArgument<TerraformValue<string>>("kms_key_arn");
        set => SetArgument("kms_key_arn", value);
    }

    /// <summary>
    /// Optional. The size of the volume, in GiBs. When unspecified, a default value is provided. See the specific reference in the parent resource.
    /// </summary>
    public TerraformValue<double> SizeGib
    {
        get => GetArgument<TerraformValue<double>>("size_gib") ?? AsReference("size_gib");
        set => SetArgument("size_gib", value);
    }

    /// <summary>
    /// Optional. The throughput to provision for the volume, in MiB/s. Only valid if the volume type is GP3. If volume type is gp3 and throughput is not specified, the throughput will defaults to 125.
    /// </summary>
    public TerraformValue<double> Throughput
    {
        get => GetArgument<TerraformValue<double>>("throughput") ?? AsReference("throughput");
        set => SetArgument("throughput", value);
    }

    /// <summary>
    /// Optional. Type of the EBS volume. When unspecified, it defaults to GP2 volume. Possible values: VOLUME_TYPE_UNSPECIFIED, GP2, GP3
    /// </summary>
    public TerraformValue<string> VolumeType
    {
        get => GetArgument<TerraformValue<string>>("volume_type") ?? AsReference("volume_type");
        set => SetArgument("volume_type", value);
    }

}

/// <summary>
/// Block type for ssh_config in GoogleContainerAwsNodePoolConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerAwsNodePoolConfigBlockSshConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ssh_config";

    /// <summary>
    /// The name of the EC2 key pair used to login into cluster machines.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Ec2KeyPair is required")]
    public required TerraformValue<string> Ec2KeyPair
    {
        get => GetRequiredArgument<TerraformValue<string>>("ec2_key_pair");
        set => SetArgument("ec2_key_pair", value);
    }

}

/// <summary>
/// Block type for taints in GoogleContainerAwsNodePoolConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerAwsNodePoolConfigBlockTaintsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "taints";

    /// <summary>
    /// The taint effect. Possible values: EFFECT_UNSPECIFIED, NO_SCHEDULE, PREFER_NO_SCHEDULE, NO_EXECUTE
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Effect is required")]
    public required TerraformValue<string> Effect
    {
        get => GetRequiredArgument<TerraformValue<string>>("effect");
        set => SetArgument("effect", value);
    }

    /// <summary>
    /// Key for the taint.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    public required TerraformValue<string> Key
    {
        get => GetRequiredArgument<TerraformValue<string>>("key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// Value for the taint.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}


/// <summary>
/// Block type for kubelet_config in GoogleContainerAwsNodePool.
/// Nesting mode: list
/// </summary>
public class GoogleContainerAwsNodePoolKubeletConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "kubelet_config";

    /// <summary>
    /// Whether or not to enable CPU CFS quota. Defaults to true.
    /// </summary>
    public TerraformValue<bool> CpuCfsQuota
    {
        get => GetArgument<TerraformValue<bool>>("cpu_cfs_quota") ?? AsReference("cpu_cfs_quota");
        set => SetArgument("cpu_cfs_quota", value);
    }

    /// <summary>
    /// Optional. The CPU CFS quota period to use for the node. Defaults to &amp;quot;100ms&amp;quot;.
    /// </summary>
    public TerraformValue<string>? CpuCfsQuotaPeriod
    {
        get => GetArgument<TerraformValue<string>>("cpu_cfs_quota_period");
        set => SetArgument("cpu_cfs_quota_period", value);
    }

    /// <summary>
    /// The CpuManagerPolicy to use for the node. Defaults to &amp;quot;none&amp;quot;.
    /// </summary>
    public TerraformValue<string> CpuManagerPolicy
    {
        get => GetArgument<TerraformValue<string>>("cpu_manager_policy") ?? AsReference("cpu_manager_policy");
        set => SetArgument("cpu_manager_policy", value);
    }

    /// <summary>
    /// Optional. The maximum number of PIDs in each pod running on the node. The limit scales automatically based on underlying machine size if left unset.
    /// </summary>
    public TerraformValue<double>? PodPidsLimit
    {
        get => GetArgument<TerraformValue<double>>("pod_pids_limit");
        set => SetArgument("pod_pids_limit", value);
    }

}


/// <summary>
/// Block type for management in GoogleContainerAwsNodePool.
/// Nesting mode: list
/// </summary>
public class GoogleContainerAwsNodePoolManagementBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "management";

    /// <summary>
    /// Optional. Whether or not the nodes will be automatically repaired.
    /// </summary>
    public TerraformValue<bool> AutoRepair
    {
        get => GetArgument<TerraformValue<bool>>("auto_repair") ?? AsReference("auto_repair");
        set => SetArgument("auto_repair", value);
    }

}


/// <summary>
/// Block type for max_pods_constraint in GoogleContainerAwsNodePool.
/// Nesting mode: list
/// </summary>
public class GoogleContainerAwsNodePoolMaxPodsConstraintBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "max_pods_constraint";

    /// <summary>
    /// The maximum number of pods to schedule on a single node.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxPodsPerNode is required")]
    public required TerraformValue<double> MaxPodsPerNode
    {
        get => GetRequiredArgument<TerraformValue<double>>("max_pods_per_node");
        set => SetArgument("max_pods_per_node", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleContainerAwsNodePool.
/// Nesting mode: single
/// </summary>
public class GoogleContainerAwsNodePoolTimeoutsBlock : TerraformBlock
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
/// Block type for update_settings in GoogleContainerAwsNodePool.
/// Nesting mode: list
/// </summary>
public class GoogleContainerAwsNodePoolUpdateSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "update_settings";

    /// <summary>
    /// SurgeSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SurgeSettings block(s) allowed")]
    public TerraformList<GoogleContainerAwsNodePoolUpdateSettingsBlockSurgeSettingsBlock>? SurgeSettings
    {
        get => GetArgument<TerraformList<GoogleContainerAwsNodePoolUpdateSettingsBlockSurgeSettingsBlock>>("surge_settings");
        set => SetArgument("surge_settings", value);
    }

}

/// <summary>
/// Block type for surge_settings in GoogleContainerAwsNodePoolUpdateSettingsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerAwsNodePoolUpdateSettingsBlockSurgeSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "surge_settings";

    /// <summary>
    /// Optional. The maximum number of nodes that can be created beyond the current size of the node pool during the update process.
    /// </summary>
    public TerraformValue<double> MaxSurge
    {
        get => GetArgument<TerraformValue<double>>("max_surge") ?? AsReference("max_surge");
        set => SetArgument("max_surge", value);
    }

    /// <summary>
    /// Optional. The maximum number of nodes that can be simultaneously unavailable during the update process. A node is considered unavailable if its status is not Ready.
    /// </summary>
    public TerraformValue<double> MaxUnavailable
    {
        get => GetArgument<TerraformValue<double>>("max_unavailable") ?? AsReference("max_unavailable");
        set => SetArgument("max_unavailable", value);
    }

}


/// <summary>
/// Represents a google_container_aws_node_pool Terraform resource.
/// Manages a google_container_aws_node_pool resource.
/// </summary>
public partial class GoogleContainerAwsNodePool(string name) : TerraformResource("google_container_aws_node_pool", name)
{
    /// <summary>
    /// Optional. Annotations on the node pool. This field has the same restrictions as Kubernetes annotations. The total size of all keys and values combined is limited to 256k. Key can have 2 segments: prefix (optional) and name (required), separated by a slash (/). Prefix must be a DNS subdomain. Name must be 63 characters or less, begin and end with alphanumerics, with dashes (-), underscores (_), dots (.), and alphanumerics between.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the annotations present in your configuration.
    /// Please refer to the field `effective_annotations` for all of the annotations present on the resource.
    /// </summary>
    public TerraformMap<string>? Annotations
    {
        get => GetArgument<TerraformMap<string>>("annotations");
        set => SetArgument("annotations", value);
    }

    /// <summary>
    /// The awsCluster for the resource
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Cluster is required")]
    public required TerraformValue<string> Cluster
    {
        get => GetRequiredArgument<TerraformValue<string>>("cluster");
        set => SetArgument("cluster", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location for the resource
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetRequiredArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The name of this resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The project for the resource
    /// </summary>
    public TerraformValue<string> Project
    {
        get => GetArgument<TerraformValue<string>>("project") ?? AsReference("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The subnet where the node pool node run.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    public required TerraformValue<string> SubnetId
    {
        get => GetRequiredArgument<TerraformValue<string>>("subnet_id");
        set => SetArgument("subnet_id", value);
    }

    /// <summary>
    /// The Kubernetes version to run on this node pool (e.g. `1.19.10-gke.1000`). You can list all supported versions on a given Google Cloud region by calling GetAwsServerConfig.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Version is required")]
    public required TerraformValue<string> Version
    {
        get => GetRequiredArgument<TerraformValue<string>>("version");
        set => SetArgument("version", value);
    }

    /// <summary>
    /// Output only. The time at which this node pool was created.
    /// </summary>
    public TerraformValue<string> CreateTime
        => AsReference("create_time");

    /// <summary>
    /// All of annotations (key/value pairs) present on the resource in GCP, including the annotations configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveAnnotations
        => AsReference("effective_annotations");

    /// <summary>
    /// Allows clients to perform consistent read-modify-writes through optimistic concurrency control. May be sent on update and delete requests to ensure the client has an up-to-date value before proceeding.
    /// </summary>
    public TerraformValue<string> Etag
        => AsReference("etag");

    /// <summary>
    /// Output only. If set, there are currently changes in flight to the node pool.
    /// </summary>
    public TerraformValue<bool> Reconciling
        => AsReference("reconciling");

    /// <summary>
    /// Output only. The lifecycle state of the node pool. Possible values: STATE_UNSPECIFIED, PROVISIONING, RUNNING, RECONCILING, STOPPING, ERROR, DEGRADED
    /// </summary>
    public TerraformValue<string> State
        => AsReference("state");

    /// <summary>
    /// Output only. A globally unique identifier for the node pool.
    /// </summary>
    public TerraformValue<string> Uid
        => AsReference("uid");

    /// <summary>
    /// Output only. The time at which this node pool was last updated.
    /// </summary>
    public TerraformValue<string> UpdateTime
        => AsReference("update_time");

    /// <summary>
    /// Autoscaling block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Autoscaling is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Autoscaling block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Autoscaling block(s) allowed")]
    public required TerraformList<GoogleContainerAwsNodePoolAutoscalingBlock> Autoscaling
    {
        get => GetRequiredArgument<TerraformList<GoogleContainerAwsNodePoolAutoscalingBlock>>("autoscaling");
        set => SetArgument("autoscaling", value);
    }

    /// <summary>
    /// Config block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Config is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Config block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Config block(s) allowed")]
    public required TerraformList<GoogleContainerAwsNodePoolConfigBlock> Config
    {
        get => GetRequiredArgument<TerraformList<GoogleContainerAwsNodePoolConfigBlock>>("config");
        set => SetArgument("config", value);
    }

    /// <summary>
    /// KubeletConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KubeletConfig block(s) allowed")]
    public TerraformList<GoogleContainerAwsNodePoolKubeletConfigBlock>? KubeletConfig
    {
        get => GetArgument<TerraformList<GoogleContainerAwsNodePoolKubeletConfigBlock>>("kubelet_config");
        set => SetArgument("kubelet_config", value);
    }

    /// <summary>
    /// Management block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Management block(s) allowed")]
    public TerraformList<GoogleContainerAwsNodePoolManagementBlock>? Management
    {
        get => GetArgument<TerraformList<GoogleContainerAwsNodePoolManagementBlock>>("management");
        set => SetArgument("management", value);
    }

    /// <summary>
    /// MaxPodsConstraint block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxPodsConstraint is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 MaxPodsConstraint block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MaxPodsConstraint block(s) allowed")]
    public required TerraformList<GoogleContainerAwsNodePoolMaxPodsConstraintBlock> MaxPodsConstraint
    {
        get => GetRequiredArgument<TerraformList<GoogleContainerAwsNodePoolMaxPodsConstraintBlock>>("max_pods_constraint");
        set => SetArgument("max_pods_constraint", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleContainerAwsNodePoolTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleContainerAwsNodePoolTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

    /// <summary>
    /// UpdateSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 UpdateSettings block(s) allowed")]
    public TerraformList<GoogleContainerAwsNodePoolUpdateSettingsBlock>? UpdateSettings
    {
        get => GetArgument<TerraformList<GoogleContainerAwsNodePoolUpdateSettingsBlock>>("update_settings");
        set => SetArgument("update_settings", value);
    }

}
