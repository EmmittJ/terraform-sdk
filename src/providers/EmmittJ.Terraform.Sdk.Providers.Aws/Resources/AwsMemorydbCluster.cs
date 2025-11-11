using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsMemorydbClusterTimeoutsBlock
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
/// Manages a aws_memorydb_cluster resource.
/// </summary>
public class AwsMemorydbCluster : TerraformResource
{
    public AwsMemorydbCluster(string name) : base("aws_memorydb_cluster", name)
    {
    }

    /// <summary>
    /// The acl_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AclName is required")]
    [TerraformPropertyName("acl_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> AclName { get; set; }

    /// <summary>
    /// The auto_minor_version_upgrade attribute.
    /// </summary>
    [TerraformPropertyName("auto_minor_version_upgrade")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? AutoMinorVersionUpgrade { get; set; }

    /// <summary>
    /// The data_tiering attribute.
    /// </summary>
    [TerraformPropertyName("data_tiering")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? DataTiering { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Description { get; set; }

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
    /// The final_snapshot_name attribute.
    /// </summary>
    [TerraformPropertyName("final_snapshot_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? FinalSnapshotName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    [TerraformPropertyName("kms_key_arn")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? KmsKeyArn { get; set; }

    /// <summary>
    /// The maintenance_window attribute.
    /// </summary>
    [TerraformPropertyName("maintenance_window")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> MaintenanceWindow { get; set; } = default!;

    /// <summary>
    /// The multi_region_cluster_name attribute.
    /// </summary>
    [TerraformPropertyName("multi_region_cluster_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? MultiRegionClusterName { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Name { get; set; } = default!;

    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    [TerraformPropertyName("name_prefix")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> NamePrefix { get; set; } = default!;

    /// <summary>
    /// The node_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NodeType is required")]
    [TerraformPropertyName("node_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> NodeType { get; set; }

    /// <summary>
    /// The num_replicas_per_shard attribute.
    /// </summary>
    [TerraformPropertyName("num_replicas_per_shard")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? NumReplicasPerShard { get; set; }

    /// <summary>
    /// The num_shards attribute.
    /// </summary>
    [TerraformPropertyName("num_shards")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? NumShards { get; set; }

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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    [TerraformPropertyName("security_group_ids")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? SecurityGroupIds { get; set; }

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
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> SnapshotRetentionLimit { get; set; } = default!;

    /// <summary>
    /// The snapshot_window attribute.
    /// </summary>
    [TerraformPropertyName("snapshot_window")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> SnapshotWindow { get; set; } = default!;

    /// <summary>
    /// The sns_topic_arn attribute.
    /// </summary>
    [TerraformPropertyName("sns_topic_arn")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SnsTopicArn { get; set; }

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
    /// The tls_enabled attribute.
    /// </summary>
    [TerraformPropertyName("tls_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? TlsEnabled { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsMemorydbClusterTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The cluster_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("cluster_endpoint")]
    // Output-only attribute - read-only reference
    public TerraformList<object> ClusterEndpoint => new TerraformReference(this, "cluster_endpoint");

    /// <summary>
    /// The engine_patch_version attribute.
    /// </summary>
    [TerraformPropertyName("engine_patch_version")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> EnginePatchVersion => new TerraformReference(this, "engine_patch_version");

    /// <summary>
    /// The shards attribute.
    /// </summary>
    [TerraformPropertyName("shards")]
    // Output-only attribute - read-only reference
    public TerraformSet<object> Shards => new TerraformReference(this, "shards");

}
