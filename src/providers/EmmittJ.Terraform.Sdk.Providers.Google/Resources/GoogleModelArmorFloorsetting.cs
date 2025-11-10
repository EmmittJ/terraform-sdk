using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for ai_platform_floor_setting in .
/// Nesting mode: list
/// </summary>
public class GoogleModelArmorFloorsettingAiPlatformFloorSettingBlock : ITerraformBlock
{
    /// <summary>
    /// If true, log Model Armor filter results to Cloud Logging.
    /// </summary>
    [TerraformPropertyName("enable_cloud_logging")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? EnableCloudLogging { get; set; }

    /// <summary>
    /// If true, Model Armor filters will be run in inspect and block mode.
    /// Requests that trip Model Armor filters will be blocked.
    /// </summary>
    [TerraformPropertyName("inspect_and_block")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? InspectAndBlock { get; set; }

    /// <summary>
    /// If true, Model Armor filters will be run in inspect only mode. No action
    /// will be taken on the request.
    /// </summary>
    [TerraformPropertyName("inspect_only")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? InspectOnly { get; set; }

}

/// <summary>
/// Block type for filter_config in .
/// Nesting mode: list
/// </summary>
public class GoogleModelArmorFloorsettingFilterConfigBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for floor_setting_metadata in .
/// Nesting mode: list
/// </summary>
public class GoogleModelArmorFloorsettingFloorSettingMetadataBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleModelArmorFloorsettingTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a google_model_armor_floorsetting resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleModelArmorFloorsetting : TerraformResource
{
    public GoogleModelArmorFloorsetting(string name) : base("google_model_armor_floorsetting", name)
    {
    }

    /// <summary>
    /// Floor Settings enforcement status.
    /// </summary>
    [TerraformPropertyName("enable_floor_setting_enforcement")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? EnableFloorSettingEnforcement { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// List of integrated services for which the floor setting is applicable.
    /// </summary>
    [TerraformPropertyName("integrated_services")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? IntegratedServices { get; set; }

    /// <summary>
    /// Resource ID segment making up resource &#39;name&#39;. It identifies the resource within its parent collection as described in https://google.aip.dev/122.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Location { get; set; }

    /// <summary>
    /// Will be any one of these:
    /// 
    /// * &#39;projects/{project}&#39;
    /// * &#39;folders/{folder}&#39;
    /// * &#39;organizations/{organizationId}&#39;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Parent is required")]
    [TerraformPropertyName("parent")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Parent { get; set; }

    /// <summary>
    /// Block for ai_platform_floor_setting.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AiPlatformFloorSetting block(s) allowed")]
    [TerraformPropertyName("ai_platform_floor_setting")]
    public TerraformList<TerraformBlock<GoogleModelArmorFloorsettingAiPlatformFloorSettingBlock>>? AiPlatformFloorSetting { get; set; } = new();

    /// <summary>
    /// Block for filter_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FilterConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 FilterConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FilterConfig block(s) allowed")]
    [TerraformPropertyName("filter_config")]
    public TerraformList<TerraformBlock<GoogleModelArmorFloorsettingFilterConfigBlock>>? FilterConfig { get; set; } = new();

    /// <summary>
    /// Block for floor_setting_metadata.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FloorSettingMetadata block(s) allowed")]
    [TerraformPropertyName("floor_setting_metadata")]
    public TerraformList<TerraformBlock<GoogleModelArmorFloorsettingFloorSettingMetadataBlock>>? FloorSettingMetadata { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleModelArmorFloorsettingTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// [Output only] Create timestamp
    /// </summary>
    [TerraformPropertyName("create_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "create_time");

    /// <summary>
    /// Identifier. The resource name.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Name => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

    /// <summary>
    /// [Output only] Update timestamp
    /// </summary>
    [TerraformPropertyName("update_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> UpdateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "update_time");

}
