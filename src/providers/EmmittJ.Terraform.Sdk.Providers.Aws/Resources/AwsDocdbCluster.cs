using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for restore_to_point_in_time in .
/// Nesting mode: list
/// </summary>
public partial class AwsDocdbClusterRestoreToPointInTimeBlock : TerraformBlockBase
{
    /// <summary>
    /// The restore_to_time attribute.
    /// </summary>
    [TerraformProperty("restore_to_time")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? RestoreToTime { get; set; }

    /// <summary>
    /// The restore_type attribute.
    /// </summary>
    [TerraformProperty("restore_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? RestoreType { get; set; }

    /// <summary>
    /// The source_cluster_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceClusterIdentifier is required")]
    [TerraformProperty("source_cluster_identifier")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> SourceClusterIdentifier { get; set; }

    /// <summary>
    /// The use_latest_restorable_time attribute.
    /// </summary>
    [TerraformProperty("use_latest_restorable_time")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? UseLatestRestorableTime { get; set; }

}

/// <summary>
/// Block type for serverless_v2_scaling_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsDocdbClusterServerlessV2ScalingConfigurationBlock : TerraformBlockBase
{
    /// <summary>
    /// The max_capacity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxCapacity is required")]
    [TerraformProperty("max_capacity")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> MaxCapacity { get; set; }

    /// <summary>
    /// The min_capacity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MinCapacity is required")]
    [TerraformProperty("min_capacity")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> MinCapacity { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsDocdbClusterTimeoutsBlock : TerraformBlockBase
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
/// Manages a aws_docdb_cluster resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsDocdbCluster : TerraformResource
{
    public AwsDocdbCluster(string name) : base("aws_docdb_cluster", name)
    {
    }

    /// <summary>
    /// The allow_major_version_upgrade attribute.
    /// </summary>
    [TerraformProperty("allow_major_version_upgrade")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? AllowMajorVersionUpgrade { get; set; }

    /// <summary>
    /// The apply_immediately attribute.
    /// </summary>
    [TerraformProperty("apply_immediately")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? ApplyImmediately { get; set; }

    /// <summary>
    /// The availability_zones attribute.
    /// </summary>
    [TerraformProperty("availability_zones")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformSet<string> AvailabilityZones { get; set; }

    /// <summary>
    /// The backup_retention_period attribute.
    /// </summary>
    [TerraformProperty("backup_retention_period")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? BackupRetentionPeriod { get; set; }

    /// <summary>
    /// The cluster_identifier attribute.
    /// </summary>
    [TerraformProperty("cluster_identifier")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> ClusterIdentifier { get; set; }

    /// <summary>
    /// The cluster_identifier_prefix attribute.
    /// </summary>
    [TerraformProperty("cluster_identifier_prefix")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> ClusterIdentifierPrefix { get; set; }

    /// <summary>
    /// The cluster_members attribute.
    /// </summary>
    [TerraformProperty("cluster_members")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformSet<string> ClusterMembers { get; set; }

    /// <summary>
    /// The db_cluster_parameter_group_name attribute.
    /// </summary>
    [TerraformProperty("db_cluster_parameter_group_name")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> DbClusterParameterGroupName { get; set; }

    /// <summary>
    /// The db_subnet_group_name attribute.
    /// </summary>
    [TerraformProperty("db_subnet_group_name")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> DbSubnetGroupName { get; set; }

    /// <summary>
    /// The deletion_protection attribute.
    /// </summary>
    [TerraformProperty("deletion_protection")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? DeletionProtection { get; set; }

    /// <summary>
    /// The enabled_cloudwatch_logs_exports attribute.
    /// </summary>
    [TerraformProperty("enabled_cloudwatch_logs_exports")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? EnabledCloudwatchLogsExports { get; set; }

    /// <summary>
    /// The engine attribute.
    /// </summary>
    [TerraformProperty("engine")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Engine { get; set; }

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
    /// The global_cluster_identifier attribute.
    /// </summary>
    [TerraformProperty("global_cluster_identifier")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? GlobalClusterIdentifier { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    [TerraformProperty("kms_key_id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> KmsKeyId { get; set; }

    /// <summary>
    /// The manage_master_user_password attribute.
    /// </summary>
    [TerraformProperty("manage_master_user_password")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? ManageMasterUserPassword { get; set; }

    /// <summary>
    /// The master_password attribute.
    /// </summary>
    [TerraformProperty("master_password")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? MasterPassword { get; set; }

    /// <summary>
    /// The master_password_wo attribute.
    /// </summary>
    [TerraformProperty("master_password_wo")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? MasterPasswordWo { get; set; }

    /// <summary>
    /// The master_password_wo_version attribute.
    /// </summary>
    [TerraformProperty("master_password_wo_version")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? MasterPasswordWoVersion { get; set; }

    /// <summary>
    /// The master_username attribute.
    /// </summary>
    [TerraformProperty("master_username")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> MasterUsername { get; set; }

    /// <summary>
    /// The port attribute.
    /// </summary>
    [TerraformProperty("port")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? Port { get; set; }

    /// <summary>
    /// The preferred_backup_window attribute.
    /// </summary>
    [TerraformProperty("preferred_backup_window")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> PreferredBackupWindow { get; set; }

    /// <summary>
    /// The preferred_maintenance_window attribute.
    /// </summary>
    [TerraformProperty("preferred_maintenance_window")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> PreferredMaintenanceWindow { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The skip_final_snapshot attribute.
    /// </summary>
    [TerraformProperty("skip_final_snapshot")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? SkipFinalSnapshot { get; set; }

    /// <summary>
    /// The snapshot_identifier attribute.
    /// </summary>
    [TerraformProperty("snapshot_identifier")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SnapshotIdentifier { get; set; }

    /// <summary>
    /// The storage_encrypted attribute.
    /// </summary>
    [TerraformProperty("storage_encrypted")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? StorageEncrypted { get; set; }

    /// <summary>
    /// The storage_type attribute.
    /// </summary>
    [TerraformProperty("storage_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? StorageType { get; set; }

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
    /// The vpc_security_group_ids attribute.
    /// </summary>
    [TerraformProperty("vpc_security_group_ids")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformSet<string> VpcSecurityGroupIds { get; set; }

    /// <summary>
    /// Block for restore_to_point_in_time.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RestoreToPointInTime block(s) allowed")]
    [TerraformProperty("restore_to_point_in_time")]
    public partial TerraformList<TerraformBlock<AwsDocdbClusterRestoreToPointInTimeBlock>>? RestoreToPointInTime { get; set; }

    /// <summary>
    /// Block for serverless_v2_scaling_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServerlessV2ScalingConfiguration block(s) allowed")]
    [TerraformProperty("serverless_v2_scaling_configuration")]
    public partial TerraformList<TerraformBlock<AwsDocdbClusterServerlessV2ScalingConfigurationBlock>>? ServerlessV2ScalingConfiguration { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AwsDocdbClusterTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The cluster_resource_id attribute.
    /// </summary>
    [TerraformProperty("cluster_resource_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ClusterResourceId { get; }

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    [TerraformProperty("endpoint")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Endpoint { get; }

    /// <summary>
    /// The hosted_zone_id attribute.
    /// </summary>
    [TerraformProperty("hosted_zone_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> HostedZoneId { get; }

    /// <summary>
    /// The master_user_secret attribute.
    /// </summary>
    [TerraformProperty("master_user_secret")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> MasterUserSecret { get; }

    /// <summary>
    /// The reader_endpoint attribute.
    /// </summary>
    [TerraformProperty("reader_endpoint")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ReaderEndpoint { get; }

}
