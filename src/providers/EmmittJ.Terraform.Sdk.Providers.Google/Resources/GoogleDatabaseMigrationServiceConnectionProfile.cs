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
        get => GetRequiredProperty<TerraformProperty<string>>("cluster_id");
        set => WithProperty("cluster_id", value);
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
        get => GetProperty<TerraformProperty<string>>("cloud_sql_id");
        set => WithProperty("cloud_sql_id", value);
    }

    /// <summary>
    /// Output only. The Cloud SQL database instance&#39;s private IP.
    /// </summary>
    public TerraformProperty<string>? PrivateIp
    {
        get => GetProperty<TerraformProperty<string>>("private_ip");
        set => WithProperty("private_ip", value);
    }

    /// <summary>
    /// Output only. The Cloud SQL database instance&#39;s public IP.
    /// </summary>
    public TerraformProperty<string>? PublicIp
    {
        get => GetProperty<TerraformProperty<string>>("public_ip");
        set => WithProperty("public_ip", value);
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
        get => GetProperty<TerraformProperty<string>>("cloud_sql_id");
        set => WithProperty("cloud_sql_id", value);
    }

    /// <summary>
    /// The IP or hostname of the source MySQL database.
    /// </summary>
    public TerraformProperty<string>? Host
    {
        get => GetProperty<TerraformProperty<string>>("host");
        set => WithProperty("host", value);
    }

    /// <summary>
    /// Input only. The password for the user that Database Migration Service will be using to connect to the database.
    /// This field is not returned on request, and the value is encrypted when stored in Database Migration Service.
    /// </summary>
    public TerraformProperty<string>? Password
    {
        get => GetProperty<TerraformProperty<string>>("password");
        set => WithProperty("password", value);
    }

    /// <summary>
    /// Output only. Indicates If this connection profile password is stored.
    /// </summary>
    public TerraformProperty<bool>? PasswordSet
    {
        get => GetProperty<TerraformProperty<bool>>("password_set");
        set => WithProperty("password_set", value);
    }

    /// <summary>
    /// The network port of the source MySQL database.
    /// </summary>
    public TerraformProperty<double>? Port
    {
        get => GetProperty<TerraformProperty<double>>("port");
        set => WithProperty("port", value);
    }

    /// <summary>
    /// The username that Database Migration Service will use to connect to the database. The value is encrypted when stored in Database Migration Service.
    /// </summary>
    public TerraformProperty<string>? Username
    {
        get => GetProperty<TerraformProperty<string>>("username");
        set => WithProperty("username", value);
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
        get => GetRequiredProperty<TerraformProperty<string>>("database_service");
        set => WithProperty("database_service", value);
    }

    /// <summary>
    /// Required. The IP or hostname of the source Oracle database.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Host is required")]
    public required TerraformProperty<string> Host
    {
        get => GetRequiredProperty<TerraformProperty<string>>("host");
        set => WithProperty("host", value);
    }

    /// <summary>
    /// Required. Input only. The password for the user that Database Migration Service will be using to connect to the database.
    /// This field is not returned on request, and the value is encrypted when stored in Database Migration Service.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Password is required")]
    public required TerraformProperty<string> Password
    {
        get => GetRequiredProperty<TerraformProperty<string>>("password");
        set => WithProperty("password", value);
    }

    /// <summary>
    /// Output only. Indicates If this connection profile password is stored.
    /// </summary>
    public TerraformProperty<bool>? PasswordSet
    {
        get => GetProperty<TerraformProperty<bool>>("password_set");
        set => WithProperty("password_set", value);
    }

    /// <summary>
    /// Required. The network port of the source Oracle database.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Port is required")]
    public required TerraformProperty<double> Port
    {
        get => GetRequiredProperty<TerraformProperty<double>>("port");
        set => WithProperty("port", value);
    }

    /// <summary>
    /// Required. The username that Database Migration Service will use to connect to the database. The value is encrypted when stored in Database Migration Service.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Username is required")]
    public required TerraformProperty<string> Username
    {
        get => GetRequiredProperty<TerraformProperty<string>>("username");
        set => WithProperty("username", value);
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
        get => GetProperty<TerraformProperty<string>>("alloydb_cluster_id");
        set => WithProperty("alloydb_cluster_id", value);
    }

    /// <summary>
    /// If the source is a Cloud SQL database, use this field to provide the Cloud SQL instance ID of the source.
    /// </summary>
    public TerraformProperty<string>? CloudSqlId
    {
        get => GetProperty<TerraformProperty<string>>("cloud_sql_id");
        set => WithProperty("cloud_sql_id", value);
    }

    /// <summary>
    /// The IP or hostname of the source MySQL database.
    /// </summary>
    public TerraformProperty<string>? Host
    {
        get => GetProperty<TerraformProperty<string>>("host");
        set => WithProperty("host", value);
    }

    /// <summary>
    /// Output only. If the source is a Cloud SQL database, this field indicates the network architecture it&#39;s associated with.
    /// </summary>
    public TerraformProperty<string>? NetworkArchitecture
    {
        get => GetProperty<TerraformProperty<string>>("network_architecture");
        set => WithProperty("network_architecture", value);
    }

    /// <summary>
    /// Input only. The password for the user that Database Migration Service will be using to connect to the database.
    /// This field is not returned on request, and the value is encrypted when stored in Database Migration Service.
    /// </summary>
    public TerraformProperty<string>? Password
    {
        get => GetProperty<TerraformProperty<string>>("password");
        set => WithProperty("password", value);
    }

    /// <summary>
    /// Output only. Indicates If this connection profile password is stored.
    /// </summary>
    public TerraformProperty<bool>? PasswordSet
    {
        get => GetProperty<TerraformProperty<bool>>("password_set");
        set => WithProperty("password_set", value);
    }

    /// <summary>
    /// The network port of the source MySQL database.
    /// </summary>
    public TerraformProperty<double>? Port
    {
        get => GetProperty<TerraformProperty<double>>("port");
        set => WithProperty("port", value);
    }

    /// <summary>
    /// The username that Database Migration Service will use to connect to the database. The value is encrypted when stored in Database Migration Service.
    /// </summary>
    public TerraformProperty<string>? Username
    {
        get => GetProperty<TerraformProperty<string>>("username");
        set => WithProperty("username", value);
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
        this.WithOutput("create_time");
        this.WithOutput("dbprovider");
        this.WithOutput("effective_labels");
        this.WithOutput("error");
        this.WithOutput("name");
        this.WithOutput("state");
        this.WithOutput("terraform_labels");
    }

    /// <summary>
    /// The ID of the connection profile.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectionProfileId is required")]
    public required TerraformProperty<string> ConnectionProfileId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("connection_profile_id");
        set => this.WithProperty("connection_profile_id", value);
    }

    /// <summary>
    /// The connection profile display name.
    /// </summary>
    public TerraformProperty<string>? DisplayName
    {
        get => GetProperty<TerraformProperty<string>>("display_name");
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
    /// The resource labels for connection profile to use to annotate any related underlying resources such as Compute Engine VMs.
    /// 
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
    /// The location where the connection profile should reside.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
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
    /// Block for alloydb.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Alloydb block(s) allowed")]
    public List<GoogleDatabaseMigrationServiceConnectionProfileAlloydbBlock>? Alloydb
    {
        get => GetProperty<List<GoogleDatabaseMigrationServiceConnectionProfileAlloydbBlock>>("alloydb");
        set => this.WithProperty("alloydb", value);
    }

    /// <summary>
    /// Block for cloudsql.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Cloudsql block(s) allowed")]
    public List<GoogleDatabaseMigrationServiceConnectionProfileCloudsqlBlock>? Cloudsql
    {
        get => GetProperty<List<GoogleDatabaseMigrationServiceConnectionProfileCloudsqlBlock>>("cloudsql");
        set => this.WithProperty("cloudsql", value);
    }

    /// <summary>
    /// Block for mysql.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Mysql block(s) allowed")]
    public List<GoogleDatabaseMigrationServiceConnectionProfileMysqlBlock>? Mysql
    {
        get => GetProperty<List<GoogleDatabaseMigrationServiceConnectionProfileMysqlBlock>>("mysql");
        set => this.WithProperty("mysql", value);
    }

    /// <summary>
    /// Block for oracle.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Oracle block(s) allowed")]
    public List<GoogleDatabaseMigrationServiceConnectionProfileOracleBlock>? Oracle
    {
        get => GetProperty<List<GoogleDatabaseMigrationServiceConnectionProfileOracleBlock>>("oracle");
        set => this.WithProperty("oracle", value);
    }

    /// <summary>
    /// Block for postgresql.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Postgresql block(s) allowed")]
    public List<GoogleDatabaseMigrationServiceConnectionProfilePostgresqlBlock>? Postgresql
    {
        get => GetProperty<List<GoogleDatabaseMigrationServiceConnectionProfilePostgresqlBlock>>("postgresql");
        set => this.WithProperty("postgresql", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleDatabaseMigrationServiceConnectionProfileTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleDatabaseMigrationServiceConnectionProfileTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
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
