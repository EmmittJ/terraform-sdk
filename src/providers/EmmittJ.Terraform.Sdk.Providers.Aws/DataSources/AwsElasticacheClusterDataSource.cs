using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_elasticache_cluster Terraform data source.
/// Retrieves information about a aws_elasticache_cluster.
/// </summary>
public partial class AwsElasticacheClusterDataSource(string name) : TerraformDataSource("aws_elasticache_cluster", name)
{
    /// <summary>
    /// The cluster_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterId is required")]
    public required TerraformValue<string> ClusterId
    {
        get => GetRequiredArgument<TerraformValue<string>>("cluster_id");
        set => SetArgument("cluster_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => GetArgument<TerraformMap<string>>("tags") ?? CreateReference("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => CreateReference("arn");

    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    public TerraformValue<string> AvailabilityZone
        => CreateReference("availability_zone");

    /// <summary>
    /// The cache_nodes attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> CacheNodes
        => CreateReference("cache_nodes");

    /// <summary>
    /// The cluster_address attribute.
    /// </summary>
    public TerraformValue<string> ClusterAddress
        => CreateReference("cluster_address");

    /// <summary>
    /// The configuration_endpoint attribute.
    /// </summary>
    public TerraformValue<string> ConfigurationEndpoint
        => CreateReference("configuration_endpoint");

    /// <summary>
    /// The engine attribute.
    /// </summary>
    public TerraformValue<string> Engine
        => CreateReference("engine");

    /// <summary>
    /// The engine_version attribute.
    /// </summary>
    public TerraformValue<string> EngineVersion
        => CreateReference("engine_version");

    /// <summary>
    /// The ip_discovery attribute.
    /// </summary>
    public TerraformValue<string> IpDiscovery
        => CreateReference("ip_discovery");

    /// <summary>
    /// The log_delivery_configuration attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> LogDeliveryConfiguration
        => CreateReference("log_delivery_configuration");

    /// <summary>
    /// The maintenance_window attribute.
    /// </summary>
    public TerraformValue<string> MaintenanceWindow
        => CreateReference("maintenance_window");

    /// <summary>
    /// The network_type attribute.
    /// </summary>
    public TerraformValue<string> NetworkType
        => CreateReference("network_type");

    /// <summary>
    /// The node_type attribute.
    /// </summary>
    public TerraformValue<string> NodeType
        => CreateReference("node_type");

    /// <summary>
    /// The notification_topic_arn attribute.
    /// </summary>
    public TerraformValue<string> NotificationTopicArn
        => CreateReference("notification_topic_arn");

    /// <summary>
    /// The num_cache_nodes attribute.
    /// </summary>
    public TerraformValue<double> NumCacheNodes
        => CreateReference("num_cache_nodes");

    /// <summary>
    /// The parameter_group_name attribute.
    /// </summary>
    public TerraformValue<string> ParameterGroupName
        => CreateReference("parameter_group_name");

    /// <summary>
    /// The port attribute.
    /// </summary>
    public TerraformValue<double> Port
        => CreateReference("port");

    /// <summary>
    /// The preferred_outpost_arn attribute.
    /// </summary>
    public TerraformValue<string> PreferredOutpostArn
        => CreateReference("preferred_outpost_arn");

    /// <summary>
    /// The replication_group_id attribute.
    /// </summary>
    public TerraformValue<string> ReplicationGroupId
        => CreateReference("replication_group_id");

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    public TerraformSet<string> SecurityGroupIds
        => CreateReference("security_group_ids");

    /// <summary>
    /// The snapshot_retention_limit attribute.
    /// </summary>
    public TerraformValue<double> SnapshotRetentionLimit
        => CreateReference("snapshot_retention_limit");

    /// <summary>
    /// The snapshot_window attribute.
    /// </summary>
    public TerraformValue<string> SnapshotWindow
        => CreateReference("snapshot_window");

    /// <summary>
    /// The subnet_group_name attribute.
    /// </summary>
    public TerraformValue<string> SubnetGroupName
        => CreateReference("subnet_group_name");

}
