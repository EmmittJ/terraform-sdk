using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleNetappBackupPolicyTimeoutsBlock : TerraformBlock
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
/// Manages a google_netapp_backup_policy resource.
/// </summary>
public class GoogleNetappBackupPolicy : TerraformResource
{
    public GoogleNetappBackupPolicy(string name) : base("google_netapp_backup_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("assigned_volume_count");
        SetOutput("create_time");
        SetOutput("effective_labels");
        SetOutput("state");
        SetOutput("terraform_labels");
        SetOutput("daily_backup_limit");
        SetOutput("description");
        SetOutput("enabled");
        SetOutput("id");
        SetOutput("labels");
        SetOutput("location");
        SetOutput("monthly_backup_limit");
        SetOutput("name");
        SetOutput("project");
        SetOutput("weekly_backup_limit");
    }

    /// <summary>
    /// Number of daily backups to keep. Note that the minimum daily backup limit is 2.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DailyBackupLimit is required")]
    public required TerraformProperty<double> DailyBackupLimit
    {
        get => GetRequiredOutput<TerraformProperty<double>>("daily_backup_limit");
        set => SetProperty("daily_backup_limit", value);
    }

    /// <summary>
    /// An optional description of this resource.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// If enabled, make backups automatically according to the schedules.
    /// This will be applied to all volumes that have this policy attached and enforced on volume level.
    /// </summary>
    public TerraformProperty<bool> Enabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("enabled");
        set => SetProperty("enabled", value);
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
    /// Labels as key value pairs. Example: &#39;{ &amp;quot;owner&amp;quot;: &amp;quot;Bob&amp;quot;, &amp;quot;department&amp;quot;: &amp;quot;finance&amp;quot;, &amp;quot;purpose&amp;quot;: &amp;quot;testing&amp;quot; }&#39;.
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
    /// Name of the region for the policy to apply to.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// Number of monthly backups to keep. Note that the sum of daily, weekly and monthly backups should be greater than 1.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MonthlyBackupLimit is required")]
    public required TerraformProperty<double> MonthlyBackupLimit
    {
        get => GetRequiredOutput<TerraformProperty<double>>("monthly_backup_limit");
        set => SetProperty("monthly_backup_limit", value);
    }

    /// <summary>
    /// The name of the backup policy. Needs to be unique per location.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
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
    /// Number of weekly backups to keep. Note that the sum of daily, weekly and monthly backups should be greater than 1.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WeeklyBackupLimit is required")]
    public required TerraformProperty<double> WeeklyBackupLimit
    {
        get => GetRequiredOutput<TerraformProperty<double>>("weekly_backup_limit");
        set => SetProperty("weekly_backup_limit", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleNetappBackupPolicyTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The total number of volumes assigned by this backup policy.
    /// </summary>
    public TerraformExpression AssignedVolumeCount => this["assigned_volume_count"];

    /// <summary>
    /// Create time of the backup policy. A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format. Examples: &amp;quot;2023-06-22T09:13:01.617Z&amp;quot;.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// The state of the backup policy.
    /// </summary>
    public TerraformExpression State => this["state"];

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

}
