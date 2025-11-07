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
    public TerraformLiteralProperty<double>? AllocatedStorage
    {
        get => GetProperty<TerraformLiteralProperty<double>>("allocated_storage");
        set => this.WithProperty("allocated_storage", value);
    }

    /// <summary>
    /// The allow_major_version_upgrade attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? AllowMajorVersionUpgrade
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("allow_major_version_upgrade");
        set => this.WithProperty("allow_major_version_upgrade", value);
    }

    /// <summary>
    /// The apply_immediately attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? ApplyImmediately
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("apply_immediately");
        set => this.WithProperty("apply_immediately", value);
    }

    /// <summary>
    /// The auto_minor_version_upgrade attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? AutoMinorVersionUpgrade
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("auto_minor_version_upgrade");
        set => this.WithProperty("auto_minor_version_upgrade", value);
    }

    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? AvailabilityZone
    {
        get => GetProperty<TerraformLiteralProperty<string>>("availability_zone");
        set => this.WithProperty("availability_zone", value);
    }

    /// <summary>
    /// The backup_retention_period attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? BackupRetentionPeriod
    {
        get => GetProperty<TerraformLiteralProperty<double>>("backup_retention_period");
        set => this.WithProperty("backup_retention_period", value);
    }

    /// <summary>
    /// The backup_target attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? BackupTarget
    {
        get => GetProperty<TerraformLiteralProperty<string>>("backup_target");
        set => this.WithProperty("backup_target", value);
    }

    /// <summary>
    /// The backup_window attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? BackupWindow
    {
        get => GetProperty<TerraformLiteralProperty<string>>("backup_window");
        set => this.WithProperty("backup_window", value);
    }

    /// <summary>
    /// The ca_cert_identifier attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? CaCertIdentifier
    {
        get => GetProperty<TerraformLiteralProperty<string>>("ca_cert_identifier");
        set => this.WithProperty("ca_cert_identifier", value);
    }

    /// <summary>
    /// The character_set_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? CharacterSetName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("character_set_name");
        set => this.WithProperty("character_set_name", value);
    }

    /// <summary>
    /// The copy_tags_to_snapshot attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? CopyTagsToSnapshot
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("copy_tags_to_snapshot");
        set => this.WithProperty("copy_tags_to_snapshot", value);
    }

    /// <summary>
    /// The custom_iam_instance_profile attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? CustomIamInstanceProfile
    {
        get => GetProperty<TerraformLiteralProperty<string>>("custom_iam_instance_profile");
        set => this.WithProperty("custom_iam_instance_profile", value);
    }

    /// <summary>
    /// The customer_owned_ip_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? CustomerOwnedIpEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("customer_owned_ip_enabled");
        set => this.WithProperty("customer_owned_ip_enabled", value);
    }

    /// <summary>
    /// The database_insights_mode attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DatabaseInsightsMode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("database_insights_mode");
        set => this.WithProperty("database_insights_mode", value);
    }

    /// <summary>
    /// The db_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DbName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("db_name");
        set => this.WithProperty("db_name", value);
    }

    /// <summary>
    /// The db_subnet_group_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DbSubnetGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("db_subnet_group_name");
        set => this.WithProperty("db_subnet_group_name", value);
    }

    /// <summary>
    /// The dedicated_log_volume attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? DedicatedLogVolume
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("dedicated_log_volume");
        set => this.WithProperty("dedicated_log_volume", value);
    }

    /// <summary>
    /// The delete_automated_backups attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? DeleteAutomatedBackups
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("delete_automated_backups");
        set => this.WithProperty("delete_automated_backups", value);
    }

    /// <summary>
    /// The deletion_protection attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? DeletionProtection
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("deletion_protection");
        set => this.WithProperty("deletion_protection", value);
    }

    /// <summary>
    /// The domain attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Domain
    {
        get => GetProperty<TerraformLiteralProperty<string>>("domain");
        set => this.WithProperty("domain", value);
    }

    /// <summary>
    /// The domain_auth_secret_arn attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DomainAuthSecretArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("domain_auth_secret_arn");
        set => this.WithProperty("domain_auth_secret_arn", value);
    }

    /// <summary>
    /// The domain_dns_ips attribute.
    /// </summary>
    public TerraformLiteralProperty<List<string>>? DomainDnsIps
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("domain_dns_ips");
        set => this.WithProperty("domain_dns_ips", value);
    }

    /// <summary>
    /// The domain_fqdn attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DomainFqdn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("domain_fqdn");
        set => this.WithProperty("domain_fqdn", value);
    }

    /// <summary>
    /// The domain_iam_role_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DomainIamRoleName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("domain_iam_role_name");
        set => this.WithProperty("domain_iam_role_name", value);
    }

    /// <summary>
    /// The domain_ou attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DomainOu
    {
        get => GetProperty<TerraformLiteralProperty<string>>("domain_ou");
        set => this.WithProperty("domain_ou", value);
    }

    /// <summary>
    /// The enabled_cloudwatch_logs_exports attribute.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? EnabledCloudwatchLogsExports
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("enabled_cloudwatch_logs_exports");
        set => this.WithProperty("enabled_cloudwatch_logs_exports", value);
    }

    /// <summary>
    /// The engine attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Engine
    {
        get => GetProperty<TerraformLiteralProperty<string>>("engine");
        set => this.WithProperty("engine", value);
    }

    /// <summary>
    /// The engine_lifecycle_support attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? EngineLifecycleSupport
    {
        get => GetProperty<TerraformLiteralProperty<string>>("engine_lifecycle_support");
        set => this.WithProperty("engine_lifecycle_support", value);
    }

    /// <summary>
    /// The engine_version attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? EngineVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("engine_version");
        set => this.WithProperty("engine_version", value);
    }

    /// <summary>
    /// The final_snapshot_identifier attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? FinalSnapshotIdentifier
    {
        get => GetProperty<TerraformLiteralProperty<string>>("final_snapshot_identifier");
        set => this.WithProperty("final_snapshot_identifier", value);
    }

    /// <summary>
    /// The iam_database_authentication_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? IamDatabaseAuthenticationEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("iam_database_authentication_enabled");
        set => this.WithProperty("iam_database_authentication_enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The identifier attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Identifier
    {
        get => GetProperty<TerraformLiteralProperty<string>>("identifier");
        set => this.WithProperty("identifier", value);
    }

    /// <summary>
    /// The identifier_prefix attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? IdentifierPrefix
    {
        get => GetProperty<TerraformLiteralProperty<string>>("identifier_prefix");
        set => this.WithProperty("identifier_prefix", value);
    }

    /// <summary>
    /// The instance_class attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? InstanceClass
    {
        get => GetProperty<TerraformLiteralProperty<string>>("instance_class");
        set => this.WithProperty("instance_class", value);
    }

    /// <summary>
    /// The iops attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? Iops
    {
        get => GetProperty<TerraformLiteralProperty<double>>("iops");
        set => this.WithProperty("iops", value);
    }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? KmsKeyId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("kms_key_id");
        set => this.WithProperty("kms_key_id", value);
    }

    /// <summary>
    /// The license_model attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? LicenseModel
    {
        get => GetProperty<TerraformLiteralProperty<string>>("license_model");
        set => this.WithProperty("license_model", value);
    }

    /// <summary>
    /// The maintenance_window attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? MaintenanceWindow
    {
        get => GetProperty<TerraformLiteralProperty<string>>("maintenance_window");
        set => this.WithProperty("maintenance_window", value);
    }

    /// <summary>
    /// The manage_master_user_password attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? ManageMasterUserPassword
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("manage_master_user_password");
        set => this.WithProperty("manage_master_user_password", value);
    }

    /// <summary>
    /// The master_user_secret_kms_key_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? MasterUserSecretKmsKeyId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("master_user_secret_kms_key_id");
        set => this.WithProperty("master_user_secret_kms_key_id", value);
    }

    /// <summary>
    /// The max_allocated_storage attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? MaxAllocatedStorage
    {
        get => GetProperty<TerraformLiteralProperty<double>>("max_allocated_storage");
        set => this.WithProperty("max_allocated_storage", value);
    }

    /// <summary>
    /// The monitoring_interval attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? MonitoringInterval
    {
        get => GetProperty<TerraformLiteralProperty<double>>("monitoring_interval");
        set => this.WithProperty("monitoring_interval", value);
    }

    /// <summary>
    /// The monitoring_role_arn attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? MonitoringRoleArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("monitoring_role_arn");
        set => this.WithProperty("monitoring_role_arn", value);
    }

    /// <summary>
    /// The multi_az attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? MultiAz
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("multi_az");
        set => this.WithProperty("multi_az", value);
    }

    /// <summary>
    /// The nchar_character_set_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? NcharCharacterSetName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("nchar_character_set_name");
        set => this.WithProperty("nchar_character_set_name", value);
    }

    /// <summary>
    /// The network_type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? NetworkType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("network_type");
        set => this.WithProperty("network_type", value);
    }

    /// <summary>
    /// The option_group_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? OptionGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("option_group_name");
        set => this.WithProperty("option_group_name", value);
    }

    /// <summary>
    /// The parameter_group_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ParameterGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("parameter_group_name");
        set => this.WithProperty("parameter_group_name", value);
    }

    /// <summary>
    /// The password attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Password
    {
        get => GetProperty<TerraformLiteralProperty<string>>("password");
        set => this.WithProperty("password", value);
    }

    /// <summary>
    /// The password_wo attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? PasswordWo
    {
        get => GetProperty<TerraformLiteralProperty<string>>("password_wo");
        set => this.WithProperty("password_wo", value);
    }

    /// <summary>
    /// The password_wo_version attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? PasswordWoVersion
    {
        get => GetProperty<TerraformLiteralProperty<double>>("password_wo_version");
        set => this.WithProperty("password_wo_version", value);
    }

    /// <summary>
    /// The performance_insights_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? PerformanceInsightsEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("performance_insights_enabled");
        set => this.WithProperty("performance_insights_enabled", value);
    }

    /// <summary>
    /// The performance_insights_kms_key_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? PerformanceInsightsKmsKeyId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("performance_insights_kms_key_id");
        set => this.WithProperty("performance_insights_kms_key_id", value);
    }

    /// <summary>
    /// The performance_insights_retention_period attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? PerformanceInsightsRetentionPeriod
    {
        get => GetProperty<TerraformLiteralProperty<double>>("performance_insights_retention_period");
        set => this.WithProperty("performance_insights_retention_period", value);
    }

    /// <summary>
    /// The port attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? Port
    {
        get => GetProperty<TerraformLiteralProperty<double>>("port");
        set => this.WithProperty("port", value);
    }

    /// <summary>
    /// The publicly_accessible attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? PubliclyAccessible
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("publicly_accessible");
        set => this.WithProperty("publicly_accessible", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The replica_mode attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ReplicaMode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("replica_mode");
        set => this.WithProperty("replica_mode", value);
    }

    /// <summary>
    /// The replicate_source_db attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ReplicateSourceDb
    {
        get => GetProperty<TerraformLiteralProperty<string>>("replicate_source_db");
        set => this.WithProperty("replicate_source_db", value);
    }

    /// <summary>
    /// The skip_final_snapshot attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? SkipFinalSnapshot
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("skip_final_snapshot");
        set => this.WithProperty("skip_final_snapshot", value);
    }

    /// <summary>
    /// The snapshot_identifier attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SnapshotIdentifier
    {
        get => GetProperty<TerraformLiteralProperty<string>>("snapshot_identifier");
        set => this.WithProperty("snapshot_identifier", value);
    }

    /// <summary>
    /// The storage_encrypted attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? StorageEncrypted
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("storage_encrypted");
        set => this.WithProperty("storage_encrypted", value);
    }

    /// <summary>
    /// The storage_throughput attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? StorageThroughput
    {
        get => GetProperty<TerraformLiteralProperty<double>>("storage_throughput");
        set => this.WithProperty("storage_throughput", value);
    }

    /// <summary>
    /// The storage_type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? StorageType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("storage_type");
        set => this.WithProperty("storage_type", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The timezone attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Timezone
    {
        get => GetProperty<TerraformLiteralProperty<string>>("timezone");
        set => this.WithProperty("timezone", value);
    }

    /// <summary>
    /// The upgrade_storage_config attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? UpgradeStorageConfig
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("upgrade_storage_config");
        set => this.WithProperty("upgrade_storage_config", value);
    }

    /// <summary>
    /// The username attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Username
    {
        get => GetProperty<TerraformLiteralProperty<string>>("username");
        set => this.WithProperty("username", value);
    }

    /// <summary>
    /// The vpc_security_group_ids attribute.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? VpcSecurityGroupIds
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("vpc_security_group_ids");
        set => this.WithProperty("vpc_security_group_ids", value);
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
