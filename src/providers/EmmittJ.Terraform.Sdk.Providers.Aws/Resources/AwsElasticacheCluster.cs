using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for log_delivery_configuration in .
/// Nesting mode: set
/// </summary>
public partial class AwsElasticacheClusterLogDeliveryConfigurationBlock : TerraformBlockBase
{
    /// <summary>
    /// The destination attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Destination is required")]
    [TerraformProperty("destination")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Destination { get; set; }

    /// <summary>
    /// The destination_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DestinationType is required")]
    [TerraformProperty("destination_type")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> DestinationType { get; set; }

    /// <summary>
    /// The log_format attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogFormat is required")]
    [TerraformProperty("log_format")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> LogFormat { get; set; }

    /// <summary>
    /// The log_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogType is required")]
    [TerraformProperty("log_type")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> LogType { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsElasticacheClusterTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a aws_elasticache_cluster resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsElasticacheCluster : TerraformResource
{
    public AwsElasticacheCluster(string name) : base("aws_elasticache_cluster", name)
    {
    }

    /// <summary>
    /// The apply_immediately attribute.
    /// </summary>
    [TerraformProperty("apply_immediately")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<bool> ApplyImmediately { get; set; }

    /// <summary>
    /// The auto_minor_version_upgrade attribute.
    /// </summary>
    [TerraformProperty("auto_minor_version_upgrade")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? AutoMinorVersionUpgrade { get; set; }

    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    [TerraformProperty("availability_zone")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> AvailabilityZone { get; set; }

    /// <summary>
    /// The az_mode attribute.
    /// </summary>
    [TerraformProperty("az_mode")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> AzMode { get; set; }

    /// <summary>
    /// The cluster_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterId is required")]
    [TerraformProperty("cluster_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ClusterId { get; set; }

    /// <summary>
    /// The engine attribute.
    /// </summary>
    [TerraformProperty("engine")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Engine { get; set; }

    /// <summary>
    /// The engine_version attribute.
    /// </summary>
    [TerraformProperty("engine_version")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> EngineVersion { get; set; }

    /// <summary>
    /// The final_snapshot_identifier attribute.
    /// </summary>
    [TerraformProperty("final_snapshot_identifier")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? FinalSnapshotIdentifier { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The ip_discovery attribute.
    /// </summary>
    [TerraformProperty("ip_discovery")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> IpDiscovery { get; set; }

    /// <summary>
    /// The maintenance_window attribute.
    /// </summary>
    [TerraformProperty("maintenance_window")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> MaintenanceWindow { get; set; }

    /// <summary>
    /// The network_type attribute.
    /// </summary>
    [TerraformProperty("network_type")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> NetworkType { get; set; }

    /// <summary>
    /// The node_type attribute.
    /// </summary>
    [TerraformProperty("node_type")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> NodeType { get; set; }

    /// <summary>
    /// The notification_topic_arn attribute.
    /// </summary>
    [TerraformProperty("notification_topic_arn")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? NotificationTopicArn { get; set; }

    /// <summary>
    /// The num_cache_nodes attribute.
    /// </summary>
    [TerraformProperty("num_cache_nodes")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<double> NumCacheNodes { get; set; }

    /// <summary>
    /// The outpost_mode attribute.
    /// </summary>
    [TerraformProperty("outpost_mode")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? OutpostMode { get; set; }

    /// <summary>
    /// The parameter_group_name attribute.
    /// </summary>
    [TerraformProperty("parameter_group_name")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> ParameterGroupName { get; set; }

    /// <summary>
    /// The port attribute.
    /// </summary>
    [TerraformProperty("port")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<double> Port { get; set; }

    /// <summary>
    /// The preferred_availability_zones attribute.
    /// </summary>
    [TerraformProperty("preferred_availability_zones")]
    // Optional argument - source generator will implement get/set
    public TerraformList<string>? PreferredAvailabilityZones { get; set; }

    /// <summary>
    /// The preferred_outpost_arn attribute.
    /// </summary>
    [TerraformProperty("preferred_outpost_arn")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> PreferredOutpostArn { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The replication_group_id attribute.
    /// </summary>
    [TerraformProperty("replication_group_id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> ReplicationGroupId { get; set; }

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    [TerraformProperty("security_group_ids")]
    // Optional+Computed - source generator will implement get/set
    public TerraformSet<string> SecurityGroupIds { get; set; }

    /// <summary>
    /// The snapshot_arns attribute.
    /// </summary>
    [TerraformProperty("snapshot_arns")]
    // Optional argument - source generator will implement get/set
    public TerraformList<string>? SnapshotArns { get; set; }

    /// <summary>
    /// The snapshot_name attribute.
    /// </summary>
    [TerraformProperty("snapshot_name")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? SnapshotName { get; set; }

    /// <summary>
    /// The snapshot_retention_limit attribute.
    /// </summary>
    [TerraformProperty("snapshot_retention_limit")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? SnapshotRetentionLimit { get; set; }

    /// <summary>
    /// The snapshot_window attribute.
    /// </summary>
    [TerraformProperty("snapshot_window")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> SnapshotWindow { get; set; }

    /// <summary>
    /// The subnet_group_name attribute.
    /// </summary>
    [TerraformProperty("subnet_group_name")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> SubnetGroupName { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// The transit_encryption_enabled attribute.
    /// </summary>
    [TerraformProperty("transit_encryption_enabled")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<bool> TransitEncryptionEnabled { get; set; }

    /// <summary>
    /// Block for log_delivery_configuration.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(2, ErrorMessage = "Maximum 2 LogDeliveryConfiguration block(s) allowed")]
    [TerraformProperty("log_delivery_configuration")]
    public TerraformSet<TerraformBlock<AwsElasticacheClusterLogDeliveryConfigurationBlock>>? LogDeliveryConfiguration { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AwsElasticacheClusterTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The cache_nodes attribute.
    /// </summary>
    [TerraformProperty("cache_nodes")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> CacheNodes { get; }

    /// <summary>
    /// The cluster_address attribute.
    /// </summary>
    [TerraformProperty("cluster_address")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ClusterAddress { get; }

    /// <summary>
    /// The configuration_endpoint attribute.
    /// </summary>
    [TerraformProperty("configuration_endpoint")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ConfigurationEndpoint { get; }

    /// <summary>
    /// The engine_version_actual attribute.
    /// </summary>
    [TerraformProperty("engine_version_actual")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> EngineVersionActual { get; }

}
