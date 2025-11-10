using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for blue_green_update in .
/// Nesting mode: list
/// </summary>
public class AwsDbInstanceBlueGreenUpdateBlock : ITerraformBlock
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformPropertyName("enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? Enabled { get; set; }

}

/// <summary>
/// Block type for restore_to_point_in_time in .
/// Nesting mode: list
/// </summary>
public class AwsDbInstanceRestoreToPointInTimeBlock : ITerraformBlock
{
    /// <summary>
    /// The restore_time attribute.
    /// </summary>
    [TerraformPropertyName("restore_time")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? RestoreTime { get; set; }

    /// <summary>
    /// The source_db_instance_automated_backups_arn attribute.
    /// </summary>
    [TerraformPropertyName("source_db_instance_automated_backups_arn")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SourceDbInstanceAutomatedBackupsArn { get; set; }

    /// <summary>
    /// The source_db_instance_identifier attribute.
    /// </summary>
    [TerraformPropertyName("source_db_instance_identifier")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SourceDbInstanceIdentifier { get; set; }

    /// <summary>
    /// The source_dbi_resource_id attribute.
    /// </summary>
    [TerraformPropertyName("source_dbi_resource_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SourceDbiResourceId { get; set; }

    /// <summary>
    /// The use_latest_restorable_time attribute.
    /// </summary>
    [TerraformPropertyName("use_latest_restorable_time")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? UseLatestRestorableTime { get; set; }

}

/// <summary>
/// Block type for s3_import in .
/// Nesting mode: list
/// </summary>
public class AwsDbInstanceS3ImportBlock : ITerraformBlock
{
    /// <summary>
    /// The bucket_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BucketName is required")]
    [TerraformPropertyName("bucket_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> BucketName { get; set; }

    /// <summary>
    /// The bucket_prefix attribute.
    /// </summary>
    [TerraformPropertyName("bucket_prefix")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? BucketPrefix { get; set; }

    /// <summary>
    /// The ingestion_role attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IngestionRole is required")]
    [TerraformPropertyName("ingestion_role")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> IngestionRole { get; set; }

    /// <summary>
    /// The source_engine attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceEngine is required")]
    [TerraformPropertyName("source_engine")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> SourceEngine { get; set; }

    /// <summary>
    /// The source_engine_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceEngineVersion is required")]
    [TerraformPropertyName("source_engine_version")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> SourceEngineVersion { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsDbInstanceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> AllocatedStorage { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "allocated_storage");

    /// <summary>
    /// The allow_major_version_upgrade attribute.
    /// </summary>
    [TerraformPropertyName("allow_major_version_upgrade")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? AllowMajorVersionUpgrade { get; set; }

    /// <summary>
    /// The apply_immediately attribute.
    /// </summary>
    [TerraformPropertyName("apply_immediately")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? ApplyImmediately { get; set; }

    /// <summary>
    /// The auto_minor_version_upgrade attribute.
    /// </summary>
    [TerraformPropertyName("auto_minor_version_upgrade")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? AutoMinorVersionUpgrade { get; set; }

    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    [TerraformPropertyName("availability_zone")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> AvailabilityZone { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "availability_zone");

    /// <summary>
    /// The backup_retention_period attribute.
    /// </summary>
    [TerraformPropertyName("backup_retention_period")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> BackupRetentionPeriod { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "backup_retention_period");

    /// <summary>
    /// The backup_target attribute.
    /// </summary>
    [TerraformPropertyName("backup_target")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> BackupTarget { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "backup_target");

    /// <summary>
    /// The backup_window attribute.
    /// </summary>
    [TerraformPropertyName("backup_window")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> BackupWindow { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "backup_window");

    /// <summary>
    /// The ca_cert_identifier attribute.
    /// </summary>
    [TerraformPropertyName("ca_cert_identifier")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> CaCertIdentifier { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "ca_cert_identifier");

    /// <summary>
    /// The character_set_name attribute.
    /// </summary>
    [TerraformPropertyName("character_set_name")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> CharacterSetName { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "character_set_name");

    /// <summary>
    /// The copy_tags_to_snapshot attribute.
    /// </summary>
    [TerraformPropertyName("copy_tags_to_snapshot")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? CopyTagsToSnapshot { get; set; }

    /// <summary>
    /// The custom_iam_instance_profile attribute.
    /// </summary>
    [TerraformPropertyName("custom_iam_instance_profile")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? CustomIamInstanceProfile { get; set; }

    /// <summary>
    /// The customer_owned_ip_enabled attribute.
    /// </summary>
    [TerraformPropertyName("customer_owned_ip_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? CustomerOwnedIpEnabled { get; set; }

    /// <summary>
    /// The database_insights_mode attribute.
    /// </summary>
    [TerraformPropertyName("database_insights_mode")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> DatabaseInsightsMode { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "database_insights_mode");

    /// <summary>
    /// The db_name attribute.
    /// </summary>
    [TerraformPropertyName("db_name")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> DbName { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "db_name");

    /// <summary>
    /// The db_subnet_group_name attribute.
    /// </summary>
    [TerraformPropertyName("db_subnet_group_name")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> DbSubnetGroupName { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "db_subnet_group_name");

    /// <summary>
    /// The dedicated_log_volume attribute.
    /// </summary>
    [TerraformPropertyName("dedicated_log_volume")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? DedicatedLogVolume { get; set; }

    /// <summary>
    /// The delete_automated_backups attribute.
    /// </summary>
    [TerraformPropertyName("delete_automated_backups")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? DeleteAutomatedBackups { get; set; }

    /// <summary>
    /// The deletion_protection attribute.
    /// </summary>
    [TerraformPropertyName("deletion_protection")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? DeletionProtection { get; set; }

    /// <summary>
    /// The domain attribute.
    /// </summary>
    [TerraformPropertyName("domain")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Domain { get; set; }

    /// <summary>
    /// The domain_auth_secret_arn attribute.
    /// </summary>
    [TerraformPropertyName("domain_auth_secret_arn")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DomainAuthSecretArn { get; set; }

    /// <summary>
    /// The domain_dns_ips attribute.
    /// </summary>
    [TerraformPropertyName("domain_dns_ips")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? DomainDnsIps { get; set; }

    /// <summary>
    /// The domain_fqdn attribute.
    /// </summary>
    [TerraformPropertyName("domain_fqdn")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> DomainFqdn { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "domain_fqdn");

    /// <summary>
    /// The domain_iam_role_name attribute.
    /// </summary>
    [TerraformPropertyName("domain_iam_role_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DomainIamRoleName { get; set; }

    /// <summary>
    /// The domain_ou attribute.
    /// </summary>
    [TerraformPropertyName("domain_ou")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DomainOu { get; set; }

    /// <summary>
    /// The enabled_cloudwatch_logs_exports attribute.
    /// </summary>
    [TerraformPropertyName("enabled_cloudwatch_logs_exports")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? EnabledCloudwatchLogsExports { get; set; }

    /// <summary>
    /// The engine attribute.
    /// </summary>
    [TerraformPropertyName("engine")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Engine { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "engine");

    /// <summary>
    /// The engine_lifecycle_support attribute.
    /// </summary>
    [TerraformPropertyName("engine_lifecycle_support")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> EngineLifecycleSupport { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "engine_lifecycle_support");

    /// <summary>
    /// The engine_version attribute.
    /// </summary>
    [TerraformPropertyName("engine_version")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> EngineVersion { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "engine_version");

    /// <summary>
    /// The final_snapshot_identifier attribute.
    /// </summary>
    [TerraformPropertyName("final_snapshot_identifier")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? FinalSnapshotIdentifier { get; set; }

    /// <summary>
    /// The iam_database_authentication_enabled attribute.
    /// </summary>
    [TerraformPropertyName("iam_database_authentication_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? IamDatabaseAuthenticationEnabled { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The identifier attribute.
    /// </summary>
    [TerraformPropertyName("identifier")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Identifier { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "identifier");

    /// <summary>
    /// The identifier_prefix attribute.
    /// </summary>
    [TerraformPropertyName("identifier_prefix")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> IdentifierPrefix { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "identifier_prefix");

    /// <summary>
    /// The instance_class attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceClass is required")]
    [TerraformPropertyName("instance_class")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> InstanceClass { get; set; }

    /// <summary>
    /// The iops attribute.
    /// </summary>
    [TerraformPropertyName("iops")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> Iops { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "iops");

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    [TerraformPropertyName("kms_key_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> KmsKeyId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "kms_key_id");

    /// <summary>
    /// The license_model attribute.
    /// </summary>
    [TerraformPropertyName("license_model")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> LicenseModel { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "license_model");

    /// <summary>
    /// The maintenance_window attribute.
    /// </summary>
    [TerraformPropertyName("maintenance_window")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> MaintenanceWindow { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "maintenance_window");

    /// <summary>
    /// The manage_master_user_password attribute.
    /// </summary>
    [TerraformPropertyName("manage_master_user_password")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? ManageMasterUserPassword { get; set; }

    /// <summary>
    /// The master_user_secret_kms_key_id attribute.
    /// </summary>
    [TerraformPropertyName("master_user_secret_kms_key_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> MasterUserSecretKmsKeyId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "master_user_secret_kms_key_id");

    /// <summary>
    /// The max_allocated_storage attribute.
    /// </summary>
    [TerraformPropertyName("max_allocated_storage")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? MaxAllocatedStorage { get; set; }

    /// <summary>
    /// The monitoring_interval attribute.
    /// </summary>
    [TerraformPropertyName("monitoring_interval")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? MonitoringInterval { get; set; }

    /// <summary>
    /// The monitoring_role_arn attribute.
    /// </summary>
    [TerraformPropertyName("monitoring_role_arn")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> MonitoringRoleArn { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "monitoring_role_arn");

    /// <summary>
    /// The multi_az attribute.
    /// </summary>
    [TerraformPropertyName("multi_az")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> MultiAz { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "multi_az");

    /// <summary>
    /// The nchar_character_set_name attribute.
    /// </summary>
    [TerraformPropertyName("nchar_character_set_name")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> NcharCharacterSetName { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "nchar_character_set_name");

    /// <summary>
    /// The network_type attribute.
    /// </summary>
    [TerraformPropertyName("network_type")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> NetworkType { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "network_type");

    /// <summary>
    /// The option_group_name attribute.
    /// </summary>
    [TerraformPropertyName("option_group_name")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> OptionGroupName { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "option_group_name");

    /// <summary>
    /// The parameter_group_name attribute.
    /// </summary>
    [TerraformPropertyName("parameter_group_name")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ParameterGroupName { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "parameter_group_name");

    /// <summary>
    /// The password attribute.
    /// </summary>
    [TerraformPropertyName("password")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Password { get; set; }

    /// <summary>
    /// The password_wo attribute.
    /// </summary>
    [TerraformPropertyName("password_wo")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? PasswordWo { get; set; }

    /// <summary>
    /// The password_wo_version attribute.
    /// </summary>
    [TerraformPropertyName("password_wo_version")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? PasswordWoVersion { get; set; }

    /// <summary>
    /// The performance_insights_enabled attribute.
    /// </summary>
    [TerraformPropertyName("performance_insights_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? PerformanceInsightsEnabled { get; set; }

    /// <summary>
    /// The performance_insights_kms_key_id attribute.
    /// </summary>
    [TerraformPropertyName("performance_insights_kms_key_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> PerformanceInsightsKmsKeyId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "performance_insights_kms_key_id");

    /// <summary>
    /// The performance_insights_retention_period attribute.
    /// </summary>
    [TerraformPropertyName("performance_insights_retention_period")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> PerformanceInsightsRetentionPeriod { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "performance_insights_retention_period");

    /// <summary>
    /// The port attribute.
    /// </summary>
    [TerraformPropertyName("port")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> Port { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "port");

    /// <summary>
    /// The publicly_accessible attribute.
    /// </summary>
    [TerraformPropertyName("publicly_accessible")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? PubliclyAccessible { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The replica_mode attribute.
    /// </summary>
    [TerraformPropertyName("replica_mode")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ReplicaMode { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "replica_mode");

    /// <summary>
    /// The replicate_source_db attribute.
    /// </summary>
    [TerraformPropertyName("replicate_source_db")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ReplicateSourceDb { get; set; }

    /// <summary>
    /// The skip_final_snapshot attribute.
    /// </summary>
    [TerraformPropertyName("skip_final_snapshot")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? SkipFinalSnapshot { get; set; }

    /// <summary>
    /// The snapshot_identifier attribute.
    /// </summary>
    [TerraformPropertyName("snapshot_identifier")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> SnapshotIdentifier { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "snapshot_identifier");

    /// <summary>
    /// The storage_encrypted attribute.
    /// </summary>
    [TerraformPropertyName("storage_encrypted")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? StorageEncrypted { get; set; }

    /// <summary>
    /// The storage_throughput attribute.
    /// </summary>
    [TerraformPropertyName("storage_throughput")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> StorageThroughput { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "storage_throughput");

    /// <summary>
    /// The storage_type attribute.
    /// </summary>
    [TerraformPropertyName("storage_type")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> StorageType { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "storage_type");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TagsAll { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags_all");

    /// <summary>
    /// The timezone attribute.
    /// </summary>
    [TerraformPropertyName("timezone")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Timezone { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "timezone");

    /// <summary>
    /// The upgrade_storage_config attribute.
    /// </summary>
    [TerraformPropertyName("upgrade_storage_config")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? UpgradeStorageConfig { get; set; }

    /// <summary>
    /// The username attribute.
    /// </summary>
    [TerraformPropertyName("username")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Username { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "username");

    /// <summary>
    /// The vpc_security_group_ids attribute.
    /// </summary>
    [TerraformPropertyName("vpc_security_group_ids")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<HashSet<TerraformProperty<string>>> VpcSecurityGroupIds { get; set; } = new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "vpc_security_group_ids");

    /// <summary>
    /// Block for blue_green_update.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BlueGreenUpdate block(s) allowed")]
    [TerraformPropertyName("blue_green_update")]
    public TerraformList<TerraformBlock<AwsDbInstanceBlueGreenUpdateBlock>>? BlueGreenUpdate { get; set; } = new();

    /// <summary>
    /// Block for restore_to_point_in_time.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RestoreToPointInTime block(s) allowed")]
    [TerraformPropertyName("restore_to_point_in_time")]
    public TerraformList<TerraformBlock<AwsDbInstanceRestoreToPointInTimeBlock>>? RestoreToPointInTime { get; set; } = new();

    /// <summary>
    /// Block for s3_import.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 S3Import block(s) allowed")]
    [TerraformPropertyName("s3_import")]
    public TerraformList<TerraformBlock<AwsDbInstanceS3ImportBlock>>? S3Import { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsDbInstanceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The address attribute.
    /// </summary>
    [TerraformPropertyName("address")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Address => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "address");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    [TerraformPropertyName("endpoint")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Endpoint => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "endpoint");

    /// <summary>
    /// The engine_version_actual attribute.
    /// </summary>
    [TerraformPropertyName("engine_version_actual")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> EngineVersionActual => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "engine_version_actual");

    /// <summary>
    /// The hosted_zone_id attribute.
    /// </summary>
    [TerraformPropertyName("hosted_zone_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> HostedZoneId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "hosted_zone_id");

    /// <summary>
    /// The latest_restorable_time attribute.
    /// </summary>
    [TerraformPropertyName("latest_restorable_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LatestRestorableTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "latest_restorable_time");

    /// <summary>
    /// The listener_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("listener_endpoint")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> ListenerEndpoint => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "listener_endpoint");

    /// <summary>
    /// The master_user_secret attribute.
    /// </summary>
    [TerraformPropertyName("master_user_secret")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> MasterUserSecret => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "master_user_secret");

    /// <summary>
    /// The replicas attribute.
    /// </summary>
    [TerraformPropertyName("replicas")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> Replicas => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "replicas");

    /// <summary>
    /// The resource_id attribute.
    /// </summary>
    [TerraformPropertyName("resource_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ResourceId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "resource_id");

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Status => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "status");

}
