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
    public required TerraformProperty<TerraformProperty<string>> ClusterId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    [TerraformPropertyName("availability_zone")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> AvailabilityZone => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "availability_zone");

    /// <summary>
    /// The cache_nodes attribute.
    /// </summary>
    [TerraformPropertyName("cache_nodes")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> CacheNodes => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "cache_nodes");

    /// <summary>
    /// The cluster_address attribute.
    /// </summary>
    [TerraformPropertyName("cluster_address")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ClusterAddress => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "cluster_address");

    /// <summary>
    /// The configuration_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("configuration_endpoint")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ConfigurationEndpoint => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "configuration_endpoint");

    /// <summary>
    /// The engine attribute.
    /// </summary>
    [TerraformPropertyName("engine")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Engine => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "engine");

    /// <summary>
    /// The engine_version attribute.
    /// </summary>
    [TerraformPropertyName("engine_version")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> EngineVersion => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "engine_version");

    /// <summary>
    /// The ip_discovery attribute.
    /// </summary>
    [TerraformPropertyName("ip_discovery")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> IpDiscovery => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "ip_discovery");

    /// <summary>
    /// The log_delivery_configuration attribute.
    /// </summary>
    [TerraformPropertyName("log_delivery_configuration")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<object>>> LogDeliveryConfiguration => new TerraformReferenceProperty<HashSet<TerraformProperty<object>>>(ResourceAddress, "log_delivery_configuration");

    /// <summary>
    /// The maintenance_window attribute.
    /// </summary>
    [TerraformPropertyName("maintenance_window")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> MaintenanceWindow => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "maintenance_window");

    /// <summary>
    /// The network_type attribute.
    /// </summary>
    [TerraformPropertyName("network_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> NetworkType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "network_type");

    /// <summary>
    /// The node_type attribute.
    /// </summary>
    [TerraformPropertyName("node_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> NodeType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "node_type");

    /// <summary>
    /// The notification_topic_arn attribute.
    /// </summary>
    [TerraformPropertyName("notification_topic_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> NotificationTopicArn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "notification_topic_arn");

    /// <summary>
    /// The num_cache_nodes attribute.
    /// </summary>
    [TerraformPropertyName("num_cache_nodes")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> NumCacheNodes => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "num_cache_nodes");

    /// <summary>
    /// The parameter_group_name attribute.
    /// </summary>
    [TerraformPropertyName("parameter_group_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ParameterGroupName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "parameter_group_name");

    /// <summary>
    /// The port attribute.
    /// </summary>
    [TerraformPropertyName("port")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> Port => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "port");

    /// <summary>
    /// The preferred_outpost_arn attribute.
    /// </summary>
    [TerraformPropertyName("preferred_outpost_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PreferredOutpostArn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "preferred_outpost_arn");

    /// <summary>
    /// The replication_group_id attribute.
    /// </summary>
    [TerraformPropertyName("replication_group_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ReplicationGroupId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "replication_group_id");

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    [TerraformPropertyName("security_group_ids")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<string>>> SecurityGroupIds => new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "security_group_ids");

    /// <summary>
    /// The snapshot_retention_limit attribute.
    /// </summary>
    [TerraformPropertyName("snapshot_retention_limit")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> SnapshotRetentionLimit => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "snapshot_retention_limit");

    /// <summary>
    /// The snapshot_window attribute.
    /// </summary>
    [TerraformPropertyName("snapshot_window")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SnapshotWindow => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "snapshot_window");

    /// <summary>
    /// The subnet_group_name attribute.
    /// </summary>
    [TerraformPropertyName("subnet_group_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SubnetGroupName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "subnet_group_name");

}
