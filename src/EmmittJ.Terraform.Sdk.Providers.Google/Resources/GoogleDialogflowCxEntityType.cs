using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_dialogflow_cx_entity_type resource.
/// </summary>
public class GoogleDialogflowCxEntityType : TerraformResource
{
    public GoogleDialogflowCxEntityType(string name) : base("google_dialogflow_cx_entity_type", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("name");
    }

    /// <summary>
    /// Represents kinds of entities.
    /// * AUTO_EXPANSION_MODE_UNSPECIFIED: Auto expansion disabled for the entity.
    /// * AUTO_EXPANSION_MODE_DEFAULT: Allows an agent to recognize values that have not been explicitly listed in the entity. Possible values: [&amp;quot;AUTO_EXPANSION_MODE_DEFAULT&amp;quot;, &amp;quot;AUTO_EXPANSION_MODE_UNSPECIFIED&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? AutoExpansionMode
    {
        get => GetProperty<TerraformProperty<string>>("auto_expansion_mode");
        set => this.WithProperty("auto_expansion_mode", value);
    }

    /// <summary>
    /// The human-readable name of the entity type, unique within the agent.
    /// </summary>
    public TerraformProperty<string>? DisplayName
    {
        get => GetProperty<TerraformProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
    }

    /// <summary>
    /// Enables fuzzy entity extraction during classification.
    /// </summary>
    public TerraformProperty<bool>? EnableFuzzyExtraction
    {
        get => GetProperty<TerraformProperty<bool>>("enable_fuzzy_extraction");
        set => this.WithProperty("enable_fuzzy_extraction", value);
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
    /// Indicates whether the entity type can be automatically expanded.
    /// * KIND_MAP: Map entity types allow mapping of a group of synonyms to a canonical value.
    /// * KIND_LIST: List entity types contain a set of entries that do not map to canonical values. However, list entity types can contain references to other entity types (with or without aliases).
    /// * KIND_REGEXP: Regexp entity types allow to specify regular expressions in entries values. Possible values: [&amp;quot;KIND_MAP&amp;quot;, &amp;quot;KIND_LIST&amp;quot;, &amp;quot;KIND_REGEXP&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? Kind
    {
        get => GetProperty<TerraformProperty<string>>("kind");
        set => this.WithProperty("kind", value);
    }

    /// <summary>
    /// The language of the following fields in entityType:
    /// EntityType.entities.value
    /// EntityType.entities.synonyms
    /// EntityType.excluded_phrases.value
    /// If not specified, the agent&#39;s default language is used. Many languages are supported. Note: languages must be enabled in the agent before they can be used.
    /// </summary>
    public TerraformProperty<string>? LanguageCode
    {
        get => GetProperty<TerraformProperty<string>>("language_code");
        set => this.WithProperty("language_code", value);
    }

    /// <summary>
    /// The agent to create a entity type for.
    /// Format: projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agents/&amp;lt;Agent ID&amp;gt;.
    /// </summary>
    public TerraformProperty<string>? Parent
    {
        get => GetProperty<TerraformProperty<string>>("parent");
        set => this.WithProperty("parent", value);
    }

    /// <summary>
    /// Indicates whether parameters of the entity type should be redacted in log. If redaction is enabled, page parameters and intent parameters referring to the entity type will be replaced by parameter name when logging.
    /// </summary>
    public TerraformProperty<bool>? Redact
    {
        get => GetProperty<TerraformProperty<bool>>("redact");
        set => this.WithProperty("redact", value);
    }

    /// <summary>
    /// The unique identifier of the entity type.
    /// Format: projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agents/&amp;lt;Agent ID&amp;gt;/entityTypes/&amp;lt;Entity Type ID&amp;gt;.
    /// </summary>
    public TerraformExpression Name => this["name"];

}
