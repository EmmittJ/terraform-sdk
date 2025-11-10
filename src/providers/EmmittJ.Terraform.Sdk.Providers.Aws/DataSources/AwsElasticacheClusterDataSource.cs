using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_elasticache_cluster.
/// </summary>
public class AwsElasticacheClusterDataSource : TerraformDataSource
{
    public AwsElasticacheClusterDataSource(string name) : base("aws_elasticache_cluster", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("availability_zone");
        SetOutput("cache_nodes");
        SetOutput("cluster_address");
        SetOutput("configuration_endpoint");
        SetOutput("engine");
        SetOutput("engine_version");
        SetOutput("ip_discovery");
        SetOutput("log_delivery_configuration");
        SetOutput("maintenance_window");
        SetOutput("network_type");
        SetOutput("node_type");
        SetOutput("notification_topic_arn");
        SetOutput("num_cache_nodes");
        SetOutput("parameter_group_name");
        SetOutput("port");
        SetOutput("preferred_outpost_arn");
        SetOutput("replication_group_id");
        SetOutput("security_group_ids");
        SetOutput("snapshot_retention_limit");
        SetOutput("snapshot_window");
        SetOutput("subnet_group_name");
        SetOutput("cluster_id");
        SetOutput("id");
        SetOutput("region");
        SetOutput("tags");
    }

    /// <summary>
    /// The cluster_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterId is required")]
    public required TerraformProperty<string> ClusterId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("cluster_id");
        set => SetProperty("cluster_id", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
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
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    public TerraformExpression AvailabilityZone => this["availability_zone"];

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
    /// The engine attribute.
    /// </summary>
    public TerraformExpression Engine => this["engine"];

    /// <summary>
    /// The engine_version attribute.
    /// </summary>
    public TerraformExpression EngineVersion => this["engine_version"];

    /// <summary>
    /// The ip_discovery attribute.
    /// </summary>
    public TerraformExpression IpDiscovery => this["ip_discovery"];

    /// <summary>
    /// The log_delivery_configuration attribute.
    /// </summary>
    public TerraformExpression LogDeliveryConfiguration => this["log_delivery_configuration"];

    /// <summary>
    /// The maintenance_window attribute.
    /// </summary>
    public TerraformExpression MaintenanceWindow => this["maintenance_window"];

    /// <summary>
    /// The network_type attribute.
    /// </summary>
    public TerraformExpression NetworkType => this["network_type"];

    /// <summary>
    /// The node_type attribute.
    /// </summary>
    public TerraformExpression NodeType => this["node_type"];

    /// <summary>
    /// The notification_topic_arn attribute.
    /// </summary>
    public TerraformExpression NotificationTopicArn => this["notification_topic_arn"];

    /// <summary>
    /// The num_cache_nodes attribute.
    /// </summary>
    public TerraformExpression NumCacheNodes => this["num_cache_nodes"];

    /// <summary>
    /// The parameter_group_name attribute.
    /// </summary>
    public TerraformExpression ParameterGroupName => this["parameter_group_name"];

    /// <summary>
    /// The port attribute.
    /// </summary>
    public TerraformExpression Port => this["port"];

    /// <summary>
    /// The preferred_outpost_arn attribute.
    /// </summary>
    public TerraformExpression PreferredOutpostArn => this["preferred_outpost_arn"];

    /// <summary>
    /// The replication_group_id attribute.
    /// </summary>
    public TerraformExpression ReplicationGroupId => this["replication_group_id"];

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    public TerraformExpression SecurityGroupIds => this["security_group_ids"];

    /// <summary>
    /// The snapshot_retention_limit attribute.
    /// </summary>
    public TerraformExpression SnapshotRetentionLimit => this["snapshot_retention_limit"];

    /// <summary>
    /// The snapshot_window attribute.
    /// </summary>
    public TerraformExpression SnapshotWindow => this["snapshot_window"];

    /// <summary>
    /// The subnet_group_name attribute.
    /// </summary>
    public TerraformExpression SubnetGroupName => this["subnet_group_name"];

}
