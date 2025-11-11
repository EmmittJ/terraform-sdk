using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_elasticache_replication_group.
/// </summary>
public partial class AwsElasticacheReplicationGroupDataSource : TerraformDataSource
{
    public AwsElasticacheReplicationGroupDataSource(string name) : base("aws_elasticache_replication_group", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The replication_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReplicationGroupId is required")]
    [TerraformProperty("replication_group_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ReplicationGroupId { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The auth_token_enabled attribute.
    /// </summary>
    [TerraformProperty("auth_token_enabled")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> AuthTokenEnabled { get; }

    /// <summary>
    /// The automatic_failover_enabled attribute.
    /// </summary>
    [TerraformProperty("automatic_failover_enabled")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> AutomaticFailoverEnabled { get; }

    /// <summary>
    /// The cluster_mode attribute.
    /// </summary>
    [TerraformProperty("cluster_mode")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ClusterMode { get; }

    /// <summary>
    /// The configuration_endpoint_address attribute.
    /// </summary>
    [TerraformProperty("configuration_endpoint_address")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ConfigurationEndpointAddress { get; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Description { get; }

    /// <summary>
    /// The log_delivery_configuration attribute.
    /// </summary>
    [TerraformProperty("log_delivery_configuration")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformSet<object> LogDeliveryConfiguration { get; }

    /// <summary>
    /// The member_clusters attribute.
    /// </summary>
    [TerraformProperty("member_clusters")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformSet<string> MemberClusters { get; }

    /// <summary>
    /// The multi_az_enabled attribute.
    /// </summary>
    [TerraformProperty("multi_az_enabled")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> MultiAzEnabled { get; }

    /// <summary>
    /// The node_type attribute.
    /// </summary>
    [TerraformProperty("node_type")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> NodeType { get; }

    /// <summary>
    /// The num_cache_clusters attribute.
    /// </summary>
    [TerraformProperty("num_cache_clusters")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> NumCacheClusters { get; }

    /// <summary>
    /// The num_node_groups attribute.
    /// </summary>
    [TerraformProperty("num_node_groups")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> NumNodeGroups { get; }

    /// <summary>
    /// The port attribute.
    /// </summary>
    [TerraformProperty("port")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> Port { get; }

    /// <summary>
    /// The primary_endpoint_address attribute.
    /// </summary>
    [TerraformProperty("primary_endpoint_address")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PrimaryEndpointAddress { get; }

    /// <summary>
    /// The reader_endpoint_address attribute.
    /// </summary>
    [TerraformProperty("reader_endpoint_address")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ReaderEndpointAddress { get; }

    /// <summary>
    /// The replicas_per_node_group attribute.
    /// </summary>
    [TerraformProperty("replicas_per_node_group")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> ReplicasPerNodeGroup { get; }

    /// <summary>
    /// The snapshot_retention_limit attribute.
    /// </summary>
    [TerraformProperty("snapshot_retention_limit")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> SnapshotRetentionLimit { get; }

    /// <summary>
    /// The snapshot_window attribute.
    /// </summary>
    [TerraformProperty("snapshot_window")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SnapshotWindow { get; }

}
