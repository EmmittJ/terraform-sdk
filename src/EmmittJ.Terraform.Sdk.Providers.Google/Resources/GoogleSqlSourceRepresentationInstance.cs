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
    public TerraformLiteralProperty<string>? CaCertificate
    {
        get => GetProperty<TerraformLiteralProperty<string>>("ca_certificate");
        set => this.WithProperty("ca_certificate", value);
    }

    /// <summary>
    /// The client certificate on the external server. Required only for server-client authentication. Include only if SSL/TLS is used on the external server.
    /// </summary>
    public TerraformLiteralProperty<string>? ClientCertificate
    {
        get => GetProperty<TerraformLiteralProperty<string>>("client_certificate");
        set => this.WithProperty("client_certificate", value);
    }

    /// <summary>
    /// The private key file for the client certificate on the external server. Required only for server-client authentication. Include only if SSL/TLS is used on the external server.
    /// </summary>
    public TerraformLiteralProperty<string>? ClientKey
    {
        get => GetProperty<TerraformLiteralProperty<string>>("client_key");
        set => this.WithProperty("client_key", value);
    }

    /// <summary>
    /// The MySQL, PostgreSQL or SQL Server (beta) version to use. Supported values include MYSQL_5_6, MYSQL_5_7, MYSQL_8_0, MYSQL_8_4, POSTGRES_9_6, POSTGRES_10, POSTGRES_11, POSTGRES_12, POSTGRES_13, POSTGRES_14, POSTGRES_15, POSTGRES_16, POSTGRES_17. Database Version Policies includes an up-to-date reference of supported versions.
    /// </summary>
    public TerraformLiteralProperty<string>? DatabaseVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("database_version");
        set => this.WithProperty("database_version", value);
    }

    /// <summary>
    /// A file in the bucket that contains the data from the external server.
    /// </summary>
    public TerraformLiteralProperty<string>? DumpFilePath
    {
        get => GetProperty<TerraformLiteralProperty<string>>("dump_file_path");
        set => this.WithProperty("dump_file_path", value);
    }

    /// <summary>
    /// The IPv4 address and port for the external server, or the the DNS address for the external server. If the external server is hosted on Cloud SQL, the port is 5432.
    /// </summary>
    public TerraformLiteralProperty<string>? Host
    {
        get => GetProperty<TerraformLiteralProperty<string>>("host");
        set => this.WithProperty("host", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The name of the source representation instance. Use any valid Cloud SQL instance name.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The password for the replication user account.
    /// </summary>
    public TerraformLiteralProperty<string>? Password
    {
        get => GetProperty<TerraformLiteralProperty<string>>("password");
        set => this.WithProperty("password", value);
    }

    /// <summary>
    /// The externally accessible port for the source database server.
    /// Defaults to 3306.
    /// </summary>
    public TerraformLiteralProperty<double>? Port
    {
        get => GetProperty<TerraformLiteralProperty<double>>("port");
        set => this.WithProperty("port", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// The Region in which the created instance should reside.
    /// If it is not provided, the provider region is used.
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The replication user account on the external server.
    /// </summary>
    public TerraformLiteralProperty<string>? Username
    {
        get => GetProperty<TerraformLiteralProperty<string>>("username");
        set => this.WithProperty("username", value);
    }

}
