using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for entities in .
/// Nesting mode: list
/// </summary>
public partial class GoogleDialogflowEntityTypeEntitiesBlock : TerraformBlockBase
{
    /// <summary>
    /// A collection of value synonyms. For example, if the entity type is vegetable, and value is scallions, a synonym
    /// could be green onions.
    /// For KIND_LIST entity types:
    /// * This collection must contain exactly one synonym equal to value.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Synonyms is required")]
    [TerraformProperty("synonyms")]
    // Required argument - source generator will implement get/set
    public TerraformList<string>? Synonyms { get; set; }

    /// <summary>
    /// The primary value associated with this entity entry. For example, if the entity type is vegetable, the value
    /// could be scallions.
    /// For KIND_MAP entity types:
    /// * A reference value to be used in place of synonyms.
    /// For KIND_LIST entity types:
    /// * A string that can contain references to other entity types (with or without aliases).
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    [TerraformProperty("value")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Value { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleDialogflowEntityTypeTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_dialogflow_entity_type resource.
/// </summary>
public partial class GoogleDialogflowEntityType : TerraformResource
{
    public GoogleDialogflowEntityType(string name) : base("google_dialogflow_entity_type", name)
    {
    }

    /// <summary>
    /// The name of this entity type to be displayed on the console.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformProperty("display_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> DisplayName { get; set; }

    /// <summary>
    /// Enables fuzzy entity extraction during classification.
    /// </summary>
    [TerraformProperty("enable_fuzzy_extraction")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? EnableFuzzyExtraction { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Indicates the kind of entity type.
    /// * KIND_MAP: Map entity types allow mapping of a group of synonyms to a reference value.
    /// * KIND_LIST: List entity types contain a set of entries that do not map to reference values. However, list entity
    /// types can contain references to other entity types (with or without aliases).
    /// * KIND_REGEXP: Regexp entity types allow to specify regular expressions in entries values. Possible values: [&amp;quot;KIND_MAP&amp;quot;, &amp;quot;KIND_LIST&amp;quot;, &amp;quot;KIND_REGEXP&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Kind is required")]
    [TerraformProperty("kind")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Kind { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Project { get; set; }

    /// <summary>
    /// Block for entities.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("entities")]
    public TerraformList<TerraformBlock<GoogleDialogflowEntityTypeEntitiesBlock>>? Entities { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<GoogleDialogflowEntityTypeTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The unique identifier of the entity type.
    /// Format: projects/&amp;lt;Project ID&amp;gt;/agent/entityTypes/&amp;lt;Entity type ID&amp;gt;.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Name { get; }

}
