using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

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
    public string? ApiVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("api_version")?.Value;
        set => this.WithProperty("api_version", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The URI of the agent&#39;s avatar, which are used throughout the Dialogflow console. When an image URL is entered
    /// into this field, the Dialogflow will save the image in the backend. The address of the backend image returned
    /// from the API will be shown in the [avatarUriBackend] field.
    /// </summary>
    public string? AvatarUri
    {
        get => GetProperty<TerraformLiteralProperty<string>>("avatar_uri")?.Value;
        set => this.WithProperty("avatar_uri", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// To filter out false positive results and still get variety in matched natural language inputs for your agent,
    /// you can tune the machine learning classification threshold. If the returned score value is less than the threshold
    /// value, then a fallback intent will be triggered or, if there are no fallback intents defined, no intent will be
    /// triggered. The score values range from 0.0 (completely uncertain) to 1.0 (completely certain). If set to 0.0, the
    /// default of 0.3 is used.
    /// </summary>
    public double? ClassificationThreshold
    {
        get => GetProperty<TerraformLiteralProperty<double>>("classification_threshold")?.Value;
        set => this.WithProperty("classification_threshold", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The default language of the agent as a language tag. [See Language Support](https://cloud.google.com/dialogflow/docs/reference/language)
    /// for a list of the currently supported language codes. This field cannot be updated after creation.
    /// </summary>
    public string? DefaultLanguageCode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("default_language_code")?.Value;
        set => this.WithProperty("default_language_code", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The description of this agent. The maximum length is 500 characters. If exceeded, the request is rejected.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name of this agent.
    /// </summary>
    public string? DisplayName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("display_name")?.Value;
        set => this.WithProperty("display_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Determines whether this agent should log conversation queries.
    /// </summary>
    public bool? EnableLogging
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enable_logging")?.Value;
        set => this.WithProperty("enable_logging", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Determines how intents are detected from user queries.
    /// * MATCH_MODE_HYBRID: Best for agents with a small number of examples in intents and/or wide use of templates
    /// syntax and composite entities.
    /// * MATCH_MODE_ML_ONLY: Can be used for agents with a large number of examples in intents, especially the ones
    /// using @sys.any or very large developer entities. Possible values: [&amp;quot;MATCH_MODE_HYBRID&amp;quot;, &amp;quot;MATCH_MODE_ML_ONLY&amp;quot;]
    /// </summary>
    public string? MatchMode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("match_mode")?.Value;
        set => this.WithProperty("match_mode", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public string? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project")?.Value;
        set => this.WithProperty("project", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The list of all languages supported by this agent (except for the defaultLanguageCode).
    /// </summary>
    public List<string>? SupportedLanguageCodes
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("supported_language_codes")?.Value;
        set => this.WithProperty("supported_language_codes", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// The agent tier. If not specified, TIER_STANDARD is assumed.
    /// * TIER_STANDARD: Standard tier.
    /// * TIER_ENTERPRISE: Enterprise tier (Essentials).
    /// * TIER_ENTERPRISE_PLUS: Enterprise tier (Plus).
    /// NOTE: Due to consistency issues, the provider will not read this field from the API. Drift is possible between
    /// the Terraform state and Dialogflow if the agent tier is changed outside of Terraform. Possible values: [&amp;quot;TIER_STANDARD&amp;quot;, &amp;quot;TIER_ENTERPRISE&amp;quot;, &amp;quot;TIER_ENTERPRISE_PLUS&amp;quot;]
    /// </summary>
    public string? Tier
    {
        get => GetProperty<TerraformLiteralProperty<string>>("tier")?.Value;
        set => this.WithProperty("tier", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The time zone of this agent from the [time zone database](https://www.iana.org/time-zones), e.g., America/New_York,
    /// Europe/Paris.
    /// </summary>
    public string? TimeZone
    {
        get => GetProperty<TerraformLiteralProperty<string>>("time_zone")?.Value;
        set => this.WithProperty("time_zone", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The URI of the agent&#39;s avatar as returned from the API. Output only. To provide an image URL for the agent avatar,
    /// the [avatarUri] field can be used.
    /// </summary>
    public TerraformExpression AvatarUriBackend => this["avatar_uri_backend"];

}
