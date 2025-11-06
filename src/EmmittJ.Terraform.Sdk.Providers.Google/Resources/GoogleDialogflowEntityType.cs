using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

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
        this.DeclareOutput("name");
    }

    /// <summary>
    /// The name of this entity type to be displayed on the console.
    /// </summary>
    public string? DisplayName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("display_name")?.Value;
        set => this.WithProperty("display_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Enables fuzzy entity extraction during classification.
    /// </summary>
    public bool? EnableFuzzyExtraction
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enable_fuzzy_extraction")?.Value;
        set => this.WithProperty("enable_fuzzy_extraction", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    /// Indicates the kind of entity type.
    /// * KIND_MAP: Map entity types allow mapping of a group of synonyms to a reference value.
    /// * KIND_LIST: List entity types contain a set of entries that do not map to reference values. However, list entity
    /// types can contain references to other entity types (with or without aliases).
    /// * KIND_REGEXP: Regexp entity types allow to specify regular expressions in entries values. Possible values: [&amp;quot;KIND_MAP&amp;quot;, &amp;quot;KIND_LIST&amp;quot;, &amp;quot;KIND_REGEXP&amp;quot;]
    /// </summary>
    public string? Kind
    {
        get => GetProperty<TerraformLiteralProperty<string>>("kind")?.Value;
        set => this.WithProperty("kind", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The unique identifier of the entity type.
    /// Format: projects/&amp;lt;Project ID&amp;gt;/agent/entityTypes/&amp;lt;Entity type ID&amp;gt;.
    /// </summary>
    public TerraformExpression Name => this["name"];

}
