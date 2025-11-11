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
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The replication_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReplicationGroupId is required")]
    [TerraformPropertyName("replication_group_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ReplicationGroupId { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The auth_token_enabled attribute.
    /// </summary>
    [TerraformPropertyName("auth_token_enabled")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> AuthTokenEnabled => new TerraformReference(this, "auth_token_enabled");

    /// <summary>
    /// The automatic_failover_enabled attribute.
    /// </summary>
    [TerraformPropertyName("automatic_failover_enabled")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> AutomaticFailoverEnabled => new TerraformReference(this, "automatic_failover_enabled");

    /// <summary>
    /// The cluster_mode attribute.
    /// </summary>
    [TerraformPropertyName("cluster_mode")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ClusterMode => new TerraformReference(this, "cluster_mode");

    /// <summary>
    /// The configuration_endpoint_address attribute.
    /// </summary>
    [TerraformPropertyName("configuration_endpoint_address")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ConfigurationEndpointAddress => new TerraformReference(this, "configuration_endpoint_address");

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Description => new TerraformReference(this, "description");

    /// <summary>
    /// The log_delivery_configuration attribute.
    /// </summary>
    [TerraformPropertyName("log_delivery_configuration")]
    // Output-only attribute - read-only reference
    public TerraformSet<object> LogDeliveryConfiguration => new TerraformReference(this, "log_delivery_configuration");

    /// <summary>
    /// The member_clusters attribute.
    /// </summary>
    [TerraformPropertyName("member_clusters")]
    // Output-only attribute - read-only reference
    public TerraformSet<string> MemberClusters => new TerraformReference(this, "member_clusters");

    /// <summary>
    /// The multi_az_enabled attribute.
    /// </summary>
    [TerraformPropertyName("multi_az_enabled")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> MultiAzEnabled => new TerraformReference(this, "multi_az_enabled");

    /// <summary>
    /// The node_type attribute.
    /// </summary>
    [TerraformPropertyName("node_type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> NodeType => new TerraformReference(this, "node_type");

    /// <summary>
    /// The num_cache_clusters attribute.
    /// </summary>
    [TerraformPropertyName("num_cache_clusters")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> NumCacheClusters => new TerraformReference(this, "num_cache_clusters");

    /// <summary>
    /// The num_node_groups attribute.
    /// </summary>
    [TerraformPropertyName("num_node_groups")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> NumNodeGroups => new TerraformReference(this, "num_node_groups");

    /// <summary>
    /// The port attribute.
    /// </summary>
    [TerraformPropertyName("port")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> Port => new TerraformReference(this, "port");

    /// <summary>
    /// The primary_endpoint_address attribute.
    /// </summary>
    [TerraformPropertyName("primary_endpoint_address")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PrimaryEndpointAddress => new TerraformReference(this, "primary_endpoint_address");

    /// <summary>
    /// The reader_endpoint_address attribute.
    /// </summary>
    [TerraformPropertyName("reader_endpoint_address")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ReaderEndpointAddress => new TerraformReference(this, "reader_endpoint_address");

    /// <summary>
    /// The replicas_per_node_group attribute.
    /// </summary>
    [TerraformPropertyName("replicas_per_node_group")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> ReplicasPerNodeGroup => new TerraformReference(this, "replicas_per_node_group");

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

}
