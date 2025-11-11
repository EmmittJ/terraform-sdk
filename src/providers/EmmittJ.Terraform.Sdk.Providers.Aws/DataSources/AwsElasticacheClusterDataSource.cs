using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_elasticache_cluster.
/// </summary>
public class AwsElasticacheClusterDataSource : TerraformDataSource
{
    public AwsElasticacheClusterDataSource(string name) : base("aws_elasticache_cluster", name)
    {
    }

    /// <summary>
    /// The cluster_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterId is required")]
    [TerraformPropertyName("cluster_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ClusterId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> Tags { get; set; } = default!;

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    [TerraformPropertyName("availability_zone")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> AvailabilityZone => new TerraformReference(this, "availability_zone");

    /// <summary>
    /// The cache_nodes attribute.
    /// </summary>
    [TerraformPropertyName("cache_nodes")]
    // Output-only attribute - read-only reference
    public TerraformList<object> CacheNodes => new TerraformReference(this, "cache_nodes");

    /// <summary>
    /// The cluster_address attribute.
    /// </summary>
    [TerraformPropertyName("cluster_address")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ClusterAddress => new TerraformReference(this, "cluster_address");

    /// <summary>
    /// The configuration_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("configuration_endpoint")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ConfigurationEndpoint => new TerraformReference(this, "configuration_endpoint");

    /// <summary>
    /// The engine attribute.
    /// </summary>
    [TerraformPropertyName("engine")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Engine => new TerraformReference(this, "engine");

    /// <summary>
    /// The engine_version attribute.
    /// </summary>
    [TerraformPropertyName("engine_version")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> EngineVersion => new TerraformReference(this, "engine_version");

    /// <summary>
    /// The ip_discovery attribute.
    /// </summary>
    [TerraformPropertyName("ip_discovery")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> IpDiscovery => new TerraformReference(this, "ip_discovery");

    /// <summary>
    /// The log_delivery_configuration attribute.
    /// </summary>
    [TerraformPropertyName("log_delivery_configuration")]
    // Output-only attribute - read-only reference
    public TerraformSet<object> LogDeliveryConfiguration => new TerraformReference(this, "log_delivery_configuration");

    /// <summary>
    /// The maintenance_window attribute.
    /// </summary>
    [TerraformPropertyName("maintenance_window")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> MaintenanceWindow => new TerraformReference(this, "maintenance_window");

    /// <summary>
    /// The network_type attribute.
    /// </summary>
    [TerraformPropertyName("network_type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> NetworkType => new TerraformReference(this, "network_type");

    /// <summary>
    /// The node_type attribute.
    /// </summary>
    [TerraformPropertyName("node_type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> NodeType => new TerraformReference(this, "node_type");

    /// <summary>
    /// The notification_topic_arn attribute.
    /// </summary>
    [TerraformPropertyName("notification_topic_arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> NotificationTopicArn => new TerraformReference(this, "notification_topic_arn");

    /// <summary>
    /// The num_cache_nodes attribute.
    /// </summary>
    [TerraformPropertyName("num_cache_nodes")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> NumCacheNodes => new TerraformReference(this, "num_cache_nodes");

    /// <summary>
    /// The parameter_group_name attribute.
    /// </summary>
    [TerraformPropertyName("parameter_group_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ParameterGroupName => new TerraformReference(this, "parameter_group_name");

    /// <summary>
    /// The port attribute.
    /// </summary>
    [TerraformPropertyName("port")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> Port => new TerraformReference(this, "port");

    /// <summary>
    /// The preferred_outpost_arn attribute.
    /// </summary>
    [TerraformPropertyName("preferred_outpost_arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PreferredOutpostArn => new TerraformReference(this, "preferred_outpost_arn");

    /// <summary>
    /// The replication_group_id attribute.
    /// </summary>
    [TerraformPropertyName("replication_group_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ReplicationGroupId => new TerraformReference(this, "replication_group_id");

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    [TerraformPropertyName("security_group_ids")]
    // Output-only attribute - read-only reference
    public TerraformSet<string> SecurityGroupIds => new TerraformReference(this, "security_group_ids");

    /// <summary>
    /// The snapshot_retention_limit attribute.
    /// </summary>
    [TerraformPropertyName("snapshot_retention_limit")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> SnapshotRetentionLimit => new TerraformReference(this, "snapshot_retention_limit");

    /// <summary>
    /// The snapshot_window attribute.
    /// </summary>
    [TerraformPropertyName("snapshot_window")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SnapshotWindow => new TerraformReference(this, "snapshot_window");

    /// <summary>
    /// The subnet_group_name attribute.
    /// </summary>
    [TerraformPropertyName("subnet_group_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SubnetGroupName => new TerraformReference(this, "subnet_group_name");

}
