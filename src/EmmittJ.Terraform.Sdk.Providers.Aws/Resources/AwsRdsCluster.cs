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
    public double? AllocatedStorage
    {
        get => GetProperty<TerraformLiteralProperty<double>>("allocated_storage")?.Value;
        set => this.WithProperty("allocated_storage", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The allow_major_version_upgrade attribute.
    /// </summary>
    public bool? AllowMajorVersionUpgrade
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("allow_major_version_upgrade")?.Value;
        set => this.WithProperty("allow_major_version_upgrade", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The apply_immediately attribute.
    /// </summary>
    public bool? ApplyImmediately
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("apply_immediately")?.Value;
        set => this.WithProperty("apply_immediately", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The availability_zones attribute.
    /// </summary>
    public HashSet<string>? AvailabilityZones
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("availability_zones")?.Value;
        set => this.WithProperty("availability_zones", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The backtrack_window attribute.
    /// </summary>
    public double? BacktrackWindow
    {
        get => GetProperty<TerraformLiteralProperty<double>>("backtrack_window")?.Value;
        set => this.WithProperty("backtrack_window", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The backup_retention_period attribute.
    /// </summary>
    public double? BackupRetentionPeriod
    {
        get => GetProperty<TerraformLiteralProperty<double>>("backup_retention_period")?.Value;
        set => this.WithProperty("backup_retention_period", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The ca_certificate_identifier attribute.
    /// </summary>
    public string? CaCertificateIdentifier
    {
        get => GetProperty<TerraformLiteralProperty<string>>("ca_certificate_identifier")?.Value;
        set => this.WithProperty("ca_certificate_identifier", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The cluster_identifier attribute.
    /// </summary>
    public string? ClusterIdentifier
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cluster_identifier")?.Value;
        set => this.WithProperty("cluster_identifier", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The cluster_identifier_prefix attribute.
    /// </summary>
    public string? ClusterIdentifierPrefix
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cluster_identifier_prefix")?.Value;
        set => this.WithProperty("cluster_identifier_prefix", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The cluster_members attribute.
    /// </summary>
    public HashSet<string>? ClusterMembers
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("cluster_members")?.Value;
        set => this.WithProperty("cluster_members", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The cluster_scalability_type attribute.
    /// </summary>
    public string? ClusterScalabilityType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cluster_scalability_type")?.Value;
        set => this.WithProperty("cluster_scalability_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The copy_tags_to_snapshot attribute.
    /// </summary>
    public bool? CopyTagsToSnapshot
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("copy_tags_to_snapshot")?.Value;
        set => this.WithProperty("copy_tags_to_snapshot", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The database_insights_mode attribute.
    /// </summary>
    public string? DatabaseInsightsMode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("database_insights_mode")?.Value;
        set => this.WithProperty("database_insights_mode", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The database_name attribute.
    /// </summary>
    public string? DatabaseName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("database_name")?.Value;
        set => this.WithProperty("database_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The db_cluster_instance_class attribute.
    /// </summary>
    public string? DbClusterInstanceClass
    {
        get => GetProperty<TerraformLiteralProperty<string>>("db_cluster_instance_class")?.Value;
        set => this.WithProperty("db_cluster_instance_class", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The db_cluster_parameter_group_name attribute.
    /// </summary>
    public string? DbClusterParameterGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("db_cluster_parameter_group_name")?.Value;
        set => this.WithProperty("db_cluster_parameter_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The db_instance_parameter_group_name attribute.
    /// </summary>
    public string? DbInstanceParameterGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("db_instance_parameter_group_name")?.Value;
        set => this.WithProperty("db_instance_parameter_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The db_subnet_group_name attribute.
    /// </summary>
    public string? DbSubnetGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("db_subnet_group_name")?.Value;
        set => this.WithProperty("db_subnet_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The db_system_id attribute.
    /// </summary>
    public string? DbSystemId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("db_system_id")?.Value;
        set => this.WithProperty("db_system_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The delete_automated_backups attribute.
    /// </summary>
    public bool? DeleteAutomatedBackups
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("delete_automated_backups")?.Value;
        set => this.WithProperty("delete_automated_backups", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The deletion_protection attribute.
    /// </summary>
    public bool? DeletionProtection
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("deletion_protection")?.Value;
        set => this.WithProperty("deletion_protection", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The domain attribute.
    /// </summary>
    public string? Domain
    {
        get => GetProperty<TerraformLiteralProperty<string>>("domain")?.Value;
        set => this.WithProperty("domain", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The domain_iam_role_name attribute.
    /// </summary>
    public string? DomainIamRoleName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("domain_iam_role_name")?.Value;
        set => this.WithProperty("domain_iam_role_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The enable_global_write_forwarding attribute.
    /// </summary>
    public bool? EnableGlobalWriteForwarding
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enable_global_write_forwarding")?.Value;
        set => this.WithProperty("enable_global_write_forwarding", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The enable_http_endpoint attribute.
    /// </summary>
    public bool? EnableHttpEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enable_http_endpoint")?.Value;
        set => this.WithProperty("enable_http_endpoint", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The enable_local_write_forwarding attribute.
    /// </summary>
    public bool? EnableLocalWriteForwarding
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enable_local_write_forwarding")?.Value;
        set => this.WithProperty("enable_local_write_forwarding", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The enabled_cloudwatch_logs_exports attribute.
    /// </summary>
    public HashSet<string>? EnabledCloudwatchLogsExports
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("enabled_cloudwatch_logs_exports")?.Value;
        set => this.WithProperty("enabled_cloudwatch_logs_exports", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The engine attribute.
    /// </summary>
    public string? Engine
    {
        get => GetProperty<TerraformLiteralProperty<string>>("engine")?.Value;
        set => this.WithProperty("engine", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The engine_lifecycle_support attribute.
    /// </summary>
    public string? EngineLifecycleSupport
    {
        get => GetProperty<TerraformLiteralProperty<string>>("engine_lifecycle_support")?.Value;
        set => this.WithProperty("engine_lifecycle_support", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The engine_mode attribute.
    /// </summary>
    public string? EngineMode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("engine_mode")?.Value;
        set => this.WithProperty("engine_mode", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The engine_version attribute.
    /// </summary>
    public string? EngineVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("engine_version")?.Value;
        set => this.WithProperty("engine_version", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The final_snapshot_identifier attribute.
    /// </summary>
    public string? FinalSnapshotIdentifier
    {
        get => GetProperty<TerraformLiteralProperty<string>>("final_snapshot_identifier")?.Value;
        set => this.WithProperty("final_snapshot_identifier", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The global_cluster_identifier attribute.
    /// </summary>
    public string? GlobalClusterIdentifier
    {
        get => GetProperty<TerraformLiteralProperty<string>>("global_cluster_identifier")?.Value;
        set => this.WithProperty("global_cluster_identifier", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The iam_database_authentication_enabled attribute.
    /// </summary>
    public bool? IamDatabaseAuthenticationEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("iam_database_authentication_enabled")?.Value;
        set => this.WithProperty("iam_database_authentication_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The iam_roles attribute.
    /// </summary>
    public HashSet<string>? IamRoles
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("iam_roles")?.Value;
        set => this.WithProperty("iam_roles", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The iops attribute.
    /// </summary>
    public double? Iops
    {
        get => GetProperty<TerraformLiteralProperty<double>>("iops")?.Value;
        set => this.WithProperty("iops", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public string? KmsKeyId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("kms_key_id")?.Value;
        set => this.WithProperty("kms_key_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The manage_master_user_password attribute.
    /// </summary>
    public bool? ManageMasterUserPassword
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("manage_master_user_password")?.Value;
        set => this.WithProperty("manage_master_user_password", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The master_password attribute.
    /// </summary>
    public string? MasterPassword
    {
        get => GetProperty<TerraformLiteralProperty<string>>("master_password")?.Value;
        set => this.WithProperty("master_password", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The master_password_wo attribute.
    /// </summary>
    public string? MasterPasswordWo
    {
        get => GetProperty<TerraformLiteralProperty<string>>("master_password_wo")?.Value;
        set => this.WithProperty("master_password_wo", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The master_password_wo_version attribute.
    /// </summary>
    public double? MasterPasswordWoVersion
    {
        get => GetProperty<TerraformLiteralProperty<double>>("master_password_wo_version")?.Value;
        set => this.WithProperty("master_password_wo_version", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The master_user_secret_kms_key_id attribute.
    /// </summary>
    public string? MasterUserSecretKmsKeyId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("master_user_secret_kms_key_id")?.Value;
        set => this.WithProperty("master_user_secret_kms_key_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The master_username attribute.
    /// </summary>
    public string? MasterUsername
    {
        get => GetProperty<TerraformLiteralProperty<string>>("master_username")?.Value;
        set => this.WithProperty("master_username", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The monitoring_interval attribute.
    /// </summary>
    public double? MonitoringInterval
    {
        get => GetProperty<TerraformLiteralProperty<double>>("monitoring_interval")?.Value;
        set => this.WithProperty("monitoring_interval", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The monitoring_role_arn attribute.
    /// </summary>
    public string? MonitoringRoleArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("monitoring_role_arn")?.Value;
        set => this.WithProperty("monitoring_role_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The network_type attribute.
    /// </summary>
    public string? NetworkType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("network_type")?.Value;
        set => this.WithProperty("network_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The performance_insights_enabled attribute.
    /// </summary>
    public bool? PerformanceInsightsEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("performance_insights_enabled")?.Value;
        set => this.WithProperty("performance_insights_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The performance_insights_kms_key_id attribute.
    /// </summary>
    public string? PerformanceInsightsKmsKeyId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("performance_insights_kms_key_id")?.Value;
        set => this.WithProperty("performance_insights_kms_key_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The performance_insights_retention_period attribute.
    /// </summary>
    public double? PerformanceInsightsRetentionPeriod
    {
        get => GetProperty<TerraformLiteralProperty<double>>("performance_insights_retention_period")?.Value;
        set => this.WithProperty("performance_insights_retention_period", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The port attribute.
    /// </summary>
    public double? Port
    {
        get => GetProperty<TerraformLiteralProperty<double>>("port")?.Value;
        set => this.WithProperty("port", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The preferred_backup_window attribute.
    /// </summary>
    public string? PreferredBackupWindow
    {
        get => GetProperty<TerraformLiteralProperty<string>>("preferred_backup_window")?.Value;
        set => this.WithProperty("preferred_backup_window", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The preferred_maintenance_window attribute.
    /// </summary>
    public string? PreferredMaintenanceWindow
    {
        get => GetProperty<TerraformLiteralProperty<string>>("preferred_maintenance_window")?.Value;
        set => this.WithProperty("preferred_maintenance_window", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The replication_source_identifier attribute.
    /// </summary>
    public string? ReplicationSourceIdentifier
    {
        get => GetProperty<TerraformLiteralProperty<string>>("replication_source_identifier")?.Value;
        set => this.WithProperty("replication_source_identifier", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The skip_final_snapshot attribute.
    /// </summary>
    public bool? SkipFinalSnapshot
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("skip_final_snapshot")?.Value;
        set => this.WithProperty("skip_final_snapshot", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The snapshot_identifier attribute.
    /// </summary>
    public string? SnapshotIdentifier
    {
        get => GetProperty<TerraformLiteralProperty<string>>("snapshot_identifier")?.Value;
        set => this.WithProperty("snapshot_identifier", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The source_region attribute.
    /// </summary>
    public string? SourceRegion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("source_region")?.Value;
        set => this.WithProperty("source_region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The storage_encrypted attribute.
    /// </summary>
    public bool? StorageEncrypted
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("storage_encrypted")?.Value;
        set => this.WithProperty("storage_encrypted", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The storage_type attribute.
    /// </summary>
    public string? StorageType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("storage_type")?.Value;
        set => this.WithProperty("storage_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, string>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all")?.Value;
        set => this.WithProperty("tags_all", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The vpc_security_group_ids attribute.
    /// </summary>
    public HashSet<string>? VpcSecurityGroupIds
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("vpc_security_group_ids")?.Value;
        set => this.WithProperty("vpc_security_group_ids", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
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
