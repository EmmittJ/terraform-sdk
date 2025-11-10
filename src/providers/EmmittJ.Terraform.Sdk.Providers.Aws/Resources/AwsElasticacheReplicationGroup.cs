using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for log_delivery_configuration in .
/// Nesting mode: set
/// </summary>
public class AwsElasticacheReplicationGroupLogDeliveryConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The destination attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Destination is required")]
    public required TerraformProperty<string> Destination
    {
        get => GetRequiredProperty<TerraformProperty<string>>("destination");
        set => WithProperty("destination", value);
    }

    /// <summary>
    /// The destination_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DestinationType is required")]
    public required TerraformProperty<string> DestinationType
    {
        get => GetRequiredProperty<TerraformProperty<string>>("destination_type");
        set => WithProperty("destination_type", value);
    }

    /// <summary>
    /// The log_format attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogFormat is required")]
    public required TerraformProperty<string> LogFormat
    {
        get => GetRequiredProperty<TerraformProperty<string>>("log_format");
        set => WithProperty("log_format", value);
    }

    /// <summary>
    /// The log_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogType is required")]
    public required TerraformProperty<string> LogType
    {
        get => GetRequiredProperty<TerraformProperty<string>>("log_type");
        set => WithProperty("log_type", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsElasticacheReplicationGroupTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a aws_elasticache_replication_group resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsElasticacheReplicationGroup : TerraformResource
{
    public AwsElasticacheReplicationGroup(string name) : base("aws_elasticache_replication_group", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("arn");
        this.WithOutput("cluster_enabled");
        this.WithOutput("configuration_endpoint_address");
        this.WithOutput("engine_version_actual");
        this.WithOutput("member_clusters");
        this.WithOutput("primary_endpoint_address");
        this.WithOutput("reader_endpoint_address");
    }

    /// <summary>
    /// The apply_immediately attribute.
    /// </summary>
    public TerraformProperty<bool>? ApplyImmediately
    {
        get => GetProperty<TerraformProperty<bool>>("apply_immediately");
        set => this.WithProperty("apply_immediately", value);
    }

    /// <summary>
    /// The at_rest_encryption_enabled attribute.
    /// </summary>
    public TerraformProperty<string>? AtRestEncryptionEnabled
    {
        get => GetProperty<TerraformProperty<string>>("at_rest_encryption_enabled");
        set => this.WithProperty("at_rest_encryption_enabled", value);
    }

    /// <summary>
    /// The auth_token attribute.
    /// </summary>
    public TerraformProperty<string>? AuthToken
    {
        get => GetProperty<TerraformProperty<string>>("auth_token");
        set => this.WithProperty("auth_token", value);
    }

    /// <summary>
    /// The auth_token_update_strategy attribute.
    /// </summary>
    public TerraformProperty<string>? AuthTokenUpdateStrategy
    {
        get => GetProperty<TerraformProperty<string>>("auth_token_update_strategy");
        set => this.WithProperty("auth_token_update_strategy", value);
    }

    /// <summary>
    /// The auto_minor_version_upgrade attribute.
    /// </summary>
    public TerraformProperty<string>? AutoMinorVersionUpgrade
    {
        get => GetProperty<TerraformProperty<string>>("auto_minor_version_upgrade");
        set => this.WithProperty("auto_minor_version_upgrade", value);
    }

    /// <summary>
    /// The automatic_failover_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? AutomaticFailoverEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("automatic_failover_enabled");
        set => this.WithProperty("automatic_failover_enabled", value);
    }

    /// <summary>
    /// The cluster_mode attribute.
    /// </summary>
    public TerraformProperty<string>? ClusterMode
    {
        get => GetProperty<TerraformProperty<string>>("cluster_mode");
        set => this.WithProperty("cluster_mode", value);
    }

    /// <summary>
    /// The data_tiering_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? DataTieringEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("data_tiering_enabled");
        set => this.WithProperty("data_tiering_enabled", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Description is required")]
    public required TerraformProperty<string> Description
    {
        get => GetRequiredProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The engine attribute.
    /// </summary>
    public TerraformProperty<string>? Engine
    {
        get => GetProperty<TerraformProperty<string>>("engine");
        set => this.WithProperty("engine", value);
    }

    /// <summary>
    /// The engine_version attribute.
    /// </summary>
    public TerraformProperty<string>? EngineVersion
    {
        get => GetProperty<TerraformProperty<string>>("engine_version");
        set => this.WithProperty("engine_version", value);
    }

    /// <summary>
    /// The final_snapshot_identifier attribute.
    /// </summary>
    public TerraformProperty<string>? FinalSnapshotIdentifier
    {
        get => GetProperty<TerraformProperty<string>>("final_snapshot_identifier");
        set => this.WithProperty("final_snapshot_identifier", value);
    }

    /// <summary>
    /// The global_replication_group_id attribute.
    /// </summary>
    public TerraformProperty<string>? GlobalReplicationGroupId
    {
        get => GetProperty<TerraformProperty<string>>("global_replication_group_id");
        set => this.WithProperty("global_replication_group_id", value);
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
    /// The ip_discovery attribute.
    /// </summary>
    public TerraformProperty<string>? IpDiscovery
    {
        get => GetProperty<TerraformProperty<string>>("ip_discovery");
        set => this.WithProperty("ip_discovery", value);
    }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformProperty<string>? KmsKeyId
    {
        get => GetProperty<TerraformProperty<string>>("kms_key_id");
        set => this.WithProperty("kms_key_id", value);
    }

    /// <summary>
    /// The maintenance_window attribute.
    /// </summary>
    public TerraformProperty<string>? MaintenanceWindow
    {
        get => GetProperty<TerraformProperty<string>>("maintenance_window");
        set => this.WithProperty("maintenance_window", value);
    }

    /// <summary>
    /// The multi_az_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? MultiAzEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("multi_az_enabled");
        set => this.WithProperty("multi_az_enabled", value);
    }

    /// <summary>
    /// The network_type attribute.
    /// </summary>
    public TerraformProperty<string>? NetworkType
    {
        get => GetProperty<TerraformProperty<string>>("network_type");
        set => this.WithProperty("network_type", value);
    }

    /// <summary>
    /// The node_type attribute.
    /// </summary>
    public TerraformProperty<string>? NodeType
    {
        get => GetProperty<TerraformProperty<string>>("node_type");
        set => this.WithProperty("node_type", value);
    }

    /// <summary>
    /// The notification_topic_arn attribute.
    /// </summary>
    public TerraformProperty<string>? NotificationTopicArn
    {
        get => GetProperty<TerraformProperty<string>>("notification_topic_arn");
        set => this.WithProperty("notification_topic_arn", value);
    }

    /// <summary>
    /// The num_cache_clusters attribute.
    /// </summary>
    public TerraformProperty<double>? NumCacheClusters
    {
        get => GetProperty<TerraformProperty<double>>("num_cache_clusters");
        set => this.WithProperty("num_cache_clusters", value);
    }

    /// <summary>
    /// The num_node_groups attribute.
    /// </summary>
    public TerraformProperty<double>? NumNodeGroups
    {
        get => GetProperty<TerraformProperty<double>>("num_node_groups");
        set => this.WithProperty("num_node_groups", value);
    }

    /// <summary>
    /// The parameter_group_name attribute.
    /// </summary>
    public TerraformProperty<string>? ParameterGroupName
    {
        get => GetProperty<TerraformProperty<string>>("parameter_group_name");
        set => this.WithProperty("parameter_group_name", value);
    }

    /// <summary>
    /// The port attribute.
    /// </summary>
    public TerraformProperty<double>? Port
    {
        get => GetProperty<TerraformProperty<double>>("port");
        set => this.WithProperty("port", value);
    }

    /// <summary>
    /// The preferred_cache_cluster_azs attribute.
    /// </summary>
    public List<TerraformProperty<string>>? PreferredCacheClusterAzs
    {
        get => GetProperty<List<TerraformProperty<string>>>("preferred_cache_cluster_azs");
        set => this.WithProperty("preferred_cache_cluster_azs", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The replicas_per_node_group attribute.
    /// </summary>
    public TerraformProperty<double>? ReplicasPerNodeGroup
    {
        get => GetProperty<TerraformProperty<double>>("replicas_per_node_group");
        set => this.WithProperty("replicas_per_node_group", value);
    }

    /// <summary>
    /// The replication_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReplicationGroupId is required")]
    public required TerraformProperty<string> ReplicationGroupId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("replication_group_id");
        set => this.WithProperty("replication_group_id", value);
    }

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? SecurityGroupIds
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("security_group_ids");
        set => this.WithProperty("security_group_ids", value);
    }

    /// <summary>
    /// The security_group_names attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? SecurityGroupNames
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("security_group_names");
        set => this.WithProperty("security_group_names", value);
    }

    /// <summary>
    /// The snapshot_arns attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? SnapshotArns
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("snapshot_arns");
        set => this.WithProperty("snapshot_arns", value);
    }

    /// <summary>
    /// The snapshot_name attribute.
    /// </summary>
    public TerraformProperty<string>? SnapshotName
    {
        get => GetProperty<TerraformProperty<string>>("snapshot_name");
        set => this.WithProperty("snapshot_name", value);
    }

    /// <summary>
    /// The snapshot_retention_limit attribute.
    /// </summary>
    public TerraformProperty<double>? SnapshotRetentionLimit
    {
        get => GetProperty<TerraformProperty<double>>("snapshot_retention_limit");
        set => this.WithProperty("snapshot_retention_limit", value);
    }

    /// <summary>
    /// The snapshot_window attribute.
    /// </summary>
    public TerraformProperty<string>? SnapshotWindow
    {
        get => GetProperty<TerraformProperty<string>>("snapshot_window");
        set => this.WithProperty("snapshot_window", value);
    }

    /// <summary>
    /// The subnet_group_name attribute.
    /// </summary>
    public TerraformProperty<string>? SubnetGroupName
    {
        get => GetProperty<TerraformProperty<string>>("subnet_group_name");
        set => this.WithProperty("subnet_group_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TagsAll
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The transit_encryption_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? TransitEncryptionEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("transit_encryption_enabled");
        set => this.WithProperty("transit_encryption_enabled", value);
    }

    /// <summary>
    /// The transit_encryption_mode attribute.
    /// </summary>
    public TerraformProperty<string>? TransitEncryptionMode
    {
        get => GetProperty<TerraformProperty<string>>("transit_encryption_mode");
        set => this.WithProperty("transit_encryption_mode", value);
    }

    /// <summary>
    /// The user_group_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? UserGroupIds
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("user_group_ids");
        set => this.WithProperty("user_group_ids", value);
    }

    /// <summary>
    /// Block for log_delivery_configuration.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(2, ErrorMessage = "Maximum 2 LogDeliveryConfiguration block(s) allowed")]
    public HashSet<AwsElasticacheReplicationGroupLogDeliveryConfigurationBlock>? LogDeliveryConfiguration
    {
        get => GetProperty<HashSet<AwsElasticacheReplicationGroupLogDeliveryConfigurationBlock>>("log_delivery_configuration");
        set => this.WithProperty("log_delivery_configuration", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsElasticacheReplicationGroupTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsElasticacheReplicationGroupTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The cluster_enabled attribute.
    /// </summary>
    public TerraformExpression ClusterEnabled => this["cluster_enabled"];

    /// <summary>
    /// The configuration_endpoint_address attribute.
    /// </summary>
    public TerraformExpression ConfigurationEndpointAddress => this["configuration_endpoint_address"];

    /// <summary>
    /// The engine_version_actual attribute.
    /// </summary>
    public TerraformExpression EngineVersionActual => this["engine_version_actual"];

    /// <summary>
    /// The member_clusters attribute.
    /// </summary>
    public TerraformExpression MemberClusters => this["member_clusters"];

    /// <summary>
    /// The primary_endpoint_address attribute.
    /// </summary>
    public TerraformExpression PrimaryEndpointAddress => this["primary_endpoint_address"];

    /// <summary>
    /// The reader_endpoint_address attribute.
    /// </summary>
    public TerraformExpression ReaderEndpointAddress => this["reader_endpoint_address"];

}
