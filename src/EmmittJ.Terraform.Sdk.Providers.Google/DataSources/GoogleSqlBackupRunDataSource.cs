using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_sql_backup_run.
/// </summary>
public class GoogleSqlBackupRunDataSource : TerraformDataSource
{
    public GoogleSqlBackupRunDataSource(string name) : base("google_sql_backup_run", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("location");
        this.DeclareOutput("start_time");
        this.DeclareOutput("status");
    }

    /// <summary>
    /// The identifier for this backup run. Unique only for a specific Cloud SQL instance. If left empty and multiple backups exist for the instance, most_recent must be set to true.
    /// </summary>
    public double? BackupId
    {
        get => GetProperty<TerraformLiteralProperty<double>>("backup_id")?.Value;
        set => this.WithProperty("backup_id", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
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
    /// Name of the database instance.
    /// </summary>
    public string? Instance
    {
        get => GetProperty<TerraformLiteralProperty<string>>("instance")?.Value;
        set => this.WithProperty("instance", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Toggles use of the most recent backup run if multiple backups exist for a Cloud SQL instance.
    /// </summary>
    public bool? MostRecent
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("most_recent")?.Value;
        set => this.WithProperty("most_recent", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// Project ID of the project that contains the instance.
    /// </summary>
    public string? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project")?.Value;
        set => this.WithProperty("project", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Location of the backups.
    /// </summary>
    public TerraformExpression Location => this["location"];

    /// <summary>
    /// The time the backup operation actually started in UTC timezone in RFC 3339 format, for example 2012-11-15T16:19:00.094Z.
    /// </summary>
    public TerraformExpression StartTime => this["start_time"];

    /// <summary>
    /// The status of this run.
    /// </summary>
    public TerraformExpression Status => this["status"];

}
