using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_elasticache_replication_group resource.
/// </summary>
public class AwsElasticacheReplicationGroup : TerraformResource
{
    public AwsElasticacheReplicationGroup(string name) : base("aws_elasticache_replication_group", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("cluster_enabled");
        this.DeclareOutput("configuration_endpoint_address");
        this.DeclareOutput("engine_version_actual");
        this.DeclareOutput("member_clusters");
        this.DeclareOutput("primary_endpoint_address");
        this.DeclareOutput("reader_endpoint_address");
    }

    /// <summary>
    /// The apply_immediately attribute.
    /// </summary>
    public bool? ApplyImmediately
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("apply_immediately")?.Value;
        set => this.WithProperty("apply_immediately", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The at_rest_encryption_enabled attribute.
    /// </summary>
    public string? AtRestEncryptionEnabled
    {
        get => GetProperty<TerraformLiteralProperty<string>>("at_rest_encryption_enabled")?.Value;
        set => this.WithProperty("at_rest_encryption_enabled", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The auth_token attribute.
    /// </summary>
    public string? AuthToken
    {
        get => GetProperty<TerraformLiteralProperty<string>>("auth_token")?.Value;
        set => this.WithProperty("auth_token", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The auth_token_update_strategy attribute.
    /// </summary>
    public string? AuthTokenUpdateStrategy
    {
        get => GetProperty<TerraformLiteralProperty<string>>("auth_token_update_strategy")?.Value;
        set => this.WithProperty("auth_token_update_strategy", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The auto_minor_version_upgrade attribute.
    /// </summary>
    public string? AutoMinorVersionUpgrade
    {
        get => GetProperty<TerraformLiteralProperty<string>>("auto_minor_version_upgrade")?.Value;
        set => this.WithProperty("auto_minor_version_upgrade", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The automatic_failover_enabled attribute.
    /// </summary>
    public bool? AutomaticFailoverEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("automatic_failover_enabled")?.Value;
        set => this.WithProperty("automatic_failover_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The cluster_mode attribute.
    /// </summary>
    public string? ClusterMode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cluster_mode")?.Value;
        set => this.WithProperty("cluster_mode", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The data_tiering_enabled attribute.
    /// </summary>
    public bool? DataTieringEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("data_tiering_enabled")?.Value;
        set => this.WithProperty("data_tiering_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The engine attribute.
    /// </summary>
    public string? Engine
    {
        get => GetProperty<TerraformLiteralProperty<string>>("engine")?.Value;
        set => this.WithProperty("engine", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The engine_version attribute.
    /// </summary>
    public string? EngineVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("engine_version")?.Value;
        set => this.WithProperty("engine_version", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The final_snapshot_identifier attribute.
    /// </summary>
    public string? FinalSnapshotIdentifier
    {
        get => GetProperty<TerraformLiteralProperty<string>>("final_snapshot_identifier")?.Value;
        set => this.WithProperty("final_snapshot_identifier", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The global_replication_group_id attribute.
    /// </summary>
    public string? GlobalReplicationGroupId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("global_replication_group_id")?.Value;
        set => this.WithProperty("global_replication_group_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The ip_discovery attribute.
    /// </summary>
    public string? IpDiscovery
    {
        get => GetProperty<TerraformLiteralProperty<string>>("ip_discovery")?.Value;
        set => this.WithProperty("ip_discovery", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public string? KmsKeyId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("kms_key_id")?.Value;
        set => this.WithProperty("kms_key_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The maintenance_window attribute.
    /// </summary>
    public string? MaintenanceWindow
    {
        get => GetProperty<TerraformLiteralProperty<string>>("maintenance_window")?.Value;
        set => this.WithProperty("maintenance_window", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The multi_az_enabled attribute.
    /// </summary>
    public bool? MultiAzEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("multi_az_enabled")?.Value;
        set => this.WithProperty("multi_az_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The network_type attribute.
    /// </summary>
    public string? NetworkType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("network_type")?.Value;
        set => this.WithProperty("network_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The node_type attribute.
    /// </summary>
    public string? NodeType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("node_type")?.Value;
        set => this.WithProperty("node_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The notification_topic_arn attribute.
    /// </summary>
    public string? NotificationTopicArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("notification_topic_arn")?.Value;
        set => this.WithProperty("notification_topic_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The num_cache_clusters attribute.
    /// </summary>
    public double? NumCacheClusters
    {
        get => GetProperty<TerraformLiteralProperty<double>>("num_cache_clusters")?.Value;
        set => this.WithProperty("num_cache_clusters", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The num_node_groups attribute.
    /// </summary>
    public double? NumNodeGroups
    {
        get => GetProperty<TerraformLiteralProperty<double>>("num_node_groups")?.Value;
        set => this.WithProperty("num_node_groups", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The parameter_group_name attribute.
    /// </summary>
    public string? ParameterGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("parameter_group_name")?.Value;
        set => this.WithProperty("parameter_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The port attribute.
    /// </summary>
    public double? Port
    {
        get => GetProperty<TerraformLiteralProperty<double>>("port")?.Value;
        set => this.WithProperty("port", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The preferred_cache_cluster_azs attribute.
    /// </summary>
    public List<string>? PreferredCacheClusterAzs
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("preferred_cache_cluster_azs")?.Value;
        set => this.WithProperty("preferred_cache_cluster_azs", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// The replicas_per_node_group attribute.
    /// </summary>
    public double? ReplicasPerNodeGroup
    {
        get => GetProperty<TerraformLiteralProperty<double>>("replicas_per_node_group")?.Value;
        set => this.WithProperty("replicas_per_node_group", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The replication_group_id attribute.
    /// </summary>
    public string? ReplicationGroupId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("replication_group_id")?.Value;
        set => this.WithProperty("replication_group_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    public HashSet<string>? SecurityGroupIds
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("security_group_ids")?.Value;
        set => this.WithProperty("security_group_ids", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The security_group_names attribute.
    /// </summary>
    public HashSet<string>? SecurityGroupNames
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("security_group_names")?.Value;
        set => this.WithProperty("security_group_names", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The snapshot_arns attribute.
    /// </summary>
    public HashSet<string>? SnapshotArns
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("snapshot_arns")?.Value;
        set => this.WithProperty("snapshot_arns", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The snapshot_name attribute.
    /// </summary>
    public string? SnapshotName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("snapshot_name")?.Value;
        set => this.WithProperty("snapshot_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The snapshot_retention_limit attribute.
    /// </summary>
    public double? SnapshotRetentionLimit
    {
        get => GetProperty<TerraformLiteralProperty<double>>("snapshot_retention_limit")?.Value;
        set => this.WithProperty("snapshot_retention_limit", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The snapshot_window attribute.
    /// </summary>
    public string? SnapshotWindow
    {
        get => GetProperty<TerraformLiteralProperty<string>>("snapshot_window")?.Value;
        set => this.WithProperty("snapshot_window", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The subnet_group_name attribute.
    /// </summary>
    public string? SubnetGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("subnet_group_name")?.Value;
        set => this.WithProperty("subnet_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, string>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all")?.Value;
        set => this.WithProperty("tags_all", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The transit_encryption_enabled attribute.
    /// </summary>
    public bool? TransitEncryptionEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("transit_encryption_enabled")?.Value;
        set => this.WithProperty("transit_encryption_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The transit_encryption_mode attribute.
    /// </summary>
    public string? TransitEncryptionMode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("transit_encryption_mode")?.Value;
        set => this.WithProperty("transit_encryption_mode", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The user_group_ids attribute.
    /// </summary>
    public HashSet<string>? UserGroupIds
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("user_group_ids")?.Value;
        set => this.WithProperty("user_group_ids", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
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
