using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for blue_green_update in .
/// Nesting mode: list
/// </summary>
public partial class AwsDbInstanceBlueGreenUpdateBlock : TerraformBlockBase
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformProperty("enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Enabled { get; set; }

}

/// <summary>
/// Block type for restore_to_point_in_time in .
/// Nesting mode: list
/// </summary>
public partial class AwsDbInstanceRestoreToPointInTimeBlock : TerraformBlockBase
{
    /// <summary>
    /// The restore_time attribute.
    /// </summary>
    [TerraformProperty("restore_time")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? RestoreTime { get; set; }

    /// <summary>
    /// The source_db_instance_automated_backups_arn attribute.
    /// </summary>
    [TerraformProperty("source_db_instance_automated_backups_arn")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SourceDbInstanceAutomatedBackupsArn { get; set; }

    /// <summary>
    /// The source_db_instance_identifier attribute.
    /// </summary>
    [TerraformProperty("source_db_instance_identifier")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SourceDbInstanceIdentifier { get; set; }

    /// <summary>
    /// The source_dbi_resource_id attribute.
    /// </summary>
    [TerraformProperty("source_dbi_resource_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SourceDbiResourceId { get; set; }

    /// <summary>
    /// The use_latest_restorable_time attribute.
    /// </summary>
    [TerraformProperty("use_latest_restorable_time")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? UseLatestRestorableTime { get; set; }

}

/// <summary>
/// Block type for s3_import in .
/// Nesting mode: list
/// </summary>
public partial class AwsDbInstanceS3ImportBlock : TerraformBlockBase
{
    /// <summary>
    /// The bucket_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BucketName is required")]
    [TerraformProperty("bucket_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> BucketName { get; set; }

    /// <summary>
    /// The bucket_prefix attribute.
    /// </summary>
    [TerraformProperty("bucket_prefix")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? BucketPrefix { get; set; }

    /// <summary>
    /// The ingestion_role attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IngestionRole is required")]
    [TerraformProperty("ingestion_role")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> IngestionRole { get; set; }

    /// <summary>
    /// The source_engine attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceEngine is required")]
    [TerraformProperty("source_engine")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> SourceEngine { get; set; }

    /// <summary>
    /// The source_engine_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceEngineVersion is required")]
    [TerraformProperty("source_engine_version")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> SourceEngineVersion { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsDbInstanceTimeoutsBlock : TerraformBlockBase
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
/// Manages a aws_db_instance resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsDbInstance : TerraformResource
{
    public AwsDbInstance(string name) : base("aws_db_instance", name)
    {
    }

    /// <summary>
    /// The allocated_storage attribute.
    /// </summary>
    [TerraformProperty("allocated_storage")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> AllocatedStorage { get; set; }

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
    /// The auto_minor_version_upgrade attribute.
    /// </summary>
    [TerraformProperty("auto_minor_version_upgrade")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? AutoMinorVersionUpgrade { get; set; }

    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    [TerraformProperty("availability_zone")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> AvailabilityZone { get; set; }

    /// <summary>
    /// The backup_retention_period attribute.
    /// </summary>
    [TerraformProperty("backup_retention_period")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> BackupRetentionPeriod { get; set; }

    /// <summary>
    /// The backup_target attribute.
    /// </summary>
    [TerraformProperty("backup_target")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> BackupTarget { get; set; }

    /// <summary>
    /// The backup_window attribute.
    /// </summary>
    [TerraformProperty("backup_window")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> BackupWindow { get; set; }

    /// <summary>
    /// The ca_cert_identifier attribute.
    /// </summary>
    [TerraformProperty("ca_cert_identifier")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> CaCertIdentifier { get; set; }

    /// <summary>
    /// The character_set_name attribute.
    /// </summary>
    [TerraformProperty("character_set_name")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> CharacterSetName { get; set; }

    /// <summary>
    /// The copy_tags_to_snapshot attribute.
    /// </summary>
    [TerraformProperty("copy_tags_to_snapshot")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? CopyTagsToSnapshot { get; set; }

    /// <summary>
    /// The custom_iam_instance_profile attribute.
    /// </summary>
    [TerraformProperty("custom_iam_instance_profile")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? CustomIamInstanceProfile { get; set; }

    /// <summary>
    /// The customer_owned_ip_enabled attribute.
    /// </summary>
    [TerraformProperty("customer_owned_ip_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? CustomerOwnedIpEnabled { get; set; }

    /// <summary>
    /// The database_insights_mode attribute.
    /// </summary>
    [TerraformProperty("database_insights_mode")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> DatabaseInsightsMode { get; set; }

    /// <summary>
    /// The db_name attribute.
    /// </summary>
    [TerraformProperty("db_name")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> DbName { get; set; }

    /// <summary>
    /// The db_subnet_group_name attribute.
    /// </summary>
    [TerraformProperty("db_subnet_group_name")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> DbSubnetGroupName { get; set; }

    /// <summary>
    /// The dedicated_log_volume attribute.
    /// </summary>
    [TerraformProperty("dedicated_log_volume")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? DedicatedLogVolume { get; set; }

    /// <summary>
    /// The delete_automated_backups attribute.
    /// </summary>
    [TerraformProperty("delete_automated_backups")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? DeleteAutomatedBackups { get; set; }

    /// <summary>
    /// The deletion_protection attribute.
    /// </summary>
    [TerraformProperty("deletion_protection")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? DeletionProtection { get; set; }

    /// <summary>
    /// The domain attribute.
    /// </summary>
    [TerraformProperty("domain")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Domain { get; set; }

    /// <summary>
    /// The domain_auth_secret_arn attribute.
    /// </summary>
    [TerraformProperty("domain_auth_secret_arn")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DomainAuthSecretArn { get; set; }

    /// <summary>
    /// The domain_dns_ips attribute.
    /// </summary>
    [TerraformProperty("domain_dns_ips")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? DomainDnsIps { get; set; }

    /// <summary>
    /// The domain_fqdn attribute.
    /// </summary>
    [TerraformProperty("domain_fqdn")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> DomainFqdn { get; set; }

    /// <summary>
    /// The domain_iam_role_name attribute.
    /// </summary>
    [TerraformProperty("domain_iam_role_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DomainIamRoleName { get; set; }

    /// <summary>
    /// The domain_ou attribute.
    /// </summary>
    [TerraformProperty("domain_ou")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DomainOu { get; set; }

    /// <summary>
    /// The enabled_cloudwatch_logs_exports attribute.
    /// </summary>
    [TerraformProperty("enabled_cloudwatch_logs_exports")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? EnabledCloudwatchLogsExports { get; set; }

    /// <summary>
    /// The engine attribute.
    /// </summary>
    [TerraformProperty("engine")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Engine { get; set; }

    /// <summary>
    /// The engine_lifecycle_support attribute.
    /// </summary>
    [TerraformProperty("engine_lifecycle_support")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> EngineLifecycleSupport { get; set; }

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
    /// The iam_database_authentication_enabled attribute.
    /// </summary>
    [TerraformProperty("iam_database_authentication_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? IamDatabaseAuthenticationEnabled { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The identifier attribute.
    /// </summary>
    [TerraformProperty("identifier")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Identifier { get; set; }

    /// <summary>
    /// The identifier_prefix attribute.
    /// </summary>
    [TerraformProperty("identifier_prefix")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> IdentifierPrefix { get; set; }

    /// <summary>
    /// The instance_class attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceClass is required")]
    [TerraformProperty("instance_class")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> InstanceClass { get; set; }

    /// <summary>
    /// The iops attribute.
    /// </summary>
    [TerraformProperty("iops")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> Iops { get; set; }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    [TerraformProperty("kms_key_id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> KmsKeyId { get; set; }

    /// <summary>
    /// The license_model attribute.
    /// </summary>
    [TerraformProperty("license_model")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> LicenseModel { get; set; }

    /// <summary>
    /// The maintenance_window attribute.
    /// </summary>
    [TerraformProperty("maintenance_window")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> MaintenanceWindow { get; set; }

    /// <summary>
    /// The manage_master_user_password attribute.
    /// </summary>
    [TerraformProperty("manage_master_user_password")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? ManageMasterUserPassword { get; set; }

    /// <summary>
    /// The master_user_secret_kms_key_id attribute.
    /// </summary>
    [TerraformProperty("master_user_secret_kms_key_id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> MasterUserSecretKmsKeyId { get; set; }

    /// <summary>
    /// The max_allocated_storage attribute.
    /// </summary>
    [TerraformProperty("max_allocated_storage")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? MaxAllocatedStorage { get; set; }

    /// <summary>
    /// The monitoring_interval attribute.
    /// </summary>
    [TerraformProperty("monitoring_interval")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? MonitoringInterval { get; set; }

    /// <summary>
    /// The monitoring_role_arn attribute.
    /// </summary>
    [TerraformProperty("monitoring_role_arn")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> MonitoringRoleArn { get; set; }

    /// <summary>
    /// The multi_az attribute.
    /// </summary>
    [TerraformProperty("multi_az")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> MultiAz { get; set; }

    /// <summary>
    /// The nchar_character_set_name attribute.
    /// </summary>
    [TerraformProperty("nchar_character_set_name")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> NcharCharacterSetName { get; set; }

    /// <summary>
    /// The network_type attribute.
    /// </summary>
    [TerraformProperty("network_type")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> NetworkType { get; set; }

    /// <summary>
    /// The option_group_name attribute.
    /// </summary>
    [TerraformProperty("option_group_name")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> OptionGroupName { get; set; }

    /// <summary>
    /// The parameter_group_name attribute.
    /// </summary>
    [TerraformProperty("parameter_group_name")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> ParameterGroupName { get; set; }

    /// <summary>
    /// The password attribute.
    /// </summary>
    [TerraformProperty("password")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Password { get; set; }

    /// <summary>
    /// The password_wo attribute.
    /// </summary>
    [TerraformProperty("password_wo")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? PasswordWo { get; set; }

    /// <summary>
    /// The password_wo_version attribute.
    /// </summary>
    [TerraformProperty("password_wo_version")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? PasswordWoVersion { get; set; }

    /// <summary>
    /// The performance_insights_enabled attribute.
    /// </summary>
    [TerraformProperty("performance_insights_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? PerformanceInsightsEnabled { get; set; }

    /// <summary>
    /// The performance_insights_kms_key_id attribute.
    /// </summary>
    [TerraformProperty("performance_insights_kms_key_id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> PerformanceInsightsKmsKeyId { get; set; }

    /// <summary>
    /// The performance_insights_retention_period attribute.
    /// </summary>
    [TerraformProperty("performance_insights_retention_period")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> PerformanceInsightsRetentionPeriod { get; set; }

    /// <summary>
    /// The port attribute.
    /// </summary>
    [TerraformProperty("port")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> Port { get; set; }

    /// <summary>
    /// The publicly_accessible attribute.
    /// </summary>
    [TerraformProperty("publicly_accessible")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? PubliclyAccessible { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The replica_mode attribute.
    /// </summary>
    [TerraformProperty("replica_mode")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> ReplicaMode { get; set; }

    /// <summary>
    /// The replicate_source_db attribute.
    /// </summary>
    [TerraformProperty("replicate_source_db")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ReplicateSourceDb { get; set; }

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
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> SnapshotIdentifier { get; set; }

    /// <summary>
    /// The storage_encrypted attribute.
    /// </summary>
    [TerraformProperty("storage_encrypted")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? StorageEncrypted { get; set; }

    /// <summary>
    /// The storage_throughput attribute.
    /// </summary>
    [TerraformProperty("storage_throughput")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> StorageThroughput { get; set; }

    /// <summary>
    /// The storage_type attribute.
    /// </summary>
    [TerraformProperty("storage_type")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> StorageType { get; set; }

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
    /// The timezone attribute.
    /// </summary>
    [TerraformProperty("timezone")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Timezone { get; set; }

    /// <summary>
    /// The upgrade_storage_config attribute.
    /// </summary>
    [TerraformProperty("upgrade_storage_config")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? UpgradeStorageConfig { get; set; }

    /// <summary>
    /// The username attribute.
    /// </summary>
    [TerraformProperty("username")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Username { get; set; }

    /// <summary>
    /// The vpc_security_group_ids attribute.
    /// </summary>
    [TerraformProperty("vpc_security_group_ids")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformSet<string> VpcSecurityGroupIds { get; set; }

    /// <summary>
    /// Block for blue_green_update.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BlueGreenUpdate block(s) allowed")]
    [TerraformProperty("blue_green_update")]
    public partial TerraformList<TerraformBlock<AwsDbInstanceBlueGreenUpdateBlock>>? BlueGreenUpdate { get; set; }

    /// <summary>
    /// Block for restore_to_point_in_time.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RestoreToPointInTime block(s) allowed")]
    [TerraformProperty("restore_to_point_in_time")]
    public partial TerraformList<TerraformBlock<AwsDbInstanceRestoreToPointInTimeBlock>>? RestoreToPointInTime { get; set; }

    /// <summary>
    /// Block for s3_import.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 S3Import block(s) allowed")]
    [TerraformProperty("s3_import")]
    public partial TerraformList<TerraformBlock<AwsDbInstanceS3ImportBlock>>? S3Import { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AwsDbInstanceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The address attribute.
    /// </summary>
    [TerraformProperty("address")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Address { get; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    [TerraformProperty("endpoint")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Endpoint { get; }

    /// <summary>
    /// The engine_version_actual attribute.
    /// </summary>
    [TerraformProperty("engine_version_actual")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> EngineVersionActual { get; }

    /// <summary>
    /// The hosted_zone_id attribute.
    /// </summary>
    [TerraformProperty("hosted_zone_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> HostedZoneId { get; }

    /// <summary>
    /// The latest_restorable_time attribute.
    /// </summary>
    [TerraformProperty("latest_restorable_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> LatestRestorableTime { get; }

    /// <summary>
    /// The listener_endpoint attribute.
    /// </summary>
    [TerraformProperty("listener_endpoint")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> ListenerEndpoint { get; }

    /// <summary>
    /// The master_user_secret attribute.
    /// </summary>
    [TerraformProperty("master_user_secret")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> MasterUserSecret { get; }

    /// <summary>
    /// The replicas attribute.
    /// </summary>
    [TerraformProperty("replicas")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> Replicas { get; }

    /// <summary>
    /// The resource_id attribute.
    /// </summary>
    [TerraformProperty("resource_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ResourceId { get; }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformProperty("status")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Status { get; }

}
