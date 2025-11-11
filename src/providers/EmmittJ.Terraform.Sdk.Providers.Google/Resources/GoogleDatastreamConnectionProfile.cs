using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for bigquery_profile in .
/// Nesting mode: list
/// </summary>
public partial class GoogleDatastreamConnectionProfileBigqueryProfileBlock : TerraformBlockBase
{
}

/// <summary>
/// Block type for forward_ssh_connectivity in .
/// Nesting mode: list
/// </summary>
public partial class GoogleDatastreamConnectionProfileForwardSshConnectivityBlock : TerraformBlockBase
{
    /// <summary>
    /// Hostname for the SSH tunnel.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Hostname is required")]
    [TerraformProperty("hostname")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Hostname { get; set; }

    /// <summary>
    /// SSH password.
    /// </summary>
    [TerraformProperty("password")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Password { get; set; }

    /// <summary>
    /// Port for the SSH tunnel.
    /// </summary>
    [TerraformProperty("port")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? Port { get; set; }

    /// <summary>
    /// SSH private key.
    /// </summary>
    [TerraformProperty("private_key")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? PrivateKey { get; set; }

    /// <summary>
    /// Username for the SSH tunnel.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Username is required")]
    [TerraformProperty("username")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Username { get; set; }

}

/// <summary>
/// Block type for gcs_profile in .
/// Nesting mode: list
/// </summary>
public partial class GoogleDatastreamConnectionProfileGcsProfileBlock : TerraformBlockBase
{
    /// <summary>
    /// The Cloud Storage bucket name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bucket is required")]
    [TerraformProperty("bucket")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Bucket { get; set; }

    /// <summary>
    /// The root path inside the Cloud Storage bucket.
    /// </summary>
    [TerraformProperty("root_path")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? RootPath { get; set; }

}

/// <summary>
/// Block type for mongodb_profile in .
/// Nesting mode: list
/// </summary>
public partial class GoogleDatastreamConnectionProfileMongodbProfileBlock : TerraformBlockBase
{
    /// <summary>
    /// Password for the MongoDB connection. Mutually exclusive with
    /// secretManagerStoredPassword.
    /// </summary>
    [TerraformProperty("password")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Password { get; set; }

    /// <summary>
    /// Name of the replica set.
    /// </summary>
    [TerraformProperty("replica_set")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ReplicaSet { get; set; }

    /// <summary>
    /// A reference to a Secret Manager resource name storing the MongoDB
    /// connection password. Mutually exclusive with password.
    /// </summary>
    [TerraformProperty("secret_manager_stored_password")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? SecretManagerStoredPassword { get; set; }

    /// <summary>
    /// Username for the MongoDB connection.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Username is required")]
    [TerraformProperty("username")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Username { get; set; }

}

/// <summary>
/// Block type for mysql_profile in .
/// Nesting mode: list
/// </summary>
public partial class GoogleDatastreamConnectionProfileMysqlProfileBlock : TerraformBlockBase
{
    /// <summary>
    /// Hostname for the MySQL connection.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Hostname is required")]
    [TerraformProperty("hostname")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Hostname { get; set; }

    /// <summary>
    /// Password for the MySQL connection.
    /// </summary>
    [TerraformProperty("password")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Password { get; set; }

    /// <summary>
    /// Port for the MySQL connection.
    /// </summary>
    [TerraformProperty("port")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? Port { get; set; }

    /// <summary>
    /// A reference to a Secret Manager resource name storing the user&#39;s password.
    /// </summary>
    [TerraformProperty("secret_manager_stored_password")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? SecretManagerStoredPassword { get; set; }

    /// <summary>
    /// Username for the MySQL connection.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Username is required")]
    [TerraformProperty("username")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Username { get; set; }

}

/// <summary>
/// Block type for oracle_profile in .
/// Nesting mode: list
/// </summary>
public partial class GoogleDatastreamConnectionProfileOracleProfileBlock : TerraformBlockBase
{
    /// <summary>
    /// Connection string attributes
    /// </summary>
    [TerraformProperty("connection_attributes")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? ConnectionAttributes { get; set; }

    /// <summary>
    /// Database for the Oracle connection.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatabaseService is required")]
    [TerraformProperty("database_service")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> DatabaseService { get; set; }

    /// <summary>
    /// Hostname for the Oracle connection.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Hostname is required")]
    [TerraformProperty("hostname")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Hostname { get; set; }

    /// <summary>
    /// Password for the Oracle connection.
    /// </summary>
    [TerraformProperty("password")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Password { get; set; }

    /// <summary>
    /// Port for the Oracle connection.
    /// </summary>
    [TerraformProperty("port")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? Port { get; set; }

    /// <summary>
    /// A reference to a Secret Manager resource name storing the user&#39;s password.
    /// </summary>
    [TerraformProperty("secret_manager_stored_password")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? SecretManagerStoredPassword { get; set; }

    /// <summary>
    /// Username for the Oracle connection.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Username is required")]
    [TerraformProperty("username")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Username { get; set; }

}

/// <summary>
/// Block type for postgresql_profile in .
/// Nesting mode: list
/// </summary>
public partial class GoogleDatastreamConnectionProfilePostgresqlProfileBlock : TerraformBlockBase
{
    /// <summary>
    /// Database for the PostgreSQL connection.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Database is required")]
    [TerraformProperty("database")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Database { get; set; }

    /// <summary>
    /// Hostname for the PostgreSQL connection.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Hostname is required")]
    [TerraformProperty("hostname")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Hostname { get; set; }

    /// <summary>
    /// Password for the PostgreSQL connection.
    /// </summary>
    [TerraformProperty("password")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Password { get; set; }

    /// <summary>
    /// Port for the PostgreSQL connection.
    /// </summary>
    [TerraformProperty("port")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? Port { get; set; }

    /// <summary>
    /// A reference to a Secret Manager resource name storing the user&#39;s password.
    /// </summary>
    [TerraformProperty("secret_manager_stored_password")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? SecretManagerStoredPassword { get; set; }

    /// <summary>
    /// Username for the PostgreSQL connection.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Username is required")]
    [TerraformProperty("username")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Username { get; set; }

}

/// <summary>
/// Block type for private_connectivity in .
/// Nesting mode: list
/// </summary>
public partial class GoogleDatastreamConnectionProfilePrivateConnectivityBlock : TerraformBlockBase
{
    /// <summary>
    /// A reference to a private connection resource. Format: &#39;projects/{project}/locations/{location}/privateConnections/{name}&#39;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrivateConnection is required")]
    [TerraformProperty("private_connection")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> PrivateConnection { get; set; }

}

/// <summary>
/// Block type for sql_server_profile in .
/// Nesting mode: list
/// </summary>
public partial class GoogleDatastreamConnectionProfileSqlServerProfileBlock : TerraformBlockBase
{
    /// <summary>
    /// Database for the SQL Server connection.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Database is required")]
    [TerraformProperty("database")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Database { get; set; }

    /// <summary>
    /// Hostname for the SQL Server connection.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Hostname is required")]
    [TerraformProperty("hostname")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Hostname { get; set; }

    /// <summary>
    /// Password for the SQL Server connection.
    /// </summary>
    [TerraformProperty("password")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Password { get; set; }

    /// <summary>
    /// Port for the SQL Server connection.
    /// </summary>
    [TerraformProperty("port")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? Port { get; set; }

    /// <summary>
    /// A reference to a Secret Manager resource name storing the user&#39;s password.
    /// </summary>
    [TerraformProperty("secret_manager_stored_password")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? SecretManagerStoredPassword { get; set; }

    /// <summary>
    /// Username for the SQL Server connection.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Username is required")]
    [TerraformProperty("username")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Username { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleDatastreamConnectionProfileTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_datastream_connection_profile resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleDatastreamConnectionProfile : TerraformResource
{
    public GoogleDatastreamConnectionProfile(string name) : base("google_datastream_connection_profile", name)
    {
    }

    /// <summary>
    /// The connection profile identifier.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectionProfileId is required")]
    [TerraformProperty("connection_profile_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ConnectionProfileId { get; set; }

    /// <summary>
    /// Create the connection profile without validating it.
    /// </summary>
    [TerraformProperty("create_without_validation")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? CreateWithoutValidation { get; set; }

    /// <summary>
    /// Display name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformProperty("display_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> DisplayName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Labels.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformProperty("labels")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Labels { get; set; }

    /// <summary>
    /// The name of the location this connection profile is located in.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Project { get; set; }

    /// <summary>
    /// Block for bigquery_profile.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BigqueryProfile block(s) allowed")]
    [TerraformProperty("bigquery_profile")]
    public TerraformList<TerraformBlock<GoogleDatastreamConnectionProfileBigqueryProfileBlock>>? BigqueryProfile { get; set; }

    /// <summary>
    /// Block for forward_ssh_connectivity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ForwardSshConnectivity block(s) allowed")]
    [TerraformProperty("forward_ssh_connectivity")]
    public TerraformList<TerraformBlock<GoogleDatastreamConnectionProfileForwardSshConnectivityBlock>>? ForwardSshConnectivity { get; set; }

    /// <summary>
    /// Block for gcs_profile.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GcsProfile block(s) allowed")]
    [TerraformProperty("gcs_profile")]
    public TerraformList<TerraformBlock<GoogleDatastreamConnectionProfileGcsProfileBlock>>? GcsProfile { get; set; }

    /// <summary>
    /// Block for mongodb_profile.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MongodbProfile block(s) allowed")]
    [TerraformProperty("mongodb_profile")]
    public TerraformList<TerraformBlock<GoogleDatastreamConnectionProfileMongodbProfileBlock>>? MongodbProfile { get; set; }

    /// <summary>
    /// Block for mysql_profile.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MysqlProfile block(s) allowed")]
    [TerraformProperty("mysql_profile")]
    public TerraformList<TerraformBlock<GoogleDatastreamConnectionProfileMysqlProfileBlock>>? MysqlProfile { get; set; }

    /// <summary>
    /// Block for oracle_profile.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OracleProfile block(s) allowed")]
    [TerraformProperty("oracle_profile")]
    public TerraformList<TerraformBlock<GoogleDatastreamConnectionProfileOracleProfileBlock>>? OracleProfile { get; set; }

    /// <summary>
    /// Block for postgresql_profile.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PostgresqlProfile block(s) allowed")]
    [TerraformProperty("postgresql_profile")]
    public TerraformList<TerraformBlock<GoogleDatastreamConnectionProfilePostgresqlProfileBlock>>? PostgresqlProfile { get; set; }

    /// <summary>
    /// Block for private_connectivity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PrivateConnectivity block(s) allowed")]
    [TerraformProperty("private_connectivity")]
    public TerraformList<TerraformBlock<GoogleDatastreamConnectionProfilePrivateConnectivityBlock>>? PrivateConnectivity { get; set; }

    /// <summary>
    /// Block for sql_server_profile.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SqlServerProfile block(s) allowed")]
    [TerraformProperty("sql_server_profile")]
    public TerraformList<TerraformBlock<GoogleDatastreamConnectionProfileSqlServerProfileBlock>>? SqlServerProfile { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<GoogleDatastreamConnectionProfileTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformProperty("effective_labels")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> EffectiveLabels { get; }

    /// <summary>
    /// The resource&#39;s name.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Name { get; }

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformProperty("terraform_labels")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> TerraformLabels { get; }

}
