using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for entities in .
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxEntityTypeEntitiesBlock
{
    /// <summary>
    /// A collection of value synonyms. For example, if the entity type is vegetable, and value is scallions, a synonym could be green onions.
    /// For KIND_LIST entity types: This collection must contain exactly one synonym equal to value.
    /// </summary>
    [TerraformPropertyName("synonyms")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? Synonyms { get; set; }

    /// <summary>
    /// The primary value associated with this entity entry. For example, if the entity type is vegetable, the value could be scallions.
    /// For KIND_MAP entity types: A canonical value to be used in place of synonyms.
    /// For KIND_LIST entity types: A string that can contain references to other entity types (with or without aliases).
    /// </summary>
    [TerraformPropertyName("value")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Value { get; set; }

}

/// <summary>
/// Block type for excluded_phrases in .
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxEntityTypeExcludedPhrasesBlock
{
    /// <summary>
    /// The word or phrase to be excluded.
    /// </summary>
    [TerraformPropertyName("value")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Value { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleDialogflowCxEntityTypeTimeoutsBlock
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
/// Manages a google_dialogflow_cx_entity_type resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleDialogflowCxEntityType : TerraformResource
{
    public GoogleDialogflowCxEntityType(string name) : base("google_dialogflow_cx_entity_type", name)
    {
    }

    /// <summary>
    /// Represents kinds of entities.
    /// * AUTO_EXPANSION_MODE_UNSPECIFIED: Auto expansion disabled for the entity.
    /// * AUTO_EXPANSION_MODE_DEFAULT: Allows an agent to recognize values that have not been explicitly listed in the entity. Possible values: [&amp;quot;AUTO_EXPANSION_MODE_DEFAULT&amp;quot;, &amp;quot;AUTO_EXPANSION_MODE_UNSPECIFIED&amp;quot;]
    /// </summary>
    [TerraformPropertyName("auto_expansion_mode")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? AutoExpansionMode { get; set; }

    /// <summary>
    /// The human-readable name of the entity type, unique within the agent.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformPropertyName("display_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> DisplayName { get; set; }

    /// <summary>
    /// Enables fuzzy entity extraction during classification.
    /// </summary>
    [TerraformPropertyName("enable_fuzzy_extraction")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? EnableFuzzyExtraction { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// Indicates whether the entity type can be automatically expanded.
    /// * KIND_MAP: Map entity types allow mapping of a group of synonyms to a canonical value.
    /// * KIND_LIST: List entity types contain a set of entries that do not map to canonical values. However, list entity types can contain references to other entity types (with or without aliases).
    /// * KIND_REGEXP: Regexp entity types allow to specify regular expressions in entries values. Possible values: [&amp;quot;KIND_MAP&amp;quot;, &amp;quot;KIND_LIST&amp;quot;, &amp;quot;KIND_REGEXP&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Kind is required")]
    [TerraformPropertyName("kind")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Kind { get; set; }

    /// <summary>
    /// The language of the following fields in entityType:
    /// EntityType.entities.value
    /// EntityType.entities.synonyms
    /// EntityType.excluded_phrases.value
    /// If not specified, the agent&#39;s default language is used. Many languages are supported. Note: languages must be enabled in the agent before they can be used.
    /// </summary>
    [TerraformPropertyName("language_code")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? LanguageCode { get; set; }

    /// <summary>
    /// The agent to create a entity type for.
    /// Format: projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agents/&amp;lt;Agent ID&amp;gt;.
    /// </summary>
    [TerraformPropertyName("parent")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Parent { get; set; }

    /// <summary>
    /// Indicates whether parameters of the entity type should be redacted in log. If redaction is enabled, page parameters and intent parameters referring to the entity type will be replaced by parameter name when logging.
    /// </summary>
    [TerraformPropertyName("redact")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? Redact { get; set; }

    /// <summary>
    /// Block for entities.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Entities is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Entities block(s) required")]
    [TerraformPropertyName("entities")]
    public TerraformList<TerraformBlock<GoogleDialogflowCxEntityTypeEntitiesBlock>>? Entities { get; set; }

    /// <summary>
    /// Block for excluded_phrases.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("excluded_phrases")]
    public TerraformList<TerraformBlock<GoogleDialogflowCxEntityTypeExcludedPhrasesBlock>>? ExcludedPhrases { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleDialogflowCxEntityTypeTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The unique identifier of the entity type.
    /// Format: projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agents/&amp;lt;Agent ID&amp;gt;/entityTypes/&amp;lt;Entity Type ID&amp;gt;.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Name => new TerraformReference(this, "name");

}
