using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for filter_config in GoogleModelArmorTemplate.
/// Nesting mode: list
/// </summary>
public class GoogleModelArmorTemplateFilterConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "filter_config";

    /// <summary>
    /// MaliciousUriFilterSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MaliciousUriFilterSettings block(s) allowed")]
    public TerraformList<GoogleModelArmorTemplateFilterConfigBlockMaliciousUriFilterSettingsBlock>? MaliciousUriFilterSettings
    {
        get => GetArgument<TerraformList<GoogleModelArmorTemplateFilterConfigBlockMaliciousUriFilterSettingsBlock>>("malicious_uri_filter_settings");
        set => SetArgument("malicious_uri_filter_settings", value);
    }

    /// <summary>
    /// PiAndJailbreakFilterSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PiAndJailbreakFilterSettings block(s) allowed")]
    public TerraformList<GoogleModelArmorTemplateFilterConfigBlockPiAndJailbreakFilterSettingsBlock>? PiAndJailbreakFilterSettings
    {
        get => GetArgument<TerraformList<GoogleModelArmorTemplateFilterConfigBlockPiAndJailbreakFilterSettingsBlock>>("pi_and_jailbreak_filter_settings");
        set => SetArgument("pi_and_jailbreak_filter_settings", value);
    }

    /// <summary>
    /// RaiSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RaiSettings block(s) allowed")]
    public TerraformList<GoogleModelArmorTemplateFilterConfigBlockRaiSettingsBlock>? RaiSettings
    {
        get => GetArgument<TerraformList<GoogleModelArmorTemplateFilterConfigBlockRaiSettingsBlock>>("rai_settings");
        set => SetArgument("rai_settings", value);
    }

    /// <summary>
    /// SdpSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SdpSettings block(s) allowed")]
    public TerraformList<GoogleModelArmorTemplateFilterConfigBlockSdpSettingsBlock>? SdpSettings
    {
        get => GetArgument<TerraformList<GoogleModelArmorTemplateFilterConfigBlockSdpSettingsBlock>>("sdp_settings");
        set => SetArgument("sdp_settings", value);
    }

}

/// <summary>
/// Block type for malicious_uri_filter_settings in GoogleModelArmorTemplateFilterConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleModelArmorTemplateFilterConfigBlockMaliciousUriFilterSettingsBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "filter_enforcement");
        set => SetArgument("filter_enforcement", value);
    }

}

/// <summary>
/// Block type for pi_and_jailbreak_filter_settings in GoogleModelArmorTemplateFilterConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleModelArmorTemplateFilterConfigBlockPiAndJailbreakFilterSettingsBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "confidence_level");
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
        get => new TerraformReference<string>(this, "filter_enforcement");
        set => SetArgument("filter_enforcement", value);
    }

}

/// <summary>
/// Block type for rai_settings in GoogleModelArmorTemplateFilterConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleModelArmorTemplateFilterConfigBlockRaiSettingsBlock : TerraformBlock
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
    public required TerraformList<GoogleModelArmorTemplateFilterConfigBlockRaiSettingsBlockRaiFiltersBlock> RaiFilters
    {
        get => GetRequiredArgument<TerraformList<GoogleModelArmorTemplateFilterConfigBlockRaiSettingsBlockRaiFiltersBlock>>("rai_filters");
        set => SetArgument("rai_filters", value);
    }

}

/// <summary>
/// Block type for rai_filters in GoogleModelArmorTemplateFilterConfigBlockRaiSettingsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleModelArmorTemplateFilterConfigBlockRaiSettingsBlockRaiFiltersBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "confidence_level");
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
        get => new TerraformReference<string>(this, "filter_type");
        set => SetArgument("filter_type", value);
    }

}

/// <summary>
/// Block type for sdp_settings in GoogleModelArmorTemplateFilterConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleModelArmorTemplateFilterConfigBlockSdpSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "sdp_settings";

    /// <summary>
    /// AdvancedConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AdvancedConfig block(s) allowed")]
    public TerraformList<GoogleModelArmorTemplateFilterConfigBlockSdpSettingsBlockAdvancedConfigBlock>? AdvancedConfig
    {
        get => GetArgument<TerraformList<GoogleModelArmorTemplateFilterConfigBlockSdpSettingsBlockAdvancedConfigBlock>>("advanced_config");
        set => SetArgument("advanced_config", value);
    }

    /// <summary>
    /// BasicConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BasicConfig block(s) allowed")]
    public TerraformList<GoogleModelArmorTemplateFilterConfigBlockSdpSettingsBlockBasicConfigBlock>? BasicConfig
    {
        get => GetArgument<TerraformList<GoogleModelArmorTemplateFilterConfigBlockSdpSettingsBlockBasicConfigBlock>>("basic_config");
        set => SetArgument("basic_config", value);
    }

}

/// <summary>
/// Block type for advanced_config in GoogleModelArmorTemplateFilterConfigBlockSdpSettingsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleModelArmorTemplateFilterConfigBlockSdpSettingsBlockAdvancedConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "advanced_config";

    /// <summary>
    /// Optional Sensitive Data Protection Deidentify template resource name.
    /// If provided then DeidentifyContent action is performed during Sanitization
    /// using this template and inspect template. The De-identified data will
    /// be returned in SdpDeidentifyResult.
    /// Note that all info-types present in the deidentify template must be present
    /// in inspect template.
    /// e.g.
    /// &#39;projects/{project}/locations/{location}/deidentifyTemplates/{deidentify_template}&#39;
    /// </summary>
    public TerraformValue<string>? DeidentifyTemplate
    {
        get => new TerraformReference<string>(this, "deidentify_template");
        set => SetArgument("deidentify_template", value);
    }

    /// <summary>
    /// Sensitive Data Protection inspect template resource name
    /// If only inspect template is provided (de-identify template not provided),
    /// then Sensitive Data Protection InspectContent action is performed during
    /// Sanitization. All Sensitive Data Protection findings identified during
    /// inspection will be returned as SdpFinding in SdpInsepctionResult.
    /// e.g:-
    /// &#39;projects/{project}/locations/{location}/inspectTemplates/{inspect_template}&#39;
    /// </summary>
    public TerraformValue<string>? InspectTemplate
    {
        get => new TerraformReference<string>(this, "inspect_template");
        set => SetArgument("inspect_template", value);
    }

}

/// <summary>
/// Block type for basic_config in GoogleModelArmorTemplateFilterConfigBlockSdpSettingsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleModelArmorTemplateFilterConfigBlockSdpSettingsBlockBasicConfigBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "filter_enforcement");
        set => SetArgument("filter_enforcement", value);
    }

}


/// <summary>
/// Block type for template_metadata in GoogleModelArmorTemplate.
/// Nesting mode: list
/// </summary>
public class GoogleModelArmorTemplateTemplateMetadataBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "template_metadata";

    /// <summary>
    /// Indicates the custom error code set by the user to be returned to the end
    /// user if the LLM response trips Model Armor filters.
    /// </summary>
    public TerraformValue<double>? CustomLlmResponseSafetyErrorCode
    {
        get => new TerraformReference<double>(this, "custom_llm_response_safety_error_code");
        set => SetArgument("custom_llm_response_safety_error_code", value);
    }

    /// <summary>
    /// Indicates the custom error message set by the user to be returned to the
    /// end user if the LLM response trips Model Armor filters.
    /// </summary>
    public TerraformValue<string>? CustomLlmResponseSafetyErrorMessage
    {
        get => new TerraformReference<string>(this, "custom_llm_response_safety_error_message");
        set => SetArgument("custom_llm_response_safety_error_message", value);
    }

    /// <summary>
    /// Indicates the custom error code set by the user to be returned to the end
    /// user by the service extension if the prompt trips Model Armor filters.
    /// </summary>
    public TerraformValue<double>? CustomPromptSafetyErrorCode
    {
        get => new TerraformReference<double>(this, "custom_prompt_safety_error_code");
        set => SetArgument("custom_prompt_safety_error_code", value);
    }

    /// <summary>
    /// Indicates the custom error message set by the user to be returned to the
    /// end user if the prompt trips Model Armor filters.
    /// </summary>
    public TerraformValue<string>? CustomPromptSafetyErrorMessage
    {
        get => new TerraformReference<string>(this, "custom_prompt_safety_error_message");
        set => SetArgument("custom_prompt_safety_error_message", value);
    }

    /// <summary>
    /// Possible values:
    /// INSPECT_ONLY
    /// INSPECT_AND_BLOCK
    /// </summary>
    public TerraformValue<string>? EnforcementType
    {
        get => new TerraformReference<string>(this, "enforcement_type");
        set => SetArgument("enforcement_type", value);
    }

    /// <summary>
    /// If true, partial detector failures should be ignored.
    /// </summary>
    public TerraformValue<bool>? IgnorePartialInvocationFailures
    {
        get => new TerraformReference<bool>(this, "ignore_partial_invocation_failures");
        set => SetArgument("ignore_partial_invocation_failures", value);
    }

    /// <summary>
    /// If true, log sanitize operations.
    /// </summary>
    public TerraformValue<bool>? LogSanitizeOperations
    {
        get => new TerraformReference<bool>(this, "log_sanitize_operations");
        set => SetArgument("log_sanitize_operations", value);
    }

    /// <summary>
    /// If true, log template crud operations.
    /// </summary>
    public TerraformValue<bool>? LogTemplateOperations
    {
        get => new TerraformReference<bool>(this, "log_template_operations");
        set => SetArgument("log_template_operations", value);
    }

    /// <summary>
    /// MultiLanguageDetection block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MultiLanguageDetection block(s) allowed")]
    public TerraformList<GoogleModelArmorTemplateTemplateMetadataBlockMultiLanguageDetectionBlock>? MultiLanguageDetection
    {
        get => GetArgument<TerraformList<GoogleModelArmorTemplateTemplateMetadataBlockMultiLanguageDetectionBlock>>("multi_language_detection");
        set => SetArgument("multi_language_detection", value);
    }

}

/// <summary>
/// Block type for multi_language_detection in GoogleModelArmorTemplateTemplateMetadataBlock.
/// Nesting mode: list
/// </summary>
public class GoogleModelArmorTemplateTemplateMetadataBlockMultiLanguageDetectionBlock : TerraformBlock
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
        get => new TerraformReference<bool>(this, "enable_multi_language_detection");
        set => SetArgument("enable_multi_language_detection", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleModelArmorTemplate.
/// Nesting mode: single
/// </summary>
public class GoogleModelArmorTemplateTimeoutsBlock : TerraformBlock
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
/// Represents a google_model_armor_template Terraform resource.
/// Manages a google_model_armor_template resource.
/// </summary>
public partial class GoogleModelArmorTemplate(string name) : TerraformResource("google_model_armor_template", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Labels as key value pairs
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
    /// Resource ID segment making up resource &#39;name&#39;. It identifies the resource within its parent collection as described in https://google.aip.dev/122.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
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
    /// Id of the requesting object
    /// If auto-generating Id server-side, remove this field and
    /// template_id from the method_signature of Create RPC
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TemplateId is required")]
    public required TerraformValue<string> TemplateId
    {
        get => new TerraformReference<string>(this, "template_id");
        set => SetArgument("template_id", value);
    }

    /// <summary>
    /// Create time stamp
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
    /// Identifier. name of resource
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
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
    /// Update time stamp
    /// </summary>
    public TerraformValue<string> UpdateTime
    {
        get => new TerraformReference<string>(this, "update_time");
    }

    /// <summary>
    /// FilterConfig block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FilterConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 FilterConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FilterConfig block(s) allowed")]
    public required TerraformList<GoogleModelArmorTemplateFilterConfigBlock> FilterConfig
    {
        get => GetRequiredArgument<TerraformList<GoogleModelArmorTemplateFilterConfigBlock>>("filter_config");
        set => SetArgument("filter_config", value);
    }

    /// <summary>
    /// TemplateMetadata block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TemplateMetadata block(s) allowed")]
    public TerraformList<GoogleModelArmorTemplateTemplateMetadataBlock>? TemplateMetadata
    {
        get => GetArgument<TerraformList<GoogleModelArmorTemplateTemplateMetadataBlock>>("template_metadata");
        set => SetArgument("template_metadata", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleModelArmorTemplateTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleModelArmorTemplateTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
