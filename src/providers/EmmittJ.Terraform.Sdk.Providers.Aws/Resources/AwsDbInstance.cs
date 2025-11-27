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
        get => new TerraformReference<bool>(this, "enabled");
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
        get => new TerraformReference<string>(this, "restore_time");
        set => SetArgument("restore_time", value);
    }

    /// <summary>
    /// The source_db_instance_automated_backups_arn attribute.
    /// </summary>
    public TerraformValue<string>? SourceDbInstanceAutomatedBackupsArn
    {
        get => new TerraformReference<string>(this, "source_db_instance_automated_backups_arn");
        set => SetArgument("source_db_instance_automated_backups_arn", value);
    }

    /// <summary>
    /// The source_db_instance_identifier attribute.
    /// </summary>
    public TerraformValue<string>? SourceDbInstanceIdentifier
    {
        get => new TerraformReference<string>(this, "source_db_instance_identifier");
        set => SetArgument("source_db_instance_identifier", value);
    }

    /// <summary>
    /// The source_dbi_resource_id attribute.
    /// </summary>
    public TerraformValue<string>? SourceDbiResourceId
    {
        get => new TerraformReference<string>(this, "source_dbi_resource_id");
        set => SetArgument("source_dbi_resource_id", value);
    }

    /// <summary>
    /// The use_latest_restorable_time attribute.
    /// </summary>
    public TerraformValue<bool>? UseLatestRestorableTime
    {
        get => new TerraformReference<bool>(this, "use_latest_restorable_time");
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
        get => new TerraformReference<string>(this, "bucket_name");
        set => SetArgument("bucket_name", value);
    }

    /// <summary>
    /// The bucket_prefix attribute.
    /// </summary>
    public TerraformValue<string>? BucketPrefix
    {
        get => new TerraformReference<string>(this, "bucket_prefix");
        set => SetArgument("bucket_prefix", value);
    }

    /// <summary>
    /// The ingestion_role attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IngestionRole is required")]
    public required TerraformValue<string> IngestionRole
    {
        get => new TerraformReference<string>(this, "ingestion_role");
        set => SetArgument("ingestion_role", value);
    }

    /// <summary>
    /// The source_engine attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceEngine is required")]
    public required TerraformValue<string> SourceEngine
    {
        get => new TerraformReference<string>(this, "source_engine");
        set => SetArgument("source_engine", value);
    }

    /// <summary>
    /// The source_engine_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceEngineVersion is required")]
    public required TerraformValue<string> SourceEngineVersion
    {
        get => new TerraformReference<string>(this, "source_engine_version");
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
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
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
        get => new TerraformReference<double>(this, "allocated_storage");
        set => SetArgument("allocated_storage", value);
    }

    /// <summary>
    /// The allow_major_version_upgrade attribute.
    /// </summary>
    public TerraformValue<bool>? AllowMajorVersionUpgrade
    {
        get => new TerraformReference<bool>(this, "allow_major_version_upgrade");
        set => SetArgument("allow_major_version_upgrade", value);
    }

    /// <summary>
    /// The apply_immediately attribute.
    /// </summary>
    public TerraformValue<bool>? ApplyImmediately
    {
        get => new TerraformReference<bool>(this, "apply_immediately");
        set => SetArgument("apply_immediately", value);
    }

    /// <summary>
    /// The auto_minor_version_upgrade attribute.
    /// </summary>
    public TerraformValue<bool>? AutoMinorVersionUpgrade
    {
        get => new TerraformReference<bool>(this, "auto_minor_version_upgrade");
        set => SetArgument("auto_minor_version_upgrade", value);
    }

    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    public TerraformValue<string> AvailabilityZone
    {
        get => new TerraformReference<string>(this, "availability_zone");
        set => SetArgument("availability_zone", value);
    }

    /// <summary>
    /// The backup_retention_period attribute.
    /// </summary>
    public TerraformValue<double> BackupRetentionPeriod
    {
        get => new TerraformReference<double>(this, "backup_retention_period");
        set => SetArgument("backup_retention_period", value);
    }

    /// <summary>
    /// The backup_target attribute.
    /// </summary>
    public TerraformValue<string> BackupTarget
    {
        get => new TerraformReference<string>(this, "backup_target");
        set => SetArgument("backup_target", value);
    }

    /// <summary>
    /// The backup_window attribute.
    /// </summary>
    public TerraformValue<string> BackupWindow
    {
        get => new TerraformReference<string>(this, "backup_window");
        set => SetArgument("backup_window", value);
    }

    /// <summary>
    /// The ca_cert_identifier attribute.
    /// </summary>
    public TerraformValue<string> CaCertIdentifier
    {
        get => new TerraformReference<string>(this, "ca_cert_identifier");
        set => SetArgument("ca_cert_identifier", value);
    }

    /// <summary>
    /// The character_set_name attribute.
    /// </summary>
    public TerraformValue<string> CharacterSetName
    {
        get => new TerraformReference<string>(this, "character_set_name");
        set => SetArgument("character_set_name", value);
    }

    /// <summary>
    /// The copy_tags_to_snapshot attribute.
    /// </summary>
    public TerraformValue<bool>? CopyTagsToSnapshot
    {
        get => new TerraformReference<bool>(this, "copy_tags_to_snapshot");
        set => SetArgument("copy_tags_to_snapshot", value);
    }

    /// <summary>
    /// The custom_iam_instance_profile attribute.
    /// </summary>
    public TerraformValue<string>? CustomIamInstanceProfile
    {
        get => new TerraformReference<string>(this, "custom_iam_instance_profile");
        set => SetArgument("custom_iam_instance_profile", value);
    }

    /// <summary>
    /// The customer_owned_ip_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? CustomerOwnedIpEnabled
    {
        get => new TerraformReference<bool>(this, "customer_owned_ip_enabled");
        set => SetArgument("customer_owned_ip_enabled", value);
    }

    /// <summary>
    /// The database_insights_mode attribute.
    /// </summary>
    public TerraformValue<string> DatabaseInsightsMode
    {
        get => new TerraformReference<string>(this, "database_insights_mode");
        set => SetArgument("database_insights_mode", value);
    }

    /// <summary>
    /// The db_name attribute.
    /// </summary>
    public TerraformValue<string> DbName
    {
        get => new TerraformReference<string>(this, "db_name");
        set => SetArgument("db_name", value);
    }

    /// <summary>
    /// The db_subnet_group_name attribute.
    /// </summary>
    public TerraformValue<string> DbSubnetGroupName
    {
        get => new TerraformReference<string>(this, "db_subnet_group_name");
        set => SetArgument("db_subnet_group_name", value);
    }

    /// <summary>
    /// The dedicated_log_volume attribute.
    /// </summary>
    public TerraformValue<bool>? DedicatedLogVolume
    {
        get => new TerraformReference<bool>(this, "dedicated_log_volume");
        set => SetArgument("dedicated_log_volume", value);
    }

    /// <summary>
    /// The delete_automated_backups attribute.
    /// </summary>
    public TerraformValue<bool>? DeleteAutomatedBackups
    {
        get => new TerraformReference<bool>(this, "delete_automated_backups");
        set => SetArgument("delete_automated_backups", value);
    }

    /// <summary>
    /// The deletion_protection attribute.
    /// </summary>
    public TerraformValue<bool>? DeletionProtection
    {
        get => new TerraformReference<bool>(this, "deletion_protection");
        set => SetArgument("deletion_protection", value);
    }

    /// <summary>
    /// The domain attribute.
    /// </summary>
    public TerraformValue<string>? Domain
    {
        get => new TerraformReference<string>(this, "domain");
        set => SetArgument("domain", value);
    }

    /// <summary>
    /// The domain_auth_secret_arn attribute.
    /// </summary>
    public TerraformValue<string>? DomainAuthSecretArn
    {
        get => new TerraformReference<string>(this, "domain_auth_secret_arn");
        set => SetArgument("domain_auth_secret_arn", value);
    }

    /// <summary>
    /// The domain_dns_ips attribute.
    /// </summary>
    public TerraformList<string>? DomainDnsIps
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "domain_dns_ips").ResolveNodes(ctx));
        set => SetArgument("domain_dns_ips", value);
    }

    /// <summary>
    /// The domain_fqdn attribute.
    /// </summary>
    public TerraformValue<string> DomainFqdn
    {
        get => new TerraformReference<string>(this, "domain_fqdn");
        set => SetArgument("domain_fqdn", value);
    }

    /// <summary>
    /// The domain_iam_role_name attribute.
    /// </summary>
    public TerraformValue<string>? DomainIamRoleName
    {
        get => new TerraformReference<string>(this, "domain_iam_role_name");
        set => SetArgument("domain_iam_role_name", value);
    }

    /// <summary>
    /// The domain_ou attribute.
    /// </summary>
    public TerraformValue<string>? DomainOu
    {
        get => new TerraformReference<string>(this, "domain_ou");
        set => SetArgument("domain_ou", value);
    }

    /// <summary>
    /// The enabled_cloudwatch_logs_exports attribute.
    /// </summary>
    public TerraformSet<string>? EnabledCloudwatchLogsExports
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "enabled_cloudwatch_logs_exports").ResolveNodes(ctx));
        set => SetArgument("enabled_cloudwatch_logs_exports", value);
    }

    /// <summary>
    /// The engine attribute.
    /// </summary>
    public TerraformValue<string> Engine
    {
        get => new TerraformReference<string>(this, "engine");
        set => SetArgument("engine", value);
    }

    /// <summary>
    /// The engine_lifecycle_support attribute.
    /// </summary>
    public TerraformValue<string> EngineLifecycleSupport
    {
        get => new TerraformReference<string>(this, "engine_lifecycle_support");
        set => SetArgument("engine_lifecycle_support", value);
    }

    /// <summary>
    /// The engine_version attribute.
    /// </summary>
    public TerraformValue<string> EngineVersion
    {
        get => new TerraformReference<string>(this, "engine_version");
        set => SetArgument("engine_version", value);
    }

    /// <summary>
    /// The final_snapshot_identifier attribute.
    /// </summary>
    public TerraformValue<string>? FinalSnapshotIdentifier
    {
        get => new TerraformReference<string>(this, "final_snapshot_identifier");
        set => SetArgument("final_snapshot_identifier", value);
    }

    /// <summary>
    /// The iam_database_authentication_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? IamDatabaseAuthenticationEnabled
    {
        get => new TerraformReference<bool>(this, "iam_database_authentication_enabled");
        set => SetArgument("iam_database_authentication_enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The identifier attribute.
    /// </summary>
    public TerraformValue<string> Identifier
    {
        get => new TerraformReference<string>(this, "identifier");
        set => SetArgument("identifier", value);
    }

    /// <summary>
    /// The identifier_prefix attribute.
    /// </summary>
    public TerraformValue<string> IdentifierPrefix
    {
        get => new TerraformReference<string>(this, "identifier_prefix");
        set => SetArgument("identifier_prefix", value);
    }

    /// <summary>
    /// The instance_class attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceClass is required")]
    public required TerraformValue<string> InstanceClass
    {
        get => new TerraformReference<string>(this, "instance_class");
        set => SetArgument("instance_class", value);
    }

    /// <summary>
    /// The iops attribute.
    /// </summary>
    public TerraformValue<double> Iops
    {
        get => new TerraformReference<double>(this, "iops");
        set => SetArgument("iops", value);
    }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformValue<string> KmsKeyId
    {
        get => new TerraformReference<string>(this, "kms_key_id");
        set => SetArgument("kms_key_id", value);
    }

    /// <summary>
    /// The license_model attribute.
    /// </summary>
    public TerraformValue<string> LicenseModel
    {
        get => new TerraformReference<string>(this, "license_model");
        set => SetArgument("license_model", value);
    }

    /// <summary>
    /// The maintenance_window attribute.
    /// </summary>
    public TerraformValue<string> MaintenanceWindow
    {
        get => new TerraformReference<string>(this, "maintenance_window");
        set => SetArgument("maintenance_window", value);
    }

    /// <summary>
    /// The manage_master_user_password attribute.
    /// </summary>
    public TerraformValue<bool>? ManageMasterUserPassword
    {
        get => new TerraformReference<bool>(this, "manage_master_user_password");
        set => SetArgument("manage_master_user_password", value);
    }

    /// <summary>
    /// The master_user_secret_kms_key_id attribute.
    /// </summary>
    public TerraformValue<string> MasterUserSecretKmsKeyId
    {
        get => new TerraformReference<string>(this, "master_user_secret_kms_key_id");
        set => SetArgument("master_user_secret_kms_key_id", value);
    }

    /// <summary>
    /// The max_allocated_storage attribute.
    /// </summary>
    public TerraformValue<double>? MaxAllocatedStorage
    {
        get => new TerraformReference<double>(this, "max_allocated_storage");
        set => SetArgument("max_allocated_storage", value);
    }

    /// <summary>
    /// The monitoring_interval attribute.
    /// </summary>
    public TerraformValue<double>? MonitoringInterval
    {
        get => new TerraformReference<double>(this, "monitoring_interval");
        set => SetArgument("monitoring_interval", value);
    }

    /// <summary>
    /// The monitoring_role_arn attribute.
    /// </summary>
    public TerraformValue<string> MonitoringRoleArn
    {
        get => new TerraformReference<string>(this, "monitoring_role_arn");
        set => SetArgument("monitoring_role_arn", value);
    }

    /// <summary>
    /// The multi_az attribute.
    /// </summary>
    public TerraformValue<bool> MultiAz
    {
        get => new TerraformReference<bool>(this, "multi_az");
        set => SetArgument("multi_az", value);
    }

    /// <summary>
    /// The nchar_character_set_name attribute.
    /// </summary>
    public TerraformValue<string> NcharCharacterSetName
    {
        get => new TerraformReference<string>(this, "nchar_character_set_name");
        set => SetArgument("nchar_character_set_name", value);
    }

    /// <summary>
    /// The network_type attribute.
    /// </summary>
    public TerraformValue<string> NetworkType
    {
        get => new TerraformReference<string>(this, "network_type");
        set => SetArgument("network_type", value);
    }

    /// <summary>
    /// The option_group_name attribute.
    /// </summary>
    public TerraformValue<string> OptionGroupName
    {
        get => new TerraformReference<string>(this, "option_group_name");
        set => SetArgument("option_group_name", value);
    }

    /// <summary>
    /// The parameter_group_name attribute.
    /// </summary>
    public TerraformValue<string> ParameterGroupName
    {
        get => new TerraformReference<string>(this, "parameter_group_name");
        set => SetArgument("parameter_group_name", value);
    }

    /// <summary>
    /// The password attribute.
    /// </summary>
    public TerraformValue<string>? Password
    {
        get => new TerraformReference<string>(this, "password");
        set => SetArgument("password", value);
    }

    /// <summary>
    /// The password_wo attribute.
    /// </summary>
    public TerraformValue<string>? PasswordWo
    {
        get => new TerraformReference<string>(this, "password_wo");
        set => SetArgument("password_wo", value);
    }

    /// <summary>
    /// The password_wo_version attribute.
    /// </summary>
    public TerraformValue<double>? PasswordWoVersion
    {
        get => new TerraformReference<double>(this, "password_wo_version");
        set => SetArgument("password_wo_version", value);
    }

    /// <summary>
    /// The performance_insights_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? PerformanceInsightsEnabled
    {
        get => new TerraformReference<bool>(this, "performance_insights_enabled");
        set => SetArgument("performance_insights_enabled", value);
    }

    /// <summary>
    /// The performance_insights_kms_key_id attribute.
    /// </summary>
    public TerraformValue<string> PerformanceInsightsKmsKeyId
    {
        get => new TerraformReference<string>(this, "performance_insights_kms_key_id");
        set => SetArgument("performance_insights_kms_key_id", value);
    }

    /// <summary>
    /// The performance_insights_retention_period attribute.
    /// </summary>
    public TerraformValue<double> PerformanceInsightsRetentionPeriod
    {
        get => new TerraformReference<double>(this, "performance_insights_retention_period");
        set => SetArgument("performance_insights_retention_period", value);
    }

    /// <summary>
    /// The port attribute.
    /// </summary>
    public TerraformValue<double> Port
    {
        get => new TerraformReference<double>(this, "port");
        set => SetArgument("port", value);
    }

    /// <summary>
    /// The publicly_accessible attribute.
    /// </summary>
    public TerraformValue<bool>? PubliclyAccessible
    {
        get => new TerraformReference<bool>(this, "publicly_accessible");
        set => SetArgument("publicly_accessible", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The replica_mode attribute.
    /// </summary>
    public TerraformValue<string> ReplicaMode
    {
        get => new TerraformReference<string>(this, "replica_mode");
        set => SetArgument("replica_mode", value);
    }

    /// <summary>
    /// The replicate_source_db attribute.
    /// </summary>
    public TerraformValue<string>? ReplicateSourceDb
    {
        get => new TerraformReference<string>(this, "replicate_source_db");
        set => SetArgument("replicate_source_db", value);
    }

    /// <summary>
    /// The skip_final_snapshot attribute.
    /// </summary>
    public TerraformValue<bool>? SkipFinalSnapshot
    {
        get => new TerraformReference<bool>(this, "skip_final_snapshot");
        set => SetArgument("skip_final_snapshot", value);
    }

    /// <summary>
    /// The snapshot_identifier attribute.
    /// </summary>
    public TerraformValue<string> SnapshotIdentifier
    {
        get => new TerraformReference<string>(this, "snapshot_identifier");
        set => SetArgument("snapshot_identifier", value);
    }

    /// <summary>
    /// The storage_encrypted attribute.
    /// </summary>
    public TerraformValue<bool>? StorageEncrypted
    {
        get => new TerraformReference<bool>(this, "storage_encrypted");
        set => SetArgument("storage_encrypted", value);
    }

    /// <summary>
    /// The storage_throughput attribute.
    /// </summary>
    public TerraformValue<double> StorageThroughput
    {
        get => new TerraformReference<double>(this, "storage_throughput");
        set => SetArgument("storage_throughput", value);
    }

    /// <summary>
    /// The storage_type attribute.
    /// </summary>
    public TerraformValue<string> StorageType
    {
        get => new TerraformReference<string>(this, "storage_type");
        set => SetArgument("storage_type", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The timezone attribute.
    /// </summary>
    public TerraformValue<string> Timezone
    {
        get => new TerraformReference<string>(this, "timezone");
        set => SetArgument("timezone", value);
    }

    /// <summary>
    /// The upgrade_storage_config attribute.
    /// </summary>
    public TerraformValue<bool>? UpgradeStorageConfig
    {
        get => new TerraformReference<bool>(this, "upgrade_storage_config");
        set => SetArgument("upgrade_storage_config", value);
    }

    /// <summary>
    /// The username attribute.
    /// </summary>
    public TerraformValue<string> Username
    {
        get => new TerraformReference<string>(this, "username");
        set => SetArgument("username", value);
    }

    /// <summary>
    /// The vpc_security_group_ids attribute.
    /// </summary>
    public TerraformSet<string> VpcSecurityGroupIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "vpc_security_group_ids").ResolveNodes(ctx));
        set => SetArgument("vpc_security_group_ids", value);
    }

    /// <summary>
    /// The address attribute.
    /// </summary>
    public TerraformValue<string> Address
    {
        get => new TerraformReference<string>(this, "address");
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    public TerraformValue<string> Endpoint
    {
        get => new TerraformReference<string>(this, "endpoint");
    }

    /// <summary>
    /// The engine_version_actual attribute.
    /// </summary>
    public TerraformValue<string> EngineVersionActual
    {
        get => new TerraformReference<string>(this, "engine_version_actual");
    }

    /// <summary>
    /// The hosted_zone_id attribute.
    /// </summary>
    public TerraformValue<string> HostedZoneId
    {
        get => new TerraformReference<string>(this, "hosted_zone_id");
    }

    /// <summary>
    /// The latest_restorable_time attribute.
    /// </summary>
    public TerraformValue<string> LatestRestorableTime
    {
        get => new TerraformReference<string>(this, "latest_restorable_time");
    }

    /// <summary>
    /// The listener_endpoint attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> ListenerEndpoint
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "listener_endpoint").ResolveNodes(ctx));
    }

    /// <summary>
    /// The master_user_secret attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> MasterUserSecret
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "master_user_secret").ResolveNodes(ctx));
    }

    /// <summary>
    /// The replicas attribute.
    /// </summary>
    public TerraformList<string> Replicas
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "replicas").ResolveNodes(ctx));
    }

    /// <summary>
    /// The resource_id attribute.
    /// </summary>
    public TerraformValue<string> ResourceId
    {
        get => new TerraformReference<string>(this, "resource_id");
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
    {
        get => new TerraformReference<string>(this, "status");
    }

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
