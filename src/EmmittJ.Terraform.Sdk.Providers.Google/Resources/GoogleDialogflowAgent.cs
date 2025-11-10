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
        this.DeclareOutput("avatar_uri_backend");
    }

    /// <summary>
    /// API version displayed in Dialogflow console. If not specified, V2 API is assumed. Clients are free to query
    /// different service endpoints for different API versions. However, bots connectors and webhook calls will follow
    /// the specified API version.
    /// * API_VERSION_V1: Legacy V1 API.
    /// * API_VERSION_V2: V2 API.
    /// * API_VERSION_V2_BETA_1: V2beta1 API. Possible values: [&amp;quot;API_VERSION_V1&amp;quot;, &amp;quot;API_VERSION_V2&amp;quot;, &amp;quot;API_VERSION_V2_BETA_1&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? ApiVersion
    {
        get => GetProperty<TerraformProperty<string>>("api_version");
        set => this.WithProperty("api_version", value);
    }

    /// <summary>
    /// The URI of the agent&#39;s avatar, which are used throughout the Dialogflow console. When an image URL is entered
    /// into this field, the Dialogflow will save the image in the backend. The address of the backend image returned
    /// from the API will be shown in the [avatarUriBackend] field.
    /// </summary>
    public TerraformProperty<string>? AvatarUri
    {
        get => GetProperty<TerraformProperty<string>>("avatar_uri");
        set => this.WithProperty("avatar_uri", value);
    }

    /// <summary>
    /// To filter out false positive results and still get variety in matched natural language inputs for your agent,
    /// you can tune the machine learning classification threshold. If the returned score value is less than the threshold
    /// value, then a fallback intent will be triggered or, if there are no fallback intents defined, no intent will be
    /// triggered. The score values range from 0.0 (completely uncertain) to 1.0 (completely certain). If set to 0.0, the
    /// default of 0.3 is used.
    /// </summary>
    public TerraformProperty<double>? ClassificationThreshold
    {
        get => GetProperty<TerraformProperty<double>>("classification_threshold");
        set => this.WithProperty("classification_threshold", value);
    }

    /// <summary>
    /// The default language of the agent as a language tag. [See Language Support](https://cloud.google.com/dialogflow/docs/reference/language)
    /// for a list of the currently supported language codes. This field cannot be updated after creation.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DefaultLanguageCode is required")]
    public required TerraformProperty<string> DefaultLanguageCode
    {
        get => GetRequiredProperty<TerraformProperty<string>>("default_language_code");
        set => this.WithProperty("default_language_code", value);
    }

    /// <summary>
    /// The description of this agent. The maximum length is 500 characters. If exceeded, the request is rejected.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The name of this agent.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformProperty<string> DisplayName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
    }

    /// <summary>
    /// Determines whether this agent should log conversation queries.
    /// </summary>
    public TerraformProperty<bool>? EnableLogging
    {
        get => GetProperty<TerraformProperty<bool>>("enable_logging");
        set => this.WithProperty("enable_logging", value);
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
    /// Determines how intents are detected from user queries.
    /// * MATCH_MODE_HYBRID: Best for agents with a small number of examples in intents and/or wide use of templates
    /// syntax and composite entities.
    /// * MATCH_MODE_ML_ONLY: Can be used for agents with a large number of examples in intents, especially the ones
    /// using @sys.any or very large developer entities. Possible values: [&amp;quot;MATCH_MODE_HYBRID&amp;quot;, &amp;quot;MATCH_MODE_ML_ONLY&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? MatchMode
    {
        get => GetProperty<TerraformProperty<string>>("match_mode");
        set => this.WithProperty("match_mode", value);
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
    /// The list of all languages supported by this agent (except for the defaultLanguageCode).
    /// </summary>
    public List<TerraformProperty<string>>? SupportedLanguageCodes
    {
        get => GetProperty<List<TerraformProperty<string>>>("supported_language_codes");
        set => this.WithProperty("supported_language_codes", value);
    }

    /// <summary>
    /// The agent tier. If not specified, TIER_STANDARD is assumed.
    /// * TIER_STANDARD: Standard tier.
    /// * TIER_ENTERPRISE: Enterprise tier (Essentials).
    /// * TIER_ENTERPRISE_PLUS: Enterprise tier (Plus).
    /// NOTE: Due to consistency issues, the provider will not read this field from the API. Drift is possible between
    /// the Terraform state and Dialogflow if the agent tier is changed outside of Terraform. Possible values: [&amp;quot;TIER_STANDARD&amp;quot;, &amp;quot;TIER_ENTERPRISE&amp;quot;, &amp;quot;TIER_ENTERPRISE_PLUS&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? Tier
    {
        get => GetProperty<TerraformProperty<string>>("tier");
        set => this.WithProperty("tier", value);
    }

    /// <summary>
    /// The time zone of this agent from the [time zone database](https://www.iana.org/time-zones), e.g., America/New_York,
    /// Europe/Paris.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TimeZone is required")]
    public required TerraformProperty<string> TimeZone
    {
        get => GetRequiredProperty<TerraformProperty<string>>("time_zone");
        set => this.WithProperty("time_zone", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleDialogflowAgentTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleDialogflowAgentTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The URI of the agent&#39;s avatar as returned from the API. Output only. To provide an image URL for the agent avatar,
    /// the [avatarUri] field can be used.
    /// </summary>
    public TerraformExpression AvatarUriBackend => this["avatar_uri_backend"];

}
