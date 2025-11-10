using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleSqlSourceRepresentationInstanceTimeoutsBlock : TerraformBlock
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

}

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
        SetOutput("ca_certificate");
        SetOutput("client_certificate");
        SetOutput("client_key");
        SetOutput("database_version");
        SetOutput("dump_file_path");
        SetOutput("host");
        SetOutput("id");
        SetOutput("name");
        SetOutput("password");
        SetOutput("port");
        SetOutput("project");
        SetOutput("region");
        SetOutput("username");
    }

    /// <summary>
    /// The CA certificate on the external server. Include only if SSL/TLS is used on the external server.
    /// </summary>
    public TerraformProperty<string> CaCertificate
    {
        get => GetRequiredOutput<TerraformProperty<string>>("ca_certificate");
        set => SetProperty("ca_certificate", value);
    }

    /// <summary>
    /// The client certificate on the external server. Required only for server-client authentication. Include only if SSL/TLS is used on the external server.
    /// </summary>
    public TerraformProperty<string> ClientCertificate
    {
        get => GetRequiredOutput<TerraformProperty<string>>("client_certificate");
        set => SetProperty("client_certificate", value);
    }

    /// <summary>
    /// The private key file for the client certificate on the external server. Required only for server-client authentication. Include only if SSL/TLS is used on the external server.
    /// </summary>
    public TerraformProperty<string> ClientKey
    {
        get => GetRequiredOutput<TerraformProperty<string>>("client_key");
        set => SetProperty("client_key", value);
    }

    /// <summary>
    /// The MySQL, PostgreSQL or SQL Server (beta) version to use. Supported values include MYSQL_5_6, MYSQL_5_7, MYSQL_8_0, MYSQL_8_4, POSTGRES_9_6, POSTGRES_10, POSTGRES_11, POSTGRES_12, POSTGRES_13, POSTGRES_14, POSTGRES_15, POSTGRES_16, POSTGRES_17. Database Version Policies includes an up-to-date reference of supported versions.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatabaseVersion is required")]
    public required TerraformProperty<string> DatabaseVersion
    {
        get => GetRequiredOutput<TerraformProperty<string>>("database_version");
        set => SetProperty("database_version", value);
    }

    /// <summary>
    /// A file in the bucket that contains the data from the external server.
    /// </summary>
    public TerraformProperty<string> DumpFilePath
    {
        get => GetRequiredOutput<TerraformProperty<string>>("dump_file_path");
        set => SetProperty("dump_file_path", value);
    }

    /// <summary>
    /// The IPv4 address and port for the external server, or the the DNS address for the external server. If the external server is hosted on Cloud SQL, the port is 5432.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Host is required")]
    public required TerraformProperty<string> Host
    {
        get => GetRequiredOutput<TerraformProperty<string>>("host");
        set => SetProperty("host", value);
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
    /// The name of the source representation instance. Use any valid Cloud SQL instance name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The password for the replication user account.
    /// </summary>
    public TerraformProperty<string> Password
    {
        get => GetRequiredOutput<TerraformProperty<string>>("password");
        set => SetProperty("password", value);
    }

    /// <summary>
    /// The externally accessible port for the source database server.
    /// Defaults to 3306.
    /// </summary>
    public TerraformProperty<double> Port
    {
        get => GetRequiredOutput<TerraformProperty<double>>("port");
        set => SetProperty("port", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
    }

    /// <summary>
    /// The Region in which the created instance should reside.
    /// If it is not provided, the provider region is used.
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The replication user account on the external server.
    /// </summary>
    public TerraformProperty<string> Username
    {
        get => GetRequiredOutput<TerraformProperty<string>>("username");
        set => SetProperty("username", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleSqlSourceRepresentationInstanceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
