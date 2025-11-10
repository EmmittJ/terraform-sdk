using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for filter_config in .
/// Nesting mode: list
/// </summary>
public class GoogleModelArmorTemplateFilterConfigBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for template_metadata in .
/// Nesting mode: list
/// </summary>
public class GoogleModelArmorTemplateTemplateMetadataBlock : ITerraformBlock
{
    /// <summary>
    /// Indicates the custom error code set by the user to be returned to the end
    /// user if the LLM response trips Model Armor filters.
    /// </summary>
    [TerraformPropertyName("custom_llm_response_safety_error_code")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? CustomLlmResponseSafetyErrorCode { get; set; }

    /// <summary>
    /// Indicates the custom error message set by the user to be returned to the
    /// end user if the LLM response trips Model Armor filters.
    /// </summary>
    [TerraformPropertyName("custom_llm_response_safety_error_message")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? CustomLlmResponseSafetyErrorMessage { get; set; }

    /// <summary>
    /// Indicates the custom error code set by the user to be returned to the end
    /// user by the service extension if the prompt trips Model Armor filters.
    /// </summary>
    [TerraformPropertyName("custom_prompt_safety_error_code")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? CustomPromptSafetyErrorCode { get; set; }

    /// <summary>
    /// Indicates the custom error message set by the user to be returned to the
    /// end user if the prompt trips Model Armor filters.
    /// </summary>
    [TerraformPropertyName("custom_prompt_safety_error_message")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? CustomPromptSafetyErrorMessage { get; set; }

    /// <summary>
    /// Possible values:
    /// INSPECT_ONLY
    /// INSPECT_AND_BLOCK
    /// </summary>
    [TerraformPropertyName("enforcement_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? EnforcementType { get; set; }

    /// <summary>
    /// If true, partial detector failures should be ignored.
    /// </summary>
    [TerraformPropertyName("ignore_partial_invocation_failures")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? IgnorePartialInvocationFailures { get; set; }

    /// <summary>
    /// If true, log sanitize operations.
    /// </summary>
    [TerraformPropertyName("log_sanitize_operations")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? LogSanitizeOperations { get; set; }

    /// <summary>
    /// If true, log template crud operations.
    /// </summary>
    [TerraformPropertyName("log_template_operations")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? LogTemplateOperations { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleModelArmorTemplateTimeoutsBlock : ITerraformBlock
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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Labels as key value pairs
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformPropertyName("labels")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Labels { get; set; }

    /// <summary>
    /// Resource ID segment making up resource &#39;name&#39;. It identifies the resource within its parent collection as described in https://google.aip.dev/122.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Location { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Project { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "project");

    /// <summary>
    /// Id of the requesting object
    /// If auto-generating Id server-side, remove this field and
    /// template_id from the method_signature of Create RPC
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TemplateId is required")]
    [TerraformPropertyName("template_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> TemplateId { get; set; }

    /// <summary>
    /// Block for filter_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FilterConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 FilterConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FilterConfig block(s) allowed")]
    [TerraformPropertyName("filter_config")]
    public TerraformList<TerraformBlock<GoogleModelArmorTemplateFilterConfigBlock>>? FilterConfig { get; set; } = new();

    /// <summary>
    /// Block for template_metadata.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TemplateMetadata block(s) allowed")]
    [TerraformPropertyName("template_metadata")]
    public TerraformList<TerraformBlock<GoogleModelArmorTemplateTemplateMetadataBlock>>? TemplateMetadata { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleModelArmorTemplateTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// Create time stamp
    /// </summary>
    [TerraformPropertyName("create_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "create_time");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformPropertyName("effective_labels")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> EffectiveLabels => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "effective_labels");

    /// <summary>
    /// Identifier. name of resource
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Name => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformPropertyName("terraform_labels")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TerraformLabels => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "terraform_labels");

    /// <summary>
    /// Update time stamp
    /// </summary>
    [TerraformPropertyName("update_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> UpdateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "update_time");

}
