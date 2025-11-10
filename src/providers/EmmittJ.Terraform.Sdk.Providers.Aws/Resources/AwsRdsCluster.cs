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
        get => GetProperty<TerraformProperty<string>>("restore_to_time");
        set => WithProperty("restore_to_time", value);
    }

    /// <summary>
    /// The restore_type attribute.
    /// </summary>
    public TerraformProperty<string>? RestoreType
    {
        get => GetProperty<TerraformProperty<string>>("restore_type");
        set => WithProperty("restore_type", value);
    }

    /// <summary>
    /// The source_cluster_identifier attribute.
    /// </summary>
    public TerraformProperty<string>? SourceClusterIdentifier
    {
        get => GetProperty<TerraformProperty<string>>("source_cluster_identifier");
        set => WithProperty("source_cluster_identifier", value);
    }

    /// <summary>
    /// The source_cluster_resource_id attribute.
    /// </summary>
    public TerraformProperty<string>? SourceClusterResourceId
    {
        get => GetProperty<TerraformProperty<string>>("source_cluster_resource_id");
        set => WithProperty("source_cluster_resource_id", value);
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
public class AwsRdsClusterS3ImportBlock : TerraformBlock
{
    /// <summary>
    /// The bucket_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BucketName is required")]
    public required TerraformProperty<string> BucketName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("bucket_name");
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
        get => GetRequiredProperty<TerraformProperty<string>>("ingestion_role");
        set => WithProperty("ingestion_role", value);
    }

    /// <summary>
    /// The source_engine attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceEngine is required")]
    public required TerraformProperty<string> SourceEngine
    {
        get => GetRequiredProperty<TerraformProperty<string>>("source_engine");
        set => WithProperty("source_engine", value);
    }

    /// <summary>
    /// The source_engine_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceEngineVersion is required")]
    public required TerraformProperty<string> SourceEngineVersion
    {
        get => GetRequiredProperty<TerraformProperty<string>>("source_engine_version");
        set => WithProperty("source_engine_version", value);
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
        get => GetProperty<TerraformProperty<bool>>("auto_pause");
        set => WithProperty("auto_pause", value);
    }

    /// <summary>
    /// The max_capacity attribute.
    /// </summary>
    public TerraformProperty<double>? MaxCapacity
    {
        get => GetProperty<TerraformProperty<double>>("max_capacity");
        set => WithProperty("max_capacity", value);
    }

    /// <summary>
    /// The min_capacity attribute.
    /// </summary>
    public TerraformProperty<double>? MinCapacity
    {
        get => GetProperty<TerraformProperty<double>>("min_capacity");
        set => WithProperty("min_capacity", value);
    }

    /// <summary>
    /// The seconds_before_timeout attribute.
    /// </summary>
    public TerraformProperty<double>? SecondsBeforeTimeout
    {
        get => GetProperty<TerraformProperty<double>>("seconds_before_timeout");
        set => WithProperty("seconds_before_timeout", value);
    }

    /// <summary>
    /// The seconds_until_auto_pause attribute.
    /// </summary>
    public TerraformProperty<double>? SecondsUntilAutoPause
    {
        get => GetProperty<TerraformProperty<double>>("seconds_until_auto_pause");
        set => WithProperty("seconds_until_auto_pause", value);
    }

    /// <summary>
    /// The timeout_action attribute.
    /// </summary>
    public TerraformProperty<string>? TimeoutAction
    {
        get => GetProperty<TerraformProperty<string>>("timeout_action");
        set => WithProperty("timeout_action", value);
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
        get => GetRequiredProperty<TerraformProperty<double>>("max_capacity");
        set => WithProperty("max_capacity", value);
    }

    /// <summary>
    /// The min_capacity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MinCapacity is required")]
    public required TerraformProperty<double> MinCapacity
    {
        get => GetRequiredProperty<TerraformProperty<double>>("min_capacity");
        set => WithProperty("min_capacity", value);
    }

    /// <summary>
    /// The seconds_until_auto_pause attribute.
    /// </summary>
    public TerraformProperty<double>? SecondsUntilAutoPause
    {
        get => GetProperty<TerraformProperty<double>>("seconds_until_auto_pause");
        set => WithProperty("seconds_until_auto_pause", value);
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
        this.DeclareOutput("arn");
        this.DeclareOutput("ca_certificate_valid_till");
        this.DeclareOutput("cluster_resource_id");
        this.DeclareOutput("endpoint");
        this.DeclareOutput("engine_version_actual");
        this.DeclareOutput("hosted_zone_id");
        this.DeclareOutput("master_user_secret");
        this.DeclareOutput("reader_endpoint");
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
    /// The availability_zones attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? AvailabilityZones
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("availability_zones");
        set => this.WithProperty("availability_zones", value);
    }

    /// <summary>
    /// The backtrack_window attribute.
    /// </summary>
    public TerraformProperty<double>? BacktrackWindow
    {
        get => GetProperty<TerraformProperty<double>>("backtrack_window");
        set => this.WithProperty("backtrack_window", value);
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
    /// The ca_certificate_identifier attribute.
    /// </summary>
    public TerraformProperty<string>? CaCertificateIdentifier
    {
        get => GetProperty<TerraformProperty<string>>("ca_certificate_identifier");
        set => this.WithProperty("ca_certificate_identifier", value);
    }

    /// <summary>
    /// The cluster_identifier attribute.
    /// </summary>
    public TerraformProperty<string>? ClusterIdentifier
    {
        get => GetProperty<TerraformProperty<string>>("cluster_identifier");
        set => this.WithProperty("cluster_identifier", value);
    }

    /// <summary>
    /// The cluster_identifier_prefix attribute.
    /// </summary>
    public TerraformProperty<string>? ClusterIdentifierPrefix
    {
        get => GetProperty<TerraformProperty<string>>("cluster_identifier_prefix");
        set => this.WithProperty("cluster_identifier_prefix", value);
    }

    /// <summary>
    /// The cluster_members attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? ClusterMembers
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("cluster_members");
        set => this.WithProperty("cluster_members", value);
    }

    /// <summary>
    /// The cluster_scalability_type attribute.
    /// </summary>
    public TerraformProperty<string>? ClusterScalabilityType
    {
        get => GetProperty<TerraformProperty<string>>("cluster_scalability_type");
        set => this.WithProperty("cluster_scalability_type", value);
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
    /// The database_insights_mode attribute.
    /// </summary>
    public TerraformProperty<string>? DatabaseInsightsMode
    {
        get => GetProperty<TerraformProperty<string>>("database_insights_mode");
        set => this.WithProperty("database_insights_mode", value);
    }

    /// <summary>
    /// The database_name attribute.
    /// </summary>
    public TerraformProperty<string>? DatabaseName
    {
        get => GetProperty<TerraformProperty<string>>("database_name");
        set => this.WithProperty("database_name", value);
    }

    /// <summary>
    /// The db_cluster_instance_class attribute.
    /// </summary>
    public TerraformProperty<string>? DbClusterInstanceClass
    {
        get => GetProperty<TerraformProperty<string>>("db_cluster_instance_class");
        set => this.WithProperty("db_cluster_instance_class", value);
    }

    /// <summary>
    /// The db_cluster_parameter_group_name attribute.
    /// </summary>
    public TerraformProperty<string>? DbClusterParameterGroupName
    {
        get => GetProperty<TerraformProperty<string>>("db_cluster_parameter_group_name");
        set => this.WithProperty("db_cluster_parameter_group_name", value);
    }

    /// <summary>
    /// The db_instance_parameter_group_name attribute.
    /// </summary>
    public TerraformProperty<string>? DbInstanceParameterGroupName
    {
        get => GetProperty<TerraformProperty<string>>("db_instance_parameter_group_name");
        set => this.WithProperty("db_instance_parameter_group_name", value);
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
    /// The db_system_id attribute.
    /// </summary>
    public TerraformProperty<string>? DbSystemId
    {
        get => GetProperty<TerraformProperty<string>>("db_system_id");
        set => this.WithProperty("db_system_id", value);
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
    /// The domain_iam_role_name attribute.
    /// </summary>
    public TerraformProperty<string>? DomainIamRoleName
    {
        get => GetProperty<TerraformProperty<string>>("domain_iam_role_name");
        set => this.WithProperty("domain_iam_role_name", value);
    }

    /// <summary>
    /// The enable_global_write_forwarding attribute.
    /// </summary>
    public TerraformProperty<bool>? EnableGlobalWriteForwarding
    {
        get => GetProperty<TerraformProperty<bool>>("enable_global_write_forwarding");
        set => this.WithProperty("enable_global_write_forwarding", value);
    }

    /// <summary>
    /// The enable_http_endpoint attribute.
    /// </summary>
    public TerraformProperty<bool>? EnableHttpEndpoint
    {
        get => GetProperty<TerraformProperty<bool>>("enable_http_endpoint");
        set => this.WithProperty("enable_http_endpoint", value);
    }

    /// <summary>
    /// The enable_local_write_forwarding attribute.
    /// </summary>
    public TerraformProperty<bool>? EnableLocalWriteForwarding
    {
        get => GetProperty<TerraformProperty<bool>>("enable_local_write_forwarding");
        set => this.WithProperty("enable_local_write_forwarding", value);
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Engine is required")]
    public required TerraformProperty<string> Engine
    {
        get => GetRequiredProperty<TerraformProperty<string>>("engine");
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
    /// The engine_mode attribute.
    /// </summary>
    public TerraformProperty<string>? EngineMode
    {
        get => GetProperty<TerraformProperty<string>>("engine_mode");
        set => this.WithProperty("engine_mode", value);
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
    /// The global_cluster_identifier attribute.
    /// </summary>
    public TerraformProperty<string>? GlobalClusterIdentifier
    {
        get => GetProperty<TerraformProperty<string>>("global_cluster_identifier");
        set => this.WithProperty("global_cluster_identifier", value);
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
    /// The iam_roles attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? IamRoles
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("iam_roles");
        set => this.WithProperty("iam_roles", value);
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
    /// The manage_master_user_password attribute.
    /// </summary>
    public TerraformProperty<bool>? ManageMasterUserPassword
    {
        get => GetProperty<TerraformProperty<bool>>("manage_master_user_password");
        set => this.WithProperty("manage_master_user_password", value);
    }

    /// <summary>
    /// The master_password attribute.
    /// </summary>
    public TerraformProperty<string>? MasterPassword
    {
        get => GetProperty<TerraformProperty<string>>("master_password");
        set => this.WithProperty("master_password", value);
    }

    /// <summary>
    /// The master_password_wo attribute.
    /// </summary>
    public TerraformProperty<string>? MasterPasswordWo
    {
        get => GetProperty<TerraformProperty<string>>("master_password_wo");
        set => this.WithProperty("master_password_wo", value);
    }

    /// <summary>
    /// The master_password_wo_version attribute.
    /// </summary>
    public TerraformProperty<double>? MasterPasswordWoVersion
    {
        get => GetProperty<TerraformProperty<double>>("master_password_wo_version");
        set => this.WithProperty("master_password_wo_version", value);
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
    /// The master_username attribute.
    /// </summary>
    public TerraformProperty<string>? MasterUsername
    {
        get => GetProperty<TerraformProperty<string>>("master_username");
        set => this.WithProperty("master_username", value);
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
    /// The network_type attribute.
    /// </summary>
    public TerraformProperty<string>? NetworkType
    {
        get => GetProperty<TerraformProperty<string>>("network_type");
        set => this.WithProperty("network_type", value);
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
    /// The preferred_backup_window attribute.
    /// </summary>
    public TerraformProperty<string>? PreferredBackupWindow
    {
        get => GetProperty<TerraformProperty<string>>("preferred_backup_window");
        set => this.WithProperty("preferred_backup_window", value);
    }

    /// <summary>
    /// The preferred_maintenance_window attribute.
    /// </summary>
    public TerraformProperty<string>? PreferredMaintenanceWindow
    {
        get => GetProperty<TerraformProperty<string>>("preferred_maintenance_window");
        set => this.WithProperty("preferred_maintenance_window", value);
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
    /// The replication_source_identifier attribute.
    /// </summary>
    public TerraformProperty<string>? ReplicationSourceIdentifier
    {
        get => GetProperty<TerraformProperty<string>>("replication_source_identifier");
        set => this.WithProperty("replication_source_identifier", value);
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
    /// The source_region attribute.
    /// </summary>
    public TerraformProperty<string>? SourceRegion
    {
        get => GetProperty<TerraformProperty<string>>("source_region");
        set => this.WithProperty("source_region", value);
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
    /// The vpc_security_group_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? VpcSecurityGroupIds
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("vpc_security_group_ids");
        set => this.WithProperty("vpc_security_group_ids", value);
    }

    /// <summary>
    /// Block for restore_to_point_in_time.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RestoreToPointInTime block(s) allowed")]
    public List<AwsRdsClusterRestoreToPointInTimeBlock>? RestoreToPointInTime
    {
        get => GetProperty<List<AwsRdsClusterRestoreToPointInTimeBlock>>("restore_to_point_in_time");
        set => this.WithProperty("restore_to_point_in_time", value);
    }

    /// <summary>
    /// Block for s3_import.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 S3Import block(s) allowed")]
    public List<AwsRdsClusterS3ImportBlock>? S3Import
    {
        get => GetProperty<List<AwsRdsClusterS3ImportBlock>>("s3_import");
        set => this.WithProperty("s3_import", value);
    }

    /// <summary>
    /// Block for scaling_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ScalingConfiguration block(s) allowed")]
    public List<AwsRdsClusterScalingConfigurationBlock>? ScalingConfiguration
    {
        get => GetProperty<List<AwsRdsClusterScalingConfigurationBlock>>("scaling_configuration");
        set => this.WithProperty("scaling_configuration", value);
    }

    /// <summary>
    /// Block for serverlessv2_scaling_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Serverlessv2ScalingConfiguration block(s) allowed")]
    public List<AwsRdsClusterServerlessv2ScalingConfigurationBlock>? Serverlessv2ScalingConfiguration
    {
        get => GetProperty<List<AwsRdsClusterServerlessv2ScalingConfigurationBlock>>("serverlessv2_scaling_configuration");
        set => this.WithProperty("serverlessv2_scaling_configuration", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsRdsClusterTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsRdsClusterTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
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
