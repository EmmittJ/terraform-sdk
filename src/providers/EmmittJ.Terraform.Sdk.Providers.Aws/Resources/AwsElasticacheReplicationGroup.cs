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
        get => GetRequiredArgument<TerraformValue<string>>("destination");
        set => SetArgument("destination", value);
    }

    /// <summary>
    /// The destination_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DestinationType is required")]
    public required TerraformValue<string> DestinationType
    {
        get => GetRequiredArgument<TerraformValue<string>>("destination_type");
        set => SetArgument("destination_type", value);
    }

    /// <summary>
    /// The log_format attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogFormat is required")]
    public required TerraformValue<string> LogFormat
    {
        get => GetRequiredArgument<TerraformValue<string>>("log_format");
        set => SetArgument("log_format", value);
    }

    /// <summary>
    /// The log_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogType is required")]
    public required TerraformValue<string> LogType
    {
        get => GetRequiredArgument<TerraformValue<string>>("log_type");
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
        get => GetArgument<TerraformValue<bool>>("apply_immediately") ?? AsReference("apply_immediately");
        set => SetArgument("apply_immediately", value);
    }

    /// <summary>
    /// The at_rest_encryption_enabled attribute.
    /// </summary>
    public TerraformValue<string> AtRestEncryptionEnabled
    {
        get => GetArgument<TerraformValue<string>>("at_rest_encryption_enabled") ?? AsReference("at_rest_encryption_enabled");
        set => SetArgument("at_rest_encryption_enabled", value);
    }

    /// <summary>
    /// The auth_token attribute.
    /// </summary>
    public TerraformValue<string>? AuthToken
    {
        get => GetArgument<TerraformValue<string>>("auth_token");
        set => SetArgument("auth_token", value);
    }

    /// <summary>
    /// The auth_token_update_strategy attribute.
    /// </summary>
    public TerraformValue<string>? AuthTokenUpdateStrategy
    {
        get => GetArgument<TerraformValue<string>>("auth_token_update_strategy");
        set => SetArgument("auth_token_update_strategy", value);
    }

    /// <summary>
    /// The auto_minor_version_upgrade attribute.
    /// </summary>
    public TerraformValue<string> AutoMinorVersionUpgrade
    {
        get => GetArgument<TerraformValue<string>>("auto_minor_version_upgrade") ?? AsReference("auto_minor_version_upgrade");
        set => SetArgument("auto_minor_version_upgrade", value);
    }

    /// <summary>
    /// The automatic_failover_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? AutomaticFailoverEnabled
    {
        get => GetArgument<TerraformValue<bool>>("automatic_failover_enabled");
        set => SetArgument("automatic_failover_enabled", value);
    }

    /// <summary>
    /// The cluster_mode attribute.
    /// </summary>
    public TerraformValue<string> ClusterMode
    {
        get => GetArgument<TerraformValue<string>>("cluster_mode") ?? AsReference("cluster_mode");
        set => SetArgument("cluster_mode", value);
    }

    /// <summary>
    /// The data_tiering_enabled attribute.
    /// </summary>
    public TerraformValue<bool> DataTieringEnabled
    {
        get => GetArgument<TerraformValue<bool>>("data_tiering_enabled") ?? AsReference("data_tiering_enabled");
        set => SetArgument("data_tiering_enabled", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Description is required")]
    public required TerraformValue<string> Description
    {
        get => GetRequiredArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The engine attribute.
    /// </summary>
    public TerraformValue<string> Engine
    {
        get => GetArgument<TerraformValue<string>>("engine") ?? AsReference("engine");
        set => SetArgument("engine", value);
    }

    /// <summary>
    /// The engine_version attribute.
    /// </summary>
    public TerraformValue<string> EngineVersion
    {
        get => GetArgument<TerraformValue<string>>("engine_version") ?? AsReference("engine_version");
        set => SetArgument("engine_version", value);
    }

    /// <summary>
    /// The final_snapshot_identifier attribute.
    /// </summary>
    public TerraformValue<string>? FinalSnapshotIdentifier
    {
        get => GetArgument<TerraformValue<string>>("final_snapshot_identifier");
        set => SetArgument("final_snapshot_identifier", value);
    }

    /// <summary>
    /// The global_replication_group_id attribute.
    /// </summary>
    public TerraformValue<string> GlobalReplicationGroupId
    {
        get => GetArgument<TerraformValue<string>>("global_replication_group_id") ?? AsReference("global_replication_group_id");
        set => SetArgument("global_replication_group_id", value);
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
    /// The ip_discovery attribute.
    /// </summary>
    public TerraformValue<string> IpDiscovery
    {
        get => GetArgument<TerraformValue<string>>("ip_discovery") ?? AsReference("ip_discovery");
        set => SetArgument("ip_discovery", value);
    }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformValue<string>? KmsKeyId
    {
        get => GetArgument<TerraformValue<string>>("kms_key_id");
        set => SetArgument("kms_key_id", value);
    }

    /// <summary>
    /// The maintenance_window attribute.
    /// </summary>
    public TerraformValue<string> MaintenanceWindow
    {
        get => GetArgument<TerraformValue<string>>("maintenance_window") ?? AsReference("maintenance_window");
        set => SetArgument("maintenance_window", value);
    }

    /// <summary>
    /// The multi_az_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? MultiAzEnabled
    {
        get => GetArgument<TerraformValue<bool>>("multi_az_enabled");
        set => SetArgument("multi_az_enabled", value);
    }

    /// <summary>
    /// The network_type attribute.
    /// </summary>
    public TerraformValue<string> NetworkType
    {
        get => GetArgument<TerraformValue<string>>("network_type") ?? AsReference("network_type");
        set => SetArgument("network_type", value);
    }

    /// <summary>
    /// The node_type attribute.
    /// </summary>
    public TerraformValue<string> NodeType
    {
        get => GetArgument<TerraformValue<string>>("node_type") ?? AsReference("node_type");
        set => SetArgument("node_type", value);
    }

    /// <summary>
    /// The notification_topic_arn attribute.
    /// </summary>
    public TerraformValue<string>? NotificationTopicArn
    {
        get => GetArgument<TerraformValue<string>>("notification_topic_arn");
        set => SetArgument("notification_topic_arn", value);
    }

    /// <summary>
    /// The num_cache_clusters attribute.
    /// </summary>
    public TerraformValue<double> NumCacheClusters
    {
        get => GetArgument<TerraformValue<double>>("num_cache_clusters") ?? AsReference("num_cache_clusters");
        set => SetArgument("num_cache_clusters", value);
    }

    /// <summary>
    /// The num_node_groups attribute.
    /// </summary>
    public TerraformValue<double> NumNodeGroups
    {
        get => GetArgument<TerraformValue<double>>("num_node_groups") ?? AsReference("num_node_groups");
        set => SetArgument("num_node_groups", value);
    }

    /// <summary>
    /// The parameter_group_name attribute.
    /// </summary>
    public TerraformValue<string> ParameterGroupName
    {
        get => GetArgument<TerraformValue<string>>("parameter_group_name") ?? AsReference("parameter_group_name");
        set => SetArgument("parameter_group_name", value);
    }

    /// <summary>
    /// The port attribute.
    /// </summary>
    public TerraformValue<double>? Port
    {
        get => GetArgument<TerraformValue<double>>("port");
        set => SetArgument("port", value);
    }

    /// <summary>
    /// The preferred_cache_cluster_azs attribute.
    /// </summary>
    public TerraformList<string>? PreferredCacheClusterAzs
    {
        get => GetArgument<TerraformList<string>>("preferred_cache_cluster_azs");
        set => SetArgument("preferred_cache_cluster_azs", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The replicas_per_node_group attribute.
    /// </summary>
    public TerraformValue<double> ReplicasPerNodeGroup
    {
        get => GetArgument<TerraformValue<double>>("replicas_per_node_group") ?? AsReference("replicas_per_node_group");
        set => SetArgument("replicas_per_node_group", value);
    }

    /// <summary>
    /// The replication_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReplicationGroupId is required")]
    public required TerraformValue<string> ReplicationGroupId
    {
        get => GetRequiredArgument<TerraformValue<string>>("replication_group_id");
        set => SetArgument("replication_group_id", value);
    }

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    public TerraformSet<string> SecurityGroupIds
    {
        get => GetArgument<TerraformSet<string>>("security_group_ids") ?? AsReference("security_group_ids");
        set => SetArgument("security_group_ids", value);
    }

    /// <summary>
    /// The security_group_names attribute.
    /// </summary>
    public TerraformSet<string> SecurityGroupNames
    {
        get => GetArgument<TerraformSet<string>>("security_group_names") ?? AsReference("security_group_names");
        set => SetArgument("security_group_names", value);
    }

    /// <summary>
    /// The snapshot_arns attribute.
    /// </summary>
    public TerraformSet<string>? SnapshotArns
    {
        get => GetArgument<TerraformSet<string>>("snapshot_arns");
        set => SetArgument("snapshot_arns", value);
    }

    /// <summary>
    /// The snapshot_name attribute.
    /// </summary>
    public TerraformValue<string>? SnapshotName
    {
        get => GetArgument<TerraformValue<string>>("snapshot_name");
        set => SetArgument("snapshot_name", value);
    }

    /// <summary>
    /// The snapshot_retention_limit attribute.
    /// </summary>
    public TerraformValue<double>? SnapshotRetentionLimit
    {
        get => GetArgument<TerraformValue<double>>("snapshot_retention_limit");
        set => SetArgument("snapshot_retention_limit", value);
    }

    /// <summary>
    /// The snapshot_window attribute.
    /// </summary>
    public TerraformValue<string> SnapshotWindow
    {
        get => GetArgument<TerraformValue<string>>("snapshot_window") ?? AsReference("snapshot_window");
        set => SetArgument("snapshot_window", value);
    }

    /// <summary>
    /// The subnet_group_name attribute.
    /// </summary>
    public TerraformValue<string> SubnetGroupName
    {
        get => GetArgument<TerraformValue<string>>("subnet_group_name") ?? AsReference("subnet_group_name");
        set => SetArgument("subnet_group_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all") ?? AsReference("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The transit_encryption_enabled attribute.
    /// </summary>
    public TerraformValue<bool> TransitEncryptionEnabled
    {
        get => GetArgument<TerraformValue<bool>>("transit_encryption_enabled") ?? AsReference("transit_encryption_enabled");
        set => SetArgument("transit_encryption_enabled", value);
    }

    /// <summary>
    /// The transit_encryption_mode attribute.
    /// </summary>
    public TerraformValue<string> TransitEncryptionMode
    {
        get => GetArgument<TerraformValue<string>>("transit_encryption_mode") ?? AsReference("transit_encryption_mode");
        set => SetArgument("transit_encryption_mode", value);
    }

    /// <summary>
    /// The user_group_ids attribute.
    /// </summary>
    public TerraformSet<string>? UserGroupIds
    {
        get => GetArgument<TerraformSet<string>>("user_group_ids");
        set => SetArgument("user_group_ids", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The cluster_enabled attribute.
    /// </summary>
    public TerraformValue<bool> ClusterEnabled
        => AsReference("cluster_enabled");

    /// <summary>
    /// The configuration_endpoint_address attribute.
    /// </summary>
    public TerraformValue<string> ConfigurationEndpointAddress
        => AsReference("configuration_endpoint_address");

    /// <summary>
    /// The engine_version_actual attribute.
    /// </summary>
    public TerraformValue<string> EngineVersionActual
        => AsReference("engine_version_actual");

    /// <summary>
    /// The member_clusters attribute.
    /// </summary>
    public TerraformSet<string> MemberClusters
        => AsReference("member_clusters");

    /// <summary>
    /// The primary_endpoint_address attribute.
    /// </summary>
    public TerraformValue<string> PrimaryEndpointAddress
        => AsReference("primary_endpoint_address");

    /// <summary>
    /// The reader_endpoint_address attribute.
    /// </summary>
    public TerraformValue<string> ReaderEndpointAddress
        => AsReference("reader_endpoint_address");

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
