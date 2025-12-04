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
        get => GetArgument<TerraformValue<string>>("cluster_id");
        set => SetArgument("cluster_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
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
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    public TerraformValue<string> AvailabilityZone
        => AsReference("availability_zone");

    /// <summary>
    /// The cache_nodes attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> CacheNodes
        => AsReference("cache_nodes");

    /// <summary>
    /// The cluster_address attribute.
    /// </summary>
    public TerraformValue<string> ClusterAddress
        => AsReference("cluster_address");

    /// <summary>
    /// The configuration_endpoint attribute.
    /// </summary>
    public TerraformValue<string> ConfigurationEndpoint
        => AsReference("configuration_endpoint");

    /// <summary>
    /// The engine attribute.
    /// </summary>
    public TerraformValue<string> Engine
        => AsReference("engine");

    /// <summary>
    /// The engine_version attribute.
    /// </summary>
    public TerraformValue<string> EngineVersion
        => AsReference("engine_version");

    /// <summary>
    /// The ip_discovery attribute.
    /// </summary>
    public TerraformValue<string> IpDiscovery
        => AsReference("ip_discovery");

    /// <summary>
    /// The log_delivery_configuration attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> LogDeliveryConfiguration
        => AsReference("log_delivery_configuration");

    /// <summary>
    /// The maintenance_window attribute.
    /// </summary>
    public TerraformValue<string> MaintenanceWindow
        => AsReference("maintenance_window");

    /// <summary>
    /// The network_type attribute.
    /// </summary>
    public TerraformValue<string> NetworkType
        => AsReference("network_type");

    /// <summary>
    /// The node_type attribute.
    /// </summary>
    public TerraformValue<string> NodeType
        => AsReference("node_type");

    /// <summary>
    /// The notification_topic_arn attribute.
    /// </summary>
    public TerraformValue<string> NotificationTopicArn
        => AsReference("notification_topic_arn");

    /// <summary>
    /// The num_cache_nodes attribute.
    /// </summary>
    public TerraformValue<double> NumCacheNodes
        => AsReference("num_cache_nodes");

    /// <summary>
    /// The parameter_group_name attribute.
    /// </summary>
    public TerraformValue<string> ParameterGroupName
        => AsReference("parameter_group_name");

    /// <summary>
    /// The port attribute.
    /// </summary>
    public TerraformValue<double> Port
        => AsReference("port");

    /// <summary>
    /// The preferred_outpost_arn attribute.
    /// </summary>
    public TerraformValue<string> PreferredOutpostArn
        => AsReference("preferred_outpost_arn");

    /// <summary>
    /// The replication_group_id attribute.
    /// </summary>
    public TerraformValue<string> ReplicationGroupId
        => AsReference("replication_group_id");

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    public TerraformSet<string> SecurityGroupIds
        => AsReference("security_group_ids");

    /// <summary>
    /// The snapshot_retention_limit attribute.
    /// </summary>
    public TerraformValue<double> SnapshotRetentionLimit
        => AsReference("snapshot_retention_limit");

    /// <summary>
    /// The snapshot_window attribute.
    /// </summary>
    public TerraformValue<string> SnapshotWindow
        => AsReference("snapshot_window");

    /// <summary>
    /// The subnet_group_name attribute.
    /// </summary>
    public TerraformValue<string> SubnetGroupName
        => AsReference("subnet_group_name");

}
