using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for property_definitions in .
/// Nesting mode: list
/// </summary>
public partial class GoogleDocumentAiWarehouseDocumentSchemaPropertyDefinitionsBlock : TerraformBlockBase
{
    /// <summary>
    /// The display-name for the property, used for front-end.
    /// </summary>
    [TerraformProperty("display_name")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? DisplayName { get; set; }

    /// <summary>
    /// Whether the property can be filtered. If this is a sub-property, all the parent properties must be marked filterable.
    /// </summary>
    [TerraformProperty("is_filterable")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? IsFilterable { get; set; }

    /// <summary>
    /// Whether the property is user supplied metadata.
    /// </summary>
    [TerraformProperty("is_metadata")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? IsMetadata { get; set; }

    /// <summary>
    /// Whether the property can have multiple values.
    /// </summary>
    [TerraformProperty("is_repeatable")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? IsRepeatable { get; set; }

    /// <summary>
    /// Whether the property is mandatory.
    /// </summary>
    [TerraformProperty("is_required")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? IsRequired { get; set; }

    /// <summary>
    /// Indicates that the property should be included in a global search.
    /// </summary>
    [TerraformProperty("is_searchable")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? IsSearchable { get; set; }

    /// <summary>
    /// The name of the metadata property.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Stores the retrieval importance. Possible values: [&amp;quot;HIGHEST&amp;quot;, &amp;quot;HIGHER&amp;quot;, &amp;quot;HIGH&amp;quot;, &amp;quot;MEDIUM&amp;quot;, &amp;quot;LOW&amp;quot;, &amp;quot;LOWEST&amp;quot;]
    /// </summary>
    [TerraformProperty("retrieval_importance")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? RetrievalImportance { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleDocumentAiWarehouseDocumentSchemaTimeoutsBlock : TerraformBlockBase
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

}

/// <summary>
/// Manages a google_document_ai_warehouse_document_schema resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleDocumentAiWarehouseDocumentSchema : TerraformResource
{
    public GoogleDocumentAiWarehouseDocumentSchema(string name) : base("google_document_ai_warehouse_document_schema", name)
    {
    }

    /// <summary>
    /// Name of the schema given by the user.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformProperty("display_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> DisplayName { get; set; }

    /// <summary>
    /// Tells whether the document is a folder or a typical document.
    /// </summary>
    [TerraformProperty("document_is_folder")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? DocumentIsFolder { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The location of the resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The unique identifier of the project.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProjectNumber is required")]
    [TerraformProperty("project_number")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ProjectNumber { get; set; }

    /// <summary>
    /// Block for property_definitions.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PropertyDefinitions is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 PropertyDefinitions block(s) required")]
    [TerraformProperty("property_definitions")]
    public TerraformList<TerraformBlock<GoogleDocumentAiWarehouseDocumentSchemaPropertyDefinitionsBlock>>? PropertyDefinitions { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<GoogleDocumentAiWarehouseDocumentSchemaTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The resource name of the document schema.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Name { get; }

}
