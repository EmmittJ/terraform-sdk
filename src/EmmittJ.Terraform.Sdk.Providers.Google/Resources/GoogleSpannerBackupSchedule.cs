using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_spanner_backup_schedule resource.
/// </summary>
public class GoogleSpannerBackupSchedule : TerraformResource
{
    public GoogleSpannerBackupSchedule(string name) : base("google_spanner_backup_schedule", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The database to create the backup schedule on.
    /// </summary>
    public TerraformLiteralProperty<string>? Database
    {
        get => GetProperty<TerraformLiteralProperty<string>>("database");
        set => this.WithProperty("database", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The instance to create the database on.
    /// </summary>
    public TerraformLiteralProperty<string>? Instance
    {
        get => GetProperty<TerraformLiteralProperty<string>>("instance");
        set => this.WithProperty("instance", value);
    }

    /// <summary>
    /// A unique identifier for the backup schedule, which cannot be changed after
    /// the backup schedule is created. Values are of the form [a-z][-a-z0-9]*[a-z0-9].
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// At what relative time in the future, compared to its creation time, the backup should be deleted, e.g. keep backups for 7 days.
    /// A duration in seconds with up to nine fractional digits, ending with &#39;s&#39;. Example: &#39;3.5s&#39;.
    /// You can set this to a value up to 366 days.
    /// </summary>
    public TerraformLiteralProperty<string>? RetentionDuration
    {
        get => GetProperty<TerraformLiteralProperty<string>>("retention_duration");
        set => this.WithProperty("retention_duration", value);
    }

}
