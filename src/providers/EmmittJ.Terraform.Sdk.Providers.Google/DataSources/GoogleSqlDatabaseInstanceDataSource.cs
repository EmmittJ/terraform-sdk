using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_sql_database_instance.
/// </summary>
public class GoogleSqlDatabaseInstanceDataSource : TerraformDataSource
{
    public GoogleSqlDatabaseInstanceDataSource(string name) : base("google_sql_database_instance", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The name of the instance. If the name is left blank, Terraform will randomly generate one when the instance is first created. This is done because after a name is used, it cannot be reused for up to one week.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs. If it is not provided, the provider project is used.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Project { get; set; }

    /// <summary>
    /// Available Maintenance versions.
    /// </summary>
    [TerraformPropertyName("available_maintenance_versions")]
    // Output-only attribute - read-only reference
    public TerraformList<string> AvailableMaintenanceVersions => new TerraformReference(this, "available_maintenance_versions");

    /// <summary>
    /// The name of the BackupDR backup to restore from.
    /// </summary>
    [TerraformPropertyName("backupdr_backup")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> BackupdrBackup => new TerraformReference(this, "backupdr_backup");

    /// <summary>
    /// Configuration for creating a new instance as a clone of another instance.
    /// </summary>
    [TerraformPropertyName("clone")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Clone => new TerraformReference(this, "clone");

    /// <summary>
    /// The connection name of the instance to be used in connection strings. For example, when connecting with Cloud SQL Proxy.
    /// </summary>
    [TerraformPropertyName("connection_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ConnectionName => new TerraformReference(this, "connection_name");

    /// <summary>
    /// The MySQL, PostgreSQL or SQL Server (beta) version to use. Supported values include MYSQL_5_6, MYSQL_5_7, MYSQL_8_0, MYSQL_8_4, POSTGRES_9_6, POSTGRES_10, POSTGRES_11, POSTGRES_12, POSTGRES_13, POSTGRES_14, POSTGRES_15, POSTGRES_16, POSTGRES_17, SQLSERVER_2017_STANDARD, SQLSERVER_2017_ENTERPRISE, SQLSERVER_2017_EXPRESS, SQLSERVER_2017_WEB. Database Version Policies includes an up-to-date reference of supported versions.
    /// </summary>
    [TerraformPropertyName("database_version")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DatabaseVersion => new TerraformReference(this, "database_version");

    /// <summary>
    /// Used to block Terraform from deleting a SQL Instance. Defaults to true.
    /// </summary>
    [TerraformPropertyName("deletion_protection")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> DeletionProtection => new TerraformReference(this, "deletion_protection");

    /// <summary>
    /// The instance-level dns name of the instance for PSC instances or public IP CAS instances.
    /// </summary>
    [TerraformPropertyName("dns_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DnsName => new TerraformReference(this, "dns_name");

    /// <summary>
    /// The list of DNS names used by this instance. Different connection types for an instance may have different DNS names. DNS names can apply to an individual instance or a cluster of instances.
    /// </summary>
    [TerraformPropertyName("dns_names")]
    // Output-only attribute - read-only reference
    public TerraformList<object> DnsNames => new TerraformReference(this, "dns_names");

    /// <summary>
    /// The encryption_key_name attribute.
    /// </summary>
    [TerraformPropertyName("encryption_key_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> EncryptionKeyName => new TerraformReference(this, "encryption_key_name");

    /// <summary>
    /// The description of final backup if instance enable create final backup during instance deletion. 
    /// </summary>
    [TerraformPropertyName("final_backup_description")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> FinalBackupDescription => new TerraformReference(this, "final_backup_description");

    /// <summary>
    /// The first IPv4 address of any type assigned. This is to support accessing the first address in the list in a terraform output when the resource is configured with a count.
    /// </summary>
    [TerraformPropertyName("first_ip_address")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> FirstIpAddress => new TerraformReference(this, "first_ip_address");

    /// <summary>
    /// The type of the instance. See https://cloud.google.com/sql/docs/mysql/admin-api/rest/v1/instances#SqlInstanceType for supported values.
    /// </summary>
    [TerraformPropertyName("instance_type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> InstanceType => new TerraformReference(this, "instance_type");

    /// <summary>
    /// The ip_address attribute.
    /// </summary>
    [TerraformPropertyName("ip_address")]
    // Output-only attribute - read-only reference
    public TerraformList<object> IpAddress => new TerraformReference(this, "ip_address");

    /// <summary>
    /// Maintenance version.
    /// </summary>
    [TerraformPropertyName("maintenance_version")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> MaintenanceVersion => new TerraformReference(this, "maintenance_version");

    /// <summary>
    /// The name of the instance that will act as the master in the replication setup. Note, this requires the master to have binary_log_enabled set, as well as existing backups.
    /// </summary>
    [TerraformPropertyName("master_instance_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> MasterInstanceName => new TerraformReference(this, "master_instance_name");

    /// <summary>
    /// For a read pool instance, the number of nodes in the read pool. For read pools with auto scaling enabled, this field is read only.
    /// </summary>
    [TerraformPropertyName("node_count")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> NodeCount => new TerraformReference(this, "node_count");

    /// <summary>
    /// Configuration for creating a new instance using point-in-time-restore from backupdr backup.
    /// </summary>
    [TerraformPropertyName("point_in_time_restore_context")]
    // Output-only attribute - read-only reference
    public TerraformList<object> PointInTimeRestoreContext => new TerraformReference(this, "point_in_time_restore_context");

    /// <summary>
    /// IPv4 address assigned. This is a workaround for an issue fixed in Terraform 0.12 but also provides a convenient way to access an IP of a specific type without performing filtering in a Terraform config.
    /// </summary>
    [TerraformPropertyName("private_ip_address")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PrivateIpAddress => new TerraformReference(this, "private_ip_address");

    /// <summary>
    /// The link to service attachment of PSC instance.
    /// </summary>
    [TerraformPropertyName("psc_service_attachment_link")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PscServiceAttachmentLink => new TerraformReference(this, "psc_service_attachment_link");

    /// <summary>
    /// IPv4 address assigned. This is a workaround for an issue fixed in Terraform 0.12 but also provides a convenient way to access an IP of a specific type without performing filtering in a Terraform config.
    /// </summary>
    [TerraformPropertyName("public_ip_address")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PublicIpAddress => new TerraformReference(this, "public_ip_address");

    /// <summary>
    /// The region the instance will sit in. Note, Cloud SQL is not available in all regions. A valid region must be provided to use this resource. If a region is not provided in the resource definition, the provider region will be used instead, but this will be an apply-time error for instances if the provider region is not supported with Cloud SQL. If you choose not to provide the region argument for this resource, make sure you understand this.
    /// </summary>
    [TerraformPropertyName("region")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Region => new TerraformReference(this, "region");

    /// <summary>
    /// The configuration for replication.
    /// </summary>
    [TerraformPropertyName("replica_configuration")]
    // Output-only attribute - read-only reference
    public TerraformList<object> ReplicaConfiguration => new TerraformReference(this, "replica_configuration");

    /// <summary>
    /// The replicas of the instance.
    /// </summary>
    [TerraformPropertyName("replica_names")]
    // Output-only attribute - read-only reference
    public TerraformList<string> ReplicaNames => new TerraformReference(this, "replica_names");

    /// <summary>
    /// A primary instance and disaster recovery replica pair. Applicable to MySQL and PostgreSQL. This field can be set only after both the primary and replica are created.
    /// </summary>
    [TerraformPropertyName("replication_cluster")]
    // Output-only attribute - read-only reference
    public TerraformList<object> ReplicationCluster => new TerraformReference(this, "replication_cluster");

    /// <summary>
    /// The restore_backup_context attribute.
    /// </summary>
    [TerraformPropertyName("restore_backup_context")]
    // Output-only attribute - read-only reference
    public TerraformList<object> RestoreBackupContext => new TerraformReference(this, "restore_backup_context");

    /// <summary>
    /// Initial root password. Required for MS SQL Server.
    /// </summary>
    [TerraformPropertyName("root_password")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> RootPassword => new TerraformReference(this, "root_password");

    /// <summary>
    /// The URI of the created resource.
    /// </summary>
    [TerraformPropertyName("self_link")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SelfLink => new TerraformReference(this, "self_link");

    /// <summary>
    /// The server_ca_cert attribute.
    /// </summary>
    [TerraformPropertyName("server_ca_cert")]
    // Output-only attribute - read-only reference
    public TerraformList<object> ServerCaCert => new TerraformReference(this, "server_ca_cert");

    /// <summary>
    /// The service account email address assigned to the instance.
    /// </summary>
    [TerraformPropertyName("service_account_email_address")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ServiceAccountEmailAddress => new TerraformReference(this, "service_account_email_address");

    /// <summary>
    /// The settings to use for the database. The configuration is detailed below.
    /// </summary>
    [TerraformPropertyName("settings")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Settings => new TerraformReference(this, "settings");

}
