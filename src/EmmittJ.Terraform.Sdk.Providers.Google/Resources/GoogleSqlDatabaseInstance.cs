using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_sql_database_instance resource.
/// </summary>
public class GoogleSqlDatabaseInstance : TerraformResource
{
    public GoogleSqlDatabaseInstance(string name) : base("google_sql_database_instance", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("available_maintenance_versions");
        this.DeclareOutput("connection_name");
        this.DeclareOutput("dns_name");
        this.DeclareOutput("dns_names");
        this.DeclareOutput("first_ip_address");
        this.DeclareOutput("ip_address");
        this.DeclareOutput("private_ip_address");
        this.DeclareOutput("psc_service_attachment_link");
        this.DeclareOutput("public_ip_address");
        this.DeclareOutput("self_link");
        this.DeclareOutput("server_ca_cert");
        this.DeclareOutput("service_account_email_address");
    }

    /// <summary>
    /// The name of the BackupDR backup to restore from.
    /// </summary>
    public TerraformProperty<string>? BackupdrBackup
    {
        get => GetProperty<TerraformProperty<string>>("backupdr_backup");
        set => this.WithProperty("backupdr_backup", value);
    }

    /// <summary>
    /// The MySQL, PostgreSQL or SQL Server (beta) version to use. Supported values include MYSQL_5_6, MYSQL_5_7, MYSQL_8_0, MYSQL_8_4, POSTGRES_9_6, POSTGRES_10, POSTGRES_11, POSTGRES_12, POSTGRES_13, POSTGRES_14, POSTGRES_15, POSTGRES_16, POSTGRES_17, SQLSERVER_2017_STANDARD, SQLSERVER_2017_ENTERPRISE, SQLSERVER_2017_EXPRESS, SQLSERVER_2017_WEB. Database Version Policies includes an up-to-date reference of supported versions.
    /// </summary>
    public TerraformProperty<string>? DatabaseVersion
    {
        get => GetProperty<TerraformProperty<string>>("database_version");
        set => this.WithProperty("database_version", value);
    }

    /// <summary>
    /// Used to block Terraform from deleting a SQL Instance. Defaults to true.
    /// </summary>
    public TerraformProperty<bool>? DeletionProtection
    {
        get => GetProperty<TerraformProperty<bool>>("deletion_protection");
        set => this.WithProperty("deletion_protection", value);
    }

    /// <summary>
    /// The encryption_key_name attribute.
    /// </summary>
    public TerraformProperty<string>? EncryptionKeyName
    {
        get => GetProperty<TerraformProperty<string>>("encryption_key_name");
        set => this.WithProperty("encryption_key_name", value);
    }

    /// <summary>
    /// The description of final backup if instance enable create final backup during instance deletion. 
    /// </summary>
    public TerraformProperty<string>? FinalBackupDescription
    {
        get => GetProperty<TerraformProperty<string>>("final_backup_description");
        set => this.WithProperty("final_backup_description", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The type of the instance. See https://cloud.google.com/sql/docs/mysql/admin-api/rest/v1/instances#SqlInstanceType for supported values.
    /// </summary>
    public TerraformProperty<string>? InstanceType
    {
        get => GetProperty<TerraformProperty<string>>("instance_type");
        set => this.WithProperty("instance_type", value);
    }

    /// <summary>
    /// Maintenance version.
    /// </summary>
    public TerraformProperty<string>? MaintenanceVersion
    {
        get => GetProperty<TerraformProperty<string>>("maintenance_version");
        set => this.WithProperty("maintenance_version", value);
    }

    /// <summary>
    /// The name of the instance that will act as the master in the replication setup. Note, this requires the master to have binary_log_enabled set, as well as existing backups.
    /// </summary>
    public TerraformProperty<string>? MasterInstanceName
    {
        get => GetProperty<TerraformProperty<string>>("master_instance_name");
        set => this.WithProperty("master_instance_name", value);
    }

    /// <summary>
    /// The name of the instance. If the name is left blank, Terraform will randomly generate one when the instance is first created. This is done because after a name is used, it cannot be reused for up to one week.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// For a read pool instance, the number of nodes in the read pool. For read pools with auto scaling enabled, this field is read only.
    /// </summary>
    public TerraformProperty<double>? NodeCount
    {
        get => GetProperty<TerraformProperty<double>>("node_count");
        set => this.WithProperty("node_count", value);
    }

    /// <summary>
    /// The ID of the project in which the resource belongs. If it is not provided, the provider project is used.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// The region the instance will sit in. Note, Cloud SQL is not available in all regions. A valid region must be provided to use this resource. If a region is not provided in the resource definition, the provider region will be used instead, but this will be an apply-time error for instances if the provider region is not supported with Cloud SQL. If you choose not to provide the region argument for this resource, make sure you understand this.
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The replicas of the instance.
    /// </summary>
    public TerraformProperty<List<string>>? ReplicaNames
    {
        get => GetProperty<TerraformProperty<List<string>>>("replica_names");
        set => this.WithProperty("replica_names", value);
    }

    /// <summary>
    /// Initial root password. Required for MS SQL Server.
    /// </summary>
    public TerraformProperty<string>? RootPassword
    {
        get => GetProperty<TerraformProperty<string>>("root_password");
        set => this.WithProperty("root_password", value);
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
