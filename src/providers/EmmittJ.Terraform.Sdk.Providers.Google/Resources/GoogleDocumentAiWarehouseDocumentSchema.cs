using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for property_definitions in .
/// Nesting mode: list
/// </summary>
public class GoogleDocumentAiWarehouseDocumentSchemaPropertyDefinitionsBlock : TerraformBlock
{
    /// <summary>
    /// The display-name for the property, used for front-end.
    /// </summary>
    public TerraformProperty<string>? DisplayName
    {
        get => GetProperty<TerraformProperty<string>>("display_name");
        set => WithProperty("display_name", value);
    }

    /// <summary>
    /// Whether the property can be filtered. If this is a sub-property, all the parent properties must be marked filterable.
    /// </summary>
    public TerraformProperty<bool>? IsFilterable
    {
        get => GetProperty<TerraformProperty<bool>>("is_filterable");
        set => WithProperty("is_filterable", value);
    }

    /// <summary>
    /// Whether the property is user supplied metadata.
    /// </summary>
    public TerraformProperty<bool>? IsMetadata
    {
        get => GetProperty<TerraformProperty<bool>>("is_metadata");
        set => WithProperty("is_metadata", value);
    }

    /// <summary>
    /// Whether the property can have multiple values.
    /// </summary>
    public TerraformProperty<bool>? IsRepeatable
    {
        get => GetProperty<TerraformProperty<bool>>("is_repeatable");
        set => WithProperty("is_repeatable", value);
    }

    /// <summary>
    /// Whether the property is mandatory.
    /// </summary>
    public TerraformProperty<bool>? IsRequired
    {
        get => GetProperty<TerraformProperty<bool>>("is_required");
        set => WithProperty("is_required", value);
    }

    /// <summary>
    /// Indicates that the property should be included in a global search.
    /// </summary>
    public TerraformProperty<bool>? IsSearchable
    {
        get => GetProperty<TerraformProperty<bool>>("is_searchable");
        set => WithProperty("is_searchable", value);
    }

    /// <summary>
    /// The name of the metadata property.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// Stores the retrieval importance. Possible values: [&amp;quot;HIGHEST&amp;quot;, &amp;quot;HIGHER&amp;quot;, &amp;quot;HIGH&amp;quot;, &amp;quot;MEDIUM&amp;quot;, &amp;quot;LOW&amp;quot;, &amp;quot;LOWEST&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? RetrievalImportance
    {
        get => GetProperty<TerraformProperty<string>>("retrieval_importance");
        set => WithProperty("retrieval_importance", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleDocumentAiWarehouseDocumentSchemaTimeoutsBlock : TerraformBlock
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

}

/// <summary>
/// Manages a google_document_ai_warehouse_document_schema resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleDocumentAiWarehouseDocumentSchema : TerraformResource
{
    public GoogleDocumentAiWarehouseDocumentSchema(string name) : base("google_document_ai_warehouse_document_schema", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("name");
    }

    /// <summary>
    /// Name of the schema given by the user.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformProperty<string> DisplayName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
    }

    /// <summary>
    /// Tells whether the document is a folder or a typical document.
    /// </summary>
    public TerraformProperty<bool>? DocumentIsFolder
    {
        get => GetProperty<TerraformProperty<bool>>("document_is_folder");
        set => this.WithProperty("document_is_folder", value);
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
    /// The location of the resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The unique identifier of the project.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProjectNumber is required")]
    public required TerraformProperty<string> ProjectNumber
    {
        get => GetRequiredProperty<TerraformProperty<string>>("project_number");
        set => this.WithProperty("project_number", value);
    }

    /// <summary>
    /// Block for property_definitions.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 PropertyDefinitions block(s) required")]
    public List<GoogleDocumentAiWarehouseDocumentSchemaPropertyDefinitionsBlock>? PropertyDefinitions
    {
        get => GetProperty<List<GoogleDocumentAiWarehouseDocumentSchemaPropertyDefinitionsBlock>>("property_definitions");
        set => this.WithProperty("property_definitions", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleDocumentAiWarehouseDocumentSchemaTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleDocumentAiWarehouseDocumentSchemaTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The resource name of the document schema.
    /// </summary>
    public TerraformExpression Name => this["name"];

}
