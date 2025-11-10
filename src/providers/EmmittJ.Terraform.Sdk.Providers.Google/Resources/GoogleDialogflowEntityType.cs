using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for entities in .
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowEntityTypeEntitiesBlock : ITerraformBlock
{
    /// <summary>
    /// A collection of value synonyms. For example, if the entity type is vegetable, and value is scallions, a synonym
    /// could be green onions.
    /// For KIND_LIST entity types:
    /// * This collection must contain exactly one synonym equal to value.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Synonyms is required")]
    [TerraformPropertyName("synonyms")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<List<TerraformProperty<string>>>? Synonyms { get; set; }

    /// <summary>
    /// The primary value associated with this entity entry. For example, if the entity type is vegetable, the value
    /// could be scallions.
    /// For KIND_MAP entity types:
    /// * A reference value to be used in place of synonyms.
    /// For KIND_LIST entity types:
    /// * A string that can contain references to other entity types (with or without aliases).
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    [TerraformPropertyName("value")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Value { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleDialogflowEntityTypeTimeoutsBlock : ITerraformBlock
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
/// Manages a google_dialogflow_entity_type resource.
/// </summary>
public class GoogleDialogflowEntityType : TerraformResource
{
    public GoogleDialogflowEntityType(string name) : base("google_dialogflow_entity_type", name)
    {
    }

    /// <summary>
    /// The name of this entity type to be displayed on the console.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformPropertyName("display_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DisplayName { get; set; }

    /// <summary>
    /// Enables fuzzy entity extraction during classification.
    /// </summary>
    [TerraformPropertyName("enable_fuzzy_extraction")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? EnableFuzzyExtraction { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Indicates the kind of entity type.
    /// * KIND_MAP: Map entity types allow mapping of a group of synonyms to a reference value.
    /// * KIND_LIST: List entity types contain a set of entries that do not map to reference values. However, list entity
    /// types can contain references to other entity types (with or without aliases).
    /// * KIND_REGEXP: Regexp entity types allow to specify regular expressions in entries values. Possible values: [&amp;quot;KIND_MAP&amp;quot;, &amp;quot;KIND_LIST&amp;quot;, &amp;quot;KIND_REGEXP&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Kind is required")]
    [TerraformPropertyName("kind")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Kind { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Project { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "project");

    /// <summary>
    /// Block for entities.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("entities")]
    public TerraformList<TerraformBlock<GoogleDialogflowEntityTypeEntitiesBlock>>? Entities { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleDialogflowEntityTypeTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The unique identifier of the entity type.
    /// Format: projects/&amp;lt;Project ID&amp;gt;/agent/entityTypes/&amp;lt;Entity type ID&amp;gt;.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Name => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

}
