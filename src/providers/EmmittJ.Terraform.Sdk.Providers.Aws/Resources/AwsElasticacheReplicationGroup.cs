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
        set => SetProperty("destination", value);
    }

    /// <summary>
    /// The destination_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DestinationType is required")]
    public required TerraformProperty<string> DestinationType
    {
        set => SetProperty("destination_type", value);
    }

    /// <summary>
    /// The log_format attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogFormat is required")]
    public required TerraformProperty<string> LogFormat
    {
        set => SetProperty("log_format", value);
    }

    /// <summary>
    /// The log_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogType is required")]
    public required TerraformProperty<string> LogType
    {
        set => SetProperty("log_type", value);
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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
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
        SetOutput("arn");
        SetOutput("cluster_enabled");
        SetOutput("configuration_endpoint_address");
        SetOutput("engine_version_actual");
        SetOutput("member_clusters");
        SetOutput("primary_endpoint_address");
        SetOutput("reader_endpoint_address");
        SetOutput("apply_immediately");
        SetOutput("at_rest_encryption_enabled");
        SetOutput("auth_token");
        SetOutput("auth_token_update_strategy");
        SetOutput("auto_minor_version_upgrade");
        SetOutput("automatic_failover_enabled");
        SetOutput("cluster_mode");
        SetOutput("data_tiering_enabled");
        SetOutput("description");
        SetOutput("engine");
        SetOutput("engine_version");
        SetOutput("final_snapshot_identifier");
        SetOutput("global_replication_group_id");
        SetOutput("id");
        SetOutput("ip_discovery");
        SetOutput("kms_key_id");
        SetOutput("maintenance_window");
        SetOutput("multi_az_enabled");
        SetOutput("network_type");
        SetOutput("node_type");
        SetOutput("notification_topic_arn");
        SetOutput("num_cache_clusters");
        SetOutput("num_node_groups");
        SetOutput("parameter_group_name");
        SetOutput("port");
        SetOutput("preferred_cache_cluster_azs");
        SetOutput("region");
        SetOutput("replicas_per_node_group");
        SetOutput("replication_group_id");
        SetOutput("security_group_ids");
        SetOutput("security_group_names");
        SetOutput("snapshot_arns");
        SetOutput("snapshot_name");
        SetOutput("snapshot_retention_limit");
        SetOutput("snapshot_window");
        SetOutput("subnet_group_name");
        SetOutput("tags");
        SetOutput("tags_all");
        SetOutput("transit_encryption_enabled");
        SetOutput("transit_encryption_mode");
        SetOutput("user_group_ids");
    }

    /// <summary>
    /// The apply_immediately attribute.
    /// </summary>
    public TerraformProperty<bool> ApplyImmediately
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("apply_immediately");
        set => SetProperty("apply_immediately", value);
    }

    /// <summary>
    /// The at_rest_encryption_enabled attribute.
    /// </summary>
    public TerraformProperty<string> AtRestEncryptionEnabled
    {
        get => GetRequiredOutput<TerraformProperty<string>>("at_rest_encryption_enabled");
        set => SetProperty("at_rest_encryption_enabled", value);
    }

    /// <summary>
    /// The auth_token attribute.
    /// </summary>
    public TerraformProperty<string> AuthToken
    {
        get => GetRequiredOutput<TerraformProperty<string>>("auth_token");
        set => SetProperty("auth_token", value);
    }

    /// <summary>
    /// The auth_token_update_strategy attribute.
    /// </summary>
    public TerraformProperty<string> AuthTokenUpdateStrategy
    {
        get => GetRequiredOutput<TerraformProperty<string>>("auth_token_update_strategy");
        set => SetProperty("auth_token_update_strategy", value);
    }

    /// <summary>
    /// The auto_minor_version_upgrade attribute.
    /// </summary>
    public TerraformProperty<string> AutoMinorVersionUpgrade
    {
        get => GetRequiredOutput<TerraformProperty<string>>("auto_minor_version_upgrade");
        set => SetProperty("auto_minor_version_upgrade", value);
    }

    /// <summary>
    /// The automatic_failover_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> AutomaticFailoverEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("automatic_failover_enabled");
        set => SetProperty("automatic_failover_enabled", value);
    }

    /// <summary>
    /// The cluster_mode attribute.
    /// </summary>
    public TerraformProperty<string> ClusterMode
    {
        get => GetRequiredOutput<TerraformProperty<string>>("cluster_mode");
        set => SetProperty("cluster_mode", value);
    }

    /// <summary>
    /// The data_tiering_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> DataTieringEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("data_tiering_enabled");
        set => SetProperty("data_tiering_enabled", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Description is required")]
    public required TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// The engine attribute.
    /// </summary>
    public TerraformProperty<string> Engine
    {
        get => GetRequiredOutput<TerraformProperty<string>>("engine");
        set => SetProperty("engine", value);
    }

    /// <summary>
    /// The engine_version attribute.
    /// </summary>
    public TerraformProperty<string> EngineVersion
    {
        get => GetRequiredOutput<TerraformProperty<string>>("engine_version");
        set => SetProperty("engine_version", value);
    }

    /// <summary>
    /// The final_snapshot_identifier attribute.
    /// </summary>
    public TerraformProperty<string> FinalSnapshotIdentifier
    {
        get => GetRequiredOutput<TerraformProperty<string>>("final_snapshot_identifier");
        set => SetProperty("final_snapshot_identifier", value);
    }

    /// <summary>
    /// The global_replication_group_id attribute.
    /// </summary>
    public TerraformProperty<string> GlobalReplicationGroupId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("global_replication_group_id");
        set => SetProperty("global_replication_group_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The ip_discovery attribute.
    /// </summary>
    public TerraformProperty<string> IpDiscovery
    {
        get => GetRequiredOutput<TerraformProperty<string>>("ip_discovery");
        set => SetProperty("ip_discovery", value);
    }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformProperty<string> KmsKeyId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("kms_key_id");
        set => SetProperty("kms_key_id", value);
    }

    /// <summary>
    /// The maintenance_window attribute.
    /// </summary>
    public TerraformProperty<string> MaintenanceWindow
    {
        get => GetRequiredOutput<TerraformProperty<string>>("maintenance_window");
        set => SetProperty("maintenance_window", value);
    }

    /// <summary>
    /// The multi_az_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> MultiAzEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("multi_az_enabled");
        set => SetProperty("multi_az_enabled", value);
    }

    /// <summary>
    /// The network_type attribute.
    /// </summary>
    public TerraformProperty<string> NetworkType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("network_type");
        set => SetProperty("network_type", value);
    }

    /// <summary>
    /// The node_type attribute.
    /// </summary>
    public TerraformProperty<string> NodeType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("node_type");
        set => SetProperty("node_type", value);
    }

    /// <summary>
    /// The notification_topic_arn attribute.
    /// </summary>
    public TerraformProperty<string> NotificationTopicArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("notification_topic_arn");
        set => SetProperty("notification_topic_arn", value);
    }

    /// <summary>
    /// The num_cache_clusters attribute.
    /// </summary>
    public TerraformProperty<double> NumCacheClusters
    {
        get => GetRequiredOutput<TerraformProperty<double>>("num_cache_clusters");
        set => SetProperty("num_cache_clusters", value);
    }

    /// <summary>
    /// The num_node_groups attribute.
    /// </summary>
    public TerraformProperty<double> NumNodeGroups
    {
        get => GetRequiredOutput<TerraformProperty<double>>("num_node_groups");
        set => SetProperty("num_node_groups", value);
    }

    /// <summary>
    /// The parameter_group_name attribute.
    /// </summary>
    public TerraformProperty<string> ParameterGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("parameter_group_name");
        set => SetProperty("parameter_group_name", value);
    }

    /// <summary>
    /// The port attribute.
    /// </summary>
    public TerraformProperty<double> Port
    {
        get => GetRequiredOutput<TerraformProperty<double>>("port");
        set => SetProperty("port", value);
    }

    /// <summary>
    /// The preferred_cache_cluster_azs attribute.
    /// </summary>
    public List<TerraformProperty<string>> PreferredCacheClusterAzs
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("preferred_cache_cluster_azs");
        set => SetProperty("preferred_cache_cluster_azs", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The replicas_per_node_group attribute.
    /// </summary>
    public TerraformProperty<double> ReplicasPerNodeGroup
    {
        get => GetRequiredOutput<TerraformProperty<double>>("replicas_per_node_group");
        set => SetProperty("replicas_per_node_group", value);
    }

    /// <summary>
    /// The replication_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReplicationGroupId is required")]
    public required TerraformProperty<string> ReplicationGroupId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("replication_group_id");
        set => SetProperty("replication_group_id", value);
    }

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> SecurityGroupIds
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("security_group_ids");
        set => SetProperty("security_group_ids", value);
    }

    /// <summary>
    /// The security_group_names attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> SecurityGroupNames
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("security_group_names");
        set => SetProperty("security_group_names", value);
    }

    /// <summary>
    /// The snapshot_arns attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> SnapshotArns
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("snapshot_arns");
        set => SetProperty("snapshot_arns", value);
    }

    /// <summary>
    /// The snapshot_name attribute.
    /// </summary>
    public TerraformProperty<string> SnapshotName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("snapshot_name");
        set => SetProperty("snapshot_name", value);
    }

    /// <summary>
    /// The snapshot_retention_limit attribute.
    /// </summary>
    public TerraformProperty<double> SnapshotRetentionLimit
    {
        get => GetRequiredOutput<TerraformProperty<double>>("snapshot_retention_limit");
        set => SetProperty("snapshot_retention_limit", value);
    }

    /// <summary>
    /// The snapshot_window attribute.
    /// </summary>
    public TerraformProperty<string> SnapshotWindow
    {
        get => GetRequiredOutput<TerraformProperty<string>>("snapshot_window");
        set => SetProperty("snapshot_window", value);
    }

    /// <summary>
    /// The subnet_group_name attribute.
    /// </summary>
    public TerraformProperty<string> SubnetGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("subnet_group_name");
        set => SetProperty("subnet_group_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> TagsAll
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => SetProperty("tags_all", value);
    }

    /// <summary>
    /// The transit_encryption_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> TransitEncryptionEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("transit_encryption_enabled");
        set => SetProperty("transit_encryption_enabled", value);
    }

    /// <summary>
    /// The transit_encryption_mode attribute.
    /// </summary>
    public TerraformProperty<string> TransitEncryptionMode
    {
        get => GetRequiredOutput<TerraformProperty<string>>("transit_encryption_mode");
        set => SetProperty("transit_encryption_mode", value);
    }

    /// <summary>
    /// The user_group_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> UserGroupIds
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("user_group_ids");
        set => SetProperty("user_group_ids", value);
    }

    /// <summary>
    /// Block for log_delivery_configuration.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(2, ErrorMessage = "Maximum 2 LogDeliveryConfiguration block(s) allowed")]
    public HashSet<AwsElasticacheReplicationGroupLogDeliveryConfigurationBlock>? LogDeliveryConfiguration
    {
        set => SetProperty("log_delivery_configuration", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsElasticacheReplicationGroupTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
