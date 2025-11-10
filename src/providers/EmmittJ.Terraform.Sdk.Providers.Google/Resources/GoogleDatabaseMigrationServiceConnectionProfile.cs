using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for alloydb in .
/// Nesting mode: list
/// </summary>
public class GoogleDatabaseMigrationServiceConnectionProfileAlloydbBlock : ITerraformBlock
{
    /// <summary>
    /// Required. The AlloyDB cluster ID that this connection profile is associated with.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterId is required")]
    [TerraformPropertyName("cluster_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ClusterId { get; set; }

}

/// <summary>
/// Block type for cloudsql in .
/// Nesting mode: list
/// </summary>
public class GoogleDatabaseMigrationServiceConnectionProfileCloudsqlBlock : ITerraformBlock
{
    /// <summary>
    /// Output only. The Cloud SQL instance ID that this connection profile is associated with.
    /// </summary>
    [TerraformPropertyName("cloud_sql_id")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CloudSqlId => new TerraformReferenceProperty<TerraformProperty<string>>("", "cloud_sql_id");

    /// <summary>
    /// Output only. The Cloud SQL database instance&#39;s private IP.
    /// </summary>
    [TerraformPropertyName("private_ip")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PrivateIp => new TerraformReferenceProperty<TerraformProperty<string>>("", "private_ip");

    /// <summary>
    /// Output only. The Cloud SQL database instance&#39;s public IP.
    /// </summary>
    [TerraformPropertyName("public_ip")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PublicIp => new TerraformReferenceProperty<TerraformProperty<string>>("", "public_ip");

}

/// <summary>
/// Block type for mysql in .
/// Nesting mode: list
/// </summary>
public class GoogleDatabaseMigrationServiceConnectionProfileMysqlBlock : ITerraformBlock
{
    /// <summary>
    /// If the source is a Cloud SQL database, use this field to provide the Cloud SQL instance ID of the source.
    /// </summary>
    [TerraformPropertyName("cloud_sql_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? CloudSqlId { get; set; }

    /// <summary>
    /// The IP or hostname of the source MySQL database.
    /// </summary>
    [TerraformPropertyName("host")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Host { get; set; }

    /// <summary>
    /// Input only. The password for the user that Database Migration Service will be using to connect to the database.
    /// This field is not returned on request, and the value is encrypted when stored in Database Migration Service.
    /// </summary>
    [TerraformPropertyName("password")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Password { get; set; }

    /// <summary>
    /// Output only. Indicates If this connection profile password is stored.
    /// </summary>
    [TerraformPropertyName("password_set")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> PasswordSet => new TerraformReferenceProperty<TerraformProperty<bool>>("", "password_set");

    /// <summary>
    /// The network port of the source MySQL database.
    /// </summary>
    [TerraformPropertyName("port")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? Port { get; set; }

    /// <summary>
    /// The username that Database Migration Service will use to connect to the database. The value is encrypted when stored in Database Migration Service.
    /// </summary>
    [TerraformPropertyName("username")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Username { get; set; }

}

/// <summary>
/// Block type for oracle in .
/// Nesting mode: list
/// </summary>
public class GoogleDatabaseMigrationServiceConnectionProfileOracleBlock : ITerraformBlock
{
    /// <summary>
    /// Required. Database service for the Oracle connection.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatabaseService is required")]
    [TerraformPropertyName("database_service")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DatabaseService { get; set; }

    /// <summary>
    /// Required. The IP or hostname of the source Oracle database.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Host is required")]
    [TerraformPropertyName("host")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Host { get; set; }

    /// <summary>
    /// Required. Input only. The password for the user that Database Migration Service will be using to connect to the database.
    /// This field is not returned on request, and the value is encrypted when stored in Database Migration Service.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Password is required")]
    [TerraformPropertyName("password")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Password { get; set; }

    /// <summary>
    /// Output only. Indicates If this connection profile password is stored.
    /// </summary>
    [TerraformPropertyName("password_set")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> PasswordSet => new TerraformReferenceProperty<TerraformProperty<bool>>("", "password_set");

    /// <summary>
    /// Required. The network port of the source Oracle database.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Port is required")]
    [TerraformPropertyName("port")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> Port { get; set; }

    /// <summary>
    /// Required. The username that Database Migration Service will use to connect to the database. The value is encrypted when stored in Database Migration Service.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Username is required")]
    [TerraformPropertyName("username")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Username { get; set; }

}

/// <summary>
/// Block type for postgresql in .
/// Nesting mode: list
/// </summary>
public class GoogleDatabaseMigrationServiceConnectionProfilePostgresqlBlock : ITerraformBlock
{
    /// <summary>
    /// If the connected database is an AlloyDB instance, use this field to provide the AlloyDB cluster ID.
    /// </summary>
    [TerraformPropertyName("alloydb_cluster_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? AlloydbClusterId { get; set; }

    /// <summary>
    /// If the source is a Cloud SQL database, use this field to provide the Cloud SQL instance ID of the source.
    /// </summary>
    [TerraformPropertyName("cloud_sql_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? CloudSqlId { get; set; }

    /// <summary>
    /// The IP or hostname of the source MySQL database.
    /// </summary>
    [TerraformPropertyName("host")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Host { get; set; }

    /// <summary>
    /// Output only. If the source is a Cloud SQL database, this field indicates the network architecture it&#39;s associated with.
    /// </summary>
    [TerraformPropertyName("network_architecture")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> NetworkArchitecture => new TerraformReferenceProperty<TerraformProperty<string>>("", "network_architecture");

    /// <summary>
    /// Input only. The password for the user that Database Migration Service will be using to connect to the database.
    /// This field is not returned on request, and the value is encrypted when stored in Database Migration Service.
    /// </summary>
    [TerraformPropertyName("password")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Password { get; set; }

    /// <summary>
    /// Output only. Indicates If this connection profile password is stored.
    /// </summary>
    [TerraformPropertyName("password_set")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> PasswordSet => new TerraformReferenceProperty<TerraformProperty<bool>>("", "password_set");

    /// <summary>
    /// The network port of the source MySQL database.
    /// </summary>
    [TerraformPropertyName("port")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? Port { get; set; }

    /// <summary>
    /// The username that Database Migration Service will use to connect to the database. The value is encrypted when stored in Database Migration Service.
    /// </summary>
    [TerraformPropertyName("username")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Username { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleDatabaseMigrationServiceConnectionProfileTimeoutsBlock : ITerraformBlock
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
/// Manages a google_database_migration_service_connection_profile resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleDatabaseMigrationServiceConnectionProfile : TerraformResource
{
    public GoogleDatabaseMigrationServiceConnectionProfile(string name) : base("google_database_migration_service_connection_profile", name)
    {
    }

    /// <summary>
    /// The ID of the connection profile.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectionProfileId is required")]
    [TerraformPropertyName("connection_profile_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ConnectionProfileId { get; set; }

    /// <summary>
    /// The connection profile display name.
    /// </summary>
    [TerraformPropertyName("display_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DisplayName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The resource labels for connection profile to use to annotate any related underlying resources such as Compute Engine VMs.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformPropertyName("labels")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Labels { get; set; }

    /// <summary>
    /// The location where the connection profile should reside.
    /// </summary>
    [TerraformPropertyName("location")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Location { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Project { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "project");

    /// <summary>
    /// Block for alloydb.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Alloydb block(s) allowed")]
    [TerraformPropertyName("alloydb")]
    public TerraformList<TerraformBlock<GoogleDatabaseMigrationServiceConnectionProfileAlloydbBlock>>? Alloydb { get; set; } = new();

    /// <summary>
    /// Block for cloudsql.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Cloudsql block(s) allowed")]
    [TerraformPropertyName("cloudsql")]
    public TerraformList<TerraformBlock<GoogleDatabaseMigrationServiceConnectionProfileCloudsqlBlock>>? Cloudsql { get; set; } = new();

    /// <summary>
    /// Block for mysql.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Mysql block(s) allowed")]
    [TerraformPropertyName("mysql")]
    public TerraformList<TerraformBlock<GoogleDatabaseMigrationServiceConnectionProfileMysqlBlock>>? Mysql { get; set; } = new();

    /// <summary>
    /// Block for oracle.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Oracle block(s) allowed")]
    [TerraformPropertyName("oracle")]
    public TerraformList<TerraformBlock<GoogleDatabaseMigrationServiceConnectionProfileOracleBlock>>? Oracle { get; set; } = new();

    /// <summary>
    /// Block for postgresql.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Postgresql block(s) allowed")]
    [TerraformPropertyName("postgresql")]
    public TerraformList<TerraformBlock<GoogleDatabaseMigrationServiceConnectionProfilePostgresqlBlock>>? Postgresql { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleDatabaseMigrationServiceConnectionProfileTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// Output only. The timestamp when the resource was created. A timestamp in RFC3339 UTC &#39;Zulu&#39; format, accurate to nanoseconds. Example: &#39;2014-10-02T15:01:23.045123456Z&#39;.
    /// </summary>
    [TerraformPropertyName("create_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "create_time");

    /// <summary>
    /// The database provider.
    /// </summary>
    [TerraformPropertyName("dbprovider")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Dbprovider => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "dbprovider");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformPropertyName("effective_labels")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> EffectiveLabels => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "effective_labels");

    /// <summary>
    /// Output only. The error details in case of state FAILED.
    /// </summary>
    [TerraformPropertyName("error")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Error => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "error");

    /// <summary>
    /// The name of this connection profile resource in the form of projects/{project}/locations/{location}/connectionProfiles/{connectionProfile}.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Name => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

    /// <summary>
    /// The current connection profile state.
    /// </summary>
    [TerraformPropertyName("state")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> State => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "state");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformPropertyName("terraform_labels")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TerraformLabels => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "terraform_labels");

}
