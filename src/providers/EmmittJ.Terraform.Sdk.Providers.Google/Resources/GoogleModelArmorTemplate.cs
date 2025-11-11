using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for filter_config in .
/// Nesting mode: list
/// </summary>
public class GoogleModelArmorTemplateFilterConfigBlock
{
}

/// <summary>
/// Block type for template_metadata in .
/// Nesting mode: list
/// </summary>
public class GoogleModelArmorTemplateTemplateMetadataBlock
{
    /// <summary>
    /// Indicates the custom error code set by the user to be returned to the end
    /// user if the LLM response trips Model Armor filters.
    /// </summary>
    [TerraformPropertyName("custom_llm_response_safety_error_code")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? CustomLlmResponseSafetyErrorCode { get; set; }

    /// <summary>
    /// Indicates the custom error message set by the user to be returned to the
    /// end user if the LLM response trips Model Armor filters.
    /// </summary>
    [TerraformPropertyName("custom_llm_response_safety_error_message")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? CustomLlmResponseSafetyErrorMessage { get; set; }

    /// <summary>
    /// Indicates the custom error code set by the user to be returned to the end
    /// user by the service extension if the prompt trips Model Armor filters.
    /// </summary>
    [TerraformPropertyName("custom_prompt_safety_error_code")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? CustomPromptSafetyErrorCode { get; set; }

    /// <summary>
    /// Indicates the custom error message set by the user to be returned to the
    /// end user if the prompt trips Model Armor filters.
    /// </summary>
    [TerraformPropertyName("custom_prompt_safety_error_message")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? CustomPromptSafetyErrorMessage { get; set; }

    /// <summary>
    /// Possible values:
    /// INSPECT_ONLY
    /// INSPECT_AND_BLOCK
    /// </summary>
    [TerraformPropertyName("enforcement_type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? EnforcementType { get; set; }

    /// <summary>
    /// If true, partial detector failures should be ignored.
    /// </summary>
    [TerraformPropertyName("ignore_partial_invocation_failures")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? IgnorePartialInvocationFailures { get; set; }

    /// <summary>
    /// If true, log sanitize operations.
    /// </summary>
    [TerraformPropertyName("log_sanitize_operations")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? LogSanitizeOperations { get; set; }

    /// <summary>
    /// If true, log template crud operations.
    /// </summary>
    [TerraformPropertyName("log_template_operations")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? LogTemplateOperations { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleModelArmorTemplateTimeoutsBlock
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
/// Manages a google_model_armor_template resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleModelArmorTemplate : TerraformResource
{
    public GoogleModelArmorTemplate(string name) : base("google_model_armor_template", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// Labels as key value pairs
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformPropertyName("labels")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Labels { get; set; }

    /// <summary>
    /// Resource ID segment making up resource &#39;name&#39;. It identifies the resource within its parent collection as described in https://google.aip.dev/122.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Project { get; set; } = default!;

    /// <summary>
    /// Id of the requesting object
    /// If auto-generating Id server-side, remove this field and
    /// template_id from the method_signature of Create RPC
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TemplateId is required")]
    [TerraformPropertyName("template_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> TemplateId { get; set; }

    /// <summary>
    /// Block for filter_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FilterConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 FilterConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FilterConfig block(s) allowed")]
    [TerraformPropertyName("filter_config")]
    public TerraformList<TerraformBlock<GoogleModelArmorTemplateFilterConfigBlock>>? FilterConfig { get; set; }

    /// <summary>
    /// Block for template_metadata.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TemplateMetadata block(s) allowed")]
    [TerraformPropertyName("template_metadata")]
    public TerraformList<TerraformBlock<GoogleModelArmorTemplateTemplateMetadataBlock>>? TemplateMetadata { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleModelArmorTemplateTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Create time stamp
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
    /// Identifier. name of resource
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Name => new TerraformReference(this, "name");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformPropertyName("terraform_labels")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> TerraformLabels => new TerraformReference(this, "terraform_labels");

    /// <summary>
    /// Update time stamp
    /// </summary>
    [TerraformPropertyName("update_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> UpdateTime => new TerraformReference(this, "update_time");

}
