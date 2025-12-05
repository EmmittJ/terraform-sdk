using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for bigquery_profile in GoogleDatastreamConnectionProfile.
/// Nesting mode: list
/// </summary>
public class GoogleDatastreamConnectionProfileBigqueryProfileBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "bigquery_profile";

}


/// <summary>
/// Block type for forward_ssh_connectivity in GoogleDatastreamConnectionProfile.
/// Nesting mode: list
/// </summary>
public class GoogleDatastreamConnectionProfileForwardSshConnectivityBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "forward_ssh_connectivity";

    /// <summary>
    /// Hostname for the SSH tunnel.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Hostname is required")]
    public required TerraformValue<string> Hostname
    {
        get => GetRequiredArgument<TerraformValue<string>>("hostname");
        set => SetArgument("hostname", value);
    }

    /// <summary>
    /// SSH password.
    /// </summary>
    public TerraformValue<string>? Password
    {
        get => GetArgument<TerraformValue<string>>("password");
        set => SetArgument("password", value);
    }

    /// <summary>
    /// Port for the SSH tunnel.
    /// </summary>
    public TerraformValue<double>? Port
    {
        get => GetArgument<TerraformValue<double>>("port");
        set => SetArgument("port", value);
    }

    /// <summary>
    /// SSH private key.
    /// </summary>
    public TerraformValue<string>? PrivateKey
    {
        get => GetArgument<TerraformValue<string>>("private_key");
        set => SetArgument("private_key", value);
    }

    /// <summary>
    /// Username for the SSH tunnel.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Username is required")]
    public required TerraformValue<string> Username
    {
        get => GetRequiredArgument<TerraformValue<string>>("username");
        set => SetArgument("username", value);
    }

}


/// <summary>
/// Block type for gcs_profile in GoogleDatastreamConnectionProfile.
/// Nesting mode: list
/// </summary>
public class GoogleDatastreamConnectionProfileGcsProfileBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "gcs_profile";

    /// <summary>
    /// The Cloud Storage bucket name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bucket is required")]
    public required TerraformValue<string> Bucket
    {
        get => GetRequiredArgument<TerraformValue<string>>("bucket");
        set => SetArgument("bucket", value);
    }

    /// <summary>
    /// The root path inside the Cloud Storage bucket.
    /// </summary>
    public TerraformValue<string>? RootPath
    {
        get => GetArgument<TerraformValue<string>>("root_path");
        set => SetArgument("root_path", value);
    }

}


/// <summary>
/// Block type for mongodb_profile in GoogleDatastreamConnectionProfile.
/// Nesting mode: list
/// </summary>
public class GoogleDatastreamConnectionProfileMongodbProfileBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "mongodb_profile";

    /// <summary>
    /// Password for the MongoDB connection. Mutually exclusive with
    /// secretManagerStoredPassword.
    /// </summary>
    public TerraformValue<string>? Password
    {
        get => GetArgument<TerraformValue<string>>("password");
        set => SetArgument("password", value);
    }

    /// <summary>
    /// Name of the replica set.
    /// </summary>
    public TerraformValue<string>? ReplicaSet
    {
        get => GetArgument<TerraformValue<string>>("replica_set");
        set => SetArgument("replica_set", value);
    }

    /// <summary>
    /// A reference to a Secret Manager resource name storing the MongoDB
    /// connection password. Mutually exclusive with password.
    /// </summary>
    public TerraformValue<string>? SecretManagerStoredPassword
    {
        get => GetArgument<TerraformValue<string>>("secret_manager_stored_password");
        set => SetArgument("secret_manager_stored_password", value);
    }

    /// <summary>
    /// Username for the MongoDB connection.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Username is required")]
    public required TerraformValue<string> Username
    {
        get => GetRequiredArgument<TerraformValue<string>>("username");
        set => SetArgument("username", value);
    }

    /// <summary>
    /// HostAddresses block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HostAddresses is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 HostAddresses block(s) required")]
    public required TerraformList<GoogleDatastreamConnectionProfileMongodbProfileBlockHostAddressesBlock> HostAddresses
    {
        get => GetRequiredArgument<TerraformList<GoogleDatastreamConnectionProfileMongodbProfileBlockHostAddressesBlock>>("host_addresses");
        set => SetArgument("host_addresses", value);
    }

    /// <summary>
    /// SrvConnectionFormat block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SrvConnectionFormat block(s) allowed")]
    public TerraformList<GoogleDatastreamConnectionProfileMongodbProfileBlockSrvConnectionFormatBlock>? SrvConnectionFormat
    {
        get => GetArgument<TerraformList<GoogleDatastreamConnectionProfileMongodbProfileBlockSrvConnectionFormatBlock>>("srv_connection_format");
        set => SetArgument("srv_connection_format", value);
    }

    /// <summary>
    /// SslConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SslConfig block(s) allowed")]
    public TerraformList<GoogleDatastreamConnectionProfileMongodbProfileBlockSslConfigBlock>? SslConfig
    {
        get => GetArgument<TerraformList<GoogleDatastreamConnectionProfileMongodbProfileBlockSslConfigBlock>>("ssl_config");
        set => SetArgument("ssl_config", value);
    }

    /// <summary>
    /// StandardConnectionFormat block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StandardConnectionFormat block(s) allowed")]
    public TerraformList<GoogleDatastreamConnectionProfileMongodbProfileBlockStandardConnectionFormatBlock>? StandardConnectionFormat
    {
        get => GetArgument<TerraformList<GoogleDatastreamConnectionProfileMongodbProfileBlockStandardConnectionFormatBlock>>("standard_connection_format");
        set => SetArgument("standard_connection_format", value);
    }

}

/// <summary>
/// Block type for host_addresses in GoogleDatastreamConnectionProfileMongodbProfileBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDatastreamConnectionProfileMongodbProfileBlockHostAddressesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "host_addresses";

    /// <summary>
    /// Hostname for the connection.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Hostname is required")]
    public required TerraformValue<string> Hostname
    {
        get => GetRequiredArgument<TerraformValue<string>>("hostname");
        set => SetArgument("hostname", value);
    }

    /// <summary>
    /// Port for the connection.
    /// </summary>
    public TerraformValue<double>? Port
    {
        get => GetArgument<TerraformValue<double>>("port");
        set => SetArgument("port", value);
    }

}

/// <summary>
/// Block type for srv_connection_format in GoogleDatastreamConnectionProfileMongodbProfileBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDatastreamConnectionProfileMongodbProfileBlockSrvConnectionFormatBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "srv_connection_format";

}

/// <summary>
/// Block type for ssl_config in GoogleDatastreamConnectionProfileMongodbProfileBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDatastreamConnectionProfileMongodbProfileBlockSslConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ssl_config";

    /// <summary>
    /// PEM-encoded certificate of the CA that signed the source database
    /// server&#39;s certificate.
    /// </summary>
    public TerraformValue<string>? CaCertificate
    {
        get => GetArgument<TerraformValue<string>>("ca_certificate");
        set => SetArgument("ca_certificate", value);
    }

    /// <summary>
    /// Indicates whether the clientKey field is set.
    /// </summary>
    public TerraformValue<bool> CaCertificateSet
        => CreateReference("ca_certificate_set");

    /// <summary>
    /// PEM-encoded certificate that will be used by the replica to
    /// authenticate against the source database server. If this field
    /// is used then the &#39;clientKey&#39; and the &#39;caCertificate&#39; fields are
    /// mandatory.
    /// </summary>
    public TerraformValue<string>? ClientCertificate
    {
        get => GetArgument<TerraformValue<string>>("client_certificate");
        set => SetArgument("client_certificate", value);
    }

    /// <summary>
    /// Indicates whether the clientCertificate field is set.
    /// </summary>
    public TerraformValue<bool> ClientCertificateSet
        => CreateReference("client_certificate_set");

    /// <summary>
    /// PEM-encoded private key associated with the Client Certificate.
    /// If this field is used then the &#39;client_certificate&#39; and the
    /// &#39;ca_certificate&#39; fields are mandatory.
    /// </summary>
    public TerraformValue<string>? ClientKey
    {
        get => GetArgument<TerraformValue<string>>("client_key");
        set => SetArgument("client_key", value);
    }

    /// <summary>
    /// Indicates whether the clientKey field is set.
    /// </summary>
    public TerraformValue<bool> ClientKeySet
        => CreateReference("client_key_set");

    /// <summary>
    /// A reference to a Secret Manager resource name storing the
    /// PEM-encoded private key. Mutually exclusive with clientKey.
    /// </summary>
    public TerraformValue<string>? SecretManagerStoredClientKey
    {
        get => GetArgument<TerraformValue<string>>("secret_manager_stored_client_key");
        set => SetArgument("secret_manager_stored_client_key", value);
    }

}

/// <summary>
/// Block type for standard_connection_format in GoogleDatastreamConnectionProfileMongodbProfileBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDatastreamConnectionProfileMongodbProfileBlockStandardConnectionFormatBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "standard_connection_format";

    /// <summary>
    /// Specifies whether the client connects directly to the
    /// host[:port] in the connection URI.
    /// </summary>
    public TerraformValue<bool>? DirectConnection
    {
        get => GetArgument<TerraformValue<bool>>("direct_connection");
        set => SetArgument("direct_connection", value);
    }

}


/// <summary>
/// Block type for mysql_profile in GoogleDatastreamConnectionProfile.
/// Nesting mode: list
/// </summary>
public class GoogleDatastreamConnectionProfileMysqlProfileBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "mysql_profile";

    /// <summary>
    /// Hostname for the MySQL connection.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Hostname is required")]
    public required TerraformValue<string> Hostname
    {
        get => GetRequiredArgument<TerraformValue<string>>("hostname");
        set => SetArgument("hostname", value);
    }

    /// <summary>
    /// Password for the MySQL connection.
    /// </summary>
    public TerraformValue<string>? Password
    {
        get => GetArgument<TerraformValue<string>>("password");
        set => SetArgument("password", value);
    }

    /// <summary>
    /// Port for the MySQL connection.
    /// </summary>
    public TerraformValue<double>? Port
    {
        get => GetArgument<TerraformValue<double>>("port");
        set => SetArgument("port", value);
    }

    /// <summary>
    /// A reference to a Secret Manager resource name storing the user&#39;s password.
    /// </summary>
    public TerraformValue<string>? SecretManagerStoredPassword
    {
        get => GetArgument<TerraformValue<string>>("secret_manager_stored_password");
        set => SetArgument("secret_manager_stored_password", value);
    }

    /// <summary>
    /// Username for the MySQL connection.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Username is required")]
    public required TerraformValue<string> Username
    {
        get => GetRequiredArgument<TerraformValue<string>>("username");
        set => SetArgument("username", value);
    }

    /// <summary>
    /// SslConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SslConfig block(s) allowed")]
    public TerraformList<GoogleDatastreamConnectionProfileMysqlProfileBlockSslConfigBlock>? SslConfig
    {
        get => GetArgument<TerraformList<GoogleDatastreamConnectionProfileMysqlProfileBlockSslConfigBlock>>("ssl_config");
        set => SetArgument("ssl_config", value);
    }

}

/// <summary>
/// Block type for ssl_config in GoogleDatastreamConnectionProfileMysqlProfileBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDatastreamConnectionProfileMysqlProfileBlockSslConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ssl_config";

    /// <summary>
    /// PEM-encoded certificate of the CA that signed the source database
    /// server&#39;s certificate.
    /// </summary>
    public TerraformValue<string>? CaCertificate
    {
        get => GetArgument<TerraformValue<string>>("ca_certificate");
        set => SetArgument("ca_certificate", value);
    }

    /// <summary>
    /// Indicates whether the clientKey field is set.
    /// </summary>
    public TerraformValue<bool> CaCertificateSet
        => CreateReference("ca_certificate_set");

    /// <summary>
    /// PEM-encoded certificate that will be used by the replica to
    /// authenticate against the source database server. If this field
    /// is used then the &#39;clientKey&#39; and the &#39;caCertificate&#39; fields are
    /// mandatory.
    /// </summary>
    public TerraformValue<string>? ClientCertificate
    {
        get => GetArgument<TerraformValue<string>>("client_certificate");
        set => SetArgument("client_certificate", value);
    }

    /// <summary>
    /// Indicates whether the clientCertificate field is set.
    /// </summary>
    public TerraformValue<bool> ClientCertificateSet
        => CreateReference("client_certificate_set");

    /// <summary>
    /// PEM-encoded private key associated with the Client Certificate.
    /// If this field is used then the &#39;client_certificate&#39; and the
    /// &#39;ca_certificate&#39; fields are mandatory.
    /// </summary>
    public TerraformValue<string>? ClientKey
    {
        get => GetArgument<TerraformValue<string>>("client_key");
        set => SetArgument("client_key", value);
    }

    /// <summary>
    /// Indicates whether the clientKey field is set.
    /// </summary>
    public TerraformValue<bool> ClientKeySet
        => CreateReference("client_key_set");

}


/// <summary>
/// Block type for oracle_profile in GoogleDatastreamConnectionProfile.
/// Nesting mode: list
/// </summary>
public class GoogleDatastreamConnectionProfileOracleProfileBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "oracle_profile";

    /// <summary>
    /// Connection string attributes
    /// </summary>
    public TerraformMap<string>? ConnectionAttributes
    {
        get => GetArgument<TerraformMap<string>>("connection_attributes");
        set => SetArgument("connection_attributes", value);
    }

    /// <summary>
    /// Database for the Oracle connection.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatabaseService is required")]
    public required TerraformValue<string> DatabaseService
    {
        get => GetRequiredArgument<TerraformValue<string>>("database_service");
        set => SetArgument("database_service", value);
    }

    /// <summary>
    /// Hostname for the Oracle connection.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Hostname is required")]
    public required TerraformValue<string> Hostname
    {
        get => GetRequiredArgument<TerraformValue<string>>("hostname");
        set => SetArgument("hostname", value);
    }

    /// <summary>
    /// Password for the Oracle connection.
    /// </summary>
    public TerraformValue<string>? Password
    {
        get => GetArgument<TerraformValue<string>>("password");
        set => SetArgument("password", value);
    }

    /// <summary>
    /// Port for the Oracle connection.
    /// </summary>
    public TerraformValue<double>? Port
    {
        get => GetArgument<TerraformValue<double>>("port");
        set => SetArgument("port", value);
    }

    /// <summary>
    /// A reference to a Secret Manager resource name storing the user&#39;s password.
    /// </summary>
    public TerraformValue<string>? SecretManagerStoredPassword
    {
        get => GetArgument<TerraformValue<string>>("secret_manager_stored_password");
        set => SetArgument("secret_manager_stored_password", value);
    }

    /// <summary>
    /// Username for the Oracle connection.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Username is required")]
    public required TerraformValue<string> Username
    {
        get => GetRequiredArgument<TerraformValue<string>>("username");
        set => SetArgument("username", value);
    }

}


/// <summary>
/// Block type for postgresql_profile in GoogleDatastreamConnectionProfile.
/// Nesting mode: list
/// </summary>
public class GoogleDatastreamConnectionProfilePostgresqlProfileBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "postgresql_profile";

    /// <summary>
    /// Database for the PostgreSQL connection.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Database is required")]
    public required TerraformValue<string> Database
    {
        get => GetRequiredArgument<TerraformValue<string>>("database");
        set => SetArgument("database", value);
    }

    /// <summary>
    /// Hostname for the PostgreSQL connection.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Hostname is required")]
    public required TerraformValue<string> Hostname
    {
        get => GetRequiredArgument<TerraformValue<string>>("hostname");
        set => SetArgument("hostname", value);
    }

    /// <summary>
    /// Password for the PostgreSQL connection.
    /// </summary>
    public TerraformValue<string>? Password
    {
        get => GetArgument<TerraformValue<string>>("password");
        set => SetArgument("password", value);
    }

    /// <summary>
    /// Port for the PostgreSQL connection.
    /// </summary>
    public TerraformValue<double>? Port
    {
        get => GetArgument<TerraformValue<double>>("port");
        set => SetArgument("port", value);
    }

    /// <summary>
    /// A reference to a Secret Manager resource name storing the user&#39;s password.
    /// </summary>
    public TerraformValue<string>? SecretManagerStoredPassword
    {
        get => GetArgument<TerraformValue<string>>("secret_manager_stored_password");
        set => SetArgument("secret_manager_stored_password", value);
    }

    /// <summary>
    /// Username for the PostgreSQL connection.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Username is required")]
    public required TerraformValue<string> Username
    {
        get => GetRequiredArgument<TerraformValue<string>>("username");
        set => SetArgument("username", value);
    }

}


/// <summary>
/// Block type for private_connectivity in GoogleDatastreamConnectionProfile.
/// Nesting mode: list
/// </summary>
public class GoogleDatastreamConnectionProfilePrivateConnectivityBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "private_connectivity";

    /// <summary>
    /// A reference to a private connection resource. Format: &#39;projects/{project}/locations/{location}/privateConnections/{name}&#39;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrivateConnection is required")]
    public required TerraformValue<string> PrivateConnection
    {
        get => GetRequiredArgument<TerraformValue<string>>("private_connection");
        set => SetArgument("private_connection", value);
    }

}


/// <summary>
/// Block type for sql_server_profile in GoogleDatastreamConnectionProfile.
/// Nesting mode: list
/// </summary>
public class GoogleDatastreamConnectionProfileSqlServerProfileBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "sql_server_profile";

    /// <summary>
    /// Database for the SQL Server connection.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Database is required")]
    public required TerraformValue<string> Database
    {
        get => GetRequiredArgument<TerraformValue<string>>("database");
        set => SetArgument("database", value);
    }

    /// <summary>
    /// Hostname for the SQL Server connection.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Hostname is required")]
    public required TerraformValue<string> Hostname
    {
        get => GetRequiredArgument<TerraformValue<string>>("hostname");
        set => SetArgument("hostname", value);
    }

    /// <summary>
    /// Password for the SQL Server connection.
    /// </summary>
    public TerraformValue<string>? Password
    {
        get => GetArgument<TerraformValue<string>>("password");
        set => SetArgument("password", value);
    }

    /// <summary>
    /// Port for the SQL Server connection.
    /// </summary>
    public TerraformValue<double>? Port
    {
        get => GetArgument<TerraformValue<double>>("port");
        set => SetArgument("port", value);
    }

    /// <summary>
    /// A reference to a Secret Manager resource name storing the user&#39;s password.
    /// </summary>
    public TerraformValue<string>? SecretManagerStoredPassword
    {
        get => GetArgument<TerraformValue<string>>("secret_manager_stored_password");
        set => SetArgument("secret_manager_stored_password", value);
    }

    /// <summary>
    /// Username for the SQL Server connection.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Username is required")]
    public required TerraformValue<string> Username
    {
        get => GetRequiredArgument<TerraformValue<string>>("username");
        set => SetArgument("username", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleDatastreamConnectionProfile.
/// Nesting mode: single
/// </summary>
public class GoogleDatastreamConnectionProfileTimeoutsBlock : TerraformBlock
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

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_datastream_connection_profile Terraform resource.
/// Manages a google_datastream_connection_profile resource.
/// </summary>
public partial class GoogleDatastreamConnectionProfile(string name) : TerraformResource("google_datastream_connection_profile", name)
{
    /// <summary>
    /// The connection profile identifier.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectionProfileId is required")]
    public required TerraformValue<string> ConnectionProfileId
    {
        get => GetRequiredArgument<TerraformValue<string>>("connection_profile_id");
        set => SetArgument("connection_profile_id", value);
    }

    /// <summary>
    /// Create the connection profile without validating it.
    /// </summary>
    public TerraformValue<bool>? CreateWithoutValidation
    {
        get => GetArgument<TerraformValue<bool>>("create_without_validation");
        set => SetArgument("create_without_validation", value);
    }

    /// <summary>
    /// Display name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformValue<string> DisplayName
    {
        get => GetRequiredArgument<TerraformValue<string>>("display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Labels.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformMap<string>? Labels
    {
        get => GetArgument<TerraformMap<string>>("labels");
        set => SetArgument("labels", value);
    }

    /// <summary>
    /// The name of the location this connection profile is located in.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetRequiredArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => GetArgument<TerraformValue<string>>("project") ?? CreateReference("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
        => CreateReference("effective_labels");

    /// <summary>
    /// The resource&#39;s name.
    /// </summary>
    public TerraformValue<string> Name
        => CreateReference("name");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
        => CreateReference("terraform_labels");

    /// <summary>
    /// BigqueryProfile block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BigqueryProfile block(s) allowed")]
    public TerraformList<GoogleDatastreamConnectionProfileBigqueryProfileBlock>? BigqueryProfile
    {
        get => GetArgument<TerraformList<GoogleDatastreamConnectionProfileBigqueryProfileBlock>>("bigquery_profile");
        set => SetArgument("bigquery_profile", value);
    }

    /// <summary>
    /// ForwardSshConnectivity block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ForwardSshConnectivity block(s) allowed")]
    public TerraformList<GoogleDatastreamConnectionProfileForwardSshConnectivityBlock>? ForwardSshConnectivity
    {
        get => GetArgument<TerraformList<GoogleDatastreamConnectionProfileForwardSshConnectivityBlock>>("forward_ssh_connectivity");
        set => SetArgument("forward_ssh_connectivity", value);
    }

    /// <summary>
    /// GcsProfile block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GcsProfile block(s) allowed")]
    public TerraformList<GoogleDatastreamConnectionProfileGcsProfileBlock>? GcsProfile
    {
        get => GetArgument<TerraformList<GoogleDatastreamConnectionProfileGcsProfileBlock>>("gcs_profile");
        set => SetArgument("gcs_profile", value);
    }

    /// <summary>
    /// MongodbProfile block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MongodbProfile block(s) allowed")]
    public TerraformList<GoogleDatastreamConnectionProfileMongodbProfileBlock>? MongodbProfile
    {
        get => GetArgument<TerraformList<GoogleDatastreamConnectionProfileMongodbProfileBlock>>("mongodb_profile");
        set => SetArgument("mongodb_profile", value);
    }

    /// <summary>
    /// MysqlProfile block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MysqlProfile block(s) allowed")]
    public TerraformList<GoogleDatastreamConnectionProfileMysqlProfileBlock>? MysqlProfile
    {
        get => GetArgument<TerraformList<GoogleDatastreamConnectionProfileMysqlProfileBlock>>("mysql_profile");
        set => SetArgument("mysql_profile", value);
    }

    /// <summary>
    /// OracleProfile block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OracleProfile block(s) allowed")]
    public TerraformList<GoogleDatastreamConnectionProfileOracleProfileBlock>? OracleProfile
    {
        get => GetArgument<TerraformList<GoogleDatastreamConnectionProfileOracleProfileBlock>>("oracle_profile");
        set => SetArgument("oracle_profile", value);
    }

    /// <summary>
    /// PostgresqlProfile block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PostgresqlProfile block(s) allowed")]
    public TerraformList<GoogleDatastreamConnectionProfilePostgresqlProfileBlock>? PostgresqlProfile
    {
        get => GetArgument<TerraformList<GoogleDatastreamConnectionProfilePostgresqlProfileBlock>>("postgresql_profile");
        set => SetArgument("postgresql_profile", value);
    }

    /// <summary>
    /// PrivateConnectivity block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PrivateConnectivity block(s) allowed")]
    public TerraformList<GoogleDatastreamConnectionProfilePrivateConnectivityBlock>? PrivateConnectivity
    {
        get => GetArgument<TerraformList<GoogleDatastreamConnectionProfilePrivateConnectivityBlock>>("private_connectivity");
        set => SetArgument("private_connectivity", value);
    }

    /// <summary>
    /// SqlServerProfile block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SqlServerProfile block(s) allowed")]
    public TerraformList<GoogleDatastreamConnectionProfileSqlServerProfileBlock>? SqlServerProfile
    {
        get => GetArgument<TerraformList<GoogleDatastreamConnectionProfileSqlServerProfileBlock>>("sql_server_profile");
        set => SetArgument("sql_server_profile", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleDatastreamConnectionProfileTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleDatastreamConnectionProfileTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
