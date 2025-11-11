using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for restore_to_point_in_time in .
/// Nesting mode: list
/// </summary>
public partial class AwsRdsClusterRestoreToPointInTimeBlock : TerraformBlockBase
{
    /// <summary>
    /// The restore_to_time attribute.
    /// </summary>
    [TerraformProperty("restore_to_time")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? RestoreToTime { get; set; }

    /// <summary>
    /// The restore_type attribute.
    /// </summary>
    [TerraformProperty("restore_type")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? RestoreType { get; set; }

    /// <summary>
    /// The source_cluster_identifier attribute.
    /// </summary>
    [TerraformProperty("source_cluster_identifier")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? SourceClusterIdentifier { get; set; }

    /// <summary>
    /// The source_cluster_resource_id attribute.
    /// </summary>
    [TerraformProperty("source_cluster_resource_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? SourceClusterResourceId { get; set; }

    /// <summary>
    /// The use_latest_restorable_time attribute.
    /// </summary>
    [TerraformProperty("use_latest_restorable_time")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? UseLatestRestorableTime { get; set; }

}

/// <summary>
/// Block type for s3_import in .
/// Nesting mode: list
/// </summary>
public partial class AwsRdsClusterS3ImportBlock : TerraformBlockBase
{
    /// <summary>
    /// The bucket_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BucketName is required")]
    [TerraformProperty("bucket_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> BucketName { get; set; }

    /// <summary>
    /// The bucket_prefix attribute.
    /// </summary>
    [TerraformProperty("bucket_prefix")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? BucketPrefix { get; set; }

    /// <summary>
    /// The ingestion_role attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IngestionRole is required")]
    [TerraformProperty("ingestion_role")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> IngestionRole { get; set; }

    /// <summary>
    /// The source_engine attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceEngine is required")]
    [TerraformProperty("source_engine")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> SourceEngine { get; set; }

    /// <summary>
    /// The source_engine_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceEngineVersion is required")]
    [TerraformProperty("source_engine_version")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> SourceEngineVersion { get; set; }

}

/// <summary>
/// Block type for scaling_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsRdsClusterScalingConfigurationBlock : TerraformBlockBase
{
    /// <summary>
    /// The auto_pause attribute.
    /// </summary>
    [TerraformProperty("auto_pause")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? AutoPause { get; set; }

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

    /// <summary>
    /// The seconds_before_timeout attribute.
    /// </summary>
    [TerraformProperty("seconds_before_timeout")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? SecondsBeforeTimeout { get; set; }

    /// <summary>
    /// The seconds_until_auto_pause attribute.
    /// </summary>
    [TerraformProperty("seconds_until_auto_pause")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? SecondsUntilAutoPause { get; set; }

    /// <summary>
    /// The timeout_action attribute.
    /// </summary>
    [TerraformProperty("timeout_action")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? TimeoutAction { get; set; }

}

/// <summary>
/// Block type for serverlessv2_scaling_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsRdsClusterServerlessv2ScalingConfigurationBlock : TerraformBlockBase
{
    /// <summary>
    /// The max_capacity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxCapacity is required")]
    [TerraformProperty("max_capacity")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<double> MaxCapacity { get; set; }

    /// <summary>
    /// The min_capacity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MinCapacity is required")]
    [TerraformProperty("min_capacity")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<double> MinCapacity { get; set; }

    /// <summary>
    /// The seconds_until_auto_pause attribute.
    /// </summary>
    [TerraformProperty("seconds_until_auto_pause")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<double> SecondsUntilAutoPause { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsRdsClusterTimeoutsBlock : TerraformBlockBase
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
/// Manages a aws_rds_cluster resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsRdsCluster : TerraformResource
{
    public AwsRdsCluster(string name) : base("aws_rds_cluster", name)
    {
    }

    /// <summary>
    /// The allocated_storage attribute.
    /// </summary>
    [TerraformProperty("allocated_storage")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<double> AllocatedStorage { get; set; }

    /// <summary>
    /// The allow_major_version_upgrade attribute.
    /// </summary>
    [TerraformProperty("allow_major_version_upgrade")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? AllowMajorVersionUpgrade { get; set; }

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
    /// The backtrack_window attribute.
    /// </summary>
    [TerraformProperty("backtrack_window")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? BacktrackWindow { get; set; }

    /// <summary>
    /// The backup_retention_period attribute.
    /// </summary>
    [TerraformProperty("backup_retention_period")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<double> BackupRetentionPeriod { get; set; }

    /// <summary>
    /// The ca_certificate_identifier attribute.
    /// </summary>
    [TerraformProperty("ca_certificate_identifier")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> CaCertificateIdentifier { get; set; }

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
    /// The cluster_members attribute.
    /// </summary>
    [TerraformProperty("cluster_members")]
    // Optional+Computed - source generator will implement get/set
    public TerraformSet<string> ClusterMembers { get; set; }

    /// <summary>
    /// The cluster_scalability_type attribute.
    /// </summary>
    [TerraformProperty("cluster_scalability_type")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> ClusterScalabilityType { get; set; }

    /// <summary>
    /// The copy_tags_to_snapshot attribute.
    /// </summary>
    [TerraformProperty("copy_tags_to_snapshot")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? CopyTagsToSnapshot { get; set; }

    /// <summary>
    /// The database_insights_mode attribute.
    /// </summary>
    [TerraformProperty("database_insights_mode")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> DatabaseInsightsMode { get; set; }

    /// <summary>
    /// The database_name attribute.
    /// </summary>
    [TerraformProperty("database_name")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> DatabaseName { get; set; }

    /// <summary>
    /// The db_cluster_instance_class attribute.
    /// </summary>
    [TerraformProperty("db_cluster_instance_class")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? DbClusterInstanceClass { get; set; }

    /// <summary>
    /// The db_cluster_parameter_group_name attribute.
    /// </summary>
    [TerraformProperty("db_cluster_parameter_group_name")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> DbClusterParameterGroupName { get; set; }

    /// <summary>
    /// The db_instance_parameter_group_name attribute.
    /// </summary>
    [TerraformProperty("db_instance_parameter_group_name")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? DbInstanceParameterGroupName { get; set; }

    /// <summary>
    /// The db_subnet_group_name attribute.
    /// </summary>
    [TerraformProperty("db_subnet_group_name")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> DbSubnetGroupName { get; set; }

    /// <summary>
    /// The db_system_id attribute.
    /// </summary>
    [TerraformProperty("db_system_id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> DbSystemId { get; set; }

    /// <summary>
    /// The delete_automated_backups attribute.
    /// </summary>
    [TerraformProperty("delete_automated_backups")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? DeleteAutomatedBackups { get; set; }

    /// <summary>
    /// The deletion_protection attribute.
    /// </summary>
    [TerraformProperty("deletion_protection")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? DeletionProtection { get; set; }

    /// <summary>
    /// The domain attribute.
    /// </summary>
    [TerraformProperty("domain")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Domain { get; set; }

    /// <summary>
    /// The domain_iam_role_name attribute.
    /// </summary>
    [TerraformProperty("domain_iam_role_name")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? DomainIamRoleName { get; set; }

    /// <summary>
    /// The enable_global_write_forwarding attribute.
    /// </summary>
    [TerraformProperty("enable_global_write_forwarding")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? EnableGlobalWriteForwarding { get; set; }

    /// <summary>
    /// The enable_http_endpoint attribute.
    /// </summary>
    [TerraformProperty("enable_http_endpoint")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? EnableHttpEndpoint { get; set; }

    /// <summary>
    /// The enable_local_write_forwarding attribute.
    /// </summary>
    [TerraformProperty("enable_local_write_forwarding")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? EnableLocalWriteForwarding { get; set; }

    /// <summary>
    /// The enabled_cloudwatch_logs_exports attribute.
    /// </summary>
    [TerraformProperty("enabled_cloudwatch_logs_exports")]
    // Optional argument - source generator will implement get/set
    public TerraformSet<string>? EnabledCloudwatchLogsExports { get; set; }

    /// <summary>
    /// The engine attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Engine is required")]
    [TerraformProperty("engine")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Engine { get; set; }

    /// <summary>
    /// The engine_lifecycle_support attribute.
    /// </summary>
    [TerraformProperty("engine_lifecycle_support")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> EngineLifecycleSupport { get; set; }

    /// <summary>
    /// The engine_mode attribute.
    /// </summary>
    [TerraformProperty("engine_mode")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? EngineMode { get; set; }

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
    // Optional+Computed - source generator will implement get/set
    public TerraformSet<string> IamRoles { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The iops attribute.
    /// </summary>
    [TerraformProperty("iops")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? Iops { get; set; }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    [TerraformProperty("kms_key_id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> KmsKeyId { get; set; }

    /// <summary>
    /// The manage_master_user_password attribute.
    /// </summary>
    [TerraformProperty("manage_master_user_password")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? ManageMasterUserPassword { get; set; }

    /// <summary>
    /// The master_password attribute.
    /// </summary>
    [TerraformProperty("master_password")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? MasterPassword { get; set; }

    /// <summary>
    /// The master_password_wo attribute.
    /// </summary>
    [TerraformProperty("master_password_wo")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? MasterPasswordWo { get; set; }

    /// <summary>
    /// The master_password_wo_version attribute.
    /// </summary>
    [TerraformProperty("master_password_wo_version")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? MasterPasswordWoVersion { get; set; }

    /// <summary>
    /// The master_user_secret_kms_key_id attribute.
    /// </summary>
    [TerraformProperty("master_user_secret_kms_key_id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> MasterUserSecretKmsKeyId { get; set; }

    /// <summary>
    /// The master_username attribute.
    /// </summary>
    [TerraformProperty("master_username")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> MasterUsername { get; set; }

    /// <summary>
    /// The monitoring_interval attribute.
    /// </summary>
    [TerraformProperty("monitoring_interval")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<double> MonitoringInterval { get; set; }

    /// <summary>
    /// The monitoring_role_arn attribute.
    /// </summary>
    [TerraformProperty("monitoring_role_arn")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> MonitoringRoleArn { get; set; }

    /// <summary>
    /// The network_type attribute.
    /// </summary>
    [TerraformProperty("network_type")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> NetworkType { get; set; }

    /// <summary>
    /// The performance_insights_enabled attribute.
    /// </summary>
    [TerraformProperty("performance_insights_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? PerformanceInsightsEnabled { get; set; }

    /// <summary>
    /// The performance_insights_kms_key_id attribute.
    /// </summary>
    [TerraformProperty("performance_insights_kms_key_id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> PerformanceInsightsKmsKeyId { get; set; }

    /// <summary>
    /// The performance_insights_retention_period attribute.
    /// </summary>
    [TerraformProperty("performance_insights_retention_period")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<double> PerformanceInsightsRetentionPeriod { get; set; }

    /// <summary>
    /// The port attribute.
    /// </summary>
    [TerraformProperty("port")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<double> Port { get; set; }

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
    /// The source_region attribute.
    /// </summary>
    [TerraformProperty("source_region")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? SourceRegion { get; set; }

    /// <summary>
    /// The storage_encrypted attribute.
    /// </summary>
    [TerraformProperty("storage_encrypted")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<bool> StorageEncrypted { get; set; }

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
    /// Block for restore_to_point_in_time.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RestoreToPointInTime block(s) allowed")]
    [TerraformProperty("restore_to_point_in_time")]
    public TerraformList<TerraformBlock<AwsRdsClusterRestoreToPointInTimeBlock>>? RestoreToPointInTime { get; set; }

    /// <summary>
    /// Block for s3_import.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 S3Import block(s) allowed")]
    [TerraformProperty("s3_import")]
    public TerraformList<TerraformBlock<AwsRdsClusterS3ImportBlock>>? S3Import { get; set; }

    /// <summary>
    /// Block for scaling_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ScalingConfiguration block(s) allowed")]
    [TerraformProperty("scaling_configuration")]
    public TerraformList<TerraformBlock<AwsRdsClusterScalingConfigurationBlock>>? ScalingConfiguration { get; set; }

    /// <summary>
    /// Block for serverlessv2_scaling_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Serverlessv2ScalingConfiguration block(s) allowed")]
    [TerraformProperty("serverlessv2_scaling_configuration")]
    public TerraformList<TerraformBlock<AwsRdsClusterServerlessv2ScalingConfigurationBlock>>? Serverlessv2ScalingConfiguration { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AwsRdsClusterTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The ca_certificate_valid_till attribute.
    /// </summary>
    [TerraformProperty("ca_certificate_valid_till")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CaCertificateValidTill { get; }

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
    /// The engine_version_actual attribute.
    /// </summary>
    [TerraformProperty("engine_version_actual")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> EngineVersionActual { get; }

    /// <summary>
    /// The hosted_zone_id attribute.
    /// </summary>
    [TerraformProperty("hosted_zone_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> HostedZoneId { get; }

    /// <summary>
    /// The master_user_secret attribute.
    /// </summary>
    [TerraformProperty("master_user_secret")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> MasterUserSecret { get; }

    /// <summary>
    /// The reader_endpoint attribute.
    /// </summary>
    [TerraformProperty("reader_endpoint")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ReaderEndpoint { get; }

}
