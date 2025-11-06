using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_sql_source_representation_instance resource.
/// </summary>
public class GoogleSqlSourceRepresentationInstance : TerraformResource
{
    public GoogleSqlSourceRepresentationInstance(string name) : base("google_sql_source_representation_instance", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The CA certificate on the external server. Include only if SSL/TLS is used on the external server.
    /// </summary>
    public string? CaCertificate
    {
        get => GetProperty<TerraformLiteralProperty<string>>("ca_certificate")?.Value;
        set => this.WithProperty("ca_certificate", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The client certificate on the external server. Required only for server-client authentication. Include only if SSL/TLS is used on the external server.
    /// </summary>
    public string? ClientCertificate
    {
        get => GetProperty<TerraformLiteralProperty<string>>("client_certificate")?.Value;
        set => this.WithProperty("client_certificate", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The private key file for the client certificate on the external server. Required only for server-client authentication. Include only if SSL/TLS is used on the external server.
    /// </summary>
    public string? ClientKey
    {
        get => GetProperty<TerraformLiteralProperty<string>>("client_key")?.Value;
        set => this.WithProperty("client_key", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The MySQL, PostgreSQL or SQL Server (beta) version to use. Supported values include MYSQL_5_6, MYSQL_5_7, MYSQL_8_0, MYSQL_8_4, POSTGRES_9_6, POSTGRES_10, POSTGRES_11, POSTGRES_12, POSTGRES_13, POSTGRES_14, POSTGRES_15, POSTGRES_16, POSTGRES_17. Database Version Policies includes an up-to-date reference of supported versions.
    /// </summary>
    public string? DatabaseVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("database_version")?.Value;
        set => this.WithProperty("database_version", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// A file in the bucket that contains the data from the external server.
    /// </summary>
    public string? DumpFilePath
    {
        get => GetProperty<TerraformLiteralProperty<string>>("dump_file_path")?.Value;
        set => this.WithProperty("dump_file_path", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The IPv4 address and port for the external server, or the the DNS address for the external server. If the external server is hosted on Cloud SQL, the port is 5432.
    /// </summary>
    public string? Host
    {
        get => GetProperty<TerraformLiteralProperty<string>>("host")?.Value;
        set => this.WithProperty("host", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The name of the source representation instance. Use any valid Cloud SQL instance name.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The password for the replication user account.
    /// </summary>
    public string? Password
    {
        get => GetProperty<TerraformLiteralProperty<string>>("password")?.Value;
        set => this.WithProperty("password", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The externally accessible port for the source database server.
    /// Defaults to 3306.
    /// </summary>
    public double? Port
    {
        get => GetProperty<TerraformLiteralProperty<double>>("port")?.Value;
        set => this.WithProperty("port", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public string? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project")?.Value;
        set => this.WithProperty("project", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The Region in which the created instance should reside.
    /// If it is not provided, the provider region is used.
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The replication user account on the external server.
    /// </summary>
    public string? Username
    {
        get => GetProperty<TerraformLiteralProperty<string>>("username")?.Value;
        set => this.WithProperty("username", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
