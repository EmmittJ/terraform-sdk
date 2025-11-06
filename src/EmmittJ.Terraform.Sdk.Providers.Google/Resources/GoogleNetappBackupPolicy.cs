using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

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
        this.DeclareOutput("assigned_volume_count");
        this.DeclareOutput("create_time");
        this.DeclareOutput("effective_labels");
        this.DeclareOutput("state");
        this.DeclareOutput("terraform_labels");
    }

    /// <summary>
    /// Number of daily backups to keep. Note that the minimum daily backup limit is 2.
    /// </summary>
    public double? DailyBackupLimit
    {
        get => GetProperty<TerraformLiteralProperty<double>>("daily_backup_limit")?.Value;
        set => this.WithProperty("daily_backup_limit", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// An optional description of this resource.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// If enabled, make backups automatically according to the schedules.
    /// This will be applied to all volumes that have this policy attached and enforced on volume level.
    /// </summary>
    public bool? Enabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enabled")?.Value;
        set => this.WithProperty("enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    /// Labels as key value pairs. Example: &#39;{ &amp;quot;owner&amp;quot;: &amp;quot;Bob&amp;quot;, &amp;quot;department&amp;quot;: &amp;quot;finance&amp;quot;, &amp;quot;purpose&amp;quot;: &amp;quot;testing&amp;quot; }&#39;.
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
    /// Name of the region for the policy to apply to.
    /// </summary>
    public string? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location")?.Value;
        set => this.WithProperty("location", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Number of monthly backups to keep. Note that the sum of daily, weekly and monthly backups should be greater than 1.
    /// </summary>
    public double? MonthlyBackupLimit
    {
        get => GetProperty<TerraformLiteralProperty<double>>("monthly_backup_limit")?.Value;
        set => this.WithProperty("monthly_backup_limit", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The name of the backup policy. Needs to be unique per location.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// Number of weekly backups to keep. Note that the sum of daily, weekly and monthly backups should be greater than 1.
    /// </summary>
    public double? WeeklyBackupLimit
    {
        get => GetProperty<TerraformLiteralProperty<double>>("weekly_backup_limit")?.Value;
        set => this.WithProperty("weekly_backup_limit", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
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
