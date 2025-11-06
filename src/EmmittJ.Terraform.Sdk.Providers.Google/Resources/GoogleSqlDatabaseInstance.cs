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
    public string? BackupdrBackup
    {
        get => GetProperty<TerraformLiteralProperty<string>>("backupdr_backup")?.Value;
        set => this.WithProperty("backupdr_backup", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The MySQL, PostgreSQL or SQL Server (beta) version to use. Supported values include MYSQL_5_6, MYSQL_5_7, MYSQL_8_0, MYSQL_8_4, POSTGRES_9_6, POSTGRES_10, POSTGRES_11, POSTGRES_12, POSTGRES_13, POSTGRES_14, POSTGRES_15, POSTGRES_16, POSTGRES_17, SQLSERVER_2017_STANDARD, SQLSERVER_2017_ENTERPRISE, SQLSERVER_2017_EXPRESS, SQLSERVER_2017_WEB. Database Version Policies includes an up-to-date reference of supported versions.
    /// </summary>
    public string? DatabaseVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("database_version")?.Value;
        set => this.WithProperty("database_version", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Used to block Terraform from deleting a SQL Instance. Defaults to true.
    /// </summary>
    public bool? DeletionProtection
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("deletion_protection")?.Value;
        set => this.WithProperty("deletion_protection", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The encryption_key_name attribute.
    /// </summary>
    public string? EncryptionKeyName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("encryption_key_name")?.Value;
        set => this.WithProperty("encryption_key_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The description of final backup if instance enable create final backup during instance deletion. 
    /// </summary>
    public string? FinalBackupDescription
    {
        get => GetProperty<TerraformLiteralProperty<string>>("final_backup_description")?.Value;
        set => this.WithProperty("final_backup_description", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The type of the instance. See https://cloud.google.com/sql/docs/mysql/admin-api/rest/v1/instances#SqlInstanceType for supported values.
    /// </summary>
    public string? InstanceType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("instance_type")?.Value;
        set => this.WithProperty("instance_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Maintenance version.
    /// </summary>
    public string? MaintenanceVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("maintenance_version")?.Value;
        set => this.WithProperty("maintenance_version", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name of the instance that will act as the master in the replication setup. Note, this requires the master to have binary_log_enabled set, as well as existing backups.
    /// </summary>
    public string? MasterInstanceName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("master_instance_name")?.Value;
        set => this.WithProperty("master_instance_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name of the instance. If the name is left blank, Terraform will randomly generate one when the instance is first created. This is done because after a name is used, it cannot be reused for up to one week.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// For a read pool instance, the number of nodes in the read pool. For read pools with auto scaling enabled, this field is read only.
    /// </summary>
    public double? NodeCount
    {
        get => GetProperty<TerraformLiteralProperty<double>>("node_count")?.Value;
        set => this.WithProperty("node_count", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The ID of the project in which the resource belongs. If it is not provided, the provider project is used.
    /// </summary>
    public string? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project")?.Value;
        set => this.WithProperty("project", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The region the instance will sit in. Note, Cloud SQL is not available in all regions. A valid region must be provided to use this resource. If a region is not provided in the resource definition, the provider region will be used instead, but this will be an apply-time error for instances if the provider region is not supported with Cloud SQL. If you choose not to provide the region argument for this resource, make sure you understand this.
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The replicas of the instance.
    /// </summary>
    public List<string>? ReplicaNames
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("replica_names")?.Value;
        set => this.WithProperty("replica_names", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// Initial root password. Required for MS SQL Server.
    /// </summary>
    public string? RootPassword
    {
        get => GetProperty<TerraformLiteralProperty<string>>("root_password")?.Value;
        set => this.WithProperty("root_password", value == null ? null : new TerraformLiteralProperty<string>(value));
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
