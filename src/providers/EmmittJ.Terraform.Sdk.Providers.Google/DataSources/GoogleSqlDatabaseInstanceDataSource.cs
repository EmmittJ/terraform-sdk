using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_sql_database_instance Terraform data source.
/// Retrieves information about a google_sql_database_instance.
/// </summary>
public partial class GoogleSqlDatabaseInstanceDataSource(string name) : TerraformDataSource("google_sql_database_instance", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name of the instance. If the name is left blank, Terraform will randomly generate one when the instance is first created. This is done because after a name is used, it cannot be reused for up to one week.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The ID of the project in which the resource belongs. If it is not provided, the provider project is used.
    /// </summary>
    public TerraformValue<string>? Project
    {
        get => GetArgument<TerraformValue<string>>("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// Available Maintenance versions.
    /// </summary>
    public TerraformList<string> AvailableMaintenanceVersions
        => CreateReference("available_maintenance_versions");

    /// <summary>
    /// The name of the BackupDR backup to restore from.
    /// </summary>
    public TerraformValue<string> BackupdrBackup
        => CreateReference("backupdr_backup");

    /// <summary>
    /// Configuration for creating a new instance as a clone of another instance.
    /// </summary>
    public TerraformList<TerraformMap<object>> Clone
        => CreateReference("clone");

    /// <summary>
    /// The connection name of the instance to be used in connection strings. For example, when connecting with Cloud SQL Proxy.
    /// </summary>
    public TerraformValue<string> ConnectionName
        => CreateReference("connection_name");

    /// <summary>
    /// The MySQL, PostgreSQL or SQL Server (beta) version to use. Supported values include MYSQL_5_6, MYSQL_5_7, MYSQL_8_0, MYSQL_8_4, POSTGRES_9_6, POSTGRES_10, POSTGRES_11, POSTGRES_12, POSTGRES_13, POSTGRES_14, POSTGRES_15, POSTGRES_16, POSTGRES_17, SQLSERVER_2017_STANDARD, SQLSERVER_2017_ENTERPRISE, SQLSERVER_2017_EXPRESS, SQLSERVER_2017_WEB. Database Version Policies includes an up-to-date reference of supported versions.
    /// </summary>
    public TerraformValue<string> DatabaseVersion
        => CreateReference("database_version");

    /// <summary>
    /// Used to block Terraform from deleting a SQL Instance. Defaults to true.
    /// </summary>
    public TerraformValue<bool> DeletionProtection
        => CreateReference("deletion_protection");

    /// <summary>
    /// The instance-level dns name of the instance for PSC instances or public IP CAS instances.
    /// </summary>
    public TerraformValue<string> DnsName
        => CreateReference("dns_name");

    /// <summary>
    /// The list of DNS names used by this instance. Different connection types for an instance may have different DNS names. DNS names can apply to an individual instance or a cluster of instances.
    /// </summary>
    public TerraformList<TerraformMap<object>> DnsNames
        => CreateReference("dns_names");

    /// <summary>
    /// The encryption_key_name attribute.
    /// </summary>
    public TerraformValue<string> EncryptionKeyName
        => CreateReference("encryption_key_name");

    /// <summary>
    /// The description of final backup if instance enable create final backup during instance deletion. 
    /// </summary>
    public TerraformValue<string> FinalBackupDescription
        => CreateReference("final_backup_description");

    /// <summary>
    /// The first IPv4 address of any type assigned. This is to support accessing the first address in the list in a terraform output when the resource is configured with a count.
    /// </summary>
    public TerraformValue<string> FirstIpAddress
        => CreateReference("first_ip_address");

    /// <summary>
    /// The type of the instance. See https://cloud.google.com/sql/docs/mysql/admin-api/rest/v1/instances#SqlInstanceType for supported values.
    /// </summary>
    public TerraformValue<string> InstanceType
        => CreateReference("instance_type");

    /// <summary>
    /// The ip_address attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> IpAddress
        => CreateReference("ip_address");

    /// <summary>
    /// Maintenance version.
    /// </summary>
    public TerraformValue<string> MaintenanceVersion
        => CreateReference("maintenance_version");

    /// <summary>
    /// The name of the instance that will act as the master in the replication setup. Note, this requires the master to have binary_log_enabled set, as well as existing backups.
    /// </summary>
    public TerraformValue<string> MasterInstanceName
        => CreateReference("master_instance_name");

    /// <summary>
    /// For a read pool instance, the number of nodes in the read pool. For read pools with auto scaling enabled, this field is read only.
    /// </summary>
    public TerraformValue<double> NodeCount
        => CreateReference("node_count");

    /// <summary>
    /// Configuration for creating a new instance using point-in-time-restore from backupdr backup.
    /// </summary>
    public TerraformList<TerraformMap<object>> PointInTimeRestoreContext
        => CreateReference("point_in_time_restore_context");

    /// <summary>
    /// IPv4 address assigned. This is a workaround for an issue fixed in Terraform 0.12 but also provides a convenient way to access an IP of a specific type without performing filtering in a Terraform config.
    /// </summary>
    public TerraformValue<string> PrivateIpAddress
        => CreateReference("private_ip_address");

    /// <summary>
    /// The link to service attachment of PSC instance.
    /// </summary>
    public TerraformValue<string> PscServiceAttachmentLink
        => CreateReference("psc_service_attachment_link");

    /// <summary>
    /// IPv4 address assigned. This is a workaround for an issue fixed in Terraform 0.12 but also provides a convenient way to access an IP of a specific type without performing filtering in a Terraform config.
    /// </summary>
    public TerraformValue<string> PublicIpAddress
        => CreateReference("public_ip_address");

    /// <summary>
    /// The region the instance will sit in. Note, Cloud SQL is not available in all regions. A valid region must be provided to use this resource. If a region is not provided in the resource definition, the provider region will be used instead, but this will be an apply-time error for instances if the provider region is not supported with Cloud SQL. If you choose not to provide the region argument for this resource, make sure you understand this.
    /// </summary>
    public TerraformValue<string> Region
        => CreateReference("region");

    /// <summary>
    /// The configuration for replication.
    /// </summary>
    public TerraformList<TerraformMap<object>> ReplicaConfiguration
        => CreateReference("replica_configuration");

    /// <summary>
    /// The replicas of the instance.
    /// </summary>
    public TerraformList<string> ReplicaNames
        => CreateReference("replica_names");

    /// <summary>
    /// A primary instance and disaster recovery replica pair. Applicable to MySQL and PostgreSQL. This field can be set only after both the primary and replica are created.
    /// </summary>
    public TerraformList<TerraformMap<object>> ReplicationCluster
        => CreateReference("replication_cluster");

    /// <summary>
    /// The restore_backup_context attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> RestoreBackupContext
        => CreateReference("restore_backup_context");

    /// <summary>
    /// Initial root password. Required for MS SQL Server.
    /// </summary>
    public TerraformValue<string> RootPassword
        => CreateReference("root_password");

    /// <summary>
    /// The URI of the created resource.
    /// </summary>
    public TerraformValue<string> SelfLink
        => CreateReference("self_link");

    /// <summary>
    /// The server_ca_cert attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> ServerCaCert
        => CreateReference("server_ca_cert");

    /// <summary>
    /// The service account email address assigned to the instance.
    /// </summary>
    public TerraformValue<string> ServiceAccountEmailAddress
        => CreateReference("service_account_email_address");

    /// <summary>
    /// The settings to use for the database. The configuration is detailed below.
    /// </summary>
    public TerraformList<TerraformMap<object>> Settings
        => CreateReference("settings");

}
