using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for clone in GoogleSqlDatabaseInstance.
/// Nesting mode: list
/// </summary>
public class GoogleSqlDatabaseInstanceCloneBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "clone";

    /// <summary>
    /// The name of the allocated ip range for the private ip CloudSQL instance. For example: &amp;quot;google-managed-services-default&amp;quot;. If set, the cloned instance ip will be created in the allocated range. The range name must comply with [RFC 1035](https://tools.ietf.org/html/rfc1035). Specifically, the name must be 1-63 characters long and match the regular expression [a-z]([-a-z0-9]*[a-z0-9])?.
    /// </summary>
    public TerraformValue<string>? AllocatedIpRange
    {
        get => new TerraformReference<string>(this, "allocated_ip_range");
        set => SetArgument("allocated_ip_range", value);
    }

    /// <summary>
    /// (SQL Server only, use with point_in_time) clone only the specified databases from the source instance. Clone all databases if empty.
    /// </summary>
    public TerraformList<string>? DatabaseNames
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "database_names").ResolveNodes(ctx));
        set => SetArgument("database_names", value);
    }

    /// <summary>
    /// The timestamp of the point in time that should be restored.
    /// </summary>
    public TerraformValue<string>? PointInTime
    {
        get => new TerraformReference<string>(this, "point_in_time");
        set => SetArgument("point_in_time", value);
    }

    /// <summary>
    /// (Point-in-time recovery for PostgreSQL only) Clone to an instance in the specified zone. If no zone is specified, clone to the same zone as the source instance.
    /// </summary>
    public TerraformValue<string>? PreferredZone
    {
        get => new TerraformReference<string>(this, "preferred_zone");
        set => SetArgument("preferred_zone", value);
    }

    /// <summary>
    /// The timestamp of when the source instance was deleted for a clone from a deleted instance.
    /// </summary>
    public TerraformValue<string>? SourceInstanceDeletionTime
    {
        get => new TerraformReference<string>(this, "source_instance_deletion_time");
        set => SetArgument("source_instance_deletion_time", value);
    }

    /// <summary>
    /// The name of the instance from which the point in time should be restored.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceInstanceName is required")]
    public required TerraformValue<string> SourceInstanceName
    {
        get => new TerraformReference<string>(this, "source_instance_name");
        set => SetArgument("source_instance_name", value);
    }

}


/// <summary>
/// Block type for point_in_time_restore_context in GoogleSqlDatabaseInstance.
/// Nesting mode: list
/// </summary>
public class GoogleSqlDatabaseInstancePointInTimeRestoreContextBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "point_in_time_restore_context";

    /// <summary>
    /// The name of the allocated IP range for the internal IP Cloud SQL instance. For example: &amp;quot;google-managed-services-default&amp;quot;. If you set this, then Cloud SQL creates the IP address for the cloned instance in the allocated range. This range must comply with [RFC 1035](https://tools.ietf.org/html/rfc1035) standards. Specifically, the name must be 1-63 characters long and match the regular expression [a-z]([-a-z0-9]*[a-z0-9])?.
    /// </summary>
    public TerraformValue<string>? AllocatedIpRange
    {
        get => new TerraformReference<string>(this, "allocated_ip_range");
        set => SetArgument("allocated_ip_range", value);
    }

    /// <summary>
    /// The Google Cloud Backup and Disaster Recovery Datasource URI. For example: &amp;quot;projects/my-project/locations/us-central1/datasources/my-datasource&amp;quot;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Datasource is required")]
    public required TerraformValue<string> Datasource
    {
        get => new TerraformReference<string>(this, "datasource");
        set => SetArgument("datasource", value);
    }

    /// <summary>
    /// The date and time to which you want to restore the instance.
    /// </summary>
    public TerraformValue<string>? PointInTime
    {
        get => new TerraformReference<string>(this, "point_in_time");
        set => SetArgument("point_in_time", value);
    }

    /// <summary>
    /// Point-in-time recovery of an instance to the specified zone. If no zone is specified, then clone to the same primary zone as the source instance.
    /// </summary>
    public TerraformValue<string>? PreferredZone
    {
        get => new TerraformReference<string>(this, "preferred_zone");
        set => SetArgument("preferred_zone", value);
    }

    /// <summary>
    /// The name of the target instance to restore to.
    /// </summary>
    public TerraformValue<string>? TargetInstance
    {
        get => new TerraformReference<string>(this, "target_instance");
        set => SetArgument("target_instance", value);
    }

}


/// <summary>
/// Block type for replica_configuration in GoogleSqlDatabaseInstance.
/// Nesting mode: list
/// </summary>
public class GoogleSqlDatabaseInstanceReplicaConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "replica_configuration";

    /// <summary>
    /// PEM representation of the trusted CA&#39;s x509 certificate.
    /// </summary>
    public TerraformValue<string>? CaCertificate
    {
        get => new TerraformReference<string>(this, "ca_certificate");
        set => SetArgument("ca_certificate", value);
    }

    /// <summary>
    /// Specifies if a SQL Server replica is a cascadable replica. A cascadable replica is a SQL Server cross region replica that supports replica(s) under it.
    /// </summary>
    public TerraformValue<bool>? CascadableReplica
    {
        get => new TerraformReference<bool>(this, "cascadable_replica");
        set => SetArgument("cascadable_replica", value);
    }

    /// <summary>
    /// PEM representation of the replica&#39;s x509 certificate.
    /// </summary>
    public TerraformValue<string>? ClientCertificate
    {
        get => new TerraformReference<string>(this, "client_certificate");
        set => SetArgument("client_certificate", value);
    }

    /// <summary>
    /// PEM representation of the replica&#39;s private key. The corresponding public key in encoded in the client_certificate.
    /// </summary>
    public TerraformValue<string>? ClientKey
    {
        get => new TerraformReference<string>(this, "client_key");
        set => SetArgument("client_key", value);
    }

    /// <summary>
    /// The number of seconds between connect retries. MySQL&#39;s default is 60 seconds.
    /// </summary>
    public TerraformValue<double>? ConnectRetryInterval
    {
        get => new TerraformReference<double>(this, "connect_retry_interval");
        set => SetArgument("connect_retry_interval", value);
    }

    /// <summary>
    /// Path to a SQL file in Google Cloud Storage from which replica instances are created. Format is gs://bucket/filename.
    /// </summary>
    public TerraformValue<string>? DumpFilePath
    {
        get => new TerraformReference<string>(this, "dump_file_path");
        set => SetArgument("dump_file_path", value);
    }

    /// <summary>
    /// Specifies if the replica is the failover target. If the field is set to true the replica will be designated as a failover replica. If the master instance fails, the replica instance will be promoted as the new master instance. Not supported for Postgres
    /// </summary>
    public TerraformValue<bool>? FailoverTarget
    {
        get => new TerraformReference<bool>(this, "failover_target");
        set => SetArgument("failover_target", value);
    }

    /// <summary>
    /// Time in ms between replication heartbeats.
    /// </summary>
    public TerraformValue<double>? MasterHeartbeatPeriod
    {
        get => new TerraformReference<double>(this, "master_heartbeat_period");
        set => SetArgument("master_heartbeat_period", value);
    }

    /// <summary>
    /// Password for the replication connection.
    /// </summary>
    public TerraformValue<string>? Password
    {
        get => new TerraformReference<string>(this, "password");
        set => SetArgument("password", value);
    }

    /// <summary>
    /// Permissible ciphers for use in SSL encryption.
    /// </summary>
    public TerraformValue<string>? SslCipher
    {
        get => new TerraformReference<string>(this, "ssl_cipher");
        set => SetArgument("ssl_cipher", value);
    }

    /// <summary>
    /// Username for replication connection.
    /// </summary>
    public TerraformValue<string>? Username
    {
        get => new TerraformReference<string>(this, "username");
        set => SetArgument("username", value);
    }

    /// <summary>
    /// True if the master&#39;s common name value is checked during the SSL handshake.
    /// </summary>
    public TerraformValue<bool>? VerifyServerCertificate
    {
        get => new TerraformReference<bool>(this, "verify_server_certificate");
        set => SetArgument("verify_server_certificate", value);
    }

}


/// <summary>
/// Block type for replication_cluster in GoogleSqlDatabaseInstance.
/// Nesting mode: list
/// </summary>
public class GoogleSqlDatabaseInstanceReplicationClusterBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "replication_cluster";

    /// <summary>
    /// Read-only field that indicates whether the replica is a DR replica.
    /// </summary>
    public TerraformValue<bool> DrReplica
    {
        get => new TerraformReference<bool>(this, "dr_replica");
    }

    /// <summary>
    /// If the instance is a primary instance, then this field identifies the disaster recovery (DR) replica. The standard format of this field is &amp;quot;your-project:your-instance&amp;quot;. You can also set this field to &amp;quot;your-instance&amp;quot;, but cloud SQL backend will convert it to the aforementioned standard format.
    /// </summary>
    public TerraformValue<string>? FailoverDrReplicaName
    {
        get => new TerraformReference<string>(this, "failover_dr_replica_name");
        set => SetArgument("failover_dr_replica_name", value);
    }

    /// <summary>
    /// If set, this field indicates this instance has a private service access (PSA) DNS endpoint that is pointing to the primary instance of the cluster. If this instance is the primary, then the DNS endpoint points to this instance. After a switchover or replica failover operation, this DNS endpoint points to the promoted instance. This is a read-only field, returned to the user as information. This field can exist even if a standalone instance doesn&#39;t have a DR replica yet or the DR replica is deleted.
    /// </summary>
    public TerraformValue<string>? PsaWriteEndpoint
    {
        get => new TerraformReference<string>(this, "psa_write_endpoint");
        set => SetArgument("psa_write_endpoint", value);
    }

}


/// <summary>
/// Block type for restore_backup_context in GoogleSqlDatabaseInstance.
/// Nesting mode: list
/// </summary>
public class GoogleSqlDatabaseInstanceRestoreBackupContextBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "restore_backup_context";

    /// <summary>
    /// The ID of the backup run to restore from.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackupRunId is required")]
    public required TerraformValue<double> BackupRunId
    {
        get => new TerraformReference<double>(this, "backup_run_id");
        set => SetArgument("backup_run_id", value);
    }

    /// <summary>
    /// The ID of the instance that the backup was taken from.
    /// </summary>
    public TerraformValue<string>? InstanceId
    {
        get => new TerraformReference<string>(this, "instance_id");
        set => SetArgument("instance_id", value);
    }

    /// <summary>
    /// The full project ID of the source instance.
    /// </summary>
    public TerraformValue<string>? Project
    {
        get => new TerraformReference<string>(this, "project");
        set => SetArgument("project", value);
    }

}


/// <summary>
/// Block type for settings in GoogleSqlDatabaseInstance.
/// Nesting mode: list
/// </summary>
public class GoogleSqlDatabaseInstanceSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "settings";

    /// <summary>
    /// This specifies when the instance should be active. Can be either ALWAYS, NEVER or ON_DEMAND.
    /// </summary>
    public TerraformValue<string>? ActivationPolicy
    {
        get => new TerraformReference<string>(this, "activation_policy");
        set => SetArgument("activation_policy", value);
    }

    /// <summary>
    /// The availability type of the Cloud SQL instance, high availability
    /// (REGIONAL) or single zone (ZONAL). For all instances, ensure that
    /// settings.backup_configuration.enabled is set to true.
    /// For MySQL instances, ensure that settings.backup_configuration.binary_log_enabled is set to true.
    /// For Postgres instances, ensure that settings.backup_configuration.point_in_time_recovery_enabled
    /// is set to true. Defaults to ZONAL.
    /// For read pool instances, this field is read-only. The availability type is changed by specifying
    /// the number of nodes (node_count).
    /// </summary>
    public TerraformValue<string>? AvailabilityType
    {
        get => new TerraformReference<string>(this, "availability_type");
        set => SetArgument("availability_type", value);
    }

    /// <summary>
    /// The name of server instance collation.
    /// </summary>
    public TerraformValue<string>? Collation
    {
        get => new TerraformReference<string>(this, "collation");
        set => SetArgument("collation", value);
    }

    /// <summary>
    /// Enables the enforcement of Cloud SQL Auth Proxy or Cloud SQL connectors for all the connections. If enabled, all the direct connections are rejected.
    /// </summary>
    public TerraformValue<string> ConnectorEnforcement
    {
        get => new TerraformReference<string>(this, "connector_enforcement");
        set => SetArgument("connector_enforcement", value);
    }

    /// <summary>
    /// Configuration to protect against accidental instance deletion.
    /// </summary>
    public TerraformValue<bool>? DeletionProtectionEnabled
    {
        get => new TerraformReference<bool>(this, "deletion_protection_enabled");
        set => SetArgument("deletion_protection_enabled", value);
    }

    /// <summary>
    /// Enables auto-resizing of the storage size. Defaults to true.
    /// </summary>
    public TerraformValue<bool>? DiskAutoresize
    {
        get => new TerraformReference<bool>(this, "disk_autoresize");
        set => SetArgument("disk_autoresize", value);
    }

    /// <summary>
    /// The maximum size, in GB, to which storage capacity can be automatically increased. The default value is 0, which specifies that there is no limit.
    /// </summary>
    public TerraformValue<double>? DiskAutoresizeLimit
    {
        get => new TerraformReference<double>(this, "disk_autoresize_limit");
        set => SetArgument("disk_autoresize_limit", value);
    }

    /// <summary>
    /// The size of data disk, in GB. Size of a running instance cannot be reduced but can be increased. The minimum value is 10GB for PD_SSD, PD_HDD and 20GB for HYPERDISK_BALANCED.
    /// </summary>
    public TerraformValue<double> DiskSize
    {
        get => new TerraformReference<double>(this, "disk_size");
        set => SetArgument("disk_size", value);
    }

    /// <summary>
    /// The type of supported data disk is tier dependent and can be PD_SSD or PD_HDD or HYPERDISK_BALANCED.
    /// </summary>
    public TerraformValue<string> DiskType
    {
        get => new TerraformReference<string>(this, "disk_type");
        set => SetArgument("disk_type", value);
    }

    /// <summary>
    /// The edition of the instance, can be ENTERPRISE or ENTERPRISE_PLUS.
    /// </summary>
    public TerraformValue<string> Edition
    {
        get => new TerraformReference<string>(this, "edition");
        set => SetArgument("edition", value);
    }

    /// <summary>
    /// The availability type of the Cloud SQL instance, high availability
    /// (REGIONAL) or single zone (ZONAL). This field always contains the value that is reported by the
    /// API (for read pools, effective_availability_type may differ from availability_type).
    /// </summary>
    public TerraformValue<string> EffectiveAvailabilityType
    {
        get => new TerraformReference<string>(this, "effective_availability_type");
    }

    /// <summary>
    /// Enables Dataplex Integration.
    /// </summary>
    public TerraformValue<bool>? EnableDataplexIntegration
    {
        get => new TerraformReference<bool>(this, "enable_dataplex_integration");
        set => SetArgument("enable_dataplex_integration", value);
    }

    /// <summary>
    /// Enables Vertex AI Integration.
    /// </summary>
    public TerraformValue<bool>? EnableGoogleMlIntegration
    {
        get => new TerraformReference<bool>(this, "enable_google_ml_integration");
        set => SetArgument("enable_google_ml_integration", value);
    }

    /// <summary>
    /// Pricing plan for this instance, can only be PER_USE.
    /// </summary>
    public TerraformValue<string>? PricingPlan
    {
        get => new TerraformReference<string>(this, "pricing_plan");
        set => SetArgument("pricing_plan", value);
    }

    /// <summary>
    /// When this parameter is set to true, Cloud SQL retains backups of the instance even after the instance is deleted. The ON_DEMAND backup will be retained until customer deletes the backup or the project. The AUTOMATED backup will be retained based on the backups retention setting.
    /// </summary>
    public TerraformValue<bool>? RetainBackupsOnDelete
    {
        get => new TerraformReference<bool>(this, "retain_backups_on_delete");
        set => SetArgument("retain_backups_on_delete", value);
    }

    /// <summary>
    /// The machine type to use. See tiers for more details and supported versions. Postgres supports only shared-core machine types, and custom machine types such as db-custom-2-13312. See the Custom Machine Type Documentation to learn about specifying custom machine types.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Tier is required")]
    public required TerraformValue<string> Tier
    {
        get => new TerraformReference<string>(this, "tier");
        set => SetArgument("tier", value);
    }

    /// <summary>
    /// The time_zone to be used by the database engine (supported only for SQL Server), in SQL Server timezone format.
    /// </summary>
    public TerraformValue<string>? TimeZone
    {
        get => new TerraformReference<string>(this, "time_zone");
        set => SetArgument("time_zone", value);
    }

    /// <summary>
    /// A set of key/value user label pairs to assign to the instance.
    /// </summary>
    public TerraformMap<string> UserLabels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "user_labels").ResolveNodes(ctx));
        set => SetArgument("user_labels", value);
    }

    /// <summary>
    /// Used to make sure changes to the settings block are atomic.
    /// </summary>
    public TerraformValue<double> Version
    {
        get => new TerraformReference<double>(this, "version");
    }

    /// <summary>
    /// ActiveDirectoryConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ActiveDirectoryConfig block(s) allowed")]
    public TerraformList<GoogleSqlDatabaseInstanceSettingsBlockActiveDirectoryConfigBlock>? ActiveDirectoryConfig
    {
        get => GetArgument<TerraformList<GoogleSqlDatabaseInstanceSettingsBlockActiveDirectoryConfigBlock>>("active_directory_config");
        set => SetArgument("active_directory_config", value);
    }

    /// <summary>
    /// AdvancedMachineFeatures block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AdvancedMachineFeatures block(s) allowed")]
    public TerraformList<GoogleSqlDatabaseInstanceSettingsBlockAdvancedMachineFeaturesBlock>? AdvancedMachineFeatures
    {
        get => GetArgument<TerraformList<GoogleSqlDatabaseInstanceSettingsBlockAdvancedMachineFeaturesBlock>>("advanced_machine_features");
        set => SetArgument("advanced_machine_features", value);
    }

    /// <summary>
    /// BackupConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BackupConfiguration block(s) allowed")]
    public TerraformList<GoogleSqlDatabaseInstanceSettingsBlockBackupConfigurationBlock>? BackupConfiguration
    {
        get => GetArgument<TerraformList<GoogleSqlDatabaseInstanceSettingsBlockBackupConfigurationBlock>>("backup_configuration");
        set => SetArgument("backup_configuration", value);
    }

    /// <summary>
    /// ConnectionPoolConfig block (nesting mode: set).
    /// </summary>
    public TerraformSet<GoogleSqlDatabaseInstanceSettingsBlockConnectionPoolConfigBlock>? ConnectionPoolConfig
    {
        get => GetArgument<TerraformSet<GoogleSqlDatabaseInstanceSettingsBlockConnectionPoolConfigBlock>>("connection_pool_config");
        set => SetArgument("connection_pool_config", value);
    }

    /// <summary>
    /// DataCacheConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DataCacheConfig block(s) allowed")]
    public TerraformList<GoogleSqlDatabaseInstanceSettingsBlockDataCacheConfigBlock>? DataCacheConfig
    {
        get => GetArgument<TerraformList<GoogleSqlDatabaseInstanceSettingsBlockDataCacheConfigBlock>>("data_cache_config");
        set => SetArgument("data_cache_config", value);
    }

    /// <summary>
    /// DatabaseFlags block (nesting mode: set).
    /// </summary>
    public TerraformSet<GoogleSqlDatabaseInstanceSettingsBlockDatabaseFlagsBlock>? DatabaseFlags
    {
        get => GetArgument<TerraformSet<GoogleSqlDatabaseInstanceSettingsBlockDatabaseFlagsBlock>>("database_flags");
        set => SetArgument("database_flags", value);
    }

    /// <summary>
    /// DenyMaintenancePeriod block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DenyMaintenancePeriod block(s) allowed")]
    public TerraformList<GoogleSqlDatabaseInstanceSettingsBlockDenyMaintenancePeriodBlock>? DenyMaintenancePeriod
    {
        get => GetArgument<TerraformList<GoogleSqlDatabaseInstanceSettingsBlockDenyMaintenancePeriodBlock>>("deny_maintenance_period");
        set => SetArgument("deny_maintenance_period", value);
    }

    /// <summary>
    /// FinalBackupConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FinalBackupConfig block(s) allowed")]
    public TerraformList<GoogleSqlDatabaseInstanceSettingsBlockFinalBackupConfigBlock>? FinalBackupConfig
    {
        get => GetArgument<TerraformList<GoogleSqlDatabaseInstanceSettingsBlockFinalBackupConfigBlock>>("final_backup_config");
        set => SetArgument("final_backup_config", value);
    }

    /// <summary>
    /// InsightsConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InsightsConfig block(s) allowed")]
    public TerraformList<GoogleSqlDatabaseInstanceSettingsBlockInsightsConfigBlock>? InsightsConfig
    {
        get => GetArgument<TerraformList<GoogleSqlDatabaseInstanceSettingsBlockInsightsConfigBlock>>("insights_config");
        set => SetArgument("insights_config", value);
    }

    /// <summary>
    /// IpConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IpConfiguration block(s) allowed")]
    public TerraformList<GoogleSqlDatabaseInstanceSettingsBlockIpConfigurationBlock>? IpConfiguration
    {
        get => GetArgument<TerraformList<GoogleSqlDatabaseInstanceSettingsBlockIpConfigurationBlock>>("ip_configuration");
        set => SetArgument("ip_configuration", value);
    }

    /// <summary>
    /// LocationPreference block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LocationPreference block(s) allowed")]
    public TerraformList<GoogleSqlDatabaseInstanceSettingsBlockLocationPreferenceBlock>? LocationPreference
    {
        get => GetArgument<TerraformList<GoogleSqlDatabaseInstanceSettingsBlockLocationPreferenceBlock>>("location_preference");
        set => SetArgument("location_preference", value);
    }

    /// <summary>
    /// MaintenanceWindow block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MaintenanceWindow block(s) allowed")]
    public TerraformList<GoogleSqlDatabaseInstanceSettingsBlockMaintenanceWindowBlock>? MaintenanceWindow
    {
        get => GetArgument<TerraformList<GoogleSqlDatabaseInstanceSettingsBlockMaintenanceWindowBlock>>("maintenance_window");
        set => SetArgument("maintenance_window", value);
    }

    /// <summary>
    /// PasswordValidationPolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PasswordValidationPolicy block(s) allowed")]
    public TerraformList<GoogleSqlDatabaseInstanceSettingsBlockPasswordValidationPolicyBlock>? PasswordValidationPolicy
    {
        get => GetArgument<TerraformList<GoogleSqlDatabaseInstanceSettingsBlockPasswordValidationPolicyBlock>>("password_validation_policy");
        set => SetArgument("password_validation_policy", value);
    }

    /// <summary>
    /// ReadPoolAutoScaleConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ReadPoolAutoScaleConfig block(s) allowed")]
    public TerraformList<GoogleSqlDatabaseInstanceSettingsBlockReadPoolAutoScaleConfigBlock>? ReadPoolAutoScaleConfig
    {
        get => GetArgument<TerraformList<GoogleSqlDatabaseInstanceSettingsBlockReadPoolAutoScaleConfigBlock>>("read_pool_auto_scale_config");
        set => SetArgument("read_pool_auto_scale_config", value);
    }

    /// <summary>
    /// SqlServerAuditConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SqlServerAuditConfig block(s) allowed")]
    public TerraformList<GoogleSqlDatabaseInstanceSettingsBlockSqlServerAuditConfigBlock>? SqlServerAuditConfig
    {
        get => GetArgument<TerraformList<GoogleSqlDatabaseInstanceSettingsBlockSqlServerAuditConfigBlock>>("sql_server_audit_config");
        set => SetArgument("sql_server_audit_config", value);
    }

}

/// <summary>
/// Block type for active_directory_config in GoogleSqlDatabaseInstanceSettingsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleSqlDatabaseInstanceSettingsBlockActiveDirectoryConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "active_directory_config";

    /// <summary>
    /// Domain name of the Active Directory for SQL Server (e.g., mydomain.com).
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Domain is required")]
    public required TerraformValue<string> Domain
    {
        get => new TerraformReference<string>(this, "domain");
        set => SetArgument("domain", value);
    }

}

/// <summary>
/// Block type for advanced_machine_features in GoogleSqlDatabaseInstanceSettingsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleSqlDatabaseInstanceSettingsBlockAdvancedMachineFeaturesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "advanced_machine_features";

    /// <summary>
    /// The number of threads per physical core. Can be 1 or 2.
    /// </summary>
    public TerraformValue<double>? ThreadsPerCore
    {
        get => new TerraformReference<double>(this, "threads_per_core");
        set => SetArgument("threads_per_core", value);
    }

}

/// <summary>
/// Block type for backup_configuration in GoogleSqlDatabaseInstanceSettingsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleSqlDatabaseInstanceSettingsBlockBackupConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "backup_configuration";

    /// <summary>
    /// True if binary logging is enabled. If settings.backup_configuration.enabled is false, this must be as well. Can only be used with MySQL.
    /// </summary>
    public TerraformValue<bool>? BinaryLogEnabled
    {
        get => new TerraformReference<bool>(this, "binary_log_enabled");
        set => SetArgument("binary_log_enabled", value);
    }

    /// <summary>
    /// True if backup configuration is enabled.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// Location of the backup configuration.
    /// </summary>
    public TerraformValue<string>? Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// True if Point-in-time recovery is enabled.
    /// </summary>
    public TerraformValue<bool>? PointInTimeRecoveryEnabled
    {
        get => new TerraformReference<bool>(this, "point_in_time_recovery_enabled");
        set => SetArgument("point_in_time_recovery_enabled", value);
    }

    /// <summary>
    /// HH:MM format time indicating when backup configuration starts.
    /// </summary>
    public TerraformValue<string> StartTime
    {
        get => new TerraformReference<string>(this, "start_time");
        set => SetArgument("start_time", value);
    }

    /// <summary>
    /// The number of days of transaction logs we retain for point in time restore, from 1-7. (For PostgreSQL Enterprise Plus instances, from 1 to 35.)
    /// </summary>
    public TerraformValue<double> TransactionLogRetentionDays
    {
        get => new TerraformReference<double>(this, "transaction_log_retention_days");
        set => SetArgument("transaction_log_retention_days", value);
    }

    /// <summary>
    /// BackupRetentionSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BackupRetentionSettings block(s) allowed")]
    public TerraformList<GoogleSqlDatabaseInstanceSettingsBlockBackupConfigurationBlockBackupRetentionSettingsBlock>? BackupRetentionSettings
    {
        get => GetArgument<TerraformList<GoogleSqlDatabaseInstanceSettingsBlockBackupConfigurationBlockBackupRetentionSettingsBlock>>("backup_retention_settings");
        set => SetArgument("backup_retention_settings", value);
    }

}

/// <summary>
/// Block type for backup_retention_settings in GoogleSqlDatabaseInstanceSettingsBlockBackupConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class GoogleSqlDatabaseInstanceSettingsBlockBackupConfigurationBlockBackupRetentionSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "backup_retention_settings";

    /// <summary>
    /// Number of backups to retain.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RetainedBackups is required")]
    public required TerraformValue<double> RetainedBackups
    {
        get => new TerraformReference<double>(this, "retained_backups");
        set => SetArgument("retained_backups", value);
    }

    /// <summary>
    /// The unit that &#39;retainedBackups&#39; represents. Defaults to COUNT
    /// </summary>
    public TerraformValue<string>? RetentionUnit
    {
        get => new TerraformReference<string>(this, "retention_unit");
        set => SetArgument("retention_unit", value);
    }

}

/// <summary>
/// Block type for connection_pool_config in GoogleSqlDatabaseInstanceSettingsBlock.
/// Nesting mode: set
/// </summary>
public class GoogleSqlDatabaseInstanceSettingsBlockConnectionPoolConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "connection_pool_config";

    /// <summary>
    /// Whether Managed Connection Pool is enabled for this instance.
    /// </summary>
    public TerraformValue<bool>? ConnectionPoolingEnabled
    {
        get => new TerraformReference<bool>(this, "connection_pooling_enabled");
        set => SetArgument("connection_pooling_enabled", value);
    }

    /// <summary>
    /// Flags block (nesting mode: set).
    /// </summary>
    public TerraformSet<GoogleSqlDatabaseInstanceSettingsBlockConnectionPoolConfigBlockFlagsBlock>? Flags
    {
        get => GetArgument<TerraformSet<GoogleSqlDatabaseInstanceSettingsBlockConnectionPoolConfigBlockFlagsBlock>>("flags");
        set => SetArgument("flags", value);
    }

}

/// <summary>
/// Block type for flags in GoogleSqlDatabaseInstanceSettingsBlockConnectionPoolConfigBlock.
/// Nesting mode: set
/// </summary>
public class GoogleSqlDatabaseInstanceSettingsBlockConnectionPoolConfigBlockFlagsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "flags";

    /// <summary>
    /// Name of the flag.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Value of the flag.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => new TerraformReference<string>(this, "value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for data_cache_config in GoogleSqlDatabaseInstanceSettingsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleSqlDatabaseInstanceSettingsBlockDataCacheConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "data_cache_config";

    /// <summary>
    /// Whether data cache is enabled for the instance.
    /// </summary>
    public TerraformValue<bool>? DataCacheEnabled
    {
        get => new TerraformReference<bool>(this, "data_cache_enabled");
        set => SetArgument("data_cache_enabled", value);
    }

}

/// <summary>
/// Block type for database_flags in GoogleSqlDatabaseInstanceSettingsBlock.
/// Nesting mode: set
/// </summary>
public class GoogleSqlDatabaseInstanceSettingsBlockDatabaseFlagsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "database_flags";

    /// <summary>
    /// Name of the flag.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Value of the flag.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => new TerraformReference<string>(this, "value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for deny_maintenance_period in GoogleSqlDatabaseInstanceSettingsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleSqlDatabaseInstanceSettingsBlockDenyMaintenancePeriodBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "deny_maintenance_period";

    /// <summary>
    /// End date before which maintenance will not take place. The date is in format yyyy-mm-dd i.e., 2020-11-01, or mm-dd, i.e., 11-01
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EndDate is required")]
    public required TerraformValue<string> EndDate
    {
        get => new TerraformReference<string>(this, "end_date");
        set => SetArgument("end_date", value);
    }

    /// <summary>
    /// Start date after which maintenance will not take place. The date is in format yyyy-mm-dd i.e., 2020-11-01, or mm-dd, i.e., 11-01
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StartDate is required")]
    public required TerraformValue<string> StartDate
    {
        get => new TerraformReference<string>(this, "start_date");
        set => SetArgument("start_date", value);
    }

    /// <summary>
    /// Time in UTC when the &amp;quot;deny maintenance period&amp;quot; starts on start_date and ends on end_date. The time is in format: HH:mm:SS, i.e., 00:00:00
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Time is required")]
    public required TerraformValue<string> Time
    {
        get => new TerraformReference<string>(this, "time");
        set => SetArgument("time", value);
    }

}

/// <summary>
/// Block type for final_backup_config in GoogleSqlDatabaseInstanceSettingsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleSqlDatabaseInstanceSettingsBlockFinalBackupConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "final_backup_config";

    /// <summary>
    /// When this parameter is set to true, the final backup is enabled for the instance
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The number of days to retain the final backup after the instance deletion. The valid range is between 1 and 365. For instances managed by BackupDR, the valid range is between 1 day and 99 years. The final backup will be purged at (time_of_instance_deletion + retention_days).
    /// </summary>
    public TerraformValue<double>? RetentionDays
    {
        get => new TerraformReference<double>(this, "retention_days");
        set => SetArgument("retention_days", value);
    }

}

/// <summary>
/// Block type for insights_config in GoogleSqlDatabaseInstanceSettingsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleSqlDatabaseInstanceSettingsBlockInsightsConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "insights_config";

    /// <summary>
    /// True if Query Insights feature is enabled.
    /// </summary>
    public TerraformValue<bool>? QueryInsightsEnabled
    {
        get => new TerraformReference<bool>(this, "query_insights_enabled");
        set => SetArgument("query_insights_enabled", value);
    }

    /// <summary>
    /// Number of query execution plans captured by Insights per minute for all queries combined. Between 0 and 20. Default to 5. For Enterprise Plus instances, from 0 to 200.
    /// </summary>
    public TerraformValue<double> QueryPlansPerMinute
    {
        get => new TerraformReference<double>(this, "query_plans_per_minute");
        set => SetArgument("query_plans_per_minute", value);
    }

    /// <summary>
    /// Maximum query length stored in bytes. Between 256 and 4500. Default to 1024. For Enterprise Plus instances, from 1 to 1048576.
    /// </summary>
    public TerraformValue<double>? QueryStringLength
    {
        get => new TerraformReference<double>(this, "query_string_length");
        set => SetArgument("query_string_length", value);
    }

    /// <summary>
    /// True if Query Insights will record application tags from query when enabled.
    /// </summary>
    public TerraformValue<bool>? RecordApplicationTags
    {
        get => new TerraformReference<bool>(this, "record_application_tags");
        set => SetArgument("record_application_tags", value);
    }

    /// <summary>
    /// True if Query Insights will record client address when enabled.
    /// </summary>
    public TerraformValue<bool>? RecordClientAddress
    {
        get => new TerraformReference<bool>(this, "record_client_address");
        set => SetArgument("record_client_address", value);
    }

}

/// <summary>
/// Block type for ip_configuration in GoogleSqlDatabaseInstanceSettingsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleSqlDatabaseInstanceSettingsBlockIpConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ip_configuration";

    /// <summary>
    /// The name of the allocated ip range for the private ip CloudSQL instance. For example: &amp;quot;google-managed-services-default&amp;quot;. If set, the instance ip will be created in the allocated range. The range name must comply with RFC 1035. Specifically, the name must be 1-63 characters long and match the regular expression [a-z]([-a-z0-9]*[a-z0-9])?.
    /// </summary>
    public TerraformValue<string>? AllocatedIpRange
    {
        get => new TerraformReference<string>(this, "allocated_ip_range");
        set => SetArgument("allocated_ip_range", value);
    }

    /// <summary>
    /// The custom subject alternative names for an instance with &amp;quot;CUSTOMER_MANAGED_CAS_CA&amp;quot; as the &amp;quot;server_ca_mode&amp;quot;.
    /// </summary>
    public TerraformSet<string>? CustomSubjectAlternativeNames
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "custom_subject_alternative_names").ResolveNodes(ctx));
        set => SetArgument("custom_subject_alternative_names", value);
    }

    /// <summary>
    /// Whether Google Cloud services such as BigQuery are allowed to access data in this Cloud SQL instance over a private IP connection. SQLSERVER database type is not supported.
    /// </summary>
    public TerraformValue<bool>? EnablePrivatePathForGoogleCloudServices
    {
        get => new TerraformReference<bool>(this, "enable_private_path_for_google_cloud_services");
        set => SetArgument("enable_private_path_for_google_cloud_services", value);
    }

    /// <summary>
    /// Whether this Cloud SQL instance should be assigned a public IPV4 address. At least ipv4_enabled must be enabled or a private_network must be configured.
    /// </summary>
    public TerraformValue<bool>? Ipv4Enabled
    {
        get => new TerraformReference<bool>(this, "ipv4_enabled");
        set => SetArgument("ipv4_enabled", value);
    }

    /// <summary>
    /// The VPC network from which the Cloud SQL instance is accessible for private IP. For example, projects/myProject/global/networks/default. Specifying a network enables private IP. At least ipv4_enabled must be enabled or a private_network must be configured. This setting can be updated, but it cannot be removed after it is set.
    /// </summary>
    public TerraformValue<string>? PrivateNetwork
    {
        get => new TerraformReference<string>(this, "private_network");
        set => SetArgument("private_network", value);
    }

    /// <summary>
    /// Specify how the server certificate&#39;s Certificate Authority is hosted.
    /// </summary>
    public TerraformValue<string> ServerCaMode
    {
        get => new TerraformReference<string>(this, "server_ca_mode");
        set => SetArgument("server_ca_mode", value);
    }

    /// <summary>
    /// The resource name of the server CA pool for an instance with &amp;quot;CUSTOMER_MANAGED_CAS_CA&amp;quot; as the &amp;quot;server_ca_mode&amp;quot;.
    /// </summary>
    public TerraformValue<string>? ServerCaPool
    {
        get => new TerraformReference<string>(this, "server_ca_pool");
        set => SetArgument("server_ca_pool", value);
    }

    /// <summary>
    /// Specify how SSL connection should be enforced in DB connections.
    /// </summary>
    public TerraformValue<string> SslMode
    {
        get => new TerraformReference<string>(this, "ssl_mode");
        set => SetArgument("ssl_mode", value);
    }

    /// <summary>
    /// AuthorizedNetworks block (nesting mode: set).
    /// </summary>
    public TerraformSet<GoogleSqlDatabaseInstanceSettingsBlockIpConfigurationBlockAuthorizedNetworksBlock>? AuthorizedNetworks
    {
        get => GetArgument<TerraformSet<GoogleSqlDatabaseInstanceSettingsBlockIpConfigurationBlockAuthorizedNetworksBlock>>("authorized_networks");
        set => SetArgument("authorized_networks", value);
    }

    /// <summary>
    /// PscConfig block (nesting mode: set).
    /// </summary>
    public TerraformSet<GoogleSqlDatabaseInstanceSettingsBlockIpConfigurationBlockPscConfigBlock>? PscConfig
    {
        get => GetArgument<TerraformSet<GoogleSqlDatabaseInstanceSettingsBlockIpConfigurationBlockPscConfigBlock>>("psc_config");
        set => SetArgument("psc_config", value);
    }

}

/// <summary>
/// Block type for authorized_networks in GoogleSqlDatabaseInstanceSettingsBlockIpConfigurationBlock.
/// Nesting mode: set
/// </summary>
public class GoogleSqlDatabaseInstanceSettingsBlockIpConfigurationBlockAuthorizedNetworksBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "authorized_networks";

    /// <summary>
    /// The expiration_time attribute.
    /// </summary>
    public TerraformValue<string>? ExpirationTime
    {
        get => new TerraformReference<string>(this, "expiration_time");
        set => SetArgument("expiration_time", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => new TerraformReference<string>(this, "value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for psc_config in GoogleSqlDatabaseInstanceSettingsBlockIpConfigurationBlock.
/// Nesting mode: set
/// </summary>
public class GoogleSqlDatabaseInstanceSettingsBlockIpConfigurationBlockPscConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "psc_config";

    /// <summary>
    /// List of consumer projects that are allow-listed for PSC connections to this instance. This instance can be connected to with PSC from any network in these projects. Each consumer project in this list may be represented by a project number (numeric) or by a project id (alphanumeric).
    /// </summary>
    public TerraformSet<string>? AllowedConsumerProjects
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "allowed_consumer_projects").ResolveNodes(ctx));
        set => SetArgument("allowed_consumer_projects", value);
    }

    /// <summary>
    /// Name of network attachment resource used to authorize a producer service to connect a PSC interface to the consumer&#39;s VPC. For example: &amp;quot;projects/myProject/regions/myRegion/networkAttachments/myNetworkAttachment&amp;quot;. This is required to enable outbound connection on a PSC instance.
    /// </summary>
    public TerraformValue<string>? NetworkAttachmentUri
    {
        get => new TerraformReference<string>(this, "network_attachment_uri");
        set => SetArgument("network_attachment_uri", value);
    }

    /// <summary>
    /// Whether PSC connectivity is enabled for this instance.
    /// </summary>
    public TerraformValue<bool>? PscEnabled
    {
        get => new TerraformReference<bool>(this, "psc_enabled");
        set => SetArgument("psc_enabled", value);
    }

    /// <summary>
    /// PscAutoConnections block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleSqlDatabaseInstanceSettingsBlockIpConfigurationBlockPscConfigBlockPscAutoConnectionsBlock>? PscAutoConnections
    {
        get => GetArgument<TerraformList<GoogleSqlDatabaseInstanceSettingsBlockIpConfigurationBlockPscConfigBlockPscAutoConnectionsBlock>>("psc_auto_connections");
        set => SetArgument("psc_auto_connections", value);
    }

}

/// <summary>
/// Block type for psc_auto_connections in GoogleSqlDatabaseInstanceSettingsBlockIpConfigurationBlockPscConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleSqlDatabaseInstanceSettingsBlockIpConfigurationBlockPscConfigBlockPscAutoConnectionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "psc_auto_connections";

    /// <summary>
    /// The consumer network of this consumer endpoint. This must be a resource path that includes both the host project and the network name. The consumer host project of this network might be different from the consumer service project.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConsumerNetwork is required")]
    public required TerraformValue<string> ConsumerNetwork
    {
        get => new TerraformReference<string>(this, "consumer_network");
        set => SetArgument("consumer_network", value);
    }

    /// <summary>
    /// The connection policy status of the consumer network.
    /// </summary>
    public TerraformValue<string> ConsumerNetworkStatus
    {
        get => new TerraformReference<string>(this, "consumer_network_status");
    }

    /// <summary>
    /// The project ID of consumer service project of this consumer endpoint.
    /// </summary>
    public TerraformValue<string>? ConsumerServiceProjectId
    {
        get => new TerraformReference<string>(this, "consumer_service_project_id");
        set => SetArgument("consumer_service_project_id", value);
    }

    /// <summary>
    /// The IP address of the consumer endpoint.
    /// </summary>
    public TerraformValue<string> IpAddress
    {
        get => new TerraformReference<string>(this, "ip_address");
    }

    /// <summary>
    /// The connection status of the consumer endpoint.
    /// </summary>
    public TerraformValue<string> Status
    {
        get => new TerraformReference<string>(this, "status");
    }

}

/// <summary>
/// Block type for location_preference in GoogleSqlDatabaseInstanceSettingsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleSqlDatabaseInstanceSettingsBlockLocationPreferenceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "location_preference";

    /// <summary>
    /// A Google App Engine application whose zone to remain in. Must be in the same region as this instance.
    /// </summary>
    public TerraformValue<string>? FollowGaeApplication
    {
        get => new TerraformReference<string>(this, "follow_gae_application");
        set => SetArgument("follow_gae_application", value);
    }

    /// <summary>
    /// The preferred Compute Engine zone for the secondary/failover
    /// </summary>
    public TerraformValue<string>? SecondaryZone
    {
        get => new TerraformReference<string>(this, "secondary_zone");
        set => SetArgument("secondary_zone", value);
    }

    /// <summary>
    /// The preferred compute engine zone.
    /// </summary>
    public TerraformValue<string>? Zone
    {
        get => new TerraformReference<string>(this, "zone");
        set => SetArgument("zone", value);
    }

}

/// <summary>
/// Block type for maintenance_window in GoogleSqlDatabaseInstanceSettingsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleSqlDatabaseInstanceSettingsBlockMaintenanceWindowBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "maintenance_window";

    /// <summary>
    /// Day of week (1-7), starting on Monday
    /// </summary>
    public TerraformValue<double>? Day
    {
        get => new TerraformReference<double>(this, "day");
        set => SetArgument("day", value);
    }

    /// <summary>
    /// Hour of day (0-23), ignored if day not set
    /// </summary>
    public TerraformValue<double>? Hour
    {
        get => new TerraformReference<double>(this, "hour");
        set => SetArgument("hour", value);
    }

    /// <summary>
    /// Receive updates after one week (canary) or after two weeks (stable) or after five weeks (week5) of notification.
    /// </summary>
    public TerraformValue<string>? UpdateTrack
    {
        get => new TerraformReference<string>(this, "update_track");
        set => SetArgument("update_track", value);
    }

}

/// <summary>
/// Block type for password_validation_policy in GoogleSqlDatabaseInstanceSettingsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleSqlDatabaseInstanceSettingsBlockPasswordValidationPolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "password_validation_policy";

    /// <summary>
    /// Password complexity.
    /// </summary>
    public TerraformValue<string>? Complexity
    {
        get => new TerraformReference<string>(this, "complexity");
        set => SetArgument("complexity", value);
    }

    /// <summary>
    /// Disallow username as a part of the password.
    /// </summary>
    public TerraformValue<bool>? DisallowUsernameSubstring
    {
        get => new TerraformReference<bool>(this, "disallow_username_substring");
        set => SetArgument("disallow_username_substring", value);
    }

    /// <summary>
    /// Whether the password policy is enabled or not.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EnablePasswordPolicy is required")]
    public required TerraformValue<bool> EnablePasswordPolicy
    {
        get => new TerraformReference<bool>(this, "enable_password_policy");
        set => SetArgument("enable_password_policy", value);
    }

    /// <summary>
    /// Minimum number of characters allowed.
    /// </summary>
    public TerraformValue<double>? MinLength
    {
        get => new TerraformReference<double>(this, "min_length");
        set => SetArgument("min_length", value);
    }

    /// <summary>
    /// Minimum interval after which the password can be changed. This flag is only supported for PostgresSQL.
    /// </summary>
    public TerraformValue<string>? PasswordChangeInterval
    {
        get => new TerraformReference<string>(this, "password_change_interval");
        set => SetArgument("password_change_interval", value);
    }

    /// <summary>
    /// Number of previous passwords that cannot be reused.
    /// </summary>
    public TerraformValue<double>? ReuseInterval
    {
        get => new TerraformReference<double>(this, "reuse_interval");
        set => SetArgument("reuse_interval", value);
    }

}

/// <summary>
/// Block type for read_pool_auto_scale_config in GoogleSqlDatabaseInstanceSettingsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleSqlDatabaseInstanceSettingsBlockReadPoolAutoScaleConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "read_pool_auto_scale_config";

    /// <summary>
    /// True if auto scale in is disabled.
    /// </summary>
    public TerraformValue<bool>? DisableScaleIn
    {
        get => new TerraformReference<bool>(this, "disable_scale_in");
        set => SetArgument("disable_scale_in", value);
    }

    /// <summary>
    /// True if Read Pool Auto Scale is enabled.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// Maximum number of nodes in the read pool. If set to lower than current node count, node count will be updated.
    /// </summary>
    public TerraformValue<double>? MaxNodeCount
    {
        get => new TerraformReference<double>(this, "max_node_count");
        set => SetArgument("max_node_count", value);
    }

    /// <summary>
    /// Minimum number of nodes in the read pool. If set to higher than current node count, node count will be updated.
    /// </summary>
    public TerraformValue<double>? MinNodeCount
    {
        get => new TerraformReference<double>(this, "min_node_count");
        set => SetArgument("min_node_count", value);
    }

    /// <summary>
    /// The cooldown period for scale in operations.
    /// </summary>
    public TerraformValue<double>? ScaleInCooldownSeconds
    {
        get => new TerraformReference<double>(this, "scale_in_cooldown_seconds");
        set => SetArgument("scale_in_cooldown_seconds", value);
    }

    /// <summary>
    /// The cooldown period for scale out operations.
    /// </summary>
    public TerraformValue<double>? ScaleOutCooldownSeconds
    {
        get => new TerraformReference<double>(this, "scale_out_cooldown_seconds");
        set => SetArgument("scale_out_cooldown_seconds", value);
    }

    /// <summary>
    /// TargetMetrics block (nesting mode: set).
    /// </summary>
    public TerraformSet<GoogleSqlDatabaseInstanceSettingsBlockReadPoolAutoScaleConfigBlockTargetMetricsBlock>? TargetMetrics
    {
        get => GetArgument<TerraformSet<GoogleSqlDatabaseInstanceSettingsBlockReadPoolAutoScaleConfigBlockTargetMetricsBlock>>("target_metrics");
        set => SetArgument("target_metrics", value);
    }

}

/// <summary>
/// Block type for target_metrics in GoogleSqlDatabaseInstanceSettingsBlockReadPoolAutoScaleConfigBlock.
/// Nesting mode: set
/// </summary>
public class GoogleSqlDatabaseInstanceSettingsBlockReadPoolAutoScaleConfigBlockTargetMetricsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "target_metrics";

    /// <summary>
    /// Metric name for Read Pool Auto Scale.
    /// </summary>
    public TerraformValue<string>? Metric
    {
        get => new TerraformReference<string>(this, "metric");
        set => SetArgument("metric", value);
    }

    /// <summary>
    /// Target value for Read Pool Auto Scale.
    /// </summary>
    public TerraformValue<double>? TargetValue
    {
        get => new TerraformReference<double>(this, "target_value");
        set => SetArgument("target_value", value);
    }

}

/// <summary>
/// Block type for sql_server_audit_config in GoogleSqlDatabaseInstanceSettingsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleSqlDatabaseInstanceSettingsBlockSqlServerAuditConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "sql_server_audit_config";

    /// <summary>
    /// The name of the destination bucket (e.g., gs://mybucket).
    /// </summary>
    public TerraformValue<string>? Bucket
    {
        get => new TerraformReference<string>(this, "bucket");
        set => SetArgument("bucket", value);
    }

    /// <summary>
    /// How long to keep generated audit files. A duration in seconds with up to nine fractional digits, terminated by &#39;s&#39;. Example: &amp;quot;3.5s&amp;quot;..
    /// </summary>
    public TerraformValue<string>? RetentionInterval
    {
        get => new TerraformReference<string>(this, "retention_interval");
        set => SetArgument("retention_interval", value);
    }

    /// <summary>
    /// How often to upload generated audit files. A duration in seconds with up to nine fractional digits, terminated by &#39;s&#39;. Example: &amp;quot;3.5s&amp;quot;.
    /// </summary>
    public TerraformValue<string>? UploadInterval
    {
        get => new TerraformReference<string>(this, "upload_interval");
        set => SetArgument("upload_interval", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleSqlDatabaseInstance.
/// Nesting mode: single
/// </summary>
public class GoogleSqlDatabaseInstanceTimeoutsBlock : TerraformBlock
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
/// Represents a google_sql_database_instance Terraform resource.
/// Manages a google_sql_database_instance resource.
/// </summary>
public partial class GoogleSqlDatabaseInstance(string name) : TerraformResource("google_sql_database_instance", name)
{
    /// <summary>
    /// The name of the BackupDR backup to restore from.
    /// </summary>
    public TerraformValue<string>? BackupdrBackup
    {
        get => new TerraformReference<string>(this, "backupdr_backup");
        set => SetArgument("backupdr_backup", value);
    }

    /// <summary>
    /// The MySQL, PostgreSQL or SQL Server (beta) version to use. Supported values include MYSQL_5_6, MYSQL_5_7, MYSQL_8_0, MYSQL_8_4, POSTGRES_9_6, POSTGRES_10, POSTGRES_11, POSTGRES_12, POSTGRES_13, POSTGRES_14, POSTGRES_15, POSTGRES_16, POSTGRES_17, SQLSERVER_2017_STANDARD, SQLSERVER_2017_ENTERPRISE, SQLSERVER_2017_EXPRESS, SQLSERVER_2017_WEB. Database Version Policies includes an up-to-date reference of supported versions.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatabaseVersion is required")]
    public required TerraformValue<string> DatabaseVersion
    {
        get => new TerraformReference<string>(this, "database_version");
        set => SetArgument("database_version", value);
    }

    /// <summary>
    /// Used to block Terraform from deleting a SQL Instance. Defaults to true.
    /// </summary>
    public TerraformValue<bool>? DeletionProtection
    {
        get => new TerraformReference<bool>(this, "deletion_protection");
        set => SetArgument("deletion_protection", value);
    }

    /// <summary>
    /// The encryption_key_name attribute.
    /// </summary>
    public TerraformValue<string> EncryptionKeyName
    {
        get => new TerraformReference<string>(this, "encryption_key_name");
        set => SetArgument("encryption_key_name", value);
    }

    /// <summary>
    /// The description of final backup if instance enable create final backup during instance deletion. 
    /// </summary>
    public TerraformValue<string>? FinalBackupDescription
    {
        get => new TerraformReference<string>(this, "final_backup_description");
        set => SetArgument("final_backup_description", value);
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
    /// The type of the instance. See https://cloud.google.com/sql/docs/mysql/admin-api/rest/v1/instances#SqlInstanceType for supported values.
    /// </summary>
    public TerraformValue<string> InstanceType
    {
        get => new TerraformReference<string>(this, "instance_type");
        set => SetArgument("instance_type", value);
    }

    /// <summary>
    /// Maintenance version.
    /// </summary>
    public TerraformValue<string> MaintenanceVersion
    {
        get => new TerraformReference<string>(this, "maintenance_version");
        set => SetArgument("maintenance_version", value);
    }

    /// <summary>
    /// The name of the instance that will act as the master in the replication setup. Note, this requires the master to have binary_log_enabled set, as well as existing backups.
    /// </summary>
    public TerraformValue<string> MasterInstanceName
    {
        get => new TerraformReference<string>(this, "master_instance_name");
        set => SetArgument("master_instance_name", value);
    }

    /// <summary>
    /// The name of the instance. If the name is left blank, Terraform will randomly generate one when the instance is first created. This is done because after a name is used, it cannot be reused for up to one week.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// For a read pool instance, the number of nodes in the read pool. For read pools with auto scaling enabled, this field is read only.
    /// </summary>
    public TerraformValue<double> NodeCount
    {
        get => new TerraformReference<double>(this, "node_count");
        set => SetArgument("node_count", value);
    }

    /// <summary>
    /// The ID of the project in which the resource belongs. If it is not provided, the provider project is used.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => new TerraformReference<string>(this, "project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The region the instance will sit in. Note, Cloud SQL is not available in all regions. A valid region must be provided to use this resource. If a region is not provided in the resource definition, the provider region will be used instead, but this will be an apply-time error for instances if the provider region is not supported with Cloud SQL. If you choose not to provide the region argument for this resource, make sure you understand this.
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The replicas of the instance.
    /// </summary>
    public TerraformList<string> ReplicaNames
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "replica_names").ResolveNodes(ctx));
        set => SetArgument("replica_names", value);
    }

    /// <summary>
    /// Initial root password. Required for MS SQL Server.
    /// </summary>
    public TerraformValue<string>? RootPassword
    {
        get => new TerraformReference<string>(this, "root_password");
        set => SetArgument("root_password", value);
    }

    /// <summary>
    /// Available Maintenance versions.
    /// </summary>
    public TerraformList<string> AvailableMaintenanceVersions
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "available_maintenance_versions").ResolveNodes(ctx));
    }

    /// <summary>
    /// The connection name of the instance to be used in connection strings. For example, when connecting with Cloud SQL Proxy.
    /// </summary>
    public TerraformValue<string> ConnectionName
    {
        get => new TerraformReference<string>(this, "connection_name");
    }

    /// <summary>
    /// The instance-level dns name of the instance for PSC instances or public IP CAS instances.
    /// </summary>
    public TerraformValue<string> DnsName
    {
        get => new TerraformReference<string>(this, "dns_name");
    }

    /// <summary>
    /// The list of DNS names used by this instance. Different connection types for an instance may have different DNS names. DNS names can apply to an individual instance or a cluster of instances.
    /// </summary>
    public TerraformList<TerraformMap<object>> DnsNames
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "dns_names").ResolveNodes(ctx));
    }

    /// <summary>
    /// The first IPv4 address of any type assigned. This is to support accessing the first address in the list in a terraform output when the resource is configured with a count.
    /// </summary>
    public TerraformValue<string> FirstIpAddress
    {
        get => new TerraformReference<string>(this, "first_ip_address");
    }

    /// <summary>
    /// The ip_address attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> IpAddress
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "ip_address").ResolveNodes(ctx));
    }

    /// <summary>
    /// IPv4 address assigned. This is a workaround for an issue fixed in Terraform 0.12 but also provides a convenient way to access an IP of a specific type without performing filtering in a Terraform config.
    /// </summary>
    public TerraformValue<string> PrivateIpAddress
    {
        get => new TerraformReference<string>(this, "private_ip_address");
    }

    /// <summary>
    /// The link to service attachment of PSC instance.
    /// </summary>
    public TerraformValue<string> PscServiceAttachmentLink
    {
        get => new TerraformReference<string>(this, "psc_service_attachment_link");
    }

    /// <summary>
    /// IPv4 address assigned. This is a workaround for an issue fixed in Terraform 0.12 but also provides a convenient way to access an IP of a specific type without performing filtering in a Terraform config.
    /// </summary>
    public TerraformValue<string> PublicIpAddress
    {
        get => new TerraformReference<string>(this, "public_ip_address");
    }

    /// <summary>
    /// The URI of the created resource.
    /// </summary>
    public TerraformValue<string> SelfLink
    {
        get => new TerraformReference<string>(this, "self_link");
    }

    /// <summary>
    /// The server_ca_cert attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> ServerCaCert
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "server_ca_cert").ResolveNodes(ctx));
    }

    /// <summary>
    /// The service account email address assigned to the instance.
    /// </summary>
    public TerraformValue<string> ServiceAccountEmailAddress
    {
        get => new TerraformReference<string>(this, "service_account_email_address");
    }

    /// <summary>
    /// Clone block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Clone block(s) allowed")]
    public TerraformList<GoogleSqlDatabaseInstanceCloneBlock>? Clone
    {
        get => GetArgument<TerraformList<GoogleSqlDatabaseInstanceCloneBlock>>("clone");
        set => SetArgument("clone", value);
    }

    /// <summary>
    /// PointInTimeRestoreContext block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PointInTimeRestoreContext block(s) allowed")]
    public TerraformList<GoogleSqlDatabaseInstancePointInTimeRestoreContextBlock>? PointInTimeRestoreContext
    {
        get => GetArgument<TerraformList<GoogleSqlDatabaseInstancePointInTimeRestoreContextBlock>>("point_in_time_restore_context");
        set => SetArgument("point_in_time_restore_context", value);
    }

    /// <summary>
    /// ReplicaConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ReplicaConfiguration block(s) allowed")]
    public TerraformList<GoogleSqlDatabaseInstanceReplicaConfigurationBlock>? ReplicaConfiguration
    {
        get => GetArgument<TerraformList<GoogleSqlDatabaseInstanceReplicaConfigurationBlock>>("replica_configuration");
        set => SetArgument("replica_configuration", value);
    }

    /// <summary>
    /// ReplicationCluster block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ReplicationCluster block(s) allowed")]
    public TerraformList<GoogleSqlDatabaseInstanceReplicationClusterBlock>? ReplicationCluster
    {
        get => GetArgument<TerraformList<GoogleSqlDatabaseInstanceReplicationClusterBlock>>("replication_cluster");
        set => SetArgument("replication_cluster", value);
    }

    /// <summary>
    /// RestoreBackupContext block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RestoreBackupContext block(s) allowed")]
    public TerraformList<GoogleSqlDatabaseInstanceRestoreBackupContextBlock>? RestoreBackupContext
    {
        get => GetArgument<TerraformList<GoogleSqlDatabaseInstanceRestoreBackupContextBlock>>("restore_backup_context");
        set => SetArgument("restore_backup_context", value);
    }

    /// <summary>
    /// Settings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Settings block(s) allowed")]
    public TerraformList<GoogleSqlDatabaseInstanceSettingsBlock>? Settings
    {
        get => GetArgument<TerraformList<GoogleSqlDatabaseInstanceSettingsBlock>>("settings");
        set => SetArgument("settings", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleSqlDatabaseInstanceTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleSqlDatabaseInstanceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
