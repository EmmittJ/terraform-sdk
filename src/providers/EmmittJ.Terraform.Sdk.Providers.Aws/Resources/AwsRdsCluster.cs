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
        get => GetArgument<TerraformValue<string>>("restore_to_time");
        set => SetArgument("restore_to_time", value);
    }

    /// <summary>
    /// The restore_type attribute.
    /// </summary>
    public TerraformValue<string>? RestoreType
    {
        get => GetArgument<TerraformValue<string>>("restore_type");
        set => SetArgument("restore_type", value);
    }

    /// <summary>
    /// The source_cluster_identifier attribute.
    /// </summary>
    public TerraformValue<string>? SourceClusterIdentifier
    {
        get => GetArgument<TerraformValue<string>>("source_cluster_identifier");
        set => SetArgument("source_cluster_identifier", value);
    }

    /// <summary>
    /// The source_cluster_resource_id attribute.
    /// </summary>
    public TerraformValue<string>? SourceClusterResourceId
    {
        get => GetArgument<TerraformValue<string>>("source_cluster_resource_id");
        set => SetArgument("source_cluster_resource_id", value);
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
        get => GetArgument<TerraformValue<string>>("bucket_name");
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
        get => GetArgument<TerraformValue<string>>("ingestion_role");
        set => SetArgument("ingestion_role", value);
    }

    /// <summary>
    /// The source_engine attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceEngine is required")]
    public required TerraformValue<string> SourceEngine
    {
        get => GetArgument<TerraformValue<string>>("source_engine");
        set => SetArgument("source_engine", value);
    }

    /// <summary>
    /// The source_engine_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceEngineVersion is required")]
    public required TerraformValue<string> SourceEngineVersion
    {
        get => GetArgument<TerraformValue<string>>("source_engine_version");
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
        get => GetArgument<TerraformValue<bool>>("auto_pause");
        set => SetArgument("auto_pause", value);
    }

    /// <summary>
    /// The max_capacity attribute.
    /// </summary>
    public TerraformValue<double>? MaxCapacity
    {
        get => GetArgument<TerraformValue<double>>("max_capacity");
        set => SetArgument("max_capacity", value);
    }

    /// <summary>
    /// The min_capacity attribute.
    /// </summary>
    public TerraformValue<double>? MinCapacity
    {
        get => GetArgument<TerraformValue<double>>("min_capacity");
        set => SetArgument("min_capacity", value);
    }

    /// <summary>
    /// The seconds_before_timeout attribute.
    /// </summary>
    public TerraformValue<double>? SecondsBeforeTimeout
    {
        get => GetArgument<TerraformValue<double>>("seconds_before_timeout");
        set => SetArgument("seconds_before_timeout", value);
    }

    /// <summary>
    /// The seconds_until_auto_pause attribute.
    /// </summary>
    public TerraformValue<double>? SecondsUntilAutoPause
    {
        get => GetArgument<TerraformValue<double>>("seconds_until_auto_pause");
        set => SetArgument("seconds_until_auto_pause", value);
    }

    /// <summary>
    /// The timeout_action attribute.
    /// </summary>
    public TerraformValue<string>? TimeoutAction
    {
        get => GetArgument<TerraformValue<string>>("timeout_action");
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
        get => GetArgument<TerraformValue<double>>("max_capacity");
        set => SetArgument("max_capacity", value);
    }

    /// <summary>
    /// The min_capacity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MinCapacity is required")]
    public required TerraformValue<double> MinCapacity
    {
        get => GetArgument<TerraformValue<double>>("min_capacity");
        set => SetArgument("min_capacity", value);
    }

    /// <summary>
    /// The seconds_until_auto_pause attribute.
    /// </summary>
    public TerraformValue<double>? SecondsUntilAutoPause
    {
        get => GetArgument<TerraformValue<double>>("seconds_until_auto_pause");
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
/// Represents a aws_rds_cluster Terraform resource.
/// Manages a aws_rds_cluster resource.
/// </summary>
public partial class AwsRdsCluster(string name) : TerraformResource("aws_rds_cluster", name)
{
    /// <summary>
    /// The allocated_storage attribute.
    /// </summary>
    public TerraformValue<double>? AllocatedStorage
    {
        get => GetArgument<TerraformValue<double>>("allocated_storage");
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
    /// The availability_zones attribute.
    /// </summary>
    public TerraformSet<string>? AvailabilityZones
    {
        get => GetArgument<TerraformSet<string>>("availability_zones");
        set => SetArgument("availability_zones", value);
    }

    /// <summary>
    /// The backtrack_window attribute.
    /// </summary>
    public TerraformValue<double>? BacktrackWindow
    {
        get => GetArgument<TerraformValue<double>>("backtrack_window");
        set => SetArgument("backtrack_window", value);
    }

    /// <summary>
    /// The backup_retention_period attribute.
    /// </summary>
    public TerraformValue<double>? BackupRetentionPeriod
    {
        get => GetArgument<TerraformValue<double>>("backup_retention_period");
        set => SetArgument("backup_retention_period", value);
    }

    /// <summary>
    /// The ca_certificate_identifier attribute.
    /// </summary>
    public TerraformValue<string>? CaCertificateIdentifier
    {
        get => GetArgument<TerraformValue<string>>("ca_certificate_identifier");
        set => SetArgument("ca_certificate_identifier", value);
    }

    /// <summary>
    /// The cluster_identifier attribute.
    /// </summary>
    public TerraformValue<string>? ClusterIdentifier
    {
        get => GetArgument<TerraformValue<string>>("cluster_identifier");
        set => SetArgument("cluster_identifier", value);
    }

    /// <summary>
    /// The cluster_identifier_prefix attribute.
    /// </summary>
    public TerraformValue<string>? ClusterIdentifierPrefix
    {
        get => GetArgument<TerraformValue<string>>("cluster_identifier_prefix");
        set => SetArgument("cluster_identifier_prefix", value);
    }

    /// <summary>
    /// The cluster_members attribute.
    /// </summary>
    public TerraformSet<string>? ClusterMembers
    {
        get => GetArgument<TerraformSet<string>>("cluster_members");
        set => SetArgument("cluster_members", value);
    }

    /// <summary>
    /// The cluster_scalability_type attribute.
    /// </summary>
    public TerraformValue<string>? ClusterScalabilityType
    {
        get => GetArgument<TerraformValue<string>>("cluster_scalability_type");
        set => SetArgument("cluster_scalability_type", value);
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
    /// The database_insights_mode attribute.
    /// </summary>
    public TerraformValue<string>? DatabaseInsightsMode
    {
        get => GetArgument<TerraformValue<string>>("database_insights_mode");
        set => SetArgument("database_insights_mode", value);
    }

    /// <summary>
    /// The database_name attribute.
    /// </summary>
    public TerraformValue<string>? DatabaseName
    {
        get => GetArgument<TerraformValue<string>>("database_name");
        set => SetArgument("database_name", value);
    }

    /// <summary>
    /// The db_cluster_instance_class attribute.
    /// </summary>
    public TerraformValue<string>? DbClusterInstanceClass
    {
        get => GetArgument<TerraformValue<string>>("db_cluster_instance_class");
        set => SetArgument("db_cluster_instance_class", value);
    }

    /// <summary>
    /// The db_cluster_parameter_group_name attribute.
    /// </summary>
    public TerraformValue<string>? DbClusterParameterGroupName
    {
        get => GetArgument<TerraformValue<string>>("db_cluster_parameter_group_name");
        set => SetArgument("db_cluster_parameter_group_name", value);
    }

    /// <summary>
    /// The db_instance_parameter_group_name attribute.
    /// </summary>
    public TerraformValue<string>? DbInstanceParameterGroupName
    {
        get => GetArgument<TerraformValue<string>>("db_instance_parameter_group_name");
        set => SetArgument("db_instance_parameter_group_name", value);
    }

    /// <summary>
    /// The db_subnet_group_name attribute.
    /// </summary>
    public TerraformValue<string>? DbSubnetGroupName
    {
        get => GetArgument<TerraformValue<string>>("db_subnet_group_name");
        set => SetArgument("db_subnet_group_name", value);
    }

    /// <summary>
    /// The db_system_id attribute.
    /// </summary>
    public TerraformValue<string>? DbSystemId
    {
        get => GetArgument<TerraformValue<string>>("db_system_id");
        set => SetArgument("db_system_id", value);
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
    /// The domain_iam_role_name attribute.
    /// </summary>
    public TerraformValue<string>? DomainIamRoleName
    {
        get => GetArgument<TerraformValue<string>>("domain_iam_role_name");
        set => SetArgument("domain_iam_role_name", value);
    }

    /// <summary>
    /// The enable_global_write_forwarding attribute.
    /// </summary>
    public TerraformValue<bool>? EnableGlobalWriteForwarding
    {
        get => GetArgument<TerraformValue<bool>>("enable_global_write_forwarding");
        set => SetArgument("enable_global_write_forwarding", value);
    }

    /// <summary>
    /// The enable_http_endpoint attribute.
    /// </summary>
    public TerraformValue<bool>? EnableHttpEndpoint
    {
        get => GetArgument<TerraformValue<bool>>("enable_http_endpoint");
        set => SetArgument("enable_http_endpoint", value);
    }

    /// <summary>
    /// The enable_local_write_forwarding attribute.
    /// </summary>
    public TerraformValue<bool>? EnableLocalWriteForwarding
    {
        get => GetArgument<TerraformValue<bool>>("enable_local_write_forwarding");
        set => SetArgument("enable_local_write_forwarding", value);
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Engine is required")]
    public required TerraformValue<string> Engine
    {
        get => GetArgument<TerraformValue<string>>("engine");
        set => SetArgument("engine", value);
    }

    /// <summary>
    /// The engine_lifecycle_support attribute.
    /// </summary>
    public TerraformValue<string>? EngineLifecycleSupport
    {
        get => GetArgument<TerraformValue<string>>("engine_lifecycle_support");
        set => SetArgument("engine_lifecycle_support", value);
    }

    /// <summary>
    /// The engine_mode attribute.
    /// </summary>
    public TerraformValue<string>? EngineMode
    {
        get => GetArgument<TerraformValue<string>>("engine_mode");
        set => SetArgument("engine_mode", value);
    }

    /// <summary>
    /// The engine_version attribute.
    /// </summary>
    public TerraformValue<string>? EngineVersion
    {
        get => GetArgument<TerraformValue<string>>("engine_version");
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
    /// The global_cluster_identifier attribute.
    /// </summary>
    public TerraformValue<string>? GlobalClusterIdentifier
    {
        get => GetArgument<TerraformValue<string>>("global_cluster_identifier");
        set => SetArgument("global_cluster_identifier", value);
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
    /// The iam_roles attribute.
    /// </summary>
    public TerraformSet<string>? IamRoles
    {
        get => GetArgument<TerraformSet<string>>("iam_roles");
        set => SetArgument("iam_roles", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The iops attribute.
    /// </summary>
    public TerraformValue<double>? Iops
    {
        get => GetArgument<TerraformValue<double>>("iops");
        set => SetArgument("iops", value);
    }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformValue<string>? KmsKeyId
    {
        get => GetArgument<TerraformValue<string>>("kms_key_id");
        set => SetArgument("kms_key_id", value);
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
    /// The master_password attribute.
    /// </summary>
    public TerraformValue<string>? MasterPassword
    {
        get => GetArgument<TerraformValue<string>>("master_password");
        set => SetArgument("master_password", value);
    }

    /// <summary>
    /// The master_password_wo attribute.
    /// </summary>
    public TerraformValue<string>? MasterPasswordWo
    {
        get => GetArgument<TerraformValue<string>>("master_password_wo");
        set => SetArgument("master_password_wo", value);
    }

    /// <summary>
    /// The master_password_wo_version attribute.
    /// </summary>
    public TerraformValue<double>? MasterPasswordWoVersion
    {
        get => GetArgument<TerraformValue<double>>("master_password_wo_version");
        set => SetArgument("master_password_wo_version", value);
    }

    /// <summary>
    /// The master_user_secret_kms_key_id attribute.
    /// </summary>
    public TerraformValue<string>? MasterUserSecretKmsKeyId
    {
        get => GetArgument<TerraformValue<string>>("master_user_secret_kms_key_id");
        set => SetArgument("master_user_secret_kms_key_id", value);
    }

    /// <summary>
    /// The master_username attribute.
    /// </summary>
    public TerraformValue<string>? MasterUsername
    {
        get => GetArgument<TerraformValue<string>>("master_username");
        set => SetArgument("master_username", value);
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
    public TerraformValue<string>? MonitoringRoleArn
    {
        get => GetArgument<TerraformValue<string>>("monitoring_role_arn");
        set => SetArgument("monitoring_role_arn", value);
    }

    /// <summary>
    /// The network_type attribute.
    /// </summary>
    public TerraformValue<string>? NetworkType
    {
        get => GetArgument<TerraformValue<string>>("network_type");
        set => SetArgument("network_type", value);
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
    public TerraformValue<string>? PerformanceInsightsKmsKeyId
    {
        get => GetArgument<TerraformValue<string>>("performance_insights_kms_key_id");
        set => SetArgument("performance_insights_kms_key_id", value);
    }

    /// <summary>
    /// The performance_insights_retention_period attribute.
    /// </summary>
    public TerraformValue<double>? PerformanceInsightsRetentionPeriod
    {
        get => GetArgument<TerraformValue<double>>("performance_insights_retention_period");
        set => SetArgument("performance_insights_retention_period", value);
    }

    /// <summary>
    /// The port attribute.
    /// </summary>
    public TerraformValue<double>? Port
    {
        get => GetArgument<TerraformValue<double>>("port");
        set => SetArgument("port", value);
    }

    /// <summary>
    /// The preferred_backup_window attribute.
    /// </summary>
    public TerraformValue<string>? PreferredBackupWindow
    {
        get => GetArgument<TerraformValue<string>>("preferred_backup_window");
        set => SetArgument("preferred_backup_window", value);
    }

    /// <summary>
    /// The preferred_maintenance_window attribute.
    /// </summary>
    public TerraformValue<string>? PreferredMaintenanceWindow
    {
        get => GetArgument<TerraformValue<string>>("preferred_maintenance_window");
        set => SetArgument("preferred_maintenance_window", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The replication_source_identifier attribute.
    /// </summary>
    public TerraformValue<string>? ReplicationSourceIdentifier
    {
        get => GetArgument<TerraformValue<string>>("replication_source_identifier");
        set => SetArgument("replication_source_identifier", value);
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
    public TerraformValue<string>? SnapshotIdentifier
    {
        get => GetArgument<TerraformValue<string>>("snapshot_identifier");
        set => SetArgument("snapshot_identifier", value);
    }

    /// <summary>
    /// The source_region attribute.
    /// </summary>
    public TerraformValue<string>? SourceRegion
    {
        get => GetArgument<TerraformValue<string>>("source_region");
        set => SetArgument("source_region", value);
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
    /// The storage_type attribute.
    /// </summary>
    public TerraformValue<string>? StorageType
    {
        get => GetArgument<TerraformValue<string>>("storage_type");
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
    public TerraformMap<string>? TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The vpc_security_group_ids attribute.
    /// </summary>
    public TerraformSet<string>? VpcSecurityGroupIds
    {
        get => GetArgument<TerraformSet<string>>("vpc_security_group_ids");
        set => SetArgument("vpc_security_group_ids", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The ca_certificate_valid_till attribute.
    /// </summary>
    public TerraformValue<string> CaCertificateValidTill
        => AsReference("ca_certificate_valid_till");

    /// <summary>
    /// The cluster_resource_id attribute.
    /// </summary>
    public TerraformValue<string> ClusterResourceId
        => AsReference("cluster_resource_id");

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    public TerraformValue<string> Endpoint
        => AsReference("endpoint");

    /// <summary>
    /// The engine_version_actual attribute.
    /// </summary>
    public TerraformValue<string> EngineVersionActual
        => AsReference("engine_version_actual");

    /// <summary>
    /// The hosted_zone_id attribute.
    /// </summary>
    public TerraformValue<string> HostedZoneId
        => AsReference("hosted_zone_id");

    /// <summary>
    /// The master_user_secret attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> MasterUserSecret
        => AsReference("master_user_secret");

    /// <summary>
    /// The reader_endpoint attribute.
    /// </summary>
    public TerraformValue<string> ReaderEndpoint
        => AsReference("reader_endpoint");

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
