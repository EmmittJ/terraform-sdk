using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_firestore_backup_schedule resource.
/// </summary>
public class GoogleFirestoreBackupSchedule : TerraformResource
{
    public GoogleFirestoreBackupSchedule(string name) : base("google_firestore_backup_schedule", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("name");
    }

    /// <summary>
    /// The Firestore database id. Defaults to &#39;&amp;quot;(default)&amp;quot;&#39;.
    /// </summary>
    public TerraformProperty<string>? Database
    {
        get => GetProperty<TerraformProperty<string>>("database");
        set => this.WithProperty("database", value);
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
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// At what relative time in the future, compared to its creation time, the backup should be deleted, e.g. keep backups for 7 days.
    /// A duration in seconds with up to nine fractional digits, ending with &#39;s&#39;. Example: &amp;quot;3.5s&amp;quot;.
    /// 
    /// You can set this to a value up to 14 weeks.
    /// </summary>
    public TerraformProperty<string>? Retention
    {
        get => GetProperty<TerraformProperty<string>>("retention");
        set => this.WithProperty("retention", value);
    }

    /// <summary>
    /// The unique backup schedule identifier across all locations and databases for the given project. Format:
    /// &#39;projects/{{project}}/databases/{{database}}/backupSchedules/{{backupSchedule}}&#39;
    /// </summary>
    public TerraformExpression Name => this["name"];

}
