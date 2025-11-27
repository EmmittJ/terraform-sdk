using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleNetappBackupPolicy.
/// Nesting mode: single
/// </summary>
public class GoogleNetappBackupPolicyTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_netapp_backup_policy Terraform resource.
/// Manages a google_netapp_backup_policy resource.
/// </summary>
public partial class GoogleNetappBackupPolicy(string name) : TerraformResource("google_netapp_backup_policy", name)
{
    /// <summary>
    /// Number of daily backups to keep. Note that the minimum daily backup limit is 2.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DailyBackupLimit is required")]
    public required TerraformValue<double> DailyBackupLimit
    {
        get => new TerraformReference<double>(this, "daily_backup_limit");
        set => SetArgument("daily_backup_limit", value);
    }

    /// <summary>
    /// An optional description of this resource.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// If enabled, make backups automatically according to the schedules.
    /// This will be applied to all volumes that have this policy attached and enforced on volume level.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
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
    /// Labels as key value pairs. Example: &#39;{ &amp;quot;owner&amp;quot;: &amp;quot;Bob&amp;quot;, &amp;quot;department&amp;quot;: &amp;quot;finance&amp;quot;, &amp;quot;purpose&amp;quot;: &amp;quot;testing&amp;quot; }&#39;.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformMap<string>? Labels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "labels").ResolveNodes(ctx));
        set => SetArgument("labels", value);
    }

    /// <summary>
    /// Name of the region for the policy to apply to.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// Number of monthly backups to keep. Note that the sum of daily, weekly and monthly backups should be greater than 1.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MonthlyBackupLimit is required")]
    public required TerraformValue<double> MonthlyBackupLimit
    {
        get => new TerraformReference<double>(this, "monthly_backup_limit");
        set => SetArgument("monthly_backup_limit", value);
    }

    /// <summary>
    /// The name of the backup policy. Needs to be unique per location.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => new TerraformReference<string>(this, "project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// Number of weekly backups to keep. Note that the sum of daily, weekly and monthly backups should be greater than 1.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WeeklyBackupLimit is required")]
    public required TerraformValue<double> WeeklyBackupLimit
    {
        get => new TerraformReference<double>(this, "weekly_backup_limit");
        set => SetArgument("weekly_backup_limit", value);
    }

    /// <summary>
    /// The total number of volumes assigned by this backup policy.
    /// </summary>
    public TerraformValue<double> AssignedVolumeCount
    {
        get => new TerraformReference<double>(this, "assigned_volume_count");
    }

    /// <summary>
    /// Create time of the backup policy. A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format. Examples: &amp;quot;2023-06-22T09:13:01.617Z&amp;quot;.
    /// </summary>
    public TerraformValue<string> CreateTime
    {
        get => new TerraformReference<string>(this, "create_time");
    }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "effective_labels").ResolveNodes(ctx));
    }

    /// <summary>
    /// The state of the backup policy.
    /// </summary>
    public TerraformValue<string> State
    {
        get => new TerraformReference<string>(this, "state");
    }

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "terraform_labels").ResolveNodes(ctx));
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleNetappBackupPolicyTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleNetappBackupPolicyTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
