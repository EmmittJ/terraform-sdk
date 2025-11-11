using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for restore_to_point_in_time in .
/// Nesting mode: list
/// </summary>
public class AwsRdsClusterRestoreToPointInTimeBlock
{
    /// <summary>
    /// The restore_to_time attribute.
    /// </summary>
    [TerraformPropertyName("restore_to_time")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? RestoreToTime { get; set; }

    /// <summary>
    /// The restore_type attribute.
    /// </summary>
    [TerraformPropertyName("restore_type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? RestoreType { get; set; }

    /// <summary>
    /// The source_cluster_identifier attribute.
    /// </summary>
    [TerraformPropertyName("source_cluster_identifier")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SourceClusterIdentifier { get; set; }

    /// <summary>
    /// The source_cluster_resource_id attribute.
    /// </summary>
    [TerraformPropertyName("source_cluster_resource_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SourceClusterResourceId { get; set; }

    /// <summary>
    /// The use_latest_restorable_time attribute.
    /// </summary>
    [TerraformPropertyName("use_latest_restorable_time")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? UseLatestRestorableTime { get; set; }

}

/// <summary>
/// Block type for s3_import in .
/// Nesting mode: list
/// </summary>
public class AwsRdsClusterS3ImportBlock
{
    /// <summary>
    /// The bucket_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BucketName is required")]
    [TerraformPropertyName("bucket_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> BucketName { get; set; }

    /// <summary>
    /// The bucket_prefix attribute.
    /// </summary>
    [TerraformPropertyName("bucket_prefix")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? BucketPrefix { get; set; }

    /// <summary>
    /// The ingestion_role attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IngestionRole is required")]
    [TerraformPropertyName("ingestion_role")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> IngestionRole { get; set; }

    /// <summary>
    /// The source_engine attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceEngine is required")]
    [TerraformPropertyName("source_engine")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> SourceEngine { get; set; }

    /// <summary>
    /// The source_engine_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceEngineVersion is required")]
    [TerraformPropertyName("source_engine_version")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> SourceEngineVersion { get; set; }

}

/// <summary>
/// Block type for scaling_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsRdsClusterScalingConfigurationBlock
{
    /// <summary>
    /// The auto_pause attribute.
    /// </summary>
    [TerraformPropertyName("auto_pause")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? AutoPause { get; set; }

    /// <summary>
    /// The max_capacity attribute.
    /// </summary>
    [TerraformPropertyName("max_capacity")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? MaxCapacity { get; set; }

    /// <summary>
    /// The min_capacity attribute.
    /// </summary>
    [TerraformPropertyName("min_capacity")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? MinCapacity { get; set; }

    /// <summary>
    /// The seconds_before_timeout attribute.
    /// </summary>
    [TerraformPropertyName("seconds_before_timeout")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? SecondsBeforeTimeout { get; set; }

    /// <summary>
    /// The seconds_until_auto_pause attribute.
    /// </summary>
    [TerraformPropertyName("seconds_until_auto_pause")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? SecondsUntilAutoPause { get; set; }

    /// <summary>
    /// The timeout_action attribute.
    /// </summary>
    [TerraformPropertyName("timeout_action")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? TimeoutAction { get; set; }

}

/// <summary>
/// Block type for serverlessv2_scaling_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsRdsClusterServerlessv2ScalingConfigurationBlock
{
    /// <summary>
    /// The max_capacity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxCapacity is required")]
    [TerraformPropertyName("max_capacity")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<double> MaxCapacity { get; set; }

    /// <summary>
    /// The min_capacity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MinCapacity is required")]
    [TerraformPropertyName("min_capacity")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<double> MinCapacity { get; set; }

    /// <summary>
    /// The seconds_until_auto_pause attribute.
    /// </summary>
    [TerraformPropertyName("seconds_until_auto_pause")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> SecondsUntilAutoPause { get; set; } = default!;

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsRdsClusterTimeoutsBlock
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
/// Manages a aws_rds_cluster resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsRdsCluster : TerraformResource
{
    public AwsRdsCluster(string name) : base("aws_rds_cluster", name)
    {
    }

    /// <summary>
    /// The allocated_storage attribute.
    /// </summary>
    [TerraformPropertyName("allocated_storage")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> AllocatedStorage { get; set; } = default!;

    /// <summary>
    /// The allow_major_version_upgrade attribute.
    /// </summary>
    [TerraformPropertyName("allow_major_version_upgrade")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? AllowMajorVersionUpgrade { get; set; }

    /// <summary>
    /// The apply_immediately attribute.
    /// </summary>
    [TerraformPropertyName("apply_immediately")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> ApplyImmediately { get; set; } = default!;

    /// <summary>
    /// The availability_zones attribute.
    /// </summary>
    [TerraformPropertyName("availability_zones")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformSet<string> AvailabilityZones { get; set; } = default!;

    /// <summary>
    /// The backtrack_window attribute.
    /// </summary>
    [TerraformPropertyName("backtrack_window")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? BacktrackWindow { get; set; }

    /// <summary>
    /// The backup_retention_period attribute.
    /// </summary>
    [TerraformPropertyName("backup_retention_period")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> BackupRetentionPeriod { get; set; } = default!;

    /// <summary>
    /// The ca_certificate_identifier attribute.
    /// </summary>
    [TerraformPropertyName("ca_certificate_identifier")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> CaCertificateIdentifier { get; set; } = default!;

    /// <summary>
    /// The cluster_identifier attribute.
    /// </summary>
    [TerraformPropertyName("cluster_identifier")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> ClusterIdentifier { get; set; } = default!;

    /// <summary>
    /// The cluster_identifier_prefix attribute.
    /// </summary>
    [TerraformPropertyName("cluster_identifier_prefix")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> ClusterIdentifierPrefix { get; set; } = default!;

    /// <summary>
    /// The cluster_members attribute.
    /// </summary>
    [TerraformPropertyName("cluster_members")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformSet<string> ClusterMembers { get; set; } = default!;

    /// <summary>
    /// The cluster_scalability_type attribute.
    /// </summary>
    [TerraformPropertyName("cluster_scalability_type")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> ClusterScalabilityType { get; set; } = default!;

    /// <summary>
    /// The copy_tags_to_snapshot attribute.
    /// </summary>
    [TerraformPropertyName("copy_tags_to_snapshot")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? CopyTagsToSnapshot { get; set; }

    /// <summary>
    /// The database_insights_mode attribute.
    /// </summary>
    [TerraformPropertyName("database_insights_mode")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> DatabaseInsightsMode { get; set; } = default!;

    /// <summary>
    /// The database_name attribute.
    /// </summary>
    [TerraformPropertyName("database_name")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> DatabaseName { get; set; } = default!;

    /// <summary>
    /// The db_cluster_instance_class attribute.
    /// </summary>
    [TerraformPropertyName("db_cluster_instance_class")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DbClusterInstanceClass { get; set; }

    /// <summary>
    /// The db_cluster_parameter_group_name attribute.
    /// </summary>
    [TerraformPropertyName("db_cluster_parameter_group_name")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> DbClusterParameterGroupName { get; set; } = default!;

    /// <summary>
    /// The db_instance_parameter_group_name attribute.
    /// </summary>
    [TerraformPropertyName("db_instance_parameter_group_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DbInstanceParameterGroupName { get; set; }

    /// <summary>
    /// The db_subnet_group_name attribute.
    /// </summary>
    [TerraformPropertyName("db_subnet_group_name")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> DbSubnetGroupName { get; set; } = default!;

    /// <summary>
    /// The db_system_id attribute.
    /// </summary>
    [TerraformPropertyName("db_system_id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> DbSystemId { get; set; } = default!;

    /// <summary>
    /// The delete_automated_backups attribute.
    /// </summary>
    [TerraformPropertyName("delete_automated_backups")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? DeleteAutomatedBackups { get; set; }

    /// <summary>
    /// The deletion_protection attribute.
    /// </summary>
    [TerraformPropertyName("deletion_protection")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? DeletionProtection { get; set; }

    /// <summary>
    /// The domain attribute.
    /// </summary>
    [TerraformPropertyName("domain")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Domain { get; set; }

    /// <summary>
    /// The domain_iam_role_name attribute.
    /// </summary>
    [TerraformPropertyName("domain_iam_role_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DomainIamRoleName { get; set; }

    /// <summary>
    /// The enable_global_write_forwarding attribute.
    /// </summary>
    [TerraformPropertyName("enable_global_write_forwarding")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? EnableGlobalWriteForwarding { get; set; }

    /// <summary>
    /// The enable_http_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("enable_http_endpoint")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? EnableHttpEndpoint { get; set; }

    /// <summary>
    /// The enable_local_write_forwarding attribute.
    /// </summary>
    [TerraformPropertyName("enable_local_write_forwarding")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? EnableLocalWriteForwarding { get; set; }

    /// <summary>
    /// The enabled_cloudwatch_logs_exports attribute.
    /// </summary>
    [TerraformPropertyName("enabled_cloudwatch_logs_exports")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? EnabledCloudwatchLogsExports { get; set; }

    /// <summary>
    /// The engine attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Engine is required")]
    [TerraformPropertyName("engine")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Engine { get; set; }

    /// <summary>
    /// The engine_lifecycle_support attribute.
    /// </summary>
    [TerraformPropertyName("engine_lifecycle_support")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> EngineLifecycleSupport { get; set; } = default!;

    /// <summary>
    /// The engine_mode attribute.
    /// </summary>
    [TerraformPropertyName("engine_mode")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? EngineMode { get; set; }

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
    /// The global_cluster_identifier attribute.
    /// </summary>
    [TerraformPropertyName("global_cluster_identifier")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? GlobalClusterIdentifier { get; set; }

    /// <summary>
    /// The iam_database_authentication_enabled attribute.
    /// </summary>
    [TerraformPropertyName("iam_database_authentication_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? IamDatabaseAuthenticationEnabled { get; set; }

    /// <summary>
    /// The iam_roles attribute.
    /// </summary>
    [TerraformPropertyName("iam_roles")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformSet<string> IamRoles { get; set; } = default!;

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The iops attribute.
    /// </summary>
    [TerraformPropertyName("iops")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? Iops { get; set; }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    [TerraformPropertyName("kms_key_id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> KmsKeyId { get; set; } = default!;

    /// <summary>
    /// The manage_master_user_password attribute.
    /// </summary>
    [TerraformPropertyName("manage_master_user_password")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? ManageMasterUserPassword { get; set; }

    /// <summary>
    /// The master_password attribute.
    /// </summary>
    [TerraformPropertyName("master_password")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? MasterPassword { get; set; }

    /// <summary>
    /// The master_password_wo attribute.
    /// </summary>
    [TerraformPropertyName("master_password_wo")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? MasterPasswordWo { get; set; }

    /// <summary>
    /// The master_password_wo_version attribute.
    /// </summary>
    [TerraformPropertyName("master_password_wo_version")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? MasterPasswordWoVersion { get; set; }

    /// <summary>
    /// The master_user_secret_kms_key_id attribute.
    /// </summary>
    [TerraformPropertyName("master_user_secret_kms_key_id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> MasterUserSecretKmsKeyId { get; set; } = default!;

    /// <summary>
    /// The master_username attribute.
    /// </summary>
    [TerraformPropertyName("master_username")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> MasterUsername { get; set; } = default!;

    /// <summary>
    /// The monitoring_interval attribute.
    /// </summary>
    [TerraformPropertyName("monitoring_interval")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> MonitoringInterval { get; set; } = default!;

    /// <summary>
    /// The monitoring_role_arn attribute.
    /// </summary>
    [TerraformPropertyName("monitoring_role_arn")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> MonitoringRoleArn { get; set; } = default!;

    /// <summary>
    /// The network_type attribute.
    /// </summary>
    [TerraformPropertyName("network_type")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> NetworkType { get; set; } = default!;

    /// <summary>
    /// The performance_insights_enabled attribute.
    /// </summary>
    [TerraformPropertyName("performance_insights_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? PerformanceInsightsEnabled { get; set; }

    /// <summary>
    /// The performance_insights_kms_key_id attribute.
    /// </summary>
    [TerraformPropertyName("performance_insights_kms_key_id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> PerformanceInsightsKmsKeyId { get; set; } = default!;

    /// <summary>
    /// The performance_insights_retention_period attribute.
    /// </summary>
    [TerraformPropertyName("performance_insights_retention_period")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> PerformanceInsightsRetentionPeriod { get; set; } = default!;

    /// <summary>
    /// The port attribute.
    /// </summary>
    [TerraformPropertyName("port")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> Port { get; set; } = default!;

    /// <summary>
    /// The preferred_backup_window attribute.
    /// </summary>
    [TerraformPropertyName("preferred_backup_window")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> PreferredBackupWindow { get; set; } = default!;

    /// <summary>
    /// The preferred_maintenance_window attribute.
    /// </summary>
    [TerraformPropertyName("preferred_maintenance_window")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> PreferredMaintenanceWindow { get; set; } = default!;

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The replication_source_identifier attribute.
    /// </summary>
    [TerraformPropertyName("replication_source_identifier")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ReplicationSourceIdentifier { get; set; }

    /// <summary>
    /// The skip_final_snapshot attribute.
    /// </summary>
    [TerraformPropertyName("skip_final_snapshot")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? SkipFinalSnapshot { get; set; }

    /// <summary>
    /// The snapshot_identifier attribute.
    /// </summary>
    [TerraformPropertyName("snapshot_identifier")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SnapshotIdentifier { get; set; }

    /// <summary>
    /// The source_region attribute.
    /// </summary>
    [TerraformPropertyName("source_region")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SourceRegion { get; set; }

    /// <summary>
    /// The storage_encrypted attribute.
    /// </summary>
    [TerraformPropertyName("storage_encrypted")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> StorageEncrypted { get; set; } = default!;

    /// <summary>
    /// The storage_type attribute.
    /// </summary>
    [TerraformPropertyName("storage_type")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> StorageType { get; set; } = default!;

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
    /// The vpc_security_group_ids attribute.
    /// </summary>
    [TerraformPropertyName("vpc_security_group_ids")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformSet<string> VpcSecurityGroupIds { get; set; } = default!;

    /// <summary>
    /// Block for restore_to_point_in_time.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RestoreToPointInTime block(s) allowed")]
    [TerraformPropertyName("restore_to_point_in_time")]
    public TerraformList<TerraformBlock<AwsRdsClusterRestoreToPointInTimeBlock>>? RestoreToPointInTime { get; set; }

    /// <summary>
    /// Block for s3_import.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 S3Import block(s) allowed")]
    [TerraformPropertyName("s3_import")]
    public TerraformList<TerraformBlock<AwsRdsClusterS3ImportBlock>>? S3Import { get; set; }

    /// <summary>
    /// Block for scaling_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ScalingConfiguration block(s) allowed")]
    [TerraformPropertyName("scaling_configuration")]
    public TerraformList<TerraformBlock<AwsRdsClusterScalingConfigurationBlock>>? ScalingConfiguration { get; set; }

    /// <summary>
    /// Block for serverlessv2_scaling_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Serverlessv2ScalingConfiguration block(s) allowed")]
    [TerraformPropertyName("serverlessv2_scaling_configuration")]
    public TerraformList<TerraformBlock<AwsRdsClusterServerlessv2ScalingConfigurationBlock>>? Serverlessv2ScalingConfiguration { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsRdsClusterTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The ca_certificate_valid_till attribute.
    /// </summary>
    [TerraformPropertyName("ca_certificate_valid_till")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CaCertificateValidTill => new TerraformReference(this, "ca_certificate_valid_till");

    /// <summary>
    /// The cluster_resource_id attribute.
    /// </summary>
    [TerraformPropertyName("cluster_resource_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ClusterResourceId => new TerraformReference(this, "cluster_resource_id");

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    [TerraformPropertyName("endpoint")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Endpoint => new TerraformReference(this, "endpoint");

    /// <summary>
    /// The engine_version_actual attribute.
    /// </summary>
    [TerraformPropertyName("engine_version_actual")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> EngineVersionActual => new TerraformReference(this, "engine_version_actual");

    /// <summary>
    /// The hosted_zone_id attribute.
    /// </summary>
    [TerraformPropertyName("hosted_zone_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> HostedZoneId => new TerraformReference(this, "hosted_zone_id");

    /// <summary>
    /// The master_user_secret attribute.
    /// </summary>
    [TerraformPropertyName("master_user_secret")]
    // Output-only attribute - read-only reference
    public TerraformList<object> MasterUserSecret => new TerraformReference(this, "master_user_secret");

    /// <summary>
    /// The reader_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("reader_endpoint")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ReaderEndpoint => new TerraformReference(this, "reader_endpoint");

}
