using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleNetappVolumeQuotaRuleTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_netapp_volume_quota_rule resource.
/// </summary>
public partial class GoogleNetappVolumeQuotaRule : TerraformResource
{
    public GoogleNetappVolumeQuotaRule(string name) : base("google_netapp_volume_quota_rule", name)
    {
    }

    /// <summary>
    /// Description for the quota rule.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The maximum allowed capacity in MiB.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DiskLimitMib is required")]
    [TerraformProperty("disk_limit_mib")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> DiskLimitMib { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Labels as key value pairs of the quota rule. Example: &#39;{ &amp;quot;owner&amp;quot;: &amp;quot;Bob&amp;quot;, &amp;quot;department&amp;quot;: &amp;quot;finance&amp;quot;, &amp;quot;purpose&amp;quot;: &amp;quot;testing&amp;quot; }&#39;.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformProperty("labels")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Labels { get; set; }

    /// <summary>
    /// Loction of the quotaRule. QuotaRules are child resources of volumes and live in the same location.
    /// </summary>
    [TerraformProperty("location")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Location { get; set; }

    /// <summary>
    /// The resource name of the quotaRule.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// The quota rule applies to the specified user or group.
    /// Valid targets for volumes with NFS protocol enabled:
    ///   - UNIX UID for individual user quota
    ///   - UNIX GID for individual group quota
    /// Valid targets for volumes with SMB protocol enabled:
    ///   - Windows SID for individual user quota
    /// Leave empty for default quotas
    /// </summary>
    [TerraformProperty("target")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Target { get; set; }

    /// <summary>
    /// Types of Quota Rule. Possible values: [&amp;quot;INDIVIDUAL_USER_QUOTA&amp;quot;, &amp;quot;INDIVIDUAL_GROUP_QUOTA&amp;quot;, &amp;quot;DEFAULT_USER_QUOTA&amp;quot;, &amp;quot;DEFAULT_GROUP_QUOTA&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Type { get; set; }

    /// <summary>
    /// Name of the volume to create the quotaRule in.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VolumeName is required")]
    [TerraformProperty("volume_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> VolumeName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public GoogleNetappVolumeQuotaRuleTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// Create time of the quota rule. A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format. Examples: &amp;quot;2023-06-22T09:13:01.617Z&amp;quot;.
    /// </summary>
    [TerraformProperty("create_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreateTime { get; }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformProperty("effective_labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> EffectiveLabels { get; }

    /// <summary>
    /// The state of the quota rule. Possible Values : [STATE_UNSPECIFIED, CREATING, UPDATING, READY, DELETING, ERROR]
    /// </summary>
    [TerraformProperty("state")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> State { get; }

    /// <summary>
    /// State details of the quota rule
    /// </summary>
    [TerraformProperty("state_details")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> StateDetails { get; }

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformProperty("terraform_labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> TerraformLabels { get; }

}
