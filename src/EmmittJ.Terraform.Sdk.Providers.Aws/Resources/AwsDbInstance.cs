using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for blue_green_update in .
/// Nesting mode: list
/// </summary>
public class AwsDbInstanceBlueGreenUpdateBlock : TerraformBlock
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? Enabled
    {
        get => GetProperty<TerraformProperty<bool>>("enabled");
        set => WithProperty("enabled", value);
    }

}

/// <summary>
/// Block type for restore_to_point_in_time in .
/// Nesting mode: list
/// </summary>
public class AwsDbInstanceRestoreToPointInTimeBlock : TerraformBlock
{
    /// <summary>
    /// The restore_time attribute.
    /// </summary>
    public TerraformProperty<string>? RestoreTime
    {
        get => GetProperty<TerraformProperty<string>>("restore_time");
        set => WithProperty("restore_time", value);
    }

    /// <summary>
    /// The source_db_instance_automated_backups_arn attribute.
    /// </summary>
    public TerraformProperty<string>? SourceDbInstanceAutomatedBackupsArn
    {
        get => GetProperty<TerraformProperty<string>>("source_db_instance_automated_backups_arn");
        set => WithProperty("source_db_instance_automated_backups_arn", value);
    }

    /// <summary>
    /// The source_db_instance_identifier attribute.
    /// </summary>
    public TerraformProperty<string>? SourceDbInstanceIdentifier
    {
        get => GetProperty<TerraformProperty<string>>("source_db_instance_identifier");
        set => WithProperty("source_db_instance_identifier", value);
    }

    /// <summary>
    /// The source_dbi_resource_id attribute.
    /// </summary>
    public TerraformProperty<string>? SourceDbiResourceId
    {
        get => GetProperty<TerraformProperty<string>>("source_dbi_resource_id");
        set => WithProperty("source_dbi_resource_id", value);
    }

    /// <summary>
    /// The use_latest_restorable_time attribute.
    /// </summary>
    public TerraformProperty<bool>? UseLatestRestorableTime
    {
        get => GetProperty<TerraformProperty<bool>>("use_latest_restorable_time");
        set => WithProperty("use_latest_restorable_time", value);
    }

}

/// <summary>
/// Block type for s3_import in .
/// Nesting mode: list
/// </summary>
public class AwsDbInstanceS3ImportBlock : TerraformBlock
{
    /// <summary>
    /// The bucket_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BucketName is required")]
    public required TerraformProperty<string> BucketName
    {
        get => GetProperty<TerraformProperty<string>>("bucket_name");
        set => WithProperty("bucket_name", value);
    }

    /// <summary>
    /// The bucket_prefix attribute.
    /// </summary>
    public TerraformProperty<string>? BucketPrefix
    {
        get => GetProperty<TerraformProperty<string>>("bucket_prefix");
        set => WithProperty("bucket_prefix", value);
    }

    /// <summary>
    /// The ingestion_role attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IngestionRole is required")]
    public required TerraformProperty<string> IngestionRole
    {
        get => GetProperty<TerraformProperty<string>>("ingestion_role");
        set => WithProperty("ingestion_role", value);
    }

    /// <summary>
    /// The source_engine attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceEngine is required")]
    public required TerraformProperty<string> SourceEngine
    {
        get => GetProperty<TerraformProperty<string>>("source_engine");
        set => WithProperty("source_engine", value);
    }

    /// <summary>
    /// The source_engine_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceEngineVersion is required")]
    public required TerraformProperty<string> SourceEngineVersion
    {
        get => GetProperty<TerraformProperty<string>>("source_engine_version");
        set => WithProperty("source_engine_version", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsDbInstanceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a aws_db_instance resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsDbInstance : TerraformResource
{
    public AwsDbInstance(string name) : base("aws_db_instance", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("address");
        this.DeclareOutput("arn");
        this.DeclareOutput("endpoint");
        this.DeclareOutput("engine_version_actual");
        this.DeclareOutput("hosted_zone_id");
        this.DeclareOutput("latest_restorable_time");
        this.DeclareOutput("listener_endpoint");
        this.DeclareOutput("master_user_secret");
        this.DeclareOutput("replicas");
        this.DeclareOutput("resource_id");
        this.DeclareOutput("status");
    }

    /// <summary>
    /// The allocated_storage attribute.
    /// </summary>
    public TerraformProperty<double>? AllocatedStorage
    {
        get => GetProperty<TerraformProperty<double>>("allocated_storage");
        set => this.WithProperty("allocated_storage", value);
    }

    /// <summary>
    /// The allow_major_version_upgrade attribute.
    /// </summary>
    public TerraformProperty<bool>? AllowMajorVersionUpgrade
    {
        get => GetProperty<TerraformProperty<bool>>("allow_major_version_upgrade");
        set => this.WithProperty("allow_major_version_upgrade", value);
    }

    /// <summary>
    /// The apply_immediately attribute.
    /// </summary>
    public TerraformProperty<bool>? ApplyImmediately
    {
        get => GetProperty<TerraformProperty<bool>>("apply_immediately");
        set => this.WithProperty("apply_immediately", value);
    }

    /// <summary>
    /// The auto_minor_version_upgrade attribute.
    /// </summary>
    public TerraformProperty<bool>? AutoMinorVersionUpgrade
    {
        get => GetProperty<TerraformProperty<bool>>("auto_minor_version_upgrade");
        set => this.WithProperty("auto_minor_version_upgrade", value);
    }

    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    public TerraformProperty<string>? AvailabilityZone
    {
        get => GetProperty<TerraformProperty<string>>("availability_zone");
        set => this.WithProperty("availability_zone", value);
    }

    /// <summary>
    /// The backup_retention_period attribute.
    /// </summary>
    public TerraformProperty<double>? BackupRetentionPeriod
    {
        get => GetProperty<TerraformProperty<double>>("backup_retention_period");
        set => this.WithProperty("backup_retention_period", value);
    }

    /// <summary>
    /// The backup_target attribute.
    /// </summary>
    public TerraformProperty<string>? BackupTarget
    {
        get => GetProperty<TerraformProperty<string>>("backup_target");
        set => this.WithProperty("backup_target", value);
    }

    /// <summary>
    /// The backup_window attribute.
    /// </summary>
    public TerraformProperty<string>? BackupWindow
    {
        get => GetProperty<TerraformProperty<string>>("backup_window");
        set => this.WithProperty("backup_window", value);
    }

    /// <summary>
    /// The ca_cert_identifier attribute.
    /// </summary>
    public TerraformProperty<string>? CaCertIdentifier
    {
        get => GetProperty<TerraformProperty<string>>("ca_cert_identifier");
        set => this.WithProperty("ca_cert_identifier", value);
    }

    /// <summary>
    /// The character_set_name attribute.
    /// </summary>
    public TerraformProperty<string>? CharacterSetName
    {
        get => GetProperty<TerraformProperty<string>>("character_set_name");
        set => this.WithProperty("character_set_name", value);
    }

    /// <summary>
    /// The copy_tags_to_snapshot attribute.
    /// </summary>
    public TerraformProperty<bool>? CopyTagsToSnapshot
    {
        get => GetProperty<TerraformProperty<bool>>("copy_tags_to_snapshot");
        set => this.WithProperty("copy_tags_to_snapshot", value);
    }

    /// <summary>
    /// The custom_iam_instance_profile attribute.
    /// </summary>
    public TerraformProperty<string>? CustomIamInstanceProfile
    {
        get => GetProperty<TerraformProperty<string>>("custom_iam_instance_profile");
        set => this.WithProperty("custom_iam_instance_profile", value);
    }

    /// <summary>
    /// The customer_owned_ip_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? CustomerOwnedIpEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("customer_owned_ip_enabled");
        set => this.WithProperty("customer_owned_ip_enabled", value);
    }

    /// <summary>
    /// The database_insights_mode attribute.
    /// </summary>
    public TerraformProperty<string>? DatabaseInsightsMode
    {
        get => GetProperty<TerraformProperty<string>>("database_insights_mode");
        set => this.WithProperty("database_insights_mode", value);
    }

    /// <summary>
    /// The db_name attribute.
    /// </summary>
    public TerraformProperty<string>? DbName
    {
        get => GetProperty<TerraformProperty<string>>("db_name");
        set => this.WithProperty("db_name", value);
    }

    /// <summary>
    /// The db_subnet_group_name attribute.
    /// </summary>
    public TerraformProperty<string>? DbSubnetGroupName
    {
        get => GetProperty<TerraformProperty<string>>("db_subnet_group_name");
        set => this.WithProperty("db_subnet_group_name", value);
    }

    /// <summary>
    /// The dedicated_log_volume attribute.
    /// </summary>
    public TerraformProperty<bool>? DedicatedLogVolume
    {
        get => GetProperty<TerraformProperty<bool>>("dedicated_log_volume");
        set => this.WithProperty("dedicated_log_volume", value);
    }

    /// <summary>
    /// The delete_automated_backups attribute.
    /// </summary>
    public TerraformProperty<bool>? DeleteAutomatedBackups
    {
        get => GetProperty<TerraformProperty<bool>>("delete_automated_backups");
        set => this.WithProperty("delete_automated_backups", value);
    }

    /// <summary>
    /// The deletion_protection attribute.
    /// </summary>
    public TerraformProperty<bool>? DeletionProtection
    {
        get => GetProperty<TerraformProperty<bool>>("deletion_protection");
        set => this.WithProperty("deletion_protection", value);
    }

    /// <summary>
    /// The domain attribute.
    /// </summary>
    public TerraformProperty<string>? Domain
    {
        get => GetProperty<TerraformProperty<string>>("domain");
        set => this.WithProperty("domain", value);
    }

    /// <summary>
    /// The domain_auth_secret_arn attribute.
    /// </summary>
    public TerraformProperty<string>? DomainAuthSecretArn
    {
        get => GetProperty<TerraformProperty<string>>("domain_auth_secret_arn");
        set => this.WithProperty("domain_auth_secret_arn", value);
    }

    /// <summary>
    /// The domain_dns_ips attribute.
    /// </summary>
    public List<TerraformProperty<string>>? DomainDnsIps
    {
        get => GetProperty<List<TerraformProperty<string>>>("domain_dns_ips");
        set => this.WithProperty("domain_dns_ips", value);
    }

    /// <summary>
    /// The domain_fqdn attribute.
    /// </summary>
    public TerraformProperty<string>? DomainFqdn
    {
        get => GetProperty<TerraformProperty<string>>("domain_fqdn");
        set => this.WithProperty("domain_fqdn", value);
    }

    /// <summary>
    /// The domain_iam_role_name attribute.
    /// </summary>
    public TerraformProperty<string>? DomainIamRoleName
    {
        get => GetProperty<TerraformProperty<string>>("domain_iam_role_name");
        set => this.WithProperty("domain_iam_role_name", value);
    }

    /// <summary>
    /// The domain_ou attribute.
    /// </summary>
    public TerraformProperty<string>? DomainOu
    {
        get => GetProperty<TerraformProperty<string>>("domain_ou");
        set => this.WithProperty("domain_ou", value);
    }

    /// <summary>
    /// The enabled_cloudwatch_logs_exports attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? EnabledCloudwatchLogsExports
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("enabled_cloudwatch_logs_exports");
        set => this.WithProperty("enabled_cloudwatch_logs_exports", value);
    }

    /// <summary>
    /// The engine attribute.
    /// </summary>
    public TerraformProperty<string>? Engine
    {
        get => GetProperty<TerraformProperty<string>>("engine");
        set => this.WithProperty("engine", value);
    }

    /// <summary>
    /// The engine_lifecycle_support attribute.
    /// </summary>
    public TerraformProperty<string>? EngineLifecycleSupport
    {
        get => GetProperty<TerraformProperty<string>>("engine_lifecycle_support");
        set => this.WithProperty("engine_lifecycle_support", value);
    }

    /// <summary>
    /// The engine_version attribute.
    /// </summary>
    public TerraformProperty<string>? EngineVersion
    {
        get => GetProperty<TerraformProperty<string>>("engine_version");
        set => this.WithProperty("engine_version", value);
    }

    /// <summary>
    /// The final_snapshot_identifier attribute.
    /// </summary>
    public TerraformProperty<string>? FinalSnapshotIdentifier
    {
        get => GetProperty<TerraformProperty<string>>("final_snapshot_identifier");
        set => this.WithProperty("final_snapshot_identifier", value);
    }

    /// <summary>
    /// The iam_database_authentication_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? IamDatabaseAuthenticationEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("iam_database_authentication_enabled");
        set => this.WithProperty("iam_database_authentication_enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The identifier attribute.
    /// </summary>
    public TerraformProperty<string>? Identifier
    {
        get => GetProperty<TerraformProperty<string>>("identifier");
        set => this.WithProperty("identifier", value);
    }

    /// <summary>
    /// The identifier_prefix attribute.
    /// </summary>
    public TerraformProperty<string>? IdentifierPrefix
    {
        get => GetProperty<TerraformProperty<string>>("identifier_prefix");
        set => this.WithProperty("identifier_prefix", value);
    }

    /// <summary>
    /// The instance_class attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceClass is required")]
    public required TerraformProperty<string> InstanceClass
    {
        get => GetProperty<TerraformProperty<string>>("instance_class");
        set => this.WithProperty("instance_class", value);
    }

    /// <summary>
    /// The iops attribute.
    /// </summary>
    public TerraformProperty<double>? Iops
    {
        get => GetProperty<TerraformProperty<double>>("iops");
        set => this.WithProperty("iops", value);
    }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformProperty<string>? KmsKeyId
    {
        get => GetProperty<TerraformProperty<string>>("kms_key_id");
        set => this.WithProperty("kms_key_id", value);
    }

    /// <summary>
    /// The license_model attribute.
    /// </summary>
    public TerraformProperty<string>? LicenseModel
    {
        get => GetProperty<TerraformProperty<string>>("license_model");
        set => this.WithProperty("license_model", value);
    }

    /// <summary>
    /// The maintenance_window attribute.
    /// </summary>
    public TerraformProperty<string>? MaintenanceWindow
    {
        get => GetProperty<TerraformProperty<string>>("maintenance_window");
        set => this.WithProperty("maintenance_window", value);
    }

    /// <summary>
    /// The manage_master_user_password attribute.
    /// </summary>
    public TerraformProperty<bool>? ManageMasterUserPassword
    {
        get => GetProperty<TerraformProperty<bool>>("manage_master_user_password");
        set => this.WithProperty("manage_master_user_password", value);
    }

    /// <summary>
    /// The master_user_secret_kms_key_id attribute.
    /// </summary>
    public TerraformProperty<string>? MasterUserSecretKmsKeyId
    {
        get => GetProperty<TerraformProperty<string>>("master_user_secret_kms_key_id");
        set => this.WithProperty("master_user_secret_kms_key_id", value);
    }

    /// <summary>
    /// The max_allocated_storage attribute.
    /// </summary>
    public TerraformProperty<double>? MaxAllocatedStorage
    {
        get => GetProperty<TerraformProperty<double>>("max_allocated_storage");
        set => this.WithProperty("max_allocated_storage", value);
    }

    /// <summary>
    /// The monitoring_interval attribute.
    /// </summary>
    public TerraformProperty<double>? MonitoringInterval
    {
        get => GetProperty<TerraformProperty<double>>("monitoring_interval");
        set => this.WithProperty("monitoring_interval", value);
    }

    /// <summary>
    /// The monitoring_role_arn attribute.
    /// </summary>
    public TerraformProperty<string>? MonitoringRoleArn
    {
        get => GetProperty<TerraformProperty<string>>("monitoring_role_arn");
        set => this.WithProperty("monitoring_role_arn", value);
    }

    /// <summary>
    /// The multi_az attribute.
    /// </summary>
    public TerraformProperty<bool>? MultiAz
    {
        get => GetProperty<TerraformProperty<bool>>("multi_az");
        set => this.WithProperty("multi_az", value);
    }

    /// <summary>
    /// The nchar_character_set_name attribute.
    /// </summary>
    public TerraformProperty<string>? NcharCharacterSetName
    {
        get => GetProperty<TerraformProperty<string>>("nchar_character_set_name");
        set => this.WithProperty("nchar_character_set_name", value);
    }

    /// <summary>
    /// The network_type attribute.
    /// </summary>
    public TerraformProperty<string>? NetworkType
    {
        get => GetProperty<TerraformProperty<string>>("network_type");
        set => this.WithProperty("network_type", value);
    }

    /// <summary>
    /// The option_group_name attribute.
    /// </summary>
    public TerraformProperty<string>? OptionGroupName
    {
        get => GetProperty<TerraformProperty<string>>("option_group_name");
        set => this.WithProperty("option_group_name", value);
    }

    /// <summary>
    /// The parameter_group_name attribute.
    /// </summary>
    public TerraformProperty<string>? ParameterGroupName
    {
        get => GetProperty<TerraformProperty<string>>("parameter_group_name");
        set => this.WithProperty("parameter_group_name", value);
    }

    /// <summary>
    /// The password attribute.
    /// </summary>
    public TerraformProperty<string>? Password
    {
        get => GetProperty<TerraformProperty<string>>("password");
        set => this.WithProperty("password", value);
    }

    /// <summary>
    /// The password_wo attribute.
    /// </summary>
    public TerraformProperty<string>? PasswordWo
    {
        get => GetProperty<TerraformProperty<string>>("password_wo");
        set => this.WithProperty("password_wo", value);
    }

    /// <summary>
    /// The password_wo_version attribute.
    /// </summary>
    public TerraformProperty<double>? PasswordWoVersion
    {
        get => GetProperty<TerraformProperty<double>>("password_wo_version");
        set => this.WithProperty("password_wo_version", value);
    }

    /// <summary>
    /// The performance_insights_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? PerformanceInsightsEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("performance_insights_enabled");
        set => this.WithProperty("performance_insights_enabled", value);
    }

    /// <summary>
    /// The performance_insights_kms_key_id attribute.
    /// </summary>
    public TerraformProperty<string>? PerformanceInsightsKmsKeyId
    {
        get => GetProperty<TerraformProperty<string>>("performance_insights_kms_key_id");
        set => this.WithProperty("performance_insights_kms_key_id", value);
    }

    /// <summary>
    /// The performance_insights_retention_period attribute.
    /// </summary>
    public TerraformProperty<double>? PerformanceInsightsRetentionPeriod
    {
        get => GetProperty<TerraformProperty<double>>("performance_insights_retention_period");
        set => this.WithProperty("performance_insights_retention_period", value);
    }

    /// <summary>
    /// The port attribute.
    /// </summary>
    public TerraformProperty<double>? Port
    {
        get => GetProperty<TerraformProperty<double>>("port");
        set => this.WithProperty("port", value);
    }

    /// <summary>
    /// The publicly_accessible attribute.
    /// </summary>
    public TerraformProperty<bool>? PubliclyAccessible
    {
        get => GetProperty<TerraformProperty<bool>>("publicly_accessible");
        set => this.WithProperty("publicly_accessible", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The replica_mode attribute.
    /// </summary>
    public TerraformProperty<string>? ReplicaMode
    {
        get => GetProperty<TerraformProperty<string>>("replica_mode");
        set => this.WithProperty("replica_mode", value);
    }

    /// <summary>
    /// The replicate_source_db attribute.
    /// </summary>
    public TerraformProperty<string>? ReplicateSourceDb
    {
        get => GetProperty<TerraformProperty<string>>("replicate_source_db");
        set => this.WithProperty("replicate_source_db", value);
    }

    /// <summary>
    /// The skip_final_snapshot attribute.
    /// </summary>
    public TerraformProperty<bool>? SkipFinalSnapshot
    {
        get => GetProperty<TerraformProperty<bool>>("skip_final_snapshot");
        set => this.WithProperty("skip_final_snapshot", value);
    }

    /// <summary>
    /// The snapshot_identifier attribute.
    /// </summary>
    public TerraformProperty<string>? SnapshotIdentifier
    {
        get => GetProperty<TerraformProperty<string>>("snapshot_identifier");
        set => this.WithProperty("snapshot_identifier", value);
    }

    /// <summary>
    /// The storage_encrypted attribute.
    /// </summary>
    public TerraformProperty<bool>? StorageEncrypted
    {
        get => GetProperty<TerraformProperty<bool>>("storage_encrypted");
        set => this.WithProperty("storage_encrypted", value);
    }

    /// <summary>
    /// The storage_throughput attribute.
    /// </summary>
    public TerraformProperty<double>? StorageThroughput
    {
        get => GetProperty<TerraformProperty<double>>("storage_throughput");
        set => this.WithProperty("storage_throughput", value);
    }

    /// <summary>
    /// The storage_type attribute.
    /// </summary>
    public TerraformProperty<string>? StorageType
    {
        get => GetProperty<TerraformProperty<string>>("storage_type");
        set => this.WithProperty("storage_type", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TagsAll
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The timezone attribute.
    /// </summary>
    public TerraformProperty<string>? Timezone
    {
        get => GetProperty<TerraformProperty<string>>("timezone");
        set => this.WithProperty("timezone", value);
    }

    /// <summary>
    /// The upgrade_storage_config attribute.
    /// </summary>
    public TerraformProperty<bool>? UpgradeStorageConfig
    {
        get => GetProperty<TerraformProperty<bool>>("upgrade_storage_config");
        set => this.WithProperty("upgrade_storage_config", value);
    }

    /// <summary>
    /// The username attribute.
    /// </summary>
    public TerraformProperty<string>? Username
    {
        get => GetProperty<TerraformProperty<string>>("username");
        set => this.WithProperty("username", value);
    }

    /// <summary>
    /// The vpc_security_group_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? VpcSecurityGroupIds
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("vpc_security_group_ids");
        set => this.WithProperty("vpc_security_group_ids", value);
    }

    /// <summary>
    /// Block for blue_green_update.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BlueGreenUpdate block(s) allowed")]
    public List<AwsDbInstanceBlueGreenUpdateBlock>? BlueGreenUpdate
    {
        get => GetProperty<List<AwsDbInstanceBlueGreenUpdateBlock>>("blue_green_update");
        set => this.WithProperty("blue_green_update", value);
    }

    /// <summary>
    /// Block for restore_to_point_in_time.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RestoreToPointInTime block(s) allowed")]
    public List<AwsDbInstanceRestoreToPointInTimeBlock>? RestoreToPointInTime
    {
        get => GetProperty<List<AwsDbInstanceRestoreToPointInTimeBlock>>("restore_to_point_in_time");
        set => this.WithProperty("restore_to_point_in_time", value);
    }

    /// <summary>
    /// Block for s3_import.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 S3Import block(s) allowed")]
    public List<AwsDbInstanceS3ImportBlock>? S3Import
    {
        get => GetProperty<List<AwsDbInstanceS3ImportBlock>>("s3_import");
        set => this.WithProperty("s3_import", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsDbInstanceTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsDbInstanceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The address attribute.
    /// </summary>
    public TerraformExpression Address => this["address"];

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    public TerraformExpression Endpoint => this["endpoint"];

    /// <summary>
    /// The engine_version_actual attribute.
    /// </summary>
    public TerraformExpression EngineVersionActual => this["engine_version_actual"];

    /// <summary>
    /// The hosted_zone_id attribute.
    /// </summary>
    public TerraformExpression HostedZoneId => this["hosted_zone_id"];

    /// <summary>
    /// The latest_restorable_time attribute.
    /// </summary>
    public TerraformExpression LatestRestorableTime => this["latest_restorable_time"];

    /// <summary>
    /// The listener_endpoint attribute.
    /// </summary>
    public TerraformExpression ListenerEndpoint => this["listener_endpoint"];

    /// <summary>
    /// The master_user_secret attribute.
    /// </summary>
    public TerraformExpression MasterUserSecret => this["master_user_secret"];

    /// <summary>
    /// The replicas attribute.
    /// </summary>
    public TerraformExpression Replicas => this["replicas"];

    /// <summary>
    /// The resource_id attribute.
    /// </summary>
    public TerraformExpression ResourceId => this["resource_id"];

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformExpression Status => this["status"];

}
