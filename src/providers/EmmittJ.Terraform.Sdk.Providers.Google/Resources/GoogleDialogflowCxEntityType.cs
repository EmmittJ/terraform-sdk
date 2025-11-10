using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for entities in .
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxEntityTypeEntitiesBlock : TerraformBlock
{
    /// <summary>
    /// A collection of value synonyms. For example, if the entity type is vegetable, and value is scallions, a synonym could be green onions.
    /// For KIND_LIST entity types: This collection must contain exactly one synonym equal to value.
    /// </summary>
    public List<TerraformProperty<string>>? Synonyms
    {
        set => SetProperty("synonyms", value);
    }

    /// <summary>
    /// The primary value associated with this entity entry. For example, if the entity type is vegetable, the value could be scallions.
    /// For KIND_MAP entity types: A canonical value to be used in place of synonyms.
    /// For KIND_LIST entity types: A string that can contain references to other entity types (with or without aliases).
    /// </summary>
    public TerraformProperty<string>? Value
    {
        set => SetProperty("value", value);
    }

}

/// <summary>
/// Block type for excluded_phrases in .
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxEntityTypeExcludedPhrasesBlock : TerraformBlock
{
    /// <summary>
    /// The word or phrase to be excluded.
    /// </summary>
    public TerraformProperty<string>? Value
    {
        set => SetProperty("value", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleDialogflowCxEntityTypeTimeoutsBlock : TerraformBlock
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
/// Manages a google_dialogflow_cx_entity_type resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleDialogflowCxEntityType : TerraformResource
{
    public GoogleDialogflowCxEntityType(string name) : base("google_dialogflow_cx_entity_type", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("name");
        SetOutput("auto_expansion_mode");
        SetOutput("display_name");
        SetOutput("enable_fuzzy_extraction");
        SetOutput("id");
        SetOutput("kind");
        SetOutput("language_code");
        SetOutput("parent");
        SetOutput("redact");
    }

    /// <summary>
    /// Represents kinds of entities.
    /// * AUTO_EXPANSION_MODE_UNSPECIFIED: Auto expansion disabled for the entity.
    /// * AUTO_EXPANSION_MODE_DEFAULT: Allows an agent to recognize values that have not been explicitly listed in the entity. Possible values: [&amp;quot;AUTO_EXPANSION_MODE_DEFAULT&amp;quot;, &amp;quot;AUTO_EXPANSION_MODE_UNSPECIFIED&amp;quot;]
    /// </summary>
    public TerraformProperty<string> AutoExpansionMode
    {
        get => GetRequiredOutput<TerraformProperty<string>>("auto_expansion_mode");
        set => SetProperty("auto_expansion_mode", value);
    }

    /// <summary>
    /// The human-readable name of the entity type, unique within the agent.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformProperty<string> DisplayName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("display_name");
        set => SetProperty("display_name", value);
    }

    /// <summary>
    /// Enables fuzzy entity extraction during classification.
    /// </summary>
    public TerraformProperty<bool> EnableFuzzyExtraction
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("enable_fuzzy_extraction");
        set => SetProperty("enable_fuzzy_extraction", value);
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
    /// Indicates whether the entity type can be automatically expanded.
    /// * KIND_MAP: Map entity types allow mapping of a group of synonyms to a canonical value.
    /// * KIND_LIST: List entity types contain a set of entries that do not map to canonical values. However, list entity types can contain references to other entity types (with or without aliases).
    /// * KIND_REGEXP: Regexp entity types allow to specify regular expressions in entries values. Possible values: [&amp;quot;KIND_MAP&amp;quot;, &amp;quot;KIND_LIST&amp;quot;, &amp;quot;KIND_REGEXP&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Kind is required")]
    public required TerraformProperty<string> Kind
    {
        get => GetRequiredOutput<TerraformProperty<string>>("kind");
        set => SetProperty("kind", value);
    }

    /// <summary>
    /// The language of the following fields in entityType:
    /// EntityType.entities.value
    /// EntityType.entities.synonyms
    /// EntityType.excluded_phrases.value
    /// If not specified, the agent&#39;s default language is used. Many languages are supported. Note: languages must be enabled in the agent before they can be used.
    /// </summary>
    public TerraformProperty<string> LanguageCode
    {
        get => GetRequiredOutput<TerraformProperty<string>>("language_code");
        set => SetProperty("language_code", value);
    }

    /// <summary>
    /// The agent to create a entity type for.
    /// Format: projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agents/&amp;lt;Agent ID&amp;gt;.
    /// </summary>
    public TerraformProperty<string> Parent
    {
        get => GetRequiredOutput<TerraformProperty<string>>("parent");
        set => SetProperty("parent", value);
    }

    /// <summary>
    /// Indicates whether parameters of the entity type should be redacted in log. If redaction is enabled, page parameters and intent parameters referring to the entity type will be replaced by parameter name when logging.
    /// </summary>
    public TerraformProperty<bool> Redact
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("redact");
        set => SetProperty("redact", value);
    }

    /// <summary>
    /// Block for entities.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Entities is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Entities block(s) required")]
    public List<GoogleDialogflowCxEntityTypeEntitiesBlock>? Entities
    {
        set => SetProperty("entities", value);
    }

    /// <summary>
    /// Block for excluded_phrases.
    /// Nesting mode: list
    /// </summary>
    public List<GoogleDialogflowCxEntityTypeExcludedPhrasesBlock>? ExcludedPhrases
    {
        set => SetProperty("excluded_phrases", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleDialogflowCxEntityTypeTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The unique identifier of the entity type.
    /// Format: projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agents/&amp;lt;Agent ID&amp;gt;/entityTypes/&amp;lt;Entity Type ID&amp;gt;.
    /// </summary>
    public TerraformExpression Name => this["name"];

}
