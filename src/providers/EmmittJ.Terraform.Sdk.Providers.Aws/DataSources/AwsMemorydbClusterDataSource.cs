using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_memorydb_cluster.
/// </summary>
public partial class AwsMemorydbClusterDataSource : TerraformDataSource
{
    public AwsMemorydbClusterDataSource(string name) : base("aws_memorydb_cluster", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

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
    /// The acl_name attribute.
    /// </summary>
    [TerraformProperty("acl_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> AclName { get; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The auto_minor_version_upgrade attribute.
    /// </summary>
    [TerraformProperty("auto_minor_version_upgrade")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> AutoMinorVersionUpgrade { get; }

    /// <summary>
    /// The cluster_endpoint attribute.
    /// </summary>
    [TerraformProperty("cluster_endpoint")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> ClusterEndpoint { get; }

    /// <summary>
    /// The data_tiering attribute.
    /// </summary>
    [TerraformProperty("data_tiering")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> DataTiering { get; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Description { get; }

    /// <summary>
    /// The engine attribute.
    /// </summary>
    [TerraformProperty("engine")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Engine { get; }

    /// <summary>
    /// The engine_patch_version attribute.
    /// </summary>
    [TerraformProperty("engine_patch_version")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> EnginePatchVersion { get; }

    /// <summary>
    /// The engine_version attribute.
    /// </summary>
    [TerraformProperty("engine_version")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> EngineVersion { get; }

    /// <summary>
    /// The final_snapshot_name attribute.
    /// </summary>
    [TerraformProperty("final_snapshot_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> FinalSnapshotName { get; }

    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    [TerraformProperty("kms_key_arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> KmsKeyArn { get; }

    /// <summary>
    /// The maintenance_window attribute.
    /// </summary>
    [TerraformProperty("maintenance_window")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> MaintenanceWindow { get; }

    /// <summary>
    /// The node_type attribute.
    /// </summary>
    [TerraformProperty("node_type")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> NodeType { get; }

    /// <summary>
    /// The num_replicas_per_shard attribute.
    /// </summary>
    [TerraformProperty("num_replicas_per_shard")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> NumReplicasPerShard { get; }

    /// <summary>
    /// The num_shards attribute.
    /// </summary>
    [TerraformProperty("num_shards")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> NumShards { get; }

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
    /// The security_group_ids attribute.
    /// </summary>
    [TerraformProperty("security_group_ids")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformSet<string> SecurityGroupIds { get; }

    /// <summary>
    /// The shards attribute.
    /// </summary>
    [TerraformProperty("shards")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformSet<object> Shards { get; }

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
    /// The sns_topic_arn attribute.
    /// </summary>
    [TerraformProperty("sns_topic_arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SnsTopicArn { get; }

    /// <summary>
    /// The subnet_group_name attribute.
    /// </summary>
    [TerraformProperty("subnet_group_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SubnetGroupName { get; }

    /// <summary>
    /// The tls_enabled attribute.
    /// </summary>
    [TerraformProperty("tls_enabled")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> TlsEnabled { get; }

}
