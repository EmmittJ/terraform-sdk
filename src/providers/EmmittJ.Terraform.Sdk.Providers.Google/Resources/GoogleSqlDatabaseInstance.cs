using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for clone in .
/// Nesting mode: list
/// </summary>
public partial class GoogleSqlDatabaseInstanceCloneBlock : TerraformBlockBase
{
    /// <summary>
    /// The name of the allocated ip range for the private ip CloudSQL instance. For example: &amp;quot;google-managed-services-default&amp;quot;. If set, the cloned instance ip will be created in the allocated range. The range name must comply with [RFC 1035](https://tools.ietf.org/html/rfc1035). Specifically, the name must be 1-63 characters long and match the regular expression [a-z]([-a-z0-9]*[a-z0-9])?.
    /// </summary>
    [TerraformProperty("allocated_ip_range")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? AllocatedIpRange { get; set; }

    /// <summary>
    /// (SQL Server only, use with point_in_time) clone only the specified databases from the source instance. Clone all databases if empty.
    /// </summary>
    [TerraformProperty("database_names")]
    // Optional argument - source generator will implement get/set
    public TerraformList<string>? DatabaseNames { get; set; }

    /// <summary>
    /// The timestamp of the point in time that should be restored.
    /// </summary>
    [TerraformProperty("point_in_time")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? PointInTime { get; set; }

    /// <summary>
    /// (Point-in-time recovery for PostgreSQL only) Clone to an instance in the specified zone. If no zone is specified, clone to the same zone as the source instance.
    /// </summary>
    [TerraformProperty("preferred_zone")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? PreferredZone { get; set; }

    /// <summary>
    /// The timestamp of when the source instance was deleted for a clone from a deleted instance.
    /// </summary>
    [TerraformProperty("source_instance_deletion_time")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? SourceInstanceDeletionTime { get; set; }

    /// <summary>
    /// The name of the instance from which the point in time should be restored.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceInstanceName is required")]
    [TerraformProperty("source_instance_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> SourceInstanceName { get; set; }

}

/// <summary>
/// Block type for point_in_time_restore_context in .
/// Nesting mode: list
/// </summary>
public partial class GoogleSqlDatabaseInstancePointInTimeRestoreContextBlock : TerraformBlockBase
{
    /// <summary>
    /// The name of the allocated IP range for the internal IP Cloud SQL instance. For example: &amp;quot;google-managed-services-default&amp;quot;. If you set this, then Cloud SQL creates the IP address for the cloned instance in the allocated range. This range must comply with [RFC 1035](https://tools.ietf.org/html/rfc1035) standards. Specifically, the name must be 1-63 characters long and match the regular expression [a-z]([-a-z0-9]*[a-z0-9])?.
    /// </summary>
    [TerraformProperty("allocated_ip_range")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? AllocatedIpRange { get; set; }

    /// <summary>
    /// The Google Cloud Backup and Disaster Recovery Datasource URI. For example: &amp;quot;projects/my-project/locations/us-central1/datasources/my-datasource&amp;quot;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Datasource is required")]
    [TerraformProperty("datasource")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Datasource { get; set; }

    /// <summary>
    /// The date and time to which you want to restore the instance.
    /// </summary>
    [TerraformProperty("point_in_time")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? PointInTime { get; set; }

    /// <summary>
    /// Point-in-time recovery of an instance to the specified zone. If no zone is specified, then clone to the same primary zone as the source instance.
    /// </summary>
    [TerraformProperty("preferred_zone")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? PreferredZone { get; set; }

    /// <summary>
    /// The name of the target instance to restore to.
    /// </summary>
    [TerraformProperty("target_instance")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? TargetInstance { get; set; }

}

/// <summary>
/// Block type for replica_configuration in .
/// Nesting mode: list
/// </summary>
public partial class GoogleSqlDatabaseInstanceReplicaConfigurationBlock : TerraformBlockBase
{
    /// <summary>
    /// PEM representation of the trusted CA&#39;s x509 certificate.
    /// </summary>
    [TerraformProperty("ca_certificate")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? CaCertificate { get; set; }

    /// <summary>
    /// Specifies if a SQL Server replica is a cascadable replica. A cascadable replica is a SQL Server cross region replica that supports replica(s) under it.
    /// </summary>
    [TerraformProperty("cascadable_replica")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? CascadableReplica { get; set; }

    /// <summary>
    /// PEM representation of the replica&#39;s x509 certificate.
    /// </summary>
    [TerraformProperty("client_certificate")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ClientCertificate { get; set; }

    /// <summary>
    /// PEM representation of the replica&#39;s private key. The corresponding public key in encoded in the client_certificate.
    /// </summary>
    [TerraformProperty("client_key")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ClientKey { get; set; }

    /// <summary>
    /// The number of seconds between connect retries. MySQL&#39;s default is 60 seconds.
    /// </summary>
    [TerraformProperty("connect_retry_interval")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? ConnectRetryInterval { get; set; }

    /// <summary>
    /// Path to a SQL file in Google Cloud Storage from which replica instances are created. Format is gs://bucket/filename.
    /// </summary>
    [TerraformProperty("dump_file_path")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? DumpFilePath { get; set; }

    /// <summary>
    /// Specifies if the replica is the failover target. If the field is set to true the replica will be designated as a failover replica. If the master instance fails, the replica instance will be promoted as the new master instance. Not supported for Postgres
    /// </summary>
    [TerraformProperty("failover_target")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? FailoverTarget { get; set; }

    /// <summary>
    /// Time in ms between replication heartbeats.
    /// </summary>
    [TerraformProperty("master_heartbeat_period")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? MasterHeartbeatPeriod { get; set; }

    /// <summary>
    /// Password for the replication connection.
    /// </summary>
    [TerraformProperty("password")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Password { get; set; }

    /// <summary>
    /// Permissible ciphers for use in SSL encryption.
    /// </summary>
    [TerraformProperty("ssl_cipher")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? SslCipher { get; set; }

    /// <summary>
    /// Username for replication connection.
    /// </summary>
    [TerraformProperty("username")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Username { get; set; }

    /// <summary>
    /// True if the master&#39;s common name value is checked during the SSL handshake.
    /// </summary>
    [TerraformProperty("verify_server_certificate")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? VerifyServerCertificate { get; set; }

}

/// <summary>
/// Block type for replication_cluster in .
/// Nesting mode: list
/// </summary>
public partial class GoogleSqlDatabaseInstanceReplicationClusterBlock : TerraformBlockBase
{

    /// <summary>
    /// If the instance is a primary instance, then this field identifies the disaster recovery (DR) replica. The standard format of this field is &amp;quot;your-project:your-instance&amp;quot;. You can also set this field to &amp;quot;your-instance&amp;quot;, but cloud SQL backend will convert it to the aforementioned standard format.
    /// </summary>
    [TerraformProperty("failover_dr_replica_name")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? FailoverDrReplicaName { get; set; }

    /// <summary>
    /// If set, this field indicates this instance has a private service access (PSA) DNS endpoint that is pointing to the primary instance of the cluster. If this instance is the primary, then the DNS endpoint points to this instance. After a switchover or replica failover operation, this DNS endpoint points to the promoted instance. This is a read-only field, returned to the user as information. This field can exist even if a standalone instance doesn&#39;t have a DR replica yet or the DR replica is deleted.
    /// </summary>
    [TerraformProperty("psa_write_endpoint")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? PsaWriteEndpoint { get; set; }

}

/// <summary>
/// Block type for restore_backup_context in .
/// Nesting mode: list
/// </summary>
public partial class GoogleSqlDatabaseInstanceRestoreBackupContextBlock : TerraformBlockBase
{
    /// <summary>
    /// The ID of the backup run to restore from.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackupRunId is required")]
    [TerraformProperty("backup_run_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<double> BackupRunId { get; set; }

    /// <summary>
    /// The ID of the instance that the backup was taken from.
    /// </summary>
    [TerraformProperty("instance_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? InstanceId { get; set; }

    /// <summary>
    /// The full project ID of the source instance.
    /// </summary>
    [TerraformProperty("project")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Project { get; set; }

}

/// <summary>
/// Block type for settings in .
/// Nesting mode: list
/// </summary>
public partial class GoogleSqlDatabaseInstanceSettingsBlock : TerraformBlockBase
{
    /// <summary>
    /// This specifies when the instance should be active. Can be either ALWAYS, NEVER or ON_DEMAND.
    /// </summary>
    [TerraformProperty("activation_policy")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ActivationPolicy { get; set; }

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
    [TerraformProperty("availability_type")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? AvailabilityType { get; set; }

    /// <summary>
    /// The name of server instance collation.
    /// </summary>
    [TerraformProperty("collation")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Collation { get; set; }

    /// <summary>
    /// Enables the enforcement of Cloud SQL Auth Proxy or Cloud SQL connectors for all the connections. If enabled, all the direct connections are rejected.
    /// </summary>
    [TerraformProperty("connector_enforcement")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> ConnectorEnforcement { get; set; }

    /// <summary>
    /// Configuration to protect against accidental instance deletion.
    /// </summary>
    [TerraformProperty("deletion_protection_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? DeletionProtectionEnabled { get; set; }

    /// <summary>
    /// Enables auto-resizing of the storage size. Defaults to true.
    /// </summary>
    [TerraformProperty("disk_autoresize")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? DiskAutoresize { get; set; }

    /// <summary>
    /// The maximum size, in GB, to which storage capacity can be automatically increased. The default value is 0, which specifies that there is no limit.
    /// </summary>
    [TerraformProperty("disk_autoresize_limit")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? DiskAutoresizeLimit { get; set; }

    /// <summary>
    /// The size of data disk, in GB. Size of a running instance cannot be reduced but can be increased. The minimum value is 10GB for PD_SSD, PD_HDD and 20GB for HYPERDISK_BALANCED.
    /// </summary>
    [TerraformProperty("disk_size")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<double> DiskSize { get; set; }

    /// <summary>
    /// The type of supported data disk is tier dependent and can be PD_SSD or PD_HDD or HYPERDISK_BALANCED.
    /// </summary>
    [TerraformProperty("disk_type")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> DiskType { get; set; }

    /// <summary>
    /// The edition of the instance, can be ENTERPRISE or ENTERPRISE_PLUS.
    /// </summary>
    [TerraformProperty("edition")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Edition { get; set; }


    /// <summary>
    /// Enables Dataplex Integration.
    /// </summary>
    [TerraformProperty("enable_dataplex_integration")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? EnableDataplexIntegration { get; set; }

    /// <summary>
    /// Enables Vertex AI Integration.
    /// </summary>
    [TerraformProperty("enable_google_ml_integration")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? EnableGoogleMlIntegration { get; set; }

    /// <summary>
    /// Pricing plan for this instance, can only be PER_USE.
    /// </summary>
    [TerraformProperty("pricing_plan")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? PricingPlan { get; set; }

    /// <summary>
    /// When this parameter is set to true, Cloud SQL retains backups of the instance even after the instance is deleted. The ON_DEMAND backup will be retained until customer deletes the backup or the project. The AUTOMATED backup will be retained based on the backups retention setting.
    /// </summary>
    [TerraformProperty("retain_backups_on_delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? RetainBackupsOnDelete { get; set; }

    /// <summary>
    /// The machine type to use. See tiers for more details and supported versions. Postgres supports only shared-core machine types, and custom machine types such as db-custom-2-13312. See the Custom Machine Type Documentation to learn about specifying custom machine types.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Tier is required")]
    [TerraformProperty("tier")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Tier { get; set; }

    /// <summary>
    /// The time_zone to be used by the database engine (supported only for SQL Server), in SQL Server timezone format.
    /// </summary>
    [TerraformProperty("time_zone")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? TimeZone { get; set; }

    /// <summary>
    /// A set of key/value user label pairs to assign to the instance.
    /// </summary>
    [TerraformProperty("user_labels")]
    // Optional+Computed - source generator will implement get/set
    public TerraformMap<string> UserLabels { get; set; }


}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleSqlDatabaseInstanceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_sql_database_instance resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleSqlDatabaseInstance : TerraformResource
{
    public GoogleSqlDatabaseInstance(string name) : base("google_sql_database_instance", name)
    {
    }

    /// <summary>
    /// The name of the BackupDR backup to restore from.
    /// </summary>
    [TerraformProperty("backupdr_backup")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? BackupdrBackup { get; set; }

    /// <summary>
    /// The MySQL, PostgreSQL or SQL Server (beta) version to use. Supported values include MYSQL_5_6, MYSQL_5_7, MYSQL_8_0, MYSQL_8_4, POSTGRES_9_6, POSTGRES_10, POSTGRES_11, POSTGRES_12, POSTGRES_13, POSTGRES_14, POSTGRES_15, POSTGRES_16, POSTGRES_17, SQLSERVER_2017_STANDARD, SQLSERVER_2017_ENTERPRISE, SQLSERVER_2017_EXPRESS, SQLSERVER_2017_WEB. Database Version Policies includes an up-to-date reference of supported versions.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatabaseVersion is required")]
    [TerraformProperty("database_version")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> DatabaseVersion { get; set; }

    /// <summary>
    /// Used to block Terraform from deleting a SQL Instance. Defaults to true.
    /// </summary>
    [TerraformProperty("deletion_protection")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? DeletionProtection { get; set; }

    /// <summary>
    /// The encryption_key_name attribute.
    /// </summary>
    [TerraformProperty("encryption_key_name")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> EncryptionKeyName { get; set; }

    /// <summary>
    /// The description of final backup if instance enable create final backup during instance deletion. 
    /// </summary>
    [TerraformProperty("final_backup_description")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? FinalBackupDescription { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The type of the instance. See https://cloud.google.com/sql/docs/mysql/admin-api/rest/v1/instances#SqlInstanceType for supported values.
    /// </summary>
    [TerraformProperty("instance_type")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> InstanceType { get; set; }

    /// <summary>
    /// Maintenance version.
    /// </summary>
    [TerraformProperty("maintenance_version")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> MaintenanceVersion { get; set; }

    /// <summary>
    /// The name of the instance that will act as the master in the replication setup. Note, this requires the master to have binary_log_enabled set, as well as existing backups.
    /// </summary>
    [TerraformProperty("master_instance_name")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> MasterInstanceName { get; set; }

    /// <summary>
    /// The name of the instance. If the name is left blank, Terraform will randomly generate one when the instance is first created. This is done because after a name is used, it cannot be reused for up to one week.
    /// </summary>
    [TerraformProperty("name")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Name { get; set; }

    /// <summary>
    /// For a read pool instance, the number of nodes in the read pool. For read pools with auto scaling enabled, this field is read only.
    /// </summary>
    [TerraformProperty("node_count")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<double> NodeCount { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs. If it is not provided, the provider project is used.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Project { get; set; }

    /// <summary>
    /// The region the instance will sit in. Note, Cloud SQL is not available in all regions. A valid region must be provided to use this resource. If a region is not provided in the resource definition, the provider region will be used instead, but this will be an apply-time error for instances if the provider region is not supported with Cloud SQL. If you choose not to provide the region argument for this resource, make sure you understand this.
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The replicas of the instance.
    /// </summary>
    [TerraformProperty("replica_names")]
    // Optional+Computed - source generator will implement get/set
    public TerraformList<string> ReplicaNames { get; set; }

    /// <summary>
    /// Initial root password. Required for MS SQL Server.
    /// </summary>
    [TerraformProperty("root_password")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? RootPassword { get; set; }

    /// <summary>
    /// Block for clone.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Clone block(s) allowed")]
    [TerraformProperty("clone")]
    public TerraformList<TerraformBlock<GoogleSqlDatabaseInstanceCloneBlock>>? Clone { get; set; }

    /// <summary>
    /// Block for point_in_time_restore_context.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PointInTimeRestoreContext block(s) allowed")]
    [TerraformProperty("point_in_time_restore_context")]
    public TerraformList<TerraformBlock<GoogleSqlDatabaseInstancePointInTimeRestoreContextBlock>>? PointInTimeRestoreContext { get; set; }

    /// <summary>
    /// Block for replica_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ReplicaConfiguration block(s) allowed")]
    [TerraformProperty("replica_configuration")]
    public TerraformList<TerraformBlock<GoogleSqlDatabaseInstanceReplicaConfigurationBlock>>? ReplicaConfiguration { get; set; }

    /// <summary>
    /// Block for replication_cluster.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ReplicationCluster block(s) allowed")]
    [TerraformProperty("replication_cluster")]
    public TerraformList<TerraformBlock<GoogleSqlDatabaseInstanceReplicationClusterBlock>>? ReplicationCluster { get; set; }

    /// <summary>
    /// Block for restore_backup_context.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RestoreBackupContext block(s) allowed")]
    [TerraformProperty("restore_backup_context")]
    public TerraformList<TerraformBlock<GoogleSqlDatabaseInstanceRestoreBackupContextBlock>>? RestoreBackupContext { get; set; }

    /// <summary>
    /// Block for settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Settings block(s) allowed")]
    [TerraformProperty("settings")]
    public TerraformList<TerraformBlock<GoogleSqlDatabaseInstanceSettingsBlock>>? Settings { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<GoogleSqlDatabaseInstanceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Available Maintenance versions.
    /// </summary>
    [TerraformProperty("available_maintenance_versions")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> AvailableMaintenanceVersions { get; }

    /// <summary>
    /// The connection name of the instance to be used in connection strings. For example, when connecting with Cloud SQL Proxy.
    /// </summary>
    [TerraformProperty("connection_name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ConnectionName { get; }

    /// <summary>
    /// The instance-level dns name of the instance for PSC instances or public IP CAS instances.
    /// </summary>
    [TerraformProperty("dns_name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> DnsName { get; }

    /// <summary>
    /// The list of DNS names used by this instance. Different connection types for an instance may have different DNS names. DNS names can apply to an individual instance or a cluster of instances.
    /// </summary>
    [TerraformProperty("dns_names")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> DnsNames { get; }

    /// <summary>
    /// The first IPv4 address of any type assigned. This is to support accessing the first address in the list in a terraform output when the resource is configured with a count.
    /// </summary>
    [TerraformProperty("first_ip_address")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> FirstIpAddress { get; }

    /// <summary>
    /// The ip_address attribute.
    /// </summary>
    [TerraformProperty("ip_address")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> IpAddress { get; }

    /// <summary>
    /// IPv4 address assigned. This is a workaround for an issue fixed in Terraform 0.12 but also provides a convenient way to access an IP of a specific type without performing filtering in a Terraform config.
    /// </summary>
    [TerraformProperty("private_ip_address")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> PrivateIpAddress { get; }

    /// <summary>
    /// The link to service attachment of PSC instance.
    /// </summary>
    [TerraformProperty("psc_service_attachment_link")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> PscServiceAttachmentLink { get; }

    /// <summary>
    /// IPv4 address assigned. This is a workaround for an issue fixed in Terraform 0.12 but also provides a convenient way to access an IP of a specific type without performing filtering in a Terraform config.
    /// </summary>
    [TerraformProperty("public_ip_address")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> PublicIpAddress { get; }

    /// <summary>
    /// The URI of the created resource.
    /// </summary>
    [TerraformProperty("self_link")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SelfLink { get; }

    /// <summary>
    /// The server_ca_cert attribute.
    /// </summary>
    [TerraformProperty("server_ca_cert")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> ServerCaCert { get; }

    /// <summary>
    /// The service account email address assigned to the instance.
    /// </summary>
    [TerraformProperty("service_account_email_address")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ServiceAccountEmailAddress { get; }

}
