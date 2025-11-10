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
        set => SetProperty("display_name", value);
    }

    /// <summary>
    /// Whether the property can be filtered. If this is a sub-property, all the parent properties must be marked filterable.
    /// </summary>
    public TerraformProperty<bool>? IsFilterable
    {
        set => SetProperty("is_filterable", value);
    }

    /// <summary>
    /// Whether the property is user supplied metadata.
    /// </summary>
    public TerraformProperty<bool>? IsMetadata
    {
        set => SetProperty("is_metadata", value);
    }

    /// <summary>
    /// Whether the property can have multiple values.
    /// </summary>
    public TerraformProperty<bool>? IsRepeatable
    {
        set => SetProperty("is_repeatable", value);
    }

    /// <summary>
    /// Whether the property is mandatory.
    /// </summary>
    public TerraformProperty<bool>? IsRequired
    {
        set => SetProperty("is_required", value);
    }

    /// <summary>
    /// Indicates that the property should be included in a global search.
    /// </summary>
    public TerraformProperty<bool>? IsSearchable
    {
        set => SetProperty("is_searchable", value);
    }

    /// <summary>
    /// The name of the metadata property.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        set => SetProperty("name", value);
    }

    /// <summary>
    /// Stores the retrieval importance. Possible values: [&amp;quot;HIGHEST&amp;quot;, &amp;quot;HIGHER&amp;quot;, &amp;quot;HIGH&amp;quot;, &amp;quot;MEDIUM&amp;quot;, &amp;quot;LOW&amp;quot;, &amp;quot;LOWEST&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? RetrievalImportance
    {
        set => SetProperty("retrieval_importance", value);
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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
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
        SetOutput("name");
        SetOutput("display_name");
        SetOutput("document_is_folder");
        SetOutput("id");
        SetOutput("location");
        SetOutput("project_number");
    }

    /// <summary>
    /// Name of the schema given by the user.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformProperty<string> DisplayName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("display_name");
        set => SetProperty("display_name", value);
    }

    /// <summary>
    /// Tells whether the document is a folder or a typical document.
    /// </summary>
    public TerraformProperty<bool> DocumentIsFolder
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("document_is_folder");
        set => SetProperty("document_is_folder", value);
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
    /// The location of the resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The unique identifier of the project.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProjectNumber is required")]
    public required TerraformProperty<string> ProjectNumber
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project_number");
        set => SetProperty("project_number", value);
    }

    /// <summary>
    /// Block for property_definitions.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PropertyDefinitions is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 PropertyDefinitions block(s) required")]
    public List<GoogleDocumentAiWarehouseDocumentSchemaPropertyDefinitionsBlock>? PropertyDefinitions
    {
        set => SetProperty("property_definitions", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleDocumentAiWarehouseDocumentSchemaTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The resource name of the document schema.
    /// </summary>
    public TerraformExpression Name => this["name"];

}
