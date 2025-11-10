using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for alloydb in .
/// Nesting mode: list
/// </summary>
public class GoogleDatabaseMigrationServiceConnectionProfileAlloydbBlock : TerraformBlock
{
    /// <summary>
    /// Required. The AlloyDB cluster ID that this connection profile is associated with.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterId is required")]
    public required TerraformProperty<string> ClusterId
    {
        set => SetProperty("cluster_id", value);
    }

}

/// <summary>
/// Block type for cloudsql in .
/// Nesting mode: list
/// </summary>
public class GoogleDatabaseMigrationServiceConnectionProfileCloudsqlBlock : TerraformBlock
{
    /// <summary>
    /// Output only. The Cloud SQL instance ID that this connection profile is associated with.
    /// </summary>
    public TerraformProperty<string>? CloudSqlId
    {
        set => SetProperty("cloud_sql_id", value);
    }

    /// <summary>
    /// Output only. The Cloud SQL database instance&#39;s private IP.
    /// </summary>
    public TerraformProperty<string>? PrivateIp
    {
        set => SetProperty("private_ip", value);
    }

    /// <summary>
    /// Output only. The Cloud SQL database instance&#39;s public IP.
    /// </summary>
    public TerraformProperty<string>? PublicIp
    {
        set => SetProperty("public_ip", value);
    }

}

/// <summary>
/// Block type for mysql in .
/// Nesting mode: list
/// </summary>
public class GoogleDatabaseMigrationServiceConnectionProfileMysqlBlock : TerraformBlock
{
    /// <summary>
    /// If the source is a Cloud SQL database, use this field to provide the Cloud SQL instance ID of the source.
    /// </summary>
    public TerraformProperty<string>? CloudSqlId
    {
        set => SetProperty("cloud_sql_id", value);
    }

    /// <summary>
    /// The IP or hostname of the source MySQL database.
    /// </summary>
    public TerraformProperty<string>? Host
    {
        set => SetProperty("host", value);
    }

    /// <summary>
    /// Input only. The password for the user that Database Migration Service will be using to connect to the database.
    /// This field is not returned on request, and the value is encrypted when stored in Database Migration Service.
    /// </summary>
    public TerraformProperty<string>? Password
    {
        set => SetProperty("password", value);
    }

    /// <summary>
    /// Output only. Indicates If this connection profile password is stored.
    /// </summary>
    public TerraformProperty<bool>? PasswordSet
    {
        set => SetProperty("password_set", value);
    }

    /// <summary>
    /// The network port of the source MySQL database.
    /// </summary>
    public TerraformProperty<double>? Port
    {
        set => SetProperty("port", value);
    }

    /// <summary>
    /// The username that Database Migration Service will use to connect to the database. The value is encrypted when stored in Database Migration Service.
    /// </summary>
    public TerraformProperty<string>? Username
    {
        set => SetProperty("username", value);
    }

}

/// <summary>
/// Block type for oracle in .
/// Nesting mode: list
/// </summary>
public class GoogleDatabaseMigrationServiceConnectionProfileOracleBlock : TerraformBlock
{
    /// <summary>
    /// Required. Database service for the Oracle connection.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatabaseService is required")]
    public required TerraformProperty<string> DatabaseService
    {
        set => SetProperty("database_service", value);
    }

    /// <summary>
    /// Required. The IP or hostname of the source Oracle database.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Host is required")]
    public required TerraformProperty<string> Host
    {
        set => SetProperty("host", value);
    }

    /// <summary>
    /// Required. Input only. The password for the user that Database Migration Service will be using to connect to the database.
    /// This field is not returned on request, and the value is encrypted when stored in Database Migration Service.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Password is required")]
    public required TerraformProperty<string> Password
    {
        set => SetProperty("password", value);
    }

    /// <summary>
    /// Output only. Indicates If this connection profile password is stored.
    /// </summary>
    public TerraformProperty<bool>? PasswordSet
    {
        set => SetProperty("password_set", value);
    }

    /// <summary>
    /// Required. The network port of the source Oracle database.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Port is required")]
    public required TerraformProperty<double> Port
    {
        set => SetProperty("port", value);
    }

    /// <summary>
    /// Required. The username that Database Migration Service will use to connect to the database. The value is encrypted when stored in Database Migration Service.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Username is required")]
    public required TerraformProperty<string> Username
    {
        set => SetProperty("username", value);
    }

}

/// <summary>
/// Block type for postgresql in .
/// Nesting mode: list
/// </summary>
public class GoogleDatabaseMigrationServiceConnectionProfilePostgresqlBlock : TerraformBlock
{
    /// <summary>
    /// If the connected database is an AlloyDB instance, use this field to provide the AlloyDB cluster ID.
    /// </summary>
    public TerraformProperty<string>? AlloydbClusterId
    {
        set => SetProperty("alloydb_cluster_id", value);
    }

    /// <summary>
    /// If the source is a Cloud SQL database, use this field to provide the Cloud SQL instance ID of the source.
    /// </summary>
    public TerraformProperty<string>? CloudSqlId
    {
        set => SetProperty("cloud_sql_id", value);
    }

    /// <summary>
    /// The IP or hostname of the source MySQL database.
    /// </summary>
    public TerraformProperty<string>? Host
    {
        set => SetProperty("host", value);
    }

    /// <summary>
    /// Output only. If the source is a Cloud SQL database, this field indicates the network architecture it&#39;s associated with.
    /// </summary>
    public TerraformProperty<string>? NetworkArchitecture
    {
        set => SetProperty("network_architecture", value);
    }

    /// <summary>
    /// Input only. The password for the user that Database Migration Service will be using to connect to the database.
    /// This field is not returned on request, and the value is encrypted when stored in Database Migration Service.
    /// </summary>
    public TerraformProperty<string>? Password
    {
        set => SetProperty("password", value);
    }

    /// <summary>
    /// Output only. Indicates If this connection profile password is stored.
    /// </summary>
    public TerraformProperty<bool>? PasswordSet
    {
        set => SetProperty("password_set", value);
    }

    /// <summary>
    /// The network port of the source MySQL database.
    /// </summary>
    public TerraformProperty<double>? Port
    {
        set => SetProperty("port", value);
    }

    /// <summary>
    /// The username that Database Migration Service will use to connect to the database. The value is encrypted when stored in Database Migration Service.
    /// </summary>
    public TerraformProperty<string>? Username
    {
        set => SetProperty("username", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleDatabaseMigrationServiceConnectionProfileTimeoutsBlock : TerraformBlock
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

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a google_database_migration_service_connection_profile resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleDatabaseMigrationServiceConnectionProfile : TerraformResource
{
    public GoogleDatabaseMigrationServiceConnectionProfile(string name) : base("google_database_migration_service_connection_profile", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("create_time");
        SetOutput("dbprovider");
        SetOutput("effective_labels");
        SetOutput("error");
        SetOutput("name");
        SetOutput("state");
        SetOutput("terraform_labels");
        SetOutput("connection_profile_id");
        SetOutput("display_name");
        SetOutput("id");
        SetOutput("labels");
        SetOutput("location");
        SetOutput("project");
    }

    /// <summary>
    /// The ID of the connection profile.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectionProfileId is required")]
    public required TerraformProperty<string> ConnectionProfileId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("connection_profile_id");
        set => SetProperty("connection_profile_id", value);
    }

    /// <summary>
    /// The connection profile display name.
    /// </summary>
    public TerraformProperty<string> DisplayName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("display_name");
        set => SetProperty("display_name", value);
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
    /// The resource labels for connection profile to use to annotate any related underlying resources such as Compute Engine VMs.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Labels
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("labels");
        set => SetProperty("labels", value);
    }

    /// <summary>
    /// The location where the connection profile should reside.
    /// </summary>
    public TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
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
    /// Block for alloydb.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Alloydb block(s) allowed")]
    public List<GoogleDatabaseMigrationServiceConnectionProfileAlloydbBlock>? Alloydb
    {
        set => SetProperty("alloydb", value);
    }

    /// <summary>
    /// Block for cloudsql.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Cloudsql block(s) allowed")]
    public List<GoogleDatabaseMigrationServiceConnectionProfileCloudsqlBlock>? Cloudsql
    {
        set => SetProperty("cloudsql", value);
    }

    /// <summary>
    /// Block for mysql.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Mysql block(s) allowed")]
    public List<GoogleDatabaseMigrationServiceConnectionProfileMysqlBlock>? Mysql
    {
        set => SetProperty("mysql", value);
    }

    /// <summary>
    /// Block for oracle.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Oracle block(s) allowed")]
    public List<GoogleDatabaseMigrationServiceConnectionProfileOracleBlock>? Oracle
    {
        set => SetProperty("oracle", value);
    }

    /// <summary>
    /// Block for postgresql.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Postgresql block(s) allowed")]
    public List<GoogleDatabaseMigrationServiceConnectionProfilePostgresqlBlock>? Postgresql
    {
        set => SetProperty("postgresql", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleDatabaseMigrationServiceConnectionProfileTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// Output only. The timestamp when the resource was created. A timestamp in RFC3339 UTC &#39;Zulu&#39; format, accurate to nanoseconds. Example: &#39;2014-10-02T15:01:23.045123456Z&#39;.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// The database provider.
    /// </summary>
    public TerraformExpression Dbprovider => this["dbprovider"];

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// Output only. The error details in case of state FAILED.
    /// </summary>
    public TerraformExpression Error => this["error"];

    /// <summary>
    /// The name of this connection profile resource in the form of projects/{project}/locations/{location}/connectionProfiles/{connectionProfile}.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The current connection profile state.
    /// </summary>
    public TerraformExpression State => this["state"];

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

}
