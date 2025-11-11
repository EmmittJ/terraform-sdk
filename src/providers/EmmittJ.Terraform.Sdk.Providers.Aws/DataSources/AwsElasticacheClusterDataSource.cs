using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_elasticache_cluster.
/// </summary>
public partial class AwsElasticacheClusterDataSource : TerraformDataSource
{
    public AwsElasticacheClusterDataSource(string name) : base("aws_elasticache_cluster", name)
    {
    }

    /// <summary>
    /// The cluster_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterId is required")]
    [TerraformProperty("cluster_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ClusterId { get; set; }

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
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> Tags { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    [TerraformProperty("availability_zone")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> AvailabilityZone { get; }

    /// <summary>
    /// The cache_nodes attribute.
    /// </summary>
    [TerraformProperty("cache_nodes")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> CacheNodes { get; }

    /// <summary>
    /// The cluster_address attribute.
    /// </summary>
    [TerraformProperty("cluster_address")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ClusterAddress { get; }

    /// <summary>
    /// The configuration_endpoint attribute.
    /// </summary>
    [TerraformProperty("configuration_endpoint")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ConfigurationEndpoint { get; }

    /// <summary>
    /// The engine attribute.
    /// </summary>
    [TerraformProperty("engine")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Engine { get; }

    /// <summary>
    /// The engine_version attribute.
    /// </summary>
    [TerraformProperty("engine_version")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> EngineVersion { get; }

    /// <summary>
    /// The ip_discovery attribute.
    /// </summary>
    [TerraformProperty("ip_discovery")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> IpDiscovery { get; }

    /// <summary>
    /// The log_delivery_configuration attribute.
    /// </summary>
    [TerraformProperty("log_delivery_configuration")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformSet<object> LogDeliveryConfiguration { get; }

    /// <summary>
    /// The maintenance_window attribute.
    /// </summary>
    [TerraformProperty("maintenance_window")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> MaintenanceWindow { get; }

    /// <summary>
    /// The network_type attribute.
    /// </summary>
    [TerraformProperty("network_type")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> NetworkType { get; }

    /// <summary>
    /// The node_type attribute.
    /// </summary>
    [TerraformProperty("node_type")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> NodeType { get; }

    /// <summary>
    /// The notification_topic_arn attribute.
    /// </summary>
    [TerraformProperty("notification_topic_arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> NotificationTopicArn { get; }

    /// <summary>
    /// The num_cache_nodes attribute.
    /// </summary>
    [TerraformProperty("num_cache_nodes")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> NumCacheNodes { get; }

    /// <summary>
    /// The parameter_group_name attribute.
    /// </summary>
    [TerraformProperty("parameter_group_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ParameterGroupName { get; }

    /// <summary>
    /// The port attribute.
    /// </summary>
    [TerraformProperty("port")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> Port { get; }

    /// <summary>
    /// The preferred_outpost_arn attribute.
    /// </summary>
    [TerraformProperty("preferred_outpost_arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PreferredOutpostArn { get; }

    /// <summary>
    /// The replication_group_id attribute.
    /// </summary>
    [TerraformProperty("replication_group_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ReplicationGroupId { get; }

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    [TerraformProperty("security_group_ids")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformSet<string> SecurityGroupIds { get; }

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

    /// <summary>
    /// The subnet_group_name attribute.
    /// </summary>
    [TerraformProperty("subnet_group_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SubnetGroupName { get; }

}
