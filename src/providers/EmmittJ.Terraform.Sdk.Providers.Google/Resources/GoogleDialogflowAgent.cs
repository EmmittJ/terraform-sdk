using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleDialogflowAgentTimeoutsBlock
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
/// Manages a google_dialogflow_agent resource.
/// </summary>
public class GoogleDialogflowAgent : TerraformResource
{
    public GoogleDialogflowAgent(string name) : base("google_dialogflow_agent", name)
    {
    }

    /// <summary>
    /// API version displayed in Dialogflow console. If not specified, V2 API is assumed. Clients are free to query
    /// different service endpoints for different API versions. However, bots connectors and webhook calls will follow
    /// the specified API version.
    /// * API_VERSION_V1: Legacy V1 API.
    /// * API_VERSION_V2: V2 API.
    /// * API_VERSION_V2_BETA_1: V2beta1 API. Possible values: [&amp;quot;API_VERSION_V1&amp;quot;, &amp;quot;API_VERSION_V2&amp;quot;, &amp;quot;API_VERSION_V2_BETA_1&amp;quot;]
    /// </summary>
    [TerraformPropertyName("api_version")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> ApiVersion { get; set; } = default!;

    /// <summary>
    /// The URI of the agent&#39;s avatar, which are used throughout the Dialogflow console. When an image URL is entered
    /// into this field, the Dialogflow will save the image in the backend. The address of the backend image returned
    /// from the API will be shown in the [avatarUriBackend] field.
    /// </summary>
    [TerraformPropertyName("avatar_uri")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? AvatarUri { get; set; }

    /// <summary>
    /// To filter out false positive results and still get variety in matched natural language inputs for your agent,
    /// you can tune the machine learning classification threshold. If the returned score value is less than the threshold
    /// value, then a fallback intent will be triggered or, if there are no fallback intents defined, no intent will be
    /// triggered. The score values range from 0.0 (completely uncertain) to 1.0 (completely certain). If set to 0.0, the
    /// default of 0.3 is used.
    /// </summary>
    [TerraformPropertyName("classification_threshold")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? ClassificationThreshold { get; set; }

    /// <summary>
    /// The default language of the agent as a language tag. [See Language Support](https://cloud.google.com/dialogflow/docs/reference/language)
    /// for a list of the currently supported language codes. This field cannot be updated after creation.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DefaultLanguageCode is required")]
    [TerraformPropertyName("default_language_code")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> DefaultLanguageCode { get; set; }

    /// <summary>
    /// The description of this agent. The maximum length is 500 characters. If exceeded, the request is rejected.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The name of this agent.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformPropertyName("display_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> DisplayName { get; set; }

    /// <summary>
    /// Determines whether this agent should log conversation queries.
    /// </summary>
    [TerraformPropertyName("enable_logging")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? EnableLogging { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// Determines how intents are detected from user queries.
    /// * MATCH_MODE_HYBRID: Best for agents with a small number of examples in intents and/or wide use of templates
    /// syntax and composite entities.
    /// * MATCH_MODE_ML_ONLY: Can be used for agents with a large number of examples in intents, especially the ones
    /// using @sys.any or very large developer entities. Possible values: [&amp;quot;MATCH_MODE_HYBRID&amp;quot;, &amp;quot;MATCH_MODE_ML_ONLY&amp;quot;]
    /// </summary>
    [TerraformPropertyName("match_mode")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> MatchMode { get; set; } = default!;

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Project { get; set; } = default!;

    /// <summary>
    /// The list of all languages supported by this agent (except for the defaultLanguageCode).
    /// </summary>
    [TerraformPropertyName("supported_language_codes")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? SupportedLanguageCodes { get; set; }

    /// <summary>
    /// The agent tier. If not specified, TIER_STANDARD is assumed.
    /// * TIER_STANDARD: Standard tier.
    /// * TIER_ENTERPRISE: Enterprise tier (Essentials).
    /// * TIER_ENTERPRISE_PLUS: Enterprise tier (Plus).
    /// NOTE: Due to consistency issues, the provider will not read this field from the API. Drift is possible between
    /// the Terraform state and Dialogflow if the agent tier is changed outside of Terraform. Possible values: [&amp;quot;TIER_STANDARD&amp;quot;, &amp;quot;TIER_ENTERPRISE&amp;quot;, &amp;quot;TIER_ENTERPRISE_PLUS&amp;quot;]
    /// </summary>
    [TerraformPropertyName("tier")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Tier { get; set; }

    /// <summary>
    /// The time zone of this agent from the [time zone database](https://www.iana.org/time-zones), e.g., America/New_York,
    /// Europe/Paris.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TimeZone is required")]
    [TerraformPropertyName("time_zone")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> TimeZone { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleDialogflowAgentTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The URI of the agent&#39;s avatar as returned from the API. Output only. To provide an image URL for the agent avatar,
    /// the [avatarUri] field can be used.
    /// </summary>
    [TerraformPropertyName("avatar_uri_backend")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> AvatarUriBackend => new TerraformReference(this, "avatar_uri_backend");

}
