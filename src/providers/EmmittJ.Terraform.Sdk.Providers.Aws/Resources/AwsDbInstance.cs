using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for blue_green_update in AwsDbInstance.
/// Nesting mode: list
/// </summary>
public class AwsDbInstanceBlueGreenUpdateBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "blue_green_update";

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => GetArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

}


/// <summary>
/// Block type for restore_to_point_in_time in AwsDbInstance.
/// Nesting mode: list
/// </summary>
public class AwsDbInstanceRestoreToPointInTimeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "restore_to_point_in_time";

    /// <summary>
    /// The restore_time attribute.
    /// </summary>
    public TerraformValue<string>? RestoreTime
    {
        get => GetArgument<TerraformValue<string>>("restore_time");
        set => SetArgument("restore_time", value);
    }

    /// <summary>
    /// The source_db_instance_automated_backups_arn attribute.
    /// </summary>
    public TerraformValue<string>? SourceDbInstanceAutomatedBackupsArn
    {
        get => GetArgument<TerraformValue<string>>("source_db_instance_automated_backups_arn");
        set => SetArgument("source_db_instance_automated_backups_arn", value);
    }

    /// <summary>
    /// The source_db_instance_identifier attribute.
    /// </summary>
    public TerraformValue<string>? SourceDbInstanceIdentifier
    {
        get => GetArgument<TerraformValue<string>>("source_db_instance_identifier");
        set => SetArgument("source_db_instance_identifier", value);
    }

    /// <summary>
    /// The source_dbi_resource_id attribute.
    /// </summary>
    public TerraformValue<string>? SourceDbiResourceId
    {
        get => GetArgument<TerraformValue<string>>("source_dbi_resource_id");
        set => SetArgument("source_dbi_resource_id", value);
    }

    /// <summary>
    /// The use_latest_restorable_time attribute.
    /// </summary>
    public TerraformValue<bool>? UseLatestRestorableTime
    {
        get => GetArgument<TerraformValue<bool>>("use_latest_restorable_time");
        set => SetArgument("use_latest_restorable_time", value);
    }

}


/// <summary>
/// Block type for s3_import in AwsDbInstance.
/// Nesting mode: list
/// </summary>
public class AwsDbInstanceS3ImportBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "s3_import";

    /// <summary>
    /// The bucket_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BucketName is required")]
    public required TerraformValue<string> BucketName
    {
        get => GetRequiredArgument<TerraformValue<string>>("bucket_name");
        set => SetArgument("bucket_name", value);
    }

    /// <summary>
    /// The bucket_prefix attribute.
    /// </summary>
    public TerraformValue<string>? BucketPrefix
    {
        get => GetArgument<TerraformValue<string>>("bucket_prefix");
        set => SetArgument("bucket_prefix", value);
    }

    /// <summary>
    /// The ingestion_role attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IngestionRole is required")]
    public required TerraformValue<string> IngestionRole
    {
        get => GetRequiredArgument<TerraformValue<string>>("ingestion_role");
        set => SetArgument("ingestion_role", value);
    }

    /// <summary>
    /// The source_engine attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceEngine is required")]
    public required TerraformValue<string> SourceEngine
    {
        get => GetRequiredArgument<TerraformValue<string>>("source_engine");
        set => SetArgument("source_engine", value);
    }

    /// <summary>
    /// The source_engine_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceEngineVersion is required")]
    public required TerraformValue<string> SourceEngineVersion
    {
        get => GetRequiredArgument<TerraformValue<string>>("source_engine_version");
        set => SetArgument("source_engine_version", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsDbInstance.
/// Nesting mode: single
/// </summary>
public class AwsDbInstanceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a aws_db_instance Terraform resource.
/// Manages a aws_db_instance resource.
/// </summary>
public partial class AwsDbInstance(string name) : TerraformResource("aws_db_instance", name)
{
    /// <summary>
    /// The allocated_storage attribute.
    /// </summary>
    public TerraformValue<double> AllocatedStorage
    {
        get => GetArgument<TerraformValue<double>>("allocated_storage") ?? CreateReference("allocated_storage");
        set => SetArgument("allocated_storage", value);
    }

    /// <summary>
    /// The allow_major_version_upgrade attribute.
    /// </summary>
    public TerraformValue<bool>? AllowMajorVersionUpgrade
    {
        get => GetArgument<TerraformValue<bool>>("allow_major_version_upgrade");
        set => SetArgument("allow_major_version_upgrade", value);
    }

    /// <summary>
    /// The apply_immediately attribute.
    /// </summary>
    public TerraformValue<bool>? ApplyImmediately
    {
        get => GetArgument<TerraformValue<bool>>("apply_immediately");
        set => SetArgument("apply_immediately", value);
    }

    /// <summary>
    /// The auto_minor_version_upgrade attribute.
    /// </summary>
    public TerraformValue<bool>? AutoMinorVersionUpgrade
    {
        get => GetArgument<TerraformValue<bool>>("auto_minor_version_upgrade");
        set => SetArgument("auto_minor_version_upgrade", value);
    }

    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    public TerraformValue<string> AvailabilityZone
    {
        get => GetArgument<TerraformValue<string>>("availability_zone") ?? CreateReference("availability_zone");
        set => SetArgument("availability_zone", value);
    }

    /// <summary>
    /// The backup_retention_period attribute.
    /// </summary>
    public TerraformValue<double> BackupRetentionPeriod
    {
        get => GetArgument<TerraformValue<double>>("backup_retention_period") ?? CreateReference("backup_retention_period");
        set => SetArgument("backup_retention_period", value);
    }

    /// <summary>
    /// The backup_target attribute.
    /// </summary>
    public TerraformValue<string> BackupTarget
    {
        get => GetArgument<TerraformValue<string>>("backup_target") ?? CreateReference("backup_target");
        set => SetArgument("backup_target", value);
    }

    /// <summary>
    /// The backup_window attribute.
    /// </summary>
    public TerraformValue<string> BackupWindow
    {
        get => GetArgument<TerraformValue<string>>("backup_window") ?? CreateReference("backup_window");
        set => SetArgument("backup_window", value);
    }

    /// <summary>
    /// The ca_cert_identifier attribute.
    /// </summary>
    public TerraformValue<string> CaCertIdentifier
    {
        get => GetArgument<TerraformValue<string>>("ca_cert_identifier") ?? CreateReference("ca_cert_identifier");
        set => SetArgument("ca_cert_identifier", value);
    }

    /// <summary>
    /// The character_set_name attribute.
    /// </summary>
    public TerraformValue<string> CharacterSetName
    {
        get => GetArgument<TerraformValue<string>>("character_set_name") ?? CreateReference("character_set_name");
        set => SetArgument("character_set_name", value);
    }

    /// <summary>
    /// The copy_tags_to_snapshot attribute.
    /// </summary>
    public TerraformValue<bool>? CopyTagsToSnapshot
    {
        get => GetArgument<TerraformValue<bool>>("copy_tags_to_snapshot");
        set => SetArgument("copy_tags_to_snapshot", value);
    }

    /// <summary>
    /// The custom_iam_instance_profile attribute.
    /// </summary>
    public TerraformValue<string>? CustomIamInstanceProfile
    {
        get => GetArgument<TerraformValue<string>>("custom_iam_instance_profile");
        set => SetArgument("custom_iam_instance_profile", value);
    }

    /// <summary>
    /// The customer_owned_ip_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? CustomerOwnedIpEnabled
    {
        get => GetArgument<TerraformValue<bool>>("customer_owned_ip_enabled");
        set => SetArgument("customer_owned_ip_enabled", value);
    }

    /// <summary>
    /// The database_insights_mode attribute.
    /// </summary>
    public TerraformValue<string> DatabaseInsightsMode
    {
        get => GetArgument<TerraformValue<string>>("database_insights_mode") ?? CreateReference("database_insights_mode");
        set => SetArgument("database_insights_mode", value);
    }

    /// <summary>
    /// The db_name attribute.
    /// </summary>
    public TerraformValue<string> DbName
    {
        get => GetArgument<TerraformValue<string>>("db_name") ?? CreateReference("db_name");
        set => SetArgument("db_name", value);
    }

    /// <summary>
    /// The db_subnet_group_name attribute.
    /// </summary>
    public TerraformValue<string> DbSubnetGroupName
    {
        get => GetArgument<TerraformValue<string>>("db_subnet_group_name") ?? CreateReference("db_subnet_group_name");
        set => SetArgument("db_subnet_group_name", value);
    }

    /// <summary>
    /// The dedicated_log_volume attribute.
    /// </summary>
    public TerraformValue<bool>? DedicatedLogVolume
    {
        get => GetArgument<TerraformValue<bool>>("dedicated_log_volume");
        set => SetArgument("dedicated_log_volume", value);
    }

    /// <summary>
    /// The delete_automated_backups attribute.
    /// </summary>
    public TerraformValue<bool>? DeleteAutomatedBackups
    {
        get => GetArgument<TerraformValue<bool>>("delete_automated_backups");
        set => SetArgument("delete_automated_backups", value);
    }

    /// <summary>
    /// The deletion_protection attribute.
    /// </summary>
    public TerraformValue<bool>? DeletionProtection
    {
        get => GetArgument<TerraformValue<bool>>("deletion_protection");
        set => SetArgument("deletion_protection", value);
    }

    /// <summary>
    /// The domain attribute.
    /// </summary>
    public TerraformValue<string>? Domain
    {
        get => GetArgument<TerraformValue<string>>("domain");
        set => SetArgument("domain", value);
    }

    /// <summary>
    /// The domain_auth_secret_arn attribute.
    /// </summary>
    public TerraformValue<string>? DomainAuthSecretArn
    {
        get => GetArgument<TerraformValue<string>>("domain_auth_secret_arn");
        set => SetArgument("domain_auth_secret_arn", value);
    }

    /// <summary>
    /// The domain_dns_ips attribute.
    /// </summary>
    public TerraformList<string>? DomainDnsIps
    {
        get => GetArgument<TerraformList<string>>("domain_dns_ips");
        set => SetArgument("domain_dns_ips", value);
    }

    /// <summary>
    /// The domain_fqdn attribute.
    /// </summary>
    public TerraformValue<string> DomainFqdn
    {
        get => GetArgument<TerraformValue<string>>("domain_fqdn") ?? CreateReference("domain_fqdn");
        set => SetArgument("domain_fqdn", value);
    }

    /// <summary>
    /// The domain_iam_role_name attribute.
    /// </summary>
    public TerraformValue<string>? DomainIamRoleName
    {
        get => GetArgument<TerraformValue<string>>("domain_iam_role_name");
        set => SetArgument("domain_iam_role_name", value);
    }

    /// <summary>
    /// The domain_ou attribute.
    /// </summary>
    public TerraformValue<string>? DomainOu
    {
        get => GetArgument<TerraformValue<string>>("domain_ou");
        set => SetArgument("domain_ou", value);
    }

    /// <summary>
    /// The enabled_cloudwatch_logs_exports attribute.
    /// </summary>
    public TerraformSet<string>? EnabledCloudwatchLogsExports
    {
        get => GetArgument<TerraformSet<string>>("enabled_cloudwatch_logs_exports");
        set => SetArgument("enabled_cloudwatch_logs_exports", value);
    }

    /// <summary>
    /// The engine attribute.
    /// </summary>
    public TerraformValue<string> Engine
    {
        get => GetArgument<TerraformValue<string>>("engine") ?? CreateReference("engine");
        set => SetArgument("engine", value);
    }

    /// <summary>
    /// The engine_lifecycle_support attribute.
    /// </summary>
    public TerraformValue<string> EngineLifecycleSupport
    {
        get => GetArgument<TerraformValue<string>>("engine_lifecycle_support") ?? CreateReference("engine_lifecycle_support");
        set => SetArgument("engine_lifecycle_support", value);
    }

    /// <summary>
    /// The engine_version attribute.
    /// </summary>
    public TerraformValue<string> EngineVersion
    {
        get => GetArgument<TerraformValue<string>>("engine_version") ?? CreateReference("engine_version");
        set => SetArgument("engine_version", value);
    }

    /// <summary>
    /// The final_snapshot_identifier attribute.
    /// </summary>
    public TerraformValue<string>? FinalSnapshotIdentifier
    {
        get => GetArgument<TerraformValue<string>>("final_snapshot_identifier");
        set => SetArgument("final_snapshot_identifier", value);
    }

    /// <summary>
    /// The iam_database_authentication_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? IamDatabaseAuthenticationEnabled
    {
        get => GetArgument<TerraformValue<bool>>("iam_database_authentication_enabled");
        set => SetArgument("iam_database_authentication_enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The identifier attribute.
    /// </summary>
    public TerraformValue<string> Identifier
    {
        get => GetArgument<TerraformValue<string>>("identifier") ?? CreateReference("identifier");
        set => SetArgument("identifier", value);
    }

    /// <summary>
    /// The identifier_prefix attribute.
    /// </summary>
    public TerraformValue<string> IdentifierPrefix
    {
        get => GetArgument<TerraformValue<string>>("identifier_prefix") ?? CreateReference("identifier_prefix");
        set => SetArgument("identifier_prefix", value);
    }

    /// <summary>
    /// The instance_class attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceClass is required")]
    public required TerraformValue<string> InstanceClass
    {
        get => GetRequiredArgument<TerraformValue<string>>("instance_class");
        set => SetArgument("instance_class", value);
    }

    /// <summary>
    /// The iops attribute.
    /// </summary>
    public TerraformValue<double> Iops
    {
        get => GetArgument<TerraformValue<double>>("iops") ?? CreateReference("iops");
        set => SetArgument("iops", value);
    }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformValue<string> KmsKeyId
    {
        get => GetArgument<TerraformValue<string>>("kms_key_id") ?? CreateReference("kms_key_id");
        set => SetArgument("kms_key_id", value);
    }

    /// <summary>
    /// The license_model attribute.
    /// </summary>
    public TerraformValue<string> LicenseModel
    {
        get => GetArgument<TerraformValue<string>>("license_model") ?? CreateReference("license_model");
        set => SetArgument("license_model", value);
    }

    /// <summary>
    /// The maintenance_window attribute.
    /// </summary>
    public TerraformValue<string> MaintenanceWindow
    {
        get => GetArgument<TerraformValue<string>>("maintenance_window") ?? CreateReference("maintenance_window");
        set => SetArgument("maintenance_window", value);
    }

    /// <summary>
    /// The manage_master_user_password attribute.
    /// </summary>
    public TerraformValue<bool>? ManageMasterUserPassword
    {
        get => GetArgument<TerraformValue<bool>>("manage_master_user_password");
        set => SetArgument("manage_master_user_password", value);
    }

    /// <summary>
    /// The master_user_secret_kms_key_id attribute.
    /// </summary>
    public TerraformValue<string> MasterUserSecretKmsKeyId
    {
        get => GetArgument<TerraformValue<string>>("master_user_secret_kms_key_id") ?? CreateReference("master_user_secret_kms_key_id");
        set => SetArgument("master_user_secret_kms_key_id", value);
    }

    /// <summary>
    /// The max_allocated_storage attribute.
    /// </summary>
    public TerraformValue<double>? MaxAllocatedStorage
    {
        get => GetArgument<TerraformValue<double>>("max_allocated_storage");
        set => SetArgument("max_allocated_storage", value);
    }

    /// <summary>
    /// The monitoring_interval attribute.
    /// </summary>
    public TerraformValue<double>? MonitoringInterval
    {
        get => GetArgument<TerraformValue<double>>("monitoring_interval");
        set => SetArgument("monitoring_interval", value);
    }

    /// <summary>
    /// The monitoring_role_arn attribute.
    /// </summary>
    public TerraformValue<string> MonitoringRoleArn
    {
        get => GetArgument<TerraformValue<string>>("monitoring_role_arn") ?? CreateReference("monitoring_role_arn");
        set => SetArgument("monitoring_role_arn", value);
    }

    /// <summary>
    /// The multi_az attribute.
    /// </summary>
    public TerraformValue<bool> MultiAz
    {
        get => GetArgument<TerraformValue<bool>>("multi_az") ?? CreateReference("multi_az");
        set => SetArgument("multi_az", value);
    }

    /// <summary>
    /// The nchar_character_set_name attribute.
    /// </summary>
    public TerraformValue<string> NcharCharacterSetName
    {
        get => GetArgument<TerraformValue<string>>("nchar_character_set_name") ?? CreateReference("nchar_character_set_name");
        set => SetArgument("nchar_character_set_name", value);
    }

    /// <summary>
    /// The network_type attribute.
    /// </summary>
    public TerraformValue<string> NetworkType
    {
        get => GetArgument<TerraformValue<string>>("network_type") ?? CreateReference("network_type");
        set => SetArgument("network_type", value);
    }

    /// <summary>
    /// The option_group_name attribute.
    /// </summary>
    public TerraformValue<string> OptionGroupName
    {
        get => GetArgument<TerraformValue<string>>("option_group_name") ?? CreateReference("option_group_name");
        set => SetArgument("option_group_name", value);
    }

    /// <summary>
    /// The parameter_group_name attribute.
    /// </summary>
    public TerraformValue<string> ParameterGroupName
    {
        get => GetArgument<TerraformValue<string>>("parameter_group_name") ?? CreateReference("parameter_group_name");
        set => SetArgument("parameter_group_name", value);
    }

    /// <summary>
    /// The password attribute.
    /// </summary>
    public TerraformValue<string>? Password
    {
        get => GetArgument<TerraformValue<string>>("password");
        set => SetArgument("password", value);
    }

    /// <summary>
    /// The password_wo attribute.
    /// </summary>
    public TerraformValue<string>? PasswordWo
    {
        get => GetArgument<TerraformValue<string>>("password_wo");
        set => SetArgument("password_wo", value);
    }

    /// <summary>
    /// The password_wo_version attribute.
    /// </summary>
    public TerraformValue<double>? PasswordWoVersion
    {
        get => GetArgument<TerraformValue<double>>("password_wo_version");
        set => SetArgument("password_wo_version", value);
    }

    /// <summary>
    /// The performance_insights_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? PerformanceInsightsEnabled
    {
        get => GetArgument<TerraformValue<bool>>("performance_insights_enabled");
        set => SetArgument("performance_insights_enabled", value);
    }

    /// <summary>
    /// The performance_insights_kms_key_id attribute.
    /// </summary>
    public TerraformValue<string> PerformanceInsightsKmsKeyId
    {
        get => GetArgument<TerraformValue<string>>("performance_insights_kms_key_id") ?? CreateReference("performance_insights_kms_key_id");
        set => SetArgument("performance_insights_kms_key_id", value);
    }

    /// <summary>
    /// The performance_insights_retention_period attribute.
    /// </summary>
    public TerraformValue<double> PerformanceInsightsRetentionPeriod
    {
        get => GetArgument<TerraformValue<double>>("performance_insights_retention_period") ?? CreateReference("performance_insights_retention_period");
        set => SetArgument("performance_insights_retention_period", value);
    }

    /// <summary>
    /// The port attribute.
    /// </summary>
    public TerraformValue<double> Port
    {
        get => GetArgument<TerraformValue<double>>("port") ?? CreateReference("port");
        set => SetArgument("port", value);
    }

    /// <summary>
    /// The publicly_accessible attribute.
    /// </summary>
    public TerraformValue<bool>? PubliclyAccessible
    {
        get => GetArgument<TerraformValue<bool>>("publicly_accessible");
        set => SetArgument("publicly_accessible", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The replica_mode attribute.
    /// </summary>
    public TerraformValue<string> ReplicaMode
    {
        get => GetArgument<TerraformValue<string>>("replica_mode") ?? CreateReference("replica_mode");
        set => SetArgument("replica_mode", value);
    }

    /// <summary>
    /// The replicate_source_db attribute.
    /// </summary>
    public TerraformValue<string>? ReplicateSourceDb
    {
        get => GetArgument<TerraformValue<string>>("replicate_source_db");
        set => SetArgument("replicate_source_db", value);
    }

    /// <summary>
    /// The skip_final_snapshot attribute.
    /// </summary>
    public TerraformValue<bool>? SkipFinalSnapshot
    {
        get => GetArgument<TerraformValue<bool>>("skip_final_snapshot");
        set => SetArgument("skip_final_snapshot", value);
    }

    /// <summary>
    /// The snapshot_identifier attribute.
    /// </summary>
    public TerraformValue<string> SnapshotIdentifier
    {
        get => GetArgument<TerraformValue<string>>("snapshot_identifier") ?? CreateReference("snapshot_identifier");
        set => SetArgument("snapshot_identifier", value);
    }

    /// <summary>
    /// The storage_encrypted attribute.
    /// </summary>
    public TerraformValue<bool>? StorageEncrypted
    {
        get => GetArgument<TerraformValue<bool>>("storage_encrypted");
        set => SetArgument("storage_encrypted", value);
    }

    /// <summary>
    /// The storage_throughput attribute.
    /// </summary>
    public TerraformValue<double> StorageThroughput
    {
        get => GetArgument<TerraformValue<double>>("storage_throughput") ?? CreateReference("storage_throughput");
        set => SetArgument("storage_throughput", value);
    }

    /// <summary>
    /// The storage_type attribute.
    /// </summary>
    public TerraformValue<string> StorageType
    {
        get => GetArgument<TerraformValue<string>>("storage_type") ?? CreateReference("storage_type");
        set => SetArgument("storage_type", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all") ?? CreateReference("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The timezone attribute.
    /// </summary>
    public TerraformValue<string> Timezone
    {
        get => GetArgument<TerraformValue<string>>("timezone") ?? CreateReference("timezone");
        set => SetArgument("timezone", value);
    }

    /// <summary>
    /// The upgrade_storage_config attribute.
    /// </summary>
    public TerraformValue<bool>? UpgradeStorageConfig
    {
        get => GetArgument<TerraformValue<bool>>("upgrade_storage_config");
        set => SetArgument("upgrade_storage_config", value);
    }

    /// <summary>
    /// The username attribute.
    /// </summary>
    public TerraformValue<string> Username
    {
        get => GetArgument<TerraformValue<string>>("username") ?? CreateReference("username");
        set => SetArgument("username", value);
    }

    /// <summary>
    /// The vpc_security_group_ids attribute.
    /// </summary>
    public TerraformSet<string> VpcSecurityGroupIds
    {
        get => GetArgument<TerraformSet<string>>("vpc_security_group_ids") ?? CreateReference("vpc_security_group_ids");
        set => SetArgument("vpc_security_group_ids", value);
    }

    /// <summary>
    /// The address attribute.
    /// </summary>
    public TerraformValue<string> Address
        => CreateReference("address");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => CreateReference("arn");

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    public TerraformValue<string> Endpoint
        => CreateReference("endpoint");

    /// <summary>
    /// The engine_version_actual attribute.
    /// </summary>
    public TerraformValue<string> EngineVersionActual
        => CreateReference("engine_version_actual");

    /// <summary>
    /// The hosted_zone_id attribute.
    /// </summary>
    public TerraformValue<string> HostedZoneId
        => CreateReference("hosted_zone_id");

    /// <summary>
    /// The latest_restorable_time attribute.
    /// </summary>
    public TerraformValue<string> LatestRestorableTime
        => CreateReference("latest_restorable_time");

    /// <summary>
    /// The listener_endpoint attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> ListenerEndpoint
        => CreateReference("listener_endpoint");

    /// <summary>
    /// The master_user_secret attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> MasterUserSecret
        => CreateReference("master_user_secret");

    /// <summary>
    /// The replicas attribute.
    /// </summary>
    public TerraformList<string> Replicas
        => CreateReference("replicas");

    /// <summary>
    /// The resource_id attribute.
    /// </summary>
    public TerraformValue<string> ResourceId
        => CreateReference("resource_id");

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
        => CreateReference("status");

    /// <summary>
    /// BlueGreenUpdate block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BlueGreenUpdate block(s) allowed")]
    public TerraformList<AwsDbInstanceBlueGreenUpdateBlock>? BlueGreenUpdate
    {
        get => GetArgument<TerraformList<AwsDbInstanceBlueGreenUpdateBlock>>("blue_green_update");
        set => SetArgument("blue_green_update", value);
    }

    /// <summary>
    /// RestoreToPointInTime block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RestoreToPointInTime block(s) allowed")]
    public TerraformList<AwsDbInstanceRestoreToPointInTimeBlock>? RestoreToPointInTime
    {
        get => GetArgument<TerraformList<AwsDbInstanceRestoreToPointInTimeBlock>>("restore_to_point_in_time");
        set => SetArgument("restore_to_point_in_time", value);
    }

    /// <summary>
    /// S3Import block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 S3Import block(s) allowed")]
    public TerraformList<AwsDbInstanceS3ImportBlock>? S3Import
    {
        get => GetArgument<TerraformList<AwsDbInstanceS3ImportBlock>>("s3_import");
        set => SetArgument("s3_import", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsDbInstanceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsDbInstanceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
