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
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name of the instance. If the name is left blank, Terraform will randomly generate one when the instance is first created. This is done because after a name is used, it cannot be reused for up to one week.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The ID of the project in which the resource belongs. If it is not provided, the provider project is used.
    /// </summary>
    public TerraformValue<string>? Project
    {
        get => new TerraformReference<string>(this, "project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// Available Maintenance versions.
    /// </summary>
    public TerraformList<string> AvailableMaintenanceVersions
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "available_maintenance_versions").ResolveNodes(ctx));
    }

    /// <summary>
    /// The name of the BackupDR backup to restore from.
    /// </summary>
    public TerraformValue<string> BackupdrBackup
    {
        get => new TerraformReference<string>(this, "backupdr_backup");
    }

    /// <summary>
    /// Configuration for creating a new instance as a clone of another instance.
    /// </summary>
    public TerraformList<TerraformMap<object>> Clone
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "clone").ResolveNodes(ctx));
    }

    /// <summary>
    /// The connection name of the instance to be used in connection strings. For example, when connecting with Cloud SQL Proxy.
    /// </summary>
    public TerraformValue<string> ConnectionName
    {
        get => new TerraformReference<string>(this, "connection_name");
    }

    /// <summary>
    /// The MySQL, PostgreSQL or SQL Server (beta) version to use. Supported values include MYSQL_5_6, MYSQL_5_7, MYSQL_8_0, MYSQL_8_4, POSTGRES_9_6, POSTGRES_10, POSTGRES_11, POSTGRES_12, POSTGRES_13, POSTGRES_14, POSTGRES_15, POSTGRES_16, POSTGRES_17, SQLSERVER_2017_STANDARD, SQLSERVER_2017_ENTERPRISE, SQLSERVER_2017_EXPRESS, SQLSERVER_2017_WEB. Database Version Policies includes an up-to-date reference of supported versions.
    /// </summary>
    public TerraformValue<string> DatabaseVersion
    {
        get => new TerraformReference<string>(this, "database_version");
    }

    /// <summary>
    /// Used to block Terraform from deleting a SQL Instance. Defaults to true.
    /// </summary>
    public TerraformValue<bool> DeletionProtection
    {
        get => new TerraformReference<bool>(this, "deletion_protection");
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
    /// The encryption_key_name attribute.
    /// </summary>
    public TerraformValue<string> EncryptionKeyName
    {
        get => new TerraformReference<string>(this, "encryption_key_name");
    }

    /// <summary>
    /// The description of final backup if instance enable create final backup during instance deletion. 
    /// </summary>
    public TerraformValue<string> FinalBackupDescription
    {
        get => new TerraformReference<string>(this, "final_backup_description");
    }

    /// <summary>
    /// The first IPv4 address of any type assigned. This is to support accessing the first address in the list in a terraform output when the resource is configured with a count.
    /// </summary>
    public TerraformValue<string> FirstIpAddress
    {
        get => new TerraformReference<string>(this, "first_ip_address");
    }

    /// <summary>
    /// The type of the instance. See https://cloud.google.com/sql/docs/mysql/admin-api/rest/v1/instances#SqlInstanceType for supported values.
    /// </summary>
    public TerraformValue<string> InstanceType
    {
        get => new TerraformReference<string>(this, "instance_type");
    }

    /// <summary>
    /// The ip_address attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> IpAddress
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "ip_address").ResolveNodes(ctx));
    }

    /// <summary>
    /// Maintenance version.
    /// </summary>
    public TerraformValue<string> MaintenanceVersion
    {
        get => new TerraformReference<string>(this, "maintenance_version");
    }

    /// <summary>
    /// The name of the instance that will act as the master in the replication setup. Note, this requires the master to have binary_log_enabled set, as well as existing backups.
    /// </summary>
    public TerraformValue<string> MasterInstanceName
    {
        get => new TerraformReference<string>(this, "master_instance_name");
    }

    /// <summary>
    /// For a read pool instance, the number of nodes in the read pool. For read pools with auto scaling enabled, this field is read only.
    /// </summary>
    public TerraformValue<double> NodeCount
    {
        get => new TerraformReference<double>(this, "node_count");
    }

    /// <summary>
    /// Configuration for creating a new instance using point-in-time-restore from backupdr backup.
    /// </summary>
    public TerraformList<TerraformMap<object>> PointInTimeRestoreContext
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "point_in_time_restore_context").ResolveNodes(ctx));
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
    /// The region the instance will sit in. Note, Cloud SQL is not available in all regions. A valid region must be provided to use this resource. If a region is not provided in the resource definition, the provider region will be used instead, but this will be an apply-time error for instances if the provider region is not supported with Cloud SQL. If you choose not to provide the region argument for this resource, make sure you understand this.
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
    }

    /// <summary>
    /// The configuration for replication.
    /// </summary>
    public TerraformList<TerraformMap<object>> ReplicaConfiguration
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "replica_configuration").ResolveNodes(ctx));
    }

    /// <summary>
    /// The replicas of the instance.
    /// </summary>
    public TerraformList<string> ReplicaNames
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "replica_names").ResolveNodes(ctx));
    }

    /// <summary>
    /// A primary instance and disaster recovery replica pair. Applicable to MySQL and PostgreSQL. This field can be set only after both the primary and replica are created.
    /// </summary>
    public TerraformList<TerraformMap<object>> ReplicationCluster
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "replication_cluster").ResolveNodes(ctx));
    }

    /// <summary>
    /// The restore_backup_context attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> RestoreBackupContext
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "restore_backup_context").ResolveNodes(ctx));
    }

    /// <summary>
    /// Initial root password. Required for MS SQL Server.
    /// </summary>
    public TerraformValue<string> RootPassword
    {
        get => new TerraformReference<string>(this, "root_password");
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
    /// The settings to use for the database. The configuration is detailed below.
    /// </summary>
    public TerraformList<TerraformMap<object>> Settings
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "settings").ResolveNodes(ctx));
    }

}
