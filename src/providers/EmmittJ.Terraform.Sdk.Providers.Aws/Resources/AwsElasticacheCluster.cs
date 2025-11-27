using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for log_delivery_configuration in AwsElasticacheCluster.
/// Nesting mode: set
/// </summary>
public class AwsElasticacheClusterLogDeliveryConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "log_delivery_configuration";

    /// <summary>
    /// The destination attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Destination is required")]
    public required TerraformValue<string> Destination
    {
        get => new TerraformReference<string>(this, "destination");
        set => SetArgument("destination", value);
    }

    /// <summary>
    /// The destination_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DestinationType is required")]
    public required TerraformValue<string> DestinationType
    {
        get => new TerraformReference<string>(this, "destination_type");
        set => SetArgument("destination_type", value);
    }

    /// <summary>
    /// The log_format attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogFormat is required")]
    public required TerraformValue<string> LogFormat
    {
        get => new TerraformReference<string>(this, "log_format");
        set => SetArgument("log_format", value);
    }

    /// <summary>
    /// The log_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogType is required")]
    public required TerraformValue<string> LogType
    {
        get => new TerraformReference<string>(this, "log_type");
        set => SetArgument("log_type", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsElasticacheCluster.
/// Nesting mode: single
/// </summary>
public class AwsElasticacheClusterTimeoutsBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a aws_elasticache_cluster Terraform resource.
/// Manages a aws_elasticache_cluster resource.
/// </summary>
public partial class AwsElasticacheCluster(string name) : TerraformResource("aws_elasticache_cluster", name)
{
    /// <summary>
    /// The apply_immediately attribute.
    /// </summary>
    public TerraformValue<bool> ApplyImmediately
    {
        get => new TerraformReference<bool>(this, "apply_immediately");
        set => SetArgument("apply_immediately", value);
    }

    /// <summary>
    /// The auto_minor_version_upgrade attribute.
    /// </summary>
    public TerraformValue<string>? AutoMinorVersionUpgrade
    {
        get => new TerraformReference<string>(this, "auto_minor_version_upgrade");
        set => SetArgument("auto_minor_version_upgrade", value);
    }

    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    public TerraformValue<string> AvailabilityZone
    {
        get => new TerraformReference<string>(this, "availability_zone");
        set => SetArgument("availability_zone", value);
    }

    /// <summary>
    /// The az_mode attribute.
    /// </summary>
    public TerraformValue<string> AzMode
    {
        get => new TerraformReference<string>(this, "az_mode");
        set => SetArgument("az_mode", value);
    }

    /// <summary>
    /// The cluster_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterId is required")]
    public required TerraformValue<string> ClusterId
    {
        get => new TerraformReference<string>(this, "cluster_id");
        set => SetArgument("cluster_id", value);
    }

    /// <summary>
    /// The engine attribute.
    /// </summary>
    public TerraformValue<string> Engine
    {
        get => new TerraformReference<string>(this, "engine");
        set => SetArgument("engine", value);
    }

    /// <summary>
    /// The engine_version attribute.
    /// </summary>
    public TerraformValue<string> EngineVersion
    {
        get => new TerraformReference<string>(this, "engine_version");
        set => SetArgument("engine_version", value);
    }

    /// <summary>
    /// The final_snapshot_identifier attribute.
    /// </summary>
    public TerraformValue<string>? FinalSnapshotIdentifier
    {
        get => new TerraformReference<string>(this, "final_snapshot_identifier");
        set => SetArgument("final_snapshot_identifier", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The ip_discovery attribute.
    /// </summary>
    public TerraformValue<string> IpDiscovery
    {
        get => new TerraformReference<string>(this, "ip_discovery");
        set => SetArgument("ip_discovery", value);
    }

    /// <summary>
    /// The maintenance_window attribute.
    /// </summary>
    public TerraformValue<string> MaintenanceWindow
    {
        get => new TerraformReference<string>(this, "maintenance_window");
        set => SetArgument("maintenance_window", value);
    }

    /// <summary>
    /// The network_type attribute.
    /// </summary>
    public TerraformValue<string> NetworkType
    {
        get => new TerraformReference<string>(this, "network_type");
        set => SetArgument("network_type", value);
    }

    /// <summary>
    /// The node_type attribute.
    /// </summary>
    public TerraformValue<string> NodeType
    {
        get => new TerraformReference<string>(this, "node_type");
        set => SetArgument("node_type", value);
    }

    /// <summary>
    /// The notification_topic_arn attribute.
    /// </summary>
    public TerraformValue<string>? NotificationTopicArn
    {
        get => new TerraformReference<string>(this, "notification_topic_arn");
        set => SetArgument("notification_topic_arn", value);
    }

    /// <summary>
    /// The num_cache_nodes attribute.
    /// </summary>
    public TerraformValue<double> NumCacheNodes
    {
        get => new TerraformReference<double>(this, "num_cache_nodes");
        set => SetArgument("num_cache_nodes", value);
    }

    /// <summary>
    /// The outpost_mode attribute.
    /// </summary>
    public TerraformValue<string>? OutpostMode
    {
        get => new TerraformReference<string>(this, "outpost_mode");
        set => SetArgument("outpost_mode", value);
    }

    /// <summary>
    /// The parameter_group_name attribute.
    /// </summary>
    public TerraformValue<string> ParameterGroupName
    {
        get => new TerraformReference<string>(this, "parameter_group_name");
        set => SetArgument("parameter_group_name", value);
    }

    /// <summary>
    /// The port attribute.
    /// </summary>
    public TerraformValue<double> Port
    {
        get => new TerraformReference<double>(this, "port");
        set => SetArgument("port", value);
    }

    /// <summary>
    /// The preferred_availability_zones attribute.
    /// </summary>
    public TerraformList<string>? PreferredAvailabilityZones
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "preferred_availability_zones").ResolveNodes(ctx));
        set => SetArgument("preferred_availability_zones", value);
    }

    /// <summary>
    /// The preferred_outpost_arn attribute.
    /// </summary>
    public TerraformValue<string> PreferredOutpostArn
    {
        get => new TerraformReference<string>(this, "preferred_outpost_arn");
        set => SetArgument("preferred_outpost_arn", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The replication_group_id attribute.
    /// </summary>
    public TerraformValue<string> ReplicationGroupId
    {
        get => new TerraformReference<string>(this, "replication_group_id");
        set => SetArgument("replication_group_id", value);
    }

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    public TerraformSet<string> SecurityGroupIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "security_group_ids").ResolveNodes(ctx));
        set => SetArgument("security_group_ids", value);
    }

    /// <summary>
    /// The snapshot_arns attribute.
    /// </summary>
    public TerraformList<string>? SnapshotArns
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "snapshot_arns").ResolveNodes(ctx));
        set => SetArgument("snapshot_arns", value);
    }

    /// <summary>
    /// The snapshot_name attribute.
    /// </summary>
    public TerraformValue<string>? SnapshotName
    {
        get => new TerraformReference<string>(this, "snapshot_name");
        set => SetArgument("snapshot_name", value);
    }

    /// <summary>
    /// The snapshot_retention_limit attribute.
    /// </summary>
    public TerraformValue<double>? SnapshotRetentionLimit
    {
        get => new TerraformReference<double>(this, "snapshot_retention_limit");
        set => SetArgument("snapshot_retention_limit", value);
    }

    /// <summary>
    /// The snapshot_window attribute.
    /// </summary>
    public TerraformValue<string> SnapshotWindow
    {
        get => new TerraformReference<string>(this, "snapshot_window");
        set => SetArgument("snapshot_window", value);
    }

    /// <summary>
    /// The subnet_group_name attribute.
    /// </summary>
    public TerraformValue<string> SubnetGroupName
    {
        get => new TerraformReference<string>(this, "subnet_group_name");
        set => SetArgument("subnet_group_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The transit_encryption_enabled attribute.
    /// </summary>
    public TerraformValue<bool> TransitEncryptionEnabled
    {
        get => new TerraformReference<bool>(this, "transit_encryption_enabled");
        set => SetArgument("transit_encryption_enabled", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The cache_nodes attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> CacheNodes
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "cache_nodes").ResolveNodes(ctx));
    }

    /// <summary>
    /// The cluster_address attribute.
    /// </summary>
    public TerraformValue<string> ClusterAddress
    {
        get => new TerraformReference<string>(this, "cluster_address");
    }

    /// <summary>
    /// The configuration_endpoint attribute.
    /// </summary>
    public TerraformValue<string> ConfigurationEndpoint
    {
        get => new TerraformReference<string>(this, "configuration_endpoint");
    }

    /// <summary>
    /// The engine_version_actual attribute.
    /// </summary>
    public TerraformValue<string> EngineVersionActual
    {
        get => new TerraformReference<string>(this, "engine_version_actual");
    }

    /// <summary>
    /// LogDeliveryConfiguration block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(2, ErrorMessage = "Maximum 2 LogDeliveryConfiguration block(s) allowed")]
    public TerraformSet<AwsElasticacheClusterLogDeliveryConfigurationBlock>? LogDeliveryConfiguration
    {
        get => GetArgument<TerraformSet<AwsElasticacheClusterLogDeliveryConfigurationBlock>>("log_delivery_configuration");
        set => SetArgument("log_delivery_configuration", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsElasticacheClusterTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsElasticacheClusterTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
