using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleDialogflowAgent.
/// Nesting mode: single
/// </summary>
public class GoogleDialogflowAgentTimeoutsBlock : TerraformBlock
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
/// Represents a google_dialogflow_agent Terraform resource.
/// Manages a google_dialogflow_agent resource.
/// </summary>
public partial class GoogleDialogflowAgent(string name) : TerraformResource("google_dialogflow_agent", name)
{
    /// <summary>
    /// API version displayed in Dialogflow console. If not specified, V2 API is assumed. Clients are free to query
    /// different service endpoints for different API versions. However, bots connectors and webhook calls will follow
    /// the specified API version.
    /// * API_VERSION_V1: Legacy V1 API.
    /// * API_VERSION_V2: V2 API.
    /// * API_VERSION_V2_BETA_1: V2beta1 API. Possible values: [&amp;quot;API_VERSION_V1&amp;quot;, &amp;quot;API_VERSION_V2&amp;quot;, &amp;quot;API_VERSION_V2_BETA_1&amp;quot;]
    /// </summary>
    public TerraformValue<string> ApiVersion
    {
        get => GetArgument<TerraformValue<string>>("api_version") ?? CreateReference("api_version");
        set => SetArgument("api_version", value);
    }

    /// <summary>
    /// The URI of the agent&#39;s avatar, which are used throughout the Dialogflow console. When an image URL is entered
    /// into this field, the Dialogflow will save the image in the backend. The address of the backend image returned
    /// from the API will be shown in the [avatarUriBackend] field.
    /// </summary>
    public TerraformValue<string>? AvatarUri
    {
        get => GetArgument<TerraformValue<string>>("avatar_uri");
        set => SetArgument("avatar_uri", value);
    }

    /// <summary>
    /// To filter out false positive results and still get variety in matched natural language inputs for your agent,
    /// you can tune the machine learning classification threshold. If the returned score value is less than the threshold
    /// value, then a fallback intent will be triggered or, if there are no fallback intents defined, no intent will be
    /// triggered. The score values range from 0.0 (completely uncertain) to 1.0 (completely certain). If set to 0.0, the
    /// default of 0.3 is used.
    /// </summary>
    public TerraformValue<double>? ClassificationThreshold
    {
        get => GetArgument<TerraformValue<double>>("classification_threshold");
        set => SetArgument("classification_threshold", value);
    }

    /// <summary>
    /// The default language of the agent as a language tag. [See Language Support](https://cloud.google.com/dialogflow/docs/reference/language)
    /// for a list of the currently supported language codes. This field cannot be updated after creation.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DefaultLanguageCode is required")]
    public required TerraformValue<string> DefaultLanguageCode
    {
        get => GetRequiredArgument<TerraformValue<string>>("default_language_code");
        set => SetArgument("default_language_code", value);
    }

    /// <summary>
    /// The description of this agent. The maximum length is 500 characters. If exceeded, the request is rejected.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The name of this agent.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformValue<string> DisplayName
    {
        get => GetRequiredArgument<TerraformValue<string>>("display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// Determines whether this agent should log conversation queries.
    /// </summary>
    public TerraformValue<bool>? EnableLogging
    {
        get => GetArgument<TerraformValue<bool>>("enable_logging");
        set => SetArgument("enable_logging", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Determines how intents are detected from user queries.
    /// * MATCH_MODE_HYBRID: Best for agents with a small number of examples in intents and/or wide use of templates
    /// syntax and composite entities.
    /// * MATCH_MODE_ML_ONLY: Can be used for agents with a large number of examples in intents, especially the ones
    /// using @sys.any or very large developer entities. Possible values: [&amp;quot;MATCH_MODE_HYBRID&amp;quot;, &amp;quot;MATCH_MODE_ML_ONLY&amp;quot;]
    /// </summary>
    public TerraformValue<string> MatchMode
    {
        get => GetArgument<TerraformValue<string>>("match_mode") ?? CreateReference("match_mode");
        set => SetArgument("match_mode", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => GetArgument<TerraformValue<string>>("project") ?? CreateReference("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The list of all languages supported by this agent (except for the defaultLanguageCode).
    /// </summary>
    public TerraformList<string>? SupportedLanguageCodes
    {
        get => GetArgument<TerraformList<string>>("supported_language_codes");
        set => SetArgument("supported_language_codes", value);
    }

    /// <summary>
    /// The agent tier. If not specified, TIER_STANDARD is assumed.
    /// * TIER_STANDARD: Standard tier.
    /// * TIER_ENTERPRISE: Enterprise tier (Essentials).
    /// * TIER_ENTERPRISE_PLUS: Enterprise tier (Plus).
    /// NOTE: Due to consistency issues, the provider will not read this field from the API. Drift is possible between
    /// the Terraform state and Dialogflow if the agent tier is changed outside of Terraform. Possible values: [&amp;quot;TIER_STANDARD&amp;quot;, &amp;quot;TIER_ENTERPRISE&amp;quot;, &amp;quot;TIER_ENTERPRISE_PLUS&amp;quot;]
    /// </summary>
    public TerraformValue<string>? Tier
    {
        get => GetArgument<TerraformValue<string>>("tier");
        set => SetArgument("tier", value);
    }

    /// <summary>
    /// The time zone of this agent from the [time zone database](https://www.iana.org/time-zones), e.g., America/New_York,
    /// Europe/Paris.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TimeZone is required")]
    public required TerraformValue<string> TimeZone
    {
        get => GetRequiredArgument<TerraformValue<string>>("time_zone");
        set => SetArgument("time_zone", value);
    }

    /// <summary>
    /// The URI of the agent&#39;s avatar as returned from the API. Output only. To provide an image URL for the agent avatar,
    /// the [avatarUri] field can be used.
    /// </summary>
    public TerraformValue<string> AvatarUriBackend
        => CreateReference("avatar_uri_backend");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleDialogflowAgentTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleDialogflowAgentTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
