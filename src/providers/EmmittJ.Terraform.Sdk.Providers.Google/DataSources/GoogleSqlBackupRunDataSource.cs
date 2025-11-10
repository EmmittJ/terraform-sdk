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
        SetOutput("location");
        SetOutput("start_time");
        SetOutput("status");
        SetOutput("backup_id");
        SetOutput("id");
        SetOutput("instance");
        SetOutput("most_recent");
        SetOutput("project");
    }

    /// <summary>
    /// The identifier for this backup run. Unique only for a specific Cloud SQL instance. If left empty and multiple backups exist for the instance, most_recent must be set to true.
    /// </summary>
    public TerraformProperty<double> BackupId
    {
        get => GetRequiredOutput<TerraformProperty<double>>("backup_id");
        set => SetProperty("backup_id", value);
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
    /// Name of the database instance.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Instance is required")]
    public required TerraformProperty<string> Instance
    {
        get => GetRequiredOutput<TerraformProperty<string>>("instance");
        set => SetProperty("instance", value);
    }

    /// <summary>
    /// Toggles use of the most recent backup run if multiple backups exist for a Cloud SQL instance.
    /// </summary>
    public TerraformProperty<bool> MostRecent
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("most_recent");
        set => SetProperty("most_recent", value);
    }

    /// <summary>
    /// Project ID of the project that contains the instance.
    /// </summary>
    public TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
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
