using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for bigquery_profile in .
/// Nesting mode: list
/// </summary>
public class GoogleDatastreamConnectionProfileBigqueryProfileBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for forward_ssh_connectivity in .
/// Nesting mode: list
/// </summary>
public class GoogleDatastreamConnectionProfileForwardSshConnectivityBlock : ITerraformBlock
{
    /// <summary>
    /// Hostname for the SSH tunnel.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Hostname is required")]
    [TerraformPropertyName("hostname")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Hostname { get; set; }

    /// <summary>
    /// SSH password.
    /// </summary>
    [TerraformPropertyName("password")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Password { get; set; }

    /// <summary>
    /// Port for the SSH tunnel.
    /// </summary>
    [TerraformPropertyName("port")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? Port { get; set; }

    /// <summary>
    /// SSH private key.
    /// </summary>
    [TerraformPropertyName("private_key")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? PrivateKey { get; set; }

    /// <summary>
    /// Username for the SSH tunnel.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Username is required")]
    [TerraformPropertyName("username")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Username { get; set; }

}

/// <summary>
/// Block type for gcs_profile in .
/// Nesting mode: list
/// </summary>
public class GoogleDatastreamConnectionProfileGcsProfileBlock : ITerraformBlock
{
    /// <summary>
    /// The Cloud Storage bucket name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bucket is required")]
    [TerraformPropertyName("bucket")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Bucket { get; set; }

    /// <summary>
    /// The root path inside the Cloud Storage bucket.
    /// </summary>
    [TerraformPropertyName("root_path")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? RootPath { get; set; }

}

/// <summary>
/// Block type for mongodb_profile in .
/// Nesting mode: list
/// </summary>
public class GoogleDatastreamConnectionProfileMongodbProfileBlock : ITerraformBlock
{
    /// <summary>
    /// Password for the MongoDB connection. Mutually exclusive with
    /// secretManagerStoredPassword.
    /// </summary>
    [TerraformPropertyName("password")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Password { get; set; }

    /// <summary>
    /// Name of the replica set.
    /// </summary>
    [TerraformPropertyName("replica_set")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ReplicaSet { get; set; }

    /// <summary>
    /// A reference to a Secret Manager resource name storing the MongoDB
    /// connection password. Mutually exclusive with password.
    /// </summary>
    [TerraformPropertyName("secret_manager_stored_password")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SecretManagerStoredPassword { get; set; }

    /// <summary>
    /// Username for the MongoDB connection.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Username is required")]
    [TerraformPropertyName("username")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Username { get; set; }

}

/// <summary>
/// Block type for mysql_profile in .
/// Nesting mode: list
/// </summary>
public class GoogleDatastreamConnectionProfileMysqlProfileBlock : ITerraformBlock
{
    /// <summary>
    /// Hostname for the MySQL connection.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Hostname is required")]
    [TerraformPropertyName("hostname")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Hostname { get; set; }

    /// <summary>
    /// Password for the MySQL connection.
    /// </summary>
    [TerraformPropertyName("password")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Password { get; set; }

    /// <summary>
    /// Port for the MySQL connection.
    /// </summary>
    [TerraformPropertyName("port")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? Port { get; set; }

    /// <summary>
    /// A reference to a Secret Manager resource name storing the user&#39;s password.
    /// </summary>
    [TerraformPropertyName("secret_manager_stored_password")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SecretManagerStoredPassword { get; set; }

    /// <summary>
    /// Username for the MySQL connection.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Username is required")]
    [TerraformPropertyName("username")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Username { get; set; }

}

/// <summary>
/// Block type for oracle_profile in .
/// Nesting mode: list
/// </summary>
public class GoogleDatastreamConnectionProfileOracleProfileBlock : ITerraformBlock
{
    /// <summary>
    /// Connection string attributes
    /// </summary>
    [TerraformPropertyName("connection_attributes")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? ConnectionAttributes { get; set; }

    /// <summary>
    /// Database for the Oracle connection.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatabaseService is required")]
    [TerraformPropertyName("database_service")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DatabaseService { get; set; }

    /// <summary>
    /// Hostname for the Oracle connection.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Hostname is required")]
    [TerraformPropertyName("hostname")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Hostname { get; set; }

    /// <summary>
    /// Password for the Oracle connection.
    /// </summary>
    [TerraformPropertyName("password")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Password { get; set; }

    /// <summary>
    /// Port for the Oracle connection.
    /// </summary>
    [TerraformPropertyName("port")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? Port { get; set; }

    /// <summary>
    /// A reference to a Secret Manager resource name storing the user&#39;s password.
    /// </summary>
    [TerraformPropertyName("secret_manager_stored_password")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SecretManagerStoredPassword { get; set; }

    /// <summary>
    /// Username for the Oracle connection.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Username is required")]
    [TerraformPropertyName("username")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Username { get; set; }

}

/// <summary>
/// Block type for postgresql_profile in .
/// Nesting mode: list
/// </summary>
public class GoogleDatastreamConnectionProfilePostgresqlProfileBlock : ITerraformBlock
{
    /// <summary>
    /// Database for the PostgreSQL connection.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Database is required")]
    [TerraformPropertyName("database")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Database { get; set; }

    /// <summary>
    /// Hostname for the PostgreSQL connection.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Hostname is required")]
    [TerraformPropertyName("hostname")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Hostname { get; set; }

    /// <summary>
    /// Password for the PostgreSQL connection.
    /// </summary>
    [TerraformPropertyName("password")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Password { get; set; }

    /// <summary>
    /// Port for the PostgreSQL connection.
    /// </summary>
    [TerraformPropertyName("port")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? Port { get; set; }

    /// <summary>
    /// A reference to a Secret Manager resource name storing the user&#39;s password.
    /// </summary>
    [TerraformPropertyName("secret_manager_stored_password")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SecretManagerStoredPassword { get; set; }

    /// <summary>
    /// Username for the PostgreSQL connection.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Username is required")]
    [TerraformPropertyName("username")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Username { get; set; }

}

/// <summary>
/// Block type for private_connectivity in .
/// Nesting mode: list
/// </summary>
public class GoogleDatastreamConnectionProfilePrivateConnectivityBlock : ITerraformBlock
{
    /// <summary>
    /// A reference to a private connection resource. Format: &#39;projects/{project}/locations/{location}/privateConnections/{name}&#39;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrivateConnection is required")]
    [TerraformPropertyName("private_connection")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> PrivateConnection { get; set; }

}

/// <summary>
/// Block type for sql_server_profile in .
/// Nesting mode: list
/// </summary>
public class GoogleDatastreamConnectionProfileSqlServerProfileBlock : ITerraformBlock
{
    /// <summary>
    /// Database for the SQL Server connection.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Database is required")]
    [TerraformPropertyName("database")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Database { get; set; }

    /// <summary>
    /// Hostname for the SQL Server connection.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Hostname is required")]
    [TerraformPropertyName("hostname")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Hostname { get; set; }

    /// <summary>
    /// Password for the SQL Server connection.
    /// </summary>
    [TerraformPropertyName("password")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Password { get; set; }

    /// <summary>
    /// Port for the SQL Server connection.
    /// </summary>
    [TerraformPropertyName("port")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? Port { get; set; }

    /// <summary>
    /// A reference to a Secret Manager resource name storing the user&#39;s password.
    /// </summary>
    [TerraformPropertyName("secret_manager_stored_password")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SecretManagerStoredPassword { get; set; }

    /// <summary>
    /// Username for the SQL Server connection.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Username is required")]
    [TerraformPropertyName("username")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Username { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleDatastreamConnectionProfileTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a google_datastream_connection_profile resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleDatastreamConnectionProfile : TerraformResource
{
    public GoogleDatastreamConnectionProfile(string name) : base("google_datastream_connection_profile", name)
    {
    }

    /// <summary>
    /// The connection profile identifier.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectionProfileId is required")]
    [TerraformPropertyName("connection_profile_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ConnectionProfileId { get; set; }

    /// <summary>
    /// Create the connection profile without validating it.
    /// </summary>
    [TerraformPropertyName("create_without_validation")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? CreateWithoutValidation { get; set; }

    /// <summary>
    /// Display name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformPropertyName("display_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DisplayName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Labels.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformPropertyName("labels")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Labels { get; set; }

    /// <summary>
    /// The name of the location this connection profile is located in.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Location { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Project { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "project");

    /// <summary>
    /// Block for bigquery_profile.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BigqueryProfile block(s) allowed")]
    [TerraformPropertyName("bigquery_profile")]
    public TerraformList<TerraformBlock<GoogleDatastreamConnectionProfileBigqueryProfileBlock>>? BigqueryProfile { get; set; } = new();

    /// <summary>
    /// Block for forward_ssh_connectivity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ForwardSshConnectivity block(s) allowed")]
    [TerraformPropertyName("forward_ssh_connectivity")]
    public TerraformList<TerraformBlock<GoogleDatastreamConnectionProfileForwardSshConnectivityBlock>>? ForwardSshConnectivity { get; set; } = new();

    /// <summary>
    /// Block for gcs_profile.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GcsProfile block(s) allowed")]
    [TerraformPropertyName("gcs_profile")]
    public TerraformList<TerraformBlock<GoogleDatastreamConnectionProfileGcsProfileBlock>>? GcsProfile { get; set; } = new();

    /// <summary>
    /// Block for mongodb_profile.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MongodbProfile block(s) allowed")]
    [TerraformPropertyName("mongodb_profile")]
    public TerraformList<TerraformBlock<GoogleDatastreamConnectionProfileMongodbProfileBlock>>? MongodbProfile { get; set; } = new();

    /// <summary>
    /// Block for mysql_profile.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MysqlProfile block(s) allowed")]
    [TerraformPropertyName("mysql_profile")]
    public TerraformList<TerraformBlock<GoogleDatastreamConnectionProfileMysqlProfileBlock>>? MysqlProfile { get; set; } = new();

    /// <summary>
    /// Block for oracle_profile.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OracleProfile block(s) allowed")]
    [TerraformPropertyName("oracle_profile")]
    public TerraformList<TerraformBlock<GoogleDatastreamConnectionProfileOracleProfileBlock>>? OracleProfile { get; set; } = new();

    /// <summary>
    /// Block for postgresql_profile.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PostgresqlProfile block(s) allowed")]
    [TerraformPropertyName("postgresql_profile")]
    public TerraformList<TerraformBlock<GoogleDatastreamConnectionProfilePostgresqlProfileBlock>>? PostgresqlProfile { get; set; } = new();

    /// <summary>
    /// Block for private_connectivity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PrivateConnectivity block(s) allowed")]
    [TerraformPropertyName("private_connectivity")]
    public TerraformList<TerraformBlock<GoogleDatastreamConnectionProfilePrivateConnectivityBlock>>? PrivateConnectivity { get; set; } = new();

    /// <summary>
    /// Block for sql_server_profile.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SqlServerProfile block(s) allowed")]
    [TerraformPropertyName("sql_server_profile")]
    public TerraformList<TerraformBlock<GoogleDatastreamConnectionProfileSqlServerProfileBlock>>? SqlServerProfile { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleDatastreamConnectionProfileTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformPropertyName("effective_labels")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> EffectiveLabels => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "effective_labels");

    /// <summary>
    /// The resource&#39;s name.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Name => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformPropertyName("terraform_labels")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TerraformLabels => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "terraform_labels");

}
