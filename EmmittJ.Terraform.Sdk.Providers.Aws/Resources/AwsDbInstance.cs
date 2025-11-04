using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_db_instance resource.
/// </summary>
public class AwsDbInstance : TerraformResource
{
    public AwsDbInstance(string name) : base("aws_db_instance", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("address");
        this.DeclareOutput("arn");
        this.DeclareOutput("endpoint");
        this.DeclareOutput("engine_version_actual");
        this.DeclareOutput("hosted_zone_id");
        this.DeclareOutput("latest_restorable_time");
        this.DeclareOutput("listener_endpoint");
        this.DeclareOutput("master_user_secret");
        this.DeclareOutput("replicas");
        this.DeclareOutput("resource_id");
        this.DeclareOutput("status");
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
    /// The auto_minor_version_upgrade attribute.
    /// </summary>
    public bool? AutoMinorVersionUpgrade
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("auto_minor_version_upgrade")?.Value;
        set => this.WithProperty("auto_minor_version_upgrade", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    public string? AvailabilityZone
    {
        get => GetProperty<TerraformLiteralProperty<string>>("availability_zone")?.Value;
        set => this.WithProperty("availability_zone", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The backup_target attribute.
    /// </summary>
    public string? BackupTarget
    {
        get => GetProperty<TerraformLiteralProperty<string>>("backup_target")?.Value;
        set => this.WithProperty("backup_target", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The backup_window attribute.
    /// </summary>
    public string? BackupWindow
    {
        get => GetProperty<TerraformLiteralProperty<string>>("backup_window")?.Value;
        set => this.WithProperty("backup_window", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The ca_cert_identifier attribute.
    /// </summary>
    public string? CaCertIdentifier
    {
        get => GetProperty<TerraformLiteralProperty<string>>("ca_cert_identifier")?.Value;
        set => this.WithProperty("ca_cert_identifier", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The character_set_name attribute.
    /// </summary>
    public string? CharacterSetName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("character_set_name")?.Value;
        set => this.WithProperty("character_set_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The custom_iam_instance_profile attribute.
    /// </summary>
    public string? CustomIamInstanceProfile
    {
        get => GetProperty<TerraformLiteralProperty<string>>("custom_iam_instance_profile")?.Value;
        set => this.WithProperty("custom_iam_instance_profile", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The customer_owned_ip_enabled attribute.
    /// </summary>
    public bool? CustomerOwnedIpEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("customer_owned_ip_enabled")?.Value;
        set => this.WithProperty("customer_owned_ip_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    /// The db_name attribute.
    /// </summary>
    public string? DbName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("db_name")?.Value;
        set => this.WithProperty("db_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The dedicated_log_volume attribute.
    /// </summary>
    public bool? DedicatedLogVolume
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("dedicated_log_volume")?.Value;
        set => this.WithProperty("dedicated_log_volume", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    /// The domain_auth_secret_arn attribute.
    /// </summary>
    public string? DomainAuthSecretArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("domain_auth_secret_arn")?.Value;
        set => this.WithProperty("domain_auth_secret_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The domain_dns_ips attribute.
    /// </summary>
    public List<string>? DomainDnsIps
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("domain_dns_ips")?.Value;
        set => this.WithProperty("domain_dns_ips", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// The domain_fqdn attribute.
    /// </summary>
    public string? DomainFqdn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("domain_fqdn")?.Value;
        set => this.WithProperty("domain_fqdn", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The domain_ou attribute.
    /// </summary>
    public string? DomainOu
    {
        get => GetProperty<TerraformLiteralProperty<string>>("domain_ou")?.Value;
        set => this.WithProperty("domain_ou", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The iam_database_authentication_enabled attribute.
    /// </summary>
    public bool? IamDatabaseAuthenticationEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("iam_database_authentication_enabled")?.Value;
        set => this.WithProperty("iam_database_authentication_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    /// The identifier attribute.
    /// </summary>
    public string? Identifier
    {
        get => GetProperty<TerraformLiteralProperty<string>>("identifier")?.Value;
        set => this.WithProperty("identifier", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The identifier_prefix attribute.
    /// </summary>
    public string? IdentifierPrefix
    {
        get => GetProperty<TerraformLiteralProperty<string>>("identifier_prefix")?.Value;
        set => this.WithProperty("identifier_prefix", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The instance_class attribute.
    /// </summary>
    public string? InstanceClass
    {
        get => GetProperty<TerraformLiteralProperty<string>>("instance_class")?.Value;
        set => this.WithProperty("instance_class", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The license_model attribute.
    /// </summary>
    public string? LicenseModel
    {
        get => GetProperty<TerraformLiteralProperty<string>>("license_model")?.Value;
        set => this.WithProperty("license_model", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The maintenance_window attribute.
    /// </summary>
    public string? MaintenanceWindow
    {
        get => GetProperty<TerraformLiteralProperty<string>>("maintenance_window")?.Value;
        set => this.WithProperty("maintenance_window", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The master_user_secret_kms_key_id attribute.
    /// </summary>
    public string? MasterUserSecretKmsKeyId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("master_user_secret_kms_key_id")?.Value;
        set => this.WithProperty("master_user_secret_kms_key_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The max_allocated_storage attribute.
    /// </summary>
    public double? MaxAllocatedStorage
    {
        get => GetProperty<TerraformLiteralProperty<double>>("max_allocated_storage")?.Value;
        set => this.WithProperty("max_allocated_storage", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
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
    /// The multi_az attribute.
    /// </summary>
    public bool? MultiAz
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("multi_az")?.Value;
        set => this.WithProperty("multi_az", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The nchar_character_set_name attribute.
    /// </summary>
    public string? NcharCharacterSetName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("nchar_character_set_name")?.Value;
        set => this.WithProperty("nchar_character_set_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The option_group_name attribute.
    /// </summary>
    public string? OptionGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("option_group_name")?.Value;
        set => this.WithProperty("option_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The parameter_group_name attribute.
    /// </summary>
    public string? ParameterGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("parameter_group_name")?.Value;
        set => this.WithProperty("parameter_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The password attribute.
    /// </summary>
    public string? Password
    {
        get => GetProperty<TerraformLiteralProperty<string>>("password")?.Value;
        set => this.WithProperty("password", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The password_wo attribute.
    /// </summary>
    public string? PasswordWo
    {
        get => GetProperty<TerraformLiteralProperty<string>>("password_wo")?.Value;
        set => this.WithProperty("password_wo", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The password_wo_version attribute.
    /// </summary>
    public double? PasswordWoVersion
    {
        get => GetProperty<TerraformLiteralProperty<double>>("password_wo_version")?.Value;
        set => this.WithProperty("password_wo_version", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
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
    /// The publicly_accessible attribute.
    /// </summary>
    public bool? PubliclyAccessible
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("publicly_accessible")?.Value;
        set => this.WithProperty("publicly_accessible", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The replica_mode attribute.
    /// </summary>
    public string? ReplicaMode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("replica_mode")?.Value;
        set => this.WithProperty("replica_mode", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The replicate_source_db attribute.
    /// </summary>
    public string? ReplicateSourceDb
    {
        get => GetProperty<TerraformLiteralProperty<string>>("replicate_source_db")?.Value;
        set => this.WithProperty("replicate_source_db", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The storage_encrypted attribute.
    /// </summary>
    public bool? StorageEncrypted
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("storage_encrypted")?.Value;
        set => this.WithProperty("storage_encrypted", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The storage_throughput attribute.
    /// </summary>
    public double? StorageThroughput
    {
        get => GetProperty<TerraformLiteralProperty<double>>("storage_throughput")?.Value;
        set => this.WithProperty("storage_throughput", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
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
    /// The timezone attribute.
    /// </summary>
    public string? Timezone
    {
        get => GetProperty<TerraformLiteralProperty<string>>("timezone")?.Value;
        set => this.WithProperty("timezone", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The upgrade_storage_config attribute.
    /// </summary>
    public bool? UpgradeStorageConfig
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("upgrade_storage_config")?.Value;
        set => this.WithProperty("upgrade_storage_config", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The username attribute.
    /// </summary>
    public string? Username
    {
        get => GetProperty<TerraformLiteralProperty<string>>("username")?.Value;
        set => this.WithProperty("username", value == null ? null : new TerraformLiteralProperty<string>(value));
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
