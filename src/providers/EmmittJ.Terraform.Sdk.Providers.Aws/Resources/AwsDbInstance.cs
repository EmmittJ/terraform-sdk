using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for blue_green_update in .
/// Nesting mode: list
/// </summary>
public class AwsDbInstanceBlueGreenUpdateBlock
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformPropertyName("enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? Enabled { get; set; }

}

/// <summary>
/// Block type for restore_to_point_in_time in .
/// Nesting mode: list
/// </summary>
public class AwsDbInstanceRestoreToPointInTimeBlock
{
    /// <summary>
    /// The restore_time attribute.
    /// </summary>
    [TerraformPropertyName("restore_time")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? RestoreTime { get; set; }

    /// <summary>
    /// The source_db_instance_automated_backups_arn attribute.
    /// </summary>
    [TerraformPropertyName("source_db_instance_automated_backups_arn")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SourceDbInstanceAutomatedBackupsArn { get; set; }

    /// <summary>
    /// The source_db_instance_identifier attribute.
    /// </summary>
    [TerraformPropertyName("source_db_instance_identifier")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SourceDbInstanceIdentifier { get; set; }

    /// <summary>
    /// The source_dbi_resource_id attribute.
    /// </summary>
    [TerraformPropertyName("source_dbi_resource_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SourceDbiResourceId { get; set; }

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
public class AwsDbInstanceS3ImportBlock
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
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsDbInstanceTimeoutsBlock
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
/// Manages a aws_db_instance resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsDbInstance : TerraformResource
{
    public AwsDbInstance(string name) : base("aws_db_instance", name)
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
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? ApplyImmediately { get; set; }

    /// <summary>
    /// The auto_minor_version_upgrade attribute.
    /// </summary>
    [TerraformPropertyName("auto_minor_version_upgrade")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? AutoMinorVersionUpgrade { get; set; }

    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    [TerraformPropertyName("availability_zone")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> AvailabilityZone { get; set; } = default!;

    /// <summary>
    /// The backup_retention_period attribute.
    /// </summary>
    [TerraformPropertyName("backup_retention_period")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> BackupRetentionPeriod { get; set; } = default!;

    /// <summary>
    /// The backup_target attribute.
    /// </summary>
    [TerraformPropertyName("backup_target")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> BackupTarget { get; set; } = default!;

    /// <summary>
    /// The backup_window attribute.
    /// </summary>
    [TerraformPropertyName("backup_window")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> BackupWindow { get; set; } = default!;

    /// <summary>
    /// The ca_cert_identifier attribute.
    /// </summary>
    [TerraformPropertyName("ca_cert_identifier")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> CaCertIdentifier { get; set; } = default!;

    /// <summary>
    /// The character_set_name attribute.
    /// </summary>
    [TerraformPropertyName("character_set_name")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> CharacterSetName { get; set; } = default!;

    /// <summary>
    /// The copy_tags_to_snapshot attribute.
    /// </summary>
    [TerraformPropertyName("copy_tags_to_snapshot")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? CopyTagsToSnapshot { get; set; }

    /// <summary>
    /// The custom_iam_instance_profile attribute.
    /// </summary>
    [TerraformPropertyName("custom_iam_instance_profile")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? CustomIamInstanceProfile { get; set; }

    /// <summary>
    /// The customer_owned_ip_enabled attribute.
    /// </summary>
    [TerraformPropertyName("customer_owned_ip_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? CustomerOwnedIpEnabled { get; set; }

    /// <summary>
    /// The database_insights_mode attribute.
    /// </summary>
    [TerraformPropertyName("database_insights_mode")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> DatabaseInsightsMode { get; set; } = default!;

    /// <summary>
    /// The db_name attribute.
    /// </summary>
    [TerraformPropertyName("db_name")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> DbName { get; set; } = default!;

    /// <summary>
    /// The db_subnet_group_name attribute.
    /// </summary>
    [TerraformPropertyName("db_subnet_group_name")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> DbSubnetGroupName { get; set; } = default!;

    /// <summary>
    /// The dedicated_log_volume attribute.
    /// </summary>
    [TerraformPropertyName("dedicated_log_volume")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? DedicatedLogVolume { get; set; }

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
    /// The domain_auth_secret_arn attribute.
    /// </summary>
    [TerraformPropertyName("domain_auth_secret_arn")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DomainAuthSecretArn { get; set; }

    /// <summary>
    /// The domain_dns_ips attribute.
    /// </summary>
    [TerraformPropertyName("domain_dns_ips")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? DomainDnsIps { get; set; }

    /// <summary>
    /// The domain_fqdn attribute.
    /// </summary>
    [TerraformPropertyName("domain_fqdn")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> DomainFqdn { get; set; } = default!;

    /// <summary>
    /// The domain_iam_role_name attribute.
    /// </summary>
    [TerraformPropertyName("domain_iam_role_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DomainIamRoleName { get; set; }

    /// <summary>
    /// The domain_ou attribute.
    /// </summary>
    [TerraformPropertyName("domain_ou")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DomainOu { get; set; }

    /// <summary>
    /// The enabled_cloudwatch_logs_exports attribute.
    /// </summary>
    [TerraformPropertyName("enabled_cloudwatch_logs_exports")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? EnabledCloudwatchLogsExports { get; set; }

    /// <summary>
    /// The engine attribute.
    /// </summary>
    [TerraformPropertyName("engine")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Engine { get; set; } = default!;

    /// <summary>
    /// The engine_lifecycle_support attribute.
    /// </summary>
    [TerraformPropertyName("engine_lifecycle_support")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> EngineLifecycleSupport { get; set; } = default!;

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
    /// The iam_database_authentication_enabled attribute.
    /// </summary>
    [TerraformPropertyName("iam_database_authentication_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? IamDatabaseAuthenticationEnabled { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The identifier attribute.
    /// </summary>
    [TerraformPropertyName("identifier")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Identifier { get; set; } = default!;

    /// <summary>
    /// The identifier_prefix attribute.
    /// </summary>
    [TerraformPropertyName("identifier_prefix")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> IdentifierPrefix { get; set; } = default!;

    /// <summary>
    /// The instance_class attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceClass is required")]
    [TerraformPropertyName("instance_class")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> InstanceClass { get; set; }

    /// <summary>
    /// The iops attribute.
    /// </summary>
    [TerraformPropertyName("iops")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> Iops { get; set; } = default!;

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    [TerraformPropertyName("kms_key_id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> KmsKeyId { get; set; } = default!;

    /// <summary>
    /// The license_model attribute.
    /// </summary>
    [TerraformPropertyName("license_model")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> LicenseModel { get; set; } = default!;

    /// <summary>
    /// The maintenance_window attribute.
    /// </summary>
    [TerraformPropertyName("maintenance_window")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> MaintenanceWindow { get; set; } = default!;

    /// <summary>
    /// The manage_master_user_password attribute.
    /// </summary>
    [TerraformPropertyName("manage_master_user_password")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? ManageMasterUserPassword { get; set; }

    /// <summary>
    /// The master_user_secret_kms_key_id attribute.
    /// </summary>
    [TerraformPropertyName("master_user_secret_kms_key_id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> MasterUserSecretKmsKeyId { get; set; } = default!;

    /// <summary>
    /// The max_allocated_storage attribute.
    /// </summary>
    [TerraformPropertyName("max_allocated_storage")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? MaxAllocatedStorage { get; set; }

    /// <summary>
    /// The monitoring_interval attribute.
    /// </summary>
    [TerraformPropertyName("monitoring_interval")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? MonitoringInterval { get; set; }

    /// <summary>
    /// The monitoring_role_arn attribute.
    /// </summary>
    [TerraformPropertyName("monitoring_role_arn")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> MonitoringRoleArn { get; set; } = default!;

    /// <summary>
    /// The multi_az attribute.
    /// </summary>
    [TerraformPropertyName("multi_az")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> MultiAz { get; set; } = default!;

    /// <summary>
    /// The nchar_character_set_name attribute.
    /// </summary>
    [TerraformPropertyName("nchar_character_set_name")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> NcharCharacterSetName { get; set; } = default!;

    /// <summary>
    /// The network_type attribute.
    /// </summary>
    [TerraformPropertyName("network_type")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> NetworkType { get; set; } = default!;

    /// <summary>
    /// The option_group_name attribute.
    /// </summary>
    [TerraformPropertyName("option_group_name")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> OptionGroupName { get; set; } = default!;

    /// <summary>
    /// The parameter_group_name attribute.
    /// </summary>
    [TerraformPropertyName("parameter_group_name")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> ParameterGroupName { get; set; } = default!;

    /// <summary>
    /// The password attribute.
    /// </summary>
    [TerraformPropertyName("password")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Password { get; set; }

    /// <summary>
    /// The password_wo attribute.
    /// </summary>
    [TerraformPropertyName("password_wo")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? PasswordWo { get; set; }

    /// <summary>
    /// The password_wo_version attribute.
    /// </summary>
    [TerraformPropertyName("password_wo_version")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? PasswordWoVersion { get; set; }

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
    /// The publicly_accessible attribute.
    /// </summary>
    [TerraformPropertyName("publicly_accessible")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? PubliclyAccessible { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The replica_mode attribute.
    /// </summary>
    [TerraformPropertyName("replica_mode")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> ReplicaMode { get; set; } = default!;

    /// <summary>
    /// The replicate_source_db attribute.
    /// </summary>
    [TerraformPropertyName("replicate_source_db")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ReplicateSourceDb { get; set; }

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
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> SnapshotIdentifier { get; set; } = default!;

    /// <summary>
    /// The storage_encrypted attribute.
    /// </summary>
    [TerraformPropertyName("storage_encrypted")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? StorageEncrypted { get; set; }

    /// <summary>
    /// The storage_throughput attribute.
    /// </summary>
    [TerraformPropertyName("storage_throughput")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> StorageThroughput { get; set; } = default!;

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
    /// The timezone attribute.
    /// </summary>
    [TerraformPropertyName("timezone")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Timezone { get; set; } = default!;

    /// <summary>
    /// The upgrade_storage_config attribute.
    /// </summary>
    [TerraformPropertyName("upgrade_storage_config")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? UpgradeStorageConfig { get; set; }

    /// <summary>
    /// The username attribute.
    /// </summary>
    [TerraformPropertyName("username")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Username { get; set; } = default!;

    /// <summary>
    /// The vpc_security_group_ids attribute.
    /// </summary>
    [TerraformPropertyName("vpc_security_group_ids")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformSet<string> VpcSecurityGroupIds { get; set; } = default!;

    /// <summary>
    /// Block for blue_green_update.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BlueGreenUpdate block(s) allowed")]
    [TerraformPropertyName("blue_green_update")]
    public TerraformList<TerraformBlock<AwsDbInstanceBlueGreenUpdateBlock>>? BlueGreenUpdate { get; set; }

    /// <summary>
    /// Block for restore_to_point_in_time.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RestoreToPointInTime block(s) allowed")]
    [TerraformPropertyName("restore_to_point_in_time")]
    public TerraformList<TerraformBlock<AwsDbInstanceRestoreToPointInTimeBlock>>? RestoreToPointInTime { get; set; }

    /// <summary>
    /// Block for s3_import.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 S3Import block(s) allowed")]
    [TerraformPropertyName("s3_import")]
    public TerraformList<TerraformBlock<AwsDbInstanceS3ImportBlock>>? S3Import { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsDbInstanceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The address attribute.
    /// </summary>
    [TerraformPropertyName("address")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Address => new TerraformReference(this, "address");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

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
    /// The latest_restorable_time attribute.
    /// </summary>
    [TerraformPropertyName("latest_restorable_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> LatestRestorableTime => new TerraformReference(this, "latest_restorable_time");

    /// <summary>
    /// The listener_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("listener_endpoint")]
    // Output-only attribute - read-only reference
    public TerraformList<object> ListenerEndpoint => new TerraformReference(this, "listener_endpoint");

    /// <summary>
    /// The master_user_secret attribute.
    /// </summary>
    [TerraformPropertyName("master_user_secret")]
    // Output-only attribute - read-only reference
    public TerraformList<object> MasterUserSecret => new TerraformReference(this, "master_user_secret");

    /// <summary>
    /// The replicas attribute.
    /// </summary>
    [TerraformPropertyName("replicas")]
    // Output-only attribute - read-only reference
    public TerraformList<string> Replicas => new TerraformReference(this, "replicas");

    /// <summary>
    /// The resource_id attribute.
    /// </summary>
    [TerraformPropertyName("resource_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ResourceId => new TerraformReference(this, "resource_id");

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Status => new TerraformReference(this, "status");

}
