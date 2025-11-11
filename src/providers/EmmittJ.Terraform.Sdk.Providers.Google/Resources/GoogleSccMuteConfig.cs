using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleSccMuteConfigTimeoutsBlock : TerraformBlockBase
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
/// Manages a google_scc_mute_config resource.
/// </summary>
public partial class GoogleSccMuteConfig : TerraformResource
{
    public GoogleSccMuteConfig(string name) : base("google_scc_mute_config", name)
    {
    }

    /// <summary>
    /// A description of the mute config.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// Optional. The expiry of the mute config. Only applicable for dynamic configs.
    /// If the expiry is set, when the config expires, it is removed from all findings.
    /// 
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to
    /// nine fractional digits. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    [TerraformProperty("expiry_time")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ExpiryTime { get; set; }

    /// <summary>
    /// An expression that defines the filter to apply across create/update
    /// events of findings. While creating a filter string, be mindful of
    /// the scope in which the mute configuration is being created. E.g.,
    /// If a filter contains project = X but is created under the
    /// project = Y scope, it might not match any findings.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Filter is required")]
    [TerraformProperty("filter")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Filter { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Unique identifier provided by the client within the parent scope.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MuteConfigId is required")]
    [TerraformProperty("mute_config_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> MuteConfigId { get; set; }

    /// <summary>
    /// Resource name of the new mute configs&#39;s parent. Its format is
    /// &amp;quot;organizations/[organization_id]&amp;quot;, &amp;quot;folders/[folder_id]&amp;quot;, or
    /// &amp;quot;projects/[project_id]&amp;quot;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Parent is required")]
    [TerraformProperty("parent")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Parent { get; set; }

    /// <summary>
    /// The type of the mute config, which determines what type of mute state the config affects. Default value: &amp;quot;DYNAMIC&amp;quot; Possible values: [&amp;quot;MUTE_CONFIG_TYPE_UNSPECIFIED&amp;quot;, &amp;quot;STATIC&amp;quot;, &amp;quot;DYNAMIC&amp;quot;]
    /// </summary>
    [TerraformProperty("type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Type { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<GoogleSccMuteConfigTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The time at which the mute config was created. This field is set by
    /// the server and will be ignored if provided on config creation.
    /// </summary>
    [TerraformProperty("create_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreateTime { get; }

    /// <summary>
    /// Email address of the user who last edited the mute config. This
    /// field is set by the server and will be ignored if provided on
    /// config creation or update.
    /// </summary>
    [TerraformProperty("most_recent_editor")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> MostRecentEditor { get; }

    /// <summary>
    /// Name of the mute config. Its format is
    /// organizations/{organization}/muteConfigs/{configId},
    /// folders/{folder}/muteConfigs/{configId},
    /// or projects/{project}/muteConfigs/{configId}
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Name { get; }

    /// <summary>
    /// Output only. The most recent time at which the mute config was
    /// updated. This field is set by the server and will be ignored if
    /// provided on config creation or update.
    /// </summary>
    [TerraformProperty("update_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> UpdateTime { get; }

}
