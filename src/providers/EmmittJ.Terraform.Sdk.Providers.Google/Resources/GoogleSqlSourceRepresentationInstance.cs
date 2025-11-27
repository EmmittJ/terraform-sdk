using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleSqlSourceRepresentationInstance.
/// Nesting mode: single
/// </summary>
public class GoogleSqlSourceRepresentationInstanceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

}


/// <summary>
/// Represents a google_sql_source_representation_instance Terraform resource.
/// Manages a google_sql_source_representation_instance resource.
/// </summary>
public partial class GoogleSqlSourceRepresentationInstance(string name) : TerraformResource("google_sql_source_representation_instance", name)
{
    /// <summary>
    /// The CA certificate on the external server. Include only if SSL/TLS is used on the external server.
    /// </summary>
    public TerraformValue<string>? CaCertificate
    {
        get => new TerraformReference<string>(this, "ca_certificate");
        set => SetArgument("ca_certificate", value);
    }

    /// <summary>
    /// The client certificate on the external server. Required only for server-client authentication. Include only if SSL/TLS is used on the external server.
    /// </summary>
    public TerraformValue<string>? ClientCertificate
    {
        get => new TerraformReference<string>(this, "client_certificate");
        set => SetArgument("client_certificate", value);
    }

    /// <summary>
    /// The private key file for the client certificate on the external server. Required only for server-client authentication. Include only if SSL/TLS is used on the external server.
    /// </summary>
    public TerraformValue<string>? ClientKey
    {
        get => new TerraformReference<string>(this, "client_key");
        set => SetArgument("client_key", value);
    }

    /// <summary>
    /// The MySQL, PostgreSQL or SQL Server (beta) version to use. Supported values include MYSQL_5_6, MYSQL_5_7, MYSQL_8_0, MYSQL_8_4, POSTGRES_9_6, POSTGRES_10, POSTGRES_11, POSTGRES_12, POSTGRES_13, POSTGRES_14, POSTGRES_15, POSTGRES_16, POSTGRES_17. Database Version Policies includes an up-to-date reference of supported versions.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatabaseVersion is required")]
    public required TerraformValue<string> DatabaseVersion
    {
        get => new TerraformReference<string>(this, "database_version");
        set => SetArgument("database_version", value);
    }

    /// <summary>
    /// A file in the bucket that contains the data from the external server.
    /// </summary>
    public TerraformValue<string>? DumpFilePath
    {
        get => new TerraformReference<string>(this, "dump_file_path");
        set => SetArgument("dump_file_path", value);
    }

    /// <summary>
    /// The IPv4 address and port for the external server, or the the DNS address for the external server. If the external server is hosted on Cloud SQL, the port is 5432.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Host is required")]
    public required TerraformValue<string> Host
    {
        get => new TerraformReference<string>(this, "host");
        set => SetArgument("host", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name of the source representation instance. Use any valid Cloud SQL instance name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The password for the replication user account.
    /// </summary>
    public TerraformValue<string>? Password
    {
        get => new TerraformReference<string>(this, "password");
        set => SetArgument("password", value);
    }

    /// <summary>
    /// The externally accessible port for the source database server.
    /// Defaults to 3306.
    /// </summary>
    public TerraformValue<double>? Port
    {
        get => new TerraformReference<double>(this, "port");
        set => SetArgument("port", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => new TerraformReference<string>(this, "project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The Region in which the created instance should reside.
    /// If it is not provided, the provider region is used.
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The replication user account on the external server.
    /// </summary>
    public TerraformValue<string>? Username
    {
        get => new TerraformReference<string>(this, "username");
        set => SetArgument("username", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleSqlSourceRepresentationInstanceTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleSqlSourceRepresentationInstanceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
