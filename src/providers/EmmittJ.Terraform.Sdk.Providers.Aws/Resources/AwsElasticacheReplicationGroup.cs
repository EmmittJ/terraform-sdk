using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for log_delivery_configuration in AwsElasticacheReplicationGroup.
/// Nesting mode: set
/// </summary>
public class AwsElasticacheReplicationGroupLogDeliveryConfigurationBlock : TerraformBlock
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
/// Block type for timeouts in AwsElasticacheReplicationGroup.
/// Nesting mode: single
/// </summary>
public class AwsElasticacheReplicationGroupTimeoutsBlock : TerraformBlock
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
/// Represents a aws_elasticache_replication_group Terraform resource.
/// Manages a aws_elasticache_replication_group resource.
/// </summary>
public partial class AwsElasticacheReplicationGroup(string name) : TerraformResource("aws_elasticache_replication_group", name)
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
    /// The at_rest_encryption_enabled attribute.
    /// </summary>
    public TerraformValue<string> AtRestEncryptionEnabled
    {
        get => new TerraformReference<string>(this, "at_rest_encryption_enabled");
        set => SetArgument("at_rest_encryption_enabled", value);
    }

    /// <summary>
    /// The auth_token attribute.
    /// </summary>
    public TerraformValue<string>? AuthToken
    {
        get => new TerraformReference<string>(this, "auth_token");
        set => SetArgument("auth_token", value);
    }

    /// <summary>
    /// The auth_token_update_strategy attribute.
    /// </summary>
    public TerraformValue<string>? AuthTokenUpdateStrategy
    {
        get => new TerraformReference<string>(this, "auth_token_update_strategy");
        set => SetArgument("auth_token_update_strategy", value);
    }

    /// <summary>
    /// The auto_minor_version_upgrade attribute.
    /// </summary>
    public TerraformValue<string> AutoMinorVersionUpgrade
    {
        get => new TerraformReference<string>(this, "auto_minor_version_upgrade");
        set => SetArgument("auto_minor_version_upgrade", value);
    }

    /// <summary>
    /// The automatic_failover_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? AutomaticFailoverEnabled
    {
        get => new TerraformReference<bool>(this, "automatic_failover_enabled");
        set => SetArgument("automatic_failover_enabled", value);
    }

    /// <summary>
    /// The cluster_mode attribute.
    /// </summary>
    public TerraformValue<string> ClusterMode
    {
        get => new TerraformReference<string>(this, "cluster_mode");
        set => SetArgument("cluster_mode", value);
    }

    /// <summary>
    /// The data_tiering_enabled attribute.
    /// </summary>
    public TerraformValue<bool> DataTieringEnabled
    {
        get => new TerraformReference<bool>(this, "data_tiering_enabled");
        set => SetArgument("data_tiering_enabled", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Description is required")]
    public required TerraformValue<string> Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
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
    /// The global_replication_group_id attribute.
    /// </summary>
    public TerraformValue<string> GlobalReplicationGroupId
    {
        get => new TerraformReference<string>(this, "global_replication_group_id");
        set => SetArgument("global_replication_group_id", value);
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
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformValue<string>? KmsKeyId
    {
        get => new TerraformReference<string>(this, "kms_key_id");
        set => SetArgument("kms_key_id", value);
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
    /// The multi_az_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? MultiAzEnabled
    {
        get => new TerraformReference<bool>(this, "multi_az_enabled");
        set => SetArgument("multi_az_enabled", value);
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
    /// The num_cache_clusters attribute.
    /// </summary>
    public TerraformValue<double> NumCacheClusters
    {
        get => new TerraformReference<double>(this, "num_cache_clusters");
        set => SetArgument("num_cache_clusters", value);
    }

    /// <summary>
    /// The num_node_groups attribute.
    /// </summary>
    public TerraformValue<double> NumNodeGroups
    {
        get => new TerraformReference<double>(this, "num_node_groups");
        set => SetArgument("num_node_groups", value);
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
    public TerraformValue<double>? Port
    {
        get => new TerraformReference<double>(this, "port");
        set => SetArgument("port", value);
    }

    /// <summary>
    /// The preferred_cache_cluster_azs attribute.
    /// </summary>
    public TerraformList<string>? PreferredCacheClusterAzs
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "preferred_cache_cluster_azs").ResolveNodes(ctx));
        set => SetArgument("preferred_cache_cluster_azs", value);
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
    /// The replicas_per_node_group attribute.
    /// </summary>
    public TerraformValue<double> ReplicasPerNodeGroup
    {
        get => new TerraformReference<double>(this, "replicas_per_node_group");
        set => SetArgument("replicas_per_node_group", value);
    }

    /// <summary>
    /// The replication_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReplicationGroupId is required")]
    public required TerraformValue<string> ReplicationGroupId
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
    /// The security_group_names attribute.
    /// </summary>
    public TerraformSet<string> SecurityGroupNames
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "security_group_names").ResolveNodes(ctx));
        set => SetArgument("security_group_names", value);
    }

    /// <summary>
    /// The snapshot_arns attribute.
    /// </summary>
    public TerraformSet<string>? SnapshotArns
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "snapshot_arns").ResolveNodes(ctx));
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
    /// The transit_encryption_mode attribute.
    /// </summary>
    public TerraformValue<string> TransitEncryptionMode
    {
        get => new TerraformReference<string>(this, "transit_encryption_mode");
        set => SetArgument("transit_encryption_mode", value);
    }

    /// <summary>
    /// The user_group_ids attribute.
    /// </summary>
    public TerraformSet<string>? UserGroupIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "user_group_ids").ResolveNodes(ctx));
        set => SetArgument("user_group_ids", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The cluster_enabled attribute.
    /// </summary>
    public TerraformValue<bool> ClusterEnabled
    {
        get => new TerraformReference<bool>(this, "cluster_enabled");
    }

    /// <summary>
    /// The configuration_endpoint_address attribute.
    /// </summary>
    public TerraformValue<string> ConfigurationEndpointAddress
    {
        get => new TerraformReference<string>(this, "configuration_endpoint_address");
    }

    /// <summary>
    /// The engine_version_actual attribute.
    /// </summary>
    public TerraformValue<string> EngineVersionActual
    {
        get => new TerraformReference<string>(this, "engine_version_actual");
    }

    /// <summary>
    /// The member_clusters attribute.
    /// </summary>
    public TerraformSet<string> MemberClusters
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "member_clusters").ResolveNodes(ctx));
    }

    /// <summary>
    /// The primary_endpoint_address attribute.
    /// </summary>
    public TerraformValue<string> PrimaryEndpointAddress
    {
        get => new TerraformReference<string>(this, "primary_endpoint_address");
    }

    /// <summary>
    /// The reader_endpoint_address attribute.
    /// </summary>
    public TerraformValue<string> ReaderEndpointAddress
    {
        get => new TerraformReference<string>(this, "reader_endpoint_address");
    }

    /// <summary>
    /// LogDeliveryConfiguration block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(2, ErrorMessage = "Maximum 2 LogDeliveryConfiguration block(s) allowed")]
    public TerraformSet<AwsElasticacheReplicationGroupLogDeliveryConfigurationBlock>? LogDeliveryConfiguration
    {
        get => GetArgument<TerraformSet<AwsElasticacheReplicationGroupLogDeliveryConfigurationBlock>>("log_delivery_configuration");
        set => SetArgument("log_delivery_configuration", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsElasticacheReplicationGroupTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsElasticacheReplicationGroupTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
