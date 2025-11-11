using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for log_delivery_configuration in .
/// Nesting mode: set
/// </summary>
public class AwsElasticacheClusterLogDeliveryConfigurationBlock
{
    /// <summary>
    /// The destination attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Destination is required")]
    [TerraformPropertyName("destination")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Destination { get; set; }

    /// <summary>
    /// The destination_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DestinationType is required")]
    [TerraformPropertyName("destination_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> DestinationType { get; set; }

    /// <summary>
    /// The log_format attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogFormat is required")]
    [TerraformPropertyName("log_format")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> LogFormat { get; set; }

    /// <summary>
    /// The log_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogType is required")]
    [TerraformPropertyName("log_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> LogType { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsElasticacheClusterTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a aws_elasticache_cluster resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsElasticacheCluster : TerraformResource
{
    public AwsElasticacheCluster(string name) : base("aws_elasticache_cluster", name)
    {
    }

    /// <summary>
    /// The apply_immediately attribute.
    /// </summary>
    [TerraformPropertyName("apply_immediately")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> ApplyImmediately { get; set; } = default!;

    /// <summary>
    /// The auto_minor_version_upgrade attribute.
    /// </summary>
    [TerraformPropertyName("auto_minor_version_upgrade")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? AutoMinorVersionUpgrade { get; set; }

    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    [TerraformPropertyName("availability_zone")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> AvailabilityZone { get; set; } = default!;

    /// <summary>
    /// The az_mode attribute.
    /// </summary>
    [TerraformPropertyName("az_mode")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> AzMode { get; set; } = default!;

    /// <summary>
    /// The cluster_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterId is required")]
    [TerraformPropertyName("cluster_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ClusterId { get; set; }

    /// <summary>
    /// The engine attribute.
    /// </summary>
    [TerraformPropertyName("engine")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Engine { get; set; } = default!;

    /// <summary>
    /// The engine_version attribute.
    /// </summary>
    [TerraformPropertyName("engine_version")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> EngineVersion { get; set; } = default!;

    /// <summary>
    /// The final_snapshot_identifier attribute.
    /// </summary>
    [TerraformPropertyName("final_snapshot_identifier")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? FinalSnapshotIdentifier { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The ip_discovery attribute.
    /// </summary>
    [TerraformPropertyName("ip_discovery")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> IpDiscovery { get; set; } = default!;

    /// <summary>
    /// The maintenance_window attribute.
    /// </summary>
    [TerraformPropertyName("maintenance_window")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> MaintenanceWindow { get; set; } = default!;

    /// <summary>
    /// The network_type attribute.
    /// </summary>
    [TerraformPropertyName("network_type")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> NetworkType { get; set; } = default!;

    /// <summary>
    /// The node_type attribute.
    /// </summary>
    [TerraformPropertyName("node_type")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> NodeType { get; set; } = default!;

    /// <summary>
    /// The notification_topic_arn attribute.
    /// </summary>
    [TerraformPropertyName("notification_topic_arn")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? NotificationTopicArn { get; set; }

    /// <summary>
    /// The num_cache_nodes attribute.
    /// </summary>
    [TerraformPropertyName("num_cache_nodes")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> NumCacheNodes { get; set; } = default!;

    /// <summary>
    /// The outpost_mode attribute.
    /// </summary>
    [TerraformPropertyName("outpost_mode")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? OutpostMode { get; set; }

    /// <summary>
    /// The parameter_group_name attribute.
    /// </summary>
    [TerraformPropertyName("parameter_group_name")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> ParameterGroupName { get; set; } = default!;

    /// <summary>
    /// The port attribute.
    /// </summary>
    [TerraformPropertyName("port")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> Port { get; set; } = default!;

    /// <summary>
    /// The preferred_availability_zones attribute.
    /// </summary>
    [TerraformPropertyName("preferred_availability_zones")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? PreferredAvailabilityZones { get; set; }

    /// <summary>
    /// The preferred_outpost_arn attribute.
    /// </summary>
    [TerraformPropertyName("preferred_outpost_arn")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> PreferredOutpostArn { get; set; } = default!;

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The replication_group_id attribute.
    /// </summary>
    [TerraformPropertyName("replication_group_id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> ReplicationGroupId { get; set; } = default!;

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    [TerraformPropertyName("security_group_ids")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformSet<string> SecurityGroupIds { get; set; } = default!;

    /// <summary>
    /// The snapshot_arns attribute.
    /// </summary>
    [TerraformPropertyName("snapshot_arns")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? SnapshotArns { get; set; }

    /// <summary>
    /// The snapshot_name attribute.
    /// </summary>
    [TerraformPropertyName("snapshot_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SnapshotName { get; set; }

    /// <summary>
    /// The snapshot_retention_limit attribute.
    /// </summary>
    [TerraformPropertyName("snapshot_retention_limit")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? SnapshotRetentionLimit { get; set; }

    /// <summary>
    /// The snapshot_window attribute.
    /// </summary>
    [TerraformPropertyName("snapshot_window")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> SnapshotWindow { get; set; } = default!;

    /// <summary>
    /// The subnet_group_name attribute.
    /// </summary>
    [TerraformPropertyName("subnet_group_name")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> SubnetGroupName { get; set; } = default!;

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> TagsAll { get; set; } = default!;

    /// <summary>
    /// The transit_encryption_enabled attribute.
    /// </summary>
    [TerraformPropertyName("transit_encryption_enabled")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> TransitEncryptionEnabled { get; set; } = default!;

    /// <summary>
    /// Block for log_delivery_configuration.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(2, ErrorMessage = "Maximum 2 LogDeliveryConfiguration block(s) allowed")]
    [TerraformPropertyName("log_delivery_configuration")]
    public TerraformSet<TerraformBlock<AwsElasticacheClusterLogDeliveryConfigurationBlock>>? LogDeliveryConfiguration { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsElasticacheClusterTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

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
    /// The engine_version_actual attribute.
    /// </summary>
    [TerraformPropertyName("engine_version_actual")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> EngineVersionActual => new TerraformReference(this, "engine_version_actual");

}
