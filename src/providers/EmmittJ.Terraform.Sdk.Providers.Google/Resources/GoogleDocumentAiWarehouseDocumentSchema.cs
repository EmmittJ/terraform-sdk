using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for property_definitions in .
/// Nesting mode: list
/// </summary>
public class GoogleDocumentAiWarehouseDocumentSchemaPropertyDefinitionsBlock : ITerraformBlock
{
    /// <summary>
    /// The display-name for the property, used for front-end.
    /// </summary>
    [TerraformPropertyName("display_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DisplayName { get; set; }

    /// <summary>
    /// Whether the property can be filtered. If this is a sub-property, all the parent properties must be marked filterable.
    /// </summary>
    [TerraformPropertyName("is_filterable")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? IsFilterable { get; set; }

    /// <summary>
    /// Whether the property is user supplied metadata.
    /// </summary>
    [TerraformPropertyName("is_metadata")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? IsMetadata { get; set; }

    /// <summary>
    /// Whether the property can have multiple values.
    /// </summary>
    [TerraformPropertyName("is_repeatable")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? IsRepeatable { get; set; }

    /// <summary>
    /// Whether the property is mandatory.
    /// </summary>
    [TerraformPropertyName("is_required")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? IsRequired { get; set; }

    /// <summary>
    /// Indicates that the property should be included in a global search.
    /// </summary>
    [TerraformPropertyName("is_searchable")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? IsSearchable { get; set; }

    /// <summary>
    /// The name of the metadata property.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// Stores the retrieval importance. Possible values: [&amp;quot;HIGHEST&amp;quot;, &amp;quot;HIGHER&amp;quot;, &amp;quot;HIGH&amp;quot;, &amp;quot;MEDIUM&amp;quot;, &amp;quot;LOW&amp;quot;, &amp;quot;LOWEST&amp;quot;]
    /// </summary>
    [TerraformPropertyName("retrieval_importance")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? RetrievalImportance { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleDocumentAiWarehouseDocumentSchemaTimeoutsBlock : ITerraformBlock
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

}

/// <summary>
/// Manages a google_document_ai_warehouse_document_schema resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleDocumentAiWarehouseDocumentSchema : TerraformResource
{
    public GoogleDocumentAiWarehouseDocumentSchema(string name) : base("google_document_ai_warehouse_document_schema", name)
    {
    }

    /// <summary>
    /// Name of the schema given by the user.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformPropertyName("display_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DisplayName { get; set; }

    /// <summary>
    /// Tells whether the document is a folder or a typical document.
    /// </summary>
    [TerraformPropertyName("document_is_folder")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? DocumentIsFolder { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The location of the resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Location { get; set; }

    /// <summary>
    /// The unique identifier of the project.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProjectNumber is required")]
    [TerraformPropertyName("project_number")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ProjectNumber { get; set; }

    /// <summary>
    /// Block for property_definitions.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PropertyDefinitions is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 PropertyDefinitions block(s) required")]
    [TerraformPropertyName("property_definitions")]
    public TerraformList<TerraformBlock<GoogleDocumentAiWarehouseDocumentSchemaPropertyDefinitionsBlock>>? PropertyDefinitions { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleDocumentAiWarehouseDocumentSchemaTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The resource name of the document schema.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Name => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

}
