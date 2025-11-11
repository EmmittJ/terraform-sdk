using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleNetappBackupPolicyTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_netapp_backup_policy resource.
/// </summary>
public class GoogleNetappBackupPolicy : TerraformResource
{
    public GoogleNetappBackupPolicy(string name) : base("google_netapp_backup_policy", name)
    {
    }

    /// <summary>
    /// Number of daily backups to keep. Note that the minimum daily backup limit is 2.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DailyBackupLimit is required")]
    [TerraformPropertyName("daily_backup_limit")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<double> DailyBackupLimit { get; set; }

    /// <summary>
    /// An optional description of this resource.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// If enabled, make backups automatically according to the schedules.
    /// This will be applied to all volumes that have this policy attached and enforced on volume level.
    /// </summary>
    [TerraformPropertyName("enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? Enabled { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// Labels as key value pairs. Example: &#39;{ &amp;quot;owner&amp;quot;: &amp;quot;Bob&amp;quot;, &amp;quot;department&amp;quot;: &amp;quot;finance&amp;quot;, &amp;quot;purpose&amp;quot;: &amp;quot;testing&amp;quot; }&#39;.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformPropertyName("labels")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Labels { get; set; }

    /// <summary>
    /// Name of the region for the policy to apply to.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// Number of monthly backups to keep. Note that the sum of daily, weekly and monthly backups should be greater than 1.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MonthlyBackupLimit is required")]
    [TerraformPropertyName("monthly_backup_limit")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<double> MonthlyBackupLimit { get; set; }

    /// <summary>
    /// The name of the backup policy. Needs to be unique per location.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Project { get; set; } = default!;

    /// <summary>
    /// Number of weekly backups to keep. Note that the sum of daily, weekly and monthly backups should be greater than 1.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WeeklyBackupLimit is required")]
    [TerraformPropertyName("weekly_backup_limit")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<double> WeeklyBackupLimit { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleNetappBackupPolicyTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The total number of volumes assigned by this backup policy.
    /// </summary>
    [TerraformPropertyName("assigned_volume_count")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> AssignedVolumeCount => new TerraformReference(this, "assigned_volume_count");

    /// <summary>
    /// Create time of the backup policy. A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format. Examples: &amp;quot;2023-06-22T09:13:01.617Z&amp;quot;.
    /// </summary>
    [TerraformPropertyName("create_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CreateTime => new TerraformReference(this, "create_time");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformPropertyName("effective_labels")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> EffectiveLabels => new TerraformReference(this, "effective_labels");

    /// <summary>
    /// The state of the backup policy.
    /// </summary>
    [TerraformPropertyName("state")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> State => new TerraformReference(this, "state");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformPropertyName("terraform_labels")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> TerraformLabels => new TerraformReference(this, "terraform_labels");

}
