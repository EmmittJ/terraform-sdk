using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for restore_to_point_in_time in AwsRdsCluster.
/// Nesting mode: list
/// </summary>
public class AwsRdsClusterRestoreToPointInTimeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "restore_to_point_in_time";

    /// <summary>
    /// The restore_to_time attribute.
    /// </summary>
    public TerraformValue<string>? RestoreToTime
    {
        get => new TerraformReference<string>(this, "restore_to_time");
        set => SetArgument("restore_to_time", value);
    }

    /// <summary>
    /// The restore_type attribute.
    /// </summary>
    public TerraformValue<string>? RestoreType
    {
        get => new TerraformReference<string>(this, "restore_type");
        set => SetArgument("restore_type", value);
    }

    /// <summary>
    /// The source_cluster_identifier attribute.
    /// </summary>
    public TerraformValue<string>? SourceClusterIdentifier
    {
        get => new TerraformReference<string>(this, "source_cluster_identifier");
        set => SetArgument("source_cluster_identifier", value);
    }

    /// <summary>
    /// The source_cluster_resource_id attribute.
    /// </summary>
    public TerraformValue<string>? SourceClusterResourceId
    {
        get => new TerraformReference<string>(this, "source_cluster_resource_id");
        set => SetArgument("source_cluster_resource_id", value);
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
/// Block type for s3_import in AwsRdsCluster.
/// Nesting mode: list
/// </summary>
public class AwsRdsClusterS3ImportBlock : TerraformBlock
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
/// Block type for scaling_configuration in AwsRdsCluster.
/// Nesting mode: list
/// </summary>
public class AwsRdsClusterScalingConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "scaling_configuration";

    /// <summary>
    /// The auto_pause attribute.
    /// </summary>
    public TerraformValue<bool>? AutoPause
    {
        get => new TerraformReference<bool>(this, "auto_pause");
        set => SetArgument("auto_pause", value);
    }

    /// <summary>
    /// The max_capacity attribute.
    /// </summary>
    public TerraformValue<double>? MaxCapacity
    {
        get => new TerraformReference<double>(this, "max_capacity");
        set => SetArgument("max_capacity", value);
    }

    /// <summary>
    /// The min_capacity attribute.
    /// </summary>
    public TerraformValue<double>? MinCapacity
    {
        get => new TerraformReference<double>(this, "min_capacity");
        set => SetArgument("min_capacity", value);
    }

    /// <summary>
    /// The seconds_before_timeout attribute.
    /// </summary>
    public TerraformValue<double>? SecondsBeforeTimeout
    {
        get => new TerraformReference<double>(this, "seconds_before_timeout");
        set => SetArgument("seconds_before_timeout", value);
    }

    /// <summary>
    /// The seconds_until_auto_pause attribute.
    /// </summary>
    public TerraformValue<double>? SecondsUntilAutoPause
    {
        get => new TerraformReference<double>(this, "seconds_until_auto_pause");
        set => SetArgument("seconds_until_auto_pause", value);
    }

    /// <summary>
    /// The timeout_action attribute.
    /// </summary>
    public TerraformValue<string>? TimeoutAction
    {
        get => new TerraformReference<string>(this, "timeout_action");
        set => SetArgument("timeout_action", value);
    }

}


/// <summary>
/// Block type for serverlessv2_scaling_configuration in AwsRdsCluster.
/// Nesting mode: list
/// </summary>
public class AwsRdsClusterServerlessv2ScalingConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "serverlessv2_scaling_configuration";

    /// <summary>
    /// The max_capacity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxCapacity is required")]
    public required TerraformValue<double> MaxCapacity
    {
        get => new TerraformReference<double>(this, "max_capacity");
        set => SetArgument("max_capacity", value);
    }

    /// <summary>
    /// The min_capacity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MinCapacity is required")]
    public required TerraformValue<double> MinCapacity
    {
        get => new TerraformReference<double>(this, "min_capacity");
        set => SetArgument("min_capacity", value);
    }

    /// <summary>
    /// The seconds_until_auto_pause attribute.
    /// </summary>
    public TerraformValue<double> SecondsUntilAutoPause
    {
        get => new TerraformReference<double>(this, "seconds_until_auto_pause");
        set => SetArgument("seconds_until_auto_pause", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsRdsCluster.
/// Nesting mode: single
/// </summary>
public class AwsRdsClusterTimeoutsBlock : TerraformBlock
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
/// Represents a aws_rds_cluster Terraform resource.
/// Manages a aws_rds_cluster resource.
/// </summary>
public partial class AwsRdsCluster(string name) : TerraformResource("aws_rds_cluster", name)
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
    public TerraformValue<bool> ApplyImmediately
    {
        get => new TerraformReference<bool>(this, "apply_immediately");
        set => SetArgument("apply_immediately", value);
    }

    /// <summary>
    /// The availability_zones attribute.
    /// </summary>
    public TerraformSet<string> AvailabilityZones
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "availability_zones").ResolveNodes(ctx));
        set => SetArgument("availability_zones", value);
    }

    /// <summary>
    /// The backtrack_window attribute.
    /// </summary>
    public TerraformValue<double>? BacktrackWindow
    {
        get => new TerraformReference<double>(this, "backtrack_window");
        set => SetArgument("backtrack_window", value);
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
    /// The ca_certificate_identifier attribute.
    /// </summary>
    public TerraformValue<string> CaCertificateIdentifier
    {
        get => new TerraformReference<string>(this, "ca_certificate_identifier");
        set => SetArgument("ca_certificate_identifier", value);
    }

    /// <summary>
    /// The cluster_identifier attribute.
    /// </summary>
    public TerraformValue<string> ClusterIdentifier
    {
        get => new TerraformReference<string>(this, "cluster_identifier");
        set => SetArgument("cluster_identifier", value);
    }

    /// <summary>
    /// The cluster_identifier_prefix attribute.
    /// </summary>
    public TerraformValue<string> ClusterIdentifierPrefix
    {
        get => new TerraformReference<string>(this, "cluster_identifier_prefix");
        set => SetArgument("cluster_identifier_prefix", value);
    }

    /// <summary>
    /// The cluster_members attribute.
    /// </summary>
    public TerraformSet<string> ClusterMembers
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "cluster_members").ResolveNodes(ctx));
        set => SetArgument("cluster_members", value);
    }

    /// <summary>
    /// The cluster_scalability_type attribute.
    /// </summary>
    public TerraformValue<string> ClusterScalabilityType
    {
        get => new TerraformReference<string>(this, "cluster_scalability_type");
        set => SetArgument("cluster_scalability_type", value);
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
    /// The database_insights_mode attribute.
    /// </summary>
    public TerraformValue<string> DatabaseInsightsMode
    {
        get => new TerraformReference<string>(this, "database_insights_mode");
        set => SetArgument("database_insights_mode", value);
    }

    /// <summary>
    /// The database_name attribute.
    /// </summary>
    public TerraformValue<string> DatabaseName
    {
        get => new TerraformReference<string>(this, "database_name");
        set => SetArgument("database_name", value);
    }

    /// <summary>
    /// The db_cluster_instance_class attribute.
    /// </summary>
    public TerraformValue<string>? DbClusterInstanceClass
    {
        get => new TerraformReference<string>(this, "db_cluster_instance_class");
        set => SetArgument("db_cluster_instance_class", value);
    }

    /// <summary>
    /// The db_cluster_parameter_group_name attribute.
    /// </summary>
    public TerraformValue<string> DbClusterParameterGroupName
    {
        get => new TerraformReference<string>(this, "db_cluster_parameter_group_name");
        set => SetArgument("db_cluster_parameter_group_name", value);
    }

    /// <summary>
    /// The db_instance_parameter_group_name attribute.
    /// </summary>
    public TerraformValue<string>? DbInstanceParameterGroupName
    {
        get => new TerraformReference<string>(this, "db_instance_parameter_group_name");
        set => SetArgument("db_instance_parameter_group_name", value);
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
    /// The db_system_id attribute.
    /// </summary>
    public TerraformValue<string> DbSystemId
    {
        get => new TerraformReference<string>(this, "db_system_id");
        set => SetArgument("db_system_id", value);
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
    /// The domain_iam_role_name attribute.
    /// </summary>
    public TerraformValue<string>? DomainIamRoleName
    {
        get => new TerraformReference<string>(this, "domain_iam_role_name");
        set => SetArgument("domain_iam_role_name", value);
    }

    /// <summary>
    /// The enable_global_write_forwarding attribute.
    /// </summary>
    public TerraformValue<bool>? EnableGlobalWriteForwarding
    {
        get => new TerraformReference<bool>(this, "enable_global_write_forwarding");
        set => SetArgument("enable_global_write_forwarding", value);
    }

    /// <summary>
    /// The enable_http_endpoint attribute.
    /// </summary>
    public TerraformValue<bool>? EnableHttpEndpoint
    {
        get => new TerraformReference<bool>(this, "enable_http_endpoint");
        set => SetArgument("enable_http_endpoint", value);
    }

    /// <summary>
    /// The enable_local_write_forwarding attribute.
    /// </summary>
    public TerraformValue<bool>? EnableLocalWriteForwarding
    {
        get => new TerraformReference<bool>(this, "enable_local_write_forwarding");
        set => SetArgument("enable_local_write_forwarding", value);
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Engine is required")]
    public required TerraformValue<string> Engine
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
    /// The engine_mode attribute.
    /// </summary>
    public TerraformValue<string>? EngineMode
    {
        get => new TerraformReference<string>(this, "engine_mode");
        set => SetArgument("engine_mode", value);
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
    /// The global_cluster_identifier attribute.
    /// </summary>
    public TerraformValue<string>? GlobalClusterIdentifier
    {
        get => new TerraformReference<string>(this, "global_cluster_identifier");
        set => SetArgument("global_cluster_identifier", value);
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
    /// The iam_roles attribute.
    /// </summary>
    public TerraformSet<string> IamRoles
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "iam_roles").ResolveNodes(ctx));
        set => SetArgument("iam_roles", value);
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
    /// The iops attribute.
    /// </summary>
    public TerraformValue<double>? Iops
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
    /// The manage_master_user_password attribute.
    /// </summary>
    public TerraformValue<bool>? ManageMasterUserPassword
    {
        get => new TerraformReference<bool>(this, "manage_master_user_password");
        set => SetArgument("manage_master_user_password", value);
    }

    /// <summary>
    /// The master_password attribute.
    /// </summary>
    public TerraformValue<string>? MasterPassword
    {
        get => new TerraformReference<string>(this, "master_password");
        set => SetArgument("master_password", value);
    }

    /// <summary>
    /// The master_password_wo attribute.
    /// </summary>
    public TerraformValue<string>? MasterPasswordWo
    {
        get => new TerraformReference<string>(this, "master_password_wo");
        set => SetArgument("master_password_wo", value);
    }

    /// <summary>
    /// The master_password_wo_version attribute.
    /// </summary>
    public TerraformValue<double>? MasterPasswordWoVersion
    {
        get => new TerraformReference<double>(this, "master_password_wo_version");
        set => SetArgument("master_password_wo_version", value);
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
    /// The master_username attribute.
    /// </summary>
    public TerraformValue<string> MasterUsername
    {
        get => new TerraformReference<string>(this, "master_username");
        set => SetArgument("master_username", value);
    }

    /// <summary>
    /// The monitoring_interval attribute.
    /// </summary>
    public TerraformValue<double> MonitoringInterval
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
    /// The network_type attribute.
    /// </summary>
    public TerraformValue<string> NetworkType
    {
        get => new TerraformReference<string>(this, "network_type");
        set => SetArgument("network_type", value);
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
    /// The preferred_backup_window attribute.
    /// </summary>
    public TerraformValue<string> PreferredBackupWindow
    {
        get => new TerraformReference<string>(this, "preferred_backup_window");
        set => SetArgument("preferred_backup_window", value);
    }

    /// <summary>
    /// The preferred_maintenance_window attribute.
    /// </summary>
    public TerraformValue<string> PreferredMaintenanceWindow
    {
        get => new TerraformReference<string>(this, "preferred_maintenance_window");
        set => SetArgument("preferred_maintenance_window", value);
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
    /// The replication_source_identifier attribute.
    /// </summary>
    public TerraformValue<string>? ReplicationSourceIdentifier
    {
        get => new TerraformReference<string>(this, "replication_source_identifier");
        set => SetArgument("replication_source_identifier", value);
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
    public TerraformValue<string>? SnapshotIdentifier
    {
        get => new TerraformReference<string>(this, "snapshot_identifier");
        set => SetArgument("snapshot_identifier", value);
    }

    /// <summary>
    /// The source_region attribute.
    /// </summary>
    public TerraformValue<string>? SourceRegion
    {
        get => new TerraformReference<string>(this, "source_region");
        set => SetArgument("source_region", value);
    }

    /// <summary>
    /// The storage_encrypted attribute.
    /// </summary>
    public TerraformValue<bool> StorageEncrypted
    {
        get => new TerraformReference<bool>(this, "storage_encrypted");
        set => SetArgument("storage_encrypted", value);
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
    /// The vpc_security_group_ids attribute.
    /// </summary>
    public TerraformSet<string> VpcSecurityGroupIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "vpc_security_group_ids").ResolveNodes(ctx));
        set => SetArgument("vpc_security_group_ids", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The ca_certificate_valid_till attribute.
    /// </summary>
    public TerraformValue<string> CaCertificateValidTill
    {
        get => new TerraformReference<string>(this, "ca_certificate_valid_till");
    }

    /// <summary>
    /// The cluster_resource_id attribute.
    /// </summary>
    public TerraformValue<string> ClusterResourceId
    {
        get => new TerraformReference<string>(this, "cluster_resource_id");
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
    /// The master_user_secret attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> MasterUserSecret
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "master_user_secret").ResolveNodes(ctx));
    }

    /// <summary>
    /// The reader_endpoint attribute.
    /// </summary>
    public TerraformValue<string> ReaderEndpoint
    {
        get => new TerraformReference<string>(this, "reader_endpoint");
    }

    /// <summary>
    /// RestoreToPointInTime block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RestoreToPointInTime block(s) allowed")]
    public TerraformList<AwsRdsClusterRestoreToPointInTimeBlock>? RestoreToPointInTime
    {
        get => GetArgument<TerraformList<AwsRdsClusterRestoreToPointInTimeBlock>>("restore_to_point_in_time");
        set => SetArgument("restore_to_point_in_time", value);
    }

    /// <summary>
    /// S3Import block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 S3Import block(s) allowed")]
    public TerraformList<AwsRdsClusterS3ImportBlock>? S3Import
    {
        get => GetArgument<TerraformList<AwsRdsClusterS3ImportBlock>>("s3_import");
        set => SetArgument("s3_import", value);
    }

    /// <summary>
    /// ScalingConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ScalingConfiguration block(s) allowed")]
    public TerraformList<AwsRdsClusterScalingConfigurationBlock>? ScalingConfiguration
    {
        get => GetArgument<TerraformList<AwsRdsClusterScalingConfigurationBlock>>("scaling_configuration");
        set => SetArgument("scaling_configuration", value);
    }

    /// <summary>
    /// Serverlessv2ScalingConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Serverlessv2ScalingConfiguration block(s) allowed")]
    public TerraformList<AwsRdsClusterServerlessv2ScalingConfigurationBlock>? Serverlessv2ScalingConfiguration
    {
        get => GetArgument<TerraformList<AwsRdsClusterServerlessv2ScalingConfigurationBlock>>("serverlessv2_scaling_configuration");
        set => SetArgument("serverlessv2_scaling_configuration", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsRdsClusterTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsRdsClusterTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
