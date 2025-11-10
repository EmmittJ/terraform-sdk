using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for restore_to_point_in_time in .
/// Nesting mode: list
/// </summary>
public class AwsRdsClusterRestoreToPointInTimeBlock : ITerraformBlock
{
    /// <summary>
    /// The restore_to_time attribute.
    /// </summary>
    [TerraformPropertyName("restore_to_time")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? RestoreToTime { get; set; }

    /// <summary>
    /// The restore_type attribute.
    /// </summary>
    [TerraformPropertyName("restore_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? RestoreType { get; set; }

    /// <summary>
    /// The source_cluster_identifier attribute.
    /// </summary>
    [TerraformPropertyName("source_cluster_identifier")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SourceClusterIdentifier { get; set; }

    /// <summary>
    /// The source_cluster_resource_id attribute.
    /// </summary>
    [TerraformPropertyName("source_cluster_resource_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SourceClusterResourceId { get; set; }

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
public class AwsRdsClusterS3ImportBlock : ITerraformBlock
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
/// Block type for scaling_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsRdsClusterScalingConfigurationBlock : ITerraformBlock
{
    /// <summary>
    /// The auto_pause attribute.
    /// </summary>
    [TerraformPropertyName("auto_pause")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? AutoPause { get; set; }

    /// <summary>
    /// The max_capacity attribute.
    /// </summary>
    [TerraformPropertyName("max_capacity")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? MaxCapacity { get; set; }

    /// <summary>
    /// The min_capacity attribute.
    /// </summary>
    [TerraformPropertyName("min_capacity")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? MinCapacity { get; set; }

    /// <summary>
    /// The seconds_before_timeout attribute.
    /// </summary>
    [TerraformPropertyName("seconds_before_timeout")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? SecondsBeforeTimeout { get; set; }

    /// <summary>
    /// The seconds_until_auto_pause attribute.
    /// </summary>
    [TerraformPropertyName("seconds_until_auto_pause")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? SecondsUntilAutoPause { get; set; }

    /// <summary>
    /// The timeout_action attribute.
    /// </summary>
    [TerraformPropertyName("timeout_action")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? TimeoutAction { get; set; }

}

/// <summary>
/// Block type for serverlessv2_scaling_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsRdsClusterServerlessv2ScalingConfigurationBlock : ITerraformBlock
{
    /// <summary>
    /// The max_capacity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxCapacity is required")]
    [TerraformPropertyName("max_capacity")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> MaxCapacity { get; set; }

    /// <summary>
    /// The min_capacity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MinCapacity is required")]
    [TerraformPropertyName("min_capacity")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> MinCapacity { get; set; }

    /// <summary>
    /// The seconds_until_auto_pause attribute.
    /// </summary>
    [TerraformPropertyName("seconds_until_auto_pause")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> SecondsUntilAutoPause { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>("", "seconds_until_auto_pause");

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsRdsClusterTimeoutsBlock : ITerraformBlock
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
/// Manages a aws_rds_cluster resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsRdsCluster : TerraformResource
{
    public AwsRdsCluster(string name) : base("aws_rds_cluster", name)
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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> ApplyImmediately { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "apply_immediately");

    /// <summary>
    /// The availability_zones attribute.
    /// </summary>
    [TerraformPropertyName("availability_zones")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<HashSet<TerraformProperty<string>>> AvailabilityZones { get; set; } = new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "availability_zones");

    /// <summary>
    /// The backtrack_window attribute.
    /// </summary>
    [TerraformPropertyName("backtrack_window")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? BacktrackWindow { get; set; }

    /// <summary>
    /// The backup_retention_period attribute.
    /// </summary>
    [TerraformPropertyName("backup_retention_period")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> BackupRetentionPeriod { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "backup_retention_period");

    /// <summary>
    /// The ca_certificate_identifier attribute.
    /// </summary>
    [TerraformPropertyName("ca_certificate_identifier")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> CaCertificateIdentifier { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "ca_certificate_identifier");

    /// <summary>
    /// The cluster_identifier attribute.
    /// </summary>
    [TerraformPropertyName("cluster_identifier")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ClusterIdentifier { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "cluster_identifier");

    /// <summary>
    /// The cluster_identifier_prefix attribute.
    /// </summary>
    [TerraformPropertyName("cluster_identifier_prefix")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ClusterIdentifierPrefix { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "cluster_identifier_prefix");

    /// <summary>
    /// The cluster_members attribute.
    /// </summary>
    [TerraformPropertyName("cluster_members")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<HashSet<TerraformProperty<string>>> ClusterMembers { get; set; } = new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "cluster_members");

    /// <summary>
    /// The cluster_scalability_type attribute.
    /// </summary>
    [TerraformPropertyName("cluster_scalability_type")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ClusterScalabilityType { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "cluster_scalability_type");

    /// <summary>
    /// The copy_tags_to_snapshot attribute.
    /// </summary>
    [TerraformPropertyName("copy_tags_to_snapshot")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? CopyTagsToSnapshot { get; set; }

    /// <summary>
    /// The database_insights_mode attribute.
    /// </summary>
    [TerraformPropertyName("database_insights_mode")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> DatabaseInsightsMode { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "database_insights_mode");

    /// <summary>
    /// The database_name attribute.
    /// </summary>
    [TerraformPropertyName("database_name")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> DatabaseName { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "database_name");

    /// <summary>
    /// The db_cluster_instance_class attribute.
    /// </summary>
    [TerraformPropertyName("db_cluster_instance_class")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DbClusterInstanceClass { get; set; }

    /// <summary>
    /// The db_cluster_parameter_group_name attribute.
    /// </summary>
    [TerraformPropertyName("db_cluster_parameter_group_name")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> DbClusterParameterGroupName { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "db_cluster_parameter_group_name");

    /// <summary>
    /// The db_instance_parameter_group_name attribute.
    /// </summary>
    [TerraformPropertyName("db_instance_parameter_group_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DbInstanceParameterGroupName { get; set; }

    /// <summary>
    /// The db_subnet_group_name attribute.
    /// </summary>
    [TerraformPropertyName("db_subnet_group_name")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> DbSubnetGroupName { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "db_subnet_group_name");

    /// <summary>
    /// The db_system_id attribute.
    /// </summary>
    [TerraformPropertyName("db_system_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> DbSystemId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "db_system_id");

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
    /// The domain_iam_role_name attribute.
    /// </summary>
    [TerraformPropertyName("domain_iam_role_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DomainIamRoleName { get; set; }

    /// <summary>
    /// The enable_global_write_forwarding attribute.
    /// </summary>
    [TerraformPropertyName("enable_global_write_forwarding")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? EnableGlobalWriteForwarding { get; set; }

    /// <summary>
    /// The enable_http_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("enable_http_endpoint")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? EnableHttpEndpoint { get; set; }

    /// <summary>
    /// The enable_local_write_forwarding attribute.
    /// </summary>
    [TerraformPropertyName("enable_local_write_forwarding")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? EnableLocalWriteForwarding { get; set; }

    /// <summary>
    /// The enabled_cloudwatch_logs_exports attribute.
    /// </summary>
    [TerraformPropertyName("enabled_cloudwatch_logs_exports")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? EnabledCloudwatchLogsExports { get; set; }

    /// <summary>
    /// The engine attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Engine is required")]
    [TerraformPropertyName("engine")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Engine { get; set; }

    /// <summary>
    /// The engine_lifecycle_support attribute.
    /// </summary>
    [TerraformPropertyName("engine_lifecycle_support")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> EngineLifecycleSupport { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "engine_lifecycle_support");

    /// <summary>
    /// The engine_mode attribute.
    /// </summary>
    [TerraformPropertyName("engine_mode")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? EngineMode { get; set; }

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
    /// The global_cluster_identifier attribute.
    /// </summary>
    [TerraformPropertyName("global_cluster_identifier")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? GlobalClusterIdentifier { get; set; }

    /// <summary>
    /// The iam_database_authentication_enabled attribute.
    /// </summary>
    [TerraformPropertyName("iam_database_authentication_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? IamDatabaseAuthenticationEnabled { get; set; }

    /// <summary>
    /// The iam_roles attribute.
    /// </summary>
    [TerraformPropertyName("iam_roles")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<HashSet<TerraformProperty<string>>> IamRoles { get; set; } = new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "iam_roles");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The iops attribute.
    /// </summary>
    [TerraformPropertyName("iops")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? Iops { get; set; }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    [TerraformPropertyName("kms_key_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> KmsKeyId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "kms_key_id");

    /// <summary>
    /// The manage_master_user_password attribute.
    /// </summary>
    [TerraformPropertyName("manage_master_user_password")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? ManageMasterUserPassword { get; set; }

    /// <summary>
    /// The master_password attribute.
    /// </summary>
    [TerraformPropertyName("master_password")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? MasterPassword { get; set; }

    /// <summary>
    /// The master_password_wo attribute.
    /// </summary>
    [TerraformPropertyName("master_password_wo")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? MasterPasswordWo { get; set; }

    /// <summary>
    /// The master_password_wo_version attribute.
    /// </summary>
    [TerraformPropertyName("master_password_wo_version")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? MasterPasswordWoVersion { get; set; }

    /// <summary>
    /// The master_user_secret_kms_key_id attribute.
    /// </summary>
    [TerraformPropertyName("master_user_secret_kms_key_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> MasterUserSecretKmsKeyId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "master_user_secret_kms_key_id");

    /// <summary>
    /// The master_username attribute.
    /// </summary>
    [TerraformPropertyName("master_username")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> MasterUsername { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "master_username");

    /// <summary>
    /// The monitoring_interval attribute.
    /// </summary>
    [TerraformPropertyName("monitoring_interval")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> MonitoringInterval { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "monitoring_interval");

    /// <summary>
    /// The monitoring_role_arn attribute.
    /// </summary>
    [TerraformPropertyName("monitoring_role_arn")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> MonitoringRoleArn { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "monitoring_role_arn");

    /// <summary>
    /// The network_type attribute.
    /// </summary>
    [TerraformPropertyName("network_type")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> NetworkType { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "network_type");

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
    /// The preferred_backup_window attribute.
    /// </summary>
    [TerraformPropertyName("preferred_backup_window")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> PreferredBackupWindow { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "preferred_backup_window");

    /// <summary>
    /// The preferred_maintenance_window attribute.
    /// </summary>
    [TerraformPropertyName("preferred_maintenance_window")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> PreferredMaintenanceWindow { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "preferred_maintenance_window");

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The replication_source_identifier attribute.
    /// </summary>
    [TerraformPropertyName("replication_source_identifier")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ReplicationSourceIdentifier { get; set; }

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
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SnapshotIdentifier { get; set; }

    /// <summary>
    /// The source_region attribute.
    /// </summary>
    [TerraformPropertyName("source_region")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SourceRegion { get; set; }

    /// <summary>
    /// The storage_encrypted attribute.
    /// </summary>
    [TerraformPropertyName("storage_encrypted")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> StorageEncrypted { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "storage_encrypted");

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
    /// The vpc_security_group_ids attribute.
    /// </summary>
    [TerraformPropertyName("vpc_security_group_ids")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<HashSet<TerraformProperty<string>>> VpcSecurityGroupIds { get; set; } = new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "vpc_security_group_ids");

    /// <summary>
    /// Block for restore_to_point_in_time.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RestoreToPointInTime block(s) allowed")]
    [TerraformPropertyName("restore_to_point_in_time")]
    public TerraformList<TerraformBlock<AwsRdsClusterRestoreToPointInTimeBlock>>? RestoreToPointInTime { get; set; } = new();

    /// <summary>
    /// Block for s3_import.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 S3Import block(s) allowed")]
    [TerraformPropertyName("s3_import")]
    public TerraformList<TerraformBlock<AwsRdsClusterS3ImportBlock>>? S3Import { get; set; } = new();

    /// <summary>
    /// Block for scaling_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ScalingConfiguration block(s) allowed")]
    [TerraformPropertyName("scaling_configuration")]
    public TerraformList<TerraformBlock<AwsRdsClusterScalingConfigurationBlock>>? ScalingConfiguration { get; set; } = new();

    /// <summary>
    /// Block for serverlessv2_scaling_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Serverlessv2ScalingConfiguration block(s) allowed")]
    [TerraformPropertyName("serverlessv2_scaling_configuration")]
    public TerraformList<TerraformBlock<AwsRdsClusterServerlessv2ScalingConfigurationBlock>>? Serverlessv2ScalingConfiguration { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsRdsClusterTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The ca_certificate_valid_till attribute.
    /// </summary>
    [TerraformPropertyName("ca_certificate_valid_till")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CaCertificateValidTill => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "ca_certificate_valid_till");

    /// <summary>
    /// The cluster_resource_id attribute.
    /// </summary>
    [TerraformPropertyName("cluster_resource_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ClusterResourceId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "cluster_resource_id");

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
    /// The master_user_secret attribute.
    /// </summary>
    [TerraformPropertyName("master_user_secret")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> MasterUserSecret => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "master_user_secret");

    /// <summary>
    /// The reader_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("reader_endpoint")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ReaderEndpoint => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "reader_endpoint");

}
