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
    public TerraformProperty<bool>? ApplyImmediately
    {
        get => GetProperty<TerraformProperty<bool>>("apply_immediately");
        set => this.WithProperty("apply_immediately", value);
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
    /// The availability_zone attribute.
    /// </summary>
    public TerraformProperty<string>? AvailabilityZone
    {
        get => GetProperty<TerraformProperty<string>>("availability_zone");
        set => this.WithProperty("availability_zone", value);
    }

    /// <summary>
    /// The az_mode attribute.
    /// </summary>
    public TerraformProperty<string>? AzMode
    {
        get => GetProperty<TerraformProperty<string>>("az_mode");
        set => this.WithProperty("az_mode", value);
    }

    /// <summary>
    /// The cluster_id attribute.
    /// </summary>
    public TerraformProperty<string>? ClusterId
    {
        get => GetProperty<TerraformProperty<string>>("cluster_id");
        set => this.WithProperty("cluster_id", value);
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
    /// The maintenance_window attribute.
    /// </summary>
    public TerraformProperty<string>? MaintenanceWindow
    {
        get => GetProperty<TerraformProperty<string>>("maintenance_window");
        set => this.WithProperty("maintenance_window", value);
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
    /// The num_cache_nodes attribute.
    /// </summary>
    public TerraformProperty<double>? NumCacheNodes
    {
        get => GetProperty<TerraformProperty<double>>("num_cache_nodes");
        set => this.WithProperty("num_cache_nodes", value);
    }

    /// <summary>
    /// The outpost_mode attribute.
    /// </summary>
    public TerraformProperty<string>? OutpostMode
    {
        get => GetProperty<TerraformProperty<string>>("outpost_mode");
        set => this.WithProperty("outpost_mode", value);
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
    /// The preferred_availability_zones attribute.
    /// </summary>
    public TerraformProperty<List<string>>? PreferredAvailabilityZones
    {
        get => GetProperty<TerraformProperty<List<string>>>("preferred_availability_zones");
        set => this.WithProperty("preferred_availability_zones", value);
    }

    /// <summary>
    /// The preferred_outpost_arn attribute.
    /// </summary>
    public TerraformProperty<string>? PreferredOutpostArn
    {
        get => GetProperty<TerraformProperty<string>>("preferred_outpost_arn");
        set => this.WithProperty("preferred_outpost_arn", value);
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
    /// The replication_group_id attribute.
    /// </summary>
    public TerraformProperty<string>? ReplicationGroupId
    {
        get => GetProperty<TerraformProperty<string>>("replication_group_id");
        set => this.WithProperty("replication_group_id", value);
    }

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? SecurityGroupIds
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("security_group_ids");
        set => this.WithProperty("security_group_ids", value);
    }

    /// <summary>
    /// The snapshot_arns attribute.
    /// </summary>
    public TerraformProperty<List<string>>? SnapshotArns
    {
        get => GetProperty<TerraformProperty<List<string>>>("snapshot_arns");
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
    public TerraformMapProperty<string>? Tags
    {
        get => GetProperty<TerraformMapProperty<string>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMapProperty<string>? TagsAll
    {
        get => GetProperty<TerraformMapProperty<string>>("tags_all");
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
