using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for restore_to_point_in_time in .
/// Nesting mode: list
/// </summary>
public class AwsRdsClusterRestoreToPointInTimeBlock : TerraformBlock
{
    /// <summary>
    /// The restore_to_time attribute.
    /// </summary>
    public TerraformProperty<string>? RestoreToTime
    {
        set => SetProperty("restore_to_time", value);
    }

    /// <summary>
    /// The restore_type attribute.
    /// </summary>
    public TerraformProperty<string>? RestoreType
    {
        set => SetProperty("restore_type", value);
    }

    /// <summary>
    /// The source_cluster_identifier attribute.
    /// </summary>
    public TerraformProperty<string>? SourceClusterIdentifier
    {
        set => SetProperty("source_cluster_identifier", value);
    }

    /// <summary>
    /// The source_cluster_resource_id attribute.
    /// </summary>
    public TerraformProperty<string>? SourceClusterResourceId
    {
        set => SetProperty("source_cluster_resource_id", value);
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
public class AwsRdsClusterS3ImportBlock : TerraformBlock
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
/// Block type for scaling_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsRdsClusterScalingConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The auto_pause attribute.
    /// </summary>
    public TerraformProperty<bool>? AutoPause
    {
        set => SetProperty("auto_pause", value);
    }

    /// <summary>
    /// The max_capacity attribute.
    /// </summary>
    public TerraformProperty<double>? MaxCapacity
    {
        set => SetProperty("max_capacity", value);
    }

    /// <summary>
    /// The min_capacity attribute.
    /// </summary>
    public TerraformProperty<double>? MinCapacity
    {
        set => SetProperty("min_capacity", value);
    }

    /// <summary>
    /// The seconds_before_timeout attribute.
    /// </summary>
    public TerraformProperty<double>? SecondsBeforeTimeout
    {
        set => SetProperty("seconds_before_timeout", value);
    }

    /// <summary>
    /// The seconds_until_auto_pause attribute.
    /// </summary>
    public TerraformProperty<double>? SecondsUntilAutoPause
    {
        set => SetProperty("seconds_until_auto_pause", value);
    }

    /// <summary>
    /// The timeout_action attribute.
    /// </summary>
    public TerraformProperty<string>? TimeoutAction
    {
        set => SetProperty("timeout_action", value);
    }

}

/// <summary>
/// Block type for serverlessv2_scaling_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsRdsClusterServerlessv2ScalingConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The max_capacity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxCapacity is required")]
    public required TerraformProperty<double> MaxCapacity
    {
        set => SetProperty("max_capacity", value);
    }

    /// <summary>
    /// The min_capacity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MinCapacity is required")]
    public required TerraformProperty<double> MinCapacity
    {
        set => SetProperty("min_capacity", value);
    }

    /// <summary>
    /// The seconds_until_auto_pause attribute.
    /// </summary>
    public TerraformProperty<double>? SecondsUntilAutoPause
    {
        set => SetProperty("seconds_until_auto_pause", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsRdsClusterTimeoutsBlock : TerraformBlock
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
/// Manages a aws_rds_cluster resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsRdsCluster : TerraformResource
{
    public AwsRdsCluster(string name) : base("aws_rds_cluster", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("ca_certificate_valid_till");
        SetOutput("cluster_resource_id");
        SetOutput("endpoint");
        SetOutput("engine_version_actual");
        SetOutput("hosted_zone_id");
        SetOutput("master_user_secret");
        SetOutput("reader_endpoint");
        SetOutput("allocated_storage");
        SetOutput("allow_major_version_upgrade");
        SetOutput("apply_immediately");
        SetOutput("availability_zones");
        SetOutput("backtrack_window");
        SetOutput("backup_retention_period");
        SetOutput("ca_certificate_identifier");
        SetOutput("cluster_identifier");
        SetOutput("cluster_identifier_prefix");
        SetOutput("cluster_members");
        SetOutput("cluster_scalability_type");
        SetOutput("copy_tags_to_snapshot");
        SetOutput("database_insights_mode");
        SetOutput("database_name");
        SetOutput("db_cluster_instance_class");
        SetOutput("db_cluster_parameter_group_name");
        SetOutput("db_instance_parameter_group_name");
        SetOutput("db_subnet_group_name");
        SetOutput("db_system_id");
        SetOutput("delete_automated_backups");
        SetOutput("deletion_protection");
        SetOutput("domain");
        SetOutput("domain_iam_role_name");
        SetOutput("enable_global_write_forwarding");
        SetOutput("enable_http_endpoint");
        SetOutput("enable_local_write_forwarding");
        SetOutput("enabled_cloudwatch_logs_exports");
        SetOutput("engine");
        SetOutput("engine_lifecycle_support");
        SetOutput("engine_mode");
        SetOutput("engine_version");
        SetOutput("final_snapshot_identifier");
        SetOutput("global_cluster_identifier");
        SetOutput("iam_database_authentication_enabled");
        SetOutput("iam_roles");
        SetOutput("id");
        SetOutput("iops");
        SetOutput("kms_key_id");
        SetOutput("manage_master_user_password");
        SetOutput("master_password");
        SetOutput("master_password_wo");
        SetOutput("master_password_wo_version");
        SetOutput("master_user_secret_kms_key_id");
        SetOutput("master_username");
        SetOutput("monitoring_interval");
        SetOutput("monitoring_role_arn");
        SetOutput("network_type");
        SetOutput("performance_insights_enabled");
        SetOutput("performance_insights_kms_key_id");
        SetOutput("performance_insights_retention_period");
        SetOutput("port");
        SetOutput("preferred_backup_window");
        SetOutput("preferred_maintenance_window");
        SetOutput("region");
        SetOutput("replication_source_identifier");
        SetOutput("skip_final_snapshot");
        SetOutput("snapshot_identifier");
        SetOutput("source_region");
        SetOutput("storage_encrypted");
        SetOutput("storage_type");
        SetOutput("tags");
        SetOutput("tags_all");
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
    /// The availability_zones attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> AvailabilityZones
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("availability_zones");
        set => SetProperty("availability_zones", value);
    }

    /// <summary>
    /// The backtrack_window attribute.
    /// </summary>
    public TerraformProperty<double> BacktrackWindow
    {
        get => GetRequiredOutput<TerraformProperty<double>>("backtrack_window");
        set => SetProperty("backtrack_window", value);
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
    /// The ca_certificate_identifier attribute.
    /// </summary>
    public TerraformProperty<string> CaCertificateIdentifier
    {
        get => GetRequiredOutput<TerraformProperty<string>>("ca_certificate_identifier");
        set => SetProperty("ca_certificate_identifier", value);
    }

    /// <summary>
    /// The cluster_identifier attribute.
    /// </summary>
    public TerraformProperty<string> ClusterIdentifier
    {
        get => GetRequiredOutput<TerraformProperty<string>>("cluster_identifier");
        set => SetProperty("cluster_identifier", value);
    }

    /// <summary>
    /// The cluster_identifier_prefix attribute.
    /// </summary>
    public TerraformProperty<string> ClusterIdentifierPrefix
    {
        get => GetRequiredOutput<TerraformProperty<string>>("cluster_identifier_prefix");
        set => SetProperty("cluster_identifier_prefix", value);
    }

    /// <summary>
    /// The cluster_members attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> ClusterMembers
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("cluster_members");
        set => SetProperty("cluster_members", value);
    }

    /// <summary>
    /// The cluster_scalability_type attribute.
    /// </summary>
    public TerraformProperty<string> ClusterScalabilityType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("cluster_scalability_type");
        set => SetProperty("cluster_scalability_type", value);
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
    /// The database_insights_mode attribute.
    /// </summary>
    public TerraformProperty<string> DatabaseInsightsMode
    {
        get => GetRequiredOutput<TerraformProperty<string>>("database_insights_mode");
        set => SetProperty("database_insights_mode", value);
    }

    /// <summary>
    /// The database_name attribute.
    /// </summary>
    public TerraformProperty<string> DatabaseName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("database_name");
        set => SetProperty("database_name", value);
    }

    /// <summary>
    /// The db_cluster_instance_class attribute.
    /// </summary>
    public TerraformProperty<string> DbClusterInstanceClass
    {
        get => GetRequiredOutput<TerraformProperty<string>>("db_cluster_instance_class");
        set => SetProperty("db_cluster_instance_class", value);
    }

    /// <summary>
    /// The db_cluster_parameter_group_name attribute.
    /// </summary>
    public TerraformProperty<string> DbClusterParameterGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("db_cluster_parameter_group_name");
        set => SetProperty("db_cluster_parameter_group_name", value);
    }

    /// <summary>
    /// The db_instance_parameter_group_name attribute.
    /// </summary>
    public TerraformProperty<string> DbInstanceParameterGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("db_instance_parameter_group_name");
        set => SetProperty("db_instance_parameter_group_name", value);
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
    /// The db_system_id attribute.
    /// </summary>
    public TerraformProperty<string> DbSystemId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("db_system_id");
        set => SetProperty("db_system_id", value);
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
    /// The domain_iam_role_name attribute.
    /// </summary>
    public TerraformProperty<string> DomainIamRoleName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("domain_iam_role_name");
        set => SetProperty("domain_iam_role_name", value);
    }

    /// <summary>
    /// The enable_global_write_forwarding attribute.
    /// </summary>
    public TerraformProperty<bool> EnableGlobalWriteForwarding
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("enable_global_write_forwarding");
        set => SetProperty("enable_global_write_forwarding", value);
    }

    /// <summary>
    /// The enable_http_endpoint attribute.
    /// </summary>
    public TerraformProperty<bool> EnableHttpEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("enable_http_endpoint");
        set => SetProperty("enable_http_endpoint", value);
    }

    /// <summary>
    /// The enable_local_write_forwarding attribute.
    /// </summary>
    public TerraformProperty<bool> EnableLocalWriteForwarding
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("enable_local_write_forwarding");
        set => SetProperty("enable_local_write_forwarding", value);
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Engine is required")]
    public required TerraformProperty<string> Engine
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
    /// The engine_mode attribute.
    /// </summary>
    public TerraformProperty<string> EngineMode
    {
        get => GetRequiredOutput<TerraformProperty<string>>("engine_mode");
        set => SetProperty("engine_mode", value);
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
    /// The global_cluster_identifier attribute.
    /// </summary>
    public TerraformProperty<string> GlobalClusterIdentifier
    {
        get => GetRequiredOutput<TerraformProperty<string>>("global_cluster_identifier");
        set => SetProperty("global_cluster_identifier", value);
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
    /// The iam_roles attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> IamRoles
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("iam_roles");
        set => SetProperty("iam_roles", value);
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
    /// The manage_master_user_password attribute.
    /// </summary>
    public TerraformProperty<bool> ManageMasterUserPassword
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("manage_master_user_password");
        set => SetProperty("manage_master_user_password", value);
    }

    /// <summary>
    /// The master_password attribute.
    /// </summary>
    public TerraformProperty<string> MasterPassword
    {
        get => GetRequiredOutput<TerraformProperty<string>>("master_password");
        set => SetProperty("master_password", value);
    }

    /// <summary>
    /// The master_password_wo attribute.
    /// </summary>
    public TerraformProperty<string> MasterPasswordWo
    {
        get => GetRequiredOutput<TerraformProperty<string>>("master_password_wo");
        set => SetProperty("master_password_wo", value);
    }

    /// <summary>
    /// The master_password_wo_version attribute.
    /// </summary>
    public TerraformProperty<double> MasterPasswordWoVersion
    {
        get => GetRequiredOutput<TerraformProperty<double>>("master_password_wo_version");
        set => SetProperty("master_password_wo_version", value);
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
    /// The master_username attribute.
    /// </summary>
    public TerraformProperty<string> MasterUsername
    {
        get => GetRequiredOutput<TerraformProperty<string>>("master_username");
        set => SetProperty("master_username", value);
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
    /// The network_type attribute.
    /// </summary>
    public TerraformProperty<string> NetworkType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("network_type");
        set => SetProperty("network_type", value);
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
    /// The preferred_backup_window attribute.
    /// </summary>
    public TerraformProperty<string> PreferredBackupWindow
    {
        get => GetRequiredOutput<TerraformProperty<string>>("preferred_backup_window");
        set => SetProperty("preferred_backup_window", value);
    }

    /// <summary>
    /// The preferred_maintenance_window attribute.
    /// </summary>
    public TerraformProperty<string> PreferredMaintenanceWindow
    {
        get => GetRequiredOutput<TerraformProperty<string>>("preferred_maintenance_window");
        set => SetProperty("preferred_maintenance_window", value);
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
    /// The replication_source_identifier attribute.
    /// </summary>
    public TerraformProperty<string> ReplicationSourceIdentifier
    {
        get => GetRequiredOutput<TerraformProperty<string>>("replication_source_identifier");
        set => SetProperty("replication_source_identifier", value);
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
    /// The source_region attribute.
    /// </summary>
    public TerraformProperty<string> SourceRegion
    {
        get => GetRequiredOutput<TerraformProperty<string>>("source_region");
        set => SetProperty("source_region", value);
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
    /// The vpc_security_group_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> VpcSecurityGroupIds
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("vpc_security_group_ids");
        set => SetProperty("vpc_security_group_ids", value);
    }

    /// <summary>
    /// Block for restore_to_point_in_time.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RestoreToPointInTime block(s) allowed")]
    public List<AwsRdsClusterRestoreToPointInTimeBlock>? RestoreToPointInTime
    {
        set => SetProperty("restore_to_point_in_time", value);
    }

    /// <summary>
    /// Block for s3_import.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 S3Import block(s) allowed")]
    public List<AwsRdsClusterS3ImportBlock>? S3Import
    {
        set => SetProperty("s3_import", value);
    }

    /// <summary>
    /// Block for scaling_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ScalingConfiguration block(s) allowed")]
    public List<AwsRdsClusterScalingConfigurationBlock>? ScalingConfiguration
    {
        set => SetProperty("scaling_configuration", value);
    }

    /// <summary>
    /// Block for serverlessv2_scaling_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Serverlessv2ScalingConfiguration block(s) allowed")]
    public List<AwsRdsClusterServerlessv2ScalingConfigurationBlock>? Serverlessv2ScalingConfiguration
    {
        set => SetProperty("serverlessv2_scaling_configuration", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsRdsClusterTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The ca_certificate_valid_till attribute.
    /// </summary>
    public TerraformExpression CaCertificateValidTill => this["ca_certificate_valid_till"];

    /// <summary>
    /// The cluster_resource_id attribute.
    /// </summary>
    public TerraformExpression ClusterResourceId => this["cluster_resource_id"];

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
    /// The master_user_secret attribute.
    /// </summary>
    public TerraformExpression MasterUserSecret => this["master_user_secret"];

    /// <summary>
    /// The reader_endpoint attribute.
    /// </summary>
    public TerraformExpression ReaderEndpoint => this["reader_endpoint"];

}
