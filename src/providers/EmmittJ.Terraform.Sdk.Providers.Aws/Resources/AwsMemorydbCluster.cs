using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsMemorydbClusterTimeoutsBlock : TerraformBlockBase
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
/// Manages a aws_memorydb_cluster resource.
/// </summary>
public partial class AwsMemorydbCluster : TerraformResource
{
    public AwsMemorydbCluster(string name) : base("aws_memorydb_cluster", name)
    {
    }

    /// <summary>
    /// The acl_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AclName is required")]
    [TerraformProperty("acl_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> AclName { get; set; }

    /// <summary>
    /// The auto_minor_version_upgrade attribute.
    /// </summary>
    [TerraformProperty("auto_minor_version_upgrade")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? AutoMinorVersionUpgrade { get; set; }

    /// <summary>
    /// The data_tiering attribute.
    /// </summary>
    [TerraformProperty("data_tiering")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? DataTiering { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

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
    /// The final_snapshot_name attribute.
    /// </summary>
    [TerraformProperty("final_snapshot_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? FinalSnapshotName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    [TerraformProperty("kms_key_arn")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? KmsKeyArn { get; set; }

    /// <summary>
    /// The maintenance_window attribute.
    /// </summary>
    [TerraformProperty("maintenance_window")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> MaintenanceWindow { get; set; }

    /// <summary>
    /// The multi_region_cluster_name attribute.
    /// </summary>
    [TerraformProperty("multi_region_cluster_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? MultiRegionClusterName { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    [TerraformProperty("name_prefix")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> NamePrefix { get; set; }

    /// <summary>
    /// The node_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NodeType is required")]
    [TerraformProperty("node_type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> NodeType { get; set; }

    /// <summary>
    /// The num_replicas_per_shard attribute.
    /// </summary>
    [TerraformProperty("num_replicas_per_shard")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? NumReplicasPerShard { get; set; }

    /// <summary>
    /// The num_shards attribute.
    /// </summary>
    [TerraformProperty("num_shards")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? NumShards { get; set; }

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
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> Port { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    [TerraformProperty("security_group_ids")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? SecurityGroupIds { get; set; }

    /// <summary>
    /// The snapshot_arns attribute.
    /// </summary>
    [TerraformProperty("snapshot_arns")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? SnapshotArns { get; set; }

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
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> SnapshotRetentionLimit { get; set; }

    /// <summary>
    /// The snapshot_window attribute.
    /// </summary>
    [TerraformProperty("snapshot_window")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> SnapshotWindow { get; set; }

    /// <summary>
    /// The sns_topic_arn attribute.
    /// </summary>
    [TerraformProperty("sns_topic_arn")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SnsTopicArn { get; set; }

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
    /// The tls_enabled attribute.
    /// </summary>
    [TerraformProperty("tls_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? TlsEnabled { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AwsMemorydbClusterTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The cluster_endpoint attribute.
    /// </summary>
    [TerraformProperty("cluster_endpoint")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> ClusterEndpoint { get; }

    /// <summary>
    /// The engine_patch_version attribute.
    /// </summary>
    [TerraformProperty("engine_patch_version")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> EnginePatchVersion { get; }

    /// <summary>
    /// The shards attribute.
    /// </summary>
    [TerraformProperty("shards")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformSet<object> Shards { get; }

}
