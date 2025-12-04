using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for ai_platform_floor_setting in GoogleModelArmorFloorsetting.
/// Nesting mode: list
/// </summary>
public class GoogleModelArmorFloorsettingAiPlatformFloorSettingBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ai_platform_floor_setting";

    /// <summary>
    /// If true, log Model Armor filter results to Cloud Logging.
    /// </summary>
    public TerraformValue<bool>? EnableCloudLogging
    {
        get => GetArgument<TerraformValue<bool>>("enable_cloud_logging");
        set => SetArgument("enable_cloud_logging", value);
    }

    /// <summary>
    /// If true, Model Armor filters will be run in inspect and block mode.
    /// Requests that trip Model Armor filters will be blocked.
    /// </summary>
    public TerraformValue<bool>? InspectAndBlock
    {
        get => GetArgument<TerraformValue<bool>>("inspect_and_block");
        set => SetArgument("inspect_and_block", value);
    }

    /// <summary>
    /// If true, Model Armor filters will be run in inspect only mode. No action
    /// will be taken on the request.
    /// </summary>
    public TerraformValue<bool>? InspectOnly
    {
        get => GetArgument<TerraformValue<bool>>("inspect_only");
        set => SetArgument("inspect_only", value);
    }

}


/// <summary>
/// Block type for filter_config in GoogleModelArmorFloorsetting.
/// Nesting mode: list
/// </summary>
public class GoogleModelArmorFloorsettingFilterConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "filter_config";

    /// <summary>
    /// MaliciousUriFilterSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MaliciousUriFilterSettings block(s) allowed")]
    public TerraformList<GoogleModelArmorFloorsettingFilterConfigBlockMaliciousUriFilterSettingsBlock>? MaliciousUriFilterSettings
    {
        get => GetArgument<TerraformList<GoogleModelArmorFloorsettingFilterConfigBlockMaliciousUriFilterSettingsBlock>>("malicious_uri_filter_settings");
        set => SetArgument("malicious_uri_filter_settings", value);
    }

    /// <summary>
    /// PiAndJailbreakFilterSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PiAndJailbreakFilterSettings block(s) allowed")]
    public TerraformList<GoogleModelArmorFloorsettingFilterConfigBlockPiAndJailbreakFilterSettingsBlock>? PiAndJailbreakFilterSettings
    {
        get => GetArgument<TerraformList<GoogleModelArmorFloorsettingFilterConfigBlockPiAndJailbreakFilterSettingsBlock>>("pi_and_jailbreak_filter_settings");
        set => SetArgument("pi_and_jailbreak_filter_settings", value);
    }

    /// <summary>
    /// RaiSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RaiSettings block(s) allowed")]
    public TerraformList<GoogleModelArmorFloorsettingFilterConfigBlockRaiSettingsBlock>? RaiSettings
    {
        get => GetArgument<TerraformList<GoogleModelArmorFloorsettingFilterConfigBlockRaiSettingsBlock>>("rai_settings");
        set => SetArgument("rai_settings", value);
    }

    /// <summary>
    /// SdpSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SdpSettings block(s) allowed")]
    public TerraformList<GoogleModelArmorFloorsettingFilterConfigBlockSdpSettingsBlock>? SdpSettings
    {
        get => GetArgument<TerraformList<GoogleModelArmorFloorsettingFilterConfigBlockSdpSettingsBlock>>("sdp_settings");
        set => SetArgument("sdp_settings", value);
    }

}

/// <summary>
/// Block type for malicious_uri_filter_settings in GoogleModelArmorFloorsettingFilterConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleModelArmorFloorsettingFilterConfigBlockMaliciousUriFilterSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "malicious_uri_filter_settings";

    /// <summary>
    /// Tells whether the Malicious URI filter is enabled or disabled.
    /// Possible values:
    /// ENABLED
    /// DISABLED
    /// </summary>
    public TerraformValue<string>? FilterEnforcement
    {
        get => GetArgument<TerraformValue<string>>("filter_enforcement");
        set => SetArgument("filter_enforcement", value);
    }

}

/// <summary>
/// Block type for pi_and_jailbreak_filter_settings in GoogleModelArmorFloorsettingFilterConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleModelArmorFloorsettingFilterConfigBlockPiAndJailbreakFilterSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "pi_and_jailbreak_filter_settings";

    /// <summary>
    /// Possible values:
    /// LOW_AND_ABOVE
    /// MEDIUM_AND_ABOVE
    /// HIGH
    /// </summary>
    public TerraformValue<string>? ConfidenceLevel
    {
        get => GetArgument<TerraformValue<string>>("confidence_level");
        set => SetArgument("confidence_level", value);
    }

    /// <summary>
    /// Tells whether Prompt injection and Jailbreak filter is enabled or
    /// disabled.
    /// Possible values:
    /// ENABLED
    /// DISABLED
    /// </summary>
    public TerraformValue<string>? FilterEnforcement
    {
        get => GetArgument<TerraformValue<string>>("filter_enforcement");
        set => SetArgument("filter_enforcement", value);
    }

}

/// <summary>
/// Block type for rai_settings in GoogleModelArmorFloorsettingFilterConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleModelArmorFloorsettingFilterConfigBlockRaiSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "rai_settings";

    /// <summary>
    /// RaiFilters block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RaiFilters is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 RaiFilters block(s) required")]
    public required TerraformList<GoogleModelArmorFloorsettingFilterConfigBlockRaiSettingsBlockRaiFiltersBlock> RaiFilters
    {
        get => GetRequiredArgument<TerraformList<GoogleModelArmorFloorsettingFilterConfigBlockRaiSettingsBlockRaiFiltersBlock>>("rai_filters");
        set => SetArgument("rai_filters", value);
    }

}

/// <summary>
/// Block type for rai_filters in GoogleModelArmorFloorsettingFilterConfigBlockRaiSettingsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleModelArmorFloorsettingFilterConfigBlockRaiSettingsBlockRaiFiltersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "rai_filters";

    /// <summary>
    /// Possible values:
    /// LOW_AND_ABOVE
    /// MEDIUM_AND_ABOVE
    /// HIGH
    /// </summary>
    public TerraformValue<string>? ConfidenceLevel
    {
        get => GetArgument<TerraformValue<string>>("confidence_level");
        set => SetArgument("confidence_level", value);
    }

    /// <summary>
    /// Possible values:
    /// SEXUALLY_EXPLICIT
    /// HATE_SPEECH
    /// HARASSMENT
    /// DANGEROUS
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FilterType is required")]
    public required TerraformValue<string> FilterType
    {
        get => GetRequiredArgument<TerraformValue<string>>("filter_type");
        set => SetArgument("filter_type", value);
    }

}

/// <summary>
/// Block type for sdp_settings in GoogleModelArmorFloorsettingFilterConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleModelArmorFloorsettingFilterConfigBlockSdpSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "sdp_settings";

    /// <summary>
    /// AdvancedConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AdvancedConfig block(s) allowed")]
    public TerraformList<GoogleModelArmorFloorsettingFilterConfigBlockSdpSettingsBlockAdvancedConfigBlock>? AdvancedConfig
    {
        get => GetArgument<TerraformList<GoogleModelArmorFloorsettingFilterConfigBlockSdpSettingsBlockAdvancedConfigBlock>>("advanced_config");
        set => SetArgument("advanced_config", value);
    }

    /// <summary>
    /// BasicConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BasicConfig block(s) allowed")]
    public TerraformList<GoogleModelArmorFloorsettingFilterConfigBlockSdpSettingsBlockBasicConfigBlock>? BasicConfig
    {
        get => GetArgument<TerraformList<GoogleModelArmorFloorsettingFilterConfigBlockSdpSettingsBlockBasicConfigBlock>>("basic_config");
        set => SetArgument("basic_config", value);
    }

}

/// <summary>
/// Block type for advanced_config in GoogleModelArmorFloorsettingFilterConfigBlockSdpSettingsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleModelArmorFloorsettingFilterConfigBlockSdpSettingsBlockAdvancedConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "advanced_config";

    /// <summary>
    /// Optional Sensitive Data Protection Deidentify template resource name.
    /// 
    /// If provided then DeidentifyContent action is performed during Sanitization
    /// using this template and inspect template. The De-identified data will
    /// be returned in SdpDeidentifyResult.
    /// Note that all info-types present in the deidentify template must be present
    /// in inspect template.
    /// 
    /// e.g.
    /// &#39;projects/{project}/locations/{location}/deidentifyTemplates/{deidentify_template}&#39;
    /// </summary>
    public TerraformValue<string>? DeidentifyTemplate
    {
        get => GetArgument<TerraformValue<string>>("deidentify_template");
        set => SetArgument("deidentify_template", value);
    }

    /// <summary>
    /// Sensitive Data Protection inspect template resource name
    /// 
    /// If only inspect template is provided (de-identify template not provided),
    /// then Sensitive Data Protection InspectContent action is performed during
    /// Sanitization. All Sensitive Data Protection findings identified during
    /// inspection will be returned as SdpFinding in SdpInsepctionResult.
    /// 
    /// e.g:-
    /// &#39;projects/{project}/locations/{location}/inspectTemplates/{inspect_template}&#39;
    /// </summary>
    public TerraformValue<string>? InspectTemplate
    {
        get => GetArgument<TerraformValue<string>>("inspect_template");
        set => SetArgument("inspect_template", value);
    }

}

/// <summary>
/// Block type for basic_config in GoogleModelArmorFloorsettingFilterConfigBlockSdpSettingsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleModelArmorFloorsettingFilterConfigBlockSdpSettingsBlockBasicConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "basic_config";

    /// <summary>
    /// Tells whether the Sensitive Data Protection basic config is enabled or
    /// disabled.
    /// Possible values:
    /// ENABLED
    /// DISABLED
    /// </summary>
    public TerraformValue<string>? FilterEnforcement
    {
        get => GetArgument<TerraformValue<string>>("filter_enforcement");
        set => SetArgument("filter_enforcement", value);
    }

}


/// <summary>
/// Block type for floor_setting_metadata in GoogleModelArmorFloorsetting.
/// Nesting mode: list
/// </summary>
public class GoogleModelArmorFloorsettingFloorSettingMetadataBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "floor_setting_metadata";

    /// <summary>
    /// MultiLanguageDetection block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MultiLanguageDetection block(s) allowed")]
    public TerraformList<GoogleModelArmorFloorsettingFloorSettingMetadataBlockMultiLanguageDetectionBlock>? MultiLanguageDetection
    {
        get => GetArgument<TerraformList<GoogleModelArmorFloorsettingFloorSettingMetadataBlockMultiLanguageDetectionBlock>>("multi_language_detection");
        set => SetArgument("multi_language_detection", value);
    }

}

/// <summary>
/// Block type for multi_language_detection in GoogleModelArmorFloorsettingFloorSettingMetadataBlock.
/// Nesting mode: list
/// </summary>
public class GoogleModelArmorFloorsettingFloorSettingMetadataBlockMultiLanguageDetectionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "multi_language_detection";

    /// <summary>
    /// If true, multi language detection will be enabled.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EnableMultiLanguageDetection is required")]
    public required TerraformValue<bool> EnableMultiLanguageDetection
    {
        get => GetRequiredArgument<TerraformValue<bool>>("enable_multi_language_detection");
        set => SetArgument("enable_multi_language_detection", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleModelArmorFloorsetting.
/// Nesting mode: single
/// </summary>
public class GoogleModelArmorFloorsettingTimeoutsBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_model_armor_floorsetting Terraform resource.
/// Manages a google_model_armor_floorsetting resource.
/// </summary>
public partial class GoogleModelArmorFloorsetting(string name) : TerraformResource("google_model_armor_floorsetting", name)
{
    /// <summary>
    /// Floor Settings enforcement status.
    /// </summary>
    public TerraformValue<bool>? EnableFloorSettingEnforcement
    {
        get => GetArgument<TerraformValue<bool>>("enable_floor_setting_enforcement");
        set => SetArgument("enable_floor_setting_enforcement", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// List of integrated services for which the floor setting is applicable.
    /// </summary>
    public TerraformList<string>? IntegratedServices
    {
        get => GetArgument<TerraformList<string>>("integrated_services");
        set => SetArgument("integrated_services", value);
    }

    /// <summary>
    /// Resource ID segment making up resource &#39;name&#39;. It identifies the resource within its parent collection as described in https://google.aip.dev/122.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetRequiredArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// Will be any one of these:
    /// 
    /// * &#39;projects/{project}&#39;
    /// * &#39;folders/{folder}&#39;
    /// * &#39;organizations/{organizationId}&#39;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Parent is required")]
    public required TerraformValue<string> Parent
    {
        get => GetRequiredArgument<TerraformValue<string>>("parent");
        set => SetArgument("parent", value);
    }

    /// <summary>
    /// [Output only] Create timestamp
    /// </summary>
    public TerraformValue<string> CreateTime
        => AsReference("create_time");

    /// <summary>
    /// Identifier. The resource name.
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

    /// <summary>
    /// [Output only] Update timestamp
    /// </summary>
    public TerraformValue<string> UpdateTime
        => AsReference("update_time");

    /// <summary>
    /// AiPlatformFloorSetting block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AiPlatformFloorSetting block(s) allowed")]
    public TerraformList<GoogleModelArmorFloorsettingAiPlatformFloorSettingBlock>? AiPlatformFloorSetting
    {
        get => GetArgument<TerraformList<GoogleModelArmorFloorsettingAiPlatformFloorSettingBlock>>("ai_platform_floor_setting");
        set => SetArgument("ai_platform_floor_setting", value);
    }

    /// <summary>
    /// FilterConfig block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FilterConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 FilterConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FilterConfig block(s) allowed")]
    public required TerraformList<GoogleModelArmorFloorsettingFilterConfigBlock> FilterConfig
    {
        get => GetRequiredArgument<TerraformList<GoogleModelArmorFloorsettingFilterConfigBlock>>("filter_config");
        set => SetArgument("filter_config", value);
    }

    /// <summary>
    /// FloorSettingMetadata block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FloorSettingMetadata block(s) allowed")]
    public TerraformList<GoogleModelArmorFloorsettingFloorSettingMetadataBlock>? FloorSettingMetadata
    {
        get => GetArgument<TerraformList<GoogleModelArmorFloorsettingFloorSettingMetadataBlock>>("floor_setting_metadata");
        set => SetArgument("floor_setting_metadata", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleModelArmorFloorsettingTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleModelArmorFloorsettingTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
