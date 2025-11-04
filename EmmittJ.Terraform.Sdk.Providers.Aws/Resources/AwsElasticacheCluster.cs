using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_elasticache_cluster resource.
/// </summary>
public class AwsElasticacheCluster : TerraformResource
{
    public AwsElasticacheCluster(string name) : base("aws_elasticache_cluster", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("cache_nodes");
        this.DeclareOutput("cluster_address");
        this.DeclareOutput("configuration_endpoint");
        this.DeclareOutput("engine_version_actual");
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
    /// The auto_minor_version_upgrade attribute.
    /// </summary>
    public string? AutoMinorVersionUpgrade
    {
        get => GetProperty<TerraformLiteralProperty<string>>("auto_minor_version_upgrade")?.Value;
        set => this.WithProperty("auto_minor_version_upgrade", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    public string? AvailabilityZone
    {
        get => GetProperty<TerraformLiteralProperty<string>>("availability_zone")?.Value;
        set => this.WithProperty("availability_zone", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The az_mode attribute.
    /// </summary>
    public string? AzMode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("az_mode")?.Value;
        set => this.WithProperty("az_mode", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The cluster_id attribute.
    /// </summary>
    public string? ClusterId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cluster_id")?.Value;
        set => this.WithProperty("cluster_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The maintenance_window attribute.
    /// </summary>
    public string? MaintenanceWindow
    {
        get => GetProperty<TerraformLiteralProperty<string>>("maintenance_window")?.Value;
        set => this.WithProperty("maintenance_window", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The num_cache_nodes attribute.
    /// </summary>
    public double? NumCacheNodes
    {
        get => GetProperty<TerraformLiteralProperty<double>>("num_cache_nodes")?.Value;
        set => this.WithProperty("num_cache_nodes", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The outpost_mode attribute.
    /// </summary>
    public string? OutpostMode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("outpost_mode")?.Value;
        set => this.WithProperty("outpost_mode", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The preferred_availability_zones attribute.
    /// </summary>
    public List<string>? PreferredAvailabilityZones
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("preferred_availability_zones")?.Value;
        set => this.WithProperty("preferred_availability_zones", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// The preferred_outpost_arn attribute.
    /// </summary>
    public string? PreferredOutpostArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("preferred_outpost_arn")?.Value;
        set => this.WithProperty("preferred_outpost_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The snapshot_arns attribute.
    /// </summary>
    public List<string>? SnapshotArns
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("snapshot_arns")?.Value;
        set => this.WithProperty("snapshot_arns", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
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
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The cache_nodes attribute.
    /// </summary>
    public TerraformExpression CacheNodes => this["cache_nodes"];

    /// <summary>
    /// The cluster_address attribute.
    /// </summary>
    public TerraformExpression ClusterAddress => this["cluster_address"];

    /// <summary>
    /// The configuration_endpoint attribute.
    /// </summary>
    public TerraformExpression ConfigurationEndpoint => this["configuration_endpoint"];

    /// <summary>
    /// The engine_version_actual attribute.
    /// </summary>
    public TerraformExpression EngineVersionActual => this["engine_version_actual"];

}
