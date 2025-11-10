using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for entities in .
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowEntityTypeEntitiesBlock : TerraformBlock
{
    /// <summary>
    /// A collection of value synonyms. For example, if the entity type is vegetable, and value is scallions, a synonym
    /// could be green onions.
    /// For KIND_LIST entity types:
    /// * This collection must contain exactly one synonym equal to value.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Synonyms is required")]
    public List<TerraformProperty<string>>? Synonyms
    {
        get => GetProperty<List<TerraformProperty<string>>>("synonyms");
        set => WithProperty("synonyms", value);
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
    public required TerraformProperty<string> Value
    {
        get => GetRequiredProperty<TerraformProperty<string>>("value");
        set => WithProperty("value", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleDialogflowEntityTypeTimeoutsBlock : TerraformBlock
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
/// Manages a google_dialogflow_entity_type resource.
/// </summary>
public class GoogleDialogflowEntityType : TerraformResource
{
    public GoogleDialogflowEntityType(string name) : base("google_dialogflow_entity_type", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("name");
    }

    /// <summary>
    /// The name of this entity type to be displayed on the console.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformProperty<string> DisplayName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("display_name");
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
    /// Indicates the kind of entity type.
    /// * KIND_MAP: Map entity types allow mapping of a group of synonyms to a reference value.
    /// * KIND_LIST: List entity types contain a set of entries that do not map to reference values. However, list entity
    /// types can contain references to other entity types (with or without aliases).
    /// * KIND_REGEXP: Regexp entity types allow to specify regular expressions in entries values. Possible values: [&amp;quot;KIND_MAP&amp;quot;, &amp;quot;KIND_LIST&amp;quot;, &amp;quot;KIND_REGEXP&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Kind is required")]
    public required TerraformProperty<string> Kind
    {
        get => GetRequiredProperty<TerraformProperty<string>>("kind");
        set => this.WithProperty("kind", value);
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
    /// Block for entities.
    /// Nesting mode: list
    /// </summary>
    public List<GoogleDialogflowEntityTypeEntitiesBlock>? Entities
    {
        get => GetProperty<List<GoogleDialogflowEntityTypeEntitiesBlock>>("entities");
        set => this.WithProperty("entities", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleDialogflowEntityTypeTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleDialogflowEntityTypeTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The unique identifier of the entity type.
    /// Format: projects/&amp;lt;Project ID&amp;gt;/agent/entityTypes/&amp;lt;Entity type ID&amp;gt;.
    /// </summary>
    public TerraformExpression Name => this["name"];

}
