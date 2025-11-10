using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for log_delivery_configuration in .
/// Nesting mode: set
/// </summary>
public class AwsElasticacheReplicationGroupLogDeliveryConfigurationBlock : ITerraformBlock
{
    /// <summary>
    /// The destination attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Destination is required")]
    [TerraformPropertyName("destination")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Destination { get; set; }

    /// <summary>
    /// The destination_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DestinationType is required")]
    [TerraformPropertyName("destination_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DestinationType { get; set; }

    /// <summary>
    /// The log_format attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogFormat is required")]
    [TerraformPropertyName("log_format")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> LogFormat { get; set; }

    /// <summary>
    /// The log_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogType is required")]
    [TerraformPropertyName("log_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> LogType { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsElasticacheReplicationGroupTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a aws_elasticache_replication_group resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsElasticacheReplicationGroup : TerraformResource
{
    public AwsElasticacheReplicationGroup(string name) : base("aws_elasticache_replication_group", name)
    {
    }

    /// <summary>
    /// The apply_immediately attribute.
    /// </summary>
    [TerraformPropertyName("apply_immediately")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> ApplyImmediately { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "apply_immediately");

    /// <summary>
    /// The at_rest_encryption_enabled attribute.
    /// </summary>
    [TerraformPropertyName("at_rest_encryption_enabled")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> AtRestEncryptionEnabled { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "at_rest_encryption_enabled");

    /// <summary>
    /// The auth_token attribute.
    /// </summary>
    [TerraformPropertyName("auth_token")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? AuthToken { get; set; }

    /// <summary>
    /// The auth_token_update_strategy attribute.
    /// </summary>
    [TerraformPropertyName("auth_token_update_strategy")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? AuthTokenUpdateStrategy { get; set; }

    /// <summary>
    /// The auto_minor_version_upgrade attribute.
    /// </summary>
    [TerraformPropertyName("auto_minor_version_upgrade")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> AutoMinorVersionUpgrade { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "auto_minor_version_upgrade");

    /// <summary>
    /// The automatic_failover_enabled attribute.
    /// </summary>
    [TerraformPropertyName("automatic_failover_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? AutomaticFailoverEnabled { get; set; }

    /// <summary>
    /// The cluster_mode attribute.
    /// </summary>
    [TerraformPropertyName("cluster_mode")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ClusterMode { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "cluster_mode");

    /// <summary>
    /// The data_tiering_enabled attribute.
    /// </summary>
    [TerraformPropertyName("data_tiering_enabled")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> DataTieringEnabled { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "data_tiering_enabled");

    /// <summary>
    /// The description attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Description is required")]
    [TerraformPropertyName("description")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Description { get; set; }

    /// <summary>
    /// The engine attribute.
    /// </summary>
    [TerraformPropertyName("engine")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Engine { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "engine");

    /// <summary>
    /// The engine_version attribute.
    /// </summary>
    [TerraformPropertyName("engine_version")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> EngineVersion { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "engine_version");

    /// <summary>
    /// The final_snapshot_identifier attribute.
    /// </summary>
    [TerraformPropertyName("final_snapshot_identifier")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? FinalSnapshotIdentifier { get; set; }

    /// <summary>
    /// The global_replication_group_id attribute.
    /// </summary>
    [TerraformPropertyName("global_replication_group_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> GlobalReplicationGroupId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "global_replication_group_id");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The ip_discovery attribute.
    /// </summary>
    [TerraformPropertyName("ip_discovery")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> IpDiscovery { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "ip_discovery");

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    [TerraformPropertyName("kms_key_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? KmsKeyId { get; set; }

    /// <summary>
    /// The maintenance_window attribute.
    /// </summary>
    [TerraformPropertyName("maintenance_window")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> MaintenanceWindow { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "maintenance_window");

    /// <summary>
    /// The multi_az_enabled attribute.
    /// </summary>
    [TerraformPropertyName("multi_az_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? MultiAzEnabled { get; set; }

    /// <summary>
    /// The network_type attribute.
    /// </summary>
    [TerraformPropertyName("network_type")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> NetworkType { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "network_type");

    /// <summary>
    /// The node_type attribute.
    /// </summary>
    [TerraformPropertyName("node_type")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> NodeType { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "node_type");

    /// <summary>
    /// The notification_topic_arn attribute.
    /// </summary>
    [TerraformPropertyName("notification_topic_arn")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? NotificationTopicArn { get; set; }

    /// <summary>
    /// The num_cache_clusters attribute.
    /// </summary>
    [TerraformPropertyName("num_cache_clusters")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> NumCacheClusters { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "num_cache_clusters");

    /// <summary>
    /// The num_node_groups attribute.
    /// </summary>
    [TerraformPropertyName("num_node_groups")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> NumNodeGroups { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "num_node_groups");

    /// <summary>
    /// The parameter_group_name attribute.
    /// </summary>
    [TerraformPropertyName("parameter_group_name")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ParameterGroupName { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "parameter_group_name");

    /// <summary>
    /// The port attribute.
    /// </summary>
    [TerraformPropertyName("port")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? Port { get; set; }

    /// <summary>
    /// The preferred_cache_cluster_azs attribute.
    /// </summary>
    [TerraformPropertyName("preferred_cache_cluster_azs")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? PreferredCacheClusterAzs { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The replicas_per_node_group attribute.
    /// </summary>
    [TerraformPropertyName("replicas_per_node_group")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> ReplicasPerNodeGroup { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "replicas_per_node_group");

    /// <summary>
    /// The replication_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReplicationGroupId is required")]
    [TerraformPropertyName("replication_group_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ReplicationGroupId { get; set; }

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    [TerraformPropertyName("security_group_ids")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<HashSet<TerraformProperty<string>>> SecurityGroupIds { get; set; } = new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "security_group_ids");

    /// <summary>
    /// The security_group_names attribute.
    /// </summary>
    [TerraformPropertyName("security_group_names")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<HashSet<TerraformProperty<string>>> SecurityGroupNames { get; set; } = new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "security_group_names");

    /// <summary>
    /// The snapshot_arns attribute.
    /// </summary>
    [TerraformPropertyName("snapshot_arns")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? SnapshotArns { get; set; }

    /// <summary>
    /// The snapshot_name attribute.
    /// </summary>
    [TerraformPropertyName("snapshot_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SnapshotName { get; set; }

    /// <summary>
    /// The snapshot_retention_limit attribute.
    /// </summary>
    [TerraformPropertyName("snapshot_retention_limit")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? SnapshotRetentionLimit { get; set; }

    /// <summary>
    /// The snapshot_window attribute.
    /// </summary>
    [TerraformPropertyName("snapshot_window")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> SnapshotWindow { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "snapshot_window");

    /// <summary>
    /// The subnet_group_name attribute.
    /// </summary>
    [TerraformPropertyName("subnet_group_name")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> SubnetGroupName { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "subnet_group_name");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TagsAll { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags_all");

    /// <summary>
    /// The transit_encryption_enabled attribute.
    /// </summary>
    [TerraformPropertyName("transit_encryption_enabled")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> TransitEncryptionEnabled { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "transit_encryption_enabled");

    /// <summary>
    /// The transit_encryption_mode attribute.
    /// </summary>
    [TerraformPropertyName("transit_encryption_mode")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> TransitEncryptionMode { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "transit_encryption_mode");

    /// <summary>
    /// The user_group_ids attribute.
    /// </summary>
    [TerraformPropertyName("user_group_ids")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? UserGroupIds { get; set; }

    /// <summary>
    /// Block for log_delivery_configuration.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(2, ErrorMessage = "Maximum 2 LogDeliveryConfiguration block(s) allowed")]
    [TerraformPropertyName("log_delivery_configuration")]
    public TerraformSet<TerraformBlock<AwsElasticacheReplicationGroupLogDeliveryConfigurationBlock>>? LogDeliveryConfiguration { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsElasticacheReplicationGroupTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The cluster_enabled attribute.
    /// </summary>
    [TerraformPropertyName("cluster_enabled")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> ClusterEnabled => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "cluster_enabled");

    /// <summary>
    /// The configuration_endpoint_address attribute.
    /// </summary>
    [TerraformPropertyName("configuration_endpoint_address")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ConfigurationEndpointAddress => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "configuration_endpoint_address");

    /// <summary>
    /// The engine_version_actual attribute.
    /// </summary>
    [TerraformPropertyName("engine_version_actual")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> EngineVersionActual => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "engine_version_actual");

    /// <summary>
    /// The member_clusters attribute.
    /// </summary>
    [TerraformPropertyName("member_clusters")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<string>>> MemberClusters => new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "member_clusters");

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

}
