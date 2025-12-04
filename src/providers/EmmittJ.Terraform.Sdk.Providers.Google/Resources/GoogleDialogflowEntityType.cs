using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for entities in GoogleDialogflowEntityType.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowEntityTypeEntitiesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "entities";

    /// <summary>
    /// A collection of value synonyms. For example, if the entity type is vegetable, and value is scallions, a synonym
    /// could be green onions.
    /// For KIND_LIST entity types:
    /// * This collection must contain exactly one synonym equal to value.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Synonyms is required")]
    public TerraformList<string>? Synonyms
    {
        get => GetArgument<TerraformList<string>>("synonyms");
        set => SetArgument("synonyms", value);
    }

    /// <summary>
    /// The primary value associated with this entity entry. For example, if the entity type is vegetable, the value
    /// could be scallions.
    /// For KIND_MAP entity types:
    /// * A reference value to be used in place of synonyms.
    /// For KIND_LIST entity types:
    /// * A string that can contain references to other entity types (with or without aliases).
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleDialogflowEntityType.
/// Nesting mode: single
/// </summary>
public class GoogleDialogflowEntityTypeTimeoutsBlock : TerraformBlock
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
/// Represents a google_dialogflow_entity_type Terraform resource.
/// Manages a google_dialogflow_entity_type resource.
/// </summary>
public partial class GoogleDialogflowEntityType(string name) : TerraformResource("google_dialogflow_entity_type", name)
{
    /// <summary>
    /// The name of this entity type to be displayed on the console.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformValue<string> DisplayName
    {
        get => GetRequiredArgument<TerraformValue<string>>("display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// Enables fuzzy entity extraction during classification.
    /// </summary>
    public TerraformValue<bool>? EnableFuzzyExtraction
    {
        get => GetArgument<TerraformValue<bool>>("enable_fuzzy_extraction");
        set => SetArgument("enable_fuzzy_extraction", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Indicates the kind of entity type.
    /// * KIND_MAP: Map entity types allow mapping of a group of synonyms to a reference value.
    /// * KIND_LIST: List entity types contain a set of entries that do not map to reference values. However, list entity
    /// types can contain references to other entity types (with or without aliases).
    /// * KIND_REGEXP: Regexp entity types allow to specify regular expressions in entries values. Possible values: [&amp;quot;KIND_MAP&amp;quot;, &amp;quot;KIND_LIST&amp;quot;, &amp;quot;KIND_REGEXP&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Kind is required")]
    public required TerraformValue<string> Kind
    {
        get => GetRequiredArgument<TerraformValue<string>>("kind");
        set => SetArgument("kind", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => GetArgument<TerraformValue<string>>("project") ?? AsReference("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The unique identifier of the entity type.
    /// Format: projects/&amp;lt;Project ID&amp;gt;/agent/entityTypes/&amp;lt;Entity type ID&amp;gt;.
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

    /// <summary>
    /// Entities block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleDialogflowEntityTypeEntitiesBlock>? Entities
    {
        get => GetArgument<TerraformList<GoogleDialogflowEntityTypeEntitiesBlock>>("entities");
        set => SetArgument("entities", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleDialogflowEntityTypeTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleDialogflowEntityTypeTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
