using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for filter_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleModelArmorTemplateFilterConfigBlock() : TerraformBlock("filter_config")
{
}

/// <summary>
/// Block type for template_metadata in .
/// Nesting mode: list
/// </summary>
public partial class GoogleModelArmorTemplateTemplateMetadataBlock() : TerraformBlock("template_metadata")
{
    /// <summary>
    /// Indicates the custom error code set by the user to be returned to the end
    /// user if the LLM response trips Model Armor filters.
    /// </summary>
    [TerraformProperty("custom_llm_response_safety_error_code")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? CustomLlmResponseSafetyErrorCode { get; set; }

    /// <summary>
    /// Indicates the custom error message set by the user to be returned to the
    /// end user if the LLM response trips Model Armor filters.
    /// </summary>
    [TerraformProperty("custom_llm_response_safety_error_message")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? CustomLlmResponseSafetyErrorMessage { get; set; }

    /// <summary>
    /// Indicates the custom error code set by the user to be returned to the end
    /// user by the service extension if the prompt trips Model Armor filters.
    /// </summary>
    [TerraformProperty("custom_prompt_safety_error_code")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? CustomPromptSafetyErrorCode { get; set; }

    /// <summary>
    /// Indicates the custom error message set by the user to be returned to the
    /// end user if the prompt trips Model Armor filters.
    /// </summary>
    [TerraformProperty("custom_prompt_safety_error_message")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? CustomPromptSafetyErrorMessage { get; set; }

    /// <summary>
    /// Possible values:
    /// INSPECT_ONLY
    /// INSPECT_AND_BLOCK
    /// </summary>
    [TerraformProperty("enforcement_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? EnforcementType { get; set; }

    /// <summary>
    /// If true, partial detector failures should be ignored.
    /// </summary>
    [TerraformProperty("ignore_partial_invocation_failures")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? IgnorePartialInvocationFailures { get; set; }

    /// <summary>
    /// If true, log sanitize operations.
    /// </summary>
    [TerraformProperty("log_sanitize_operations")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? LogSanitizeOperations { get; set; }

    /// <summary>
    /// If true, log template crud operations.
    /// </summary>
    [TerraformProperty("log_template_operations")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? LogTemplateOperations { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleModelArmorTemplateTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Manages a google_model_armor_template resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleModelArmorTemplate : TerraformResource
{
    public GoogleModelArmorTemplate(string name) : base("google_model_armor_template", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Labels as key value pairs
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformProperty("labels")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Labels { get; set; }

    /// <summary>
    /// Resource ID segment making up resource &#39;name&#39;. It identifies the resource within its parent collection as described in https://google.aip.dev/122.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// Id of the requesting object
    /// If auto-generating Id server-side, remove this field and
    /// template_id from the method_signature of Create RPC
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TemplateId is required")]
    [TerraformProperty("template_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> TemplateId { get; set; }

    /// <summary>
    /// Block for filter_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FilterConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 FilterConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FilterConfig block(s) allowed")]
    [TerraformProperty("filter_config")]
    public required TerraformList<GoogleModelArmorTemplateFilterConfigBlock> FilterConfig { get; set; } = new();

    /// <summary>
    /// Block for template_metadata.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TemplateMetadata block(s) allowed")]
    [TerraformProperty("template_metadata")]
    public TerraformList<GoogleModelArmorTemplateTemplateMetadataBlock> TemplateMetadata { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public GoogleModelArmorTemplateTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// Create time stamp
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
    /// Identifier. name of resource
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Name { get; }

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformProperty("terraform_labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> TerraformLabels { get; }

    /// <summary>
    /// Update time stamp
    /// </summary>
    [TerraformProperty("update_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> UpdateTime { get; }

}
