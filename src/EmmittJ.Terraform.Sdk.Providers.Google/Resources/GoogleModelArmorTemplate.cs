using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for filter_config in .
/// Nesting mode: list
/// </summary>
public class GoogleModelArmorTemplateFilterConfigBlock : TerraformBlock
{
}

/// <summary>
/// Block type for template_metadata in .
/// Nesting mode: list
/// </summary>
public class GoogleModelArmorTemplateTemplateMetadataBlock : TerraformBlock
{
    /// <summary>
    /// Indicates the custom error code set by the user to be returned to the end
    /// user if the LLM response trips Model Armor filters.
    /// </summary>
    public TerraformProperty<double>? CustomLlmResponseSafetyErrorCode
    {
        get => GetProperty<TerraformProperty<double>>("custom_llm_response_safety_error_code");
        set => WithProperty("custom_llm_response_safety_error_code", value);
    }

    /// <summary>
    /// Indicates the custom error message set by the user to be returned to the
    /// end user if the LLM response trips Model Armor filters.
    /// </summary>
    public TerraformProperty<string>? CustomLlmResponseSafetyErrorMessage
    {
        get => GetProperty<TerraformProperty<string>>("custom_llm_response_safety_error_message");
        set => WithProperty("custom_llm_response_safety_error_message", value);
    }

    /// <summary>
    /// Indicates the custom error code set by the user to be returned to the end
    /// user by the service extension if the prompt trips Model Armor filters.
    /// </summary>
    public TerraformProperty<double>? CustomPromptSafetyErrorCode
    {
        get => GetProperty<TerraformProperty<double>>("custom_prompt_safety_error_code");
        set => WithProperty("custom_prompt_safety_error_code", value);
    }

    /// <summary>
    /// Indicates the custom error message set by the user to be returned to the
    /// end user if the prompt trips Model Armor filters.
    /// </summary>
    public TerraformProperty<string>? CustomPromptSafetyErrorMessage
    {
        get => GetProperty<TerraformProperty<string>>("custom_prompt_safety_error_message");
        set => WithProperty("custom_prompt_safety_error_message", value);
    }

    /// <summary>
    /// Possible values:
    /// INSPECT_ONLY
    /// INSPECT_AND_BLOCK
    /// </summary>
    public TerraformProperty<string>? EnforcementType
    {
        get => GetProperty<TerraformProperty<string>>("enforcement_type");
        set => WithProperty("enforcement_type", value);
    }

    /// <summary>
    /// If true, partial detector failures should be ignored.
    /// </summary>
    public TerraformProperty<bool>? IgnorePartialInvocationFailures
    {
        get => GetProperty<TerraformProperty<bool>>("ignore_partial_invocation_failures");
        set => WithProperty("ignore_partial_invocation_failures", value);
    }

    /// <summary>
    /// If true, log sanitize operations.
    /// </summary>
    public TerraformProperty<bool>? LogSanitizeOperations
    {
        get => GetProperty<TerraformProperty<bool>>("log_sanitize_operations");
        set => WithProperty("log_sanitize_operations", value);
    }

    /// <summary>
    /// If true, log template crud operations.
    /// </summary>
    public TerraformProperty<bool>? LogTemplateOperations
    {
        get => GetProperty<TerraformProperty<bool>>("log_template_operations");
        set => WithProperty("log_template_operations", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleModelArmorTemplateTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a google_model_armor_template resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleModelArmorTemplate : TerraformResource
{
    public GoogleModelArmorTemplate(string name) : base("google_model_armor_template", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("create_time");
        this.DeclareOutput("effective_labels");
        this.DeclareOutput("name");
        this.DeclareOutput("terraform_labels");
        this.DeclareOutput("update_time");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// Labels as key value pairs
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Labels
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("labels");
        set => this.WithProperty("labels", value);
    }

    /// <summary>
    /// Resource ID segment making up resource &#39;name&#39;. It identifies the resource within its parent collection as described in https://google.aip.dev/122.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// Id of the requesting object
    /// If auto-generating Id server-side, remove this field and
    /// template_id from the method_signature of Create RPC
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TemplateId is required")]
    public required TerraformProperty<string> TemplateId
    {
        get => GetProperty<TerraformProperty<string>>("template_id");
        set => this.WithProperty("template_id", value);
    }

    /// <summary>
    /// Block for filter_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 FilterConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FilterConfig block(s) allowed")]
    public List<GoogleModelArmorTemplateFilterConfigBlock>? FilterConfig
    {
        get => GetProperty<List<GoogleModelArmorTemplateFilterConfigBlock>>("filter_config");
        set => this.WithProperty("filter_config", value);
    }

    /// <summary>
    /// Block for template_metadata.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TemplateMetadata block(s) allowed")]
    public List<GoogleModelArmorTemplateTemplateMetadataBlock>? TemplateMetadata
    {
        get => GetProperty<List<GoogleModelArmorTemplateTemplateMetadataBlock>>("template_metadata");
        set => this.WithProperty("template_metadata", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleModelArmorTemplateTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleModelArmorTemplateTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Create time stamp
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// Identifier. name of resource
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

    /// <summary>
    /// Update time stamp
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
