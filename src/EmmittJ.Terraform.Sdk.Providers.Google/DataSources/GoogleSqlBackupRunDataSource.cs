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
    public TerraformProperty<double>? BackupId
    {
        get => GetProperty<TerraformProperty<double>>("backup_id");
        set => this.WithProperty("backup_id", value);
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
    /// Name of the database instance.
    /// </summary>
    public TerraformProperty<string>? Instance
    {
        get => GetProperty<TerraformProperty<string>>("instance");
        set => this.WithProperty("instance", value);
    }

    /// <summary>
    /// Toggles use of the most recent backup run if multiple backups exist for a Cloud SQL instance.
    /// </summary>
    public TerraformProperty<bool>? MostRecent
    {
        get => GetProperty<TerraformProperty<bool>>("most_recent");
        set => this.WithProperty("most_recent", value);
    }

    /// <summary>
    /// Project ID of the project that contains the instance.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
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
