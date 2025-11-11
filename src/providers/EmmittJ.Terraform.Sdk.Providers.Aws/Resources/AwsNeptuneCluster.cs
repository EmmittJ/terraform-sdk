using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for serverless_v2_scaling_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsNeptuneClusterServerlessV2ScalingConfigurationBlock : TerraformBlockBase
{
    /// <summary>
    /// The max_capacity attribute.
    /// </summary>
    [TerraformProperty("max_capacity")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? MaxCapacity { get; set; }

    /// <summary>
    /// The min_capacity attribute.
    /// </summary>
    [TerraformProperty("min_capacity")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? MinCapacity { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsNeptuneClusterTimeoutsBlock : TerraformBlockBase
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
/// Manages a aws_neptune_cluster resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsNeptuneCluster : TerraformResource
{
    public AwsNeptuneCluster(string name) : base("aws_neptune_cluster", name)
    {
    }

    /// <summary>
    /// The allow_major_version_upgrade attribute.
    /// </summary>
    [TerraformProperty("allow_major_version_upgrade")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<bool> AllowMajorVersionUpgrade { get; set; }

    /// <summary>
    /// The apply_immediately attribute.
    /// </summary>
    [TerraformProperty("apply_immediately")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<bool> ApplyImmediately { get; set; }

    /// <summary>
    /// The availability_zones attribute.
    /// </summary>
    [TerraformProperty("availability_zones")]
    // Optional+Computed - source generator will implement get/set
    public TerraformSet<string> AvailabilityZones { get; set; }

    /// <summary>
    /// The backup_retention_period attribute.
    /// </summary>
    [TerraformProperty("backup_retention_period")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? BackupRetentionPeriod { get; set; }

    /// <summary>
    /// The cluster_identifier attribute.
    /// </summary>
    [TerraformProperty("cluster_identifier")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> ClusterIdentifier { get; set; }

    /// <summary>
    /// The cluster_identifier_prefix attribute.
    /// </summary>
    [TerraformProperty("cluster_identifier_prefix")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> ClusterIdentifierPrefix { get; set; }

    /// <summary>
    /// The copy_tags_to_snapshot attribute.
    /// </summary>
    [TerraformProperty("copy_tags_to_snapshot")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? CopyTagsToSnapshot { get; set; }

    /// <summary>
    /// The deletion_protection attribute.
    /// </summary>
    [TerraformProperty("deletion_protection")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? DeletionProtection { get; set; }

    /// <summary>
    /// The enable_cloudwatch_logs_exports attribute.
    /// </summary>
    [TerraformProperty("enable_cloudwatch_logs_exports")]
    // Optional argument - source generator will implement get/set
    public TerraformSet<string>? EnableCloudwatchLogsExports { get; set; }

    /// <summary>
    /// The engine attribute.
    /// </summary>
    [TerraformProperty("engine")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Engine { get; set; }

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
    /// The global_cluster_identifier attribute.
    /// </summary>
    [TerraformProperty("global_cluster_identifier")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? GlobalClusterIdentifier { get; set; }

    /// <summary>
    /// The iam_database_authentication_enabled attribute.
    /// </summary>
    [TerraformProperty("iam_database_authentication_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? IamDatabaseAuthenticationEnabled { get; set; }

    /// <summary>
    /// The iam_roles attribute.
    /// </summary>
    [TerraformProperty("iam_roles")]
    // Optional argument - source generator will implement get/set
    public TerraformSet<string>? IamRoles { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    [TerraformProperty("kms_key_arn")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> KmsKeyArn { get; set; }

    /// <summary>
    /// The neptune_cluster_parameter_group_name attribute.
    /// </summary>
    [TerraformProperty("neptune_cluster_parameter_group_name")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> NeptuneClusterParameterGroupName { get; set; }

    /// <summary>
    /// The neptune_instance_parameter_group_name attribute.
    /// </summary>
    [TerraformProperty("neptune_instance_parameter_group_name")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? NeptuneInstanceParameterGroupName { get; set; }

    /// <summary>
    /// The neptune_subnet_group_name attribute.
    /// </summary>
    [TerraformProperty("neptune_subnet_group_name")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> NeptuneSubnetGroupName { get; set; }

    /// <summary>
    /// The port attribute.
    /// </summary>
    [TerraformProperty("port")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? Port { get; set; }

    /// <summary>
    /// The preferred_backup_window attribute.
    /// </summary>
    [TerraformProperty("preferred_backup_window")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> PreferredBackupWindow { get; set; }

    /// <summary>
    /// The preferred_maintenance_window attribute.
    /// </summary>
    [TerraformProperty("preferred_maintenance_window")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> PreferredMaintenanceWindow { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The replication_source_identifier attribute.
    /// </summary>
    [TerraformProperty("replication_source_identifier")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ReplicationSourceIdentifier { get; set; }

    /// <summary>
    /// The skip_final_snapshot attribute.
    /// </summary>
    [TerraformProperty("skip_final_snapshot")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? SkipFinalSnapshot { get; set; }

    /// <summary>
    /// The snapshot_identifier attribute.
    /// </summary>
    [TerraformProperty("snapshot_identifier")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? SnapshotIdentifier { get; set; }

    /// <summary>
    /// The storage_encrypted attribute.
    /// </summary>
    [TerraformProperty("storage_encrypted")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? StorageEncrypted { get; set; }

    /// <summary>
    /// The storage_type attribute.
    /// </summary>
    [TerraformProperty("storage_type")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> StorageType { get; set; }

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
    /// The vpc_security_group_ids attribute.
    /// </summary>
    [TerraformProperty("vpc_security_group_ids")]
    // Optional+Computed - source generator will implement get/set
    public TerraformSet<string> VpcSecurityGroupIds { get; set; }

    /// <summary>
    /// Block for serverless_v2_scaling_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServerlessV2ScalingConfiguration block(s) allowed")]
    [TerraformProperty("serverless_v2_scaling_configuration")]
    public TerraformList<TerraformBlock<AwsNeptuneClusterServerlessV2ScalingConfigurationBlock>>? ServerlessV2ScalingConfiguration { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AwsNeptuneClusterTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The cluster_members attribute.
    /// </summary>
    [TerraformProperty("cluster_members")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformSet<string> ClusterMembers { get; }

    /// <summary>
    /// The cluster_resource_id attribute.
    /// </summary>
    [TerraformProperty("cluster_resource_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ClusterResourceId { get; }

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    [TerraformProperty("endpoint")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Endpoint { get; }

    /// <summary>
    /// The hosted_zone_id attribute.
    /// </summary>
    [TerraformProperty("hosted_zone_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> HostedZoneId { get; }

    /// <summary>
    /// The reader_endpoint attribute.
    /// </summary>
    [TerraformProperty("reader_endpoint")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ReaderEndpoint { get; }

}
