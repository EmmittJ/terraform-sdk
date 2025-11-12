using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for ai_platform_floor_setting in .
/// Nesting mode: list
/// </summary>
public partial class GoogleModelArmorFloorsettingAiPlatformFloorSettingBlock() : TerraformBlock("ai_platform_floor_setting")
{
    /// <summary>
    /// If true, log Model Armor filter results to Cloud Logging.
    /// </summary>
    [TerraformProperty("enable_cloud_logging")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? EnableCloudLogging { get; set; }

    /// <summary>
    /// If true, Model Armor filters will be run in inspect and block mode.
    /// Requests that trip Model Armor filters will be blocked.
    /// </summary>
    [TerraformProperty("inspect_and_block")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? InspectAndBlock { get; set; }

    /// <summary>
    /// If true, Model Armor filters will be run in inspect only mode. No action
    /// will be taken on the request.
    /// </summary>
    [TerraformProperty("inspect_only")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? InspectOnly { get; set; }

}

/// <summary>
/// Block type for filter_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleModelArmorFloorsettingFilterConfigBlock() : TerraformBlock("filter_config")
{
}

/// <summary>
/// Block type for floor_setting_metadata in .
/// Nesting mode: list
/// </summary>
public partial class GoogleModelArmorFloorsettingFloorSettingMetadataBlock() : TerraformBlock("floor_setting_metadata")
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleModelArmorFloorsettingTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Manages a google_model_armor_floorsetting resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleModelArmorFloorsetting : TerraformResource
{
    public GoogleModelArmorFloorsetting(string name) : base("google_model_armor_floorsetting", name)
    {
    }

    /// <summary>
    /// Floor Settings enforcement status.
    /// </summary>
    [TerraformProperty("enable_floor_setting_enforcement")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? EnableFloorSettingEnforcement { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// List of integrated services for which the floor setting is applicable.
    /// </summary>
    [TerraformProperty("integrated_services")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? IntegratedServices { get; set; }

    /// <summary>
    /// Resource ID segment making up resource &#39;name&#39;. It identifies the resource within its parent collection as described in https://google.aip.dev/122.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// Will be any one of these:
    /// 
    /// * &#39;projects/{project}&#39;
    /// * &#39;folders/{folder}&#39;
    /// * &#39;organizations/{organizationId}&#39;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Parent is required")]
    [TerraformProperty("parent")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Parent { get; set; }

    /// <summary>
    /// Block for ai_platform_floor_setting.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AiPlatformFloorSetting block(s) allowed")]
    [TerraformProperty("ai_platform_floor_setting")]
    public TerraformList<GoogleModelArmorFloorsettingAiPlatformFloorSettingBlock> AiPlatformFloorSetting { get; set; } = new();

    /// <summary>
    /// Block for filter_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FilterConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 FilterConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FilterConfig block(s) allowed")]
    [TerraformProperty("filter_config")]
    public required TerraformList<GoogleModelArmorFloorsettingFilterConfigBlock> FilterConfig { get; set; } = new();

    /// <summary>
    /// Block for floor_setting_metadata.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FloorSettingMetadata block(s) allowed")]
    [TerraformProperty("floor_setting_metadata")]
    public TerraformList<GoogleModelArmorFloorsettingFloorSettingMetadataBlock> FloorSettingMetadata { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public GoogleModelArmorFloorsettingTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// [Output only] Create timestamp
    /// </summary>
    [TerraformProperty("create_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreateTime { get; }

    /// <summary>
    /// Identifier. The resource name.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Name { get; }

    /// <summary>
    /// [Output only] Update timestamp
    /// </summary>
    [TerraformProperty("update_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> UpdateTime { get; }

}
