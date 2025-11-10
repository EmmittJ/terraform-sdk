using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_elasticache_replication_group.
/// </summary>
public class AwsElasticacheReplicationGroupDataSource : TerraformDataSource
{
    public AwsElasticacheReplicationGroupDataSource(string name) : base("aws_elasticache_replication_group", name)
    {
    }

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
    /// The replication_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReplicationGroupId is required")]
    [TerraformPropertyName("replication_group_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ReplicationGroupId { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The auth_token_enabled attribute.
    /// </summary>
    [TerraformPropertyName("auth_token_enabled")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> AuthTokenEnabled => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "auth_token_enabled");

    /// <summary>
    /// The automatic_failover_enabled attribute.
    /// </summary>
    [TerraformPropertyName("automatic_failover_enabled")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> AutomaticFailoverEnabled => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "automatic_failover_enabled");

    /// <summary>
    /// The cluster_mode attribute.
    /// </summary>
    [TerraformPropertyName("cluster_mode")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ClusterMode => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "cluster_mode");

    /// <summary>
    /// The configuration_endpoint_address attribute.
    /// </summary>
    [TerraformPropertyName("configuration_endpoint_address")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ConfigurationEndpointAddress => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "configuration_endpoint_address");

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Description => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "description");

    /// <summary>
    /// The log_delivery_configuration attribute.
    /// </summary>
    [TerraformPropertyName("log_delivery_configuration")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<object>>> LogDeliveryConfiguration => new TerraformReferenceProperty<HashSet<TerraformProperty<object>>>(ResourceAddress, "log_delivery_configuration");

    /// <summary>
    /// The member_clusters attribute.
    /// </summary>
    [TerraformPropertyName("member_clusters")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<string>>> MemberClusters => new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "member_clusters");

    /// <summary>
    /// The multi_az_enabled attribute.
    /// </summary>
    [TerraformPropertyName("multi_az_enabled")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> MultiAzEnabled => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "multi_az_enabled");

    /// <summary>
    /// The node_type attribute.
    /// </summary>
    [TerraformPropertyName("node_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> NodeType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "node_type");

    /// <summary>
    /// The num_cache_clusters attribute.
    /// </summary>
    [TerraformPropertyName("num_cache_clusters")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> NumCacheClusters => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "num_cache_clusters");

    /// <summary>
    /// The num_node_groups attribute.
    /// </summary>
    [TerraformPropertyName("num_node_groups")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> NumNodeGroups => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "num_node_groups");

    /// <summary>
    /// The port attribute.
    /// </summary>
    [TerraformPropertyName("port")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> Port => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "port");

    /// <summary>
    /// The primary_endpoint_address attribute.
    /// </summary>
    [TerraformPropertyName("primary_endpoint_address")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PrimaryEndpointAddress => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "primary_endpoint_address");

    /// <summary>
    /// The reader_endpoint_address attribute.
    /// </summary>
    [TerraformPropertyName("reader_endpoint_address")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ReaderEndpointAddress => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "reader_endpoint_address");

    /// <summary>
    /// The replicas_per_node_group attribute.
    /// </summary>
    [TerraformPropertyName("replicas_per_node_group")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> ReplicasPerNodeGroup => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "replicas_per_node_group");

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

}
