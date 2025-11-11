using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_sql_database_instance.
/// </summary>
public partial class GoogleSqlDatabaseInstanceDataSource : TerraformDataSource
{
    public GoogleSqlDatabaseInstanceDataSource(string name) : base("google_sql_database_instance", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name of the instance. If the name is left blank, Terraform will randomly generate one when the instance is first created. This is done because after a name is used, it cannot be reused for up to one week.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs. If it is not provided, the provider project is used.
    /// </summary>
    [TerraformProperty("project")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Project { get; set; }

    /// <summary>
    /// Available Maintenance versions.
    /// </summary>
    [TerraformProperty("available_maintenance_versions")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> AvailableMaintenanceVersions { get; }

    /// <summary>
    /// The name of the BackupDR backup to restore from.
    /// </summary>
    [TerraformProperty("backupdr_backup")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> BackupdrBackup { get; }

    /// <summary>
    /// Configuration for creating a new instance as a clone of another instance.
    /// </summary>
    [TerraformProperty("clone")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> Clone { get; }

    /// <summary>
    /// The connection name of the instance to be used in connection strings. For example, when connecting with Cloud SQL Proxy.
    /// </summary>
    [TerraformProperty("connection_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ConnectionName { get; }

    /// <summary>
    /// The MySQL, PostgreSQL or SQL Server (beta) version to use. Supported values include MYSQL_5_6, MYSQL_5_7, MYSQL_8_0, MYSQL_8_4, POSTGRES_9_6, POSTGRES_10, POSTGRES_11, POSTGRES_12, POSTGRES_13, POSTGRES_14, POSTGRES_15, POSTGRES_16, POSTGRES_17, SQLSERVER_2017_STANDARD, SQLSERVER_2017_ENTERPRISE, SQLSERVER_2017_EXPRESS, SQLSERVER_2017_WEB. Database Version Policies includes an up-to-date reference of supported versions.
    /// </summary>
    [TerraformProperty("database_version")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DatabaseVersion { get; }

    /// <summary>
    /// Used to block Terraform from deleting a SQL Instance. Defaults to true.
    /// </summary>
    [TerraformProperty("deletion_protection")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> DeletionProtection { get; }

    /// <summary>
    /// The instance-level dns name of the instance for PSC instances or public IP CAS instances.
    /// </summary>
    [TerraformProperty("dns_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DnsName { get; }

    /// <summary>
    /// The list of DNS names used by this instance. Different connection types for an instance may have different DNS names. DNS names can apply to an individual instance or a cluster of instances.
    /// </summary>
    [TerraformProperty("dns_names")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> DnsNames { get; }

    /// <summary>
    /// The encryption_key_name attribute.
    /// </summary>
    [TerraformProperty("encryption_key_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> EncryptionKeyName { get; }

    /// <summary>
    /// The description of final backup if instance enable create final backup during instance deletion. 
    /// </summary>
    [TerraformProperty("final_backup_description")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> FinalBackupDescription { get; }

    /// <summary>
    /// The first IPv4 address of any type assigned. This is to support accessing the first address in the list in a terraform output when the resource is configured with a count.
    /// </summary>
    [TerraformProperty("first_ip_address")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> FirstIpAddress { get; }

    /// <summary>
    /// The type of the instance. See https://cloud.google.com/sql/docs/mysql/admin-api/rest/v1/instances#SqlInstanceType for supported values.
    /// </summary>
    [TerraformProperty("instance_type")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> InstanceType { get; }

    /// <summary>
    /// The ip_address attribute.
    /// </summary>
    [TerraformProperty("ip_address")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> IpAddress { get; }

    /// <summary>
    /// Maintenance version.
    /// </summary>
    [TerraformProperty("maintenance_version")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> MaintenanceVersion { get; }

    /// <summary>
    /// The name of the instance that will act as the master in the replication setup. Note, this requires the master to have binary_log_enabled set, as well as existing backups.
    /// </summary>
    [TerraformProperty("master_instance_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> MasterInstanceName { get; }

    /// <summary>
    /// For a read pool instance, the number of nodes in the read pool. For read pools with auto scaling enabled, this field is read only.
    /// </summary>
    [TerraformProperty("node_count")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> NodeCount { get; }

    /// <summary>
    /// Configuration for creating a new instance using point-in-time-restore from backupdr backup.
    /// </summary>
    [TerraformProperty("point_in_time_restore_context")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> PointInTimeRestoreContext { get; }

    /// <summary>
    /// IPv4 address assigned. This is a workaround for an issue fixed in Terraform 0.12 but also provides a convenient way to access an IP of a specific type without performing filtering in a Terraform config.
    /// </summary>
    [TerraformProperty("private_ip_address")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PrivateIpAddress { get; }

    /// <summary>
    /// The link to service attachment of PSC instance.
    /// </summary>
    [TerraformProperty("psc_service_attachment_link")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PscServiceAttachmentLink { get; }

    /// <summary>
    /// IPv4 address assigned. This is a workaround for an issue fixed in Terraform 0.12 but also provides a convenient way to access an IP of a specific type without performing filtering in a Terraform config.
    /// </summary>
    [TerraformProperty("public_ip_address")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PublicIpAddress { get; }

    /// <summary>
    /// The region the instance will sit in. Note, Cloud SQL is not available in all regions. A valid region must be provided to use this resource. If a region is not provided in the resource definition, the provider region will be used instead, but this will be an apply-time error for instances if the provider region is not supported with Cloud SQL. If you choose not to provide the region argument for this resource, make sure you understand this.
    /// </summary>
    [TerraformProperty("region")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Region { get; }

    /// <summary>
    /// The configuration for replication.
    /// </summary>
    [TerraformProperty("replica_configuration")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> ReplicaConfiguration { get; }

    /// <summary>
    /// The replicas of the instance.
    /// </summary>
    [TerraformProperty("replica_names")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> ReplicaNames { get; }

    /// <summary>
    /// A primary instance and disaster recovery replica pair. Applicable to MySQL and PostgreSQL. This field can be set only after both the primary and replica are created.
    /// </summary>
    [TerraformProperty("replication_cluster")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> ReplicationCluster { get; }

    /// <summary>
    /// The restore_backup_context attribute.
    /// </summary>
    [TerraformProperty("restore_backup_context")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> RestoreBackupContext { get; }

    /// <summary>
    /// Initial root password. Required for MS SQL Server.
    /// </summary>
    [TerraformProperty("root_password")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> RootPassword { get; }

    /// <summary>
    /// The URI of the created resource.
    /// </summary>
    [TerraformProperty("self_link")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SelfLink { get; }

    /// <summary>
    /// The server_ca_cert attribute.
    /// </summary>
    [TerraformProperty("server_ca_cert")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> ServerCaCert { get; }

    /// <summary>
    /// The service account email address assigned to the instance.
    /// </summary>
    [TerraformProperty("service_account_email_address")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ServiceAccountEmailAddress { get; }

    /// <summary>
    /// The settings to use for the database. The configuration is detailed below.
    /// </summary>
    [TerraformProperty("settings")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> Settings { get; }

}
