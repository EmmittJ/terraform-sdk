using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for clone in .
/// Nesting mode: list
/// </summary>
public class GoogleSqlDatabaseInstanceCloneBlock : TerraformBlock
{
    /// <summary>
    /// The name of the allocated ip range for the private ip CloudSQL instance. For example: &amp;quot;google-managed-services-default&amp;quot;. If set, the cloned instance ip will be created in the allocated range. The range name must comply with [RFC 1035](https://tools.ietf.org/html/rfc1035). Specifically, the name must be 1-63 characters long and match the regular expression [a-z]([-a-z0-9]*[a-z0-9])?.
    /// </summary>
    public TerraformProperty<string>? AllocatedIpRange
    {
        set => SetProperty("allocated_ip_range", value);
    }

    /// <summary>
    /// (SQL Server only, use with point_in_time) clone only the specified databases from the source instance. Clone all databases if empty.
    /// </summary>
    public List<TerraformProperty<string>>? DatabaseNames
    {
        set => SetProperty("database_names", value);
    }

    /// <summary>
    /// The timestamp of the point in time that should be restored.
    /// </summary>
    public TerraformProperty<string>? PointInTime
    {
        set => SetProperty("point_in_time", value);
    }

    /// <summary>
    /// (Point-in-time recovery for PostgreSQL only) Clone to an instance in the specified zone. If no zone is specified, clone to the same zone as the source instance.
    /// </summary>
    public TerraformProperty<string>? PreferredZone
    {
        set => SetProperty("preferred_zone", value);
    }

    /// <summary>
    /// The timestamp of when the source instance was deleted for a clone from a deleted instance.
    /// </summary>
    public TerraformProperty<string>? SourceInstanceDeletionTime
    {
        set => SetProperty("source_instance_deletion_time", value);
    }

    /// <summary>
    /// The name of the instance from which the point in time should be restored.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceInstanceName is required")]
    public required TerraformProperty<string> SourceInstanceName
    {
        set => SetProperty("source_instance_name", value);
    }

}

/// <summary>
/// Block type for point_in_time_restore_context in .
/// Nesting mode: list
/// </summary>
public class GoogleSqlDatabaseInstancePointInTimeRestoreContextBlock : TerraformBlock
{
    /// <summary>
    /// The name of the allocated IP range for the internal IP Cloud SQL instance. For example: &amp;quot;google-managed-services-default&amp;quot;. If you set this, then Cloud SQL creates the IP address for the cloned instance in the allocated range. This range must comply with [RFC 1035](https://tools.ietf.org/html/rfc1035) standards. Specifically, the name must be 1-63 characters long and match the regular expression [a-z]([-a-z0-9]*[a-z0-9])?.
    /// </summary>
    public TerraformProperty<string>? AllocatedIpRange
    {
        set => SetProperty("allocated_ip_range", value);
    }

    /// <summary>
    /// The Google Cloud Backup and Disaster Recovery Datasource URI. For example: &amp;quot;projects/my-project/locations/us-central1/datasources/my-datasource&amp;quot;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Datasource is required")]
    public required TerraformProperty<string> Datasource
    {
        set => SetProperty("datasource", value);
    }

    /// <summary>
    /// The date and time to which you want to restore the instance.
    /// </summary>
    public TerraformProperty<string>? PointInTime
    {
        set => SetProperty("point_in_time", value);
    }

    /// <summary>
    /// Point-in-time recovery of an instance to the specified zone. If no zone is specified, then clone to the same primary zone as the source instance.
    /// </summary>
    public TerraformProperty<string>? PreferredZone
    {
        set => SetProperty("preferred_zone", value);
    }

    /// <summary>
    /// The name of the target instance to restore to.
    /// </summary>
    public TerraformProperty<string>? TargetInstance
    {
        set => SetProperty("target_instance", value);
    }

}

/// <summary>
/// Block type for replica_configuration in .
/// Nesting mode: list
/// </summary>
public class GoogleSqlDatabaseInstanceReplicaConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// PEM representation of the trusted CA&#39;s x509 certificate.
    /// </summary>
    public TerraformProperty<string>? CaCertificate
    {
        set => SetProperty("ca_certificate", value);
    }

    /// <summary>
    /// Specifies if a SQL Server replica is a cascadable replica. A cascadable replica is a SQL Server cross region replica that supports replica(s) under it.
    /// </summary>
    public TerraformProperty<bool>? CascadableReplica
    {
        set => SetProperty("cascadable_replica", value);
    }

    /// <summary>
    /// PEM representation of the replica&#39;s x509 certificate.
    /// </summary>
    public TerraformProperty<string>? ClientCertificate
    {
        set => SetProperty("client_certificate", value);
    }

    /// <summary>
    /// PEM representation of the replica&#39;s private key. The corresponding public key in encoded in the client_certificate.
    /// </summary>
    public TerraformProperty<string>? ClientKey
    {
        set => SetProperty("client_key", value);
    }

    /// <summary>
    /// The number of seconds between connect retries. MySQL&#39;s default is 60 seconds.
    /// </summary>
    public TerraformProperty<double>? ConnectRetryInterval
    {
        set => SetProperty("connect_retry_interval", value);
    }

    /// <summary>
    /// Path to a SQL file in Google Cloud Storage from which replica instances are created. Format is gs://bucket/filename.
    /// </summary>
    public TerraformProperty<string>? DumpFilePath
    {
        set => SetProperty("dump_file_path", value);
    }

    /// <summary>
    /// Specifies if the replica is the failover target. If the field is set to true the replica will be designated as a failover replica. If the master instance fails, the replica instance will be promoted as the new master instance. Not supported for Postgres
    /// </summary>
    public TerraformProperty<bool>? FailoverTarget
    {
        set => SetProperty("failover_target", value);
    }

    /// <summary>
    /// Time in ms between replication heartbeats.
    /// </summary>
    public TerraformProperty<double>? MasterHeartbeatPeriod
    {
        set => SetProperty("master_heartbeat_period", value);
    }

    /// <summary>
    /// Password for the replication connection.
    /// </summary>
    public TerraformProperty<string>? Password
    {
        set => SetProperty("password", value);
    }

    /// <summary>
    /// Permissible ciphers for use in SSL encryption.
    /// </summary>
    public TerraformProperty<string>? SslCipher
    {
        set => SetProperty("ssl_cipher", value);
    }

    /// <summary>
    /// Username for replication connection.
    /// </summary>
    public TerraformProperty<string>? Username
    {
        set => SetProperty("username", value);
    }

    /// <summary>
    /// True if the master&#39;s common name value is checked during the SSL handshake.
    /// </summary>
    public TerraformProperty<bool>? VerifyServerCertificate
    {
        set => SetProperty("verify_server_certificate", value);
    }

}

/// <summary>
/// Block type for replication_cluster in .
/// Nesting mode: list
/// </summary>
public class GoogleSqlDatabaseInstanceReplicationClusterBlock : TerraformBlock
{
    /// <summary>
    /// Read-only field that indicates whether the replica is a DR replica.
    /// </summary>
    public TerraformProperty<bool>? DrReplica
    {
        set => SetProperty("dr_replica", value);
    }

    /// <summary>
    /// If the instance is a primary instance, then this field identifies the disaster recovery (DR) replica. The standard format of this field is &amp;quot;your-project:your-instance&amp;quot;. You can also set this field to &amp;quot;your-instance&amp;quot;, but cloud SQL backend will convert it to the aforementioned standard format.
    /// </summary>
    public TerraformProperty<string>? FailoverDrReplicaName
    {
        set => SetProperty("failover_dr_replica_name", value);
    }

    /// <summary>
    /// If set, this field indicates this instance has a private service access (PSA) DNS endpoint that is pointing to the primary instance of the cluster. If this instance is the primary, then the DNS endpoint points to this instance. After a switchover or replica failover operation, this DNS endpoint points to the promoted instance. This is a read-only field, returned to the user as information. This field can exist even if a standalone instance doesn&#39;t have a DR replica yet or the DR replica is deleted.
    /// </summary>
    public TerraformProperty<string>? PsaWriteEndpoint
    {
        set => SetProperty("psa_write_endpoint", value);
    }

}

/// <summary>
/// Block type for restore_backup_context in .
/// Nesting mode: list
/// </summary>
public class GoogleSqlDatabaseInstanceRestoreBackupContextBlock : TerraformBlock
{
    /// <summary>
    /// The ID of the backup run to restore from.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackupRunId is required")]
    public required TerraformProperty<double> BackupRunId
    {
        set => SetProperty("backup_run_id", value);
    }

    /// <summary>
    /// The ID of the instance that the backup was taken from.
    /// </summary>
    public TerraformProperty<string>? InstanceId
    {
        set => SetProperty("instance_id", value);
    }

    /// <summary>
    /// The full project ID of the source instance.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        set => SetProperty("project", value);
    }

}

/// <summary>
/// Block type for settings in .
/// Nesting mode: list
/// </summary>
public class GoogleSqlDatabaseInstanceSettingsBlock : TerraformBlock
{
    /// <summary>
    /// This specifies when the instance should be active. Can be either ALWAYS, NEVER or ON_DEMAND.
    /// </summary>
    public TerraformProperty<string>? ActivationPolicy
    {
        set => SetProperty("activation_policy", value);
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
    public TerraformProperty<string>? AvailabilityType
    {
        set => SetProperty("availability_type", value);
    }

    /// <summary>
    /// The name of server instance collation.
    /// </summary>
    public TerraformProperty<string>? Collation
    {
        set => SetProperty("collation", value);
    }

    /// <summary>
    /// Enables the enforcement of Cloud SQL Auth Proxy or Cloud SQL connectors for all the connections. If enabled, all the direct connections are rejected.
    /// </summary>
    public TerraformProperty<string>? ConnectorEnforcement
    {
        set => SetProperty("connector_enforcement", value);
    }

    /// <summary>
    /// Configuration to protect against accidental instance deletion.
    /// </summary>
    public TerraformProperty<bool>? DeletionProtectionEnabled
    {
        set => SetProperty("deletion_protection_enabled", value);
    }

    /// <summary>
    /// Enables auto-resizing of the storage size. Defaults to true.
    /// </summary>
    public TerraformProperty<bool>? DiskAutoresize
    {
        set => SetProperty("disk_autoresize", value);
    }

    /// <summary>
    /// The maximum size, in GB, to which storage capacity can be automatically increased. The default value is 0, which specifies that there is no limit.
    /// </summary>
    public TerraformProperty<double>? DiskAutoresizeLimit
    {
        set => SetProperty("disk_autoresize_limit", value);
    }

    /// <summary>
    /// The size of data disk, in GB. Size of a running instance cannot be reduced but can be increased. The minimum value is 10GB for PD_SSD, PD_HDD and 20GB for HYPERDISK_BALANCED.
    /// </summary>
    public TerraformProperty<double>? DiskSize
    {
        set => SetProperty("disk_size", value);
    }

    /// <summary>
    /// The type of supported data disk is tier dependent and can be PD_SSD or PD_HDD or HYPERDISK_BALANCED.
    /// </summary>
    public TerraformProperty<string>? DiskType
    {
        set => SetProperty("disk_type", value);
    }

    /// <summary>
    /// The edition of the instance, can be ENTERPRISE or ENTERPRISE_PLUS.
    /// </summary>
    public TerraformProperty<string>? Edition
    {
        set => SetProperty("edition", value);
    }

    /// <summary>
    /// The availability type of the Cloud SQL instance, high availability
    /// (REGIONAL) or single zone (ZONAL). This field always contains the value that is reported by the
    /// API (for read pools, effective_availability_type may differ from availability_type).
    /// </summary>
    public TerraformProperty<string>? EffectiveAvailabilityType
    {
        set => SetProperty("effective_availability_type", value);
    }

    /// <summary>
    /// Enables Dataplex Integration.
    /// </summary>
    public TerraformProperty<bool>? EnableDataplexIntegration
    {
        set => SetProperty("enable_dataplex_integration", value);
    }

    /// <summary>
    /// Enables Vertex AI Integration.
    /// </summary>
    public TerraformProperty<bool>? EnableGoogleMlIntegration
    {
        set => SetProperty("enable_google_ml_integration", value);
    }

    /// <summary>
    /// Pricing plan for this instance, can only be PER_USE.
    /// </summary>
    public TerraformProperty<string>? PricingPlan
    {
        set => SetProperty("pricing_plan", value);
    }

    /// <summary>
    /// When this parameter is set to true, Cloud SQL retains backups of the instance even after the instance is deleted. The ON_DEMAND backup will be retained until customer deletes the backup or the project. The AUTOMATED backup will be retained based on the backups retention setting.
    /// </summary>
    public TerraformProperty<bool>? RetainBackupsOnDelete
    {
        set => SetProperty("retain_backups_on_delete", value);
    }

    /// <summary>
    /// The machine type to use. See tiers for more details and supported versions. Postgres supports only shared-core machine types, and custom machine types such as db-custom-2-13312. See the Custom Machine Type Documentation to learn about specifying custom machine types.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Tier is required")]
    public required TerraformProperty<string> Tier
    {
        set => SetProperty("tier", value);
    }

    /// <summary>
    /// The time_zone to be used by the database engine (supported only for SQL Server), in SQL Server timezone format.
    /// </summary>
    public TerraformProperty<string>? TimeZone
    {
        set => SetProperty("time_zone", value);
    }

    /// <summary>
    /// A set of key/value user label pairs to assign to the instance.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? UserLabels
    {
        set => SetProperty("user_labels", value);
    }

    /// <summary>
    /// Used to make sure changes to the settings block are atomic.
    /// </summary>
    public TerraformProperty<double>? Version
    {
        set => SetProperty("version", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleSqlDatabaseInstanceTimeoutsBlock : TerraformBlock
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
/// Manages a google_sql_database_instance resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleSqlDatabaseInstance : TerraformResource
{
    public GoogleSqlDatabaseInstance(string name) : base("google_sql_database_instance", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("available_maintenance_versions");
        SetOutput("connection_name");
        SetOutput("dns_name");
        SetOutput("dns_names");
        SetOutput("first_ip_address");
        SetOutput("ip_address");
        SetOutput("private_ip_address");
        SetOutput("psc_service_attachment_link");
        SetOutput("public_ip_address");
        SetOutput("self_link");
        SetOutput("server_ca_cert");
        SetOutput("service_account_email_address");
        SetOutput("backupdr_backup");
        SetOutput("database_version");
        SetOutput("deletion_protection");
        SetOutput("encryption_key_name");
        SetOutput("final_backup_description");
        SetOutput("id");
        SetOutput("instance_type");
        SetOutput("maintenance_version");
        SetOutput("master_instance_name");
        SetOutput("name");
        SetOutput("node_count");
        SetOutput("project");
        SetOutput("region");
        SetOutput("replica_names");
        SetOutput("root_password");
    }

    /// <summary>
    /// The name of the BackupDR backup to restore from.
    /// </summary>
    public TerraformProperty<string> BackupdrBackup
    {
        get => GetRequiredOutput<TerraformProperty<string>>("backupdr_backup");
        set => SetProperty("backupdr_backup", value);
    }

    /// <summary>
    /// The MySQL, PostgreSQL or SQL Server (beta) version to use. Supported values include MYSQL_5_6, MYSQL_5_7, MYSQL_8_0, MYSQL_8_4, POSTGRES_9_6, POSTGRES_10, POSTGRES_11, POSTGRES_12, POSTGRES_13, POSTGRES_14, POSTGRES_15, POSTGRES_16, POSTGRES_17, SQLSERVER_2017_STANDARD, SQLSERVER_2017_ENTERPRISE, SQLSERVER_2017_EXPRESS, SQLSERVER_2017_WEB. Database Version Policies includes an up-to-date reference of supported versions.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatabaseVersion is required")]
    public required TerraformProperty<string> DatabaseVersion
    {
        get => GetRequiredOutput<TerraformProperty<string>>("database_version");
        set => SetProperty("database_version", value);
    }

    /// <summary>
    /// Used to block Terraform from deleting a SQL Instance. Defaults to true.
    /// </summary>
    public TerraformProperty<bool> DeletionProtection
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("deletion_protection");
        set => SetProperty("deletion_protection", value);
    }

    /// <summary>
    /// The encryption_key_name attribute.
    /// </summary>
    public TerraformProperty<string> EncryptionKeyName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("encryption_key_name");
        set => SetProperty("encryption_key_name", value);
    }

    /// <summary>
    /// The description of final backup if instance enable create final backup during instance deletion. 
    /// </summary>
    public TerraformProperty<string> FinalBackupDescription
    {
        get => GetRequiredOutput<TerraformProperty<string>>("final_backup_description");
        set => SetProperty("final_backup_description", value);
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
    /// The type of the instance. See https://cloud.google.com/sql/docs/mysql/admin-api/rest/v1/instances#SqlInstanceType for supported values.
    /// </summary>
    public TerraformProperty<string> InstanceType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("instance_type");
        set => SetProperty("instance_type", value);
    }

    /// <summary>
    /// Maintenance version.
    /// </summary>
    public TerraformProperty<string> MaintenanceVersion
    {
        get => GetRequiredOutput<TerraformProperty<string>>("maintenance_version");
        set => SetProperty("maintenance_version", value);
    }

    /// <summary>
    /// The name of the instance that will act as the master in the replication setup. Note, this requires the master to have binary_log_enabled set, as well as existing backups.
    /// </summary>
    public TerraformProperty<string> MasterInstanceName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("master_instance_name");
        set => SetProperty("master_instance_name", value);
    }

    /// <summary>
    /// The name of the instance. If the name is left blank, Terraform will randomly generate one when the instance is first created. This is done because after a name is used, it cannot be reused for up to one week.
    /// </summary>
    public TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// For a read pool instance, the number of nodes in the read pool. For read pools with auto scaling enabled, this field is read only.
    /// </summary>
    public TerraformProperty<double> NodeCount
    {
        get => GetRequiredOutput<TerraformProperty<double>>("node_count");
        set => SetProperty("node_count", value);
    }

    /// <summary>
    /// The ID of the project in which the resource belongs. If it is not provided, the provider project is used.
    /// </summary>
    public TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
    }

    /// <summary>
    /// The region the instance will sit in. Note, Cloud SQL is not available in all regions. A valid region must be provided to use this resource. If a region is not provided in the resource definition, the provider region will be used instead, but this will be an apply-time error for instances if the provider region is not supported with Cloud SQL. If you choose not to provide the region argument for this resource, make sure you understand this.
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The replicas of the instance.
    /// </summary>
    public List<TerraformProperty<string>> ReplicaNames
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("replica_names");
        set => SetProperty("replica_names", value);
    }

    /// <summary>
    /// Initial root password. Required for MS SQL Server.
    /// </summary>
    public TerraformProperty<string> RootPassword
    {
        get => GetRequiredOutput<TerraformProperty<string>>("root_password");
        set => SetProperty("root_password", value);
    }

    /// <summary>
    /// Block for clone.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Clone block(s) allowed")]
    public List<GoogleSqlDatabaseInstanceCloneBlock>? Clone
    {
        set => SetProperty("clone", value);
    }

    /// <summary>
    /// Block for point_in_time_restore_context.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PointInTimeRestoreContext block(s) allowed")]
    public List<GoogleSqlDatabaseInstancePointInTimeRestoreContextBlock>? PointInTimeRestoreContext
    {
        set => SetProperty("point_in_time_restore_context", value);
    }

    /// <summary>
    /// Block for replica_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ReplicaConfiguration block(s) allowed")]
    public List<GoogleSqlDatabaseInstanceReplicaConfigurationBlock>? ReplicaConfiguration
    {
        set => SetProperty("replica_configuration", value);
    }

    /// <summary>
    /// Block for replication_cluster.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ReplicationCluster block(s) allowed")]
    public List<GoogleSqlDatabaseInstanceReplicationClusterBlock>? ReplicationCluster
    {
        set => SetProperty("replication_cluster", value);
    }

    /// <summary>
    /// Block for restore_backup_context.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RestoreBackupContext block(s) allowed")]
    public List<GoogleSqlDatabaseInstanceRestoreBackupContextBlock>? RestoreBackupContext
    {
        set => SetProperty("restore_backup_context", value);
    }

    /// <summary>
    /// Block for settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Settings block(s) allowed")]
    public List<GoogleSqlDatabaseInstanceSettingsBlock>? Settings
    {
        set => SetProperty("settings", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleSqlDatabaseInstanceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// Available Maintenance versions.
    /// </summary>
    public TerraformExpression AvailableMaintenanceVersions => this["available_maintenance_versions"];

    /// <summary>
    /// The connection name of the instance to be used in connection strings. For example, when connecting with Cloud SQL Proxy.
    /// </summary>
    public TerraformExpression ConnectionName => this["connection_name"];

    /// <summary>
    /// The instance-level dns name of the instance for PSC instances or public IP CAS instances.
    /// </summary>
    public TerraformExpression DnsName => this["dns_name"];

    /// <summary>
    /// The list of DNS names used by this instance. Different connection types for an instance may have different DNS names. DNS names can apply to an individual instance or a cluster of instances.
    /// </summary>
    public TerraformExpression DnsNames => this["dns_names"];

    /// <summary>
    /// The first IPv4 address of any type assigned. This is to support accessing the first address in the list in a terraform output when the resource is configured with a count.
    /// </summary>
    public TerraformExpression FirstIpAddress => this["first_ip_address"];

    /// <summary>
    /// The ip_address attribute.
    /// </summary>
    public TerraformExpression IpAddress => this["ip_address"];

    /// <summary>
    /// IPv4 address assigned. This is a workaround for an issue fixed in Terraform 0.12 but also provides a convenient way to access an IP of a specific type without performing filtering in a Terraform config.
    /// </summary>
    public TerraformExpression PrivateIpAddress => this["private_ip_address"];

    /// <summary>
    /// The link to service attachment of PSC instance.
    /// </summary>
    public TerraformExpression PscServiceAttachmentLink => this["psc_service_attachment_link"];

    /// <summary>
    /// IPv4 address assigned. This is a workaround for an issue fixed in Terraform 0.12 but also provides a convenient way to access an IP of a specific type without performing filtering in a Terraform config.
    /// </summary>
    public TerraformExpression PublicIpAddress => this["public_ip_address"];

    /// <summary>
    /// The URI of the created resource.
    /// </summary>
    public TerraformExpression SelfLink => this["self_link"];

    /// <summary>
    /// The server_ca_cert attribute.
    /// </summary>
    public TerraformExpression ServerCaCert => this["server_ca_cert"];

    /// <summary>
    /// The service account email address assigned to the instance.
    /// </summary>
    public TerraformExpression ServiceAccountEmailAddress => this["service_account_email_address"];

}
