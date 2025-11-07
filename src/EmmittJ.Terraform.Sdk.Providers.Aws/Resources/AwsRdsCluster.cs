using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_rds_cluster resource.
/// </summary>
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
    public TerraformProperty<HashSet<string>>? AvailabilityZones
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("availability_zones");
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
    public TerraformProperty<HashSet<string>>? ClusterMembers
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("cluster_members");
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
    public TerraformProperty<HashSet<string>>? EnabledCloudwatchLogsExports
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("enabled_cloudwatch_logs_exports");
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
    public TerraformProperty<HashSet<string>>? IamRoles
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("iam_roles");
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
    public TerraformProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? TagsAll
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The vpc_security_group_ids attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? VpcSecurityGroupIds
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("vpc_security_group_ids");
        set => this.WithProperty("vpc_security_group_ids", value);
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
