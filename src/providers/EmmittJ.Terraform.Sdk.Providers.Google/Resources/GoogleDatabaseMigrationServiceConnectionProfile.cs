using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for alloydb in .
/// Nesting mode: list
/// </summary>
public partial class GoogleDatabaseMigrationServiceConnectionProfileAlloydbBlock : TerraformBlockBase
{
    /// <summary>
    /// Required. The AlloyDB cluster ID that this connection profile is associated with.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterId is required")]
    [TerraformProperty("cluster_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ClusterId { get; set; }

}

/// <summary>
/// Block type for cloudsql in .
/// Nesting mode: list
/// </summary>
public partial class GoogleDatabaseMigrationServiceConnectionProfileCloudsqlBlock : TerraformBlockBase
{



}

/// <summary>
/// Block type for mysql in .
/// Nesting mode: list
/// </summary>
public partial class GoogleDatabaseMigrationServiceConnectionProfileMysqlBlock : TerraformBlockBase
{
    /// <summary>
    /// If the source is a Cloud SQL database, use this field to provide the Cloud SQL instance ID of the source.
    /// </summary>
    [TerraformProperty("cloud_sql_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? CloudSqlId { get; set; }

    /// <summary>
    /// The IP or hostname of the source MySQL database.
    /// </summary>
    [TerraformProperty("host")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Host { get; set; }

    /// <summary>
    /// Input only. The password for the user that Database Migration Service will be using to connect to the database.
    /// This field is not returned on request, and the value is encrypted when stored in Database Migration Service.
    /// </summary>
    [TerraformProperty("password")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Password { get; set; }


    /// <summary>
    /// The network port of the source MySQL database.
    /// </summary>
    [TerraformProperty("port")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? Port { get; set; }

    /// <summary>
    /// The username that Database Migration Service will use to connect to the database. The value is encrypted when stored in Database Migration Service.
    /// </summary>
    [TerraformProperty("username")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Username { get; set; }

}

/// <summary>
/// Block type for oracle in .
/// Nesting mode: list
/// </summary>
public partial class GoogleDatabaseMigrationServiceConnectionProfileOracleBlock : TerraformBlockBase
{
    /// <summary>
    /// Required. Database service for the Oracle connection.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatabaseService is required")]
    [TerraformProperty("database_service")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DatabaseService { get; set; }

    /// <summary>
    /// Required. The IP or hostname of the source Oracle database.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Host is required")]
    [TerraformProperty("host")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Host { get; set; }

    /// <summary>
    /// Required. Input only. The password for the user that Database Migration Service will be using to connect to the database.
    /// This field is not returned on request, and the value is encrypted when stored in Database Migration Service.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Password is required")]
    [TerraformProperty("password")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Password { get; set; }


    /// <summary>
    /// Required. The network port of the source Oracle database.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Port is required")]
    [TerraformProperty("port")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> Port { get; set; }

    /// <summary>
    /// Required. The username that Database Migration Service will use to connect to the database. The value is encrypted when stored in Database Migration Service.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Username is required")]
    [TerraformProperty("username")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Username { get; set; }

}

/// <summary>
/// Block type for postgresql in .
/// Nesting mode: list
/// </summary>
public partial class GoogleDatabaseMigrationServiceConnectionProfilePostgresqlBlock : TerraformBlockBase
{
    /// <summary>
    /// If the connected database is an AlloyDB instance, use this field to provide the AlloyDB cluster ID.
    /// </summary>
    [TerraformProperty("alloydb_cluster_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AlloydbClusterId { get; set; }

    /// <summary>
    /// If the source is a Cloud SQL database, use this field to provide the Cloud SQL instance ID of the source.
    /// </summary>
    [TerraformProperty("cloud_sql_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? CloudSqlId { get; set; }

    /// <summary>
    /// The IP or hostname of the source MySQL database.
    /// </summary>
    [TerraformProperty("host")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Host { get; set; }


    /// <summary>
    /// Input only. The password for the user that Database Migration Service will be using to connect to the database.
    /// This field is not returned on request, and the value is encrypted when stored in Database Migration Service.
    /// </summary>
    [TerraformProperty("password")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Password { get; set; }


    /// <summary>
    /// The network port of the source MySQL database.
    /// </summary>
    [TerraformProperty("port")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? Port { get; set; }

    /// <summary>
    /// The username that Database Migration Service will use to connect to the database. The value is encrypted when stored in Database Migration Service.
    /// </summary>
    [TerraformProperty("username")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Username { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleDatabaseMigrationServiceConnectionProfileTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_database_migration_service_connection_profile resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleDatabaseMigrationServiceConnectionProfile : TerraformResource
{
    public GoogleDatabaseMigrationServiceConnectionProfile(string name) : base("google_database_migration_service_connection_profile", name)
    {
    }

    /// <summary>
    /// The ID of the connection profile.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectionProfileId is required")]
    [TerraformProperty("connection_profile_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ConnectionProfileId { get; set; }

    /// <summary>
    /// The connection profile display name.
    /// </summary>
    [TerraformProperty("display_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DisplayName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The resource labels for connection profile to use to annotate any related underlying resources such as Compute Engine VMs.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformProperty("labels")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Labels { get; set; }

    /// <summary>
    /// The location where the connection profile should reside.
    /// </summary>
    [TerraformProperty("location")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Location { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// Block for alloydb.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Alloydb block(s) allowed")]
    [TerraformProperty("alloydb")]
    public partial TerraformList<TerraformBlock<GoogleDatabaseMigrationServiceConnectionProfileAlloydbBlock>>? Alloydb { get; set; }

    /// <summary>
    /// Block for cloudsql.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Cloudsql block(s) allowed")]
    [TerraformProperty("cloudsql")]
    public partial TerraformList<TerraformBlock<GoogleDatabaseMigrationServiceConnectionProfileCloudsqlBlock>>? Cloudsql { get; set; }

    /// <summary>
    /// Block for mysql.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Mysql block(s) allowed")]
    [TerraformProperty("mysql")]
    public partial TerraformList<TerraformBlock<GoogleDatabaseMigrationServiceConnectionProfileMysqlBlock>>? Mysql { get; set; }

    /// <summary>
    /// Block for oracle.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Oracle block(s) allowed")]
    [TerraformProperty("oracle")]
    public partial TerraformList<TerraformBlock<GoogleDatabaseMigrationServiceConnectionProfileOracleBlock>>? Oracle { get; set; }

    /// <summary>
    /// Block for postgresql.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Postgresql block(s) allowed")]
    [TerraformProperty("postgresql")]
    public partial TerraformList<TerraformBlock<GoogleDatabaseMigrationServiceConnectionProfilePostgresqlBlock>>? Postgresql { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<GoogleDatabaseMigrationServiceConnectionProfileTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Output only. The timestamp when the resource was created. A timestamp in RFC3339 UTC &#39;Zulu&#39; format, accurate to nanoseconds. Example: &#39;2014-10-02T15:01:23.045123456Z&#39;.
    /// </summary>
    [TerraformProperty("create_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreateTime { get; }

    /// <summary>
    /// The database provider.
    /// </summary>
    [TerraformProperty("dbprovider")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Dbprovider { get; }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformProperty("effective_labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> EffectiveLabels { get; }

    /// <summary>
    /// Output only. The error details in case of state FAILED.
    /// </summary>
    [TerraformProperty("error")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> Error { get; }

    /// <summary>
    /// The name of this connection profile resource in the form of projects/{project}/locations/{location}/connectionProfiles/{connectionProfile}.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Name { get; }

    /// <summary>
    /// The current connection profile state.
    /// </summary>
    [TerraformProperty("state")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> State { get; }

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformProperty("terraform_labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> TerraformLabels { get; }

}
