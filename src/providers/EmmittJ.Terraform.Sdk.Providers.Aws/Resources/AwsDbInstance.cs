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
        set => SetProperty("enabled", value);
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
        set => SetProperty("restore_time", value);
    }

    /// <summary>
    /// The source_db_instance_automated_backups_arn attribute.
    /// </summary>
    public TerraformProperty<string>? SourceDbInstanceAutomatedBackupsArn
    {
        set => SetProperty("source_db_instance_automated_backups_arn", value);
    }

    /// <summary>
    /// The source_db_instance_identifier attribute.
    /// </summary>
    public TerraformProperty<string>? SourceDbInstanceIdentifier
    {
        set => SetProperty("source_db_instance_identifier", value);
    }

    /// <summary>
    /// The source_dbi_resource_id attribute.
    /// </summary>
    public TerraformProperty<string>? SourceDbiResourceId
    {
        set => SetProperty("source_dbi_resource_id", value);
    }

    /// <summary>
    /// The use_latest_restorable_time attribute.
    /// </summary>
    public TerraformProperty<bool>? UseLatestRestorableTime
    {
        set => SetProperty("use_latest_restorable_time", value);
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
        set => SetProperty("bucket_name", value);
    }

    /// <summary>
    /// The bucket_prefix attribute.
    /// </summary>
    public TerraformProperty<string>? BucketPrefix
    {
        set => SetProperty("bucket_prefix", value);
    }

    /// <summary>
    /// The ingestion_role attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IngestionRole is required")]
    public required TerraformProperty<string> IngestionRole
    {
        set => SetProperty("ingestion_role", value);
    }

    /// <summary>
    /// The source_engine attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceEngine is required")]
    public required TerraformProperty<string> SourceEngine
    {
        set => SetProperty("source_engine", value);
    }

    /// <summary>
    /// The source_engine_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceEngineVersion is required")]
    public required TerraformProperty<string> SourceEngineVersion
    {
        set => SetProperty("source_engine_version", value);
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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
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
        SetOutput("address");
        SetOutput("arn");
        SetOutput("endpoint");
        SetOutput("engine_version_actual");
        SetOutput("hosted_zone_id");
        SetOutput("latest_restorable_time");
        SetOutput("listener_endpoint");
        SetOutput("master_user_secret");
        SetOutput("replicas");
        SetOutput("resource_id");
        SetOutput("status");
        SetOutput("allocated_storage");
        SetOutput("allow_major_version_upgrade");
        SetOutput("apply_immediately");
        SetOutput("auto_minor_version_upgrade");
        SetOutput("availability_zone");
        SetOutput("backup_retention_period");
        SetOutput("backup_target");
        SetOutput("backup_window");
        SetOutput("ca_cert_identifier");
        SetOutput("character_set_name");
        SetOutput("copy_tags_to_snapshot");
        SetOutput("custom_iam_instance_profile");
        SetOutput("customer_owned_ip_enabled");
        SetOutput("database_insights_mode");
        SetOutput("db_name");
        SetOutput("db_subnet_group_name");
        SetOutput("dedicated_log_volume");
        SetOutput("delete_automated_backups");
        SetOutput("deletion_protection");
        SetOutput("domain");
        SetOutput("domain_auth_secret_arn");
        SetOutput("domain_dns_ips");
        SetOutput("domain_fqdn");
        SetOutput("domain_iam_role_name");
        SetOutput("domain_ou");
        SetOutput("enabled_cloudwatch_logs_exports");
        SetOutput("engine");
        SetOutput("engine_lifecycle_support");
        SetOutput("engine_version");
        SetOutput("final_snapshot_identifier");
        SetOutput("iam_database_authentication_enabled");
        SetOutput("id");
        SetOutput("identifier");
        SetOutput("identifier_prefix");
        SetOutput("instance_class");
        SetOutput("iops");
        SetOutput("kms_key_id");
        SetOutput("license_model");
        SetOutput("maintenance_window");
        SetOutput("manage_master_user_password");
        SetOutput("master_user_secret_kms_key_id");
        SetOutput("max_allocated_storage");
        SetOutput("monitoring_interval");
        SetOutput("monitoring_role_arn");
        SetOutput("multi_az");
        SetOutput("nchar_character_set_name");
        SetOutput("network_type");
        SetOutput("option_group_name");
        SetOutput("parameter_group_name");
        SetOutput("password");
        SetOutput("password_wo");
        SetOutput("password_wo_version");
        SetOutput("performance_insights_enabled");
        SetOutput("performance_insights_kms_key_id");
        SetOutput("performance_insights_retention_period");
        SetOutput("port");
        SetOutput("publicly_accessible");
        SetOutput("region");
        SetOutput("replica_mode");
        SetOutput("replicate_source_db");
        SetOutput("skip_final_snapshot");
        SetOutput("snapshot_identifier");
        SetOutput("storage_encrypted");
        SetOutput("storage_throughput");
        SetOutput("storage_type");
        SetOutput("tags");
        SetOutput("tags_all");
        SetOutput("timezone");
        SetOutput("upgrade_storage_config");
        SetOutput("username");
        SetOutput("vpc_security_group_ids");
    }

    /// <summary>
    /// The allocated_storage attribute.
    /// </summary>
    public TerraformProperty<double> AllocatedStorage
    {
        get => GetRequiredOutput<TerraformProperty<double>>("allocated_storage");
        set => SetProperty("allocated_storage", value);
    }

    /// <summary>
    /// The allow_major_version_upgrade attribute.
    /// </summary>
    public TerraformProperty<bool> AllowMajorVersionUpgrade
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("allow_major_version_upgrade");
        set => SetProperty("allow_major_version_upgrade", value);
    }

    /// <summary>
    /// The apply_immediately attribute.
    /// </summary>
    public TerraformProperty<bool> ApplyImmediately
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("apply_immediately");
        set => SetProperty("apply_immediately", value);
    }

    /// <summary>
    /// The auto_minor_version_upgrade attribute.
    /// </summary>
    public TerraformProperty<bool> AutoMinorVersionUpgrade
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("auto_minor_version_upgrade");
        set => SetProperty("auto_minor_version_upgrade", value);
    }

    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    public TerraformProperty<string> AvailabilityZone
    {
        get => GetRequiredOutput<TerraformProperty<string>>("availability_zone");
        set => SetProperty("availability_zone", value);
    }

    /// <summary>
    /// The backup_retention_period attribute.
    /// </summary>
    public TerraformProperty<double> BackupRetentionPeriod
    {
        get => GetRequiredOutput<TerraformProperty<double>>("backup_retention_period");
        set => SetProperty("backup_retention_period", value);
    }

    /// <summary>
    /// The backup_target attribute.
    /// </summary>
    public TerraformProperty<string> BackupTarget
    {
        get => GetRequiredOutput<TerraformProperty<string>>("backup_target");
        set => SetProperty("backup_target", value);
    }

    /// <summary>
    /// The backup_window attribute.
    /// </summary>
    public TerraformProperty<string> BackupWindow
    {
        get => GetRequiredOutput<TerraformProperty<string>>("backup_window");
        set => SetProperty("backup_window", value);
    }

    /// <summary>
    /// The ca_cert_identifier attribute.
    /// </summary>
    public TerraformProperty<string> CaCertIdentifier
    {
        get => GetRequiredOutput<TerraformProperty<string>>("ca_cert_identifier");
        set => SetProperty("ca_cert_identifier", value);
    }

    /// <summary>
    /// The character_set_name attribute.
    /// </summary>
    public TerraformProperty<string> CharacterSetName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("character_set_name");
        set => SetProperty("character_set_name", value);
    }

    /// <summary>
    /// The copy_tags_to_snapshot attribute.
    /// </summary>
    public TerraformProperty<bool> CopyTagsToSnapshot
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("copy_tags_to_snapshot");
        set => SetProperty("copy_tags_to_snapshot", value);
    }

    /// <summary>
    /// The custom_iam_instance_profile attribute.
    /// </summary>
    public TerraformProperty<string> CustomIamInstanceProfile
    {
        get => GetRequiredOutput<TerraformProperty<string>>("custom_iam_instance_profile");
        set => SetProperty("custom_iam_instance_profile", value);
    }

    /// <summary>
    /// The customer_owned_ip_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> CustomerOwnedIpEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("customer_owned_ip_enabled");
        set => SetProperty("customer_owned_ip_enabled", value);
    }

    /// <summary>
    /// The database_insights_mode attribute.
    /// </summary>
    public TerraformProperty<string> DatabaseInsightsMode
    {
        get => GetRequiredOutput<TerraformProperty<string>>("database_insights_mode");
        set => SetProperty("database_insights_mode", value);
    }

    /// <summary>
    /// The db_name attribute.
    /// </summary>
    public TerraformProperty<string> DbName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("db_name");
        set => SetProperty("db_name", value);
    }

    /// <summary>
    /// The db_subnet_group_name attribute.
    /// </summary>
    public TerraformProperty<string> DbSubnetGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("db_subnet_group_name");
        set => SetProperty("db_subnet_group_name", value);
    }

    /// <summary>
    /// The dedicated_log_volume attribute.
    /// </summary>
    public TerraformProperty<bool> DedicatedLogVolume
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("dedicated_log_volume");
        set => SetProperty("dedicated_log_volume", value);
    }

    /// <summary>
    /// The delete_automated_backups attribute.
    /// </summary>
    public TerraformProperty<bool> DeleteAutomatedBackups
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("delete_automated_backups");
        set => SetProperty("delete_automated_backups", value);
    }

    /// <summary>
    /// The deletion_protection attribute.
    /// </summary>
    public TerraformProperty<bool> DeletionProtection
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("deletion_protection");
        set => SetProperty("deletion_protection", value);
    }

    /// <summary>
    /// The domain attribute.
    /// </summary>
    public TerraformProperty<string> Domain
    {
        get => GetRequiredOutput<TerraformProperty<string>>("domain");
        set => SetProperty("domain", value);
    }

    /// <summary>
    /// The domain_auth_secret_arn attribute.
    /// </summary>
    public TerraformProperty<string> DomainAuthSecretArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("domain_auth_secret_arn");
        set => SetProperty("domain_auth_secret_arn", value);
    }

    /// <summary>
    /// The domain_dns_ips attribute.
    /// </summary>
    public List<TerraformProperty<string>> DomainDnsIps
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("domain_dns_ips");
        set => SetProperty("domain_dns_ips", value);
    }

    /// <summary>
    /// The domain_fqdn attribute.
    /// </summary>
    public TerraformProperty<string> DomainFqdn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("domain_fqdn");
        set => SetProperty("domain_fqdn", value);
    }

    /// <summary>
    /// The domain_iam_role_name attribute.
    /// </summary>
    public TerraformProperty<string> DomainIamRoleName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("domain_iam_role_name");
        set => SetProperty("domain_iam_role_name", value);
    }

    /// <summary>
    /// The domain_ou attribute.
    /// </summary>
    public TerraformProperty<string> DomainOu
    {
        get => GetRequiredOutput<TerraformProperty<string>>("domain_ou");
        set => SetProperty("domain_ou", value);
    }

    /// <summary>
    /// The enabled_cloudwatch_logs_exports attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> EnabledCloudwatchLogsExports
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("enabled_cloudwatch_logs_exports");
        set => SetProperty("enabled_cloudwatch_logs_exports", value);
    }

    /// <summary>
    /// The engine attribute.
    /// </summary>
    public TerraformProperty<string> Engine
    {
        get => GetRequiredOutput<TerraformProperty<string>>("engine");
        set => SetProperty("engine", value);
    }

    /// <summary>
    /// The engine_lifecycle_support attribute.
    /// </summary>
    public TerraformProperty<string> EngineLifecycleSupport
    {
        get => GetRequiredOutput<TerraformProperty<string>>("engine_lifecycle_support");
        set => SetProperty("engine_lifecycle_support", value);
    }

    /// <summary>
    /// The engine_version attribute.
    /// </summary>
    public TerraformProperty<string> EngineVersion
    {
        get => GetRequiredOutput<TerraformProperty<string>>("engine_version");
        set => SetProperty("engine_version", value);
    }

    /// <summary>
    /// The final_snapshot_identifier attribute.
    /// </summary>
    public TerraformProperty<string> FinalSnapshotIdentifier
    {
        get => GetRequiredOutput<TerraformProperty<string>>("final_snapshot_identifier");
        set => SetProperty("final_snapshot_identifier", value);
    }

    /// <summary>
    /// The iam_database_authentication_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> IamDatabaseAuthenticationEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("iam_database_authentication_enabled");
        set => SetProperty("iam_database_authentication_enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The identifier attribute.
    /// </summary>
    public TerraformProperty<string> Identifier
    {
        get => GetRequiredOutput<TerraformProperty<string>>("identifier");
        set => SetProperty("identifier", value);
    }

    /// <summary>
    /// The identifier_prefix attribute.
    /// </summary>
    public TerraformProperty<string> IdentifierPrefix
    {
        get => GetRequiredOutput<TerraformProperty<string>>("identifier_prefix");
        set => SetProperty("identifier_prefix", value);
    }

    /// <summary>
    /// The instance_class attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceClass is required")]
    public required TerraformProperty<string> InstanceClass
    {
        get => GetRequiredOutput<TerraformProperty<string>>("instance_class");
        set => SetProperty("instance_class", value);
    }

    /// <summary>
    /// The iops attribute.
    /// </summary>
    public TerraformProperty<double> Iops
    {
        get => GetRequiredOutput<TerraformProperty<double>>("iops");
        set => SetProperty("iops", value);
    }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformProperty<string> KmsKeyId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("kms_key_id");
        set => SetProperty("kms_key_id", value);
    }

    /// <summary>
    /// The license_model attribute.
    /// </summary>
    public TerraformProperty<string> LicenseModel
    {
        get => GetRequiredOutput<TerraformProperty<string>>("license_model");
        set => SetProperty("license_model", value);
    }

    /// <summary>
    /// The maintenance_window attribute.
    /// </summary>
    public TerraformProperty<string> MaintenanceWindow
    {
        get => GetRequiredOutput<TerraformProperty<string>>("maintenance_window");
        set => SetProperty("maintenance_window", value);
    }

    /// <summary>
    /// The manage_master_user_password attribute.
    /// </summary>
    public TerraformProperty<bool> ManageMasterUserPassword
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("manage_master_user_password");
        set => SetProperty("manage_master_user_password", value);
    }

    /// <summary>
    /// The master_user_secret_kms_key_id attribute.
    /// </summary>
    public TerraformProperty<string> MasterUserSecretKmsKeyId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("master_user_secret_kms_key_id");
        set => SetProperty("master_user_secret_kms_key_id", value);
    }

    /// <summary>
    /// The max_allocated_storage attribute.
    /// </summary>
    public TerraformProperty<double> MaxAllocatedStorage
    {
        get => GetRequiredOutput<TerraformProperty<double>>("max_allocated_storage");
        set => SetProperty("max_allocated_storage", value);
    }

    /// <summary>
    /// The monitoring_interval attribute.
    /// </summary>
    public TerraformProperty<double> MonitoringInterval
    {
        get => GetRequiredOutput<TerraformProperty<double>>("monitoring_interval");
        set => SetProperty("monitoring_interval", value);
    }

    /// <summary>
    /// The monitoring_role_arn attribute.
    /// </summary>
    public TerraformProperty<string> MonitoringRoleArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("monitoring_role_arn");
        set => SetProperty("monitoring_role_arn", value);
    }

    /// <summary>
    /// The multi_az attribute.
    /// </summary>
    public TerraformProperty<bool> MultiAz
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("multi_az");
        set => SetProperty("multi_az", value);
    }

    /// <summary>
    /// The nchar_character_set_name attribute.
    /// </summary>
    public TerraformProperty<string> NcharCharacterSetName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("nchar_character_set_name");
        set => SetProperty("nchar_character_set_name", value);
    }

    /// <summary>
    /// The network_type attribute.
    /// </summary>
    public TerraformProperty<string> NetworkType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("network_type");
        set => SetProperty("network_type", value);
    }

    /// <summary>
    /// The option_group_name attribute.
    /// </summary>
    public TerraformProperty<string> OptionGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("option_group_name");
        set => SetProperty("option_group_name", value);
    }

    /// <summary>
    /// The parameter_group_name attribute.
    /// </summary>
    public TerraformProperty<string> ParameterGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("parameter_group_name");
        set => SetProperty("parameter_group_name", value);
    }

    /// <summary>
    /// The password attribute.
    /// </summary>
    public TerraformProperty<string> Password
    {
        get => GetRequiredOutput<TerraformProperty<string>>("password");
        set => SetProperty("password", value);
    }

    /// <summary>
    /// The password_wo attribute.
    /// </summary>
    public TerraformProperty<string> PasswordWo
    {
        get => GetRequiredOutput<TerraformProperty<string>>("password_wo");
        set => SetProperty("password_wo", value);
    }

    /// <summary>
    /// The password_wo_version attribute.
    /// </summary>
    public TerraformProperty<double> PasswordWoVersion
    {
        get => GetRequiredOutput<TerraformProperty<double>>("password_wo_version");
        set => SetProperty("password_wo_version", value);
    }

    /// <summary>
    /// The performance_insights_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> PerformanceInsightsEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("performance_insights_enabled");
        set => SetProperty("performance_insights_enabled", value);
    }

    /// <summary>
    /// The performance_insights_kms_key_id attribute.
    /// </summary>
    public TerraformProperty<string> PerformanceInsightsKmsKeyId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("performance_insights_kms_key_id");
        set => SetProperty("performance_insights_kms_key_id", value);
    }

    /// <summary>
    /// The performance_insights_retention_period attribute.
    /// </summary>
    public TerraformProperty<double> PerformanceInsightsRetentionPeriod
    {
        get => GetRequiredOutput<TerraformProperty<double>>("performance_insights_retention_period");
        set => SetProperty("performance_insights_retention_period", value);
    }

    /// <summary>
    /// The port attribute.
    /// </summary>
    public TerraformProperty<double> Port
    {
        get => GetRequiredOutput<TerraformProperty<double>>("port");
        set => SetProperty("port", value);
    }

    /// <summary>
    /// The publicly_accessible attribute.
    /// </summary>
    public TerraformProperty<bool> PubliclyAccessible
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("publicly_accessible");
        set => SetProperty("publicly_accessible", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The replica_mode attribute.
    /// </summary>
    public TerraformProperty<string> ReplicaMode
    {
        get => GetRequiredOutput<TerraformProperty<string>>("replica_mode");
        set => SetProperty("replica_mode", value);
    }

    /// <summary>
    /// The replicate_source_db attribute.
    /// </summary>
    public TerraformProperty<string> ReplicateSourceDb
    {
        get => GetRequiredOutput<TerraformProperty<string>>("replicate_source_db");
        set => SetProperty("replicate_source_db", value);
    }

    /// <summary>
    /// The skip_final_snapshot attribute.
    /// </summary>
    public TerraformProperty<bool> SkipFinalSnapshot
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("skip_final_snapshot");
        set => SetProperty("skip_final_snapshot", value);
    }

    /// <summary>
    /// The snapshot_identifier attribute.
    /// </summary>
    public TerraformProperty<string> SnapshotIdentifier
    {
        get => GetRequiredOutput<TerraformProperty<string>>("snapshot_identifier");
        set => SetProperty("snapshot_identifier", value);
    }

    /// <summary>
    /// The storage_encrypted attribute.
    /// </summary>
    public TerraformProperty<bool> StorageEncrypted
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("storage_encrypted");
        set => SetProperty("storage_encrypted", value);
    }

    /// <summary>
    /// The storage_throughput attribute.
    /// </summary>
    public TerraformProperty<double> StorageThroughput
    {
        get => GetRequiredOutput<TerraformProperty<double>>("storage_throughput");
        set => SetProperty("storage_throughput", value);
    }

    /// <summary>
    /// The storage_type attribute.
    /// </summary>
    public TerraformProperty<string> StorageType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("storage_type");
        set => SetProperty("storage_type", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> TagsAll
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => SetProperty("tags_all", value);
    }

    /// <summary>
    /// The timezone attribute.
    /// </summary>
    public TerraformProperty<string> Timezone
    {
        get => GetRequiredOutput<TerraformProperty<string>>("timezone");
        set => SetProperty("timezone", value);
    }

    /// <summary>
    /// The upgrade_storage_config attribute.
    /// </summary>
    public TerraformProperty<bool> UpgradeStorageConfig
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("upgrade_storage_config");
        set => SetProperty("upgrade_storage_config", value);
    }

    /// <summary>
    /// The username attribute.
    /// </summary>
    public TerraformProperty<string> Username
    {
        get => GetRequiredOutput<TerraformProperty<string>>("username");
        set => SetProperty("username", value);
    }

    /// <summary>
    /// The vpc_security_group_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> VpcSecurityGroupIds
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("vpc_security_group_ids");
        set => SetProperty("vpc_security_group_ids", value);
    }

    /// <summary>
    /// Block for blue_green_update.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BlueGreenUpdate block(s) allowed")]
    public List<AwsDbInstanceBlueGreenUpdateBlock>? BlueGreenUpdate
    {
        set => SetProperty("blue_green_update", value);
    }

    /// <summary>
    /// Block for restore_to_point_in_time.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RestoreToPointInTime block(s) allowed")]
    public List<AwsDbInstanceRestoreToPointInTimeBlock>? RestoreToPointInTime
    {
        set => SetProperty("restore_to_point_in_time", value);
    }

    /// <summary>
    /// Block for s3_import.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 S3Import block(s) allowed")]
    public List<AwsDbInstanceS3ImportBlock>? S3Import
    {
        set => SetProperty("s3_import", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsDbInstanceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
