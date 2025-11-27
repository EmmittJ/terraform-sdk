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
        get => new TerraformReference<string>(this, "cluster_id");
        set => SetArgument("cluster_id", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    public TerraformValue<string> AvailabilityZone
    {
        get => new TerraformReference<string>(this, "availability_zone");
    }

    /// <summary>
    /// The cache_nodes attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> CacheNodes
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "cache_nodes").ResolveNodes(ctx));
    }

    /// <summary>
    /// The cluster_address attribute.
    /// </summary>
    public TerraformValue<string> ClusterAddress
    {
        get => new TerraformReference<string>(this, "cluster_address");
    }

    /// <summary>
    /// The configuration_endpoint attribute.
    /// </summary>
    public TerraformValue<string> ConfigurationEndpoint
    {
        get => new TerraformReference<string>(this, "configuration_endpoint");
    }

    /// <summary>
    /// The engine attribute.
    /// </summary>
    public TerraformValue<string> Engine
    {
        get => new TerraformReference<string>(this, "engine");
    }

    /// <summary>
    /// The engine_version attribute.
    /// </summary>
    public TerraformValue<string> EngineVersion
    {
        get => new TerraformReference<string>(this, "engine_version");
    }

    /// <summary>
    /// The ip_discovery attribute.
    /// </summary>
    public TerraformValue<string> IpDiscovery
    {
        get => new TerraformReference<string>(this, "ip_discovery");
    }

    /// <summary>
    /// The log_delivery_configuration attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> LogDeliveryConfiguration
    {
        get => TerraformSet<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformSet<TerraformMap<object>>>(this, "log_delivery_configuration").ResolveNodes(ctx));
    }

    /// <summary>
    /// The maintenance_window attribute.
    /// </summary>
    public TerraformValue<string> MaintenanceWindow
    {
        get => new TerraformReference<string>(this, "maintenance_window");
    }

    /// <summary>
    /// The network_type attribute.
    /// </summary>
    public TerraformValue<string> NetworkType
    {
        get => new TerraformReference<string>(this, "network_type");
    }

    /// <summary>
    /// The node_type attribute.
    /// </summary>
    public TerraformValue<string> NodeType
    {
        get => new TerraformReference<string>(this, "node_type");
    }

    /// <summary>
    /// The notification_topic_arn attribute.
    /// </summary>
    public TerraformValue<string> NotificationTopicArn
    {
        get => new TerraformReference<string>(this, "notification_topic_arn");
    }

    /// <summary>
    /// The num_cache_nodes attribute.
    /// </summary>
    public TerraformValue<double> NumCacheNodes
    {
        get => new TerraformReference<double>(this, "num_cache_nodes");
    }

    /// <summary>
    /// The parameter_group_name attribute.
    /// </summary>
    public TerraformValue<string> ParameterGroupName
    {
        get => new TerraformReference<string>(this, "parameter_group_name");
    }

    /// <summary>
    /// The port attribute.
    /// </summary>
    public TerraformValue<double> Port
    {
        get => new TerraformReference<double>(this, "port");
    }

    /// <summary>
    /// The preferred_outpost_arn attribute.
    /// </summary>
    public TerraformValue<string> PreferredOutpostArn
    {
        get => new TerraformReference<string>(this, "preferred_outpost_arn");
    }

    /// <summary>
    /// The replication_group_id attribute.
    /// </summary>
    public TerraformValue<string> ReplicationGroupId
    {
        get => new TerraformReference<string>(this, "replication_group_id");
    }

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    public TerraformSet<string> SecurityGroupIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "security_group_ids").ResolveNodes(ctx));
    }

    /// <summary>
    /// The snapshot_retention_limit attribute.
    /// </summary>
    public TerraformValue<double> SnapshotRetentionLimit
    {
        get => new TerraformReference<double>(this, "snapshot_retention_limit");
    }

    /// <summary>
    /// The snapshot_window attribute.
    /// </summary>
    public TerraformValue<string> SnapshotWindow
    {
        get => new TerraformReference<string>(this, "snapshot_window");
    }

    /// <summary>
    /// The subnet_group_name attribute.
    /// </summary>
    public TerraformValue<string> SubnetGroupName
    {
        get => new TerraformReference<string>(this, "subnet_group_name");
    }

}
