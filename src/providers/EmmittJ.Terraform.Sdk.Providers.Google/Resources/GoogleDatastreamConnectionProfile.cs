using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for bigquery_profile in .
/// Nesting mode: list
/// </summary>
public class GoogleDatastreamConnectionProfileBigqueryProfileBlock : TerraformBlock
{
}

/// <summary>
/// Block type for forward_ssh_connectivity in .
/// Nesting mode: list
/// </summary>
public class GoogleDatastreamConnectionProfileForwardSshConnectivityBlock : TerraformBlock
{
    /// <summary>
    /// Hostname for the SSH tunnel.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Hostname is required")]
    public required TerraformProperty<string> Hostname
    {
        get => GetRequiredProperty<TerraformProperty<string>>("hostname");
        set => WithProperty("hostname", value);
    }

    /// <summary>
    /// SSH password.
    /// </summary>
    public TerraformProperty<string>? Password
    {
        get => GetProperty<TerraformProperty<string>>("password");
        set => WithProperty("password", value);
    }

    /// <summary>
    /// Port for the SSH tunnel.
    /// </summary>
    public TerraformProperty<double>? Port
    {
        get => GetProperty<TerraformProperty<double>>("port");
        set => WithProperty("port", value);
    }

    /// <summary>
    /// SSH private key.
    /// </summary>
    public TerraformProperty<string>? PrivateKey
    {
        get => GetProperty<TerraformProperty<string>>("private_key");
        set => WithProperty("private_key", value);
    }

    /// <summary>
    /// Username for the SSH tunnel.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Username is required")]
    public required TerraformProperty<string> Username
    {
        get => GetRequiredProperty<TerraformProperty<string>>("username");
        set => WithProperty("username", value);
    }

}

/// <summary>
/// Block type for gcs_profile in .
/// Nesting mode: list
/// </summary>
public class GoogleDatastreamConnectionProfileGcsProfileBlock : TerraformBlock
{
    /// <summary>
    /// The Cloud Storage bucket name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bucket is required")]
    public required TerraformProperty<string> Bucket
    {
        get => GetRequiredProperty<TerraformProperty<string>>("bucket");
        set => WithProperty("bucket", value);
    }

    /// <summary>
    /// The root path inside the Cloud Storage bucket.
    /// </summary>
    public TerraformProperty<string>? RootPath
    {
        get => GetProperty<TerraformProperty<string>>("root_path");
        set => WithProperty("root_path", value);
    }

}

/// <summary>
/// Block type for mongodb_profile in .
/// Nesting mode: list
/// </summary>
public class GoogleDatastreamConnectionProfileMongodbProfileBlock : TerraformBlock
{
    /// <summary>
    /// Password for the MongoDB connection. Mutually exclusive with
    /// secretManagerStoredPassword.
    /// </summary>
    public TerraformProperty<string>? Password
    {
        get => GetProperty<TerraformProperty<string>>("password");
        set => WithProperty("password", value);
    }

    /// <summary>
    /// Name of the replica set.
    /// </summary>
    public TerraformProperty<string>? ReplicaSet
    {
        get => GetProperty<TerraformProperty<string>>("replica_set");
        set => WithProperty("replica_set", value);
    }

    /// <summary>
    /// A reference to a Secret Manager resource name storing the MongoDB
    /// connection password. Mutually exclusive with password.
    /// </summary>
    public TerraformProperty<string>? SecretManagerStoredPassword
    {
        get => GetProperty<TerraformProperty<string>>("secret_manager_stored_password");
        set => WithProperty("secret_manager_stored_password", value);
    }

    /// <summary>
    /// Username for the MongoDB connection.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Username is required")]
    public required TerraformProperty<string> Username
    {
        get => GetRequiredProperty<TerraformProperty<string>>("username");
        set => WithProperty("username", value);
    }

}

/// <summary>
/// Block type for mysql_profile in .
/// Nesting mode: list
/// </summary>
public class GoogleDatastreamConnectionProfileMysqlProfileBlock : TerraformBlock
{
    /// <summary>
    /// Hostname for the MySQL connection.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Hostname is required")]
    public required TerraformProperty<string> Hostname
    {
        get => GetRequiredProperty<TerraformProperty<string>>("hostname");
        set => WithProperty("hostname", value);
    }

    /// <summary>
    /// Password for the MySQL connection.
    /// </summary>
    public TerraformProperty<string>? Password
    {
        get => GetProperty<TerraformProperty<string>>("password");
        set => WithProperty("password", value);
    }

    /// <summary>
    /// Port for the MySQL connection.
    /// </summary>
    public TerraformProperty<double>? Port
    {
        get => GetProperty<TerraformProperty<double>>("port");
        set => WithProperty("port", value);
    }

    /// <summary>
    /// A reference to a Secret Manager resource name storing the user&#39;s password.
    /// </summary>
    public TerraformProperty<string>? SecretManagerStoredPassword
    {
        get => GetProperty<TerraformProperty<string>>("secret_manager_stored_password");
        set => WithProperty("secret_manager_stored_password", value);
    }

    /// <summary>
    /// Username for the MySQL connection.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Username is required")]
    public required TerraformProperty<string> Username
    {
        get => GetRequiredProperty<TerraformProperty<string>>("username");
        set => WithProperty("username", value);
    }

}

/// <summary>
/// Block type for oracle_profile in .
/// Nesting mode: list
/// </summary>
public class GoogleDatastreamConnectionProfileOracleProfileBlock : TerraformBlock
{
    /// <summary>
    /// Connection string attributes
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? ConnectionAttributes
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("connection_attributes");
        set => WithProperty("connection_attributes", value);
    }

    /// <summary>
    /// Database for the Oracle connection.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatabaseService is required")]
    public required TerraformProperty<string> DatabaseService
    {
        get => GetRequiredProperty<TerraformProperty<string>>("database_service");
        set => WithProperty("database_service", value);
    }

    /// <summary>
    /// Hostname for the Oracle connection.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Hostname is required")]
    public required TerraformProperty<string> Hostname
    {
        get => GetRequiredProperty<TerraformProperty<string>>("hostname");
        set => WithProperty("hostname", value);
    }

    /// <summary>
    /// Password for the Oracle connection.
    /// </summary>
    public TerraformProperty<string>? Password
    {
        get => GetProperty<TerraformProperty<string>>("password");
        set => WithProperty("password", value);
    }

    /// <summary>
    /// Port for the Oracle connection.
    /// </summary>
    public TerraformProperty<double>? Port
    {
        get => GetProperty<TerraformProperty<double>>("port");
        set => WithProperty("port", value);
    }

    /// <summary>
    /// A reference to a Secret Manager resource name storing the user&#39;s password.
    /// </summary>
    public TerraformProperty<string>? SecretManagerStoredPassword
    {
        get => GetProperty<TerraformProperty<string>>("secret_manager_stored_password");
        set => WithProperty("secret_manager_stored_password", value);
    }

    /// <summary>
    /// Username for the Oracle connection.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Username is required")]
    public required TerraformProperty<string> Username
    {
        get => GetRequiredProperty<TerraformProperty<string>>("username");
        set => WithProperty("username", value);
    }

}

/// <summary>
/// Block type for postgresql_profile in .
/// Nesting mode: list
/// </summary>
public class GoogleDatastreamConnectionProfilePostgresqlProfileBlock : TerraformBlock
{
    /// <summary>
    /// Database for the PostgreSQL connection.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Database is required")]
    public required TerraformProperty<string> Database
    {
        get => GetRequiredProperty<TerraformProperty<string>>("database");
        set => WithProperty("database", value);
    }

    /// <summary>
    /// Hostname for the PostgreSQL connection.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Hostname is required")]
    public required TerraformProperty<string> Hostname
    {
        get => GetRequiredProperty<TerraformProperty<string>>("hostname");
        set => WithProperty("hostname", value);
    }

    /// <summary>
    /// Password for the PostgreSQL connection.
    /// </summary>
    public TerraformProperty<string>? Password
    {
        get => GetProperty<TerraformProperty<string>>("password");
        set => WithProperty("password", value);
    }

    /// <summary>
    /// Port for the PostgreSQL connection.
    /// </summary>
    public TerraformProperty<double>? Port
    {
        get => GetProperty<TerraformProperty<double>>("port");
        set => WithProperty("port", value);
    }

    /// <summary>
    /// A reference to a Secret Manager resource name storing the user&#39;s password.
    /// </summary>
    public TerraformProperty<string>? SecretManagerStoredPassword
    {
        get => GetProperty<TerraformProperty<string>>("secret_manager_stored_password");
        set => WithProperty("secret_manager_stored_password", value);
    }

    /// <summary>
    /// Username for the PostgreSQL connection.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Username is required")]
    public required TerraformProperty<string> Username
    {
        get => GetRequiredProperty<TerraformProperty<string>>("username");
        set => WithProperty("username", value);
    }

}

/// <summary>
/// Block type for private_connectivity in .
/// Nesting mode: list
/// </summary>
public class GoogleDatastreamConnectionProfilePrivateConnectivityBlock : TerraformBlock
{
    /// <summary>
    /// A reference to a private connection resource. Format: &#39;projects/{project}/locations/{location}/privateConnections/{name}&#39;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrivateConnection is required")]
    public required TerraformProperty<string> PrivateConnection
    {
        get => GetRequiredProperty<TerraformProperty<string>>("private_connection");
        set => WithProperty("private_connection", value);
    }

}

/// <summary>
/// Block type for sql_server_profile in .
/// Nesting mode: list
/// </summary>
public class GoogleDatastreamConnectionProfileSqlServerProfileBlock : TerraformBlock
{
    /// <summary>
    /// Database for the SQL Server connection.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Database is required")]
    public required TerraformProperty<string> Database
    {
        get => GetRequiredProperty<TerraformProperty<string>>("database");
        set => WithProperty("database", value);
    }

    /// <summary>
    /// Hostname for the SQL Server connection.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Hostname is required")]
    public required TerraformProperty<string> Hostname
    {
        get => GetRequiredProperty<TerraformProperty<string>>("hostname");
        set => WithProperty("hostname", value);
    }

    /// <summary>
    /// Password for the SQL Server connection.
    /// </summary>
    public TerraformProperty<string>? Password
    {
        get => GetProperty<TerraformProperty<string>>("password");
        set => WithProperty("password", value);
    }

    /// <summary>
    /// Port for the SQL Server connection.
    /// </summary>
    public TerraformProperty<double>? Port
    {
        get => GetProperty<TerraformProperty<double>>("port");
        set => WithProperty("port", value);
    }

    /// <summary>
    /// A reference to a Secret Manager resource name storing the user&#39;s password.
    /// </summary>
    public TerraformProperty<string>? SecretManagerStoredPassword
    {
        get => GetProperty<TerraformProperty<string>>("secret_manager_stored_password");
        set => WithProperty("secret_manager_stored_password", value);
    }

    /// <summary>
    /// Username for the SQL Server connection.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Username is required")]
    public required TerraformProperty<string> Username
    {
        get => GetRequiredProperty<TerraformProperty<string>>("username");
        set => WithProperty("username", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleDatastreamConnectionProfileTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a google_datastream_connection_profile resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleDatastreamConnectionProfile : TerraformResource
{
    public GoogleDatastreamConnectionProfile(string name) : base("google_datastream_connection_profile", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("effective_labels");
        this.WithOutput("name");
        this.WithOutput("terraform_labels");
    }

    /// <summary>
    /// The connection profile identifier.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectionProfileId is required")]
    public required TerraformProperty<string> ConnectionProfileId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("connection_profile_id");
        set => this.WithProperty("connection_profile_id", value);
    }

    /// <summary>
    /// Create the connection profile without validating it.
    /// </summary>
    public TerraformProperty<bool>? CreateWithoutValidation
    {
        get => GetProperty<TerraformProperty<bool>>("create_without_validation");
        set => this.WithProperty("create_without_validation", value);
    }

    /// <summary>
    /// Display name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformProperty<string> DisplayName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
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
    /// Labels.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Labels
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("labels");
        set => this.WithProperty("labels", value);
    }

    /// <summary>
    /// The name of the location this connection profile is located in.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// Block for bigquery_profile.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BigqueryProfile block(s) allowed")]
    public List<GoogleDatastreamConnectionProfileBigqueryProfileBlock>? BigqueryProfile
    {
        get => GetProperty<List<GoogleDatastreamConnectionProfileBigqueryProfileBlock>>("bigquery_profile");
        set => this.WithProperty("bigquery_profile", value);
    }

    /// <summary>
    /// Block for forward_ssh_connectivity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ForwardSshConnectivity block(s) allowed")]
    public List<GoogleDatastreamConnectionProfileForwardSshConnectivityBlock>? ForwardSshConnectivity
    {
        get => GetProperty<List<GoogleDatastreamConnectionProfileForwardSshConnectivityBlock>>("forward_ssh_connectivity");
        set => this.WithProperty("forward_ssh_connectivity", value);
    }

    /// <summary>
    /// Block for gcs_profile.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GcsProfile block(s) allowed")]
    public List<GoogleDatastreamConnectionProfileGcsProfileBlock>? GcsProfile
    {
        get => GetProperty<List<GoogleDatastreamConnectionProfileGcsProfileBlock>>("gcs_profile");
        set => this.WithProperty("gcs_profile", value);
    }

    /// <summary>
    /// Block for mongodb_profile.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MongodbProfile block(s) allowed")]
    public List<GoogleDatastreamConnectionProfileMongodbProfileBlock>? MongodbProfile
    {
        get => GetProperty<List<GoogleDatastreamConnectionProfileMongodbProfileBlock>>("mongodb_profile");
        set => this.WithProperty("mongodb_profile", value);
    }

    /// <summary>
    /// Block for mysql_profile.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MysqlProfile block(s) allowed")]
    public List<GoogleDatastreamConnectionProfileMysqlProfileBlock>? MysqlProfile
    {
        get => GetProperty<List<GoogleDatastreamConnectionProfileMysqlProfileBlock>>("mysql_profile");
        set => this.WithProperty("mysql_profile", value);
    }

    /// <summary>
    /// Block for oracle_profile.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OracleProfile block(s) allowed")]
    public List<GoogleDatastreamConnectionProfileOracleProfileBlock>? OracleProfile
    {
        get => GetProperty<List<GoogleDatastreamConnectionProfileOracleProfileBlock>>("oracle_profile");
        set => this.WithProperty("oracle_profile", value);
    }

    /// <summary>
    /// Block for postgresql_profile.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PostgresqlProfile block(s) allowed")]
    public List<GoogleDatastreamConnectionProfilePostgresqlProfileBlock>? PostgresqlProfile
    {
        get => GetProperty<List<GoogleDatastreamConnectionProfilePostgresqlProfileBlock>>("postgresql_profile");
        set => this.WithProperty("postgresql_profile", value);
    }

    /// <summary>
    /// Block for private_connectivity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PrivateConnectivity block(s) allowed")]
    public List<GoogleDatastreamConnectionProfilePrivateConnectivityBlock>? PrivateConnectivity
    {
        get => GetProperty<List<GoogleDatastreamConnectionProfilePrivateConnectivityBlock>>("private_connectivity");
        set => this.WithProperty("private_connectivity", value);
    }

    /// <summary>
    /// Block for sql_server_profile.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SqlServerProfile block(s) allowed")]
    public List<GoogleDatastreamConnectionProfileSqlServerProfileBlock>? SqlServerProfile
    {
        get => GetProperty<List<GoogleDatastreamConnectionProfileSqlServerProfileBlock>>("sql_server_profile");
        set => this.WithProperty("sql_server_profile", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleDatastreamConnectionProfileTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleDatastreamConnectionProfileTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// The resource&#39;s name.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

}
