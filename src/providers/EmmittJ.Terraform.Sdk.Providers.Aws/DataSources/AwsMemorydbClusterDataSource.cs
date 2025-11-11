using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_memorydb_cluster.
/// </summary>
public class AwsMemorydbClusterDataSource : TerraformDataSource
{
    public AwsMemorydbClusterDataSource(string name) : base("aws_memorydb_cluster", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> Tags { get; set; } = default!;

    /// <summary>
    /// The acl_name attribute.
    /// </summary>
    [TerraformPropertyName("acl_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> AclName => new TerraformReference(this, "acl_name");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The auto_minor_version_upgrade attribute.
    /// </summary>
    [TerraformPropertyName("auto_minor_version_upgrade")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> AutoMinorVersionUpgrade => new TerraformReference(this, "auto_minor_version_upgrade");

    /// <summary>
    /// The cluster_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("cluster_endpoint")]
    // Output-only attribute - read-only reference
    public TerraformList<object> ClusterEndpoint => new TerraformReference(this, "cluster_endpoint");

    /// <summary>
    /// The data_tiering attribute.
    /// </summary>
    [TerraformPropertyName("data_tiering")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> DataTiering => new TerraformReference(this, "data_tiering");

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Description => new TerraformReference(this, "description");

    /// <summary>
    /// The engine attribute.
    /// </summary>
    [TerraformPropertyName("engine")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Engine => new TerraformReference(this, "engine");

    /// <summary>
    /// The engine_patch_version attribute.
    /// </summary>
    [TerraformPropertyName("engine_patch_version")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> EnginePatchVersion => new TerraformReference(this, "engine_patch_version");

    /// <summary>
    /// The engine_version attribute.
    /// </summary>
    [TerraformPropertyName("engine_version")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> EngineVersion => new TerraformReference(this, "engine_version");

    /// <summary>
    /// The final_snapshot_name attribute.
    /// </summary>
    [TerraformPropertyName("final_snapshot_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> FinalSnapshotName => new TerraformReference(this, "final_snapshot_name");

    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    [TerraformPropertyName("kms_key_arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> KmsKeyArn => new TerraformReference(this, "kms_key_arn");

    /// <summary>
    /// The maintenance_window attribute.
    /// </summary>
    [TerraformPropertyName("maintenance_window")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> MaintenanceWindow => new TerraformReference(this, "maintenance_window");

    /// <summary>
    /// The node_type attribute.
    /// </summary>
    [TerraformPropertyName("node_type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> NodeType => new TerraformReference(this, "node_type");

    /// <summary>
    /// The num_replicas_per_shard attribute.
    /// </summary>
    [TerraformPropertyName("num_replicas_per_shard")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> NumReplicasPerShard => new TerraformReference(this, "num_replicas_per_shard");

    /// <summary>
    /// The num_shards attribute.
    /// </summary>
    [TerraformPropertyName("num_shards")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> NumShards => new TerraformReference(this, "num_shards");

    /// <summary>
    /// The parameter_group_name attribute.
    /// </summary>
    [TerraformPropertyName("parameter_group_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ParameterGroupName => new TerraformReference(this, "parameter_group_name");

    /// <summary>
    /// The port attribute.
    /// </summary>
    [TerraformPropertyName("port")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> Port => new TerraformReference(this, "port");

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    [TerraformPropertyName("security_group_ids")]
    // Output-only attribute - read-only reference
    public TerraformSet<string> SecurityGroupIds => new TerraformReference(this, "security_group_ids");

    /// <summary>
    /// The shards attribute.
    /// </summary>
    [TerraformPropertyName("shards")]
    // Output-only attribute - read-only reference
    public TerraformSet<object> Shards => new TerraformReference(this, "shards");

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

    /// <summary>
    /// The sns_topic_arn attribute.
    /// </summary>
    [TerraformPropertyName("sns_topic_arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SnsTopicArn => new TerraformReference(this, "sns_topic_arn");

    /// <summary>
    /// The subnet_group_name attribute.
    /// </summary>
    [TerraformPropertyName("subnet_group_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SubnetGroupName => new TerraformReference(this, "subnet_group_name");

    /// <summary>
    /// The tls_enabled attribute.
    /// </summary>
    [TerraformPropertyName("tls_enabled")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> TlsEnabled => new TerraformReference(this, "tls_enabled");

}
