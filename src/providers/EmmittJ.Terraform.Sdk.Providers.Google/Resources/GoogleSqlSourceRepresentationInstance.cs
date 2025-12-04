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
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
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
        get => GetArgument<TerraformValue<string>>("ca_certificate");
        set => SetArgument("ca_certificate", value);
    }

    /// <summary>
    /// The client certificate on the external server. Required only for server-client authentication. Include only if SSL/TLS is used on the external server.
    /// </summary>
    public TerraformValue<string>? ClientCertificate
    {
        get => GetArgument<TerraformValue<string>>("client_certificate");
        set => SetArgument("client_certificate", value);
    }

    /// <summary>
    /// The private key file for the client certificate on the external server. Required only for server-client authentication. Include only if SSL/TLS is used on the external server.
    /// </summary>
    public TerraformValue<string>? ClientKey
    {
        get => GetArgument<TerraformValue<string>>("client_key");
        set => SetArgument("client_key", value);
    }

    /// <summary>
    /// The MySQL, PostgreSQL or SQL Server (beta) version to use. Supported values include MYSQL_5_6, MYSQL_5_7, MYSQL_8_0, MYSQL_8_4, POSTGRES_9_6, POSTGRES_10, POSTGRES_11, POSTGRES_12, POSTGRES_13, POSTGRES_14, POSTGRES_15, POSTGRES_16, POSTGRES_17. Database Version Policies includes an up-to-date reference of supported versions.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatabaseVersion is required")]
    public required TerraformValue<string> DatabaseVersion
    {
        get => GetArgument<TerraformValue<string>>("database_version");
        set => SetArgument("database_version", value);
    }

    /// <summary>
    /// A file in the bucket that contains the data from the external server.
    /// </summary>
    public TerraformValue<string>? DumpFilePath
    {
        get => GetArgument<TerraformValue<string>>("dump_file_path");
        set => SetArgument("dump_file_path", value);
    }

    /// <summary>
    /// The IPv4 address and port for the external server, or the the DNS address for the external server. If the external server is hosted on Cloud SQL, the port is 5432.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Host is required")]
    public required TerraformValue<string> Host
    {
        get => GetArgument<TerraformValue<string>>("host");
        set => SetArgument("host", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name of the source representation instance. Use any valid Cloud SQL instance name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The password for the replication user account.
    /// </summary>
    public TerraformValue<string>? Password
    {
        get => GetArgument<TerraformValue<string>>("password");
        set => SetArgument("password", value);
    }

    /// <summary>
    /// The externally accessible port for the source database server.
    /// Defaults to 3306.
    /// </summary>
    public TerraformValue<double>? Port
    {
        get => GetArgument<TerraformValue<double>>("port");
        set => SetArgument("port", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string>? Project
    {
        get => GetArgument<TerraformValue<string>>("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The Region in which the created instance should reside.
    /// If it is not provided, the provider region is used.
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The replication user account on the external server.
    /// </summary>
    public TerraformValue<string>? Username
    {
        get => GetArgument<TerraformValue<string>>("username");
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
