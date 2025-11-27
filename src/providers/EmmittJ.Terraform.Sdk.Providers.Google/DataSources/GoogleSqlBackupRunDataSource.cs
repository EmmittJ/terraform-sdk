using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_sql_backup_run Terraform data source.
/// Retrieves information about a google_sql_backup_run.
/// </summary>
public partial class GoogleSqlBackupRunDataSource(string name) : TerraformDataSource("google_sql_backup_run", name)
{
    /// <summary>
    /// The identifier for this backup run. Unique only for a specific Cloud SQL instance. If left empty and multiple backups exist for the instance, most_recent must be set to true.
    /// </summary>
    public TerraformValue<double> BackupId
    {
        get => new TerraformReference<double>(this, "backup_id");
        set => SetArgument("backup_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Name of the database instance.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Instance is required")]
    public required TerraformValue<string> Instance
    {
        get => new TerraformReference<string>(this, "instance");
        set => SetArgument("instance", value);
    }

    /// <summary>
    /// Toggles use of the most recent backup run if multiple backups exist for a Cloud SQL instance.
    /// </summary>
    public TerraformValue<bool>? MostRecent
    {
        get => new TerraformReference<bool>(this, "most_recent");
        set => SetArgument("most_recent", value);
    }

    /// <summary>
    /// Project ID of the project that contains the instance.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => new TerraformReference<string>(this, "project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// Location of the backups.
    /// </summary>
    public TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
    }

    /// <summary>
    /// The time the backup operation actually started in UTC timezone in RFC 3339 format, for example 2012-11-15T16:19:00.094Z.
    /// </summary>
    public TerraformValue<string> StartTime
    {
        get => new TerraformReference<string>(this, "start_time");
    }

    /// <summary>
    /// The status of this run.
    /// </summary>
    public TerraformValue<string> Status
    {
        get => new TerraformReference<string>(this, "status");
    }

}
