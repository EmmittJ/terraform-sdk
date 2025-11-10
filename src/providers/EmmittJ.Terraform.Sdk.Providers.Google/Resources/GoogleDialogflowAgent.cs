using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleDialogflowAgentTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a google_dialogflow_agent resource.
/// </summary>
public class GoogleDialogflowAgent : TerraformResource
{
    public GoogleDialogflowAgent(string name) : base("google_dialogflow_agent", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("avatar_uri_backend");
        SetOutput("api_version");
        SetOutput("avatar_uri");
        SetOutput("classification_threshold");
        SetOutput("default_language_code");
        SetOutput("description");
        SetOutput("display_name");
        SetOutput("enable_logging");
        SetOutput("id");
        SetOutput("match_mode");
        SetOutput("project");
        SetOutput("supported_language_codes");
        SetOutput("tier");
        SetOutput("time_zone");
    }

    /// <summary>
    /// API version displayed in Dialogflow console. If not specified, V2 API is assumed. Clients are free to query
    /// different service endpoints for different API versions. However, bots connectors and webhook calls will follow
    /// the specified API version.
    /// * API_VERSION_V1: Legacy V1 API.
    /// * API_VERSION_V2: V2 API.
    /// * API_VERSION_V2_BETA_1: V2beta1 API. Possible values: [&amp;quot;API_VERSION_V1&amp;quot;, &amp;quot;API_VERSION_V2&amp;quot;, &amp;quot;API_VERSION_V2_BETA_1&amp;quot;]
    /// </summary>
    public TerraformProperty<string> ApiVersion
    {
        get => GetRequiredOutput<TerraformProperty<string>>("api_version");
        set => SetProperty("api_version", value);
    }

    /// <summary>
    /// The URI of the agent&#39;s avatar, which are used throughout the Dialogflow console. When an image URL is entered
    /// into this field, the Dialogflow will save the image in the backend. The address of the backend image returned
    /// from the API will be shown in the [avatarUriBackend] field.
    /// </summary>
    public TerraformProperty<string> AvatarUri
    {
        get => GetRequiredOutput<TerraformProperty<string>>("avatar_uri");
        set => SetProperty("avatar_uri", value);
    }

    /// <summary>
    /// To filter out false positive results and still get variety in matched natural language inputs for your agent,
    /// you can tune the machine learning classification threshold. If the returned score value is less than the threshold
    /// value, then a fallback intent will be triggered or, if there are no fallback intents defined, no intent will be
    /// triggered. The score values range from 0.0 (completely uncertain) to 1.0 (completely certain). If set to 0.0, the
    /// default of 0.3 is used.
    /// </summary>
    public TerraformProperty<double> ClassificationThreshold
    {
        get => GetRequiredOutput<TerraformProperty<double>>("classification_threshold");
        set => SetProperty("classification_threshold", value);
    }

    /// <summary>
    /// The default language of the agent as a language tag. [See Language Support](https://cloud.google.com/dialogflow/docs/reference/language)
    /// for a list of the currently supported language codes. This field cannot be updated after creation.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DefaultLanguageCode is required")]
    public required TerraformProperty<string> DefaultLanguageCode
    {
        get => GetRequiredOutput<TerraformProperty<string>>("default_language_code");
        set => SetProperty("default_language_code", value);
    }

    /// <summary>
    /// The description of this agent. The maximum length is 500 characters. If exceeded, the request is rejected.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// The name of this agent.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformProperty<string> DisplayName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("display_name");
        set => SetProperty("display_name", value);
    }

    /// <summary>
    /// Determines whether this agent should log conversation queries.
    /// </summary>
    public TerraformProperty<bool> EnableLogging
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("enable_logging");
        set => SetProperty("enable_logging", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// Determines how intents are detected from user queries.
    /// * MATCH_MODE_HYBRID: Best for agents with a small number of examples in intents and/or wide use of templates
    /// syntax and composite entities.
    /// * MATCH_MODE_ML_ONLY: Can be used for agents with a large number of examples in intents, especially the ones
    /// using @sys.any or very large developer entities. Possible values: [&amp;quot;MATCH_MODE_HYBRID&amp;quot;, &amp;quot;MATCH_MODE_ML_ONLY&amp;quot;]
    /// </summary>
    public TerraformProperty<string> MatchMode
    {
        get => GetRequiredOutput<TerraformProperty<string>>("match_mode");
        set => SetProperty("match_mode", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
    }

    /// <summary>
    /// The list of all languages supported by this agent (except for the defaultLanguageCode).
    /// </summary>
    public List<TerraformProperty<string>> SupportedLanguageCodes
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("supported_language_codes");
        set => SetProperty("supported_language_codes", value);
    }

    /// <summary>
    /// The agent tier. If not specified, TIER_STANDARD is assumed.
    /// * TIER_STANDARD: Standard tier.
    /// * TIER_ENTERPRISE: Enterprise tier (Essentials).
    /// * TIER_ENTERPRISE_PLUS: Enterprise tier (Plus).
    /// NOTE: Due to consistency issues, the provider will not read this field from the API. Drift is possible between
    /// the Terraform state and Dialogflow if the agent tier is changed outside of Terraform. Possible values: [&amp;quot;TIER_STANDARD&amp;quot;, &amp;quot;TIER_ENTERPRISE&amp;quot;, &amp;quot;TIER_ENTERPRISE_PLUS&amp;quot;]
    /// </summary>
    public TerraformProperty<string> Tier
    {
        get => GetRequiredOutput<TerraformProperty<string>>("tier");
        set => SetProperty("tier", value);
    }

    /// <summary>
    /// The time zone of this agent from the [time zone database](https://www.iana.org/time-zones), e.g., America/New_York,
    /// Europe/Paris.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TimeZone is required")]
    public required TerraformProperty<string> TimeZone
    {
        get => GetRequiredOutput<TerraformProperty<string>>("time_zone");
        set => SetProperty("time_zone", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleDialogflowAgentTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The URI of the agent&#39;s avatar as returned from the API. Output only. To provide an image URL for the agent avatar,
    /// the [avatarUri] field can be used.
    /// </summary>
    public TerraformExpression AvatarUriBackend => this["avatar_uri_backend"];

}
