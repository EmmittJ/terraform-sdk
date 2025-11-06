using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_database_migration_service_migration_job resource.
/// </summary>
public class GoogleDatabaseMigrationServiceMigrationJob : TerraformResource
{
    public GoogleDatabaseMigrationServiceMigrationJob(string name) : base("google_database_migration_service_migration_job", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("create_time");
        this.DeclareOutput("effective_labels");
        this.DeclareOutput("error");
        this.DeclareOutput("name");
        this.DeclareOutput("phase");
        this.DeclareOutput("state");
        this.DeclareOutput("terraform_labels");
    }

    /// <summary>
    /// The name of the destination connection profile resource in the form of projects/{project}/locations/{location}/connectionProfiles/{destinationConnectionProfile}.
    /// </summary>
    public string? Destination
    {
        get => GetProperty<TerraformLiteralProperty<string>>("destination")?.Value;
        set => this.WithProperty("destination", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The migration job display name.
    /// </summary>
    public string? DisplayName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("display_name")?.Value;
        set => this.WithProperty("display_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The path to the dump file in Google Cloud Storage,
    /// in the format: (gs://[BUCKET_NAME]/[OBJECT_NAME]).
    /// This field and the &amp;quot;dump_flags&amp;quot; field are mutually exclusive.
    /// </summary>
    public string? DumpPath
    {
        get => GetProperty<TerraformLiteralProperty<string>>("dump_path")?.Value;
        set => this.WithProperty("dump_path", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The type of the data dump. Supported for MySQL to CloudSQL for MySQL
    /// migrations only. Possible values: [&amp;quot;LOGICAL&amp;quot;, &amp;quot;PHYSICAL&amp;quot;]
    /// </summary>
    public string? DumpType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("dump_type")?.Value;
        set => this.WithProperty("dump_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The resource labels for migration job to use to annotate any related underlying resources such as Compute Engine VMs.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public Dictionary<string, string>? Labels
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("labels")?.Value;
        set => this.WithProperty("labels", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The location where the migration job should reside.
    /// </summary>
    public string? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location")?.Value;
        set => this.WithProperty("location", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The ID of the migration job.
    /// </summary>
    public string? MigrationJobId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("migration_job_id")?.Value;
        set => this.WithProperty("migration_job_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public string? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project")?.Value;
        set => this.WithProperty("project", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name of the source connection profile resource in the form of projects/{project}/locations/{location}/connectionProfiles/{sourceConnectionProfile}.
    /// </summary>
    public string? Source
    {
        get => GetProperty<TerraformLiteralProperty<string>>("source")?.Value;
        set => this.WithProperty("source", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The type of the migration job. Possible values: [&amp;quot;ONE_TIME&amp;quot;, &amp;quot;CONTINUOUS&amp;quot;]
    /// </summary>
    public string? Type
    {
        get => GetProperty<TerraformLiteralProperty<string>>("type")?.Value;
        set => this.WithProperty("type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Output only. The timestamp when the resource was created. A timestamp in RFC3339 UTC &#39;Zulu&#39; format, accurate to nanoseconds. Example: &#39;2014-10-02T15:01:23.045123456Z&#39;.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// Output only. The error details in case of state FAILED.
    /// </summary>
    public TerraformExpression Error => this["error"];

    /// <summary>
    /// The name of this migration job resource in the form of projects/{project}/locations/{location}/migrationJobs/{migrationJob}.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The current migration job phase.
    /// </summary>
    public TerraformExpression Phase => this["phase"];

    /// <summary>
    /// The current migration job state.
    /// </summary>
    public TerraformExpression State => this["state"];

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

}
