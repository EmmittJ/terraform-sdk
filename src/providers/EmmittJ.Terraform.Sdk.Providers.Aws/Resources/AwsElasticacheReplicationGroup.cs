using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for log_delivery_configuration in .
/// Nesting mode: set
/// </summary>
public partial class AwsElasticacheReplicationGroupLogDeliveryConfigurationBlock() : TerraformBlock("log_delivery_configuration")
{
    /// <summary>
    /// The destination attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Destination is required")]
    [TerraformProperty("destination")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Destination { get; set; }

    /// <summary>
    /// The destination_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DestinationType is required")]
    [TerraformProperty("destination_type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DestinationType { get; set; }

    /// <summary>
    /// The log_format attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogFormat is required")]
    [TerraformProperty("log_format")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> LogFormat { get; set; }

    /// <summary>
    /// The log_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogType is required")]
    [TerraformProperty("log_type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> LogType { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsElasticacheReplicationGroupTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a aws_elasticache_replication_group resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsElasticacheReplicationGroup : TerraformResource
{
    public AwsElasticacheReplicationGroup(string name) : base("aws_elasticache_replication_group", name)
    {
    }

    /// <summary>
    /// The apply_immediately attribute.
    /// </summary>
    [TerraformProperty("apply_immediately")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> ApplyImmediately { get; set; }

    /// <summary>
    /// The at_rest_encryption_enabled attribute.
    /// </summary>
    [TerraformProperty("at_rest_encryption_enabled")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> AtRestEncryptionEnabled { get; set; }

    /// <summary>
    /// The auth_token attribute.
    /// </summary>
    [TerraformProperty("auth_token")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AuthToken { get; set; }

    /// <summary>
    /// The auth_token_update_strategy attribute.
    /// </summary>
    [TerraformProperty("auth_token_update_strategy")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AuthTokenUpdateStrategy { get; set; }

    /// <summary>
    /// The auto_minor_version_upgrade attribute.
    /// </summary>
    [TerraformProperty("auto_minor_version_upgrade")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> AutoMinorVersionUpgrade { get; set; }

    /// <summary>
    /// The automatic_failover_enabled attribute.
    /// </summary>
    [TerraformProperty("automatic_failover_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? AutomaticFailoverEnabled { get; set; }

    /// <summary>
    /// The cluster_mode attribute.
    /// </summary>
    [TerraformProperty("cluster_mode")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> ClusterMode { get; set; }

    /// <summary>
    /// The data_tiering_enabled attribute.
    /// </summary>
    [TerraformProperty("data_tiering_enabled")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> DataTieringEnabled { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Description is required")]
    [TerraformProperty("description")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Description { get; set; }

    /// <summary>
    /// The engine attribute.
    /// </summary>
    [TerraformProperty("engine")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Engine { get; set; }

    /// <summary>
    /// The engine_version attribute.
    /// </summary>
    [TerraformProperty("engine_version")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> EngineVersion { get; set; }

    /// <summary>
    /// The final_snapshot_identifier attribute.
    /// </summary>
    [TerraformProperty("final_snapshot_identifier")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? FinalSnapshotIdentifier { get; set; }

    /// <summary>
    /// The global_replication_group_id attribute.
    /// </summary>
    [TerraformProperty("global_replication_group_id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> GlobalReplicationGroupId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The ip_discovery attribute.
    /// </summary>
    [TerraformProperty("ip_discovery")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> IpDiscovery { get; set; }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    [TerraformProperty("kms_key_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? KmsKeyId { get; set; }

    /// <summary>
    /// The maintenance_window attribute.
    /// </summary>
    [TerraformProperty("maintenance_window")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> MaintenanceWindow { get; set; }

    /// <summary>
    /// The multi_az_enabled attribute.
    /// </summary>
    [TerraformProperty("multi_az_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? MultiAzEnabled { get; set; }

    /// <summary>
    /// The network_type attribute.
    /// </summary>
    [TerraformProperty("network_type")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> NetworkType { get; set; }

    /// <summary>
    /// The node_type attribute.
    /// </summary>
    [TerraformProperty("node_type")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> NodeType { get; set; }

    /// <summary>
    /// The notification_topic_arn attribute.
    /// </summary>
    [TerraformProperty("notification_topic_arn")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? NotificationTopicArn { get; set; }

    /// <summary>
    /// The num_cache_clusters attribute.
    /// </summary>
    [TerraformProperty("num_cache_clusters")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> NumCacheClusters { get; set; }

    /// <summary>
    /// The num_node_groups attribute.
    /// </summary>
    [TerraformProperty("num_node_groups")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> NumNodeGroups { get; set; }

    /// <summary>
    /// The parameter_group_name attribute.
    /// </summary>
    [TerraformProperty("parameter_group_name")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> ParameterGroupName { get; set; }

    /// <summary>
    /// The port attribute.
    /// </summary>
    [TerraformProperty("port")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? Port { get; set; }

    /// <summary>
    /// The preferred_cache_cluster_azs attribute.
    /// </summary>
    [TerraformProperty("preferred_cache_cluster_azs")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? PreferredCacheClusterAzs { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The replicas_per_node_group attribute.
    /// </summary>
    [TerraformProperty("replicas_per_node_group")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> ReplicasPerNodeGroup { get; set; }

    /// <summary>
    /// The replication_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReplicationGroupId is required")]
    [TerraformProperty("replication_group_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ReplicationGroupId { get; set; }

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    [TerraformProperty("security_group_ids")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformSet<string> SecurityGroupIds { get; set; }

    /// <summary>
    /// The security_group_names attribute.
    /// </summary>
    [TerraformProperty("security_group_names")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformSet<string> SecurityGroupNames { get; set; }

    /// <summary>
    /// The snapshot_arns attribute.
    /// </summary>
    [TerraformProperty("snapshot_arns")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? SnapshotArns { get; set; }

    /// <summary>
    /// The snapshot_name attribute.
    /// </summary>
    [TerraformProperty("snapshot_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SnapshotName { get; set; }

    /// <summary>
    /// The snapshot_retention_limit attribute.
    /// </summary>
    [TerraformProperty("snapshot_retention_limit")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? SnapshotRetentionLimit { get; set; }

    /// <summary>
    /// The snapshot_window attribute.
    /// </summary>
    [TerraformProperty("snapshot_window")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> SnapshotWindow { get; set; }

    /// <summary>
    /// The subnet_group_name attribute.
    /// </summary>
    [TerraformProperty("subnet_group_name")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> SubnetGroupName { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// The transit_encryption_enabled attribute.
    /// </summary>
    [TerraformProperty("transit_encryption_enabled")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> TransitEncryptionEnabled { get; set; }

    /// <summary>
    /// The transit_encryption_mode attribute.
    /// </summary>
    [TerraformProperty("transit_encryption_mode")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> TransitEncryptionMode { get; set; }

    /// <summary>
    /// The user_group_ids attribute.
    /// </summary>
    [TerraformProperty("user_group_ids")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? UserGroupIds { get; set; }

    /// <summary>
    /// Block for log_delivery_configuration.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(2, ErrorMessage = "Maximum 2 LogDeliveryConfiguration block(s) allowed")]
    [TerraformProperty("log_delivery_configuration")]
    public TerraformSet<AwsElasticacheReplicationGroupLogDeliveryConfigurationBlock> LogDeliveryConfiguration { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AwsElasticacheReplicationGroupTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The cluster_enabled attribute.
    /// </summary>
    [TerraformProperty("cluster_enabled")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> ClusterEnabled { get; }

    /// <summary>
    /// The configuration_endpoint_address attribute.
    /// </summary>
    [TerraformProperty("configuration_endpoint_address")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ConfigurationEndpointAddress { get; }

    /// <summary>
    /// The engine_version_actual attribute.
    /// </summary>
    [TerraformProperty("engine_version_actual")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> EngineVersionActual { get; }

    /// <summary>
    /// The member_clusters attribute.
    /// </summary>
    [TerraformProperty("member_clusters")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformSet<string> MemberClusters { get; }

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

}
